namespace Zadacha3_Fold.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using Zadacha3_FoldOnFunctionWithValue;

    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Initialize()
        {
            function = new Function();
        }

        /// <summary>
        /// Fold for list, element 1 and operation multiplication.
        /// </summary>
        [TestMethod]
        public void SortListValueOneMultiplyTest()
        {
            Assert.AreEqual(6, function.Fold(new List<int>() {1, 2, 3}, 1, (acc, elem) => acc * elem));
        }

        /// <summary>
        /// Folf for list, element 1 and operation addition.
        /// </summary>
        [TestMethod]
        public void SortListValueOneAdditionTest()
        {
            Assert.AreEqual(7, function.Fold(new List<int>() { 1, 2, 3 }, 1, (acc, elem) => acc + elem));
        }

        private Function function;
    }
}
