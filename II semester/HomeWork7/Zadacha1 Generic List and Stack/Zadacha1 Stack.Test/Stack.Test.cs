namespace StackNamespace.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using StackNamespace;

    [TestClass]
    public class ListTest
    {
        [TestInitialize]
        public void Initialize()
        {
            stack = new Stack<int>();
            stack2 = new Stack<char>();
        }

        /// <summary>
        /// Insert to head element 5 and stack must be not empty.
        /// </summary>
        [TestMethod]
        public void PushTest()
        {
            stack.Push(5);
            Assert.IsFalse(stack.IsEmpty());
        }

        /// <summary>
        /// Insert to head elements, remove stack and stack must be empty.
        /// </summary>
        [TestMethod]
        public void RemoveStackTest()
        {
            stack.Push(5);
            stack.Push(10);
            stack.Push(15);
            stack.Push(20);
            stack.RemoveStack();
            Assert.IsTrue(stack.IsEmpty());
        }

        /// <summary>
        /// Source stacks must be empty.
        /// </summary>
        [TestMethod]
        public void IsEmptyTest()
        {
            Assert.IsTrue(stack.IsEmpty());
            Assert.IsTrue(stack2.IsEmpty());
        }

        /// <summary>
        /// Test for pop from stack.
        /// </summary>
        [TestMethod]
        public void PopTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.AreEqual(5, stack.Pop());
            stack.Push(10);
            Assert.AreEqual(10, stack.Pop());
        }

        /// <summary>
        /// Test for peek from stack.
        /// </summary>
        [TestMethod]
        public void PeekTest()
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Assert.AreEqual(5, stack.Peek());
            Assert.AreEqual(5, stack.Peek());
            stack.Push(10);
            Assert.AreEqual(10, stack.Peek());
        }

        /// <summary>
        /// Insert to head element 'A' and stack must be not empty.
        /// </summary>
        [TestMethod]
        public void PushCharTest()
        {
            stack2.Push('A');
            Assert.IsFalse(stack2.IsEmpty());
        }

        /// <summary>
        /// Test for pop from stack with chars.
        /// </summary>
        [TestMethod]
        public void PopCharTest()
        {
            stack2.Push('A');
            stack2.Push('b');
            stack2.Push('C');
            stack2.Push('d');
            stack2.Push('E');
            Assert.AreEqual('E', stack2.Pop());
            stack2.Push('S');
            Assert.AreEqual('S', stack2.Pop());
        }

        /// <summary>
        /// Test for peek from stack with chars.
        /// </summary>
        [TestMethod]
        public void PeekCharTest()
        {
            stack2.Push('Q');
            stack2.Push('R');
            stack2.Push('e');
            stack2.Push('a');
            stack2.Push('l');
            Assert.AreEqual('l', stack2.Peek());
            Assert.AreEqual('l', stack2.Peek());
            stack2.Push('!');
            Assert.AreEqual('!', stack2.Peek());
        }

        private Stack<int> stack;
        private Stack<char> stack2;
    }
}