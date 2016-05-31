namespace Zadacha2_HashTableWithMobileFunction.Test
{
    using HashTableNamespace;

    /// <summary>
    /// Class of user hash function.
    /// </summary>
    public class UserHashFunction : HashFunction
    {
        public int ruleOfHashFunction(int value, int lengthOfHashTable)
        {
            return (value % lengthOfHashTable);
        }
    }
}
