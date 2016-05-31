#include <iostream>

using namespace std;

int main()
{
	cout << "Input length of array (length < 20)\n";
	int length = 0;
	cin >> length;
	cout << "Input array (min >= 0, max < 100)\n";
	int sourceArray[20];
	for (int i = 0; i < length; i++)
		cin >> sourceArray[i];
	int auxiliaryArray[100];
	for (int i = 0; i < 100; i++)
		auxiliaryArray[i] = 0;
	int maximum = 0;
	for (int i = 0; i < length; i++)
	{
		auxiliaryArray[sourceArray[i]]++;
		if (maximum < sourceArray[i])
			maximum = sourceArray[i];
	}
	int variable = 0;
	for (int i = 0; i <= maximum; i++)
	{
		while (auxiliaryArray[i] > 0)
		{
			sourceArray[variable] = i;
			variable++;
			auxiliaryArray[i]--;
		}
	}
	cout << "Sorted array\n";	
	for (int i = 0; i < length; i++)
	{
		cout << sourceArray[i] << " ";
	}
	return 0;
}