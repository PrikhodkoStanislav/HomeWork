/*Tests:
1)
0 - exit
1 - insert element of the list (name and telephone number)(length of name = 5)
2 - find telephone number by name(length of name = 5)
3 - find name by telephone number
4 - save list in file
Input number of operation:
1
Input phone number
547
Input name
danil

Input number of operation:
1
Input phone number
588
Input name
favin

Input number of operation:
2
Input name:
danil

Number of telephone = 547

Input number of operation:
3
Input telephone:
588

Name: favin

Input number of operation:
3
Input telephone:
544

No this phone in list!

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

2)
0 - exit
1 - insert element of the list (name and telephone number)(length of name = 5)
2 - find telephone number by name(length of name = 5)
3 - find name by telephone number
4 - save list in file
Input number of operation:
1
Input phone number
547
Input name
danil

Input number of operation:
1
Input phone number
152
Input name
rondo

Input number of operation:
2
Input name:
danil

Number of telephone = 547

Input number of operation:
3
Input telephone:
152

Name: rondo

Input number of operation:
3
Input telephone:
118

No this phone in list!

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

3)
0 - exit
1 - insert element of the list (name and telephone number)(length of name = 5)
2 - find telephone number by name(length of name = 5)
3 - find name by telephone number
4 - save list in file
Input number of operation:
2
Input name:
raddd

No this name in list!

Input number of operation:
1
Input phone number
578
Input name
drill

Input number of operation:
3
Input telephone:
578

Name: drill

Input number of operation:
3
Input telephone:
152

Name: rondo

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

4)
0 - exit
1 - insert element of the list (name and telephone number)(length of name = 5)
2 - find telephone number by name(length of name = 5)
3 - find name by telephone number
4 - save list in file
Input number of operation:
1
Input phone number
555
Input name
richi

Input number of operation:
3
Input telephone:
588

Name: favin

Input number of operation:
2
Input name:
richi

Number of telephone = 555

Input number of operation:
3
Input telephone:
555

Name: richi

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

4)
0 - exit
1 - insert element of the list (name and telephone number)
2 - find telephone number by name
3 - find name by telephone number
4 - save list in file
Input number of operation:
1
Input phone number
54
Input name
res

Input number of operation:
2
Input name:
res

Number of telephone = 54

Input number of operation:
3
Input telephone:
54

Name: res

Input number of operation:
1
Input phone number
887
Input name
gerardin

Input number of operation:
3
Input telephone:
887

Name: gerardin

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

5)
0 - exit
1 - insert element of the list (name and telephone number)
2 - find telephone number by name
3 - find name by telephone number
4 - save list in file
Input number of operation:
2
Input name:
gerardin

Number of telephone = 54

Input number of operation:
3
Input telephone:
155

This phone is not in the list!

Input number of operation:
3
Input telephone:
154

This phone is not in the list!

Input number of operation:
3
Input telephone:
555

Name: richi

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .

0 - exit
1 - insert element of the list (name and telephone number)
2 - find telephone number by name
3 - find name by telephone number
4 - save list in file
Input number of operation:
2
Input name:
rondo

Number of telephone = 152

Input number of operation:
1
Input phone number
548
Input name
daf

Input number of operation:
2
Input name:
daf

Number of telephone = 548

Input number of operation:
3
Input telephone:
548

Name: daf

Input number of operation:
4

Input number of operation:
0
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>
#include <string.h>

#include "spisok.h"

using namespace std;

int main()
{
	cout << "0 - exit\n1 - insert element of the list (name and telephone number)\n";
	cout << "2 - find telephone number by name\n3 - find name by telephone number\n";
	cout << "4 - save list in file\n";
	cout << "Input number of operation:\n";
	int variable = 0;
	cin >> variable;
	if (variable != 0)
	{
		List *list = create();
		ifstream infile("telephone.in");
		if (infile.is_open())
		{
			int lengthOfSourceList = 0;
			infile >> lengthOfSourceList;
			printLast(list, lengthOfSourceList);
			int tempPhone = 0;
			char buffer[1000][1000];
			for (int i = 0; i < lengthOfSourceList; i++)
			{
				infile >> tempPhone;
				printPhone(list, tempPhone, i);
				infile >> buffer[i];
				printName(list, buffer[i], i);
			} 
			infile.close();
		}

		while (variable != 0)
		{
			if (variable == 1)
			{
				cout << "Input phone number\n";
				PhoneType number = 0;
				cin >> number;
				cout << "Input name\n";
				char buffer[1000];
				cin >> buffer;
				insert(list, number, buffer);
			}
			if (variable == 2)
			{
				cout << "Input name:\n";
				char buffer[1000];
				cin >> buffer;
				char *buffer1 = buffer;
				bool thisName = false;
				if (returnLast(list) == 0)
				{
					cout << "List is clear!\n";
				}
				for (int i = 0; i < returnLast(list); i++)
				{
					if (strcmp(returnName(list, i), buffer1) == 0)
					{
						cout << "\nNumber of telephone = " << returnPhoneNumber(list, i) << endl;
						thisName = true;
						break;
					}
				}
				if (!thisName)
				{
					cout <<"\nThis name is not in the list!\n";
				}
			}
			if (variable == 3)
			{
				cout << "Input telephone:\n";
				PhoneType phone;
				cin >> phone;
				bool thisPhone = true;
				if (returnLast(list) == 0)
				{
					cout << "List is clear!\n";
				}
				for (int i = 0; i < returnLast(list); i++)
				{
					if (returnPhoneNumber(list, i) == phone)
					{
						thisPhone = true;
						cout << "\nName: ";
						cout << returnName(list, i);
						cout << "\n";
						break;
					}
					else
						thisPhone = false;
				}
				if (!thisPhone)
				{
					cout <<"\nThis phone is not in the list!\n";
				}
			}
			if (variable == 4)
			{
				char *nameOfFile = "telephone.in";
				print(list, nameOfFile);
			}
			cout << "\nInput number of operation:\n";
			cin >> variable;
		}
		deleteList(list);
	}
	return 0;
}