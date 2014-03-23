namespace Zadacha2_HashTableWithMobileFunction.Test
{
    using HashTableNamespace;

    /// <summary>
    /// Class of user hash function.
    /// </summary>
    public class UserHashFunction : HashFunction
    {
        public int lengthOfHashTable()
        {
            return 5;
        }

        public int ruleOfHashFunction(int value)
        {
            return (value % this.lengthOfHashTable());
        }
    }
}
