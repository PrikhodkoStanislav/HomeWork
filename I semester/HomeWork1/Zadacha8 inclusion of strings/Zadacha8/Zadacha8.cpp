#include <iostream>

using namespace std;

int main()
{
	cout << "Input main string\n";
	char string1[50];
	gets(string1);
	cout << "Input substring\n";
	char substring1[10];
	gets(substring1);
	int i = 0;
	int j = 0;
	int numberOfOccurrences = 0;
	bool firstElement = true;
	int start = 0;
	while (i < strlen(string1))
	{
		if (string1[i] == substring1[j])
		{
			j++;
			if (firstElement)
			{
				start = i;
				firstElement = false;
			}
		}
		else
			j = 0;
		if (j == strlen(substring1))
		{
			numberOfOccurrences++;
			j = 0;
			i = start;
			firstElement = true;
		}
		i++;
	}
	cout << "Number of occurrences = " << numberOfOccurrences;
	return 0;
}