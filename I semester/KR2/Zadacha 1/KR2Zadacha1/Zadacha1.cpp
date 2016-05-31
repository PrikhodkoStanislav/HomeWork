/*Tests:
Input numbers a and b:
2 5
Для продолжения нажмите любую клавишу . . .
Elements of output file:
1 1 4 5 2 8 10 71 54 11

Input numbers a and b:
1 7
Для продолжения нажмите любую клавишу . . .
Elements of output file:
1 4 5 1 2 8 10 71 54 11

Input numbers a and b:
5 18
Для продолжения нажмите любую клавишу . . .
Elements of output file:
1 4 1 2 8 10 5 11 71 54
*/
#include <iostream>
#include <fstream>

#include "list.h"

; using namespace std;

int main()
{
	ifstream input("input.txt");
    ofstream output("output.txt");
    cout << "Input numbers a and b:\n";
	int a = 0;
	int b = 0;
    cin >> a;
    cin >> b;
	int element = 0;
	List *list1 = create();
	List *list2 = create();
	while (!input.eof())
	{
		input >> element;
		if (element < a)
		{
			output << element << " ";
		}
		else
		{
			if (element >= a && element <=  b)
			{
				insert(list1, element);
			}
			else
			{
				insert(list2, element);
			}
		}
	}
	input.close();
	Position position = first(list1);
	while (position != end(list1))
	{
		output << valueOnPosition(list1, position) << " ";
		position = next(list1, position);
	}
	position = first(list2);
	while (position != end(list2))
	{
		output << valueOnPosition(list2, position) << " ";
		position = next(list2, position);
	}
	output.close();
	deleteList(list1);
	deleteList(list2);
	return 0;
}