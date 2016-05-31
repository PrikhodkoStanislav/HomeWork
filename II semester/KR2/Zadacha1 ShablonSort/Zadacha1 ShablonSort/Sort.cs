namespace SortNamespace
{
    using InterfaceNamespace;

    /// <summary>
    /// Class sort.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Sort<T>
    {
        /// <summary>
        /// Bubble sort.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="length"></param>
        /// <param name="Compare"></param>
        public void SortArray(ref T[] array, int length, InterfaceComparator<T> Compare)
        {
            for (int j = 0; j < length - 1; j++)
            {
                for (int i = 0; i < (length - j - 1); i++)
                {
                    Compare.NewCompare(array[i]);
                    if (Compare.CopareTo(array[i + 1]) < 0)
                    {
                        Swap(ref array, i, i + 1);
                    }
                }
            }
        }

        /// <summary>
        /// Swap elements with indexes i and j in the array.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public void Swap(ref T[] array, int i, int j)
        {
            T element = array[i];
            array[i] = array[j];
            array[j] = element;
        }
    }
}
