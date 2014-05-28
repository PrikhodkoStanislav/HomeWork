namespace HashTableNamespace
{
    using ListNamespace;
    using ListElementNamespace;

    /// <summary>
    /// Hash table.
    /// </summary>
    public class HashTable
    {
        private List[] table;
        private int length;
        private HashFunction hashFunction;

        /// <summary>
        /// Constructor for new hash table.
        /// </summary>
        public HashTable(HashFunction function)
        {
            length = 10;
            table = new List[length];
            hashFunction = function;
            for (int i = 0; i < length; i++)
            {
                table[i] = new List();
            }
        }

        /// <summary>
        /// Modify hash table.
        /// </summary>
        /// <param name="length1"></param>
        /// <param name="length2"></param>
        public void ModifyHash(int length1, int length2)
        {
            List[] newTable = new List[length2];
            for (int i = 0; i < length2; i++)
            {
                newTable[i] = new List();
            }
            for (int i = 0; i < length; i++)
            {
                ListElement variable = table[i].head;
                while (variable != null)
                {
                    newTable[hashFunction.ruleOfHashFunction(variable.Value, length2)].InsertToHead(variable.Value);
                    variable = variable.Next;
                }
            }
            this.table = newTable;
        }

        /// <summary>
        /// Modify hash function on new function.
        /// </summary>
        /// <param name="function"></param>
        public void ModifyHashFunction(HashFunction function)
        {
            this.hashFunction = function;
            ModifyHash(length, length);
        }

        /// <summary>
        /// Modify length of hash table.
        /// </summary>
        /// <param name="lengthOfTable"></param>
        public void ModifyLengthOfHashTable(int lengthOfTable)
        {
            ModifyHash(length, lengthOfTable);
            this.length = lengthOfTable;
        }

        /// <summary>
        /// Is value in the hash table?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ExistElement(int value)
        {
            return table[hashFunction.ruleOfHashFunction(value, length)].Exist(value);
        }

        /// <summary>
        /// Insert value to the hash table if it is not there.
        /// </summary>
        /// <param name="value"></param>
        public void InsertToHashTable(int value)
        {
            if (!this.ExistElement(value))
            {
                table[hashFunction.ruleOfHashFunction(value, length)].InsertToHead(value);
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
                table[hashFunction.ruleOfHashFunction(value, length)].RemoveElement(value);
            }
        }
    }
}