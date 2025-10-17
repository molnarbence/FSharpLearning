// F# Learning Console Application
// This application demonstrates various F# concepts for learning and practice

// 1. Basic printing and string formatting
printfn "=== Welcome to F# Learning ==="
printfn "Hello from F#!"
printfn ""

// 2. Variables and type inference
let name = "F# Developer"
let age = 10
let isAwesome = true
printfn "My name is %s, I am %d years old, and F# is awesome: %b" name age isAwesome
printfn ""

// 3. Functions
let add x y = x + y
let multiply x y = x * y
printfn "=== Functions ==="
printfn "5 + 3 = %d" (add 5 3)
printfn "5 * 3 = %d" (multiply 5 3)
printfn ""

// 4. Lists and list operations
let numbers = [1; 2; 3; 4; 5]
let doubled = numbers |> List.map (fun x -> x * 2)
let sum = numbers |> List.sum
printfn "=== Lists ==="
printfn "Original list: %A" numbers
printfn "Doubled list: %A" doubled
printfn "Sum of numbers: %d" sum
printfn ""

// 5. Pattern matching
let describeNumber n =
    match n with
    | 0 -> "zero"
    | 1 -> "one"
    | 2 -> "two"
    | x when x > 2 && x <= 10 -> "between three and ten"
    | _ -> "larger than ten"

printfn "=== Pattern Matching ==="
printfn "The number 0 is: %s" (describeNumber 0)
printfn "The number 5 is: %s" (describeNumber 5)
printfn "The number 100 is: %s" (describeNumber 100)
printfn ""

// 6. Records
type Person = {
    Name: string
    Age: int
    City: string
}

let person = { Name = "Alice"; Age = 30; City = "New York" }
printfn "=== Records ==="
printfn "Person: %s, Age: %d, City: %s" person.Name person.Age person.City
printfn ""

// 7. Options
let tryDivide x y =
    if y = 0 then None
    else Some (x / y)

printfn "=== Options ==="
match tryDivide 10 2 with
| Some result -> printfn "10 / 2 = %d" result
| None -> printfn "Cannot divide by zero"

match tryDivide 10 0 with
| Some result -> printfn "10 / 0 = %d" result
| None -> printfn "Cannot divide by zero"
printfn ""

// 8. Discriminated Unions
type Shape =
    | Circle of radius: float
    | Rectangle of width: float * height: float
    | Triangle of base_: float * height: float

let calculateArea shape =
    match shape with
    | Circle radius -> System.Math.PI * radius * radius
    | Rectangle (width, height) -> width * height
    | Triangle (base_, height) -> 0.5 * base_ * height

printfn "=== Discriminated Unions ==="
let circle = Circle 5.0
let rectangle = Rectangle (4.0, 6.0)
printfn "Circle area: %.2f" (calculateArea circle)
printfn "Rectangle area: %.2f" (calculateArea rectangle)
printfn ""

// 9. Piping and composition
let square x = x * x
let addTen x = x + 10
let result = 5 |> square |> addTen
printfn "=== Piping ==="
printfn "5 |> square |> addTen = %d" result
printfn ""

// 10. Sequences (lazy evaluation)
let evenNumbers = seq { 0 .. 2 .. 20 }
printfn "=== Sequences ==="
printfn "Even numbers from 0 to 20: %A" (evenNumbers |> Seq.toList)
printfn ""

printfn "=== End of F# Learning Examples ==="
