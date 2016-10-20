# Collection.Delegation

***All methods in this section can also be called as extension methods from any IEnumerable using Underscore.Extensions***

- [Invoke](#invoke)
- [Resolve](#resolve)

## Invoke

### IEnumerable\<T\> Invoke\<T\>(IEnumerable\<T\> items, string methodName)
Returns an IEnumerable consisting of the results of each item after having the method with name methodName being called.
```csharp
class Foo
{
    private static int counter = 0;
    public int Value;

    public void Bar() {
        value = counter;
        counter++;
    }
}

Foo[] items = new Foo[] {new Foo(), new Foo(), new Foo(), new Foo()}

IEnumerable<Foo> afterInvoke = _.Collection.Invoke(items, "Bar");

afterInvoke.Select(foo => foo.Value); // {1, 2, 3, 4}
```

### IEnumerable\<T\> Invoke\<T\>(IEnumerable\<T\> items, string methodName, params object[] arguments)
Returns an IEnumerable consisting of the results of each item after having the method with name methodName being called with the given arguments.
```csharp
class Foo
{
    public int Value;

    public void Bar(int n) {
        value = n;
    }
}

Foo[] items = new Foo[] {new Foo(), new Foo(), new Foo(), new Foo()}

IEnumerable<Foo> afterInvoke = _.Collection.Invoke(items, "Bar", new object[] {1});

afterInvoke.Select(foo => foo.Value); // {1, 1, 1, 1}
```

## Resolve

### IEnumerable\<T\> Resolve\<T\>(IList\<Func\<T\>\> list)
Executes a list of functions and returns the results
```csharp

Func<int>[] arr = { () => 1, () => 2, () => 3, () => 4 };

int[] resolved = _.List.Resolve(arr); // { 1, 2, 3, 4 }
```
