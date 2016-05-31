namespace ShablonSort.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SortNamespace;
    using InterfaceNamespace;

    [TestClass]
    public class ShablonSortTest
    {
        [TestInitialize]
        public void Initialize()
        {
            sort = new Sort<string>();
            sortInt = new Sort<int>();
            arrayOfString = new string[10];
            arrayOfInt = new int[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 10; j > i; j--)
                {
                    arrayOfString[i] += "a";
                }
            }
            for (int i = 0; i < 10; i++)
            {
                arrayOfInt[i] = 50 - (2 * i);
            }
            comparator = new ComparatorString();
            comparatorInt = new ComparatorInt();
        }

        /// <summary>
        /// Sort array of string in ascending length.
        /// </summary>
        [TestMethod]
        public void SortStringTest()
        {
            string sourceString = "a";
            for (int i = 9; i >= 0; i--)
            {
                Assert.AreEqual(sourceString, arrayOfString[i]);
                sourceString += "a";
            }
            sort.SortArray(ref arrayOfString, 10, comparator);
            sourceString = "a";
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(sourceString, arrayOfString[i]);
                sourceString += "a";
            }
        }

        /// <summary>
        /// Sort array of int in ascending elements.
        /// </summary>
        [TestMethod]
        public void SortIntTest()
        {
            sortInt.SortArray(ref arrayOfInt, 10, comparatorInt);
            int number = 32;
            for (int i = 0; i < 10; i++)
            {
                Assert.AreEqual(number, arrayOfInt[i]);
                number += 2;
            }
        }

        private Sort<string> sort;
        private Sort<int> sortInt;
        private string[] arrayOfString;
        private int[] arrayOfInt;
        private InterfaceComparator<string> comparator;
        private InterfaceComparator<int> comparatorInt;
    }
}
