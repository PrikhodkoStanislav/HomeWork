let unique list =
    let sortedList = List.sort list
    let rec seekRepeateElement list =
        match list with
        | [] -> true
        | h :: t ->
            match t with
            | [] -> true
            | head :: tail ->
                if (h = head) then
                    false
                else
                    seekRepeateElement t
    seekRepeateElement sortedList

// true
unique []

// true
unique [10; 11; 12]

// false
unique [10; 10; 11]