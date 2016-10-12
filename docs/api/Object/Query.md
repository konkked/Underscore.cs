# Using the "Query" Object

The Object module has a commonly used concept of a "query" object (such as in `_.Object.Constructor.Find(Type target, object query)`) which can be somewhat confusing, since the object itself isn't strongly typed (it accepts an `object` as a parameter) and can take a variety of forms. Following is a description of the different ways you can use the query object to filter your results from various `Object` methods.

- [Object Array](#object-array)
- [String](#string)
- [Type](#type)
- [Anonymous Object](#anonymous-object)

## Object Array
A `object[]` where arguments can match against `String` or `Type` values in the array. Each value in the array is compared against the argument in the equivalent position of a method's parameter list (e.g. `arr[0]` => first parameter in method). `String` values are compared against the name of the argument, `Type` values are compared against the type of the argument, and other values (including `null`) are treated as wildcards, which don't filter against the argument in their index.
```cs
interface IFoo
{
    void Bah();
    void Bar(string s);
    void Buzz(int i);
    void Bazz(string s, int i);
    void Pizazz(int i, int j);
    void FooBar(int i, double d, string s);
}

object[] query;

// note that all return values are actually the MethodInfo of the method with the shown signature

// empty array
query = new[] { }
_.Object.Method.Query(typeof(IFoo), query) // [{void Bah()}]

// single string
query = new[] { "s" };
_.Object.Method.Query(typeof(IFoo), query); // [{void Bar(string s)}]

// multiple strings
query = new[] { "s", "i" };
_.Object.Method.Query(typeof(IFoo), query); // [{void Bazz(string s, int i)}]

// single type
query = new[] { typeof(int) };
_.Object.Method.Query(typeof(IFoo), query); // [{void Buzz(int i)}]

// multiple types
query = new { typeof(int), typeof(int) };
_.Object.Method.Query(typeof(IFoo), query); // [{void Pizazz(int i, int j)}]

// mixed string/types
query = new { "s", typeof(int) }
_.Object.Method.Query(typeof(IFoo), query); // [{void Bazz(string s, int i)}]

// using null as wildcard
query = new { "i", null, typeof(string) };
_.Object.Method.Query(typeof(IFoo), query); // [{void FooBar(int i, double d, string s)}]

```

## String
A single `string` can be passed to filter for methods with a single parameter whose name matches the given `string`.
```cs
interface IFoo
{
    void Bar(string s);
    void Buzz(int i);
    void Bazz(string s, int i);
}

string query = "s";

_.Object.Method.Query(typeof(IFoo), query); // [{void Bar(string s)}]
```

## Type
A single `Type` can be passed to filter for methods with a single parameter whose `Type` matches the given `Type`.
```cs
interface IFoo
{
    void Bar(string s);
    void Buzz(int i);
    void Bazz(string s, int i);
}

Type query = typeof(int);

_.Object.Method.Query(typeof(IFoo), query); // [{void Buzz(int i)}]
```

## Anonymous Object
An anonymous object can be passed to filter for both name and type simultaneously (though it's order-independent, unlike the `object[]` option). The anonymous object should be in the format `new { argName = typeof(arg) }`. If the right side of any value in the independent object is not a `Type`, an exception will be thrown. An anonymous object query ensures that any returned methods have an argument matching each of the name/type pairs in the anonymous object, ignoring order.
```cs
interface IFoo
{
    void Bah();
    void Bar(string s);
    void Buzz(int i);
    void Bazz(string s, int i);
    void Pizazz(int i, int j);
    void FooBar(int i, double d, string s);
}

// empty anonymous object accepts only parameterless methods
_.Object.Method.Query(typeof(IFoo), new {}); // [{void Bah()}]

// single property object
_.Object.Method.Query(typeof(IFoo), new {s = typeof(string)}); // [{void Bar(string s)}]

// single property object (non-matching)
_.Object.Method.Query(typeof(IFoo), new {i = typeof(string)}); // []

// multiple property object
_.Object.Method.Query(typeof(IFoo), new {s = typeof(string), i = typeof(int)}); // [{void Bazz(string s, int i)}]

// multiple property object (non-matching)
_.Object.Method.Query(typeof(IFoo), new {s = typeof(string), d = typeof(int)}); // []
```
