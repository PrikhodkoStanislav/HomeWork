namespace ShablonSort.Test
{
    using InterfaceNamespace;

    /// <summary>
    /// Realization comparator int.
    /// </summary>
    public class ComparatorInt : InterfaceComparator<int>
    {
        private int element1 { get; set; }

        public void NewCompare(int newElement)
        {
            this.element1 = newElement;
        }

        public int CopareTo(int element2)
        {
            return (element2 - this.element1);
        }
    }
}