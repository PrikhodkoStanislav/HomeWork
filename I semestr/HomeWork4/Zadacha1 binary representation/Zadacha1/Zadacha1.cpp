/*Tests:

Введите два числа:
15 5
Числа в двоичном представлении:
00000000000000000000000000001111
00000000000000000000000000000101
Сумма в двоичном представлении:
00000000000000000000000000010100
Сумма в десятичной системе счисления:
20Для продолжения нажмите любую клавишу . . .

Введите два числа:
155 -5
Числа в двоичном представлении:
00000000000000000000000010011011
11111111111111111111111111111011
Сумма в двоичном представлении:
00000000000000000000000010010110
Сумма в десятичной системе счисления:
150Для продолжения нажмите любую клавишу . . .

Введите два числа:
-180 170
Числа в двоичном представлении:
11111111111111111111111101001100
00000000000000000000000010101010
Сумма в двоичном представлении:
11111111111111111111111111110110
Сумма в десятичной системе счисления:
-10Для продолжения нажмите любую клавишу . . .

Введите два числа:
-700 -180
Числа в двоичном представлении:
11111111111111111111110101000100
11111111111111111111111101001100
Сумма в двоичном представлении:
11111111111111111111110010010000
Сумма в десятичной системе счисления:
-880Для продолжения нажмите любую клавишу . . .

Введите два числа:
78150255
78152175
Числа в двоичном представлении:
00000100101010000111101001101111
00000100101010001000000111101111
Сумма в двоичном представлении:
00001001010100001111110001011110
Сумма в десятичной системе счисления:
156302430Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>

using namespace std;

void transferNumberInTheBinaryNumberSystem(int number, bool result[sizeof(int) * 8])
{
	int mask = 1; // use mask for numbers
	for (int i = 0; i < sizeof(int) * 8; ++i)
	{
		result[i] = (number & mask) != 0;
		mask = mask << 1;
	}
}

void displayingNumbersInBinaryNotation(bool result[sizeof(int) * 8]) // number in base-two system
{
	for (int i = sizeof(int) * 8 - 1; i >= 0; --i)
	{
		cout << result[i];
	}
}
void additionInTheBinarySystem(bool result1[sizeof(int) * 8], bool result2[sizeof(int) * 8], bool sum[sizeof(int) * 8])
{
	for (int i = sizeof(int) * 8 - 1; i >= 0; --i) // zeroing sum
	{
		sum[i] = 0;
	}
	bool transfer = false; // transfer overflow discharge
	for (int i = 0; i < sizeof(int) * 8; ++i)
	{
		if (result1[i] && result2[i]) // 1 1 x
		{
			sum[i] = transfer;
			transfer = true;
		}
		else
		{
			if (result1[i] + result2[i] && transfer) // (0 1 1) | (1 0 1)
			{
				sum[i] = false;
				transfer = true;
			}
			else // other cases
			{
				sum[i] = result1[i] + result2[i] + transfer;
				transfer = false;
			}
		}
	}
}
int theSumIn10ScaleOfNotation(bool sum[sizeof(int) * 8], int i, int ithPowerOfTwo)
{
	if (i < sizeof(int) * 8)
		return (sum[i] * ithPowerOfTwo) + theSumIn10ScaleOfNotation(sum, i + 1, ithPowerOfTwo * 2);
	else
		return 0;
}

int main()
{
	setlocale(LC_ALL, "rus"); // Kirilliza
	cout << "Введите два числа:\n";
	int number1 = 0;
	int number2 = 0;
	cin >> number1 >> number2;
	bool result1[sizeof(int) * 8];
	bool result2[sizeof(int) * 8];
	transferNumberInTheBinaryNumberSystem(number1, result1);
	transferNumberInTheBinaryNumberSystem(number2, result2);
	cout << "Числа в двоичном представлении:\n";
	displayingNumbersInBinaryNotation(result1);
	cout << "\n";
	displayingNumbersInBinaryNotation(result2);
	bool sum[sizeof(int) * 8]; // sum of number1 and number2
	additionInTheBinarySystem(result1, result2, sum);
	cout << "\nСумма в двоичном представлении:\n";
	for (int i = sizeof(int) * 8 - 1; i >= 0; --i) // sum in base-two system
	{
		cout << sum[i];
	}
	cout << "\nСумма в десятичной системе счисления:\n";
	cout << theSumIn10ScaleOfNotation(sum, 0, 1);
	return 0;
}