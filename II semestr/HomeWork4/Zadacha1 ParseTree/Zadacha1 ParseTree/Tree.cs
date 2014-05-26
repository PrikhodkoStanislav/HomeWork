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
        private TreeElement head { get; set; }

        /// <summary>
        /// Return head of tree.
        /// </summary>
        /// <returns></returns>
        public TreeElement ReturnHead()
        {
            return head;
        }

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
                    TreeElement newElement = new TreeElement(expression[index + 1]);
                    newElement.WriteUp(element);
                    if (element == null)
                    {
                        this.head = newElement;
                        element = newElement;
                    }
                    else
                    {
                        if (element.ReturnLeft() == null)
                        {
                            element.WriteLeft(newElement);
                        }
                        else
                        {
                            element.WriteRight(newElement);
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
                        TreeElement newTreeElement = new TreeElement(element, (int)expression[index] - (int)'0');
                        index++;
                    }
                    else
                    {
                        if (expression[index] == ')')
                        {
                            element = element.ReturnUp();
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
            TreeElement element = this.ReturnHead();
            int i = 0;
            InsertSubTree(expression, ref i, element);
        }

        /// <summary>
        /// Print sub tree.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="result"></param>
        private void PrintSubTree(TreeElement element, ref string result)
        {
            if (IsFunction(element.ReturnValue()))
            {
                Console.Write("( {0} ", element.ReturnValue());
                result += "( " + element.ReturnValue().ToString() + " ";
                PrintSubTree(element.ReturnLeft(), ref result);
                PrintSubTree(element.ReturnRight(), ref result);
            }
            else
            {
                Console.Write("{0} ", element.ReturnNumber());
                result += element.ReturnNumber().ToString() + " ";
                if (element == element.ReturnUp().ReturnRight())
                {
                    Console.Write(") ");
                    result += ") ";
                }
            }
        }

        /// <summary>
        /// Print tree.
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            TreeElement element = this.ReturnHead();
            if (element != null)
            {
                string result = "";
                PrintSubTree(element, ref result);
                return result;
            }
            else
            {
                Console.WriteLine("Tree is clear!");
                return "Tree is clear!";
            }
        }
    }
}
