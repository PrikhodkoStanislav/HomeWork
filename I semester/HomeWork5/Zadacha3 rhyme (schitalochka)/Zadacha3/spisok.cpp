#include <iostream>
#include "spisok.h"

using namespace std;

struct List
{
	ListElement *head;
};

struct ListElement
{
	ElementType value;
	ListElement *next;
};

List *create()
{
	List *result = new List;
	result->head = NULL;
	return result;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

void deleteElement(List *list, Position position)
{
	Position tempBeforePosition = list->head;
	Position tempOnPosition = position;
	if (position == list->head)
	{
		while (tempBeforePosition->next != position)
		{
			tempBeforePosition = tempBeforePosition->next;
		}
		tempBeforePosition->next = position->next;
		list->head = position->next;
		delete tempOnPosition;
		return;
	}
	while (tempBeforePosition->next != position)
	{
		tempBeforePosition = tempBeforePosition->next;
	}
	tempBeforePosition->next = position->next;
	delete tempOnPosition;
}

void makeCircularList(List *list, ElementType numberOfWarriors)
{
	insertToHead(list, 1);
	Position position = list->head;  // current position, after which add an element
	for (ElementType i = 2; i <= numberOfWarriors; i++)
	{
		ListElement *newElement = new ListElement;
		newElement->value = i;
		newElement->next = position->next;
		position->next = newElement;
		position = position->next;
	}
	position->next = list->head;  // the last item points to the first
}

Position first(List *list)
{
	return list->head;
}

Position next(List *list, Position position)
{
	return position->next;
}

ElementType valueOfAlive(List *list, Position position)
{
	return position->value;
}