namespace HashTableNamespace
{
    using ListNamespace;

    /// <summary>
    /// Hash table.
    /// </summary>
    public class HashTable
    {
        private List[] table;
        private int length;
        private delegate int ruleHashTable(int value);
        private ruleHashTable hashFunction;

        /// <summary>
        /// Constructor for new hash table.
        /// </summary>
        public HashTable(HashFunction function)
        {
            table = new List[function.lengthOfHashTable()];
            length = function.lengthOfHashTable();
            hashFunction = new ruleHashTable(function.ruleOfHashFunction);
            for (int i = 0; i < length; i++)
            {
                table[i] = new List();
            }
        }

        public void ModifyHashFunction()
        {

        }

        /// <summary>
        /// Is value in the hash table?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ExistElement(int value)
        {
            return table[hashFunction(value)].Exist(value);
        }

        /// <summary>
        /// Insert value to the hash table if it is not there.
        /// </summary>
        /// <param name="value"></param>
        public void InsertToHashTable(int value)
        {
            if (!this.ExistElement(value))
            {
                table[hashFunction(value)].InsertToHead(value);
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
                table[hashFunction(value)].RemoveElement(value);
            }
        }
    }
}