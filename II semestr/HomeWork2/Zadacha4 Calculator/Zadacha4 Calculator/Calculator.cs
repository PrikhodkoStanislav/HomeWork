namespace CalculatorNamespace
{
    using StackNamespace;

    /// <summary>
    /// Class of calculator.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// Add new element in stack calculator.
        /// </summary>
        /// <param name="value"></param>
        public void AddElement(int value)
        {
            stack.Push(value);
        }

        /// <summary>
        /// Add elements.(+)
        /// </summary>
        public void Add()
        {
            stack.Push(stack.Pop() + stack.Pop());
        }

        /// <summary>
        /// Subtract elements.(-)
        /// </summary>
        public void Subtract()
        {
            int temp = stack.Pop();
            stack.Push(stack.Pop() - temp);
        }

        /// <summary>
        /// Divide elements.(/)
        /// </summary>
        public void Division()
        {
            int temp = stack.Pop();
            stack.Push(stack.Pop() / temp);
        }

        /// <summary>
        /// Multiply elements.(*)
        /// </summary>
        public void Multiplication()
        {
            stack.Push(stack.Pop() * stack.Pop());
        }

        /// <summary>
        /// Return result of operation.(=)
        /// </summary>
        /// <returns></returns>
        public int ReturnResult()
        {
            return stack.Peek();
        }

        private Stack stack = new StackOnReference();
        //private Stack stack = new StackOnArray();
    }
}
