let fivePoweredOfTwo startPower = 
    let rec generateList basis count startPower =
        let rec pow element power =
            if (power = 1)
            then element
            else
            pow (element * basis) (power - 1)
        let rec func element basis count =
            if (count = 0)
            then []
            else
            element :: func (element * basis) basis (count - 1)
        func (pow basis startPower) basis count
    generateList 2 5 startPower

/// [32; 64; 128; 256; 512]
fivePoweredOfTwo 5

