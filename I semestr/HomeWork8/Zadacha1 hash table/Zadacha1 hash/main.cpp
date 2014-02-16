/*Tests:
1)
Words:
is
Number of repetition = 1

happened?
Number of repetition = 1

what
Number of repetition = 1

Для продолжения нажмите любую клавишу . . .

2)
Words:
and
Number of repetition = 2

are
Number of repetition = 2

Names
Number of repetition = 2

Petr!
Number of repetition = 1

child
Number of repetition = 3

Svetlana!
Number of repetition = 1

Petr
Number of repetition = 1

Name
Number of repetition = 3

Andrey!
Number of repetition = 2

Kseniya
Number of repetition = 1

Elena!
Number of repetition = 1

childs
Number of repetition = 2

is
Number of repetition = 3

of
Number of repetition = 5

Для продолжения нажмите любую клавишу . . .

3)
Words:
Svetlana
Number of repetition = 1

Elena
Number of repetition = 1

and
Number of repetition = 2

are
Number of repetition = 2

Names
Number of repetition = 2

child
Number of repetition = 3

Petr
Number of repetition = 2

Name
Number of repetition = 3

Andrey
Number of repetition = 2

Kseniya
Number of repetition = 1

childs
Number of repetition = 2

!
Number of repetition = 5

is
Number of repetition = 3

of
Number of repetition = 5

Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>
#include "hash.h"

using namespace std;
using namespace hash;

int main()
{
	HashTable *hashTable = createHashTable();
	ifstream input("text.txt");
	while (!input.eof())
	{
		char *word = new char[1000];
		input >> word;
		insertToHashTable(hashTable, word);
	}
	cout << "Words:\n";
	printHashTable(hashTable);
	deleteHashTable(hashTable);
	input.close();
	return 0;
}