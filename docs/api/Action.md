# Action Module
***Note that while these are separated into categories here based on behavior, they are all called from _.Action***

## Bind
### Action Bind\<T1\>(Action\<T1\> action, T1 a)
<<<<<<< HEAD
Returns an action with all of its arguments bound to the passed arguments. Works with up to 16 arguments.
```csharp
string foo = "Hello, World!";
Action<string> action = foo => Console.WriteLine(foo);

Action boundAction = _.Action.Bind(action, foo);

boundAction(); // prints "Hello, World!"
```

### Action\<T2\> Partial\<T1, T2\>(Action\<T1, T2\> action, T1 a)
Returns a function with some of its arguments bound to the passed arguments, going from left to right. Works with any combination of partial binds, up to 15 arguments bound to a 16 argument function.
```csharp
// partially binding a small action
Action<int, string> action = (i, s) => Console.WriteLine("{0} {1}", i, s);

Action<string> boundAction = _.Action.Partial(action, 1);

boundAction("foo"); // prints "1 foo"

// partially binding a bigger action
Action<string, string, string, string, string, string> biggerAction = (a, b, c, d, e, f) => Console.WriteLine("{0} {1} {2} {3} {4} {5}", a, b, c, d, e, f);

Action<string, string, string> biggerBoundAction = _.Action.Partial(biggerAction, "a, b, c");

biggerBoundAction("d", "e", "f"); // prints "a b c d e f"
```

## Convert
### Func\<object\> ToFunction(Action action);
Converts the given action into a function which performs the action then returns null. Useful for overloading functions to accept both Func and Action inputs.
```csharp
Action action = () => Console.WriteLine("I'm hit!");

object result = _.Action.ToFunction(action); // prints "I'm hit!" and result == null
```

## Split
### Func\<T0, Action\<T1\>\> Split\<T0, T1\>(Action\<T0, T1\> action)
Halves the passed action as a function that returns action that can invoke the passed action. Works for Actions with any even parameter count up to 16.
```csharp
Action<int, int, int, int> action = (a, b, c, d) => Console.WriteLine("{0} {1} {2} {3}", a, b, c, d);

var splitAction = _.Action.Split(action);

splitAction(1, 2)(3, 4); // prints "1 2 3 4"
```

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

## Synch
### Action Before(Action action, int count)
Returns a version of the action which will only invoke a limited number of times. Any invocations past the given limit perform a no-op instead (do nothing).
```csharp
// we'll use this to see how many times the function is invoked
int counter = 0;

Action action = () => counter++;

Action befored = _.Action.Before(action, 3);

for(int i = 0; i < 10; i++)
    befored();

Console.WriteLine(counter); // prints "3"
```

### Func\<Task\> After(Action action, int count)
Returns a function which returns a task that only starts performing the given action after it is invoked count times.
```csharp
// we'll use this to see how many times the function is invoked
int counter = 0;

// we'll use this to store the tasks produced by the aftered function
Task[] tasks = new Task[6];

Action action = () => counter++;

Func<Task> aftered = _.Action.After(action, 3);

// set up a list of aftered tasks to run
for(int i = 0; i < tasks.Length; i++)
    tasks[i] = aftered();

for(int i = 0; i < tasks.Length; i++)
    tasks[i].Wait();

Console.WriteLine(counter); // prints 3
```

### Action Once(Action action)
Returns of the given action which will only invoke once. Any times it is called after the first, it instead just performs a no-op.
```csharp
int counter = 0;
Action action = () => counter++;
Action onced = _.Once(action);

// call it repeatedly
for(int i = 0; i < 100; i++)
    onced();

Console.WriteLine(counter); // 1
```

### Func\<Task\> Debounce(Action action, int milliseconds)
Returns a function which acts as a debounced version of the given function. A debounced function is throttled to only be allowed to be invoked once within the given time frame.
```csharp
int[] result = {0}

Action<int> toDebounce = n => result[0] += n

var debounced = _.Debounce(toDebounce, 50);

var tasksRunning = new List<Task>>();

for(int i = 0; i < 100; i++)
    tasksRunning.Add(debounced(i))

Console.WriteLine(result[0]) // 0

foreach(task in tasksRunning)
    await task;

Console.WriteLine(result[0]); // 99, because only the last task was processed
```

### Throttle

### Func\<Task\> Delay(Action action, int milliseconds)
Returns a function which executes the given action after the given delay, asynchronously.
```csharp
bool invoked = false;
Action action = () => invoked = true;
Func<Task> delayed = _.Delay(action, 100);

var timer = new Stopwatch();

timer.Start();
delayed.Wait();
timer.Stop();

Console.WriteLine(timer.ElapsedMilliseconds); // somewhere in the range of 105-115ms
```
