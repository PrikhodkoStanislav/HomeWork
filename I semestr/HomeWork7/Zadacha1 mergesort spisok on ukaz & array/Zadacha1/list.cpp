#include <iostream>
#include "list.h"

using namespace std;

namespace listName
{

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
		result->head = nullptr;
		return result;
	}

	void insertToHead(List *list, ElementType value)
	{
		ListElement *newElement = new ListElement;
		newElement->value = value;
		newElement->next = list->head;
		list->head = newElement;
	}

	void insert(List *list, ElementType value, Position position)
	{
		ListElement *newElement = new ListElement;
		newElement->value = value;
		Position tempBeforePosition = first(list);
		while (tempBeforePosition->next != nullptr && tempBeforePosition->next != position)
		{
			tempBeforePosition = tempBeforePosition->next;
		}
		if (tempBeforePosition == nullptr)
		{
			cout << "No element before!\n";
			return;
		}
		newElement->next = tempBeforePosition->next;
		tempBeforePosition->next = newElement;
	}

	void print(List *list)
	{
		Position positionTemp = list->head;
		if (positionTemp == nullptr)
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
		while (position != nullptr)
		{
			Position temp = position;
			position = position->next;
			delete temp;
		}
		delete position;
		delete list;
	}

	bool noolPosition(List *list, Position position)
	{
		return (position == nullptr);
	}
}