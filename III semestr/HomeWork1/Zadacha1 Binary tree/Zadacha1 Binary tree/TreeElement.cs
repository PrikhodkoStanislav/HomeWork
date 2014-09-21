using System;

namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Class tree element.
    /// </summary>
    public class TreeElement<T> : IComparable
    {
        /// <summary>
        /// Constructor of tree element with value.
        /// </summary>
        /// <param name="value"></param>
        public TreeElement(T value)
        {
            this.Value = value;
            this.LeftElement = null;
            this.RightElement = null;
        }

        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 2;
            }
            TreeElement<T> element = obj as TreeElement<T>;
            if (this.Value == element.Value)
            {
                return 0;
            }
            if (this.Value > element.Value)
            {
                return 1;
            }
        }

        /// <summary>
        /// Value of tree element.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Left element of tree element.
        /// </summary>
        public TreeElement<T> LeftElement { get; set; }

        /// <summary>
        /// Right element of tree element.
        /// </summary>
        public TreeElement<T> RightElement { get; set; }
    }
}
