using System.Collections;
using System.Collections.Generic;

namespace Zadacha1_Binary_tree
{
    /// <summary>
    /// Class binary tree.
    /// </summary>
    public class BinaryTree : IEnumerable
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
        private void ElementsOfTree(TreeElement element)
        {
            this.listOfElements.Add(element);
            if (element.leftElement != null)
            {
                ElementsOfTree(element.leftElement);
            }
            if (element.rightElement != null)
            {
                ElementsOfTree(element.rightElement);
            }
        }

        /// <summary>
        /// Add element in tree.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(int value)
        {
            TreeElement element = new TreeElement(value);
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
        private void AddElementInSubTree(TreeElement element, TreeElement rootOfSubTree)
        {
            if (rootOfSubTree.value > element.value)
            {
                if (rootOfSubTree.leftElement == null)
                {
                    rootOfSubTree.leftElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.leftElement);
                return;
            }
            if (rootOfSubTree.value < element.value)
            {
                if (rootOfSubTree.rightElement == null)
                {
                    rootOfSubTree.rightElement = element;
                    return;
                }
                this.AddElementInSubTree(element, rootOfSubTree.rightElement);
                return;
            }
        }

        /// <summary>
        /// Is element in the tree?
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool ExistElement(int value)
        {
            if (root == null)
            {
                return false;
            }
            listOfElements.Clear();
            ElementsOfTree(root);
            foreach (TreeElement element in listOfElements)
            {
                if (element.value == value)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Remove element from tree.
        /// </summary>
        /// <param name="value"></param>
        public void RemoveElement(int value)
        {
            if (!this.ExistElement(value))
            {
                return;
            }
            if (root.value == value)
            {
                if (root.leftElement == null)
                {
                    root = root.rightElement;
                    return;
                }
                if (root.rightElement == null)
                {
                    root = root.leftElement;
                    return;
                }
                if (root.rightElement.leftElement == null)
                {
                    root.rightElement.leftElement = root.leftElement;
                    root = root.rightElement;
                }
                TreeElement temp = root.rightElement;
                TreeElement element = root;
                while (temp.leftElement.leftElement != null)
                {
                    temp = temp.leftElement;
                }
                temp.leftElement.leftElement = root.leftElement;
                temp.leftElement = temp.leftElement.rightElement;
                root = temp.leftElement;
                root.rightElement = element.rightElement;
                return;
            }
            this.RemoveElementFromSubTree(value, root);
        }

        /// <summary>
        /// Remove element from sub tree.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="rootOfSubTree"></param>
        public void RemoveElementFromSubTree(int value, TreeElement rootOfSubTree)
        {
            if (rootOfSubTree.value > value)
            {
                if (rootOfSubTree.leftElement.value == value)
                {
                    this.DeleteElement(rootOfSubTree.leftElement, rootOfSubTree);
                    return;
                }
                RemoveElementFromSubTree(value, rootOfSubTree.leftElement);
                return;
            }
            if (rootOfSubTree.value < value)
            {
                if (rootOfSubTree.rightElement.value == value)
                {
                    this.DeleteElement(rootOfSubTree.rightElement, rootOfSubTree);
                    return;
                }
                this.RemoveElementFromSubTree(value, rootOfSubTree.rightElement);
                return;
            }
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="parent"></param>
        private void DeleteElement(TreeElement element, TreeElement parent)
        {
            if (element == parent.leftElement)
            {
                if (element.leftElement == null)
                {
                    parent.leftElement = element.rightElement;
                    return;
                }
                if (element.rightElement == null)
                {
                    parent.leftElement = element.leftElement;
                    return;
                }
                if (element.rightElement.leftElement == null)
                {
                    element.rightElement.leftElement = element.leftElement;
                    parent.leftElement = element.rightElement;
                    return;
                }
                TreeElement temp = element.rightElement;
                while (temp.leftElement.leftElement != null)
                {
                    temp = temp.leftElement;
                }
                temp.leftElement.leftElement = element.leftElement;
                parent.leftElement = temp.leftElement;
                parent.leftElement.rightElement = element.rightElement;
                temp.leftElement = temp.leftElement.rightElement;
                return;
            }
            else
            {
                if (element.leftElement == null)
                {
                    parent.rightElement = element.rightElement;
                    return;
                }
                if (element.rightElement == null)
                {
                    parent.rightElement = element.leftElement;
                    return;
                }
                if (element.rightElement.leftElement == null)
                {
                    element.rightElement.leftElement = element.leftElement;
                    parent.rightElement = element.rightElement;
                    return;
                }
                TreeElement temp = element.rightElement;
                while (temp.leftElement.leftElement != null)
                {
                    temp = temp.leftElement;
                }
                temp.leftElement.leftElement = element.leftElement;
                parent.rightElement = temp.leftElement;
                parent.rightElement.rightElement = element.rightElement;
                temp.leftElement = temp.leftElement.rightElement;
                return;
            }
        }

        private TreeElement root;
        private List<TreeElement> listOfElements = new List<TreeElement>();
    }
}
