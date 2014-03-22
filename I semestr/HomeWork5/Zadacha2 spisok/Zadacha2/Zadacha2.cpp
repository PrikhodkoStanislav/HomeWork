/*Tests:
1)
0 - exit
1 - insert element in the sorted list
2 - delete element from the list
3 - print list

Input number of operation
1
Input value:
2

Input number of operation:
1
Input value:
7

Input number of operation:
1
Input value:
1

Input number of operation:
1
Input value:
8

Input number of operation:
1
Input value:
7

Input number of operation:
3
List:
1 2 7 7 8

Input number of operation:
2
Input position:
1

Input number of operation:
3
List:
1 7 7 8

Input number of operation:
2
Input position:
0

Input number of operation:
3
List:
7 7 8

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

2)
0 - exit
1 - insert element in the sorted list
2 - delete element from the list
3 - print list

Input number of operation
3
List is clear!

Input number of operation:
1
Input value:
1

Input number of operation:
3
List:
1

Input number of operation:
2
Input position:
0

Input number of operation:
3
List is clear!

Input number of operation:
1
Input value:
7

Input number of operation:
1
Input value:
7

Input number of operation:
1
Input value:
7

Input number of operation:
3
List:
7 7 7

Input number of operation:
2
Input position:
2

Input number of operation:
3
List:
7 7

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

3)
0 - exit
1 - insert element in the sorted list
2 - delete element from the list
3 - print list

Input number of operation
2
Input position:
2
WRONG! This element is not in this list!!!!!

Input number of operation:
2
Input position:
0
WRONG! This element is not in this list!!!!!

Input number of operation:
3
List is clear!

Input number of operation:
1
Input value:
7

Input number of operation:
1
Input value:
7

Input number of operation:
3
List:
7 7

Input number of operation:
2
Input position:
2
WRONG! This element is not in this list!!!!!

Input number of operation:
2
Input position:
1

Input number of operation:
3
List:
7

Input number of operation:
1
Input value:
44

Input number of operation:
1
Input value:
55

Input number of operation:
1
Input value:
120

Input number of operation:
3
List:
7 44 55 120

Input number of operation:
2
Input position:
0

Input number of operation:
3
List:
44 55 120

Input number of operation:
2
Input position:
4
WRONG! This element is not in this list!!!!!

Input number of operation:
2
Input position:
2

Input number of operation:
3
List:
44 55

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "spisok.h"

using namespace std;

int main()
{
	cout << "0 - exit\n1 - insert element in the sorted list\n";
	cout <<	"2 - delete element from the list\n3 - print list\n\n";
	cout << "Input number of operation\n";
	int number = 0;
	cin >> number;
	//if (number != 0)
	List *list = create();
	while (number != 0)
	{
		if (number == 1)
		{
			cout << "Input value:\n";
			ElementType value;
			cin >> value;
			Position position = first(list);
			if (position != NULL)
			{
				while (position != NULL && returnValue(list, position) < value)
				{
					position = next(list, position);
				}
				if (position == first(list))
					insertToHead(list, value);
				else
					insert(list, value, position);
			}
			else
				insertToHead(list, value);
		}
		if (number == 2)
		{
			cout << "Input position:\n";
			int pos = 0;
			cin >> pos;
			Position position = first(list);
			if (pos != 0 && position != NULL)
			{
				for (int i = 0; i < pos && position != NULL; i++)
				{
					position = next(list, position);
				}
			}
			if (position != NULL)
				deleteElement(list, position);
			else
				cout << "WRONG! This element is not in this list!!!!!\n";
		}
		if (number == 3)
		{
			print (list);
		}
		cout << "\nInput number of operation:\n";
		cin >> number;
	}
	deleteList(list);
	return 0;
}