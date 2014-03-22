#include "Sort.h"

void sort(int arraySorce[100], int right) // heap sort
{
	int maxSon = 0;
	int maxNumber = 0;
	for (int i = ((right) / 2); i >= 1; i--)
	{
		if ((right % 2 == 0) && (i == right / 2))
		{
			maxSon = arraySorce[2 * i];
			maxNumber = 2 * i;
		}
		else
		{
			if (arraySorce[2 * i + 1] > arraySorce[2 * i])
			{
				maxSon = arraySorce[2 * i + 1];
				maxNumber = 2 * i + 1;
			}
			else
			{
				maxSon = arraySorce[2 * i];
				maxNumber = 2 * i;
			}
		}
		if (arraySorce[i] < maxSon)
		{
			int variable = arraySorce[i];
			arraySorce[i] = arraySorce[maxNumber];
			arraySorce[maxNumber] = variable;
		}
	}
	int variable = arraySorce[right];
	arraySorce[right] = arraySorce[1];
	arraySorce[1] = variable;
	if (right > 2) 
		sort(arraySorce, right - 1);
}