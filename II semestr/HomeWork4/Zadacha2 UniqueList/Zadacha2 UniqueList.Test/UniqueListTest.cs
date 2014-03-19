namespace Zadacha2_UniqueList.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UniqueListNamespace;

    [TestClass]
    public class UniqueListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            uniqueList = new UniqueList();
        }

        /// <summary>
        /// Insert to head of unique list element 5.
        /// If insert element 5 again, exception must work.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ExceptionExistElement))]
        public void InsertToHeadTest()
        {
            uniqueList.InsertToHead(5);   
            uniqueList.InsertToHead(5);
        }

        /// <summary>
        /// Insert to head of unique list element 1.
        /// If insert element 1 in position 1, it must work the exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ExceptionExistElement))]
        public void InsertToPositionTest()
        {
            uniqueList.InsertToHead(1);
            uniqueList.InsertToPosition(1, 1);
        }

        /// <summary>
        /// If remove element from the empty unique list,
        /// it must work the exception.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ExceptionNotThisElement))]
        public void RemoveElementTest()
        {
            uniqueList.RemoveElement(0);
        }

        /// <summary>
        /// Insert to position as list.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ExceptionExistElement))]
        public void InsertToPositionTestAsList()
        {
            uniqueList.InsertToHead(1);
            (uniqueList as List).InsertToPosition(1, 1);
        }

        private UniqueList uniqueList;
    }
}
