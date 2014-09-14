namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Class tree element.
    /// </summary>
    public class TreeElement
    {
        /// <summary>
        /// Constructor of tree element with value.
        /// </summary>
        /// <param name="value"></param>
        public TreeElement(int value)
        {
            this.value = value;
            this.leftElement = null;
            this.rightElement = null;
        }

        /// <summary>
        /// Value of tree element.
        /// </summary>
        public int value { get; set; }

        /// <summary>
        /// Left element of tree element.
        /// </summary>
        public TreeElement leftElement { get; set; }

        /// <summary>
        /// Right element of tree element.
        /// </summary>
        public TreeElement rightElement { get; set; }
    }
}
