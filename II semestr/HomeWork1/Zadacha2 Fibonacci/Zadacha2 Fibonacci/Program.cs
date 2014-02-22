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
 * 6)
 * Input number:
qw
Wrong input!

Input number:
as
Wrong input!

Input number:
ad
Wrong input!

Input number:
3a
Wrong input!

Input number:
3
Fibonacci number = 2
Для продолжения нажмите любую клавишу . . .
 * 7)
 * Input number:
45w
Wrong input!

Input number:
15
Fibonacci number = 610
Для продолжения нажмите любую клавишу . . .
 */
using System;

namespace Zadacha2_Fibonacci
{
    class Program
    {
        // fubbonacci number
        public static int FibonacciNumber(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            return FibonacciNumber(number - 1) + FibonacciNumber(number - 2);
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            string input = Console.ReadLine();
            int number = 0;
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.WriteLine("Input number:");
                input = Console.ReadLine();
            }
            Console.WriteLine("Fibonacci number = {0}", FibonacciNumber(number));
        }
    }
}
