#include <iostream>

using namespace std;

int main()
{
	cout << "Input natural number\n";
	int number = 0;
	cin >> number;
	cout << "Input natural power\n";
	int power = 0;
	cin >> power;
	int result = 1;
	for (int i = 0; i < power; i++)
	{
		result = result * number;
	}
	cout << "Result = " << result;
	return 0;
}