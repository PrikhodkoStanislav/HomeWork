using System;

namespace ParseTreeNamespace
{
    /// <summary>
    /// Class tree.
    /// </summary>
    public class Tree
    {
        /// <summary>
        /// Head of tree.
        /// </summary>
        public TreeElement head { get; set; }

        /// <summary>
        /// Is element number?
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private bool IsNumber(char element)
        {
            return (((int)element >= (int)('0')) && ((int)element - (int)('0') <= 9));
        }

        /// <summary>
        /// Is element function?
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private bool IsFunction(char element)
        {
            return ((element == '+') | (element == '-') | (element == '*') | (element == '/'));
        }

        private Operation NewOperation(char value)
        {
            Operation theOperation;
            if (value == '+')
            {
                theOperation = new OperationSum();
            }
            else if (value == '-')
            {
                theOperation = new OperationDiff();
            }
            else if (value == '*')
            {
                theOperation = new OperationMulti();
            }
            else
            {
                theOperation = new OperationDiv();
            }
            theOperation.left = null;
            theOperation.right = null;
            theOperation.up = null;
            return theOperation;
        }

        /// <summary>
        /// Insert sub tree by expression and index-variable.
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="index"></param>
        /// <param name="element"></param>
        private void InsertSubTree(string expression, ref int index, TreeElement element)
        {
            while (index < expression.Length)
            {
                char symbol = expression[index];
                if (symbol == '(')
                {
                    TreeElement newElement = NewOperation(expression[index + 1]);
                    newElement.up = element;
                    if (element == null)
                    {
                        this.head = newElement;
                        element = newElement;
                    }
                    else
                    {
                        if (element.left == null)
                        {
                            element.left = newElement;
                        }
                        else
                        {
                            element.right = newElement;
                        }
                        element = newElement;
                    }
                    index += 2;
                    InsertSubTree(expression, ref index, element);
                    InsertSubTree(expression, ref index, element);
                }
                else
                {
                    if (IsNumber(expression[index]))
                    {
                        TreeElement newTreeElement = new Operand(element, (int)expression[index] - (int)'0');
                        index++;
                    }
                    else
                    {
                        if (expression[index] == ')')
                        {
                            element = element.up;
                            index++;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Write in tree expression.
        /// </summary>
        /// <param name="expression"></param>
        public void WriteInTree(string expression)
        {
            TreeElement element = this.head;
            int i = 0;
            InsertSubTree(expression, ref i, element);
        }

        /// <summary>
        /// Print tree.
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            string result = "";
            this.head.Print(ref result);
            return result;
        }

        /// <summary>
        /// Return value of the expression-tree.
        /// </summary>
        /// <returns></returns>
        public int ValueOfExpression()
        {
            TreeElement element = this.head;
            if (element != null)
            {
                return (element.Count());
            }
            return 0;
        }
    }
}
