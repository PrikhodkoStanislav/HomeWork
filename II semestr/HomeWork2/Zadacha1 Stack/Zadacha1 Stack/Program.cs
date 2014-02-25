using System;

namespace Zadacha1_Stack
{
    public class Element
    {
        private int value;
        private Element next;
        public Element(int value)
        {
            this.value = value;
            this.next = null;
        }

        public Element(int value, Element next)
        {
            this.value = value;
            this.next = next;
        }

        public int ReturnValue()
        {
            return value;
        }

        public Element ReturnNext()
        {
            return next;
        }
    }

    public class Stack
    {
        private Element lastElement;
        private int stackSize;

        public Stack()
        {
            this.lastElement = null;
            this.stackSize = 0;
        }

        public int Size()
        {
            return stackSize;
        }

        public void Push(int value)
        {
            if (stackSize == 0)
            {
                Element element = new Element(value);
                lastElement = element;
            }
            else
            {
                Element element = new Element(value, lastElement);
                lastElement = element;
            }
            stackSize += 1;
        }

        public int Pop()
        {
            if (stackSize > 0)
            {
                Element variable = lastElement;
                lastElement = lastElement.ReturnNext();
                stackSize -= 1;
                return variable.ReturnValue();
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }

        public int Peek()
        {
            if (stackSize > 0)
            {
                return lastElement.ReturnValue();
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return 0;
            }
        }
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
            Console.WriteLine("Stack size = {0}", stack.Size());
            Console.WriteLine("Last element = {0}", stack.Peek());
            Console.WriteLine("Elements in stack: {0}, {1}, {2}, {3}, {4}", stack.Pop(), stack.Pop(), stack.Pop(), stack.Pop(), stack.Pop());
        }
    }
}
