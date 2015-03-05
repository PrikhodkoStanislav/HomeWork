let numberOfEven1 list =
    let newList = List.filter (fun x -> x % 2 = 0) list
    List.length newList

let numberOfEven2 list =
    list |> List.map (fun x -> ((x % 2) + 1 ) % 2) |> List.fold (fun acc x -> acc + x) 0

let numberOfEven3 list =
    list |> List.fold (fun acc x -> (acc + 1) - (x % 2)) 0

// 5
numberOfEven [1; 2; 4; 8; 16; 32]

// 5
numberOfEven2 [1; 2; 4; 8; 16; 32]

// 5
numberOfEven3 [1; 2; 4; 8; 16; 32]