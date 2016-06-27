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
***TODO***

### Func<bool> And(params Func<bool>[] fns)
***TODO***

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
