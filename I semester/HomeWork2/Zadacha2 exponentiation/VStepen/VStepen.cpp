#include <iostream>

using namespace std;

int inPower(int number, int power)
{
	int result = 1;
	while (power > 0)
	{
		if (power % 2 == 0)
		{
			power /= 2;
			number *= number;
		}
		else
		{
			power--;
			result *= number;
		}
	}
	return result;
}

int main()
{
	cout << "Input natural number\n";
	int number = 0;
	cin >> number;
	cout << "Input natural power\n";
	int power = 0;
	cin >> power;
	cout << "Result = " << inPower(number, power);
	return 0;
}