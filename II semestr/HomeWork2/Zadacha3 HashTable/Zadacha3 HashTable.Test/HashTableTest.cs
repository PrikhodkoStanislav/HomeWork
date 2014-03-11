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

        private HashTable hashTable;
    }
}
