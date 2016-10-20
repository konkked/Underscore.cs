# Object.Method
***All Methods called from _.Object.Method property***

***All Methods which take a Type target can also take an object as target***

 - [All](#all)
 - [Find](#find)
 - [Has](#has)
 - [Query](#query)
 - [Invoke](#invoke)

 All examples in this document assume the following class exists:

 ```cs
class Foo
{
    public void Bar();
    public void Bar(string s);
    public string Buzz(int i);
    public double Bazz(int i, string s);
    public long Pizazz(int i, int j);
}
 ```

 All the return values in the format `{public Bar()}` are referring to the MethodInfo of the function with that signature.

## All

### IEnumerable\<MethodInfo> All(Type target[, BindingFlags flags])
Gets the [MethodInfo](https://msdn.microsoft.com/en-us/library/system.reflection.methodinfo.aspx) of all methods on `target`.
```cs
_.Object.Method.All(typeof(Foo)); // [{public void Bar()}, {public void Bar(string s)}, {public string Buzz(int i)}, {public double Bazz(int i, string s)}, {public long Pizazz(int i, int j)}]
```

## Find

### MethodInfo Find(Type target[, string name, object query, bool caseSensitive, BindingFlags flags])
Find a method on `target` which matches the name and/or [query](./Query.md) and return its [MethodInfo](https://msdn.microsoft.com/en-us/library/system.reflection.methodinfo.aspx). Either `name`, [query](./Query.md), or both must be passed to this method. If no `flags` are passed, this method defaults to looking for public instance methods. Either `name`, `query` or both must be passed to the function. If no matching methods are found, returns `null`.
```cs
// just name input
_.Object.Method.Find(typeof(Foo), "Bar"); // {public void Bar()}
_.Object.Method.Find(typeof(Foo), "bar"); // null
_.Object.Method.Find(typeof(Foo), "bar", false); // {public void Bar()}

// just query input
_.Object.Method.Find(typeof(Foo), new { i = typeof(int) }); // {public string Buzz()}

// mixed input
_.Object.Method.Find(typeof(Foo), "Bar", new { s = typeof(string) }); // {public void Bar(string s)}
```

## Has

### bool Has(Type target, [string name, object query, BindingFlags flags])
Check if a method exists on `target` which matches the name and/or [query](./Query.md). Either name, query, or both must be passed to this method. If no `flags` are passed, this method defaults to looking for public instance methods. Either `name`, `query` or both must be passed to the function. If no matching methods are found, returns `null`.
```cs
// just name input
_.Object.Method.Find(typeof(Foo), "Bar"); // true
_.Object.Method.Find(typeof(Foo), "bar"); // false

// just query input
_.Object.Method.Find(typeof(Foo), new { i = typeof(int) }); // true
_.Object.Method.Find(typeof(Foo), new { i = typeof(string) }); // false

// mixed input
_.Object.Method.Find(typeof(Foo), "Bar", new { s = typeof(string) }); // true
_.Object.Method.Find(typeof(Foo), "Bar", new { }); // true
_.Object.Method.Find(typeof(Foo), "Bar", new { s = typeof(int) }); // false
```

## Query

## IEnumerable\<MethodInfo> Query(Type target, object query[, string name, bool caseSensitive, BindingFlags flags])
Query for all methods on `target` which match the given [query](./Query.md) (and optionally, name). If no `flags` are passed, this method defaults to looking for public instance methods. If no matching results are found, returns an empty IEnumerable. For an in-depth look at all of the query object options, look [here](./Query.md).
```cs
_.Object.Method.Query(typeof(Foo), new { i = typeof(int) }); // [{public string Buzz()}]
_.Object.Method.Query(typeof(Foo), new[] { }) // [{public void Bar()}]

_.Object.Method.Query(typeof(Foo), "Bar", new { s = typeof(string) }); // [{public void Bar(string s)}]
_.Object.Method.Query(typeof(Foo), "Bar", new { s = typeof(int) }); // []
```

## Invoke
Invokes the given method from the given object and returns the result.

### object Invoke(object target, string name[, BindingFlags flags, params object\[] arguments])
Returns an object containing the return value of the invocation. If arguments are provided, the method is invoked with those arguments. If the method is not found on the object, returns null.
```cs
var foo = new Foo();

_.Object.Method.Invoke(foo, "Bar"); // invokes foo.Bar()
_.Object.Method.Invoke(foo, "Bar", new object[] { "foo" }); // invokes foo.Bar("foo")

string result = (string) _.Object.Method.Invoke(foo, "Buzz", new object[] { 1 }); // invokes foo.Buzz(1) and returns result
```

### T Invoke\<T>(object target, string name[, BindingFlags flags, params object\[] arguments])
Returns a `T` containing the return value of the invocation, where `T` is the return type of the desired method. If arguments are provided, the method is invoked with those arguments. If the method is not found on the object, returns the default value of `T`.
```cs
var foo = new Foo();

_.Object.Method.Invoke<object>(foo, "Bar"); // invokes foo.Bar()

string result = _.Object.Method.Invoke<string>(foo, "Buzz", new object[] { 1 }); // invokes foo.Buzz(1) and returns result
```

## InvokeForAll

### IEnumerable\<object> InvokeForAll(object target, string name[, BindingFlags flags], object\[]\[] argumentSets[, bool greedy])
Returns an `IEnumerable<object>` consisting of the results of invoking the method with the given `name` with each array of arguments in `argumentSets`. If `greedy` is `true`, all invocations are done on call of `InvokeForAll()`, else invocations are done as objects are yielded by the `IEnumerable`.
```cs
var foo = new Foo();
var argSets = new object[][]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 },
    { 7, 8 }
};

// Pizazz hasn't been executed yet
IEnumerable<object> result = _.Object.Method.InvokeForAll(foo, "Pizazz", argSets);

foreach(object item in result)
{
    // foo.Pizazz is being called on each iteration of this loop
    Console.WriteLine(item);
}

// Pizass is invoked for all arguments on this call because of the greedy parameter
result = _.Object.Method.InvokeForAll(foo, "Pizazz", argSets, true);
```

### IEnumerable\<T> InvokeForAll(object target, string name[, BindingFlags flags, object\[]\[] argumentSets, bool greedy])
Returns an `IEnumerable<T>` consisting of the results of invoking the method with the given `name` with each array of arguments in `argumentSets`, where `T` is the expected return type of the method you want to invoke. If `greedy` is `true`, all invocations are done on call of InvokeForAll(), else invocations are done as objects are yielded by the `IEnumerable`.
```cs
var foo = new Foo();
var argSets = new object[][]
{
    { 1, 2 },
    { 3, 4 },
    { 5, 6 },
    { 7, 8 }
};

// Pizazz hasn't been executed yet
IEnumerable<long> result = _.Object.Method.InvokeForAll<long>(foo, "Pizazz", argSets);

foreach(object item in result)
{
    // foo.Pizazz is being called on each iteration of this loop
    Console.WriteLine(item);
}

// Pizass is invoked for all arguments on this call because of the greedy parameter
result = _.Object.Method.InvokeForAll<long>(foo, "Pizazz", argSets, true);
```
