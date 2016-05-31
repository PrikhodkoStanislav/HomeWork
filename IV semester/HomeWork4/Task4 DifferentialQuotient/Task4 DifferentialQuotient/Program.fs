type Operation = char

type Expression =
    | Variable
    | Constant of double
    | FullExpression of Expression * Operation * Expression

let count x operation y =
    match operation with
    | '+' -> x + y
    | '-' -> x - y
    | '*' -> x * y
    | '/' -> x / y
    | _ -> 0.0

let rec simplify expression =
    match expression with
    | Constant _ -> expression
    | Variable -> expression
    | FullExpression (leftExpression, operation, rightExpression) ->
        let ls = simplify leftExpression
        let rs = simplify rightExpression
        match (ls, operation, rs) with
        | (Constant n1, op,  Constant n2) -> Constant (count n1 op n2)
        | (Constant 1.0, '*', x) | (x, '*', Constant 1.0) | (x, '/', Constant 1.0) -> x
        | (Constant 0.0, '*', _) | (_, '*', Constant 0.0) | (Constant 0.0, '/', _) -> Constant 0.0
        | (x, '+', Constant 0.0) | (Constant 0.0, '+', x) | (x, '-', Constant 0.0) -> x
        | _ -> FullExpression (ls, operation, rs)

let rec derivative expression =
    let exp = simplify expression
    match exp with
    | Constant _ -> Constant 0.0
    | Variable -> Constant 1.0
    | FullExpression (leftExpression, operation, rightExpression) ->
        match operation with
        | '+' | '-' -> FullExpression (derivative leftExpression, operation, derivative rightExpression)
        | '*' -> FullExpression (FullExpression (derivative leftExpression, '*', rightExpression), '+', FullExpression (leftExpression, '*', derivative rightExpression))
        | '/' -> FullExpression (FullExpression (FullExpression (derivative leftExpression, '*', rightExpression), '-', FullExpression (leftExpression, '*', derivative rightExpression)), '/', FullExpression (rightExpression, '*', rightExpression))
        | _ -> Constant 0.0



// x * 2
let expression = FullExpression (Variable, '*', Constant 2.0)

// Expression = FullExpression (FullExpression (Constant 1.0,'*',Constant 2.0),'+',FullExpression (Variable,'*',Constant 0.0))
derivative expression

// Expression = Constant 2.0
simplify (derivative expression)

//////////

// (x * 3) + (x / 2) - (1 * 2)
let expression2 = FullExpression (FullExpression (Variable, '*', Constant 3.0), '+', FullExpression (FullExpression (Variable, '/', Constant 2.0), '-', FullExpression (Constant 1.0, '*', Constant 2.0)))

(* Expression =
  FullExpression
    (FullExpression (Variable,'*',Constant 3.0),'+',
     FullExpression
       (FullExpression (Variable,'/',Constant 2.0),'-',Constant 2.0))
       *)
simplify expression2

(* Expression =
  FullExpression
    (FullExpression
       (FullExpression (Constant 1.0,'*',Constant 3.0),'+',
        FullExpression (Variable,'*',Constant 0.0)),'+',
     FullExpression
       (FullExpression
          (FullExpression
             (FullExpression (Constant 1.0,'*',Constant 2.0),'-',
              FullExpression (Variable,'*',Constant 0.0)),'/',
           FullExpression (Constant 2.0,'*',Constant 2.0)),'-',
        FullExpression
          (FullExpression (Constant 0.0,'*',Constant 2.0),'+',
           FullExpression (Constant 1.0,'*',Constant 0.0))))
           *)
derivative expression2

// Expression = Constant 3.5
simplify (derivative expression2)