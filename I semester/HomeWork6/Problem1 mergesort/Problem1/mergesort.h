#pragma once

struct List;
struct ListElement;

typedef int PhoneType;
typedef char *NameType;

List *create();

// delete list
void deleteList(List *list);

// addition new element in the list
void add(List *list, PhoneType phone, NameType name);

// sorting the list in the selected version
List *sortList(List *list, int left, int right, bool phoneOrName);

// print the entire list
void printList(List *list);

void printStatistic();