let maxSum list =
    let rec sumFor list sum position result =
        match list with
        | head :: tail ->
            match tail with
            | headOfTail :: tailOfTail ->
                match tailOfTail with
                | h :: t -> 
                    if (head + h) > sum then
                        sumFor tail (head + h) (position + 1) position
                    else
                        sumFor tail sum (position + 1) result
                | [] ->
                    if (position >= 2) then
                        result
                    else 0
            | [] -> 0
        | [] -> 0
    sumFor list 0 1 0

// 0
maxSum []

// 0
maxSum [1]

// 0
maxSum [1; 2]

// 1
maxSum [1; 2; 3]

// 3
maxSum [1; 2; 3; 4; 5]