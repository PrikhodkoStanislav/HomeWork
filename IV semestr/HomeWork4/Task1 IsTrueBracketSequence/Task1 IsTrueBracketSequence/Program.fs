let isTrueBracketSequence theString =
    let rec parseString theString index list =
        if (index < String.length theString) then
            let doCompare x =
                if List.head list = x then
                    parseString theString (index + 1) (List.tail list)
                else
                    false
            match (theString.[index]) with
            | '(' | '{' | '[' -> parseString theString (index + 1) (theString.[index] :: list)
            | ')' -> doCompare '('
            | '}' -> doCompare '{'
            | ']' -> doCompare '['
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