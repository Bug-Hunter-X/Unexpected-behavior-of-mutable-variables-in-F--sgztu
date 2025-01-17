let mutable x = 10
let mutable y = 20

let add x y = 
    x + y

let inline swap x y =
    let temp = x
    x <- y
    y <- temp

let mutable a = 1
let mutable b = 2

swap a b
printf "a = %d, b = %d\n" a b // this will print a = 2, b = 2

// However, if we try to use this function in a different way, it will not work as expected.
let mutable c = 3
let mutable d = 4
let result = add c d
printf "%d\n" result // this will print 7

swap c d
printf "c = %d, d = %d\n" c d // this will print c = 4, d = 3

// The problem is that the swap function modifies the mutable variables in place.
// This can lead to unexpected behavior if the mutable variables are used in other parts of the code.
// To avoid this problem, it is best to avoid using mutable variables whenever possible.
// If you must use mutable variables, then make sure that they are only modified within the scope of the function that uses them.