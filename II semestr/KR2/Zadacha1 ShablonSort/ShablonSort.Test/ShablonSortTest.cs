using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortNamespace;
using InterfaceNamespace;


namespace ShablonSort.Test
{
    using System.Collections;
    using System.Collections.Generic;

    [TestClass]
    public class ShablonSortTest
    {
        [TestInitialize]
        public void Initialize()
        {
            sort = new Sort();
            arrayOfString = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    arrayOfString[i] += "a";
                }
            }
            comparator = new ComparatorString();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("a", arrayOfString[1]);
            sort.SortArray(arrayOfString, 10, comparator);
            Assert.AreEqual("a", arrayOfString[8]);
        }

        private Sort sort;
        private ArrayList arrayOfString;
        private InterfaceComparator comparator;
    }
}
