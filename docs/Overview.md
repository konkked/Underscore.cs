# Module Overview

## Delegate (Func & Action) Shared Components

***The implementations are in separate locations but functionality is same in both ``` _.Action``` and ```_.Function```***

Bind - takes a parameter and an action,
and returns an action that takes no parameters,
bound to the passed parameters.

Partial - Takes a parameter and an action,
and returns an action that is partially bound
to the passed parameters and takes the remaining
parameters.

Compose - Contains Methods that compose actions,
including some of the classic js methods like
apply.

Convert - Allows Delegates to be switched to their counterparts
Func => Action and Action => Func, while the result isn't meaningful
(Action => Func conversions only return null), it can be useful
for reusing methods made for actions or vice-a-versa.

Split - Allows the splitting up of actions and functions into smaller chunks.
Contains two methods, Split and Curry, split halves the function into a function
taking the half of the parameters and returns a function that takes the remaining
half, splay splits a chain of functions that return functions.

Synch - Contains methods focused on call control.
Includes methods such as Throttle and Debounce.

## Function

Cache - This is the only Func specific component.
It contains memoize which will take a function call and if the passed
parameters have already been called then it will not execute the function
and return the value obtained before.


## List

***All methods in module can also be called as extension methods using Underscore.Extensions***

Manipulate - Contains methods that manipulate the state of a list or return samples from a list's state, such as Swap, Shuffle and Rotate

Partition - Contains methods which split a list into multiple parts, such as Chunk, Split and Partition.


## Collection

***All methods in module can also be called as extension methods using Underscore.Extensions***

Creation - Contains Snapshot method which creates a method that will always return the enumerable
as it was at the time it was passed.

Partition- Contains Chunk and Partition for now.

## Object

Contains reflection methods to work with the most common cases for use (will be adding the Attribute
section to it soon, next thing I am planning on doing).

The method reflection object contains a query method that allows for the easy querying of a method
by types and names of the parameters.

## Utility

Contains the functionality I couldn't quite pin into a section easily, such as Random.
