let multiOfDigit digit =
    if (digit = 0)
    then 0
    else
    let rec resultOfMultiplication digit result =
        if (digit = 0)
        then result
        elif (result = 0)
        then 0
        else
        resultOfMultiplication (digit / 10) (result * (digit % 10))
    resultOfMultiplication digit 1

let digitForExample = 512
let digit0 = 0
let digitWithMultiIs0 = 100000

/// 10
multiOfDigit digitForExample
/// 0
multiOfDigit digit0
/// 0
multiOfDigit digitWithMultiIs0