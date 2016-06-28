# Function Module
***Note that while these are separated into categories here based on behavior, they are all called from _.Function***

## Bind
### Func\<TResult\> Bind\<T1, TResult\>(Func\<T1, TResult\> function, T1 a)
Returns a function with all of its arguments bound to the passed arguments. Works with up to 16 arguments.
```
Func<string, string> foo = (s) => s + "bar";

Func<string> bound = _.Function.Bind(foo, "bar");

bound(); // "foobar"
```

### Func\<T2, TResult\> Partial\<T1, T2, TResult\>(Func\<T1, T2, TResult\> function, T1 a)
Returns a function with some of its arguments bound to the passed arguments, going from left to right. Works with any combination of partial binds, up to 15 arguments bound to a 16 argument function.
```
// partially binding to a small function
Func<string, string, string> foo = (a, b) => a + b;

Func<string, string> bound = _.Function.Partial(foo, "foo");

bound("bar"); // "foobar"

// partially binding to a bigger function
Func<string, string, string, string, string, string, string> bigFoo = (a, b, c, d, e, f) => a + b + c + d + e + f;

Func<string, string, string, string> bound = _.Function.Partial(bigFoo, "a", "b", "c");

bound("d", "e", "f"); // "abcdef"
```

## Boolean
### Func\<T1, bool\> Negate(Func<T1, bool> toNegate)
Returns a function which returns the opposite of toNegate whenever it is called;
```
Func<string, string, bool> equals = (a, b) => a == b;
Func<string, string, bool> notEquals = _.Function.Negate(equals);

equals("foo", "foo"); // true
notEquals("foo", "foo"); // false

equals("foo", "bar"); // false
notEquals("foo", "bar"); // true
```

### Func<bool> Or(params Func<bool>[] fns)
Returns a function which aggregates the results of all the given functions as a logical "or" does, including short-circuiting to avoid processing functions more than necessary
```
bool[] wasCalled = {false, false, false};
Func<bool> func1 = () => (wasCalled[0] = true) && false;
Func<bool> func2 = () => (wasCalled[1] = true) && true;
Func<bool> func3 = () => (wasCalled[2] = true) && false;

var orCombined = _.Function.Or(func1, func2, func3);

onCombined(); // true
wasCalled; // {true, true, false}
```

### Func<bool> And(params Func<bool>[] fns)
```
bool[] wasCalled = {false, false, false};
Func<bool> func1 = () => (wasCalled[0] = true) && true;
Func<bool> func2 = () => (wasCalled[1] = true) && false;
Func<bool> func3 = () => (wasCalled[2] = true) && true;

var orCombined = _.Function.And(func1, func2, func3);

onCombined(); // false
wasCalled; // {true, true, false}
```

## Compose
### TResult Apply\<T, TResult\>(Func\<T, TResult\> function, T[] arguments)
Applies the given array of arguments to the given function and returns the result. Works with functions using up to 16 arguments.
```
string[] args = {"foo", "bar"};
Func<string, string, string> foo = (a, b) => a + b;

_.Function.Invoke(foo, args); // "foobar"
```

### Func\<TStart, TResult\> Compose\<TStart, TMid, TResult\>(Func\<TStart, TMid\> start, Func\<TMid,TResult\> end)
Chains a series of functions together, passing the result of each function to the next and returning the result of the last function passed in. Takes up to 16 functions.
```
Func<string, string> first = (a) => a + "foo";
Func<string, string> second = (a) => a + "bar";
Func<string, string> third = (a) => a + "baz";

Func<string, string> composed = _.Compose(first, second, third);

composed(""); // "foobarbaz"
```

## Split
### Func\<T0, Func\<T1, TResult\>\> Split\<T0, T1, TResult\>(Func\<T0, T1, TResult\> function)
Halves the passed function into a function that returns another function, where the intitial function takes the first half of the original function's arguments, and the function it returns takes the second half of the original function's arugments. Works for Funcs with any even parameter count up to 16.
```
Func<int, int, int, int, int> action = (a, b, c, d) => a + b + c + d;

var splitAction = _.Action.Split(action);

splitAction(1, 2)(3, 4); // 10
```

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

## Synch
### Func\<Task\<TResult\>\> After\<TResult\>(Func\<TResult\> function, int count)
Returns a function which returns a task that only performs the given function after it is called with all of the calls before count times yielding a result equal to the result of the first working invocation, with every subsequent execution just returning the last invocation's result.
```
Func<string, string> function = (a) => a + a;

var aftered = _.Function.After(function, 3);

List<Task<string>> tasks = new List<Task<string>>();

for(int i = 0; i < 10; i++)
    tasks.Add(aftered(i.ToString()));

foreach(var task in tasks)
    task.Wait();

var results = new List<string>();

foreach(var task in tasks)
    results.Add(task.Result);

results; // { "2", "2", "2", "3", "4", "5", "6", "7", "8", "9" }
```

### Throttle
*TODO*

### Delay
*TODO*

### Func<TResult> Before<TResult>(Func\<TResult\> function, int count)
Returns a function which performs the initial function up until the given number of invocations is reached, after which time it will return the result of the last invocation that was performed.
```
int counter = 0;
Func<int> toBefore = ++counter;


Func<int> befored = _.Function.Before(toOnce, 3);

int result;

for(int i = 0; i < 100; i++)
    result = onced();

result; // 3
counter; // 3
```

### Func<TResult> Once<TResult>(Func\<TResult\> function, int count)
```
int counter = 0;
Func<int> toOnce = ++counter;


Func<int> onced = _.Function.Once(toOnce);

int result;

for(int i = 0; i < 100; i++)
    result = onced();

result; // 1
counter; // 1
```
