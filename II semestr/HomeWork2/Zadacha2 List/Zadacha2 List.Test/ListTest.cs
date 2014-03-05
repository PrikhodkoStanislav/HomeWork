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

        /// <summary>
        /// Insert to head elements and value of position 2 must be 2.
        /// </summary>
        [TestMethod]
        public void ValueOfPositionTest()
        {
            list.InsertToHead(4);
            list.InsertToHead(3);
            list.InsertToHead(2);
            list.InsertToHead(1);
            list.InsertToHead(0);
            Assert.AreEqual(2, list.ValueOfPosition(2));
        }

        /// <summary>
        /// In empty stack value of any position must be -1.
        /// </summary>
        [TestMethod]
        public void ValueOfPositionInEmptyListTest()
        {
            Assert.AreEqual(-1, list.ValueOfPosition(5));
        }



        private List list;
    }
}
