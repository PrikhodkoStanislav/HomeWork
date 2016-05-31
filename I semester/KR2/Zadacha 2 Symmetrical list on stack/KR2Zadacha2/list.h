#pragma once
#include "stack.h"

typedef int ElementType;  // type of the element in the list

struct List;
struct ListElement;  // element of the list

typedef ListElement *Position;  // type of ukazatel' on the element

List *create();  // create the list

void insert(List *list, ElementType value);  // insert element
void insertToHead(List *list, ElementType value);  // insert element in the head of list
void remove(List *list, Position position);  // delete element in position
void print(List *list);  // print all list
Position first(List *list);  // return position of first element
Position end(List *list);  // return position of end of list (NULL)
Position next(List *list, Position position);  // return next position (after position)
ElementType valueOnPosition(List *list, Position position);  // return element ofist in position
void deleteList(List *list); // delete list
bool symmetricalList(List *list); // Is list symmetric?