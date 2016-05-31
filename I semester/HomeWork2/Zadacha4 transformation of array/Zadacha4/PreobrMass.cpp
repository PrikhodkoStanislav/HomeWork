#include <iostream>
#include <stdlib.h>

using namespace std;

int main()
{
	cout << "Input length of array\n";
	int length = 0;
	cin >> length;
	int array1[100];
	cout << "Initial array\n";
	for (int i = 0; i < length; i++)
	{
		array1[i] = rand() % 100 + 1;
		cout << array1[i] << " ";
	}
	cout << "\n";
	int centralPoint = array1[0];
	int left = 0;
	int right = length - 1;
	int variable = 2;
	while (left < right)
	{
		while (array1[left] < centralPoint)
			left++;
		while (array1[right] > centralPoint)
			right--;
		if (left < right)
		{
			array1[left] = array1[left] ^ array1[right];
			array1[right] = array1[left] ^ array1[right];
			array1[left] = array1[left] ^ array1[right];
			if (variable % 2 == 0)
				left++;
			else
				right--;
			variable++;
		}
	}
	cout << "New array\n";
	for (int i = 0; i < length; i++)
		cout << array1[i] << " ";
	return 0;
}