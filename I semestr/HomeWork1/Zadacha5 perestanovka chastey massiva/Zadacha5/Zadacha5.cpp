#include <iostream>

using namespace std;

void overturn(int array1[10], int left, int right)
{
	int CenterOfArray = (right - left + 1) / 2;
	for (int i = 0; i < CenterOfArray; i++)
	{
		array1[left + i - 1] = array1[left + i - 1] ^ array1[right - i - 1];
		array1[right - i - 1] = array1[right - i - 1] ^ array1[left + i - 1];
		array1[left + i - 1] = array1[right - i - 1] ^ array1[left + i - 1];
	}
}

int main()
{
	cout << "Input length of array \n";
	int LengthOfArray = 0;
	cin >> LengthOfArray;
	cout << "Input array \n" ;
	int array1[10];
	for (int i = 0; i < LengthOfArray; i++)
	{
		cin >> array1[i];
	}
	cout << "Input m \n";
	int separator = 0;
	cin >> separator;
	overturn(array1, 1, separator);
	overturn(array1, separator + 1, LengthOfArray);
	overturn(array1, 1, LengthOfArray);
	cout << "New array \n";
	for (int i = 0; i < LengthOfArray; i++)
		cout << array1[i] << " ";
}