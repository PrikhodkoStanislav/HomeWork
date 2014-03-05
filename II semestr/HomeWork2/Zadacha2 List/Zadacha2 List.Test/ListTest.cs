namespace ListNamespace.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ListNamespace;

    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            list = new List();
        }

        /// <summary>
        /// Insert to head element 5 and list must be not empty.
        /// </summary>
        [TestMethod]
        public void InsertToHeadTest()
        {
            list.InsertToHead(5);
            Assert.IsFalse(list.IsEmpty());
        }

        /// <summary>
        /// Insert to head elements, remove list and list must be empty.
        /// </summary>
        [TestMethod]
        public void RemoveListTest()
        {
            list.InsertToHead(5);
            list.InsertToHead(10);
            list.InsertToHead(15);
            list.InsertToHead(20);
            list.RemoveList();
            Assert.IsTrue(list.IsEmpty());
        }

        /// <summary>
        /// Insert to head element 5 and it must be exist in the list.
        /// </summary>
        [TestMethod]
        public void ExistTest()
        {
            list.InsertToHead(5);
            Assert.IsTrue(list.Exist(5));
        }

        /// <summary>
        /// Source list must be empty.
        /// </summary>
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(list.IsEmpty());
        }

        private List list;
    }
}
