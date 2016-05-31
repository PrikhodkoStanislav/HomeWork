namespace MultitudeTestNamespace
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MultitudeNamespace;

    [TestClass]
    public class MultitudeTest
    {
        [TestInitialize]
        public void Initialize()
        {
            multitudeOfInt = new Multitude<int>();
            multitudeOfString = new Multitude<string>();
            multiInt = new Multitude<int>();
            multiString = new Multitude<string>();
        }

        /// <summary>
        /// Test for add elements in multitude of int.
        /// </summary>
        [TestMethod]
        public void AddIntTest()
        {
            multitudeOfInt.AddElement(1);
            Assert.IsTrue(multitudeOfInt.ExistElement(1));
        }

        /// <summary>
        /// Test for add elements in multitude of string.
        /// </summary>
        [TestMethod]
        public void AddStringTest()
        {
            multitudeOfString.AddElement("Hello!");
            Assert.IsTrue(multitudeOfString.ExistElement("Hello!"));
        }

        /// <summary>
        /// Test for exist element in multitude of int.
        /// </summary>
        [TestMethod]
        public void ExistIntTest()
        {
            Assert.IsFalse(multitudeOfInt.ExistElement(2));
            multitudeOfInt.AddElement(2);
            Assert.IsTrue(multitudeOfInt.ExistElement(2));
        }

        /// <summary>
        /// Test for exist element in multitude of string.
        /// </summary>
        [TestMethod]
        public void ExistStringTest()
        {
            Assert.IsFalse(multitudeOfString.ExistElement("World"));
            multitudeOfString.AddElement("World");
            Assert.IsTrue(multitudeOfString.ExistElement("World"));
        }

        /// <summary>
        /// Test for remove element in multitude of int.
        /// </summary>
        [TestMethod]
        public void RemoveIntTest()
        {
            multitudeOfInt.AddElement(10);
            Assert.IsTrue(multitudeOfInt.ExistElement(10));
            multitudeOfInt.RemoveElement(10);
            Assert.IsFalse(multitudeOfInt.ExistElement(10));
        }

        /// <summary>
        /// Test for remove element in multitude of string.
        /// </summary>
        [TestMethod]
        public void RemoveStringTest()
        {
            multitudeOfString.AddElement("World!");
            Assert.IsTrue(multitudeOfString.ExistElement("World!"));
            multitudeOfString.RemoveElement("World!");
            Assert.IsFalse(multitudeOfString.ExistElement("World!"));
        }

        /// <summary>
        /// Test for unification in multitude of int.
        /// </summary>
        [TestMethod]
        public void UnificationIntTest()
        {
            multitudeOfInt.AddElement(10);
            multiInt.AddElement(20);
            multitudeOfInt.Unification(multiInt);
            Assert.IsTrue(multitudeOfInt.ExistElement(10));
            Assert.IsTrue(multitudeOfInt.ExistElement(20));
        }

        /// <summary>
        /// Test for unification in multitude of string.
        /// </summary>
        [TestMethod]
        public void UnificationStringTest()
        {
            multitudeOfString.AddElement("Hi");
            multiString.AddElement("Hello");
            multiString.AddElement("World");
            multitudeOfString.Unification(multiString);
            Assert.IsTrue(multitudeOfString.ExistElement("World"));
            Assert.IsTrue(multitudeOfString.ExistElement("Hello"));
            Assert.IsTrue(multitudeOfString.ExistElement("Hi"));
        }

        /// <summary>
        /// Test for intersection in multitude of int.
        /// </summary>
        [TestMethod]
        public void IntersectionIntTest()
        {
            multitudeOfInt.AddElement(1);
            multitudeOfInt.AddElement(2);
            multitudeOfInt.AddElement(3);
            multiInt.AddElement(2);
            multiInt.AddElement(10);
            multitudeOfInt.Intersection(multiInt);
            Assert.IsTrue(multitudeOfInt.ExistElement(2));
            Assert.IsFalse(multitudeOfInt.ExistElement(1));
            Assert.IsFalse(multitudeOfInt.ExistElement(3));
            Assert.IsFalse(multitudeOfInt.ExistElement(20));
        }

        /// <summary>
        /// Test for intersection in multitude of string.
        /// </summary>
        [TestMethod]
        public void IntersectionStringTest()
        {
            multitudeOfString.AddElement("Hello");
            multitudeOfString.AddElement("World");
            multitudeOfString.AddElement("Hi");
            multiString.AddElement("Hello");
            multiString.AddElement("World");
            multiString.AddElement("GoodBye");
            multiString.AddElement("Bye");
            multitudeOfString.Intersection(multiString);
            Assert.IsTrue(multitudeOfString.ExistElement("Hello"));
            Assert.IsTrue(multitudeOfString.ExistElement("World"));
            Assert.IsFalse(multitudeOfString.ExistElement("Hi"));
            Assert.IsFalse(multitudeOfString.ExistElement("GoodBye"));
            Assert.IsFalse(multitudeOfString.ExistElement("Bye"));
        }

        private Multitude<int> multitudeOfInt;
        private Multitude<int> multiInt;
        private Multitude<string> multitudeOfString;
        private Multitude<string> multiString;
    }
}
