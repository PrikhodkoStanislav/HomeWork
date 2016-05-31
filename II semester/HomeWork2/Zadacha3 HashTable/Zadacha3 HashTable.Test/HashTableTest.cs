namespace HashTableNamespace.Test
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
            hashTable = new HashTable();
        }

        /// <summary>
        /// Insert to hash table element 5.
        /// </summary>
        [TestMethod]
        public void InsertToHashTableTest()
        {
            hashTable.InsertToHashTable(5);
            Assert.IsTrue(hashTable.ExistElement(5));
        }

        /// <summary>
        /// Element 10 is not in empty hash table.
        /// Insert element 10 to hash table.
        /// Now value 10 is in hash table.
        /// </summary>
        [TestMethod]
        public void ExistElementTest()
        {
            Assert.IsFalse(hashTable.ExistElement(10));
            hashTable.InsertToHashTable(10);
            Assert.IsTrue(hashTable.ExistElement(10));
        }

        /// <summary>
        /// Insert element 25 to hash table and remove it.
        /// Now element is not in hash table.
        /// </summary>
        [TestMethod]
        public void RemoveFromHashTableTest()
        {
            hashTable.InsertToHashTable(25);
            Assert.IsTrue(hashTable.ExistElement(25));
            hashTable.RemoveFromHashTable(25);
            Assert.IsFalse(hashTable.ExistElement(25));
        }

        private HashTable hashTable;
    }
}
