namespace StackNamespace
{
    using System;

    /// <summary>
    /// Class of stack on array.
    /// </summary>
    public class StackOnArray : Stack
    {
        /// <summary>
        /// Push value to the stack.
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = value;
        }

        /// <summary>
        /// Pop element from the stack.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            int temp = array[array.Length - 1];
            Array.Resize(ref array, array.Length - 1);
            return temp;
        }

        /// <summary>
        /// Peek element from the stack.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return array[array.Length - 1];
        }

        /// <summary>
        /// Is stack empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (array.Length == 0);
        }

        private int[] array = new int[0];
    }
}
