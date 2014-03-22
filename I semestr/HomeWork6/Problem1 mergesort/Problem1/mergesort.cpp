#include "mergesort.h"
#include <iostream>
#include <fstream>
#include <string.h>

using namespace std;

int counter = 0;

struct List
{
	ListElement *head;
};

struct ListElement
{
	PhoneType value;
	NameType name;
	ListElement *next;
};

List *create()
{
	counter++;
	List *list = new List;
	list->head = nullptr;
	return list;
}

void deleteList(List *list)
{
	counter--;
	while (list->head != nullptr)
	{
		ListElement *temp = list->head;
		list->head = list->head->next;
		delete temp;
	}
	delete list->head;
	delete list;
}

void printStatistic()
{
	cout << 0 << endl;
}

void add(List *list, PhoneType phone, NameType name)
{
	if (list->head == nullptr)
	{
		ListElement *element = new ListElement;
		element->value = phone;
		element->name = new char[1000];
		strcpy(element->name, name);
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
	element->value = phone;
	element->name = new char[1000];
	strcpy(element->name, name);
	element->next = nullptr;
	position->next = element;
}

void printList(List *list)
{
	if (list->head == nullptr)
	{
		cout << "List is clear!\n";
		return;
	}
	ListElement *position = list->head;
	while (position != nullptr)
	{
		cout << position->name << endl;
		cout << position->value << endl;
		position = position->next;
	}
}

List *makeSort(List *list1, List *list2, int length1, int length2, bool phoneOrName)
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
				element->name = position2->name;
				element->value = position2->value;
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
					element->name = position1->name;
					element->value = position1->value;
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
				if ((position1->value <= position2->value && !phoneOrName) || (strcmp(position1->name, position2->name) <= 0 && phoneOrName))
				{
					ListElement *element = new ListElement;
					element->name = position1->name;
					element->value = position1->value;
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
					element->name = position2->name;
					element->value = position2->value;
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
	deleteList(list1);
	deleteList(list2);
	return elementList;
}

List *sortList(List *list, int left, int right, bool phoneOrName)
{
	ListElement *position = list->head;
	if (position == nullptr)
	{
		return list;
	}
	if (right - left > 1)
	{
		List *newList = create();
		List *list1 = create();
		List *list2 = create();
		for (int i = left; i < ((right + left) / 2); i++)
		{
			add(list1, position->value, position->name);
			position = position->next;
		}
		for (int i = ((right + left ) / 2); i < right; i++)
		{
			add(list2, position->value, position->name);
			position = position->next;
		}
		newList = makeSort(sortList(list1, left, (right + left) / 2, phoneOrName), sortList(list2, (right + left) / 2, right, phoneOrName), ((right + left) / 2) - left, right - ((right + left) / 2), phoneOrName);
		return newList;
	}
	return list;
}