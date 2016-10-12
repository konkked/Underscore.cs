#  Object.Field
***All Methods called from _.Object.Field property***

***All Methods which take a Type target can also take an object as target***

- [Find](#find)
- [Has](#has)
- [All](#all)
- [OfType](#oftype)
- [Values](#values)

## Find

### FieldInfo Find(Type target, string name[, Type type, bool caseSensitive])
Find a field on the target (optionally filtering by type) and return its [FieldInfo](https://msdn.microsoft.com/en-us/library/system.reflection.fieldinfo.aspx).
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
}

_.Object.Field(typeof(Foo), "s"); // string s
_.Object.Field(typeof(Foo), "i", typeof(int)); // int i
_.Object.Field(typeof(Foo), "s", typeof(double), false); // double S
```

## Has

### bool Has(Type target, string name[, Type type, bool caseSensitive])
Check if the target has a field with the given name (optionally additionally filtering by type).
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
}

_.Object.Field.Has(typeof(Foo), "s"); // true
_.Object.Field.Has(typeof(Foo), "i", typeof(int)); // true
_.Object.Field.Has(typeof(Foo), "s", typeof(double), false); // true
_.Object.Field.Has(typeof(Foo), "d"); // false
_.Object.Field.Has(typeof(Foo), "I"); // false
_.Object.Field.Has(typeof(Foo), "s", typeof(int)); // false
```

## All

### IEnumerable\<FieldInfo> All(Type target[, BindingFlags flags])
Return the [FieldInfo](https://msdn.microsoft.com/en-us/library/system.reflection.fieldinfo.aspx) of all fields from the given target, filtering for those that match the given flags (defaults to public instance).
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
}

_.Object.Field.All(typeof(Foo)); // [{string s}, {double d}, {int i}]
```

## OfType

### IEnumerable\<FieldInfo> OfType(Type target, Type type)
Returns the [FieldInfo](https://msdn.microsoft.com/en-us/library/system.reflection.fieldinfo.aspx) of all fields of the given type on `target`.
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
    public int j;
}

_.Object.Field.OfType(typeof(Foo), typeof(int)); // [{int i}, {int j}]
```

## Values
Returns the values of all public instance fields on `target`. Order of the values is not guaranteed, so if order is important the IEnumerable should be sorted after return.

### IEnumerable\<T> Values(object target)
Generic version which filters to only return the values of fields of type `T`.
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
    public int j;
}

var foo = new Foo {
    s = "foo",
    S = 3.14,
    i = 1,
    j = 2
};

_.Object.Field.Values<int>(foo); // [1, 2]
```

### IEnumerable\<object> Values(object target)
Overload which returns the value of all fields on `target`, regardless of type.
```cs
class Foo
{
    public string s;
    public double S;
    public int i;
    public int j;
}

var foo = new Foo {
    s = "foo",
    S = 3.14,
    i = 1,
    j = 2
};

_.Object.Field.Values(foo); // ["foo", 3.14, 1, 2]
```
