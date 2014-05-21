namespace ShablonSort.Test
{
    using InterfaceNamespace;

    /// <summary>
    /// Realization comparator string.
    /// </summary>
    public class ComparatorString : InterfaceComparator<string>
    {
        private string string1 { get; set; }

        public void NewCompare(string newString)
        {
            this.string1 = newString;
        }

        public int CopareTo(string string2)
        {
            return (string2.Length - this.string1.Length);
        }


    }
}
