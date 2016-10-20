# Action.Bind

***All methods in this section are called from _.Action***

- [Bind](#bind)
- [Partial](#partial)

## Bind

### Action Bind\<T1\>(Action\<T1\> action, T1 a)
Returns an action with all of its arguments bound to the passed arguments. Works with up to 16 arguments.
```csharp
string foo = "Hello, World!";
Action<string> action = foo => Console.WriteLine(foo);

Action boundAction = _.Action.Bind(action, foo);

boundAction(); // prints "Hello, World!"
```

## Partial

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
