/* Tests:

Input length of array (length > 0, length < 100)
5
Input array
1 2 4 4 5
The most common element(-s) = 4 Для продолжения нажмите любую клавишу . . .

Input length of array (length > 0, length < 100)
10
Input array
1 2 3 3 4 5 7 7 10 4
The most common element(-s) = 3 4 7 Для продолжения нажмите любую клавишу . . .

Input length of array (length > 0, length < 100)
10
Input array
10 8 7 5 4 1 2 3 10 5
The most common element(-s) = 5 10 Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;

void sort(int arraySorce[100], int right)
{
	int maxSon = 0;
	int maxNumber = 0;
	for (int i = ((right - 1) / 2); i >= 1; i--)
	{
		if ((right % 2 == 0) && (i == right / 2))
		{
			maxSon = arraySorce[2 * i];
			maxNumber = 2 * i;
		}
		else
		{
			if (arraySorce[2 * i + 1] > arraySorce[2 * i])
			{
				maxSon = arraySorce[2 * i + 1];
				maxNumber = 2 * i + 1;
			}
			else
			{
				maxSon = arraySorce[2 * i];
				maxNumber = 2 * i;
			}
		}
		if (arraySorce[i] < maxSon)
		{
			int variable = arraySorce[i];
			arraySorce[i] = arraySorce[maxNumber];
			arraySorce[maxNumber] = variable;
		}
	}
	int variable = arraySorce[right];
	arraySorce[right] = arraySorce[1];
	arraySorce[1] = variable;
	if (right > 2) 
		sort(arraySorce, right - 1);
}

int main()
{
	cout << "Input length of array (length > 0, length < 100)\n";
	int lengthOfArray = 0;
	cin >> lengthOfArray;
	cout << "Input array\n";
	int arraySource[100];
	for (int i = 1; i <= lengthOfArray; i++)
		cin >> arraySource[i];
	sort(arraySource, lengthOfArray);
	int number = 1;
	int maxNumber = 0;
	for (int i = 2; i <= lengthOfArray; i++)
	{
		if (arraySource[i] == arraySource[i-1])
			number++;
		else
			number = 1;
		if (number > maxNumber)
			maxNumber = number;
	}
	cout << "The most common element(-s) = ";
	if (maxNumber == 1)
		cout << arraySource[1] << " ";
	number = 1;
	for (int i = 2; i <= lengthOfArray; i++)
	{
		if (arraySource[i] == arraySource[i - 1])
			number++;
		else
			number = 1;
		if (number == maxNumber)
			cout << arraySource[i] << " ";
	}
	return 0;
}