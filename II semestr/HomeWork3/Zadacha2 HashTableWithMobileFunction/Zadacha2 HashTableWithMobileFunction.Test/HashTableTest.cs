namespace Zadacha2_HashTableWithMobileFunction.Test
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using HashTableNamespace;

    [TestClass]
    public class HashTableTest
    {
        [TestInitialize]
        public void Initialize()
        {
            hashFunction10Elements = new HashFunctionWith10Elements();
            hashTable = new HashTable(hashFunction10Elements);

            userHashFunction = new UserHashFunction();
            userHashTable = new HashTable(userHashFunction);
        }

        /// <summary>
        /// Insert to hash able element 5 and it must exist in hash table.
        /// </summary>
        [TestMethod]
        public void InsertToHashTableTest()
        {
            hashTable.InsertToHashTable(5);
            Assert.IsTrue(hashTable.ExistElement(5));
        }

        /// <summary>
        /// Element 0 must not be in empty hash table.
        /// </summary>
        [TestMethod]
        public void ExistElementTest()
        {
            Assert.IsFalse(hashTable.ExistElement(0));
        }

        /// <summary>
        /// If we remove element 0 from the hash table, 
        /// element 0 must not be in the hash table.
        /// </summary>
        [TestMethod]
        public void RemoveFromHashTableTest()
        {
            hashTable.InsertToHashTable(0);
            Assert.IsTrue(hashTable.ExistElement(0));
            hashTable.RemoveFromHashTable(0);
            Assert.IsFalse(hashTable.ExistElement(0));
        }

        /// <summary>
        /// Insert element 0 to the user hash table and it must be in user hash table.
        /// </summary>
        [TestMethod]
        public void InsertToUserHashTableTest()
        {
            userHashTable.InsertToHashTable(0);
            Assert.IsTrue(userHashTable.ExistElement(0));
        }

        /// <summary>
        /// Element 0 must not be in empty user hash table.
        /// </summary>
        [TestMethod]
        public void ExistElementInTheUserHashTableTest()
        {
            Assert.IsFalse(userHashTable.ExistElement(0));
        }

        /// <summary>
        /// If we remove element 1 from the user hash table, 
        /// element 1 must not be in the user hash table.
        /// </summary>
        [TestMethod]
        public void RemoveFromUserHashTableTest()
        {
            userHashTable.InsertToHashTable(1);
            Assert.IsTrue(userHashTable.ExistElement(1));
            userHashTable.RemoveFromHashTable(1);
            Assert.IsFalse(userHashTable.ExistElement(1));
        }

        /// <summary>
        /// Insert elements to the user hash table and they must be in user hash table.
        /// </summary>
        [TestMethod]
        public void InsertElementsToUserHashTableTest()
        {
            userHashTable.InsertToHashTable(0);
            userHashTable.InsertToHashTable(1);
            userHashTable.InsertToHashTable(2);
            userHashTable.InsertToHashTable(3);
            userHashTable.InsertToHashTable(4);
            userHashTable.InsertToHashTable(15);
            userHashTable.InsertToHashTable(14);
            userHashTable.InsertToHashTable(10);
            userHashTable.InsertToHashTable(20);
            userHashTable.InsertToHashTable(210);
            Assert.IsTrue(userHashTable.ExistElement(20));
        }

        private HashFunctionWith10Elements hashFunction10Elements;
        private HashTable hashTable;
        private UserHashFunction userHashFunction;
        private HashTable userHashTable;
    }
}
