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
            this.lengthOfArray++;
            if (array.Length < this.lengthOfArray)
            {
                Array.Resize(ref array, array.Length * 2);
            }
            array[this.lengthOfArray - 1] = value;
        }

        /// <summary>
        /// Pop element from the stack.
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            int temp = array[this.lengthOfArray - 1];
            this.lengthOfArray--;
            return temp;
        }

        /// <summary>
        /// Peek element from the stack.
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            return array[this.lengthOfArray - 1];
        }

        /// <summary>
        /// Is stack empty?
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (array.Length == 0);
        }

        private int[] array = new int[1];
        private int lengthOfArray { get; set; }
    }
}
