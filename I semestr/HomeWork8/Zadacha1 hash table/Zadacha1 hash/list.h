#pragma once

namespace list
{

struct List;
struct ListElement;
typedef char *ElementType;
typedef ListElement *Position;
// create new list
List *create();
// insert new element with value in the position of the list
void insert(List *list, ElementType value, Position position);
// insert new element with value in the head of the list
void insertToHead(List *list, ElementType value);
// remove all list
void removeList(List *list);
// remove element of the list in the position
void remove(List *list, Position position);
// return position of element with value
Position positionOfElement(List *list, ElementType value);
// print value of all elements of the list with their repetition on console
void print(List *list);
// return first element of the list
Position first(List *list);
// return last element of the list
Position end(List *list);
// return next element after the position of the list
Position next(List *list, Position position);
// return value of the element in the position of the list
ElementType valueOnPosition(List *list, Position position);
// add to the quantity of elements one
void quantityOfElementPlusOne(List *list, ElementType element);
// Is element with value in the list?
bool exist(List *list, ElementType value);
}