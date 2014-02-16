#pragma once

typedef char Element;
typedef int Number;

struct Tree;
struct TreeElement;

typedef TreeElement *Position;

Tree *create();

// delete tree
void deleteTree(Tree *tree);
// print the tree on the screen
void print(Tree *tree);
// write expression in the tree
void writeInTree(Tree *tree, char *buffer);
// count value of expression
int valueOfExpression(Tree *tree);