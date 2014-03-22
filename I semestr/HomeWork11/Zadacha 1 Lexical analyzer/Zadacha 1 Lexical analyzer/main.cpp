/*Tests:
1)
Input sequence of symbols:
0.5E18
This is real number!
Для продолжения нажмите любую клавишу . . .

2)
Input sequence of symbols:
1.E
This is NOT real number!
Для продолжения нажмите любую клавишу . . .

3)
Input sequence of symbols:
18.486546E-484
This is real number!
Для продолжения нажмите любую клавишу . . .

4)
Input sequence of symbols:
1815E+48
This is real number!
Для продолжения нажмите любую клавишу . . .

5)
Input sequence of symbols:
0.185441
This is real number!
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;
// Is symbol digit?
bool isDigit(char symbol)
{
	return (static_cast<int>(symbol) >= static_cast<int>('0') && static_cast<int>(symbol) <= static_cast<int>('9'));
}
// Is sequence of symbols real number?
bool isRealNumber(char *buffer)
{
	int state = -1;
	int position = 0;
	bool next = true;
	bool end = false;
	while (next && (position < strlen(buffer)))
	{
		switch (state)
		{
		// start
		case -1:
			if (isDigit(buffer[position]))
			{
				state = 0;
				end = true;
			}
			else
				next = false;
			break;
		// digit
		case 0:
			if (isDigit(buffer[position]))
			{
				state = 0;
			}
			else
			{
				if (buffer[position] == '.')
				{
					state = 1;
					end = false;
				}
				else
				{
					if (buffer[position] == 'E')
					{
						state = 3;
						end = false;
					}
					else
						next = false;
				}
			}
			break;
		// dot
		case 1:
			if (isDigit(buffer[position]))
			{
				state = 2;
				end = true;
			}
			else
				next = false;
			break;
		// digit after dot
		case 2:
			end = true;
			if (isDigit(buffer[position]))
			{
				state = 2;
			}
			else
			{
				if (buffer[position] == 'E')
				{
					state = 3;
					end = false;
				}
				else
					next = false;
			}
			break;
		// E
		case 3:
			if (isDigit(buffer[position]))
			{
				state = 5;
				end = true;
			}
			else
			{
				if (buffer[position] == '+' || buffer[position] == '-')
				{
					state = 4;
				}
				else
					next = false;
			}
			break;
		// +/-
		case 4:
			if (isDigit(buffer[position]))
			{
				state = 5;
				end = true;
			}
			else
				next = false;
			break;
		// digit after E and +/-
		case 5:
			if (isDigit(buffer[position]))
			{
				state = 5;
			}
			else
				next = false;
			break;
		}
		position++;
	}
	// if the exit by the reason of difference schemes
	if (!next)
		end = false;
	return end;
}

int main()
{
	cout << "Input sequence of symbols:\n";
	char *buffer = new char[1000];
	cin >> buffer;
	if (isRealNumber(buffer))
		cout << "This is real number!\n";
	else
		cout << "This is NOT real number!\n";
	delete []buffer;
	return 0;
}