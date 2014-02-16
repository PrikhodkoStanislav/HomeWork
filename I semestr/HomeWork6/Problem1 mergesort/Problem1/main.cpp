/*Tests:
1)
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
1
Yana
4511
Andrey
4575
Alexey
4621
Svetlana
7124
Viktoriya
8421
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
2
Alexey
4621
Andrey
4575
Svetlana
7124
Viktoriya
8421
Yana
4511
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
1
Yana
4511
Andrey
4575
Alexey
4621
Svetlana
7124
Viktoriya
8421
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

2)
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
1
Svetlana
7124
Viktoriya
8421
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
2
Svetlana
7124
Viktoriya
8421
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

3)
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
1
Evgeniy
78
Angelina
5712
Svetlana
7124
Viktoriya
8421
Dmitriy
48111
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
2
Angelina
5712
Dmitriy
48111
Evgeniy
78
Svetlana
7124
Viktoriya
8421
1 - sort by phone
2 - sort by name
0 - exit
Input number of operation:
0
Для продолжения нажмите любую клавишу . . .
*/
#include "mergesort.h"
#include <iostream>
#include <fstream>
#include <string.h>

using namespace std;

int main()
{
	List *list = create();
	ifstream infile("book.in");
	int lengthOfSourceList = 0;
	if (infile.is_open())
	{
		infile >> lengthOfSourceList;
		int tempPhone = 0;
		char buffer[1000];
		for (int i = 0; i < lengthOfSourceList; i++)
		{
			infile >> buffer;
			infile >> tempPhone;
			add(list, tempPhone, buffer);
		} 
		infile.close();
	}
	cout << "1 - sort by phone\n2 - sort by name\n0 - exit\n";
	cout << "Input number of operation:\n";
	int temp = 0;
	cin >> temp;
	while (temp != 0)
	{
		if (temp == 1)
		{
			list = sortList(list, 0, lengthOfSourceList,  false);
			printList(list);
		}
		if (temp == 2)
		{
			list = sortList(list, 0, lengthOfSourceList, true);
			printList(list);
		}
		cout << "1 - sort by phone\n2 - sort by name\n0 - exit\n";
		cout << "Input number of operation:\n";
		cin >> temp;
	}
	deleteList(list);
	cout << "Counter: ";
	printStatistic();
	return 0;
}