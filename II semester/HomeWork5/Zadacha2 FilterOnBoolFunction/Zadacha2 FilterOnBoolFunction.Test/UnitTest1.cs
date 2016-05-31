namespace Zadacha2_FilterOnBoolFunction.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using FunctionNamespace;

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initizlize()
        {
            function = new Function();
        }

        /// <summary>
        /// Test on divisible by two.
        /// </summary>
        [TestMethod]
        public void FilterOnDivisibleByTwoTest()
        {
            modelList = new List<int>() { 2, 4 };
            CollectionAssert.AreEqual(modelList, function.Filter(new List<int>() { 1, 2, 3, 4, 5 }, x => (x % 2) == 0));
        }

        /// <summary>
        /// Filter on element 1.
        /// </summary>
        [TestMethod]
        public void FilterOnOneTest()
        {
            modelList = new List<int>() { 1, 1, 1 };
            CollectionAssert.AreEqual(modelList, function.Filter(new List<int>() { 1, 2, 1, 3, 4, 5, 1 }, x => x == 1));
        }

        private Function function;
        private List<int> modelList;
    }
}
