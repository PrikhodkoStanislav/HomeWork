/*Tests:
1)
Countries:
Capital: 0
Cities: 1 2

Для продолжения нажмите любую клавишу . . .

2)
Countries:
Capital: 0
Cities: 2 1 4 3

Для продолжения нажмите любую клавишу . . .

3)
Countries:
Capital: 0
Cities: 1 2

Capital: 4
Cities: 3

Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream input("cities.txt");
	int numberOfCities = 0;
	int numberOfRoads = 0;
	input >> numberOfCities;
	input >> numberOfRoads;
	int **arrayOfConnected = new int*[numberOfCities];
	for (int i = 0; i < numberOfCities; i++)
	{
		arrayOfConnected[i] = new int[numberOfCities];
	}
	for (int i = 0; i < numberOfCities; i++)
	{
		for (int j = 0; j < numberOfCities; j++)
		{
			arrayOfConnected[i][j] = 0;
		}
	}
	for (int i = 0; i < numberOfRoads; i++)
	{
		int city1 = 0;
		int city2 = 0;
		input >> city1;
		input >> city2;
		input >> arrayOfConnected[city1][city2];
		arrayOfConnected[city2][city1] = arrayOfConnected[city1][city2];
	}
	int numberOfCapitals = 0;
	input  >> numberOfCapitals;
	int **arrayOfCapitals = new int*[numberOfCapitals];
	for (int i = 0; i < numberOfCities; i++)
	{
		arrayOfCapitals[i] = new int[numberOfCities];
	}
	for (int i = 0; i < numberOfCapitals; i++)
	{
		input >> arrayOfCapitals[i][0];
	}
	bool *arrayOfFreeCities = new bool[numberOfCities];
	for (int i = 0; i < numberOfCities; i++)
	{
		arrayOfFreeCities[i] = true;
	}
	for (int i = 0; i < numberOfCapitals; i++)
	{
		arrayOfFreeCities[arrayOfCapitals[i][0]] = false;
	}
	int *counterOfCountries = new int[numberOfCapitals];
	for (int i = 0; i < numberOfCapitals; i++)
	{
		counterOfCountries[i] = 1;
	}
	int indexOfCapital = 0;
	for (int var = 0; var < (numberOfCities - numberOfCapitals); var++)
	{
		int temp = 0;
		int k = 0;
		while (arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][temp] == 0 || !arrayOfFreeCities[temp])
		{
			temp++;
			if (temp == numberOfCities)
			{
				temp = 0;
				k++;
			}
		}
		int minimumSize = arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][temp];
		int city = temp;
		for (int k = 0; k < counterOfCountries[indexOfCapital]; k++)
		{
			for (int i = temp + 1; i < numberOfCities; i++)
			{
				if (arrayOfFreeCities[i] && arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][i] != 0 && arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][i] < minimumSize)
				{
					minimumSize = arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][i];
					city = i;
				}
			}
		}
		arrayOfFreeCities[city] = false;
		arrayOfCapitals[indexOfCapital][counterOfCountries[indexOfCapital]] = city;
		counterOfCountries[indexOfCapital]++;
		if (indexOfCapital == (numberOfCapitals - 1))
			indexOfCapital = 0;
		else
			indexOfCapital++;
	}
	cout << "Countries:\n";
	for (int i = 0; i < numberOfCapitals; i++)
	{
		cout << "Capital: " << arrayOfCapitals[i][0] << endl;
		cout << "Cities: ";
		for (int k = 1; k < counterOfCountries[i]; k++)
		{
			cout << arrayOfCapitals[i][k] << " ";
		}
		cout << "\n\n";
	delete []counterOfCountries;
	}
	delete []arrayOfFreeCities;
	for (int i = 0; i < numberOfCapitals; i++)
	{
		delete []arrayOfCapitals[i];
	}
	delete []arrayOfCapitals;
	for (int i = 0; i < numberOfCities; i++)
	{
		delete []arrayOfConnected[i];
	}
	delete []arrayOfConnected;
	input.close();
	return 0;
}