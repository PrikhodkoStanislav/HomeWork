namespace HashTableNamespace
{
    /// <summary>
    /// Interface of hash function.
    /// </summary>
    public interface HashFunction
    {
        /// <summary>
        /// Rule of hash function for values.
        /// </summary>
        /// <returns></returns>
        int ruleOfHashFunction(int value, int lengthOfHashTable);
    }
}
