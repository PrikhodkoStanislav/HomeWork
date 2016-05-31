let fib x =
    let rec func x a1 a2 =
        match x with
        | 0 -> a2
        | _ -> func (x - 1) (a1 + a2) a1
    in func x 1 0

let sumEvenFib =
    let rec func n sum =
        if ((fib n) > 1000000) then
            sum
        else
            if ((fib n) % 2 = 0) then
                func (n + 1) (sum + (fib n))
            else
                func (n + 1) (sum)
    in func 0 0

/// int = 1089154
sumEvenFib