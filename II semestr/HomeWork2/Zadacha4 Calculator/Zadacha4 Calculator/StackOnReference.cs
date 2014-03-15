using System;

namespace StackNamespace
{
    /// <summary>
    /// Class of stack on references.
    /// </summary>
    public class StackOnReference : Stack
    {
        /// <summary>
        /// class of element with value and reference on next element
        /// </summary>
        private class Element
        {
            /// <summary>
            /// properties for element
            /// </summary>
            public Element Next { get; set; }

            /// <summary>
            /// properties for element
            /// </summary>
            public int Value { get; set; }
        }

        /// <summary>
        /// push element with value to the stack
        /// </summary>
        /// <param name="value"></param>
        public void Push(int value)
        {
            Element newElement = new Element()
            {
                Next = head,
                Value = value
            };

            head = newElement;
        }

        /// <summary>
        /// return value from the stack and delete it from the stack
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (head != null)
            {
                int temp = head.Value;
                head = head.Next;
                return temp;
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }

        /// <summary>
        /// return value from the stack
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (head != null)
            {
                return head.Value;
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }

        /// <summary>
        /// return 'true' if stack is empty and 'false' if it's not empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (head == null);
        }

        private Element head;
    }
}
