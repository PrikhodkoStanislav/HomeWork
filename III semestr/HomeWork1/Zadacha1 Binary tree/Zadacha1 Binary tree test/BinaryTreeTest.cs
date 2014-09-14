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
            tree = new BinaryTree();
        }

        /// <summary>
        /// Add element in the tree and this element must be in the tree.
        /// </summary>
        [TestMethod]
        public void AddElementTest()
        {
            tree.AddElement(1);
            Assert.IsTrue(tree.ExistElement(1));
        }

        /// <summary>
        /// In empty tree must not be value.
        /// Add element.
        /// Element must be in the tree.
        /// </summary>
        [TestMethod]
        public void ExistElementTest()
        {
            Assert.IsFalse(tree.ExistElement(1));
            tree.AddElement(1);
            Assert.IsTrue(tree.ExistElement(1));
        }

        /// <summary>
        /// Add element. Remove element. This element must not be in the tree.
        /// </summary>
        [TestMethod]
        public void RemoveElementTest()
        {
            tree.AddElement(1);
            Assert.IsTrue(tree.ExistElement(1));
            tree.RemoveElement(1);
            Assert.IsFalse(tree.ExistElement(1));
        }

        /// <summary>
        /// Add elements in the tree and check order of element.
        /// </summary>
        [TestMethod]
        public void EnumeratorTest()
        {
            tree.AddElement(5);
            tree.AddElement(3);
            tree.AddElement(7);
            tree.AddElement(4);
            tree.AddElement(2);
            tree.AddElement(6);
            tree.AddElement(8);
            int[] arrayOfElements = new int[7];
            int i = 0;
            foreach (TreeElement element in tree)
            {
                arrayOfElements[i] = element.value;
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

        private BinaryTree tree;
    }
}
