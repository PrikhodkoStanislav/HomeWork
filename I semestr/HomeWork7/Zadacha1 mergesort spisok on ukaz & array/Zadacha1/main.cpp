/*Tests:
Input quantity of numbers:
5
Input numbers:
4 8 2 1 5
List:
1 2 4 5 8
Для продолжения нажмите любую клавишу . . .

Input quantity of numbers:
3
Input numbers:
7 1 84
List:
1 7 84
Для продолжения нажмите любую клавишу . . .

Input quantity of numbers:
5
Input numbers:
1 2 5 5 5
List:
1 2 5 5 5
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "mergesort.h"

using namespace std;

int main()
{
	List *list = create();
	cout << "Input quantity of numbers:\n";
	int quantity = 0;
	cin >> quantity;
	if (quantity > 0)
	{
		cout << "Input numbers:\n";
	}
	int buffer[1000];
	for (int i = 0; i < quantity; i++)
		cin >> buffer[i];
	for (int i = 0; i < quantity; i++)
	{
		insertToHead(list, buffer[i]);
	}
	list = sortList(list, 0, quantity);
	print(list);
	deleteList(list);
	return 0;
}