let reverse list =
    let rec reversion lst result = 
        match lst with
        | head :: tail ->
            let theResult = head :: result
            reversion tail theResult
        | [] -> result
    reversion list []

let listForExample = [1; 2; 3]

/// [3; 2; 1]
reverse listForExample