#pragma once

typedef int ElementType;

struct Stack;

Stack *createStack();

void addElement(Stack *stack, ElementType value); // add value in stack

ElementType returnElement(Stack *stack); // return element fron the stack

bool emptyStack(Stack *stack); // Is stack empty?

void deleteElement(Stack *stack); // delete element fron stack

void deleteStack(Stack *stack); // delete stack