#pragma once

typedef int ElementType;

struct Stack;

Stack *createStack();

void addElement(Stack *stack, ElementType value);

ElementType returnElement(Stack *stack);

bool emptyStack(Stack *stack);

void deleteElement(Stack *stack);

void deleteStack(Stack *stack);