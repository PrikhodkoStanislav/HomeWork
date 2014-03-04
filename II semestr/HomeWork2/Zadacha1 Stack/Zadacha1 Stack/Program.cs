/*
 * Test:
 * 
 * Stack is not empty!
Last element = 25
Elements in stack: 25, 20, 10, 7, 5
Для продолжения нажмите любую клавишу . . .
 * */
using System;

namespace Zadacha1_Stack
{
    /// <summary>
    /// class of stack
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// class of element with value and reference on next element
        /// </summary>
        private class Element
        {
            private int value;
            public Element Next { get; set; }

            /// <summary>
            /// properties for element
            /// </summary>
            public int Value
            {
                get
                {
                    return value;
                }

                set
                {
                    this.value = value;
                }
            }
        }

        /// <summary>
        /// constuctor of clear stack
        /// </summary>
        public Stack()
        {
            this.head = null;
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
    
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(5);
            stack.Push(7);
            stack.Push(10);
            stack.Push(20);
            stack.Push(25);
            if (stack.IsEmpty())
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            else
            {
                Console.WriteLine("Stack is not empty!");
            }
            Console.WriteLine("Last element = {0}", stack.Peek());
            Console.WriteLine("Elements in stack: {0}, {1}, {2}, {3}, {4}", stack.Pop(), stack.Pop(), stack.Pop(), stack.Pop(), stack.Pop());
        }
    }
}
