#include <iostream>

#include "list.h"

using namespace std;

struct ListElement
{
	ElementType value;
	ListElement *next;
};

struct List
{
	ListElement *head;
	int lenght;
};

List *create()
{
	List *result = new List;
	result->lenght = 0;
	result->head = nullptr;
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
	list->lenght += 1;
}

void insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->next = list->head;
	list->head = newElement;
	list->lenght += 1;
}

void remove(List *list, Position position)
{
	if (position->next == nullptr)
	{
		cout << "No element!" << endl;
		return;
	}
	Position temp = position->next;
	position->next = temp->next;
	delete temp;
}

void print(List *list)
{
	Position positionTemp = list->head;
	while (positionTemp != nullptr)
	{
		cout << positionTemp->value << endl;
		positionTemp = positionTemp->next;
	}
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

bool symmetricalList(List *list)
{
	Position position = list->head;
	Stack *stack = createStack();
	if (position == nullptr)
	{
		return true;
	}
	if (list->lenght % 2 != 0)
	{
		for (int i = 0; i < (list->lenght / 2); i++)
		{
			addElement(stack, position->value);
			position = position->next;
		}
		if (list->lenght % 2 != 0)
			position = position->next;
		for (int i = 0; i < (list->lenght / 2); i++)
		{
            if (returnElement(stack) != position->value)
            {
                deleteStack(stack);
                return false;
            }
			deleteElement(stack);
			position = position->next;
		}
	}
	deleteStack(stack);
	return true;
}