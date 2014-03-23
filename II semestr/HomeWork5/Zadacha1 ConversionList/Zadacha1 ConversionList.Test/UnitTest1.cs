namespace FunctionNamespace.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using FunctionNamespace;
    using System.Collections.Generic;

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List<int>();
            function = new Function();
        }

        /// <summary>
        /// Multiply all elements of the list by two.
        /// </summary>
        [TestMethod]
        public void MultiplyByTwoTest()
        {
            modelList = new List<int>() {2, 4, 6};
            CollectionAssert.AreEqual(modelList, function.Map(new List<int>() { 1, 2, 3 }, x => x * 2));
        }

        /// <summary>
        /// Squaring elements of the list.
        /// </summary>
        [TestMethod]
        public void SquaringTest()
        {
            modelList = new List<int>() { 4, 16, 36 };
            CollectionAssert.AreEqual(modelList, function.Map(new List<int>() { 2, 4, 6 }, x => x * x));
        }

        private Function function;
        private List<int> list;
        private List<int> modelList;
    }
}
