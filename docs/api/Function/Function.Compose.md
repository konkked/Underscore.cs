# Function.Compose

- [Apply](#apply)
- [Compose](#compose)

## Apply

### TResult Apply\<T, TResult\>(Func\<T, TResult\> function, T[] arguments)
Applies the given array of arguments to the given function and returns the result. Works with functions using up to 16 arguments.
```
string[] args = {"foo", "bar"};
Func<string, string, string> foo = (a, b) => a + b;

_.Function.Invoke(foo, args); // "foobar"
```

## Compose

### Func\<TStart, TResult\> Compose\<TStart, TMid, TResult\>(Func\<TStart, TMid\> start, Func\<TMid,TResult\> end)
Chains a series of functions together, passing the result of each function to the next and returning the result of the last function passed in. Takes up to 16 functions.
```
Func<string, string> first = (a) => a + "foo";
Func<string, string> second = (a) => a + "bar";
Func<string, string> third = (a) => a + "baz";

Func<string, string> composed = _.Compose(first, second, third);

composed(""); // "foobarbaz"
```
