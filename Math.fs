module CS220.Quiz1.Math

open System

/// Modify the function `collatz` in such a way that the function takes in a
/// 32-bit integer, and returns the number of steps it takes to reach 1 in the
/// Collatz sequence.
let collatz n =
    let rec iter n step =

        if n = 1UL then step
        elif n % 2UL = 0UL then iter (n / 2UL) (step + 1)
        else iter (3UL * n + 1UL) (step + 1)

    let N = uint64 n
    iter N 0
