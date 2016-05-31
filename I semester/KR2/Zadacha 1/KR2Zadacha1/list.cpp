#include <iostream>

#include "list.h"

; using namespace std;

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

void deleteList(List *list)
{
	Position position = list->head;
	while (position != nullptr)
	{
		Position temp = position;
		position = position->next;
		delete temp;
	}
	delete position;
	delete list;
}

void insert(List *list, ElementType value)
{
	Position position = list->head;
	if (position == nullptr)
	{
		insertToHead(list, value);
		return;
	}
	while (position->next != nullptr)
	{
		position = position->next;
	}
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = position->next;
	position->next = newElement;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
}

Position first(List *list)
{
	return list->head;
}

Position end(List *list)
{
	return nullptr;
}

Position next(List *list, Position position)
{
	return position->next;
}

ElementType valueOnPosition(List *list, Position position)
{
	return position->value;
}