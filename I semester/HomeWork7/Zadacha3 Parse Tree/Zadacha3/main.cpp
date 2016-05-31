/*Tests:
1)
( * ( + 1 1 ) 2 )
Value of expression = 4
Для продолжения нажмите любую клавишу . . .

2)
( * ( + 1 7 ) 2 )
Value of expression = 16
Для продолжения нажмите любую клавишу . . .

3)
( + ( + ( / ( - 8 3 ) 5 ) 2 ) 2 )
Value of expression = 5
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>
#include "tree.h"

using namespace std;

int main()
{
	ifstream input("tree.txt");
	char *buffer = new char[1000];
	input >> buffer;
	Tree *tree = create();
	writeInTree(tree, buffer);
	print(tree);
	cout << "\nValue of expression = " << valueOfExpression(tree) << endl;
	delete []buffer;
	deleteTree(tree);
	return 0;
}