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
Func<string, string, string> foo = (s1, s2) => s1 + s2;

Func<string, string> bound = _.Function.Partial(foo, "foo");

bound("bar"); // "foobar"
```
