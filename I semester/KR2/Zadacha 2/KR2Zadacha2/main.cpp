#include <iostream>
#include <fstream>
#include "list.h"

using namespace std;

int main()
{
	ifstream input("input.txt");
	int element = 0;
	List *list = create();
	while (!input.eof())
	{
		input >> element;
		insert(list, element);
	}
	cout << "Is list symmetric?" << endl;
	if (symmetricalList(list))
		cout << "YES!" << endl;
	else
		cout << "NO!" << endl;
	deleteList(list);
	input.close();
	return 0;
}