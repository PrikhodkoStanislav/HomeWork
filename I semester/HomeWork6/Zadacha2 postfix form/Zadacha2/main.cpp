/*Tests:
Input an arithmetic expression in Postfix form:
96-12+*
Result:
9
Для продолжения нажмите любую клавишу . . .

Input an arithmetic expression in Postfix form:
15+78-*84/84+*+
Result:
18
Для продолжения нажмите любую клавишу . . .

Input an arithmetic expression in Postfix form:
17+18*-24**32+41-*
Result:
15
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "stack.h"

using namespace std;

int result(char operation, int number1, int number2)
{
	if (operation == '*')
		return (number1 * number2);
	if (operation == '+')
		return (number1 + number2);
	if (operation == '-')
		return (number1 - number2);
	if (operation == '/')
		if (number2 != 0)
			return (number1 / number2);
		else
			return 0;
}

int main()
{
	Stack *stack = createStack();
	cout << "Input an arithmetic expression in Postfix form:\n";
	char buffer[1000];
	cin >> buffer;
	for (int i = 0; i < strlen(buffer); i++)
	{
		char temp = buffer[i];
		if ((static_cast<int>(temp) - static_cast<int>('0')) >= 0 && (static_cast<int>(temp) - static_cast<int>('0')) <= 9)
			addElement(stack, static_cast<int>(temp) - static_cast<int>('0'));
		else
		{
			int number2 = returnElement(stack);
			deleteElement(stack);
			int number1 = returnElement(stack);
			deleteElement(stack);
			addElement(stack, result(temp, number1, number2));
		}
	}
	cout << "Result:\n";
	cout << returnElement(stack) << endl;
	deleteStack(stack);
	return 0;
}