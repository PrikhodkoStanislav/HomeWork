/*Tests:
Input length of array and number of elements:
5
2
How do You enter the array?
 1 - random
 2 (or not 1) - manual input
1
Source array:
16886
26874
4851
29803
15497

How do You enter the element(-s)?
 1 - random
 2 (or not 1) - manual input
2
Input element(-s):
4851
Number enter in array
2000
No number in array
Для продолжения нажмите любую клавишу . . .

Input length of array and number of elements:
15
5
How do You enter the array?
 1 - random
 2 (or not 1) - manual input
1
Source array:
17258
7008
9750
20509
11710
4906
29609
15574
2694
10818
25430
5936
9876
24320
2983

How do You enter the element(-s)?
 1 - random
 2 (or not 1) - manual input
1
Element(-s):
9949
No number in array
18663
No number in array
16949
No number in array
18615
No number in array
27618
No number in array
Для продолжения нажмите любую клавишу . . .

Input length of array and number of elements:
10
3
How do You enter the array?
 1 - random
 2 (or not 1) - manual input
2
Input array:
150 15 2 45 80 3 14 2 45 40

How do You enter the element(-s)?
 1 - random
 2 (or not 1) - manual input
2
Input element(-s):
2
Number enter in array
200
No number in array
15
Number enter in array
Для продолжения нажмите любую клавишу . . .

Input length of array and number of elements:
5
3
How do You enter the array?
 1 - random
 2 (or not 1) - manual input
2
Input array:
10 5 150 200 1

How do You enter the element(-s)?
 1 - random
 2 (or not 1) - manual input
1
Element(-s):
17605
No number in array
32227
No number in array
2809
No number in array
Для продолжения нажмите любую клавишу . . .

Input length of array and number of elements:
10
5
How do You enter the array?
 1 - random
 2 (or not 1) - manual input
2
Input array:
15 20 150 1502 48 45 18 50 100 23

How do You enter the element(-s)?
 1 - random
 2 (or not 1) - manual input
2
Input element(-s):
23
Number enter in array
70
No number in array
300
No number in array
17
No number in array
239
No number in array
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <stdlib.h>
#include <time.h>

using namespace std;


void quickSort(int arrayOfNumbers[5000], int l, int n)
{
	int left = l;
	int right = n;
	int support = arrayOfNumbers[1];
	int i = 1;
	while (arrayOfNumbers[i] == arrayOfNumbers[l] && i <= right)
		i++;
	if (i <= right)
	{
		support = max(arrayOfNumbers[l], arrayOfNumbers[i]);
		while (left <= right)
		{
			while (arrayOfNumbers[left] < support)
				left++;
			while (arrayOfNumbers[right] > support)
				right--;
			if (left <= right)
			{
				int variable = arrayOfNumbers[left];
				arrayOfNumbers[left] = arrayOfNumbers[right];
				arrayOfNumbers[right] = variable;
				left++;
				right--;
			}
		}
		if (l < right)
			quickSort(arrayOfNumbers, l, right);
		if (left < n)
			quickSort(arrayOfNumbers, left, n);
	}
}

bool binarySearch(int arrayOfNumbers[5000], int left, int right, int number)
{
	while (left < right)
	{
		if (arrayOfNumbers[(right + left) / 2] > number)
		{
			right = (right + left) / 2 - 1;
			binarySearch(arrayOfNumbers, left, right, number);
		}
		if (arrayOfNumbers[(right + left) / 2] < number)
		{
			left = (right + left) / 2 + 1;
			binarySearch(arrayOfNumbers, left, right, number);
		}
		if (arrayOfNumbers[(right + left) / 2] == number)
			return true;
	}
		return arrayOfNumbers[left] == number;
}

int main()
{
	srand(time(0));
	cout << "Input length of array and number of elements:\n";
	int length = 0;
	int numberOfElements = 0;
	cin >> length >> numberOfElements;
	int arrayOfNumbers[5000];
	cout << "How do You enter the array?\n 1 - random\n 2 (or not 1) - manual input\n";
	int variable = 0;
	cin >> variable;
	if (variable == 1)
	{
		cout << "Source array:\n";
		for (int i = 0; i < length; i++)
		{
			arrayOfNumbers[i] = rand();
			cout << arrayOfNumbers[i] << " \n";
		}
	}
	else
	{
		cout << "Input array:\n";
		for (int i = 0; i < length; i++)
			cin >> arrayOfNumbers[i];
	}
	cout << " \n";
	quickSort(arrayOfNumbers, 0, length - 1);
	cout << "Sorted array:\n";
	for (int i = 0; i < length; i++)
		cout << arrayOfNumbers[i] << " ";
	cout << "How do You enter the element(-s)?\n 1 - random\n 2 (or not 1) - manual input\n";
	cin >> variable;
	if (variable == 1)
	{
		cout << "Element(-s):\n";
		for (int i = 0; i < numberOfElements; i++)
		{
			int number = rand();
			cout << number << " \n";
			if (binarySearch(arrayOfNumbers, 0, length - 1, number))
				cout << "Number enter in array\n";
			else
				cout << "No number in array\n";
		}
	}
	else
	{
		cout << "Input element(-s):\n";
		for (int i = 0; i < numberOfElements; i++)
		{
			int number;
			cin >> number;
			if (binarySearch(arrayOfNumbers, 0, length - 1, number))
				cout << "Number enter in array\n";
			else
				cout << "No number in array\n";
		}
	}
	return 0;
}