namespace HashTableNamespace
{
    /// <summary>
    /// Interface of hash function.
    /// </summary>
    public interface HashFunction
    {
        /// <summary>
        /// Length of the hashtable.
        /// </summary>
        /// <returns></returns>
        int lengthOfHashTable();

        /// <summary>
        /// Rule of hash function for values.
        /// </summary>
        /// <returns></returns>
        int ruleOfHashFunction(int value);
    }
}
