#pragma once

namespace listName
{
	typedef int ElementType;

	struct List;
	struct ListElement;

	List *create();

	typedef ListElement *Position;

	// insert element in the head of list
	void insertToHead(List *list, ElementType value);

	// insert element in the position
	void insert(List *list, ElementType value, Position position);

	// print all list
	void print(List *list);

	// return position of first element
	Position first(List *list);

	// return next position (after position)
	Position next(List *list, Position position);

	// return position of end of list (NULL)
	Position end(List *list);

	// return value of the element in the position
	ElementType returnValue(List *list, Position position);

	// delete all elements of the list
	void deleteList(List *list);

	bool noolPosition(List *list, Position position);
}

namespace arrayName
{
	typedef int ElementType;

	struct List;
	struct ListElement;

	List *create();

	typedef int Position;

	// insert element in the head of list
	void insertToHead(List *list, ElementType value);

	// insert element in the position
	void insert(List *list, ElementType value, Position position);

	// print all list
	void print(List *list);

	// return position of first element
	Position first(List *list);

	// return next position (after position)
	Position next(List *list, Position position);

	// return position of end of list (NULL)
	Position end(List *list);

	// return value of the element in the position
	ElementType returnValue(List *list, Position position);

	// delete all elements of the list
	void deleteList(List *list);

	bool noolPosition(List *list, Position position);
}