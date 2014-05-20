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
            list = new List<int>();
            list2 = new List<string>();
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
        /// In empty stack value of any position must be 0.
        /// </summary>
        [TestMethod]
        public void ValueOfPositionInEmptyListTest()
        {
            Assert.AreEqual(0, list.ValueOfPosition(5));
        }

        /// <summary>
        /// Insert elements to head and insert value 2 to position 2.
        /// In position 2 must be value 2.
        /// </summary>
        [TestMethod]
        public void InsertToPositionTest()
        {
            list.InsertToHead(4);
            list.InsertToHead(3);
            list.InsertToHead(1);
            list.InsertToHead(0);
            list.InsertToPosition(2, 2);
            Assert.AreEqual(2, list.ValueOfPosition(2));
        }

        /// <summary>
        /// Insert element 5 to big position in empty list.
        /// Value 5 must be in 0 posititon of the list.
        /// </summary>
        [TestMethod]
        public void InsertToPositionInEmptyListTest()
        {
            list.InsertToPosition(5, 2);
            Assert.AreEqual(5, list.ValueOfPosition(0));
        }

        /// <summary>
        /// Insert 3 elements to head of the list.
        /// Insert value 5 to position 15.
        /// Element 5 must be in position 3.
        /// </summary>
        [TestMethod]
        public void InsertToBigPositionInSmallListTest()
        {
            list.InsertToHead(3);
            list.InsertToHead(2);
            list.InsertToHead(1);
            list.InsertToPosition(5, 15);
            Assert.AreEqual(5, list.ValueOfPosition(3));
        }

        /// <summary>
        /// Insert elements 1 and 0 to head of the list.
        /// Insert value 2 to position 2.
        /// Remove element to position 1.
        /// Element 0 must be in 0 position.
        /// Element 2 must be in position 1.
        /// </summary>
        [TestMethod]
        public void RemoveElementToPositionTest()
        {
            list.InsertToHead(1);
            list.InsertToHead(0);
            list.InsertToPosition(2, 2);
            list.RemoveElementToPosition(1);
            Assert.AreEqual(0, list.ValueOfPosition(0));
            Assert.AreEqual(2, list.ValueOfPosition(1));
        }

        /// <summary>
        /// Insert elements 2, 1 and 0 to head of the list.
        /// Remove element to position 0.
        /// Element 1 must be in position 0.
        /// Element 2 must be in position 1.
        /// </summary>
        [TestMethod]
        public void RemoveElementToZeroPositionTest()
        {
            list.InsertToHead(2);
            list.InsertToHead(1);
            list.InsertToHead(0);
            list.RemoveElementToPosition(0);
            Assert.AreEqual(1, list.ValueOfPosition(0));
            Assert.AreEqual(2, list.ValueOfPosition(1));
        }

        /// <summary>
        /// Test for list of the strings.
        /// </summary>
        [TestMethod]
        public void ListOnStringTest()
        {
            /// new stack must be empty
            Assert.IsTrue(list2.IsEmpty());

            list2.InsertToHead("Hello!");
            list2.InsertToPosition("World!", 1);

            /// stack must be not empty
            Assert.IsFalse(list2.IsEmpty());

            /// "Hello!" must be in the list2
            Assert.IsTrue(list2.Exist("Hello!"));

            /// "World!" must be element 2 (on the position 1) in the list2.
            Assert.AreEqual("World!", list2.ValueOfPosition(1));

            /// on position 5 no element => return default(string)
            Assert.AreEqual(default(string), list2.ValueOfPosition(5));

            list2.RemoveElementToPosition(1);
            list2.InsertToHead("Summer!");

            /// "Hello!" now on the position 1
            Assert.AreEqual("Hello!", list2.ValueOfPosition(1));

            /// "Summer" on position 1
            Assert.AreEqual("Summer!", list2.ValueOfPosition(0));

            list2.RemoveList();

            /// element remove => empty
            Assert.IsTrue(list2.IsEmpty());
        }

        /// <summary>
        /// Test for list enumerator.
        /// </summary>
        [TestMethod]
        public void ListEnumeratorTest()
        {
            list.InsertToHead(5);
            list.InsertToHead(4);
            list.InsertToHead(3);
            list.InsertToHead(2);
            list.InsertToHead(1);
            int number = 0;
            foreach (int value in list)
            {
                number = value;
            }
            Assert.AreEqual(5, number);
        }

        private List<int> list;
        private List<string> list2;
    }
}