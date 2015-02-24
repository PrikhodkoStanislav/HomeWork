let isPalindrome string =
    let length = String.length string
    let rec check position =
        if (position = length / 2)
        then true
        elif (string.[position] = string.[length - position - 1])
        then check (position + 1)
        else
        false
    check 0

/// true
isPalindrome "ABBA"

/// false
isPalindrome "lololo"

/// false
isPalindrome "hello!"

/// true
isPalindrome "level"