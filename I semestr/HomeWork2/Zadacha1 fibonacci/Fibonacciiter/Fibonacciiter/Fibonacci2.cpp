#include <iostream>

using namespace std;

int main()
{
	cout << "Input number\n";
	int number1 = 0;
	cin >> number1;
	int previous = 1;
	int now = 1;
	int variable = 1;
	for (int i = 1; i < number1; i++)
	{
		variable = now;
		now = now + previous;
		variable = previous ^ variable;
		previous = previous ^ variable;
		variable = previous ^ variable;
	}
	cout << "Fibonacci number = " << now;
	return 0;
}