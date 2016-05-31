/*Tests:
1)
Adjacency matrix of spanning tree:
 0 0 0 1 0
 0 0 6 3 0
 0 6 0 0 1
 1 3 0 0 0
 0 0 1 0 0
Для продолжения нажмите любую клавишу . . .

2)
Adjacency matrix of spanning tree:
   0  10   0   0   0
  10   0   7   5   0
   0   7   0   0   1
   0   5   0   0   0
   0   0   1   0   0
Для продолжения нажмите любую клавишу . . .

3)
Adjacency matrix of spanning tree:
   0   0   0  11   0
   0   0   0   5   0
   0   0   0   0   1
  11   5   0   0   4
   0   0   1   4   0
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>
#include "list.h"

using namespace std;

int main()
{
	ifstream input("graph.txt");
	int numberOfNodes = 0;
	input >> numberOfNodes;
	int **graph = new int*[numberOfNodes];
	for (int i = 0; i < numberOfNodes; i++)
	{
		graph[i] = new int[numberOfNodes];
	}
	for (int i = 0; i < numberOfNodes; i++)
	{
		for (int j = 0; j < numberOfNodes; j++)
		{
			input >> graph[i][j];
		}
	}
	List *list = create();
	Position position = first(list);
	int numberOfEdges = 0;
	for (int i = 0; i < numberOfNodes; i++)
	{
		for (int j = i; j < numberOfNodes; j++)
		{
			if (graph[i][j] != 0)
			{
				insert(list, graph[i][j], i, j, position);
				numberOfEdges++;
				if (position != end(list))
					position = next(list, position);
			}
		}
	}
	list = sortList(list, 0, numberOfEdges);
	int *arrayOfNodes = new int[numberOfNodes];
	for (int i = 0; i < numberOfNodes; i++)
	{
		arrayOfNodes[i] = i + 1;
	}
	int markerOfNewElement = 0;
	List *listOfResult = create();
	Position positionResult = first(listOfResult);
	for (Position position = first(list); position != end(list); position = next(list, position))
	{
		if (arrayOfNodes[leftNodeOnPosition(list, position)] != arrayOfNodes[rightNodeOnPosition(list, position)])
		{
			if (arrayOfNodes[leftNodeOnPosition(list, position)] > 0 && arrayOfNodes[rightNodeOnPosition(list, position)] > 0)
			{
				arrayOfNodes[leftNodeOnPosition(list, position)] = markerOfNewElement;
				arrayOfNodes[rightNodeOnPosition(list, position)] = markerOfNewElement;
				markerOfNewElement--;
			}
			else
			{
				if (arrayOfNodes[leftNodeOnPosition(list, position)] <= 0 && arrayOfNodes[rightNodeOnPosition(list, position)] <= 0)
				{
					for (int i = 0; i < numberOfNodes; i++)
					{
						if (arrayOfNodes[i] == max(arrayOfNodes[leftNodeOnPosition(list, position)], arrayOfNodes[rightNodeOnPosition(list, position)]))
						{
							if (i != leftNodeOnPosition(list, position) && i != rightNodeOnPosition(list, position))
							{
								arrayOfNodes[i] = min(arrayOfNodes[leftNodeOnPosition(list, position)], arrayOfNodes[rightNodeOnPosition(list, position)]);
							}
						}
					}
				}
			}
			arrayOfNodes[leftNodeOnPosition(list, position)] = min(arrayOfNodes[leftNodeOnPosition(list, position)], arrayOfNodes[rightNodeOnPosition(list, position)]);
			arrayOfNodes[rightNodeOnPosition(list, position)] = min(arrayOfNodes[leftNodeOnPosition(list, position)], arrayOfNodes[rightNodeOnPosition(list, position)]);
			insert(listOfResult, edgeOnPosition(list, position), leftNodeOnPosition(list, position), rightNodeOnPosition(list, position), positionResult);
			if (positionResult != nullptr)
			{
				positionResult = next(listOfResult, positionResult);
			}
		}
	}
	int **spanningTree = new int*[numberOfNodes];
	for (int i = 0; i < numberOfNodes; i++)
	{
		spanningTree[i] = new int[numberOfNodes];
	}
	for (int i = 0; i < numberOfNodes; i++)
	{
		for (int j = 0; j < numberOfNodes; j++)
		{
			spanningTree[i][j] = 0;
		}
	}
	for (Position position = first(listOfResult); position != end(listOfResult); position = next(listOfResult, position))
	{
		spanningTree[leftNodeOnPosition(listOfResult, position)][rightNodeOnPosition(listOfResult, position)] = edgeOnPosition(listOfResult, position);
		spanningTree[rightNodeOnPosition(listOfResult, position)][leftNodeOnPosition(listOfResult, position)] = edgeOnPosition(listOfResult, position);
	}
	cout << "Adjacency matrix of spanning tree:\n";
	for (int i = 0; i < numberOfNodes; i++)
	{
		for (int j = 0; j < numberOfNodes; j++)
		{
			cout.width(4);
			cout << spanningTree[i][j];
		}
		cout << "\n";
	}
	input.close();
	deleteList(list);
	deleteList(listOfResult);
	delete []arrayOfNodes;
	for (int i = 0; i < numberOfNodes; i++)
	{
		delete []spanningTree[i];
	}
	delete []spanningTree;
	for (int i = 0; i < numberOfNodes; i++)
	{
		delete []graph[i];
	}
	delete []graph;
	return 0;
}