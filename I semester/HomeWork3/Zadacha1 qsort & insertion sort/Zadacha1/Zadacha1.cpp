/*Tests:
Input length of array
15
Input source array
1 2 3 4 15 14 13 12 11 10 5 6 9 8 7
Sorted array:
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 Для продолжения нажмите любую клавишу . . .

Input length of array
10
Input source array
15 17 48 43 10 555 45 48 42 10
Sorted array:
10 10 15 17 42 43 45 48 48 555 Для продолжения нажмите любую клавишу . . .

Input length of array
10
Input source array
15 17 23 4 1 5 21 20 7 10
Sorted array:
1 4 5 7 10 15 17 20 21 23 Для продолжения нажмите любую клавишу . . .

Input length of array
15
Input source array
1 2 3 4 15 14 13 12 11 10 5 6 9 8 7
Sorted array:
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 Для продолжения нажмите любую клавишу . . .

Input length of array
23
Input source array
7 8 1 4 5 23 25 17 18 10 11 14 15 21 22 20 16 19 9 6 3 2 23
Sorted array:
1 2 3 4 5 6 7 8 9 10 11 14 15 16 17 18 19 20 21 22 23 23 25 Для продолжения нажм
ите любую клавишу . . .
*/
#include <iostream>

using namespace std;

void sortInsertion(int arraySource[100], int left, int right)
{
	for (int i = left + 1; i <= right; i++)
	{
		while (arraySource[i] < arraySource[i - 1])
		{
			int variable = arraySource[i];
			arraySource[i] = arraySource[i - 1];
			arraySource[i - 1] = variable;
			i--;
		}
	}
}

void quickSort(int arraySource[100], int left, int right)
{
	int leftTeller = left;
	int rightTeller = right;
	int referenceElement = arraySource[left];
	int reference1 = arraySource[left];
	int reference2 = arraySource[left + 1];
	int cellOfArray = 1;
	if ((right - left) >= 9)
	{
		while (reference1 == reference2 && cellOfArray < rightTeller)
		{
			cellOfArray++;
			reference2 = arraySource[cellOfArray];
		}
		if (reference1 != reference2)
		{
			if (reference2 > reference1)
				referenceElement = reference2;
			else
				referenceElement = reference1;
			while (leftTeller <= rightTeller)
			{
				while (arraySource[leftTeller] < referenceElement)
					leftTeller++;
				while (arraySource[rightTeller] > referenceElement)
					rightTeller--;
				if (leftTeller <= rightTeller)
				{
					int variable = arraySource[leftTeller];
					arraySource[leftTeller] = arraySource[rightTeller];
					arraySource[rightTeller] = variable;
					leftTeller++;
					rightTeller--;
				}
			}
			if (left < rightTeller)
				quickSort(arraySource, left, rightTeller);
			if (leftTeller < right)
				quickSort(arraySource, leftTeller, right);
		}
	}
	else
		sortInsertion(arraySource, left, right);
}

int main()
{
	cout << "Input length of array\n";
	int length = 0;
	cin >> length;
	cout << "Input source array\n";
	int arraySource[100];
	for (int i = 0; i < length; i++)
		cin >> arraySource[i];
	quickSort(arraySource, 0, length - 1);
	cout << "Sorted array:\n";
	for (int i = 0; i < length; i++)
		cout << arraySource[i] << " ";
	return 0;
}