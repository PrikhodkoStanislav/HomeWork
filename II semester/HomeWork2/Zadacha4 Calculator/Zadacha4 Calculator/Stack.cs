namespace StackNamespace
{
    /// <summary>
    /// Interface of stack.
    /// </summary>
    public interface Stack
    {
        /// <summary>
        /// Push value to the stack.
        /// </summary>
        /// <param name="value"></param>
        void Push(int value);

        /// <summary>
        /// Pop element from the stack.
        /// </summary>
        /// <returns></returns>
        int Pop();

        /// <summary>
        /// Peek element from the stack.
        /// </summary>
        /// <returns></returns>
        int Peek();

        /// <summary>
        /// Return bool: Is stack empty?
        /// </summary>
        /// <returns></returns>
        bool IsEmpty();
    }
}
