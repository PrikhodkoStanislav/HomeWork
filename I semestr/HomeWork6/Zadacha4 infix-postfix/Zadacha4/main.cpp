/*Tests:
1)
Input an expression in infix form:
(1+1)*2
The expression in postfix form:
11+2*
Для продолжения нажмите любую клавишу . . .

2)
Input an expression in infix form:
7+5*5+5-1
The expression in postfix form:
755*+5+1-
Для продолжения нажмите любую клавишу . . .

3)
Input an expression in infix form:
7+8/5*4/4
The expression in postfix form:
785/4*4/+
Для продолжения нажмите любую клавишу . . .

4)
Input an expression in infix form:
7+8*5-4
The expression in postfix form:
785*+4-
Для продолжения нажмите любую клавишу . . .

5)
Input an expression in infix form:
7*5*8+7-4/5
The expression in postfix form:
75*8*7+45/-
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "stack.h"

using namespace std;

// Is the symbol operation?
bool isOperation(char element)
{
	return ((element == '+') | (element == '-') | (element == '*') | (element == '/'));
}

// Has the element first priority?
bool firstPriority(char element)
{
	return (element == '*' || element == '/');
}

// Is the element2 of less priority than the element1?
bool isPriority(char element1, char element2)
{
	return ((firstPriority(element1) && !firstPriority(element2)) || (firstPriority(element1) == firstPriority(element2)));
}

int main()
{
	Stack *stack = createStack();
	cout << "Input an expression in infix form:\n";
	char buffer[1000];
	cin >> buffer;
	char string[1000];
	int lengthOfString = 0;
	for (int i = 0; i < strlen(buffer); i++)
	{
		if ((static_cast<int>(buffer[i]) >= static_cast<int>('0')) && (static_cast<int>(buffer[i]) - static_cast<int>('0') <= 9))
		{
			string[lengthOfString] = buffer[i];
			lengthOfString++;
		}
		//if (isOperation(buffer[i]) | (buffer[i] == '('))
		if (isOperation(buffer[i]))
		{
			while (!emptyStack(stack) && isOperation(returnElement(stack)) && isPriority(returnElement(stack), buffer[i]))
			{
				string[lengthOfString] = returnElement(stack);
				lengthOfString++;
				deleteElement(stack);
			}
			addElement(stack, buffer[i]);
		}
		if (buffer[i] == '(')
			addElement(stack, buffer[i]);
		if (buffer[i] == ')')
		{
			while (returnElement(stack) != '(')
			{
				string[lengthOfString] = returnElement(stack);
				lengthOfString++;
				deleteElement(stack);
			}
			deleteElement(stack);
			if (!emptyStack(stack) && isOperation(returnElement(stack)))
			{
				string[lengthOfString] = returnElement(stack);
				lengthOfString++;
				deleteElement(stack);
			}
		}
	}
	while (!emptyStack(stack))
	{
		string[lengthOfString] = returnElement(stack);
		lengthOfString++;
		deleteElement(stack);
	}
	cout << "The expression in postfix form:\n";
	for (int i = 0; i < lengthOfString; i++)
		cout << string[i];
	cout << "\n";
	deleteStack(stack);
	return 0;
}