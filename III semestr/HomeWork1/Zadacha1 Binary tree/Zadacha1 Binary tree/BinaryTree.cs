using System.Collections;
using System.Collections.Generic;

namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Class binary tree.
    /// </summary>
    public class BinaryTree<T> : IEnumerable<T>
    {
        /// <summary>
        /// Class element of the tree.
        /// </summary>
        public class TreeElement
        {
            /// <summary>
            /// Constructor of tree element with value.
            /// </summary>
            /// <param name="value"></param>
            public TreeElement(T value)
            {
                this.value = value;
                this.leftElement = null;
                this.rightElement = null;
            }

            public T Value
            {
                get { return value; }
            }

            public TreeElement LeftElement
            {
                get { return leftElement; }
                set { this.leftElement = value; }
            }

            public TreeElement RightElement
            {
                get { return rightElement; }
                set { this.rightElement = value; }
            }

            /// <summary>
            /// Value of tree element.
            /// </summary>
            private T value;

            /// <summary>
            /// Left element of tree element.
            /// </summary>
            private TreeElement leftElement;

            /// <summary>
            /// Right element of tree element.
            /// </summary>
            private TreeElement rightElement;
        }

        /// <summary>
        /// Constructor for Binary tree.
        /// </summary>
        public BinaryTree()
        {
            root = null;
        }

        /// <summary>
        /// Get enumerator.
        /// </summary>
        /// <returns></returns>
        //public IEnumerator<T> GetEnumerator()
        //{
        //    if (root != null)
        //    {
        //        listOfElements.Clear();
        //        ElementsOfTree(root);
        //    }
        //    foreach (var temp in listOfElements)
        //    {
        //        yield return temp.Value;
        //    }
        //}

        /// <summary>
        /// Fill list with elements of tree in the true order.
        /// </summary>
        /// <param name="element"></param>
        private void ElementsOfTree(TreeElement element)
        {
            this.listOfElements.Add(element);
            if (element.LeftElement != null)
            {
                ElementsOfTree(element.LeftElement);
            }
            if (element.RightElement != null)
            {
                ElementsOfTree(element.RightElement);
            }
        }

        /// <summary>
        /// Add element in tree.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparator"></param>
        public void AddElement(T value, CompareInterface<T> comparator)
        {
            if (!ExistElement(value, comparator))
            {
                TreeElement element = new TreeElement(value);
                if (this.root == null)
                {
                    this.root = element;
                    return;
                }
                this.AddElementInSubTree(element, root, comparator);
            }
        }

        /// <summary>
        /// Add element in subtree (with root of subtree).
        /// </summary>
        /// <param name="element"></param>
        /// <param name="rootOfSubTree"></param>
        /// <param name="comparator"></param>
        private void AddElementInSubTree(TreeElement element, TreeElement rootOfSubTree, CompareInterface<T> comparator)
        {
            if (comparator.Compare(rootOfSubTree.Value, element.Value) == 1)
            {
                if (rootOfSubTree.LeftElement == null)
                {
                    rootOfSubTree.LeftElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.LeftElement, comparator);
                return;
            }
            if (comparator.Compare(rootOfSubTree.Value, element.Value) == -1)
            {
                if (rootOfSubTree.RightElement == null)
                {
                    rootOfSubTree.RightElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.RightElement, comparator);
                return;
            }
        }

        /// <summary>
        /// Is element in the tree?
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparator"></param>
        /// <returns></returns>
        public bool ExistElement(T value, CompareInterface<T> comparator)
        {
            if (root == null)
            {
                return false;
            }
            return ExistElementInSubTree(root, value, comparator);
        }

        /// <summary>
        /// Is element in subtree with root element?
        /// </summary>
        /// <param name="rootElement"></param>
        /// <param name="value"></param>
        /// <param name="comparator"></param>
        /// <returns></returns>
        private bool ExistElementInSubTree(TreeElement rootElement, T value, CompareInterface<T> comparator)
        {
            if (comparator.Compare(rootElement.Value, value) == 0)
            {
                return true;
            }
            else
            {
                if (comparator.Compare(rootElement.Value, value) == 1 && rootElement.LeftElement != null)
                {
                    return ExistElementInSubTree(rootElement.LeftElement, value, comparator);
                }
                if (comparator.Compare(rootElement.Value, value) == -1 && rootElement.RightElement != null)
                {
                    return ExistElementInSubTree(rootElement.RightElement, value, comparator);
                }
                return false;
            }
        }

        /// <summary>
        /// Remove element from tree.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="comparator"></param>
        public void RemoveElement(T value, CompareInterface<T> comparator)
        {
            if (this.ExistElement(value, comparator))
            {
                if (comparator.Compare(root.Value, value) == 0)
                {
                    if (root.LeftElement == null)
                    {
                        root = root.RightElement;
                        return;
                    }
                    if (root.RightElement == null)
                    {
                        root = root.LeftElement;
                        return;
                    }
                    if (root.RightElement.LeftElement == null)
                    {
                        root.RightElement.LeftElement = root.LeftElement;
                        root = root.RightElement;
                    }
                    TreeElement temp = root.RightElement;
                    TreeElement element = root;
                    while (temp.LeftElement.LeftElement != null)
                    {
                        temp = temp.LeftElement;
                    }
                    temp.LeftElement.LeftElement = root.LeftElement;
                    temp.LeftElement = temp.LeftElement.RightElement;
                    root = temp.LeftElement;
                    root.RightElement = element.RightElement;
                    return;
                }
                this.RemoveElementFromSubTree(value, root, comparator);
            }
        }

        /// <summary>
        /// Remove element from sub tree.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rootOfSubTree"></param>
        /// <param name="comparator"></param>
        public void RemoveElementFromSubTree(T value, TreeElement rootOfSubTree, CompareInterface<T> comparator)
        {
            if (comparator.Compare(rootOfSubTree.Value, value) == 1)
            {
                if (comparator.Compare(rootOfSubTree.LeftElement.Value, value) == 0)
                {
                    this.DeleteElement(rootOfSubTree.LeftElement, rootOfSubTree);
                }
                else
                {
                    RemoveElementFromSubTree(value, rootOfSubTree.LeftElement, comparator);
                }
            }
            else if (comparator.Compare(rootOfSubTree.Value, value) == -1)
            {
                if (comparator.Compare(rootOfSubTree.RightElement.Value, value) == 0)
                {
                    this.DeleteElement(rootOfSubTree.RightElement, rootOfSubTree);
                }
                else
                {
                    RemoveElementFromSubTree(value, rootOfSubTree.RightElement, comparator);
                }
            }
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="parent"></param>
        private void DeleteElement(TreeElement element, TreeElement parent)
        {
            if (element == parent.LeftElement)
            {
                if (element.LeftElement == null)
                {
                    parent.LeftElement = element.RightElement;
                    return;
                }
                if (element.RightElement == null)
                {
                    parent.LeftElement = element.LeftElement;
                    return;
                }
                if (element.RightElement.LeftElement == null)
                {
                    element.RightElement.LeftElement = element.LeftElement;
                    parent.LeftElement = element.RightElement;
                    return;
                }
                TreeElement temp = element.RightElement;
                while (temp.LeftElement.LeftElement != null)
                {
                    temp = temp.LeftElement;
                }
                temp.LeftElement.LeftElement = element.LeftElement;
                parent.LeftElement = temp.LeftElement;
                parent.LeftElement.RightElement = element.RightElement;
                temp.LeftElement = temp.LeftElement.RightElement;
                return;
            }
            else
            {
                if (element.LeftElement == null)
                {
                    parent.RightElement = element.RightElement;
                    return;
                }
                if (element.RightElement == null)
                {
                    parent.RightElement = element.LeftElement;
                    return;
                }
                if (element.RightElement.LeftElement == null)
                {
                    element.RightElement.LeftElement = element.LeftElement;
                    parent.RightElement = element.RightElement;
                    return;
                }
                TreeElement temp = element.RightElement;
                while (temp.LeftElement.LeftElement != null)
                {
                    temp = temp.LeftElement;
                }
                temp.LeftElement.LeftElement = element.LeftElement;
                parent.RightElement = temp.LeftElement;
                parent.RightElement.RightElement = element.RightElement;
                temp.LeftElement = temp.LeftElement.RightElement;
                return;
            }
        }

        private TreeElement root;
        private List<TreeElement> listOfElements = new List<TreeElement>();

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            if (root != null)
            {
                listOfElements.Clear();
                ElementsOfTree(root);
            }
            foreach (var temp in listOfElements)
            {
                yield return temp.Value;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new System.NotImplementedException();
        }
    }
}
