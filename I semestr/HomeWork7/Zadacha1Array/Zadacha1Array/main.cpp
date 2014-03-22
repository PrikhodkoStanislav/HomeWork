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
#include "list.h"

using namespace std;

List *makeSort(List *list1, List *list2, int length1, int length2)
{
	List *elementList = create();
	Position position1 = first(list1);
	Position position2 = first(list2);
	Position position = first(elementList);
	while (!noolPosition(list1, position1) || !noolPosition(list2, position2))
	{
		if (noolPosition(list1, position1))
		{
			while (!noolPosition(list2, position2))
			{
				if (noolPosition(elementList, position))
				{
					insertToHead(elementList, returnValue(list2, position2));
					position = first(list2);
				}
				else
				{
					insert(elementList, returnValue(list2, position2), next(elementList, position));
					position = next(elementList, position);
				}
				position2 = next(list2, position2);
			}
		}
		else
		{
			if (noolPosition(list2, position2))
			{
				while (!noolPosition(list1, position1))
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list1, position1));
						position = first(list1);
					}
					else
					{
						insert(elementList, returnValue(list1, position1), next(elementList, position));
						position = next(elementList, position);
					}
					position1 = next(list1, position1);
				}
			}
			else
			{
				if (returnValue(list1, position1) <= returnValue(list2, position2))
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list1, position1));
						position = first(elementList);
					}
					else
					{
						insert(elementList, returnValue(list1, position1), next(elementList, position));
						position = next(elementList, position);
					}
					position1 = next(list1, position1);
				}
				else
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list2, position2));
						position = first(elementList);
					}
					else
					{
						insert(elementList, returnValue(list2, position2), next(elementList, position));
						position = next(elementList, position);
					}
					position2 = next(list2, position2);
				}
			}
		}
	}
	deleteList(list1);
	deleteList(list2);
	return elementList;
}

List *sortList(List *list, int left, int right)
{
	Position position = first(list);
	if (noolPosition(list, position))
	{
		cout << "List is clear!\n";
		return nullptr;
	}
	List *newList = create();
	insertToHead(newList, returnValue(list, position));
	position = next(list, position);
	for (int i = 1; i < (right - left); i++)
	{
		List *list2 = create();
		insertToHead(list2, returnValue(list, position));
		newList = makeSort(newList, list2, i, 1);
		position = next(list, position);
	}
	return newList;
}

int main()
{
	List *list = create();
	cout << "Input quantity of numbers:\n";
	int quantity = 0;
	cin >> quantity;
	cout << "Input numbers:\n";
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