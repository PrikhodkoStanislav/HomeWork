/* Tests:
Source array:
25 23 17 15 18 10 17 25 20 23
The most common element(-s) = 17 23 25 25 Для продолжения нажмите любую клавишу
. . .

Source array:
1 5 2 4 1 5 2 7 4
The most common element(-s) = 1 2 4 5 Для продолжения нажмите любую клавишу . .
.

Source array:
1 10 15 17 23 15 14 27 18 20 11 32 37 15 17 48 42 23 55 51 21 10 55
The most common element(-s) = 15 Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>
#include "Sort.h"

using namespace std;

int main()
{
	ifstream infile("InputZ2.in");
	ofstream outfile("OutputZ2.out");
	int lengthOfArray = 0;
	infile >> lengthOfArray;
	int arraySource[100];
	if (!infile.is_open())
		cout << "File can not open\n";
	else
	{
		cout << "Source array:\n";
		for (int i = 1; i <= lengthOfArray; i++)
		{
			infile >> arraySource[i];
			cout << arraySource[i] << " ";
		}
	}
	infile.close();
	sort(arraySource, lengthOfArray);
	int number = 1;
	int maxNumber = 0;
	int count = 0;
	for (int i = 2; i <= lengthOfArray; i++)
	{
		if (arraySource[i] == arraySource[i - 1])
			number++;
		else
			number = 1;
		if (number == maxNumber)
			count++;
		if (number > maxNumber)
		{
			count = 1;
			maxNumber = number;
		}
	}
	outfile << count << " ";
	if (maxNumber == 1)
	{

		outfile << arraySource[1] << " ";
	}
	number = 1;
	for (int i = 2; i <= lengthOfArray; i++)
	{
		if (arraySource[i] == arraySource[i - 1])
			number++;
		else
			number = 1;
		if (number == maxNumber)
			outfile << arraySource[i] << " ";
	}
	outfile.close();
	ifstream resultfile("OutputZ2.out");
	int elements = 0;
	int countOfElements = 0;
	if (!resultfile.is_open())
		cout << "\nFile can not open\n";
	else
	{
		cout << "\nThe most common element(-s) = ";
		resultfile >> countOfElements;
		for (int i = 0; i < countOfElements; i++)
		{
			resultfile >> elements;
			cout << elements << " ";
		}
	}
	resultfile.close();
	return 0;
}