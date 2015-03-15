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

let phoneNumber =
    let rec func listNameAndPhoneNumber =
        printfn "%s" " 0 - Exit \n 1 - Add name and phone number \n 2 - Find phone number by name"
        printfn "%s" " 3 - Find name by phone number \n 4 - Save data in file \n 5 - Read data from file \n"
        let n = System.Int32.Parse(System.Console.ReadLine())
        match n with
        | 0 -> printfn "%s" "Exit"
        | 1 -> printfn "%s" "Input name"
               let newName = System.Console.ReadLine()
               printfn "%s" "Input phone number"
               let newNumber = System.Console.ReadLine()
               func ((newName, newNumber) :: listNameAndPhoneNumber)
        | 2 -> printfn "%s" "Input name"
               let name = System.Console.ReadLine()
               printfn "%s" "Phone number"
               let findNumder list name =
                   List.fold (fun find (x, y) -> if (x = name) then y else find) "No number with this name!" list
               printfn "%s" (findNumder listNameAndPhoneNumber name)
               func listNameAndPhoneNumber
        | 3 -> printfn "%s" "Input phone number"
               let number = System.Console.ReadLine()
               printfn "%s" "Name"
               let findName list number =
                   List.fold (fun find (x, y) -> if (y = number) then x else find) "No name with this phone number!" list
               printfn "%s" (findName listNameAndPhoneNumber number)
               func listNameAndPhoneNumber
        | 4 -> System.IO.File.AppendAllLines(@"phoneBook.txt", listNameAndPhoneNumber |> List.fold(fun acc (x, y) -> y :: x :: acc) [] |> List.rev)
               func listNameAndPhoneNumber
        | 5 -> let listFromFile = System.IO.File.ReadLines(@"phoneBook.txt") |> Seq.toList
               let createListFromFile list =
                   let rec func list acc =
                       match list with
                       | [] -> acc
                       | head :: headOfTail :: tail -> func tail ( (head, headOfTail) :: acc)
                       | _ -> printfn "Error with data in file!"
                              []
                   func list []
               func ( (createListFromFile listFromFile) @ listNameAndPhoneNumber)
        | _ -> func listNameAndPhoneNumber
    func []