#include <iostream>

using namespace std;

int fibonacci(int number)
{
	if (number <= 1)
		return 1;
	else
		return fibonacci(number - 1) + fibonacci(number - 2);
}

int main()
{
	cout << "Input number \n";
	int number = 0;
	cin >> number;
	cout << "Number of Fibonacci = " << fibonacci(number);
	return 0;
}