#include <iostream>

using namespace std;

int main()
{
	cout << "Input length of array (length < 10)\n";
	int length = 0;
	cin >> length;
	cout << "Input array\n";
	int array1[10];
	for (int i = 0; i < length; i++)
		cin >> array1[i];
	for (int i = 0; i < (length - 1); i++)
	{
		for (int j = 0; j < (length - i - 1); j++)
		{
			if (array1[j] > array1[j+1])
			{
				int variable = array1[j];
				array1[j] = array1[j + 1];
				array1[j + 1] = variable;
			}
		}
	}
	cout << "Sorted array\n";
	for (int i = 0; i < length; i++)
		cout << array1[i] << " ";
	return 0;
}