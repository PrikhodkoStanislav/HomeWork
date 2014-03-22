#pragma once

typedef int ElementType;

struct List;
struct ListElement;

typedef int Position;

List *create();

void insertToHead(List *list, ElementType value);  // insert element in the head of list
void insert(List *list, ElementType value, Position position);  // insert element in the position
void print(List *list);  // print all list
Position first(List *list);  // return position of first element
Position next(List *list, Position position);  // return next position (after position)
Position end(List *list);  // return position of end of list (NULL)
ElementType returnValue(List *list, Position position);  // return value of the element in the position
void deleteList(List *list);  // delete all elements of the list
bool noolPosition(List *list, Position position);