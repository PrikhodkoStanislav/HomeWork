/*
 * Tests:
 * 1)
 * Input odd length of matrix:
3
Input matrix:
1 2 3
4 5 6
7 8 9
Elements of matrix in the spiral form:
5 2 3 6 9 8 7 4 1
Для продолжения нажмите любую клавишу . . .
 * 2)
 * Input odd length of matrix:
1
Input matrix:
1
Elements of matrix in the spiral form:
1
Для продолжения нажмите любую клавишу . . .
 * 3)
 * Input odd length of matrix:
5
Input matrix:
25 10 11 12 13
24 9 2 3 14
23 8 1 4 15
22 7 6 5 16
21 20 19 18 17
Elements of matrix in the spiral form:
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25
Для продолжения нажмите любую клавишу . . .
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6_SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input odd length of matrix:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input matrix:");
            int[,] matrix = new int[length, length];
            for (int i = 0; i < length; i++)
            {
                string stringWithElementsOfLine = Console.ReadLine();
                string[] stringWithNumbers = stringWithElementsOfLine.Split(' ');
                for (int j = 0; j < length; j++)
                {
                    matrix[i, j] = Convert.ToInt32(stringWithNumbers[j]); 
                }
            }
            Console.WriteLine("Elements of matrix in the spiral form:");
            int indexLine = length / 2;
            int indexColumn = length / 2;
            Console.Write("{0} ", matrix[indexLine, indexColumn]);
            for (int i = 1; i < length * length; i++)
            {
                // up
                if (((indexLine == indexColumn) && (indexLine == length - indexColumn - 1)) || ((indexLine <= length - indexColumn - 1) && (indexLine >= indexColumn)))
                {
                    indexLine--;
                }
                else
                {
                    // down
                    if (indexLine < indexColumn && (indexLine >= length - indexColumn - 1))
                    {
                        indexLine++;
                    }
                    else
                    {
                        // right
                        if (indexLine <= indexColumn && (indexLine < length - indexColumn - 1))
                        {
                            indexColumn++;
                        }
                        else
                        {
                            // left
                            indexColumn--;
                        }
                    }
                }
                Console.Write("{0} ", matrix[indexLine, indexColumn]);
            }
            Console.WriteLine();
        }
    }
}
