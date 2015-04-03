type QueueWithPriority (query : list<'a>, length : int) =
    member q.Length = length
    member q.Elements = query
    member q.Push(element, priority) = QueueWithPriority((element, priority) :: q.Elements, q.Length + 1)
//    member q.Pop() = if (q.Length = 0) then
//                         printfn "%s" "Error!"
//                     else
//                         

let q = QueueWithPriority([], 0)
