using System.Collections;
using System.Collections.Generic;

namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Class binary tree.
    /// </summary>
    public class BinaryTree<T> : IEnumerable
    {
        /// <summary>
        /// Get enumerator.
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            if (root != null)
            {
                listOfElements.Clear();
                ElementsOfTree(root);
            }
            foreach (var temp in listOfElements)
            {
                yield return temp;
            }
        }

        /// <summary>
        /// Fill list with elements of tree in the true order.
        /// </summary>
        /// <param name="element"></param>
        private void ElementsOfTree(TreeElement<T> element)
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
        public void AddElement(T value)
        {
            TreeElement<T> element = new TreeElement<T>(value);
            if (this.root == null)
            {
                this.root = element;
                return;
            }
            this.AddElementInSubTree(element, root);
        }

        /// <summary>
        /// Add element in subtree (with root of subtree).
        /// </summary>
        /// <param name="element"></param>
        /// <param name="rootOfSubTree"></param>
        private void AddElementInSubTree(TreeElement<T> element, TreeElement<T> rootOfSubTree)
        {
            if (rootOfSubTree.Value > element.Value)
            {
                if (rootOfSubTree.LeftElement == null)
                {
                    rootOfSubTree.LeftElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.LeftElement);
                return;
            }
            if (rootOfSubTree.Value < element.Value)
            {
                if (rootOfSubTree.RightElement == null)
                {
                    rootOfSubTree.RightElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.RightElement);
                return;
            }
        }

        /// <summary>
        /// Is element in the tree?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ExistElement(T value)
        {
            if (root == null)
            {
                return false;
            }
            return ExistElementInSubTree(root, value);
        }

        /// <summary>
        /// Is element in subtree with root element?
        /// </summary>
        /// <param name="rootElement"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool ExistElementInSubTree(TreeElement<T> rootElement, T value)
        {
            if (rootElement.Value  == value)
            {
                return true;
            }
            else
            {
                if (rootElement.Value > value && rootElement.LeftElement != null)
                {
                    return ExistElementInSubTree(rootElement.LeftElement, value);
                }
                if (rootElement.Value < value && rootElement.RightElement != null)
                {
                    return ExistElementInSubTree(rootElement.RightElement, value);
                }
                return false;
            }
        }

        /// <summary>
        /// Remove element from tree.
        /// </summary>
        /// <param name="value"></param>
        public void RemoveElement(T value)
        {
            if (!this.ExistElement(value))
            {
                return;
            }
            if (root.Value == value)
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
                TreeElement<T> temp = root.RightElement;
                TreeElement<T> element = root;
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
            this.RemoveElementFromSubTree(value, root);
        }

        /// <summary>
        /// Remove element from sub tree.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rootOfSubTree"></param>
        public void RemoveElementFromSubTree(T value, TreeElement<T> rootOfSubTree)
        {
            if (rootOfSubTree.Value > value)
            {
                if (rootOfSubTree.LeftElement.Value == value)
                {
                    this.DeleteElement(rootOfSubTree.LeftElement, rootOfSubTree);
                    return;
                }
                RemoveElementFromSubTree(value, rootOfSubTree.LeftElement);
                return;
            }
            if (rootOfSubTree.Value < value)
            {
                if (rootOfSubTree.RightElement.Value == value)
                {
                    this.DeleteElement(rootOfSubTree.RightElement, rootOfSubTree);
                    return;
                }
                this.RemoveElementFromSubTree(value, rootOfSubTree.RightElement);
                return;
            }
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="parent"></param>
        private void DeleteElement(TreeElement<T> element, TreeElement<T> parent)
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
                TreeElement<T> temp = element.RightElement;
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
                TreeElement<T> temp = element.RightElement;
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

        private TreeElement<T> root;
        private List<TreeElement<T>> listOfElements = new List<TreeElement<T>>();
    }
}
