# Object.Constructor
***All Methods called from _.Object.Constructor property***

***All Methods which take a Type target can also take an object as target***

***All Methods that take BindingFlags default to public instance if none are given***

- [All](#all)
- [Find](#find)
- [Query](#query)
- [HasParameterless](#hasparameterless)
- [Parameterless](#parameterless)
- [Simplest](#simplest)

## All

### IEnumerable<ConstructorInfo> All(Type target[, BindingFlags flags])
Returns an IEnumerable containing the [ConstructorInfo](https://msdn.microsoft.com/en-us/library/system.reflection.constructorinfo.aspx) of all of the given type/object's constructors.
```csharp
class Foo
{
    internal Foo() { }
    public Foo(string bar) { }
    public static Foo(int buzz) { }
}

_.Object.Constructor.All(typeof(Foo), BindingFlags.Static); // [{public Foo(int buzz)}]
_.Object.Constructor.All(typeof(Foo)); // [{public Foo(string bar)}, {public Foo(int buzz)}]
```

## Find

### ConstructorInfo Find(Type target, object query[, BindingFlags flags])
Find the first constructor on the given type matching the given [query](./Query.md) and return its [ConstructorInfo](https://msdn.microsoft.com/en-us/library/system.reflection.constructorinfo.aspx).

## HasParameterless

### bool HasParameterless(Type target[, BindingFlags flags])
Checks for a parameterless constructor on the given object/type which matches the given flags.
```csharp
class Foo
{
    public Foo() { }
}

class Bar
{
    public Bar(string a) { }
}

_.Object.Constructor.HasParameterless(typeof(Foo)); // true
_.Object.Constructor.HasParameterless(new Foo()); // true
_.Object.Constructor.HasParameterless(typeof(Bar)); // false
_.Object.Constructor.HasParameterless(new Bar("foo")); // false
```

## Parameterless

### ConstructorInfo Parameterless(Type target[, BindingFlags flags])
Returns the [ConstructorInfo](https://msdn.microsoft.com/en-us/library/system.reflection.constructorinfo.aspx) of the given type's parameterless constructor, if it has one. If not, returns null.

## Simplest

### ConstructorInfo Simplest(Type target[, BindingFlags flags])
Gets the info of the constructor with the least parameters on the given type/object.
```csharp
class Foo
{
    internal Foo() { }
    public Foo(string bar) { }
    public Foo(string bar, int buzz) { }
}

_.Object.Constructor.Simplest(typeof(Foo)); // {public Foo(string bar)}
```

## Query

### IEnumerable<ConstructorInfo> Query(Type target, object query[, BindingFlags flags])
Queries the given type using a [Query Object](./Query.md) to find any constructors which match the given query.
