(*
 0 - Exit
 1 - Add name and phone number
 2 - Find phone number by name
 3 - Find name by phone number
 4 - Save data in file
 5 - Read data from file

5
 0 - Exit
 1 - Add name and phone number
 2 - Find phone number by name
 3 - Find name by phone number
 4 - Save data in file
 5 - Read data from file

3
Input phone number
12345
Name
Stas
 0 - Exit
 1 - Add name and phone number
 2 - Find phone number by name
 3 - Find name by phone number
 4 - Save data in file
 5 - Read data from file

3
Input phone number
12345
Name
Stas
 0 - Exit
 1 - Add name and phone number
 2 - Find phone number by name
 3 - Find name by phone number
 4 - Save data in file
 5 - Read data from file

2
Input name
Stas
Phone number
12345
 0 - Exit
 1 - Add name and phone number
 2 - Find phone number by name
 3 - Find name by phone number
 4 - Save data in file
 5 - Read data from file

0
Exit
Для продолжения нажмите любую клавишу . . .


*)

let findElementInBook (list : (string * string) list) funcForParameter parameter =
    List.fold (fun alternative (pair : string * string) ->
        if (funcForParameter pair = parameter) then
            pair
        else
            alternative)
            ("No elements with this parameter!", "No elements with this parameter!") list 

let phoneNumber =
    let rec interfaceOfProgram listNameAndPhoneNumber =
        printfn "%s" " 0 - Exit \n 1 - Add name and phone number \n 2 - Find phone number by name"
        printfn "%s" " 3 - Find name by phone number \n 4 - Save data in file \n 5 - Read data from file \n"
        let n = System.Int32.Parse(System.Console.ReadLine())
        match n with
        | 0 -> printfn "%s" "Exit"
        | 1 -> printfn "%s" "Input name"
               let newName = System.Console.ReadLine()
               printfn "%s" "Input phone number"
               let newNumber = System.Console.ReadLine()
               interfaceOfProgram ((newName, newNumber) :: listNameAndPhoneNumber)
        | 2 -> printfn "%s" "Input name"
               let name = System.Console.ReadLine()
               printfn "%s" "Phone number"
               printfn "%s" ((fun (x, y) -> y) (findElementInBook listNameAndPhoneNumber (fun (x, y) -> x) name))
               interfaceOfProgram listNameAndPhoneNumber
        | 3 -> printfn "%s" "Input phone number"
               let number = System.Console.ReadLine()
               printfn "%s" "Name"
               printfn "%s" ((fun (x, y) -> x) (findElementInBook listNameAndPhoneNumber (fun (x, y) -> y) number))
               interfaceOfProgram listNameAndPhoneNumber
        | 4 -> System.IO.File.AppendAllLines(@"phoneBook.txt", listNameAndPhoneNumber |> List.fold(fun acc (x, y) -> y :: x :: acc) [] |> List.rev)
               interfaceOfProgram listNameAndPhoneNumber
        | 5 -> if not(System.IO.File.Exists(@"phoneBook.txt")) then
                   printfn "%s" "File is not created!"
                   interfaceOfProgram listNameAndPhoneNumber
               else
                   let listFromFile = System.IO.File.ReadLines(@"phoneBook.txt") |> Seq.toList
                   let createListFromFile list =
                       let rec createList list acc =
                           match list with
                           | [] -> acc
                           | head :: headOfTail :: tail -> createList tail ( (head, headOfTail) :: acc)
                           | _ -> printfn "Error with data in file!"
                                  []
                       createList list []
                   interfaceOfProgram ( (createListFromFile listFromFile) @ listNameAndPhoneNumber)
        | _ -> interfaceOfProgram listNameAndPhoneNumber
    interfaceOfProgram []