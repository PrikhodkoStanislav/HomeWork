#pragma once
#include "list.h"

using namespace list;

namespace hash
{
struct HashTable;
// create new hashtable
HashTable *createHashTable();
// delete hashtable
void deleteHashTable(HashTable *hashTable);
// insert to hashtable new element
void insertToHashTable(HashTable *hashTable, ElementType newElement);
// Is element in the hashtable?
bool exist(HashTable *hashTable, ElementType element);
// remove element from hashtable
void remove(HashTable *hashTable, ElementType element);
// print elements of hashtable with number of their repetition on console
void printHashTable(HashTable *hashTable);
}