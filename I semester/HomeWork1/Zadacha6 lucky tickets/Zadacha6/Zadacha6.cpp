#include <iostream>

using namespace std;

int main()
{
	int arrayOfSums[28]; // Array with indexes, equal to the sum of the first three digits
	for (int i = 0; i <= 9; i++)
	{
		for (int j = 0; j <= 9; j++)
		{
			for (int k = 0; k <= 9; k++)
			{
				arrayOfSums[i + j + k]++; /* The value of the cells in the array is 
			                              equal orderly number of triple digits, 
										  giving a total index of the cell */
			}
		}
	}
	int numberOfLuckyTickets = 0;
	for (int i = 0; i < 14; i++) /* Number of sums of triples symmetrically
								 => consider half of all elements, i.e. 14 of 28 */
	{
		arrayOfSums[i] = arrayOfSums[i] * arrayOfSums[i]; /* Two threes => the number of combination 
														  for each amount of triple digits is equal 
														  to the square of the number of such triples */
		numberOfLuckyTickets = numberOfLuckyTickets + arrayOfSums[i]; /* The number of lucky tickets 
																	  is equal to the sum of all combinations 
																	  for all the sums of digits */
	}	
	numberOfLuckyTickets = numberOfLuckyTickets * 2; /*Will double the number of lucky tickets 
													due to the symmetry of the sums of digits 
													(0 = 1000 -0 ; 1 = 1000 - 1 etc.) */
	cout << "Number of Lucky tickets = " << numberOfLuckyTickets;
	return 0;
}