type Tree<'a> =
    | Tree of char * Tree<'a> * Tree<'a>
    | Tip of 'a

let parseTree tree = 
    let rec countParseTree tree =
        match tree with
        | Tree('+', l, r) -> countParseTree l + countParseTree r
        | Tree('-', l, r) -> countParseTree l - countParseTree r
        | Tree('*', l, r) -> countParseTree l * countParseTree r
        | Tree('/', l, r) -> if (countParseTree r = 0) then
                                 printfn("Error: division by zero!");
                                 0
                             else
                                 countParseTree l / countParseTree r
        | Tip x -> x
        | Tree(_, _, _) -> 0
    countParseTree tree

let tree = Tree('+', Tree('-', Tip(2), Tip (1)), Tree('*', Tip(2), Tree('/', Tip(3), Tip(1))))

parseTree tree