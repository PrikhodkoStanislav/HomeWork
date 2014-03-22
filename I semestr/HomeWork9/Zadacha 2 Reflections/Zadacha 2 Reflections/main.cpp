/*Tests:
1)
Input cardinalities m and n:
5 8
Number of injections = 6720
Number of surjections = 0
Number of reflections = 32768
Number of biections = 0
Для продолжения нажмите любую клавишу . . .

2)
Input cardinalities m and n:
8 2
Number of injections = 0
Number of surjections = 254
Number of reflections = 256
Number of biections = 0
Для продолжения нажмите любую клавишу . . .

3)
Input cardinalities m and n:
5 5
Number of injections = 120
Number of surjections = 120
Number of reflections = 3125
Number of biections = 120
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;

int factorial(int number)
{
	if (number == 0)
		return 1;
	return (number * factorial(number - 1));
}

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

int numberOfPermutation(int n, int k)
{
	return (factorial(n) / (factorial(k) * factorial(n - k)));
}

int numberOfSurjections(int m, int n)
{
	int sum = 0;
	for (int i = 0; i < n; i++)
	{
		sum += inPower(-1, i) * numberOfPermutation(n, i) * inPower(n - i, m);
	}
	return sum;
}

int main()
{
	cout << "Input cardinalities m and n:\n";
	int m = 0;
	int n = 0;
	cin >> m;
	cin >> n;
	cout << "Number of injections = ";
	if (n < m)
		cout << 0 << endl;
	else
		cout << factorial(n) / factorial(n - m) << endl;

	cout << "Number of surjections = ";
	cout << numberOfSurjections(m, n) << endl;

	cout << "Number of reflections = ";
	cout << inPower(n, m) << endl;

	cout << "Number of biections = ";
	if (n == m)
		cout << factorial(n) << endl;
	else
		cout << 0 << endl;
	return 0;
}