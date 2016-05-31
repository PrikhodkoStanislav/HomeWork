namespace InterfaceNamespace
{
    /// <summary>
    /// Interface Comparator.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface InterfaceComparator<T>
    {
        /// <summary>
        /// Element for compare.
        /// </summary>
        /// <param name="element"></param>
        void NewCompare(T element);

        /// <summary>
        /// Return number == 0, if element 1 == element 2.
        /// Return number > 0, if element 2 > element 1.
        /// Return number < 0, if element 2 < element 1.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        int CopareTo(T element);
    }
}
