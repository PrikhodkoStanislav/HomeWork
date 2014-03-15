﻿namespace CalculatorTestNamespace
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CalculatorNamespace;

    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        {
            calc = new Calculator(true);
            calc2 = new Calculator(false);
        }

        /// <summary>
        /// Add element 5 and result must be 5.
        /// </summary>
        [TestMethod]
        public void AddElementTest()
        {
            calc.AddElement(5);
            Assert.AreEqual(5, calc.ReturnResult());
            calc2.AddElement(5);
            Assert.AreEqual(5, calc2.ReturnResult());
        }

        /// <summary>
        /// Add elements 5 and 10, add elements and result must be 15.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            calc.AddElement(5);
            calc.AddElement(10);
            calc.Add();
            Assert.AreEqual(15, calc.ReturnResult());
            calc2.AddElement(5);
            calc2.AddElement(10);
            calc2.Add();
            Assert.AreEqual(15, calc2.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 7, subtract 7 from 10 and result must be 3.
        /// </summary>
        [TestMethod]
        public void SubtractTest()
        {
            calc.AddElement(10);
            calc.AddElement(7);
            calc.Subtract();
            Assert.AreEqual(3, calc.ReturnResult());
            calc2.AddElement(10);
            calc2.AddElement(7);
            calc2.Subtract();
            Assert.AreEqual(3, calc2.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 2, divide 10 by 2 and result must be 5.
        /// </summary>
        [TestMethod]
        public void DivisionTest()
        {
            calc.AddElement(10);
            calc.AddElement(2);
            calc.Division();
            Assert.AreEqual(5, calc.ReturnResult());
            calc2.AddElement(10);
            calc2.AddElement(2);
            calc2.Division();
            Assert.AreEqual(5, calc2.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 5, multiply them and result must be 50.
        /// </summary>
        [TestMethod]
        public void MultiplicationTest()
        {
            calc.AddElement(10);
            calc.AddElement(5);
            calc.Multiplication();
            Assert.AreEqual(50, calc.ReturnResult());
            calc2.AddElement(10);
            calc2.AddElement(5);
            calc2.Multiplication();
            Assert.AreEqual(50, calc2.ReturnResult());
        }

        private Calculator calc;
        private Calculator calc2;
    }
}
