namespace CalculatorTestNamespace
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using CalculatorNamespace;
    using StackNamespace;

    [TestClass]
    public class CalculatorTest
    {
        [TestInitialize]
        public void Initialize()
        { 
            Stack stackOnReferences = new StackOnReference();
            Stack stackOnArray = new StackOnArray();

            calcOnReferences = new Calculator(stackOnReferences);
            calcOnArray = new Calculator(stackOnArray); 
        }

        /// <summary>
        /// Add element 5 and result must be 5.
        /// </summary>
        [TestMethod]
        public void AddElementTest()
        {
            calcOnReferences.AddElement(5);
            Assert.AreEqual(5, calcOnReferences.ReturnResult());

            calcOnArray.AddElement(5);
            Assert.AreEqual(5, calcOnArray.ReturnResult());
        }

        /// <summary>
        /// Add elements 5 and 10, add elements and result must be 15.
        /// </summary>
        [TestMethod]
        public void AddTest()
        {
            calcOnReferences.AddElement(5);
            calcOnReferences.AddElement(10);
            calcOnReferences.Add();
            Assert.AreEqual(15, calcOnReferences.ReturnResult());

            calcOnArray.AddElement(5);
            calcOnArray.AddElement(10);
            calcOnArray.Add();
            Assert.AreEqual(15, calcOnArray.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 7, subtract 7 from 10 and result must be 3.
        /// </summary>
        [TestMethod]
        public void SubtractTest()
        {
            calcOnReferences.AddElement(10);
            calcOnReferences.AddElement(7);
            calcOnReferences.Subtract();
            Assert.AreEqual(3, calcOnReferences.ReturnResult());

            calcOnArray.AddElement(10);
            calcOnArray.AddElement(7);
            calcOnArray.Subtract();
            Assert.AreEqual(3, calcOnArray.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 2, divide 10 by 2 and result must be 5.
        /// </summary>
        [TestMethod]
        public void DivisionTest()
        {
            calcOnReferences.AddElement(10);
            calcOnReferences.AddElement(2);
            calcOnReferences.Division();
            Assert.AreEqual(5, calcOnReferences.ReturnResult());

            calcOnArray.AddElement(10);
            calcOnArray.AddElement(2);
            calcOnArray.Division();
            Assert.AreEqual(5, calcOnArray.ReturnResult());
        }

        /// <summary>
        /// Add elements 10 and 5, multiply them and result must be 50.
        /// </summary>
        [TestMethod]
        public void MultiplicationTest()
        {
            calcOnReferences.AddElement(10);
            calcOnReferences.AddElement(5);
            calcOnReferences.Multiplication();
            Assert.AreEqual(50, calcOnReferences.ReturnResult());

            calcOnArray.AddElement(10);
            calcOnArray.AddElement(5);
            calcOnArray.Multiplication();
            Assert.AreEqual(50, calcOnArray.ReturnResult());
        }

        private Calculator calcOnReferences;
        private Calculator calcOnArray;
    }
}
