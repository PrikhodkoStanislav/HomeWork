#include <iostream>
#include <fstream>
#include <string.h>

#include "spisok.h"

using namespace std;

const int lengthOfNumbersInList = 100;

struct List
{
	PhoneType phoneNumbers[lengthOfNumbersInList];
	NameType names[lengthOfNumbersInList];
	Position last;
};

List *create()
{
	List *result = new List;
	result->last = 0;
	return result;
}

void deleteList(List *list)
{
	delete list;
}

PhoneType returnPhoneNumber(List *list, int number)
{
	return list->phoneNumbers[number];
}

NameType returnName(List *list, int number)
{
	return list->names[number];
}

Position returnLast(List *list)
{
	return list->last;
}

void insert(List *list, PhoneType number, NameType name)
{
	list->last++;
	list->phoneNumbers[returnLast(list) - 1] = number;
	list->names[returnLast(list) - 1] = new char[1000];
	strcpy(list->names[returnLast(list) - 1], name);
}

void print(List *list, char *name)
{
	ofstream file(name);
	file << returnLast(list) << "\n";
	for (int i = 0; i < returnLast(list); i++)
	{
		file << returnPhoneNumber(list, i) << endl;
		file << list->names[i];
		file << "\n";
	}
	file.close();
}

void printLast(List *list, Position last)
{
	list->last = last;
}

void printPhone(List *list, PhoneType phone, int i)
{
	list->phoneNumbers[i] = phone;
}

void printName(List *list, NameType name, int i)
{
	list->names[i] = new char[1000];
	strcpy(list->names[i], name);
}