#include <iostream>

using namespace std;

int main()
{
	cout << "Input number\n";
	int number = 0;
	cin >> number;
	bool primeNumber = true;
	if (number >= 4)
	{
		cout << "Prime numbers: 2, 3";
		for (int numbersLessNumber = 5; numbersLessNumber <= number; numbersLessNumber++)
		{
			int i = 2;
			primeNumber = true;
			while (i <= floor(sqrt(numbersLessNumber)) && primeNumber)
			{
				if (numbersLessNumber % i == 0)
					primeNumber = false;
				i++;
			}
			if (primeNumber)
				cout << ", " << numbersLessNumber;
		}
	}
	if ((number > 1) && (number < 4))
	{
		cout << "Prime numbers: ";
		for (int i = 2; i <= number; i++)
			cout << i << " ";
	}
	if (number <= 1)
		cout << "No prime numbers";
	return 0;
}