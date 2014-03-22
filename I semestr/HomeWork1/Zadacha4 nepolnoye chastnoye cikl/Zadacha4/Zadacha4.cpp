#include <iostream>

using namespace std;

int main()
{
	cout << "Input a and b \n";
	int numerator = 0;
	int denominator = 0;
	int quotient = 0;
	bool quotientPositive = true;
	cin >> numerator;
	cin >> denominator;
	if (numerator * denominator < 0)
		quotientPositive = false;
	numerator = abs(numerator);
	denominator = abs(denominator);
	if (denominator == 0)
		cout << "Not divide by 0 \n";
	if (denominator != 0)
	{
		while (numerator >= denominator)
		{
			quotient++;
			numerator = numerator - denominator;
		}
		if (!quotientPositive)
			quotient = -quotient;
		cout << "Short quotient =  " << quotient << endl;
	}
	return 0;
}