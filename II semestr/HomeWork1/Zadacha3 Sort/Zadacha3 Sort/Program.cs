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
 * 6)
 * Input length of array:
r
Wrong input!

Input length of array:
5
Input array(between elements must be ' ' !):
1 2 3 4 f
Wrong input!

Input array(between elements must be ' ' !):
 1 3 2 4 f
Wrong input!

Input array(between elements must be ' ' !):
1 2 3 4 1
Sorted array:
1 1 2 3 4
Для продолжения нажмите любую клавишу . . .
 * 7)
 * Input length of array:
10
Input array(between elements must be ' ' !):
q e d f g
Wrong input!

Input array(between elements must be ' ' !):
1 f
Wrong input!

Input array(between elements must be ' ' !):
1 5 3 4 10 23 20 15 4 23
Sorted array:
1 3 4 4 5 10 15 20 23 23
Для продолжения нажмите любую клавишу . . .
*/
using System;

namespace Zadacha3_Sort
{
    class Program
    {
        // swap elements in array with indexes i and j
        public static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        // bubblesort of array
        public static void BubbleSort(int[] array)
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

        public static void Main(string[] args)
        {
            Console.WriteLine("Input length of array:");
            string input = Console.ReadLine();
            int length = 0;
            while (!int.TryParse(input, out length) || length <= 0)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.WriteLine("Input length of array:");
                input = Console.ReadLine();
            }
            int[] arrayOfNumbers = new int[length];
            string stringWithElements = " ";
            bool goodInput = false;
            while (!goodInput)
            {
                Console.WriteLine("Input array(between elements must be ' ' !):");
                stringWithElements = Console.ReadLine();
                string[] arrayOfElements = stringWithElements.Split(' ');
                for (int i = 0; i < length; i++)
                {
                    if (int.TryParse(arrayOfElements[i], out arrayOfNumbers[i]))
                    {
                        goodInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine();
                        goodInput = false;
                        break;
                    }
                }
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
