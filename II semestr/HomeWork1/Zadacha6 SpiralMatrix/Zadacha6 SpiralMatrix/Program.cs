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
 * 4)
 * Input odd length of matrix:
3
Input matrix(between elements in the one line must be ' ' !):
1 2 3
4 5 6
7 8 9
Elements of matrix in the spiral form:
5 2 3 6 9 8 7 4 1
Для продолжения нажмите любую клавишу . . .
 * 5)
 * Input odd length of matrix:
fds
Wrong input!

Input length of matrix:
2
Wrong input!

Input length of matrix:
24
Wrong input!

Input length of matrix:
5
Input matrix(between elements in the one line must be ' ' !):
rewe rewer gfd
Wrong input!

Input matrix(between elements in the one line must be ' ' !):
4 3 fd
Wrong input!

Input matrix(between elements in the one line must be ' ' !):
1 2 3 4 5
6 7 8 9 10
11 12 13 14 15
16 17 18 19 20
21 22 23 24 25
Elements of matrix in the spiral form:
13 8 9 14 19 18 17 12 7 2 3 4 5 10 15 20 25 24 23 22 21 16 11 6 1
Для продолжения нажмите любую клавишу . . .
 */
using System;

namespace Zadacha6_SpiralMatrix
{
    class Program
    {
        // modificate indexLine and indexColumn of next output element
        public static void Modification(ref int indexLine, ref int indexColumn, int length)
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
        }

        // output matrix with length in spiral form
        public static void OutputMatrixInSpiralForm(int [,]matrix, int length)
        {
            Console.WriteLine("Elements of matrix in the spiral form:");
            int indexLine = length / 2;
            int indexColumn = length / 2;
            Console.Write("{0} ", matrix[indexLine, indexColumn]);
            for (int i = 1; i < length * length; i++)
            {
                Modification(ref indexLine, ref indexColumn, length);
                Console.Write("{0} ", matrix[indexLine, indexColumn]);
            }
            Console.WriteLine();
        }

        // input matrix with length
        public static void InputMatrix(int [,]matrix, int length)
        {
            bool goodInput = false;
            while (!goodInput)
            {
                Console.WriteLine("Input matrix(between elements in the one line must be ' ' !):");
                for (int i = 0; i < length; i++)
                {
                    string stringWithElementsOfLine = Console.ReadLine();
                    string[] stringWithNumbers = stringWithElementsOfLine.Split(' ');
                    for (int j = 0; j < length; j++)
                    {
                        if (int.TryParse(stringWithNumbers[j], out matrix[i, j]))
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
                    if (!goodInput)
                    {
                        break;
                    }
                }
            }
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Input odd length of matrix:");
            string input = Console.ReadLine();
            int length = 0;
            while (!int.TryParse(input, out length) || length <= 0 || length % 2 == 0)
            {
                Console.WriteLine("Wrong input!");
                Console.WriteLine();
                Console.WriteLine("Input length of matrix:");
                input = Console.ReadLine();
            }
            int[,] matrix = new int[length, length];
            InputMatrix(matrix, length);
            OutputMatrixInSpiralForm(matrix, length);
        }
    }
}
