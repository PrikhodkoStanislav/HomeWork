/*Tests:
Input number of elements:
10
Input array of elements:
20 17 48 52 17 94 48 100 27 15
Sorted array:
15 17 17 20 27 48 48 52 94 100 Для продолжения нажмите любую клавишу . . .

Input number of elements:
5
Input array of elements:
5 4 3 2 1
Sorted array:
1 2 3 4 5 Для продолжения нажмите любую клавишу . . .

Input number of elements:
15
Input array of elements:
15 10 1 18 12 7 8 3 5 23 14 25 20 11 30
Sorted array:
1 3 5 7 8 10 11 12 14 15 18 20 23 25 30 Для продолжения нажмите любую клавишу .
. .
*/
#include <iostream>

using namespace std;

void swap(int arrayOfElements[], int i, int j)  // swap the elements in array of elements with indexes "i" and "j"
{
	int variable = arrayOfElements[i];
	arrayOfElements[i] = arrayOfElements[j];
	arrayOfElements[j] = variable;
}

int main()
{
	cout << "Input number of elements:" << endl;
	int numberOfElements = 0;
	cin >> numberOfElements;  // input number of elements in the array to work with him
	cout << "Input array of elements:" << endl;
	const int maxLengthOfArray = 1000;  // const variable of max length of array
	int arrayOfElements[maxLengthOfArray];
	for(int i = 0; i < maxLengthOfArray; i++)  // zeroing array of elements
	{
		arrayOfElements[i] = 0;
	}
	for(int i = 0; i < numberOfElements; i++)  // input all elements of array with length = number of elements
	{
		cin >> arrayOfElements[i];
	}
	for(int k = 0; k < numberOfElements - 1; k++)  // iterate through all of the right border of the segment
	{
		for(int i = 0; i < numberOfElements - k - 1; i++)  // maximum of [element with index 0 -- element with index (numberOfElements - k - 1)] is "pops up" in cycle
		{
			if (arrayOfElements[i] > arrayOfElements[i + 1])
			{
				swap(arrayOfElements, i, i + 1);  // maximum of two elements is rise up
			}
		}
	}
	cout << "Sorted array:" << endl;
	for(int i = 0; i < numberOfElements; i++)  // output sorted array of elements
	{
		cout << arrayOfElements[i] << " ";
	}
	return 0;
}