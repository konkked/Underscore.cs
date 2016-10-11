# Function.Bind

- [Bind](#bind)
- [Partial](#partial)

## Bind

### Func\<TResult\> Bind\<T1, TResult\>(Func\<T1, TResult\> function, T1 a)
Returns a function with all of its arguments bound to the passed arguments. Works with up to 16 arguments.
```
Func<string, string> foo = (s) => s + "bar";

Func<string> bound = _.Function.Bind(foo, "bar");

bound(); // "foobar"
```

## Partial

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
