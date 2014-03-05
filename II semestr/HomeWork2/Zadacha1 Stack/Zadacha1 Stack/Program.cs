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
