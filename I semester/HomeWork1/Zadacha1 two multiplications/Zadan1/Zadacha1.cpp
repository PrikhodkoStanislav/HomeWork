#include <iostream>

using namespace std;

int main()
{
	cout << "Vvedite x \n" ;
	int x = 0;
	cin >> x;
	int x2 = x * x;
	cout << "x^4+x^3+x^2+x = " << (x2 + x) * (x2 + 1) << endl;
	return 0;
}