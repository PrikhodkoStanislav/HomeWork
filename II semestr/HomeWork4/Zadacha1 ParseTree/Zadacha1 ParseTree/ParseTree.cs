namespace ParseTreeNamespace
{
    /// <summary>
    /// Class parse tree.
    /// </summary>
    public class ParseTree
    {
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
        /// Make operation with number1 and number2.
        /// </summary>
        /// <param name="number1"></param>
        /// <param name="number2"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        private int MakeOperation(int number1, int number2, char operation)
        {
            if (operation == '+')
            {
                return (number1 + number2);
            }
            if (operation == '*')
            {
                return (number1 * number2);
            }
            if (operation == '-')
            {
                return (number1 - number2);
            }
            else
            {
                if (number2 != 0)
                {
                    return (number1 / number2);
                }
                else
                {
                    throw new ExceptionDivisionBy0();
                }
            }
        }

        /// <summary>
        /// Count element.
        /// </summary>
        /// <param name="element"></param>
        /// <returns></returns>
        private int Count(TreeElement element)
        {
            if (IsFunction(element.ReturnValue()))
            {
                return (MakeOperation(Count(element.ReturnLeft()), Count(element.ReturnRight()), element.ReturnValue()));
            }
            else
            {
                return (element.ReturnNumber());
            }
        }

        /// <summary>
        /// Count value of expression parse tree.
        /// </summary>
        /// <param name="tree"></param>
        /// <returns></returns>
        public int ValueOfExpression(Tree tree)
        {
            TreeElement element = tree.ReturnHead();
            if (element != null)
            {
                return (Count(element));
            }
            return 0;
        }
    }
}
