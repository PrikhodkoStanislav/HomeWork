#include <iostream>
#include "list.h"

using namespace std;

struct list::ListElement
{
	ElementType value;
	int quantity;
	ListElement *next;
};

struct list::List 
{
	ListElement *head;
};

list::List *list::create()
{
	List *result = new List;
	result->head = nullptr;
	return result;
}

void list::insert(List *list, ElementType value, Position position)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->quantity = 1;
	newElement->next = position->next;
	position->next = newElement;
}

void list::insertToHead(List *list, ElementType value)
{
	ListElement *newElement = new ListElement;
	newElement->value = value;
	newElement->quantity = 1;
	newElement->next = list->head;
	list->head = newElement;
}

void list::removeList(List *list)
{
	ListElement *position = list->head;
	while (position != nullptr)
	{
		ListElement *temp = position;
		position = position->next;
		delete temp->value;
		delete temp;
	}
	delete list;
}

void list::remove(List *list, Position position)
{
	if (position == nullptr) 
	{
		cout << "Error" << endl;
		return;
	}
	Position temp = position;
	if (position == list->head)
		list->head = list->head->next;
	else
	{
		position = list->head;
		while (position->next != temp)
			position = position->next;
		position->next = temp->next;
	}
	delete temp;
}

list::Position list::positionOfElement(List *list, ElementType value)
{
	Position position = list->head;
	while (position != nullptr)
	{
		if (strcmp(position->value, value) == 0)
			return position;
		else
		{
			position = position->next;
		}
	}
	return nullptr;
}

void list::print(List *list)
{
	Position position = list->head;
	while (position != nullptr)
	{
		cout << position->value << endl;
		cout << "Number of repetition = " << position->quantity << "\n" << endl;
		position = position->next;
	}
}

bool list::exist(List *list, ElementType value)
{
	ListElement *position = list->head;
	while (position != nullptr)
	{
		if (strcmp(position->value, value) == 0)
			return true;
		else
			position = position->next;
	}
	return false;
}


list::Position list::first(List *list)
{
	return list->head;
}

list::Position list::end(List *list)
{
	return nullptr;
}
list::Position list::next(List *list, Position position)
{
	return position->next;
}
list::ElementType list::valueOnPosition(List *list, Position position)
{
	return position->value;
}

void list::quantityOfElementPlusOne(List *list, ElementType element)
{
	Position position = list->head;
	while (position != nullptr && strcmp(position->value, element) != 0)
	{
		position = position->next;
	}
	if (position != nullptr)
		position->quantity++;
	return;
}