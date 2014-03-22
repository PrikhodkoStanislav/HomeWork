#pragma once

typedef int ElementType;

struct List;
struct ListElement;

typedef ListElement *Position;

List *create();

void insertToHead(List *list, ElementType value);  // insert element in the head of list
void deleteElement(List *list, Position position);  // delete element in the position
// insert elements in the source list and make of the source list in the circular list
void makeCircularList(List *list, ElementType numberOfWarriors);
Position first(List *list);  // return first element in the list
Position next(List *list, Position position);  // return next element after the position of the list
ElementType valueOfAlive(List *list, Position position);  // return value in the position of the list