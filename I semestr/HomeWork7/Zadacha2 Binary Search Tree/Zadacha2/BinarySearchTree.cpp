#include <iostream>
#include "binarySearchTree.h"

using namespace std;

struct TreeElement
{
	Element value;
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
	temp->left = nullptr;
	temp->right = nullptr;
	temp->up = nullptr;
	return temp;
}

void insertElement(Tree *tree, Element value)
{
	TreeElement *element = tree->head;
	if (element == nullptr)
	{
		tree->head = createNewElement(value);
		tree->head->up = nullptr;
		return;
	}
	while (element != nullptr && element->value != value)
	{
		if (element->value < value)
		{
			if (element->right == nullptr)
			{
				element->right = createNewElement(value);
				element->right->up = element;
				return;
			}
			element = element->right;
		}
		else
		{
			if (element->value > value)
			{
				if (element->left == nullptr)
				{
					element->left = createNewElement(value);
					element->left->up = element;
					return;
				}
				element = element->left;
			}
		}
	}
}

void deleteElementInSubTree(Tree *tree, TreeElement *element, Element value)
{
	if (element == nullptr)
	{
		cout << "Wrong value!\n";
		return;
	}
	if (element->value == value)
	{
		if (element == tree->head)
		{
			if (element->left == nullptr)
			{
				tree->head = element->right;
				if (tree->head != nullptr)
				{
					tree->head->up = nullptr;
				}
				delete element;
				return;
			}
			else
			{
				TreeElement *temp = element->left;
				if (temp->right == nullptr)
				{
					tree->head = element->left;
					if (tree->head != nullptr)
						tree->head->up = nullptr;
					tree->head->right = element->right;
					if (tree->head->right != nullptr)
						tree->head->right->up = tree->head;
					delete element;
					return;
				}
				else
				{
					while (temp->right->right != nullptr)
					{
						temp = temp->right;
					}
					tree->head = temp->right;
					if (tree->head != nullptr)
						tree->head->up = nullptr;
					temp->right = temp->right->left;
					if (temp->right != nullptr)
						temp->right->up = temp;
					tree->head->left = element->left;
					if (tree->head->left != nullptr)
						tree->head->left->up = tree->head;
					tree->head->right = element->right;
					if (tree->head->right != nullptr)
						tree->head->right->up = tree->head;
					delete element;
					return;
				}
			}
		}

		if (element->left == nullptr)
		{
			if (element == element->up->left)
			{
				element->up->left = element->right;
				if (element->up->left != nullptr)
					element->up->left->up = element->up;
			}
			else
			{
				element->up->right = element->right;
				if (element->up->right != nullptr)
					element->up->right->up = element->up;
			}
			delete element;
			return;
		}
		else
		{
			TreeElement *temp = element->left;
			if (temp->right == nullptr)
			{
				if (element == element->up->left)
				{
					element->up->left = element->left;
					if (element->up->left != nullptr)
						element->up->left->up = element->up;
					element->up->left->right = element->right;
					if (element->up->left->right != nullptr)
						element->up->left->right->up = element->up->left;
				}
				else
				{
					element->up->right = element->right;
					if (element->up->right != nullptr)
						element->up->right->up = element->up;
					element->up->right->left = element->left;
					if (element->up->right->left != nullptr)
						element->up->right->left->up = element->up->right;
				}
				delete element;
				return;
			}
			else
			{
				while (temp->right->right != nullptr)
				{
					temp = temp->right;
				}
				if (element == element->up->left)
				{
					element->up->left = temp->right;
					if (element->up->left != nullptr)
						element->up->left->up = element->up;
					temp->right = temp->right->left;
					if (temp->right != nullptr)
						temp->right->up = temp;
					element->up->left->left = element->left;
					if (element->up->left->left != nullptr)
						element->up->left->left->up = element->up->left;
					element->up->left->right = element->right;
					if (element->up->left->right != nullptr)
						element->up->left->right->up = element->up->left;
				}
				else
				{
					element->up->right = temp->right;
					if (element->up->right != nullptr)
						element->up->right->up = element->up;
					temp->right = temp->right->left;
					if (temp->right != nullptr)
						temp->right->up = temp;
					element->up->right->left = element->left;
					if (element->up->right->left != nullptr)
						element->up->right->left->up = element->up->right;
					element->up->right->right = element->right;
					if (element->up->right->right != nullptr)
						element->up->right->right->up = element->up->right;
				}
				delete element;
				return;
			}
		}
	}
	if (element->value > value)
	{
		deleteElementInSubTree(tree, element->left, value);
	}
	else
	{
		deleteElementInSubTree(tree, element->right, value);
	}
}

void deleteElement(Tree *tree, Element value)
{
	deleteElementInSubTree(tree, tree->head, value);
}

bool exists(Tree *tree, Element value)
{
	TreeElement *element = tree->head;
	while (element != nullptr && element->value != value)
	{
		if (element->value < value)
		{
			element = element->right;
		}
		else
		{
			if (element->value > value)
			{
				element = element->left;
			}
		}
	}
	if (element == nullptr)
		return false;
	else
		return true;
}

void printSubTreeUp(TreeElement *element)
{
	if (element->left != nullptr)
		printSubTreeUp(element->left);
	cout << element->value << " ";
	if (element->right!= nullptr)
		printSubTreeUp(element->right);
}

void printUp(Tree *tree)
{
	TreeElement *element = tree->head;
	if (element != nullptr)
		printSubTreeUp(element);
	else
		cout << "Tree is clear!\n";
}

void printSubTreeDown(TreeElement *element)
{
	if (element->right!= nullptr)
		printSubTreeDown(element->right);
	cout << element->value << " ";
	if (element->left != nullptr)
		printSubTreeDown(element->left);
}

void printDown(Tree *tree)
{
	TreeElement *element = tree->head;
	if (element != nullptr)
		printSubTreeDown(element);
	else
		cout << "Tree is clear!\n";
}