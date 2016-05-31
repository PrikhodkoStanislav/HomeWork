/*
Tests:

Input array (length of array = 10):
1 5 4 2 1 5 48 54 21 22
Sorted array:
1 1 2 4 5 5 21 22 48 54 Для продолжения нажмите любую клавишу . . .

Input array (length of array = 10):
4 8 5 4 1 3 2 1 5 48
Sorted array:
1 1 2 3 4 4 5 5 8 48 Для продолжения нажмите любую клавишу . . .

Input array (length of array = 10):
20 19 18 17 16 15 14 11 12 13
Sorted array:
11 12 13 14 15 16 17 18 19 20 Для продолжения нажмите любую клавишу . . .

Input array (length of array = 10):
10 8 7 5 4 3 2 1 15 23
Sorted array:
1 2 3 4 5 7 8 10 15 23 Для продолжения нажмите любую клавишу . . .

Input array (length of array = 10):
1 2 3 4 5 5 4 3 2 1
Sorted array:
1 1 2 2 3 3 4 4 5 5 Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;

void bubbleSort(int arrayOfNumbers[10])
{
    for (int left = 0; left < 9; left++)  // move the left edge, because everything is already sorted
    {
        for (int i = 9; i > left; i--)  /* iterating through all the elements to the right of the left edge
                                           and looking for a minimum promoting smaller item at the beginning
                                           of the examined part of the array*/
        {
            if (arrayOfNumbers[i] < arrayOfNumbers[i - 1])
            {
                int variable = arrayOfNumbers[i];
                arrayOfNumbers[i] = arrayOfNumbers[i - 1];
                arrayOfNumbers[i - 1] = variable;
            }
        }
    }
}

int main()
{
	cout << "Input array (length of array = 10):\n";
	int arrayOfNumbers[10];
	for (int i = 0; i < 10; i++)
	{
		cin >> arrayOfNumbers[i];
	}
    bubbleSort(arrayOfNumbers);
	cout << "Sorted array:\n";
	for (int i = 0; i < 10; i++)
	{
		cout << arrayOfNumbers[i] << " ";
	}
	return 0;
}