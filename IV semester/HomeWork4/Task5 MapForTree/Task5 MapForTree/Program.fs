type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a


let mapTree func tree =
    let rec funcForElementOfTree func tree =
        match tree with
        | Tip x -> Tip (func x)
        | Tree(x, l, r) -> Tree(func x, funcForElementOfTree func l, funcForElementOfTree func r)
    funcForElementOfTree func tree

// Tree (1,Tree (4,Tip 9,Tip 16),Tree (25,Tip 36,Tip 49))
mapTree (fun x -> x * x) (Tree(1, Tree(2, Tip 3, Tip 4), Tree(5, Tip 6, Tip 7)))