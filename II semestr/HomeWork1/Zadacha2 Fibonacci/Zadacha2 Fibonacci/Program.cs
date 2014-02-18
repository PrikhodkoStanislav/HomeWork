/*
 * Tests:
 * 1)
 * Input number:
5
Fibonacci number = 5
Для продолжения нажмите любую клавишу . . .
 * 2)
 * Input number:
15
Fibonacci number = 610
Для продолжения нажмите любую клавишу . . .
 * 3)
 * Input number:
25
Fibonacci number = 75025
Для продолжения нажмите любую клавишу . . .
 * 4)
 * Input number:
10
Fibonacci number = 55
Для продолжения нажмите любую клавишу . . .
 * 5)
 * Input number:
30
Fibonacci number = 832040
Для продолжения нажмите любую клавишу . . .
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2_Fibonacci
{
    class Program
    {
        static int FibonacciNumber(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci number = {0}", FibonacciNumber(number));
        }
    }
}
