/*
 * Tests:
 * 1)
 * Input length of array:
5
Input array:
5 3 4 2 1
Sorted array:
1 2 3 4 5
Для продолжения нажмите любую клавишу . . .
 * 2)
 * Input length of array:
7
Input array:
1 5 2 4 7 8 3
Sorted array:
1 2 3 4 5 7 8
Для продолжения нажмите любую клавишу . . .
 * 3)
 * Input length of array:
3
Input array:
20 27 15
Sorted array:
15 20 27
Для продолжения нажмите любую клавишу . . .
 * 4)
 * Input length of array:
4
Input array:
4 2 3 18
Sorted array:
2 3 4 18
Для продолжения нажмите любую клавишу . . .
 * 5)
 * Input length of array:
5
Input array:
10 23 5 25 20
Sorted array:
5 10 20 23 25
Для продолжения нажмите любую клавишу . . .
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3_Sort
{
    class Program
    {
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        Swap(array, j, j + 1);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input length of array:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input array:");
            int[] arrayOfNumbers = new int[length];
            string stringWithElements = Console.ReadLine();
            string[] arrayOfElements = stringWithElements.Split(' ');
            for (int i = 0; i < length; i++)
            {
                arrayOfNumbers[i] = Convert.ToInt32(arrayOfElements[i]);
            }
            BubbleSort(arrayOfNumbers);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} ", arrayOfNumbers[i]);
            }
            Console.WriteLine();
        }
    }
}
