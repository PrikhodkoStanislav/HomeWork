namespace HashTableNamespace
{
    /// <summary>
    /// Hash function with 10 elements.
    /// </summary>
    public class HashFunctionWith10Elements : HashFunction
    {
        /// <summary>
        /// Return hash function of value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int ruleOfHashFunction(int value, int lengthOfHashTable)
        {
            return ((value * 15 + 23) % lengthOfHashTable);
        }
    }
}
