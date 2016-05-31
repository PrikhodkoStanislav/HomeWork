#pragma once

// type of the element in the list
typedef int ElementType;

struct List;

// element of the list
struct ListElement;

// type of ukazatel' on the element
typedef ListElement *Position;

// create the list
List *create();

// insert element next position
void insert(List *list, ElementType value);

// insert element in the head of list
void insertToHead(List *list, ElementType value);

// return position of first element
Position first(List *list);

// return position of end of list (NULL)
Position end(List *list);

// return next position (after position)
Position next(List *list, Position position);

// return element ofist in position
ElementType valueOnPosition(List *list, Position position);

// delete list
void deleteList(List *list)