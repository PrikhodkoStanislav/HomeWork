let isPrimeNumber n = not ( (Seq.exists (fun x -> n % x = 0) ) {2 .. n / 2 } )

let generateInfiniteSequenceOfPrimeNumbers =
     Seq.filter isPrimeNumber (Seq.initInfinite( fun i -> i + 2))

printfn "%A" generateInfiniteSequenceOfPrimeNumbers