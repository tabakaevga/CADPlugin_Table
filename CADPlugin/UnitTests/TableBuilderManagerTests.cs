using System;
using System.Collections.Generic;
using System.Linq;
using CadPlugin.Builders;
using CadPlugin.Parameters;
using NUnit.Framework;
using SldWorks;
using UnitTests.Stubs;

namespace UnitTests
{
    /// <summary>
    /// Тесты менеджера построителя
    /// </summary>
    [TestFixture]
    public class TableBuilderManagerTests
    {
        #region Private fields

        private readonly IModelDoc2 _modelDocStub = new ModelDocStub();

        private readonly TableParameters _parametersCorrect = new TableParameters()
        {
            Parameters = new Dictionary<string, double>
            {
                {"Top Width", 0.75},
                {"Top Length", 0.75},
                {"Top Height", 0.05},
                {"Edge Offset", 0.1},
                {"Legs Height", 0.75},
                {"Legs Radius", 0.05},
                {"Strut Height", 0.2},
                {"Strut Thickness", 0.03}
            }
        };

        #endregion

        /// <summary>
        /// Тест на корректных данных. Ножки без усилений
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест с корректными данными. Ножки без усилений")]
        public void TestCorrectData()
        {
            Assert.DoesNotThrow(() =>
            {
                var parameters = new TableParameters()
                {
                    Parameters = _parametersCorrect.Parameters.Select(t => new { t.Key, t.Value})
                        .Where(t => !t.Key.Contains("Strut"))
                        .ToDictionary(t => t.Key, t => t.Value)
                };
                var tableBuilderManager = new TableBuilderManager(_modelDocStub, parameters);
            });
        }

        /// <summary>
        /// Тест на корректных данных. Ножки с усилениями
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест с корректными данными. Ножки с усилениями")]
        public void TestCorrectDataWithStruts()
        {
            Assert.DoesNotThrow(() =>
            {
                var tableBuilderManager = new TableBuilderManager(_modelDocStub,
                    _parametersCorrect);
            });
        }

        #region Tests for null or empty

        /// <summary>
        /// Тест на параметрах null
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если parameters null")]
        public void TestConstructorThrowsTopParamsNull()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                var tableBuilderManager = new TableBuilderManager(_modelDocStub, null);
            }, "parameters are null");
        }

        /// <summary>
        /// Тест на документе null
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если modelDoc null")]
        public void TestConstructorThrowsModelDocNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var tableBuilderManager = new TableBuilderManager(null, _parametersCorrect);
            }, "modelDoc is null");
        }

        #endregion

        

    }
}
