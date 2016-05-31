namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Comparator for elements with int type.
    /// </summary>
    public class CompareInt : CompareInterface<int>
    {
        /// <summary>
        /// Function Compare for elements with int type.
        /// </summary>
        /// <param name="element1"></param>
        /// <param name="element2"></param>
        /// <returns></returns>
        public int Compare(int element1, int element2)
        {
            if (element1 > element2)
            {
                return 1;
            }
            if (element1 < element2)
            {
                return -1;
            }
            return 0;
        }
    }
}
