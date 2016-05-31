type Tree<'a> =
    | Tree of 'a * Tree<'a> * Tree<'a>
    | Tip of 'a

let rec height tree =
    match tree with
    | Tree (_, left, right) -> 1 + max (height left) (height right)
    | Tip _ -> 1