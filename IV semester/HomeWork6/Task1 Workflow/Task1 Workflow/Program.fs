type rounding (exactitude : int) =
    member this.Bind (x : float, rest : float -> float) =
        rest (System.Math.Round (x, exactitude))
    member this.Return (x : float) =
        System.Math.Round (x, exactitude)
    

// float = 0.048
let roundingOperations = 
    rounding 3 {
        let! a = 2.0 / 12.0
        let! b = 3.5
        return a / b
    }