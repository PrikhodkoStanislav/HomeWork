let compareElementWithTheHeadOfList element list =
    List.head list = element

let isTrueBracketSequence theString =
    let rec parseString theString index list =
        if (index < String.length theString) then
            match (theString.[index]) with
            | '(' | '{' | '[' -> parseString theString (index + 1) (theString.[index] :: list)
            | ')' -> if (compareElementWithTheHeadOfList '(' list) then
                         parseString theString (index + 1) (List.tail list)
                     else
                         false
            | '}' -> if (compareElementWithTheHeadOfList '{' list) then
                         parseString theString (index + 1) (List.tail list)
                     else
                         false
            | ']' -> if (compareElementWithTheHeadOfList '[' list) then
                         parseString theString (index + 1) (List.tail list)
                     else
                         false
            | _ -> parseString theString (index + 1) list
        else
            list = []
    parseString theString 0 []

// true
isTrueBracketSequence "{sddsfdf}"

// false
isTrueBracketSequence "{[sdd(sdsdfsdf]sdfsdf)sfdf}"

// true
isTrueBracketSequence "ololo[({([sdfdfsfsdfsdf(sf)sfsfsd[sf]sdf]sdfsdfsdf)sdfsd(s)qq}sfsd)sdfsfsdfsd[sf[sdf]sdf]sdf]qw"