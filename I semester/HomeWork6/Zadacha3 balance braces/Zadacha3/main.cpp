/*Tests:
Input string:
()
Balance:
Yes!
Для продолжения нажмите любую клавишу . . .

Input string:
hjdshfjksdhfkj{sjdfhkjsdh[sdfdsf(sfdsfsd)]asdasd}ds
Balance:
Yes!
Для продолжения нажмите любую клавишу . . .

Input string:
jsdkfjskdlfjl{ssdfsdfsdfsd}9sdfsdfds({sfdsfsd)adsadad}
Balance:
No!
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "stack.h"

using namespace std;

char opposite(char element)
{
	if (element == ')')
		return '(';
	if (element == ']')
		return '[';
	if (element == '}')
		return '{';
}

int main()
{
	Stack *stack = createStack();
	cout << "Input string:\n";
	char buffer[1000];
	cin >> buffer;
	bool balance = true;
	for (int i = 0; i < strlen(buffer); i++)
	{
		if ((buffer[i] == '(') | (buffer[i] == '[') | (buffer[i] == '{'))
			addElement(stack, buffer[i]);
		if ((buffer[i] == ')') | (buffer[i] == ']') | (buffer[i] == '}'))
		{
			if (!emptyStack(stack) && (returnElement(stack) == opposite(buffer[i])))
				deleteElement(stack);
			else
			{
				balance = false;
				break;
			}
		}
	}
	cout << "Balance:\n";
	if (emptyStack(stack) && balance)
		cout << "Yes!\n";
	else
		cout << "No!\n";
	deleteStack(stack);
	return 0;
}