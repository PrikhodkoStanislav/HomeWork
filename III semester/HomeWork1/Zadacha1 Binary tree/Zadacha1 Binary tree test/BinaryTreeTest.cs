using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadacha1_Binary_tree;

namespace Zadacha1_Binary_tree_test
{
    [TestClass]
    public class BinaryTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            intTree = new BinaryTree<int>();
            stringTree = new BinaryTree<string>();
            compareInt = new CompareInt();
            compareString = new CompareString();
        }

        /// <summary>
        /// Add element with int type in the tree and this element must be in the tree.
        /// </summary>
        [TestMethod]
        public void AddElementIntTest()
        {
            intTree.AddElement(1, compareInt);
            Assert.IsTrue(intTree.ExistElement(1, compareInt));
        }

        /// <summary>
        /// Add element with string type in the tree and this element must be in the tree.
        /// </summary>
        [TestMethod]
        public void AddElementStringTest()
        {
            stringTree.AddElement("Hello", compareString);
            Assert.IsTrue(stringTree.ExistElement("Hello", compareString));
        }

        /// <summary>
        /// In empty tree must not be value.
        /// Add element with int type.
        /// Element must be in the tree.
        /// </summary>
        [TestMethod]
        public void ExistElementIntTest()
        {
            Assert.IsFalse(intTree.ExistElement(1, compareInt));
            intTree.AddElement(1, compareInt);
            Assert.IsTrue(intTree.ExistElement(1, compareInt));
        }

        /// <summary>
        /// In empty tree must not be value.
        /// Add element with string type.
        /// Element must be in the tree.
        /// </summary>
        [TestMethod]
        public void ExistElementStringTest()
        {
            Assert.IsFalse(stringTree.ExistElement("String", compareString));
            stringTree.AddElement("String", compareString);
            Assert.IsTrue(stringTree.ExistElement("String", compareString));
        }

        /// <summary>
        /// Add element with int type. Remove element. This element must not be in the tree.
        /// </summary>
        [TestMethod]
        public void RemoveElementIntTest()
        {
            intTree.AddElement(1, compareInt);
            Assert.IsTrue(intTree.ExistElement(1, compareInt));
            intTree.RemoveElement(1, compareInt);
            Assert.IsFalse(intTree.ExistElement(1, compareInt));
        }

        /// <summary>
        /// Add element with string type. Remove element. This element must not be in the tree.
        /// </summary>
        [TestMethod]
        public void RemoveElementStringTest()
        {
            stringTree.AddElement("Good test", compareString);
            Assert.IsTrue(stringTree.ExistElement("Good test", compareString));
            stringTree.RemoveElement("Good test", compareString);
            Assert.IsFalse(stringTree.ExistElement("Good test", compareString));
        }

        /// <summary>
        /// Add elements with int type in the tree and check order of element.
        /// </summary>
        [TestMethod]
        public void EnumeratorIntTest()
        {
            intTree.AddElement(5, compareInt);
            intTree.AddElement(3, compareInt);
            intTree.AddElement(7, compareInt);
            intTree.AddElement(4, compareInt);
            intTree.AddElement(2, compareInt);
            intTree.AddElement(6, compareInt);
            intTree.AddElement(8, compareInt);
            int[] arrayOfElements = new int[7];
            int i = 0;
            foreach (int element in intTree)
            {
                arrayOfElements[i] = element;
                i++;
            }
            Assert.AreEqual(5, arrayOfElements[0]);
            Assert.AreEqual(3, arrayOfElements[1]);
            Assert.AreEqual(2, arrayOfElements[2]);
            Assert.AreEqual(4, arrayOfElements[3]);
            Assert.AreEqual(7, arrayOfElements[4]);
            Assert.AreEqual(6, arrayOfElements[5]);
            Assert.AreEqual(8, arrayOfElements[6]);
        }

        /// <summary>
        /// Add elements with string type in the tree and check order of element.
        /// </summary>
        [TestMethod]
        public void EnumeratorStringTest()
        {
            stringTree.AddElement("5", compareString);
            stringTree.AddElement("3", compareString);
            stringTree.AddElement("7", compareString);
            stringTree.AddElement("4", compareString);
            stringTree.AddElement("2", compareString);
            stringTree.AddElement("6", compareString);
            stringTree.AddElement("8", compareString);
            string[] arrayOfElements = new string[7];
            int i = 0;
            foreach (string element in stringTree)
            {
                arrayOfElements[i] = element;
                i++;
            }
            Assert.AreEqual("5", arrayOfElements[0]);
            Assert.AreEqual("3", arrayOfElements[1]);
            Assert.AreEqual("2", arrayOfElements[2]);
            Assert.AreEqual("4", arrayOfElements[3]);
            Assert.AreEqual("7", arrayOfElements[4]);
            Assert.AreEqual("6", arrayOfElements[5]);
            Assert.AreEqual("8", arrayOfElements[6]);
        }

        private BinaryTree<int> intTree;
        private BinaryTree<string> stringTree;
        private CompareInterface<string> compareString;
        private CompareInterface<int> compareInt;
    }
}
