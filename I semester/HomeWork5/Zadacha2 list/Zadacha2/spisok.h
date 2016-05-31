#pragma once

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

List *create();

void insert(List *list, ElementType value, Position position);  // insert element in the position
void insertToHead(List *list, ElementType value);  // insert element in the head of list
void print(List *list);  // print all list
void deleteElement(List *list, Position position);  // delete element in the position
Position first(List *list);  // return position of first element
Position next(List *list, Position position);  // return next position (after position)
Position end(List *list);  // return position of end of list (NULL)
ElementType returnValue(List *list, Position position);  // return value of the element in the position
void deleteList(List *list);  // delete all elements of the list