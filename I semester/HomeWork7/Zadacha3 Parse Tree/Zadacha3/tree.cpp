#include <iostream>
#include "tree.h"

using namespace std;

struct TreeElement
{
	Element value;
	Number number;
	TreeElement *left;
	TreeElement *right;
	TreeElement *up;
};

struct Tree
{
	TreeElement *head;
};

Tree *create()
{
	Tree *newTree = new Tree;
	newTree->head = nullptr;
	return newTree;
}

void deleteSubTree(TreeElement *element)
{
	if (element != nullptr)
	{
		deleteSubTree(element->left);
		deleteSubTree(element->right);
		delete element;
	}
}

void deleteTree(Tree *tree)
{
	deleteSubTree(tree->head);
	delete tree;
}

TreeElement *createNewElement(Element value)
{
	TreeElement *temp = new TreeElement;
	temp->value = value;
	temp->number = 0;
	temp->left = nullptr;
	temp->right = nullptr;
	temp->up = nullptr;
	return temp;
}

Position first(Tree *tree)
{
	return tree->head;
}

Position left(Tree *tree, Position position)
{
	return position->left;
}

Position right(Tree *tree, Position position)
{
	return position->right;
}

Position up(Tree *tree, Position position)
{
	return position->up;
}

bool isNumber(char element)
{
	return ((static_cast<int>(element) >= static_cast<int>('0')) && (static_cast<int>(element) - static_cast<int>('0') <= 9));
}

bool isFunction(char element)
{
	return ((element == '+') | (element == '-') | (element == '*') | (element == '/'));
}

void createNewElementWithNumber(Tree *tree, Position position, char value)
{
	TreeElement *newElement = new TreeElement;
	newElement->number = static_cast<int>(value) - static_cast<int>('0');
	newElement->left = nullptr;
	newElement->right = nullptr;
	newElement->value = '#';
	newElement->up = position;
	if (position->left == nullptr)
	{
		position->left = newElement;
	}
	else
	{
		position->right = newElement;
	}
}

void insertSubTree(Tree *tree, char *buffer, int &i, Position position)
{
	while (i < strlen(buffer))
	{
		char p = buffer[i];
		if (p == '(')
		{
			TreeElement *newElement = createNewElement(buffer[i + 1]);
			newElement->up = position;
			if (position == nullptr)
			{
				tree->head = newElement;
				position = newElement;
			}
			else
			{
				if (position->left == nullptr)
				{
					position->left = newElement;
				}
				else
				{
					position->right = newElement;
				}
				position = newElement;
			}
			i += 2;
			insertSubTree(tree, buffer, i, position);
			insertSubTree(tree, buffer, i, position);
		}
		else
		{
			if (isNumber(buffer[i]))
			{
				createNewElementWithNumber(tree, position, buffer[i]);
				i++;
			}
			else
			{
				if (buffer[i] == ')')
				{
					position = up(tree, position);
					i++;
				}
			}
		}
	}
}

void writeInTree(Tree *tree, char *buffer)
{
	Position position = first(tree);
	int i = 0;
	insertSubTree(tree, buffer, i, position);
}

void printSubTree(Position position)
{
	if (isFunction(position->value))
	{
		cout << "( " << position->value << " ";
		printSubTree(position->left);
		printSubTree(position->right);
	}
	else
	{
		cout << position->number << " ";
		if (position == position->up->right)
			cout << ") ";
	}
}

void print(Tree *tree)
{
	Position position = tree->head;
	if (position != nullptr)
		printSubTree(position);
	else
		cout << "Tree is clear!\n";
}

int makeOperation(int number1, int number2, char operation)
{
	if (operation == '+')
	{
		return (number1 + number2);
	}
	if (operation == '*')
	{
		return (number1 * number2);
	}
	if (operation == '-')
	{
		return (number1 - number2);
	}
	if (operation == '/')
	{
		return (number1 / number2);
	}
}

int count(Position position)
{
	if (isFunction(position->value))
	{
		return (makeOperation(count(position->left), count(position->right), position->value));
	}
	else
	{
		return (position->number);
	}
}

int valueOfExpression(Tree *tree)
{
	Position position = tree->head;
	if (position != nullptr)
	{
		return (count(position));
	}
	return 0;
}