#include <iostream>

using namespace std;

int main()
{
	cout << "Input length of array \n";
	int lengthOfArray = 0;
	cin >> lengthOfArray;
	cout << "Input array \n";
	int const length = 100;
	int array1[length];
	for (int i = 0; i < lengthOfArray; i++)
		cin >> array1[i];
	int countOfZero = 0;
	for (int i = 0; i < lengthOfArray; i++)
	{
		if (array1[i] == 0)
			countOfZero++;
	}
	cout << "Count of zero = " << countOfZero;
	return 0;
}