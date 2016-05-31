/*
Tests
1.""
hsdfhsdjkfhsdjk;sdfhjsdfhjk
sdfsdf

jkhljhjkhl;d
;shdjfkhsldjk
""
Comments:
;sdfhjsdfhjk
;d
;shdjfkhsldjk
Для продолжения нажмите любую клавишу . . .

2.""
ghjhgghjghgj;
sdfjklsdfjkl;sdfnsdfndjkl

   ;
sdfjsdjf;kjsdkl
			jkjkljsdfkljkfdj;dgfgdfgdgmcvmxc,v5
sdfjhsdjklfjkj'sdfsdf;sdf
""
Comments:
;
;sdfnsdfndjkl
;
;kjsdkl
;dgfgdfgdgmcvmxc,v5
;sdf
Для продолжения нажмите любую клавишу . . .

3.""
ololollololo
asdasjdhljs45687454132415
;asdljaskhdhasjkdhjk
nmnm,n,mn,
;
""
Comments:
;asdljaskhdhasjkdhjk
;
Для продолжения нажмите любую клавишу . . .
4.""
\



""
Comments:
No comments!Для продолжения нажмите любую клавишу . . .
5.""



;this programm working


""
Comments:
;this programm working
Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream input("input.txt");  // source file
	char element = ' ';  // readable element
	bool areThereAnyComments = false;  // check whether there are comments at all
	cout << "Comments:\n";
	while (!input.eof())  // while not end of file read the elements
	{
		while (input.get(element) && element != '\n')  // while not end of string
		{
			if (element == ';')  // start of comment
			{
				cout << element;  // write ";"
				areThereAnyComments = true;  // there is one comment at least
				while (input.get(element) && element != '\n')  // read all string after ";"
				{
					cout << element;  // write all comment
				}
				cout << "\n";
			}
		}
	}
	if (!areThereAnyComments)  // if not comment
		cout << "No comments!";
	input.close();
	return 0;
}