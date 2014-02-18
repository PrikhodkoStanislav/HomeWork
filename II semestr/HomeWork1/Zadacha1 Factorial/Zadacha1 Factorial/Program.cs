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
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1_Factorial
{
    class Program
    {
        static int Factorial(int number)
        {
            if (number == 0)
                return 1;
            return number * Factorial(number - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factorial = {0}", Factorial(number));
        }
    }
}
