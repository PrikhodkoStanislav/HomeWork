namespace ParseTreeNamespace
{
    /// <summary>
    /// Class element of the tree.
    /// </summary>
    public class TreeElement
    {
        /// <summary>
        /// Left child of the tree element.
        /// </summary>
        public TreeElement left { get; set; }

        /// <summary>
        /// Right child of the tree element.
        /// </summary>
        public TreeElement right { get; set; }

        /// <summary>
        /// Parent of the tree element.
        /// </summary>
        public TreeElement up { get; set; }

        /// <summary>
        /// Print element.
        /// </summary>
        /// <param name="result"></param>
        public virtual void Print(ref string result)
        {

        }

        /// <summary>
        /// Count element.
        /// </summary>
        /// <returns></returns>
        public virtual int Count()
        {
            return 0;
        }
    }
}
