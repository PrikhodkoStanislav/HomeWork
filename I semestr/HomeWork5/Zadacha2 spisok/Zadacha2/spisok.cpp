#include <iostream>
#include "spisok.h"

using namespace std;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct List
{
	ListElement *head;
};

List *create()
{
	List *result = new List;
	result->head = NULL;
	return result;
}

void insert(List *list, ElementType value, Position position)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	Position tempBeforePosition = first(list);
	while (tempBeforePosition->next != position)
	{
		tempBeforePosition = tempBeforePosition->next;
	}
	if (tempBeforePosition == NULL)
	{
		cout << "No element before!\n";
		return;
	}
	newElement->next = tempBeforePosition->next;
	tempBeforePosition->next = newElement;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void print(List *list)
{
	Position positionTemp = list->head;
	if (positionTemp == NULL)
	{
		cout << "List is clear!\n";
		return;
	}
	cout << "List:\n";
	while (positionTemp != NULL)
	{
		cout << positionTemp->value << " ";
		positionTemp = positionTemp->next;
	}
	cout << "\n";
}

void deleteElement(List *list, Position position)
{
	if (position == NULL)
	{
		cout << "No element!\n";
		return;
	}
	Position tempBeforePosition = first(list);
	if (position == first(list))
	{
		Position tempOnPosition = position;
		list->head = position->next;
		delete tempOnPosition;
		return;
	}
	while (tempBeforePosition->next != position)
	{
		if (tempBeforePosition == NULL)
		{
			cout << "No element before!\n";
			return;
		}
		tempBeforePosition = tempBeforePosition->next;
	}
	Position tempOnPosition = position;
	tempBeforePosition->next = position->next;
	delete tempOnPosition;
}

Position first(List *list)
{
	return list->head;
}

Position next(List *list, Position position)
{
	return position->next;
}

ElementType returnValue(List *list, Position position)
{
	return position->value;
}

void deleteList(List *list)
{
	Position position = first(list);
	while (position != NULL)
	{
		Position temp = position;
		position = position->next;
		delete temp;
	}
	delete position;
	delete list;
}