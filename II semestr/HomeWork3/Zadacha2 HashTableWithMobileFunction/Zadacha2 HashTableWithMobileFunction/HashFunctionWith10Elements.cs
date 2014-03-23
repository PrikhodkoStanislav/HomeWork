namespace HashTableNamespace
{
    /// <summary>
    /// Hash function with 10 elements.
    /// </summary>
    public class HashFunctionWith10Elements : HashFunction
    {
        /// <summary>
        /// In this hash function length is 10.
        /// </summary>
        /// <returns></returns>
        public int lengthOfHashTable()
        {
            return 10;
        }

        /// <summary>
        /// Return hash function of value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int ruleOfHashFunction(int value)
        {
            return ((value * 15 + 23) % this.lengthOfHashTable());
        }
    }
}
