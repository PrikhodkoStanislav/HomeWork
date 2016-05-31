#include <iostream>
#include "hash.h"

using namespace list;

const int b = 10;

struct hash::HashTable
{
	List *bucket[b];
};

hash::HashTable *hash::createHashTable()
{
	HashTable *hashTable = new HashTable;
	for (int i = 0; i < b; i++)
		hashTable->bucket[i] = create();
	return hashTable;
}

void hash::deleteHashTable(HashTable *hashTable)
{
	for (int i = 0; i < b; i++)
	{
		removeList(hashTable->bucket[i]);
	}
	delete hashTable;
}

int hashFunction(ElementType newElement)
{
	int number = ((strlen(newElement) + 7) * (strlen(newElement)) % b);
	return number;
}

void hash::insertToHashTable(HashTable *hashTable, ElementType newElement)
{
	if (exist(hashTable->bucket[hashFunction(newElement)], newElement))
	{
		quantityOfElementPlusOne(hashTable->bucket[hashFunction(newElement)], newElement);
		return;
	}
	insertToHead(hashTable->bucket[hashFunction(newElement)], newElement);
}

bool hash::exist(HashTable *hashTable, ElementType element)
{
	return exist(hashTable->bucket[hashFunction(element)], element);
}

void hash::remove(HashTable *hashTable, ElementType element)
{
	remove(hashTable->bucket[hashFunction(element)], positionOfElement(hashTable->bucket[hashFunction(element)], element));
}

void hash::printHashTable(HashTable *hashTable)
{
	for (int i = 0; i < b; i++)
	{
		print(hashTable->bucket[i]);
	}
}