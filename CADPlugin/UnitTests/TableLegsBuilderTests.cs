﻿using System;
using System.Collections.Generic;
using CadPlugin.Builders;
using NUnit.Framework;
using UnitTests.Stubs;

namespace UnitTests
{
    /// <summary>
    /// Тест построителя ножек стола
    /// </summary>
    [TestFixture]
    class TableLegsBuilderTests
    {
        #region Private Fields

        private readonly ModelDocStub _modelDoc = new ModelDocStub();

        private readonly Dictionary<string, double> _legsParametersCorrect = new Dictionary<string, double>
        {
            {"Top Width", 0.75},
            {"Top Length", 0.75},
            {"Edge Offset", 0.1},
            {"Legs Height", 0.75},
            {"Legs Radius", 0.05}
        };

        #endregion

        /// <summary>
        /// Тест на корректных данных
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест с корректными данными")]
        public void TestLegsBuilderCorrectData()
        {
            Assert.DoesNotThrow(() =>
            {
                var builder = new TableLegsBuilder(_modelDoc, _legsParametersCorrect);
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
                var tableLegsBuilder = new TableLegsBuilder(null, _legsParametersCorrect);
            });
        }

        /// <summary>
        /// Тест на параметрах ножек null
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если parameters null")]
        public void TestConstructorThrowsTopParamsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() =>
            {
                var tableLegsBuilder = new TableLegsBuilder(_modelDoc, null);
            });
        }

        /// <summary>
        /// Тест на пустых параметрах стола
        /// </summary>
        [Test]
        [TestCase(TestName = "Тест на исключение, если parameters пустая")]
        public void TestConstructorThrowsTopParamsEmpty()
        {
            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var tableLegsBuilder = new TableLegsBuilder(_modelDoc, new Dictionary<string, double>());
            });
            Assert.That(exception.Message, Is.EqualTo("parameters are empty"));
        }

        #endregion
    }
}
