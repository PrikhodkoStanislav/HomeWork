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
void insert(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight, Position position);
// insert element in the head of list
void insertToHead(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight);
// delete element in position
void remove(List *list, Position position);
// print all list
void print(List *list);
// return position of first element
Position first(List *list);
// return position of end of list (nullptr)
Position end(List *list);
// return next position (after position)
Position next(List *list, Position position);
// return edge of element in position
ElementType edgeOnPosition(List *list, Position position);
// return left node of element in position
ElementType leftNodeOnPosition(List *list, Position position);
// return right node of element in position
ElementType rightNodeOnPosition(List *list, Position position);
// delete list
void deleteList(List *list);
// addition new element in the list
void add(List *list, ElementType value, ElementType nodeLeft, ElementType nodeRight);
// sorting the list in the selected version
List *sortList(List *list, int left, int right);