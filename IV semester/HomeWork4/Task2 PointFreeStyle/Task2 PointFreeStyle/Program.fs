let func x l = List.map (fun y -> y * x) l

let func'01 x = List.map (fun y -> y * x)

let func'02 x : int list -> int list = List.map (fun y -> y * x)

let func'03 x : int list -> int list = List.map ((*) x)

let func'04 : int -> (int list -> int list) = (*) >> List.map


// [5; 10; 15; 20; 25]
func 5 [1; 2; 3; 4; 5]

// [5; 10; 15; 20; 25]
func'01 5 [1; 2; 3; 4; 5]

// [5; 10; 15; 20; 25]
func'02 5 [1; 2; 3; 4; 5]

// [5; 10; 15; 20; 25]
func'03 5 [1; 2; 3; 4; 5]

// [5; 10; 15; 20; 25]
func'04 5 [1; 2; 3; 4; 5]