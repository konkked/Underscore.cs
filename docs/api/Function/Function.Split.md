# Function.Split

- [Split](#split)
- [Curry](#curry)
- [Uncurry](#uncurry)

## Split

### Func\<T0, Func\<T1, TResult\>\> Split\<T0, T1, TResult\>(Func\<T0, T1, TResult\> function)
Halves the passed function into a function that returns another function, where the intitial function takes the first half of the original function's arguments, and the function it returns takes the second half of the original function's arugments. Works for Funcs with any even parameter count up to 16.
```
Func<int, int, int, int, int> action = (a, b, c, d) => a + b + c + d;

var splitAction = _.Action.Split(action);

splitAction(1, 2)(3, 4); // 10
```

## Curry

### Func\<T0, Func\<T1, TResult\>\> Curry\<T0, T1, TResult\>(Func\<T0, T1, TResult\> function)
Returns a function which takes a chain of function calls to use as arguments for function (see examples). Can be called with Funcs that have up to 16 parameters.
```
// with an action with a few parameters
Func<string, string, string> smallFunction = (a, b) => a + b;
var smallCurriedAction = _.Curry(smallAction);

smallCurriedAction("a")("b"); // ab

// with an action with a lot of parameters
Func<string, string, string, string, string, string, string, string, string, string, string> bigFunction =
    (a, b, c, d, e, f, g, h, i, j) =>
        string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", a, b, c, d, e, f, g, h, i, j);

var bigCurriedFunction = _.Curry(bigFunction);

bigCurriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j"); //"a b c d e f g h i j"
```

## Uncurry

### Function\<T0, T1, TResult\> Uncurry\<T0, T1, TResult\>(Func\<T0, Func\<T1, TResult\>\> function)
Returns an action which takes a set of arguments from a function that was curried (see example).
```
Func<string, string, string> function = (a, b, c) => a + b + c;

// we need a curried function to uncurry
var curriedFunction = _.Curry(action);

// this is equivalent to our starting action
var uncurriedFunction = _.Uncurry(curriedFunction);

function("a", "b", "c"); // "a b c"
curriedFunction("a")("b")("c"); // "a b c"
uncurriedFunction("a", "b", "c") // "a b c"
```
