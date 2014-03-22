/*Tests:

1."file.in":
""
8sdf
	
c
dsfg
dggghxcb
sdf




sdfsdfsdfdsf		 
   
 
sdfsdfsdf

""
Number of non-empty string = 7Для продолжения нажмите любую клавишу . . .

2."file.in":
""
				
    
		
    	


 	 	

worknumber4
asdasdasd
adidas 


""
Number of non-empty string = 3Для продолжения нажмите любую клавишу . . .

3. "file.in":
""
 jdshfjsdhfkjs 		
sdhfjsdhfkjdsh


sdfsdfsdfsdfvds
qll;fl;cmngiuvlb,b7484555

			
jhkfdjjhjkdfhgjkdf555
""
Number of non-empty string = 5Для продолжения нажмите любую клавишу . . .
*/
#include <iostream>
#include <fstream>

using namespace std;

int main()
{
	ifstream input("file.in");
	char element = ' ';
	bool checkTheLineOnEmptiness = false;
	int numberOfNonEmptyString = 0;
	while (!input.eof())
	{
		checkTheLineOnEmptiness = false;
		while (input.get(element) && element != '\n')
		{
			if (element != ' ' && element != '\t' && element != '\n')
			{
				checkTheLineOnEmptiness = true;
				while (!input.eof() && element != '\n')
					input.get(element);
			}
			if (element == '\n')
				break;
		}
		if (checkTheLineOnEmptiness)
			++numberOfNonEmptyString;
	}
	cout << "Number of non-empty string = " << numberOfNonEmptyString;
	input.close();
	return 0;
}