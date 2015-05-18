open System.Collections
open System.Collections.Generic

type BinaryTree<'a> =
    | Tree of 'a * BinaryTree<'a> * BinaryTree<'a>
    | Tip of 'a
    | Empty

type BinarySearchTree<'a when 'a : comparison>() =
    let mutable tree = Empty

    member v.Add value = 
        let rec add value subtree =
            match subtree with
            | Empty -> Tip value
            | Tip element ->
                if (element < value) then
                    Tree(element, Empty, Tip value)
                elif (element > value) then
                    Tree (element, Tip value, Empty)
                else
                    Tip element
            | Tree (element, left, right) ->
                if (element < value) then
                    Tree(element, left, add value right)
                elif (element > value) then
                    Tree (element, add value left, right)
                else
                    Tree (element, left, right)
        tree <- add value tree
    
    member v.Exist value =
        let rec exist value subtree =
            match subtree with
            | Empty -> false
            | Tip element -> element = value
            | Tree (element, left, right) ->
                if (value = element) then
                    true
                elif (value < element) then
                    exist value left
                else
                    exist value right
        exist value tree
    
    member v.Delete value =
        let rec findElementInSubtree subtree =
            match subtree with
            | Tip ele -> ele
            | Tree (ele, a, b) ->
                if (b = Empty) then
                    ele
                else
                    findElementInSubtree b
        let rec subtreeWithDeletedElement subtree =
            match subtree with
            | Tip ele -> Empty
            | Tree (ele, a, b) ->
                if (b = Empty) then
                    a
                else
                    Tree (ele, a, subtreeWithDeletedElement b)
            | Empty -> Empty     
        let rec delete value subtree =
            match subtree with
            | Empty -> Empty
            | Tip element -> if (element = value) then
                                 Empty
                             else
                                 subtree
            | Tree (element, left, right) ->
                if (value < element) then
                    Tree (element, delete value left, right)
                elif (value > element) then
                    Tree (element, left, delete value right)
                else
                    if not(left = Empty) then
                        match left with
                        | Tip el -> Tree (el, Empty, right)
                        | Tree (_, _, _) ->
                            Tree (findElementInSubtree left, subtreeWithDeletedElement left, right)
                        | Empty -> Empty
                    else
                        right
        let rec check subtree =
            match (subtree) with
            | Empty -> Empty
            | Tip element | Tree (element, Empty, Empty) -> Tip element
            | Tree (element, left, right) ->
                Tree (element, check left, check right)
        if (v.Exist value) then
            tree <- check (delete value tree)
        else
            printfn "Element %A is not in the tree!" value

    member v.TreeToList =
        let rec subtreeToList subtree =
            match subtree with
            | Empty -> []
            | Tip element -> [element]
            | Tree (element, left, right) ->
                 (subtreeToList left) @ [element] @ (subtreeToList right)
        subtreeToList tree

    interface IEnumerable with 
        member v.GetEnumerator() =
                let list = ref v.TreeToList
                { new IEnumerator with
                    member e.Current with get() = 
                         let current = (!list).Head :> obj 
                         list := (!list).Tail
                         current

                    member e.MoveNext() = 
                         match !list with
                         | [] ->
                            false
                         | _ -> 
                            true 
                    
                    member e.Reset() =
                        list := v.TreeToList  
                }

(*
1 2 3 4 5
false
1 2 4 5
Element 8 is not in the tree!
1 2 4 5 7
Для продолжения нажмите любую клавишу . . .
*)
let binaryTree = new BinarySearchTree<int>()
binaryTree.Add 3
binaryTree.Add 2
binaryTree.Add 1
binaryTree.Add 4
binaryTree.Add 5
for i in binaryTree do
    printf "%A " i
printfn ""
binaryTree.Delete 3
printfn "%A" (binaryTree.Exist 3)
for i in binaryTree do
    printf "%A " i
printfn ""
binaryTree.Delete 8
binaryTree.Add 7
for i in binaryTree do
    printf "%A " i
printfn ""