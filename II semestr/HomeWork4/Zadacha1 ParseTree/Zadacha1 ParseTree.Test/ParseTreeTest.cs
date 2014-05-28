namespace Zadacha1_ParseTree.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using ParseTreeNamespace;
    using System.IO;

    [TestClass]
    public class ParseTreeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            tree = new Tree();
        }

        /// <summary>
        /// Parse tree expression.
        /// Print tree and count result of expression.
        /// </summary>
        [TestMethod]
        public void ParseTreeExpressionTest()
        {
            string expression = "(*(+11)2)";
            tree.WriteInTree(expression);
            Assert.AreEqual("( * ( + 1 1 ) 2 ) ", tree.Print());
            Assert.AreEqual(4, tree.ValueOfExpression());
        }

        /// <summary>
        /// Exception : division by 0.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ExceptionDivisionBy0))]
        public void ParseTreeWithExceptionTest()
        {
            string expression = "(/10)";
            tree.WriteInTree(expression);
            Assert.AreEqual("( / 1 0 ) ", tree.Print());
            int result = tree.ValueOfExpression();
        }

        /// <summary>
        /// Parse tree new expression.
        /// Print tree and count result of expression.
        /// </summary>
        [TestMethod]
        public void ParseTreeNewExpressionTest()
        {
            string expression = "(+(+(/(-83)5)2)2)";
            tree.WriteInTree(expression);
            Assert.AreEqual("( + ( + ( / ( - 8 3 ) 5 ) 2 ) 2 ) ", tree.Print());
            Assert.AreEqual(5, tree.ValueOfExpression());
        }

        private Tree tree;
    }
}
