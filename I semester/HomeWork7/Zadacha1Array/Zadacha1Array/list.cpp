#include <iostream>
#include "list.h"

using namespace std;

const int length = 100;

struct ListElement
{
	ElementType value[length];
	int number;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *result = new List;
	ListElement *element = new ListElement;
	element->number = 0;
	result->head = element;
	return result;
}

void insertToHead(List *list, ElementType value)
{
	list->head->value[list->head->number] = value;
	list->head->number++;
}

void insert(List *list, ElementType value, Position position)
{
	list->head->value[position] = value;
	list->head->number++;
}

void print(List *list)
{
	if (list->head->number == 0)
	{
		cout << "List is clear!\n";
		return;
	}
	cout << "List:\n";
	for (int i = 0; i < list->head->number; i++)
	{
		cout << list->head->value[i] << " ";
	}
	cout << "\n";
}

Position first(List *list)
{
	return 0;
}

Position next(List *list, Position position)
{
	return (position + 1);
}

ElementType returnValue(List *list, Position position)
{
	return list->head->value[position];
}

void deleteList(List *list)
{
	delete list->head;
	delete list;
}

bool noolPosition(List *list, Position position)
{
	return (position >= list->head->number);
}