# Action Module
## Bind
### Action Bind\<T1\>(Action\<T1\> action, T1 a)
Binds action to given variables. When called with more variables (and a action with a param list of matching size), binds all of the variables to the given action.
```
string foo = "Hello, World!";
Action<string> action = foo => Console.WriteLine(foo);

Action boundAction = _.Action.Bind(action, foo);

boundAction(); // prints "Hello, World!" to console
```

### Action\<T2\> Partial\<T1, T2\>(Action\<T1, T2\> action, T1 a)
Partially binds the given parameters to action, from left to right. Works with any combination of Action parameter counts and number of parameters to partially bind (if you want to partially bind 11 parameters to a 14 parameter function, you can).
```
Action<int, string> action = (i, s) => Console.WriteLine("{0} {1}", i, s);

Action<string> boundAction = _.Action.Partial(action, 1);

boundAction("foo"); // prints "1 foo"
```

## Convert
### Func\<object\> ToFunction(Action action);
Converts the given action into a function which performs the action then returns null. Useful for overloading functions to accept both Func and Action inputs.
```
Action action = () => Console.WriteLine("I'm hit!");

object result = _.Action.ToFunction(action); // prints "I'm hit!" and result == null
```

## Split
### Func\<T0, Action\<T1\>\> Split\<T0, T1\>(Action\<T0, T1\> action)
Halves the passed action as a function that returns action that can invoke the passed action. Works for Actions with any even parameter count up to 16.
```
Action<int, int, int, int> action = (a, b, c, d) => Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);

var splitAction = _.Action.Split(action);

splitAction(1, 2)(3, 4); // prints "1 2 3 4
```

### Func\<T0, Action\<T1\>\> Curry\<T0, T1\>(Action\<T0, T1\> action)
Returns a function which takes a chain of function calls to use as arguments for action (see examples). Can be called with Actions that have up to 16 parameters.
```
// with an action with a few parameters
Action<int, int> smallAction = (a, b) => Console.WriteLine("{0} {1}");
var smallCurriedAction = _.Curry(smallAction);

smallCurriedAction(1)(2); // prints "1 2"

// with an action with a lot of parameters
Action<int, int, int, int, int, int, int, int, int, int> bigAction = (a, b, c, d, e, f, g, h, i, j) => Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10}", a, b, c, d, e, f, g, h, i, j);

var bigCurriedAction = _.Curry(bigAction);

bigCurriedAction(1)(2)(3)(4)(5)(6)(7)(8)(9)(10); // prints "1 2 3 4 5 6 7 8 9 10"
```
