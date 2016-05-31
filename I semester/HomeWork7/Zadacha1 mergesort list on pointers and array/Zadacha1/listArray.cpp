#include <iostream>
#include "list.h"

using namespace std;

const int length = 100;

namespace arrayName
{

	struct List
	{
		ElementType value[length];
		int number;
	};

	List *create()
	{
		List *result = new List;
		result->number = 0;
		return result;
	}

	void insertToHead(List *list, ElementType value)
	{
		list->value[list->number] = value;
		list->number++;
	}

	void insert(List *list, ElementType value, arrayName::Position position)
	{
		list->value[position] = value;
		list->number++;
	}

	void print(List *list)
	{
		if (list->number == 0)
		{
			cout << "List is clear!\n";
			return;
		}
		cout << "List:\n";
		for (int i = 0; i < list->number; i++)
		{
			cout << list->value[i] << " ";
		}
		cout << "\n";
	}

	arrayName::Position first(List *list)
	{
		return 0;
	}

	arrayName::Position next(List *list, arrayName::Position position)
	{
		return (position + 1);
	}

	ElementType returnValue(List *list, arrayName::Position position)
	{
		return list->value[position];
	}

	void deleteList(List *list)
	{
		delete list;
	}

	bool noolPosition(List *list, arrayName::Position position)
	{
		return (position >= list->number);
	}
}