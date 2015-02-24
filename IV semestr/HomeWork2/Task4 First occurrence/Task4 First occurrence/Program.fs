let firstOccurrence list element =
    let rec seekElement theList theElement position =
        match theList with
        | head :: tail ->
            if (head = theElement)
            then position
            else
            seekElement tail theElement (position + 1)
        | [] -> 0
    seekElement list element 1

/// 5
firstOccurrence [1; 2; 3; 4; 5] 5

/// 0
firstOccurrence [2; 4; 8] 7