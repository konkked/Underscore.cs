# Action.Split

***All methods in this section are called from _.Action***

- [Split](#split)
- [Curry](#curry)
- [Uncurry](#uncurry)

## Split

### Func\<T0, Action\<T1\>\> Split\<T0, T1\>(Action\<T0, T1\> action)
Halves the passed action as a function that returns action that can invoke the passed action. Works for Actions with any even parameter count up to 16.
```csharp
Action<int, int, int, int> action = (a, b, c, d) => Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);

var splitAction = _.Action.Split(action);

splitAction(1, 2)(3, 4); // prints "1 2 3 4"
```

## Curry

### Func\<T0, Action\<T1\>\> Curry\<T0, T1\>(Action\<T0, T1\> action)
Returns a function which takes a chain of function calls to use as arguments for action (see examples). Can be called with Actions that have up to 16 parameters.
```csharp
// with an action with a few parameters
Action<int, int> smallAction = (a, b) => Console.WriteLine("{0} {1}", a, b);
var smallCurriedAction = _.Curry(smallAction);

smallCurriedAction(1)(2); // prints "1 2"

// with an action with a lot of parameters
Action<int, int, int, int, int, int, int, int, int, int> bigAction = (a, b, c, d, e, f, g, h, i, j) => Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", a, b, c, d, e, f, g, h, i, j);

var bigCurriedAction = _.Curry(bigAction);

bigCurriedAction(1)(2)(3)(4)(5)(6)(7)(8)(9)(10); // prints "1 2 3 4 5 6 7 8 9 10"
```

## Uncurry

### Action\<T0, T1\> Uncurry\<T0, T1\>(Func\<T0, Action\<T1\>\> action)
Returns an action which takes a set of arguments from a function that was curried (see example).
```csharp
Action<int, int, int> action = (a, b, c) => Console.WriteLine("{0} {1} {2}", a, b, c);

// we need a curried function to uncurry
var curriedFunction = _.Curry(action);

// this is equivalent to our starting action
var uncurriedFunction = _.Uncurry(curriedFunction);

action(1, 2, 3); // prints "1 2 3"
curriedFunction(1)(2)(3); // prints "1 2 3"
uncurriedFunction(1, 2, 3) // prints "1 2 3"
```
