using System;
using System.Collections.Generic;
using CadPlugin.Builders;
using NUnit.Framework;
using UnitTests.Stubs;

namespace UnitTests
{
    /// <summary>
    /// Тесты параметров ножек стола
    /// </summary>
    [TestFixture]
    public class TableTopBuilderTests
    {
        #region Private Fields

        private readonly ModelDocStub _modelDoc = new ModelDocStub();

        private readonly Dictionary<string, double> _parametersCorrect = new Dictionary<string, double>()
        {
            {"Top Width", 0.75 },
            {"Top Length", 0.75 },
            {"Top Height", 0.05 },
        };

        #endregion

        /// <summary>
        /// Тест на корректных данных
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест с корректными данными")]
        public void TestTopBuilderCorrectData()
        {
            Assert.DoesNotThrow(() =>
            {
                var builder = new TableTopBuilder(_modelDoc, _parametersCorrect);
            });
        }

        #region Tests that throw something

        /// <summary>
        /// Тест на документе null
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если modelDoc null")]
        public void TestConstructorThrowsModelDocNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                var tableTopBuilder = new TableTopBuilder(null, _parametersCorrect);
            });
        }

        /// <summary>
        /// Тест на параметрах крышки стола null
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если parameters null")]
        public void TestConstructorThrowsParamsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                var tableTopBuilder = new TableTopBuilder(_modelDoc, null);
            });
        }

        /// <summary>
        /// Тест на пустых параметрах крышки стола
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если parameters пустая")]
        public void TestConstructorThrowsTopParamsEmpty()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var tableTopBuilder = new TableTopBuilder(_modelDoc, new Dictionary<string, double>());
            });
            Assert.That(exception.Message, Is.EqualTo("parameters are empty"));
        }

        #endregion


    }
}
