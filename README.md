# F# Mutable Variable Bug

This repository demonstrates an uncommon bug in F# related to the unexpected behavior of mutable variables when used within functions that modify them in place. The issue arises when a function modifies mutable variables passed as arguments, potentially leading to unexpected side effects in other parts of the code if those variables are used elsewhere.

## Bug Description
The `swap` function, designed to exchange the values of two mutable variables, works correctly in isolation. However, its behavior becomes unpredictable when combined with other operations, particularly if the same mutable variables are involved in subsequent calculations.

## Solution
The solution involves understanding the implications of in-place modifications of mutable variables. While sometimes necessary, it's often more robust and predictable to avoid mutable variables where feasible. If their use is unavoidable, careful scoping and avoiding unintended side effects are critical.  The provided solution demonstrates an alternative approach where the `swap` function returns a tuple containing the new values, thereby preventing unintentional side effects.

## Files
* `bug.fs`: Demonstrates the buggy code.
* `bugSolution.fs`: Provides a corrected version.