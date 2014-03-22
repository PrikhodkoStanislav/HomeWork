#pragma once

typedef char ElementType;

struct Stack;

Stack *createStack();

// addition element in the stack
void addElement(Stack *stack, ElementType value);
// return element from the stack
ElementType returnElement(Stack *stack);
// Is stack empty?
bool emptyStack(Stack *stack);
// delete element from the stack
void deleteElement(Stack *stack);
// delete stack
void deleteStack(Stack *stack);