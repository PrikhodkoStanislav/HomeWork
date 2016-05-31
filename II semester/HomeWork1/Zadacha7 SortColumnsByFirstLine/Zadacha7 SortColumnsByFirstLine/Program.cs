/*
 * Tests:
 * 1)
 * Input numbers of lines:
1
Input numbers of columns:
5
Input elements of matrix:
3 4 2 7 1
Sorted matrix:
1 2 3 4 7
Для продолжения нажмите любую клавишу . . .
 * 2)
 * Input numbers of lines:
3
Input numbers of columns:
5
Input elements of matrix:
1 8 3 7 5
1 3 2 1 1
3 4 5 1 8
Sorted matrix:
1 3 5 7 8
1 2 1 1 3
3 5 8 1 4
Для продолжения нажмите любую клавишу . . .
 * 3)
 * Input numbers of lines:
5
Input numbers of columns:
5
Input elements of matrix:
10 23 20 25 5
1 3 4 15 5
1 3 2 5 5
10 10 5 15 55
1 2 5 5 5
Sorted matrix:
5 10 20 23 25
5 1 4 3 15
5 1 2 3 5
55 10 5 10 15
5 1 5 2 5
Для продолжения нажмите любую клавишу . . .
 * 4)
 * Input numbers of lines:
-1
Wrong input!

Input numbers of lines:
rewe
Wrong input!

Input numbers of lines:
2
Input numbers of columns:
fdsdf
Wrong input!

Input numbers of columns:
-4
Wrong input!

Input numbers of columns:
4
Input elements of matrix:
rew dfs  -4
Wrong input!

=f f
Wrong input!

1 2 3 -5
1 3 5 8
Sorted matrix:
-5 1 2 3
8 1 3 5
Для продолжения нажмите любую клавишу . . .
 * 5)
 * Input numbers of lines:
-11
Wrong input!

Input numbers of lines:
g
Wrong input!

Input numbers of lines:
e
Wrong input!

Input numbers of lines:
4
Input numbers of columns:
ewewew
Wrong input!

Input numbers of columns:
5
Input elements of matrix:
20 23 10 25 5
15 17 81 18 22
14 12 10 7 1
10 4 35 8 23
Sorted matrix:
5 10 20 23 25
22 81 15 17 18
1 10 14 12 7
23 35 10 4 8
Для продолжения нажмите любую клавишу . . .
 */
using System;

namespace Zadacha7_SortColumnsByFirstLine
{
    class Program
    {
        // swap columns with indexes i and j in array
        public static void SwapColumns(int[,] array, int i, int j)
        {
            for (int k = 0; k < array.GetLength(0); k++)
            {
                int temp = array[k, i];
                array[k, i] = array[k, j];
                array[k, j] = temp;
            }
        }

        // selectionSort of array
        public static void SelectionSort(int[,] array)
        {
            int minimumElement = array[0, 0];
            int index = 0;
            for (int j = 0; j < array.GetLength(1) - 1; j++)
            {
                for (int i = j + 1; i < array.GetLength(1); i++)
                {
                    if (array[0, i] < minimumElement)
                    {
                        minimumElement = array[0, i];
                        index = i;
                    }
                }
                SwapColumns(array, j, index);
                index = j + 1;
                minimumElement = array[0, index];
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input numbers of lines:");
            string input = Console.ReadLine();
            int m = 0;
            while (!int.TryParse(input, out m) || m <= 0)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.WriteLine("Input numbers of lines:");
                input = Console.ReadLine();
            }
            Console.WriteLine("Input numbers of columns:");
            input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n <= 0)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.WriteLine("Input numbers of columns:");
                input = Console.ReadLine();
            }
            Console.WriteLine("Input elements of matrix:");
            int[,] matrix = new int [m, n];
            bool correctInput = false;
            while (!correctInput)
            {
                for (int i = 0; i < m; i++)
                {
                    string stringOfLine = Console.ReadLine();
                    string[] stringWithLine = stringOfLine.Split(' ');
                    if (stringWithLine.Length != n)
                    {
                        Console.WriteLine("Wrong input!");
                        Console.WriteLine();
                        correctInput = false;
                        break;
                    }
                    for (int j = 0; j < n; j++)
                    {
                        if (int.TryParse(stringWithLine[j], out matrix[i, j]))
                        {
                            correctInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Wrong input!");
                            Console.WriteLine();
                            correctInput = false;
                            break;
                        }
                    }
                    if (!correctInput)
                    {
                        break;
                    }
                }
            }
            SelectionSort(matrix);
            Console.WriteLine("Sorted matrix:");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
