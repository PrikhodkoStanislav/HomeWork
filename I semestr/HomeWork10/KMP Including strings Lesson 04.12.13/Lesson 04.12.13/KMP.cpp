/*Tests:
Input substring:
a
First occurrence of the substring = 0
Для продолжения нажмите любую клавишу . . .

Input substring:
ba
First occurrence of the substring = 5
Для продолжения нажмите любую клавишу . . .

Input substring:
q
The substring is not included in the original string!
Для продолжения нажмите любую клавишу . . .

Input substring:
gcx
First occurrence of the substring = 10
Для продолжения нажмите любую клавишу . . .

Input substring:
okv
First occurrence of the substring = 17
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>

using namespace std;

// populating a table of prefix functions
void prefix(char *string, int *table)
{
	int position = 2;
	int index = 0;
	table[0] = -1;
	table[1] = 0;
	while (position < strlen(string))
	{
		// the substring continues including in the string
		if (table[position - 1] == table[index])
		{
			index++;
			table[position] = index;
			position++;
		}
		else
		{
			// it doesn't, but we can fall back
			if (index > 0)
			{
				index = table[index];
			}
			else
			{
				// we have run out of candidates
				table[position] = 0;
				position++;
			}
		}
	}
}

// Knuth-Morris-Pratt algorithm
int kMP(char *sourceString, char *substring)
{
	int *table = new int[2001];
	prefix(sourceString, table);
	int indexSourceString = 0;
	int indexSubstring = 0;
	// running on strings
	while (indexSourceString + indexSubstring < strlen(sourceString))
	{
		// including continue
		if (substring[indexSubstring] == sourceString[indexSourceString + indexSubstring])
		{
			// substring includes in the string
			if (indexSubstring == (strlen(substring) - 1))
			{
				delete []table;
				return indexSourceString;
			}
			indexSubstring++;
		}
		else
		{
			// jumping on the string
			indexSourceString = indexSourceString + indexSubstring - table[indexSubstring];
			// jump on the index of the element
			if (table[indexSubstring] > -1)
			{
				indexSubstring = table[indexSubstring];
			}
			// index on the first element
			else
			{
				indexSubstring = 0;
			}
		}
	}
	delete []table;
	return -1;
}

int main()
{
	ifstream input("string.txt");
	char *buffer = new char[1000];
	input >> buffer;
	char *substring = new char[1000];
	cout << "Input substring:\n";
	cin >> substring;
	int result = kMP(buffer, substring);
	if (result >= 0)
		cout << "First occurrence of the substring = " << result << endl;
	else
		cout << "The substring is not included in the original string!\n";
	input.close();
	delete []substring;
	delete []buffer;
	return 0;
}