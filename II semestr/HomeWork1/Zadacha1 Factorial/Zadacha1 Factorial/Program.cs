/*
 * Tests:
 * 1)
 * Input number:
5
Factorial = 120
Для продолжения нажмите любую клавишу . . .
 * 2)
 * Input number:
10
Factorial = 3628800
Для продолжения нажмите любую клавишу . . .
 * 3)
 * Input number:
0
Factorial = 1
Для продолжения нажмите любую клавишу . . .
 * 4)
 * Input number:
f
Wrong input!

Input number:
d
Wrong input!

Input number:
s
Wrong input!

Input number:
asd
Wrong input!

Input number:
1-w
Wrong input!

Input number:
1-
Wrong input!

Input number:
5
Factorial = 120
Для продолжения нажмите любую клавишу . . .
 * 5)
 * Input number:
2q
Wrong input!

Input number:
25
Factorial = 2076180480
Для продолжения нажмите любую клавишу . . .
*/
using System;

namespace Zadacha1_Factorial
{
    class Program
    {
        // factorial number
        public static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
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
            Console.WriteLine("Factorial = {0}", Factorial(number));
        }
    }
}
