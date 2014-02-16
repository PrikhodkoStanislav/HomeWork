/*Tests:
Input number of warriors and number of died warrior
2 1
Number of alive warrior = 2Для продолжения нажмите любую клавишу . . .

Input number of warriors and number of died warrior
4 3
Number of alive warrior = 1Для продолжения нажмите любую клавишу . . .

Input number of warriors and number of died warrior
41 3
Number of alive warrior = 31Для продолжения нажмите любую клавишу . . .

Input number of warriors and number of died warrior
10 5
Number of alive warrior = 3Для продолжения нажмите любую клавишу . . .

Input number of warriors and number of died warrior
25 14
Number of alive warrior = 12Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include "spisok.h"

using namespace std;

int main()
{
	cout << "Input number of warriors and number of died warrior\n";
	int numberOfWarriors = 0;
	int numberOfDiedWarrior = 0;
	cin >> numberOfWarriors >> numberOfDiedWarrior;
	List *list = create();
	makeCircularList(list, numberOfWarriors);
	Position positionOfDiedWarriors = first(list);
	while (numberOfWarriors > 1)
	{
		for (int i = 1; i < numberOfDiedWarrior; i++)
		{
			positionOfDiedWarriors = next(list, positionOfDiedWarriors);
		}
		Position positionAfterDiedWarrior = next(list, positionOfDiedWarriors);
		deleteElement(list, positionOfDiedWarriors);
		positionOfDiedWarriors = positionAfterDiedWarrior;
		numberOfWarriors--;
	}
	ElementType numberOfAliveWarrior = valueOfAlive(list, positionOfDiedWarriors);
	cout << "Number of alive warrior = ";
	cout << numberOfAliveWarrior << endl;
	deleteElement(list, positionOfDiedWarriors);
	delete list;
	return 0;
}