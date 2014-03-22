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

4)
Countries:
Capital: 0
Cities:

Capital: 1
Cities: 2

Для продолжения нажмите любую клавишу . . .

5)
Countries:
Capital: 0
Cities:

Capital: 1
Cities: 2 3 4

Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>

using namespace std;

void makingCountries(int **arrayOfConnected, int **arrayOfCapitals, int *counterOfCountries, int numberOfCities, int numberOfCapitals)
{
	
	bool *arrayOfFreeCities = new bool[numberOfCities];
	for (int i = 0; i < numberOfCities; i++)
	{
		arrayOfFreeCities[i] = true;
	}
	for (int i = 0; i < numberOfCapitals; i++)
	{
		arrayOfFreeCities[arrayOfCapitals[i][0]] = false;
	}

	int indexOfCapital = 0;
	int var = 0;

	// run for the free cities and seek the shortest road
	while (var < (numberOfCities - numberOfCapitals))
	{
		bool isRoadNow = true;
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
			if (k == counterOfCountries[indexOfCapital])
			{
				k = 0;
				isRoadNow = false;
				break;
			}
		}
		if (!isRoadNow)
		{
			if (indexOfCapital < numberOfCapitals)
				indexOfCapital++;
			continue;
		}

		int minimumSize = arrayOfConnected[arrayOfCapitals[indexOfCapital][k]][temp];
		int city = temp;

		for (int p = 0; p < counterOfCountries[indexOfCapital]; p++)
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
		var++;
		if (indexOfCapital == (numberOfCapitals - 1))
			indexOfCapital = 0;
		else
			indexOfCapital++;
	}

	delete []arrayOfFreeCities;
}

void printAllCountrues(int **arrayOfCapitals, int numberOfCapitals, int *counterOfCountries)
{
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
	}
}

void deleteAllArrays(int **arrayOfConnected, int **arrayOfCapitals, int *counterOfCountries, int numberOfCapitals, int numberOfCities)
{
	delete []counterOfCountries;
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
}

void inputCities(ifstream &input, int numberOfRoads, int **arrayOfConnected)
{
	for (int i = 0; i < numberOfRoads; i++)
	{
		int city1 = 0;
		int city2 = 0;
		input >> city1;
		input >> city2;
		input >> arrayOfConnected[city1][city2];
		arrayOfConnected[city2][city1] = arrayOfConnected[city1][city2];
	}
}

void inputCapitals(ifstream &input, int numberOfCapitals, int **arrayOfCapitals)
{
	for (int i = 0; i < numberOfCapitals; i++)
	{
		input >> arrayOfCapitals[i][0];
	}
}

int inputNumber(ifstream &input)
{
	int element = 0;
	input >> element;
	return element;
}

int *newOneArray(int numberOfCapitals)
{
	int *counterOfCountries = new int[numberOfCapitals];
	for (int i = 0; i < numberOfCapitals; i++)
	{
		counterOfCountries[i] = 1;
	}
	return counterOfCountries;
}

int **newArray(int numberOfLines, int numberOfColumns)
{
	int **arrayOfConnected = new int*[numberOfLines];
	for (int i = 0; i < numberOfLines; i++)
	{
		arrayOfConnected[i] = new int[numberOfColumns];
	}
	for (int i = 0; i < numberOfLines; i++)
	{
		for (int j = 0; j < numberOfColumns; j++)
		{
			arrayOfConnected[i][j] = 0;
		}
	}
	return arrayOfConnected;
}

int main()
{
	ifstream input("cities.txt");

	int numberOfCities = inputNumber(input);
	int numberOfRoads = inputNumber(input);

	int **arrayOfConnected = newArray(numberOfCities, numberOfCities);

	inputCities(input, numberOfRoads, arrayOfConnected);

	int numberOfCapitals = inputNumber(input);

	int **arrayOfCapitals = newArray(numberOfCapitals, numberOfCities);

	inputCapitals(input, numberOfCapitals, arrayOfCapitals);

	input.close();

	int *counterOfCountries = newOneArray(numberOfCapitals);

	makingCountries(arrayOfConnected, arrayOfCapitals, counterOfCountries, numberOfCities, numberOfCapitals);

	printAllCountrues(arrayOfCapitals, numberOfCapitals, counterOfCountries);

	deleteAllArrays(arrayOfConnected, arrayOfCapitals, counterOfCountries, numberOfCapitals, numberOfCities);

	return 0;
}