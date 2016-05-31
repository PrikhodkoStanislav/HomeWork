#include <iostream>

#include "list.h"

using namespace std;

struct ListElement
{
	ElementType edge;
	ElementType nodeLeft;
	ElementType nodeRight;
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

void insert(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight, Position position)
{
	ListElement *newElement = new ListElement;
	if (position == nullptr)
	{
		insertToHead(list, value, nodeLeft, nodeRight);
		return;
	}
	newElement->edge = value;
	newElement->nodeLeft = nodeLeft;
	newElement->nodeRight = nodeRight;
	newElement->next = position->next;
	position->next = newElement;
}

void insertToHead(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight)
{
	ListElement *newElement = new ListElement;
	newElement->edge = value;
	newElement->nodeLeft = nodeLeft;
	newElement->nodeRight = nodeRight;
	newElement->next = list->head;
	list->head = newElement;
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
		cout << positionTemp->edge << endl;
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

ElementType edgeOnPosition(List *list, Position position)
{
	return position->edge;
}

ElementType leftNodeOnPosition(List *list, Position position)
{
	return position->nodeLeft;
}

ElementType rightNodeOnPosition(List *list, Position position)
{
	return position->nodeRight;
}

void deleteList(List *list)
{
	ListElement *element = list->head;
	while(element != nullptr)
	{
		ListElement *temp = element;
		element = element->next;
		delete temp;
	}
	delete element;
	delete list;
}

void add(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight)
{
	if (list->head == nullptr)
	{
		ListElement *element = new ListElement;
		element->edge = value;
		element->nodeLeft = nodeLeft;
		element->nodeRight = nodeRight;
		element->next = list->head;
		list->head = element;
		return;
	}
	ListElement *position = list->head;
	while (position->next != nullptr)
	{
		position = position->next;
	}
	ListElement *element = new ListElement;
	element->edge = value;
	element->nodeLeft = nodeLeft;
	element->nodeRight = nodeRight;
	element->next = nullptr;
	position->next = element;
}

List *makeSort(List *list1, List *list2, int length1, int length2)
{
	List *elementList = create();
	ListElement *position1 = list1->head;
	ListElement *position2 = list2->head;
	ListElement *position = elementList->head;
	while (position1 != nullptr || position2 != nullptr)
	{
		if (position1 == nullptr)
		{
			while (position2 != nullptr)
			{
				ListElement *element = new ListElement;
				element->edge = position2->edge;
				element->nodeLeft = position2->nodeLeft;
				element->nodeRight = position2->nodeRight;
				element->next = nullptr;
				if (position == nullptr)
				{
					elementList->head = element;
					position = element;
				}
				else
				{
					position->next = element;
					position = position->next;
				}
				position2 = position2->next;
			}
		}
		else
		{
			if (position2 == nullptr)
			{
				while (position1 != nullptr)
				{
					ListElement *element = new ListElement;
					element->edge = position1->edge;
					element->nodeLeft = position1->nodeLeft;
					element->nodeRight = position1->nodeRight;
					element->next = nullptr;
					if (position == nullptr)
					{
						elementList->head = element;
						position = element;
					}
					else
					{
						position->next = element;
						position = position->next;
					}
					position1 = position1->next;
				}
			}
			else
			{
				if (position1->edge <= position2->edge)
				{
					ListElement *element = new ListElement;
					element->edge = position1->edge;
					element->nodeLeft = position1->nodeLeft;
					element->nodeRight = position1->nodeRight;
					element->next = nullptr;
					if (position == nullptr)
					{
						elementList->head = element;
						position = element;
					}
					else
					{
						position->next = element;
						position = position->next;
					}
					position1 = position1->next;
				}
				else
				{
					ListElement *element = new ListElement;
					element->edge = position2->edge;
					element->nodeLeft = position2->nodeLeft;
					element->nodeRight = position2->nodeRight;
					element->next = nullptr;
					if (position == nullptr)
					{
						elementList->head = element;
						position = element;
					}
					else
					{
						position->next = element;
						position = position->next;
					}
					position2 = position2->next;
				}
			}
		}
	}
	return elementList;
}

List *sortList(List *list, int left, int right)
{
	ListElement *position = list->head;
	if (position == nullptr)
	{
		cout << "List is clear!\n";
		return nullptr;
	}
	if (right - left > 1)
	{
		List *newList = create();
		List *list1 = create();
		List *list2 = create();
		for (int i = left; i < ((right + left) / 2); i++)
		{
			add(list1, position->edge, position->nodeLeft, position->nodeRight);
			position = position->next;
		}
		for (int i = ((right + left ) / 2); i < right; i++)
		{
			add(list2, position->edge, position->nodeLeft, position->nodeRight);
			position = position->next;
		}
		newList = makeSort(sortList(list1, left, (right + left) / 2), sortList(list2, (right + left) / 2, right), ((right + left) / 2) - left, right - ((right + left) / 2));
		deleteList(list1);
		deleteList(list2);
		return newList;
	}
	return list;
}