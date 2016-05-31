#pragma once

typedef int PhoneType;
typedef char *NameType;
typedef int Position;

const int lengthOfName = 100;

struct List;

List *create();

void deleteList(List *list);
// insert element in the list
void insert(List *list, PhoneType number, NameType name);
// print list in the file
void print(List *list, char *name);
// return phone number of the number
PhoneType returnPhoneNumber(List *list, int number);
// return symbol of name in the position of the number
NameType returnName(List *list, int number);
// return last of the list
Position returnLast(List *list);
// write last in the list
void printLast(List *list, Position last);
// write phone number in the list on the "i"-th position
void printPhone(List *list, PhoneType phone, int i);
// write name in the list on the "i"-th position
void printName(List *list, NameType name, int i);