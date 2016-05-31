#include <iostream>

using namespace std;

int main()
{
	cout << "Vvedite stroku \n";
	char s[] = "";
	cin >> s;
	int k = 0;
	int i = 0;
	while ((i <= strlen(s)) && (k >= 0))
	{
		if (s[i] == '(')
			k++;
		if (s[i] == ')')
			k--;
		i++;
	}
	if (k < 0)
		cout << "Net vlozheniya skobok \n";
	if (k == 0)
		cout << "Balans skobok vypolnen \n";
	if (k > 0)
		cout << "Ne vypolnen balans skobok \n";
	return 0;
}