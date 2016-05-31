exception ExceptionEmptyQueue of string

let getFirst (a, b) = a
let getSecond (a, b) = b

type QueueWithPriority (query : list<('a * int)>) =
    let mutable elements = query
    member q.Push(element, priority) =
        let rec exist x list =
            match list with
            | (h : ('a * int)) :: t -> if (not(h = x)) then exist x t
            | _ -> let rec sort list prefix x =
                       match list with
                       | h :: t -> if ((getSecond h) >= (getSecond x)) then
                                       sort t (prefix @ [h]) x
                                    else
                                       elements <- prefix @ [x] @ list
                       | _ -> elements <- prefix @ [x]
                   sort elements [] (element, priority)
        exist (element, priority) elements
    member q.Pop = match elements with
                   | (h : ('a * int)) :: t -> elements <- t
                                              getFirst h           
                   | _ -> raise(ExceptionEmptyQueue "Empty queue!")

let queueOperations (q : QueueWithPriority) = 
    try
        printfn "%A" q.Pop
    with
        | ExceptionEmptyQueue(string) -> printfn "Exception %s" string

let q = QueueWithPriority([])
q.Push(1, 3)
q.Push(2, 2)
q.Push(3, 10)
q.Push(4, 1)
q.Push(5, 5)

// 3
queueOperations q
// 5
queueOperations q
// 1
queueOperations q
// 2
queueOperations q
// 4
queueOperations q
// Exception Empty queue!
queueOperations q