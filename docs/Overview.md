# Module Overview

## Delegate (Func & Action) Shared Components

***The implementations are in separate locations but functionality is same in both ``` _.Action``` and ```_.Function```***

Bind - takes a parameter and an action,
and returns an action that takes no parameters,
bound to the passed parameters.

Partial- Takes a parameter and an action,
and returns an action that is partially bound
to the passed parameters and takes the remaining
parameters.

Compose- Contains Methods that compose actions,
including some of the classic js methods like
call and apply.

Convert - Allows Delegates to be switched to their counterparts
Func => Action and Action => Func, while the result isn't meaningful
( Action => Func conversions only return null ) possibly could be useful
for reusing methods made for actions or vice-a-versa.

Split - Allows the splitting up of actions and functions into smaller chunks.
Contains two methods, Split and Splay, split halves the function into a function
taking the half of the parameters and returns a function that takes the remaining
half, splay splits a chain of functions that return functions.

Synch - Includes functionality like Throttle and Debounce,
also has methods that control the number of times something is done
and other call control functionality.

## Function

Cache - This is the only Func specific component, currently only
contains memoize which will take a function call and if the passed
parameters have already been called then it will not execute the function
and return the value obtained before.


## List

Delegate - Contains two methods: delegate, which wraps elements into a list of functions,
and resolve, which resolves a list of functions into a list of elements.

Manipulate - Includes methods like swap, shuffle, and rotate that swap an element in a list,
create a shuffled version of the list (or shuffles in place), and returns a random sample
from the list respectively.

Partition - Contains Chunk, Partition, Slice, and Split. Chunk breaks a collection into smaller chunks
partition splits the collection into two parts, Split into two equal parts, slice takes a rotating
and reversible slice of a list (looking at the unit test would probably give you the best
idea about the functionality).


## Collection

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
