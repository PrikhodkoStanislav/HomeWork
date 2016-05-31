namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Interface for comparator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface CompareInterface<T>
    {
        /// <summary>
        /// Compare function.
        /// </summary>
        /// <param name="element1"></param>
        /// <param name="element2"></param>
        /// <returns></returns>
        int Compare(T element1, T element2);
    }
}
