let swap x y =
    let temp = x
    x <- y
    y <- temp
    (x,y)

let mutable a = 1
let mutable b = 2

let (a', b') = swap a b
printf "a = %d, b = %d\n" a' b' // this will print a = 2, b = 2

let mutable c = 3
let mutable d = 4
let (c', d') = swap c d
printf "c = %d, d = %d\n" c' d' // this will print c = 4, d = 3

// The solution is to return a tuple containing the new values.
// This prevents the function from modifying the mutable variables in place.
// This makes the code more predictable and less prone to errors.