open System.Collections
open System.Collections.Generic

type BinaryTree<'a> =
    | Tree of 'a * BinaryTree<'a> * BinaryTree<'a>
    | Tip of 'a
    | Empty

type BinarySearchTree<'a>() =

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
                    Tree(element, Empty, add value right)
                elif (element > value) then
                    Tree (element, add value left, Empty)
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
        let rec delete value subtree =
            match subtree with
            | Empty -> Empty
            | Tip element -> Empty
            | Tree (element, left, right) ->
                if (value < element) then
                    Tree (element, delete value left, right)
                elif (value > element) then
                    Tree (element, left, delete value right)
                else
                    if not(left = Empty) then
                        match left with
                        | Tip el -> Tree (el, Empty, right)
                        | Tree (el, l, r) -> 
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
                            Tree (findElementInSubtree l, subtreeWithDeletedElement l, r)
                    else
                        right
        let rec check subtree =
            match (subtree) with
            | Empty -> Empty
            | Tip element -> Tip element
            | Tree (element, left, right) ->
                if ((right = Empty) && (left = Empty)) then
                    Tip element
                else
                    Tree (element, check left, check right)
        if (v.Exist value) then
            tree <- check (delete value tree)

    member v.treeToList =
        let rec subtreeToList subtree =
            match subtree with
            | Empty -> []
            | Tip element -> [element]
            | Tree (element, left, right) ->
                [element] @ (subtreeToList left) @ (subtreeToList right)
        subtreeToList tree

    interface IEnumerable<'a> with
        member v.GetEnumerator() =
            for i in v.treeToList
                yield i

    interface IEnumerable with
        member s.GetEnumerator () = (s :> IEnumerable<'a>).GetEnumerator() :> IEnumerator


let binaryTree = new BinarySearchTree<int>()
binaryTree.Add 3
binaryTree.Add 2
binaryTree.Add 1
binaryTree.Add 4
binaryTree.Add 5
for i in binaryTree do
    printfn "%d " i