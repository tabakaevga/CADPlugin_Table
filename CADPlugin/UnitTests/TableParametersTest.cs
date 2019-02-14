using System;
using System.Collections.Generic;
using CadPlugin.Parameters;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class TableParametersTest
    {
        #region Private Fields

        private readonly Dictionary<string, double> _parametersCorrect =  new Dictionary<string, double>
        {
                {"Top Width",       0.75 },
                {"Top Length",      0.75 },
                {"Top Height",      0.05 },
                {"Edge Offset",     0.1  },
                {"Legs Height",     0.75 },
                {"Legs Radius",     0.05 },
                {"Strut Height",    0.2 },
                {"Strut Thickness", 0.03 }
        };

        private readonly Dictionary<string, double> _parametersIncorrectNamings = new Dictionary<string, double>
        {
                {"Top Width", 0.75},
                {"Top Length", 0.75},
                {"Not Height", 0.05},
                {"Legs Height", 0.75},
                {"Edge Offset", 0.055},
                {"Legs Radius", 0.05},
                {"Strut Height", 200},
                {"Strut Thickness", 0.5}
        };


        private readonly Dictionary<string, double> _parametersIncorrectValues = new Dictionary<string, double>()
        {
            {"Top Width", -0.75},
            {"Top Length", 0.75},
            {"Top Height", 500},
            {"Legs Radius", -0.75},
            {"Edge Offset", 0.05},
            {"Legs Height", 5000},
            {"Strut Height", 200},
            {"Strut Thickness", 0.5}
        };

        #endregion

        /// <summary>
        /// Тест параметров ножек по диапазонам
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на корректных данных")]
        public void TestParametersCorrect()
        {
            Assert.DoesNotThrow(() =>
                {
                    var tableParameters = new TableParameters()
                    {
                        Parameters = _parametersCorrect
                    };
                }
            );
        }

        #region Tests for incorrect data

        /// <summary>
        /// Тест параметров ножек по диапазонам
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если параметры не входят в диапазоны")]
        public void TestParametersIncorrectParameters()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var tableParameters = new TableParameters()
                {
                    Parameters =  _parametersIncorrectValues
                };
            });

            Assert.That(exception.Message, 
                Is.EqualTo("Table Top Width is lower than 700mm. " +
                           "\nTable Top Height is higher than 100mm. " +
                           "\nTable Legs Radius is lower than 50mm. " +
                           "\nTable Legs Height is higher than 1000mm. " +
                           "\nTable Strut Thickness is higher than " +
                           "-750mm. \n"));
        }

        /// <summary>
        /// Тест параметров ножек по соответствию ключей
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если параметры содержат неверный ключ")]
        public void TestParametersIncorrectNaming()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var tableParameters = new TableParameters
                {
                    Parameters = _parametersIncorrectNamings
                };
            });
            Assert.That(exception.Message, Is.EqualTo("No Not Height in this class' Parameters"));
        }

        #endregion
    }
}
