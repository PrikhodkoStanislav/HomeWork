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
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7_SortColumnsByFirstLine
{
    class Program
    {
        static void SwapColumns(int[,] array, int i, int j, int m)
        {
            for (int k = 0; k < m; k++)
            {
                int temp = array[k, i];
                array[k, i] = array[k, j];
                array[k, j] = temp;
            }
        }
        static void SelectionSort(int[,] array, int m, int n)
        {
            int minimumElement = array[0, 0];
            int index = 0;
            for (int j = 0; j < n - 1; j++)
            {
                for (int i = j + 1; i < n; i++)
                {
                    if (array[0, i] < minimumElement)
                    {
                        minimumElement = array[0, i];
                        index = i;
                    }
                }
                SwapColumns(array, j, index, m);
                index = j + 1;
                minimumElement = array[0, index];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Input numbers of lines:");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input numbers of columns:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input elements of matrix:");
            int[,] matrix = new int [m, n];
            for (int i = 0; i < m; i++)
            {
                string stringOfLine = Console.ReadLine();
                string[] stringWithLine = stringOfLine.Split(' ');
                for(int j = 0; j < n; j++)
                {   
                    matrix[i, j] = Convert.ToInt32(stringWithLine[j]);
                }
            }
            SelectionSort(matrix, m, n);
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
