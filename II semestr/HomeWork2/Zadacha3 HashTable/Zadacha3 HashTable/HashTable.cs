namespace HashTableNamespace
{
    using ListNamespace;

    /// <summary>
    /// Hash table.
    /// </summary>
    public class HashTable
    {
        private const int n = 10;
        private List[] table = new List[n];

        /// <summary>
        /// Constructor for new hash table.
        /// </summary>
        public HashTable()
        {
            for (int i = 0; i < n; i++)
            {
                table[i] = new List();
            }
        }

        /// <summary>
        /// Return hash function of value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private int HashFunction(int value)
        {
            return ((value * 15 - 23) % 10);
        }

        /// <summary>
        /// Is value in the hash table?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ExistElement(int value)
        {
            return table[HashFunction(value)].Exist(value);
        }

        /// <summary>
        /// Insert value to the hash table if it is not there.
        /// </summary>
        /// <param name="value"></param>
        public void InsertToHashTable(int value)
        {
            if (!this.ExistElement(value))
            {
                table[HashFunction(value)].InsertToHead(value);
            }
        }

        /// <summary>
        /// Remove value from the hash table.
        /// </summary>
        /// <param name="value"></param>
        public void RemoveFromHashTable(int value)
        {
            if (this.ExistElement(value))
            {
                table[HashFunction(value)].RemoveElement(value);
            }
        }
    }
}
