type OS = {name : string; probability : int}

type Computer(OSOfComputer : OS) =
    let random = new System.Random()
    let mutable infected = false
    member v.Infected = infected
    member v.TryToInfect =
        if (random.Next(1, 100) < OSOfComputer.probability) then
            infected <- true
            true
        else
            false

type Network(computers : Computer array, matrixOfConnection : bool array array) =
    let mutable computersNow = computers
    let mutable numberOfDirtyComputers = 0
    let dirtyComputers computersNow = 
        Array.fold (fun acc elem -> acc @ ([(elem : Computer).Infected])) [] computersNow |> List.toArray               
    member v.Infect =
        if (computers.[0].TryToInfect) then
            numberOfDirtyComputers <- numberOfDirtyComputers + 1
            printfn "Computer %d infected" 0
            while (numberOfDirtyComputers < computers.Length) do
                for i in 0 .. (Array.length computers - 1) do
                    if (computersNow.[i].Infected) then
                        for j in 0 .. (Array.length computers - 1) do
                            if (matrixOfConnection.[i].[j] && not(computersNow.[j].Infected)) then
                                if (computersNow.[j].TryToInfect) then
                                    numberOfDirtyComputers <- numberOfDirtyComputers + 1
                                    printfn "Computer %d infected by %d" j i
        else
            v.Infect
                            
                            
            
let listOfOS = [{name = "Windows"; probability = 50}; {name = "Linux"; probability = 30}; {name = "Mac"; probability = 70}]

let arrayOfComputers = [|new Computer(listOfOS.[0]); new Computer(listOfOS.[1]);
                        new Computer(listOfOS.[2])|]

let connectionMatrix = [|([|false; true; true|]); ([|true; false; false|]);
                        ([|true; false; false|])|]

let computerNetwork = new Network(arrayOfComputers, connectionMatrix)

(*
Computer 0 infected
Computer 2 infected by 0
Computer 1 infected by 0
Для продолжения нажмите любую клавишу . . .
*)
computerNetwork.Infect