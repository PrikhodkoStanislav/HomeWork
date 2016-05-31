#include <iostream>
#include "stack.h"

using namespace std;

struct StackElement
{
	ElementType value;
	StackElement *next;
};

struct Stack
{
	StackElement *head;
};

Stack *createStack()
{
	Stack *element = new Stack;
	element->head = nullptr;
	return element;
}

void addElement(Stack *stack, ElementType value)
{
	StackElement *element = new StackElement;
	element->value = value;
	element->next = stack->head;
	stack->head = element;
}

ElementType returnElement(Stack *stack)
{
	return stack->head->value;
}

bool emptyStack(Stack *stack)
{
	return (stack->head == nullptr);
}

void deleteElement(Stack *stack)
{
	StackElement *element = stack->head;
	if (element != nullptr)
	{
		stack->head = stack->head->next;
		delete element;
	}
	else
		cout << "Stack is empty!" << endl;
}

void deleteStack(Stack *stack)
{
	StackElement *element = stack->head;
	while (element != nullptr)
	{
		deleteElement(stack);
		element = stack->head;
	}
	delete stack;
}