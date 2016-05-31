/*Tests:
Input length of array:
10
Input array of numbers
1 48 5 214 325 415 48545 12 48 555

NumbersWithMaxSumOfFigures = 48545 Для продолжения нажмите любую клавишу . . .

Input length of array:
1
Input array of numbers
15

NumbersWithMaxSumOfFigures = 15 Для продолжения нажмите любую клавишу . . .

Input length of array:
5
Input array of numbers
18 45 75 412 44

NumbersWithMaxSumOfFigures = 75 Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;

int main()
{
	cout << "Input length of array <= 1000:\n";
	int lengthOfArray = 0;
	cin >> lengthOfArray;
	cout << "Input array of numbers:\n";
	int arrayOfNumbers[1000];
	for (int i = 0; i < lengthOfArray; i++)
	{
		cin >> arrayOfNumbers[i];
	}
	int maxSumOfFigures = 0;
	int arrayOfNumbersWithMaxSumOfFigures[1000];
	int firstPlaceOfArrayOfNumbersWithMaxSumOfFigures = 0;
	for (int i = 0; i < lengthOfArray; i++)
	{
		int sumOfFigures = 0;
		int variable = arrayOfNumbers[i];  // decompose numbers by the figures
		while (variable > 0)
		{
			sumOfFigures += variable % 10;  // save the remainder
			variable = variable / 10;
		}
		if (sumOfFigures == maxSumOfFigures)
		{
			arrayOfNumbersWithMaxSumOfFigures[firstPlaceOfArrayOfNumbersWithMaxSumOfFigures] = arrayOfNumbers[i];  // save all of numbers with max sum of figures
			++firstPlaceOfArrayOfNumbersWithMaxSumOfFigures;
		}
		if (sumOfFigures > maxSumOfFigures)
		{
			maxSumOfFigures = sumOfFigures;
			firstPlaceOfArrayOfNumbersWithMaxSumOfFigures = 0;  // delete all previous numbers
			arrayOfNumbersWithMaxSumOfFigures[firstPlaceOfArrayOfNumbersWithMaxSumOfFigures] = arrayOfNumbers[i];
			++firstPlaceOfArrayOfNumbersWithMaxSumOfFigures;
		}
	}
	cout << "\nNumbersWithMaxSumOfFigures = ";
	for (int i = 0; i < firstPlaceOfArrayOfNumbersWithMaxSumOfFigures; i++)
	{
		cout << arrayOfNumbersWithMaxSumOfFigures[i] <<" ";
	}
	return 0;
}