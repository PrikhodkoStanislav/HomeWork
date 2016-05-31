#include <iostream>
#include "mergesort.h"

using namespace std;

List *makeSort(List *list1, List *list2, int length1, int length2)
{
	List *elementList = create();
	Position position1 = first(list1);
	Position position2 = first(list2);
	Position position = first(elementList);
	while (!noolPosition(list1, position1) || !noolPosition(list2, position2))
	{
		if (noolPosition(list1, position1))
		{
			while (!noolPosition(list2, position2))
			{
				if (noolPosition(elementList, position))
				{
					insertToHead(elementList, returnValue(list2, position2));
					position = first(list2);
				}
				else
				{
					insert(elementList, returnValue(list2, position2), next(elementList, position));
					position = next(elementList, position);
				}
				position2 = next(list2, position2);
			}
		}
		else
		{
			if (noolPosition(list2, position2))
			{
				while (!noolPosition(list1, position1))
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list1, position1));
						position = first(list1);
					}
					else
					{
						insert(elementList, returnValue(list1, position1), next(elementList, position));
						position = next(elementList, position);
					}
					position1 = next(list1, position1);
				}
			}
			else
			{
				if (returnValue(list1, position1) <= returnValue(list2, position2))
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list1, position1));
						position = first(elementList);
					}
					else
					{
						insert(elementList, returnValue(list1, position1), next(elementList, position));
						position = next(elementList, position);
					}
					position1 = next(list1, position1);
				}
				else
				{
					if (noolPosition(elementList, position))
					{
						insertToHead(elementList, returnValue(list2, position2));
						position = first(elementList);
					}
					else
					{
						insert(elementList, returnValue(list2, position2), next(elementList, position));
						position = next(elementList, position);
					}
					position2 = next(list2, position2);
				}
			}
		}
	}
	deleteList(list1);
	deleteList(list2);
	return elementList;
}

List *sortList(List *list, int left, int right)
{
	Position position = first(list);
	if (noolPosition(list, position))
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
			insertToHead(list1, returnValue(list, position));
			position = next(list, position);
		}
		for (int i = ((right + left) / 2); i < right; i++)
		{
			insertToHead(list2, returnValue(list, position));
			position = next(list, position);
		}
		newList = makeSort(sortList(list1, left, (right + left) / 2), sortList(list2, (right + left) / 2, right), ((right + left) / 2) - left, right - ((right + left) / 2));
		return newList;
	}
	return list;
}