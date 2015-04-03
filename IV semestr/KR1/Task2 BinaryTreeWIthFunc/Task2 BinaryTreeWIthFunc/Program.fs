type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a


let filterTree func tree =
    let rec funcForElementOfTree func tree =
        match tree with
        | Tip x -> if (func x) then
                       printfn "%A" x
        | Tree(x, l, r) -> if (func x) then
                               printfn "%A" x
                           funcForElementOfTree func l
                           funcForElementOfTree func r
    funcForElementOfTree func tree


filterTree (fun x -> (x % 2) = 0) (Tree (2, Tip 1, Tip 4))