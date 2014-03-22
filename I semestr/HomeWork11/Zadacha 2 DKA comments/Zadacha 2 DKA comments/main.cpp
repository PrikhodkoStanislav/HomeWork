/*Tests:
/*
1)
/*dfsdfdsfd*/
/*sdfsdfsdf*/
/*sdfsdfsdfsdfsdfsdfsdfsdfsdfsdfsdfsdfsdsdfsdfdsf*s
dfsdfsdfsdf/sdfsdfsdf*/
//Для продолжения нажмите любую клавишу . . .
/*
2)
/*#include<iostream>usingnamespacestd;//Issymboldigit?boolisDigit(charsymbol){re
turn(static_cast<int>(symbol)>=static_cast<int>('0')&&static_cast<int>(symbol)<=
static_cast<int>('9'));}//Issequenceofsymbolsrealnumber?boolisRealNumber(char*b
uffer){intstate=-1;intposition=0;boolnext=true;boolend=false;while(next&&(positi
on<strlen(buffer))){switch(state){//startcase-1:if(isDigit(buffer[position])){st
ate=0;end=true;}elsenext=false;break;//digitcase0:if(isDigit(buffer[position])){
state=0;}else{if(buffer[position]=='.'){state=1;end=false;}else{if(buffer[positi
on]=='E'){state=3;end=false;}elsenext=false;}}break;//dotcase1:if(isDigit(buffer
[position])){state=2;end=true;}elsenext=false;break;//digitafterdotcase2:end=tru
e;if(isDigit(buffer[position])){state=2;}else{if(buffer[position]=='E'){state=3;
end=false;}elsenext=false;}break;//Ecase3:if(isDigit(buffer[position])){state=5;
end=true;}else{if(buffer[position]=='+'||buffer[position]=='-'){state=4;}elsenex
t=false;}break;//+/-case4:if(isDigit(buffer[position])){state=5;end=true;}elsene
xt=false;break;//digitafterEand+/-case5:if(isDigit(buffer[position])){state=5;}e
lsenext=false;break;}position++;}//iftheexitbythereasonofdifferenceschemesif(!ne
xt)end=false;returnend;}intmain(){cout<<"Inputsequenceofsymbols:\n";char*b
uffer=newchar[1000];cin>>buffer;if(isRealNumber(buffer))cout<<"Thisisrealnumber!
\n";elsecout<<"ThisisNOTrealnumber!\n";delete[]buffer;return0;}*/
//Для продолжения нажмите любую клавишу . . .
/*

3)
/*adsadasdasdasdasdasdasd/asdasdasdasd*a
sdasdaasdasdasdasd*/
/*as*/
//Для продолжения нажмите любую клавишу . . .
/*
*/

#include <iostream>
#include <fstream>

using namespace std;

const int numberOfColumns = 5;
const int numberOfStates = 4;

// finite-state machine (DKA) for symbol in the state
void dka(int &state, char symbol, int **stateTable)
{
	int tempState = 0;
	int tempElement = 0;
	while (stateTable[tempState][tempElement] != state)
	{
		tempState++;
	}
	tempElement++;
	if (stateTable[tempState][tempElement] == 1)
	{
		cout << symbol;
	}
	tempElement++;
	if (stateTable[tempState][tempElement] == 0)
		cout << "\n";
	if (symbol == '/')
		state = stateTable[tempState][tempElement];
	else
	{
		tempElement++;
		if (symbol == '*')
		{
			state = stateTable[tempState][tempElement];
			if (stateTable[tempState][tempElement] == 2)
				cout << "/" << symbol;
		}
		else
		{
			tempElement++;
			state = stateTable[tempState][tempElement];
		}
	}
}

int main()
{
	ifstream input("input.txt");
	char symbol = ' ';
	int state = 0;
	ifstream table("tableOfStates.txt");
	char variable = ' ';
	while (variable != '|')
	{
		table >> variable;
	}
	int **stateTable = new int*[numberOfStates];
	for (int i = 0; i < numberOfStates; i++)
	{
		stateTable[i] = new int[numberOfColumns];
	}
	for (int i = 0; i < numberOfStates; i++)
	{
		for (int j = 0; j < numberOfColumns; j++)
		{
			table >> stateTable[i][j];
		}
	}
	table.close();
	while (!input.eof())
	{
		input >> symbol;
		dka(state, symbol, stateTable);
	}
	input.close();
	for (int i = 0; i < numberOfStates; i++)
	{
		delete []stateTable[i];
	}
	delete []stateTable;
	return 0;
}