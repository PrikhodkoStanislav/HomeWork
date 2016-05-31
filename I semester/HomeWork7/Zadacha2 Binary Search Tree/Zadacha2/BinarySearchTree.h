#pragma once

typedef int Element;

struct Tree;

Tree *create();

// delete tree
void deleteTree(Tree *tree);

// insert element with value in the tree
void insertElement(Tree *tree, Element value);

// delete element with value from the tree
void deleteElement(Tree *tree, Element value);

// Is value in the tree?
bool exists(Tree *tree, Element value);

// print tree in descendinging order
void printUp(Tree *tree);

// print tree in ascending order
void printDown(Tree *tree);