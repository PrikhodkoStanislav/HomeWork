let number = 5
// Formula for factorial of x.
let rec factorial x = if x = 0 then 1 else x * factorial (x - 1)
System.Console.WriteLine(factorial number)
