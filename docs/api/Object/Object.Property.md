# Object.Property
***All Methods called from _.Object.Method property***

***All Methods which take a Type target can also take an object as target***

- [All](#all)
- [Each](#each)
- [Find](#find)
- [Has](#has)
- [OfType](#oftype)
- [GetValue](#getvalue)
- [SetValue](#setvalue)
- [Pairs](#pairs)
- [Values](#values)

For all examples in this class assume the following class/object exists:
```cs
class Foo
{
    public string S { get; set; }
    public int I { get; set; }
    public int J { get; set; }
}

var foo = new Foo
    {
        S = "foobar",
        I = 1,
        J = 2
    };
```

## All

### IEnumerable\<PropertyInfo> All(Type target)
Get the [PropertyInfo](https://msdn.microsoft.com/en-us/library/system.reflection.propertyinfo.aspx) of all properties on `target`.
```cs
_.Object.Property.All(typeof(Foo)); // [{public string S}, {public int I}, {public int J}]
```

## Each
Performs the given action on each property of `target`.

### void Each\<T>(object target, Action\<T> onEach[, BindingFlags flags])
Performs the given action on the value of each property of `target` which is of type `T`, using an action which takes the value of the property as a parameter.
```cs
_.Object.Property.Each<int>(foo, value => Console.WriteLine(value));
// 1
// 2
```

### void Each\<T>(object target, Action\<T, string> onEach[, BindingFlags flags])
Performs the given action on each property of `target` which is of type `T`, using an action which takes the value and name of the property as a parameter.
```cs
_.Object.Property.Each<int>(foo, (value, name) => Console.WriteLine("{0}: {1}", name, value));
// I: 1
// J: 2
```

### void Each\<T>(object target, Action\<T, string, Action\<T>>[, BindingFlags flags])
Performs the given action on each property of `target` which is of type `T`, using an action which takes the value and name of the property, as well as an action to set its value as arguments.
```cs
_.Object.Property.Each<int>(foo, (value, name, setter) => { setter(value * 2) });
foo.I // 2
foo.J // 4
```

### void Each(object target, Action\<T> onEach[, BindingFlags flags])
Performs the given action on the value of each property of `target`, using an action which takes the value of the property as a parameter.
```cs
_.Object.Property.Each(foo, value => Console.WriteLine(value));
// foobar
// 1
// 2
```

### void Each(object target, Action\<T, string> onEach[, BindingFlags flags])
Performs the given action on each property of `target`, using an action which takes the value and name of the property as a parameter.
```cs
_.Object.Property.Each(foo, (value, name) => Console.WriteLine("{0}: {1}", name, value));
// S: foobar
// I: 1
// J: 2
```

### void Each(object target, Action\<object, string, Action\<object>>[, BindingFlags flags])
Performs the given action on each property of `target`, using an action which takes the value and name of the property, as well as an action to set its value as arguments.
```cs
_.Object.Property.Each(foo, (value, name, setter) => {
    if(value is int)
        setter(((int) value) * 2);
    else if(value is string)
        setter(((string) value) + ((string) value));
});
foo.S // foobarfoobar
foo.I // 2
foo.J // 4
```

## Find

### PropertyInfo Find(Type target, string name[, bool caseSensitive, BindingFlags flags])
Find a property with the given name on `target` and return its [PropertyInfo](https://msdn.microsoft.com/en-us/library/system.reflection.propertyinfo.aspx).
```cs
_.Object.Property.Find(typeof(Foo), "S"); // {string S}
_.Object.Property.Find(typeof(Foo), "s"); // null
_.Object.Property.Find(typeof(Foo), "s", false); // {string S}
```

## Has

### bool Has(Type target, string name[, bool caseSensitive, BindingFlags flags])
Check if a property exists on `target` with the given name.
```cs
_.Object.Property.Has(typeof(Foo), "S"); // true
_.Object.Property.Has(typeof(Foo), "s"); // false
_.Object.Property.Has(typeof(Foo), "s", false); // true
```

## OfType

### IEnumerable\<PropertyInfo> OfType(Type target, Type propertyTypeTarget[, BindingFlags flags])
Get all properties of type `propertyTypeTarget` which are on `target`.
```cs
_.Object.Property.OfType(typeof(Foo), typeof(string)); // [{public string S}]
_.Object.Property.OfType(typeof(Foo), typeof(int)); // [{public int I}, {public int J}]
```

### IEnumerable\<PropertyInfo> OfType\<T>(Type target[, BindingFlags flags])
Get all properties of type `T` which are on `target`.
```cs
_.Object.Property.Find<string>(typeof(Foo)); // [{public string S}]
_.Object.Property.Find<int>(typeof(Foo)); // [{public int I}, {public int J}]
```

## GetValue

### T GetValue\<T>(object target, string name[, string caseSensitive])
Get the value of the property on `target` with the given name and type `T`. If no matching properties are found, throws an ArgumentException.
```cs
_.Object.Property.GetValue<string>(foo, "S"); // foobar
_.Object.Property.GetValue<int>(foo, "S"); // throws ArgumentException
_.Object.Property.GetValue<string>(foo, "s"); // throws ArgumentException
_.Object.Property.GetValue<string>(foo, "s", false); // foobar
```

### object GetValue(object target, string name[, string caseSensitive, BindingFlags flags])
Get the value of the property on `target` with the given name. If no matching properties are found, throws an ArgumentException.
```cs
_.Object.Property.GetValue(foo, "S"); // foobar
_.Object.Property.GetValue(foo, "s"); // throws ArgumentException
_.Object.Property.GetValue(foo, "s", false); // foobar
```

## SetValue

### void SetValue\<T>(object target, string name, T value[, bool caseSensitive, BindingFlags flags])
Set the value of the property with name `name` on `target` to `value`. The found property must be of type `T`. If there is a type mismatch or a property with the given name is not found, an ArgumentException is thrown.
```cs
_.Object.Property.SetValue<int>(foo, "I", 4);
foo.I // 4

_.Object.Property.SetValue<string>(foo, "I", "foo"); // throws ArgumentException
foo.I // 4

_.Object.Property.SetValue<int>(foo, "i", 8); // throws ArgumentException
foo.I // 4

_.Object.Property.SetValue<int>(foo, "i", 8, false);
foo.I // 8
```

### void SetValue(object target, string name, object value[, bool caseSensitive, BindingFlags flags])
Set the value of the property with name `name` on `target` to `value`. If a property with the given name is not found, an ArgumentException is thrown.
```cs
_.Object.Property.SetValue(foo, "I", 4);
foo.I // 4

_.Object.Property.SetValue(foo, "i", 8); // throws ArgumentException
foo.I // 4

_.Object.Property.SetValue(foo, "i", 8, false);
foo.I // 8
```

## Pairs

### IEnumerable\<MemberPair\<TPropertyValue>> Pairs\<TPropertyValue>(object target[, BindingFlags flags])
Retrieve all name-value pairs of properties of type `TPropertyValue` on `target`.
```cs
// this class is not being defined for the example, just being shown. it is defined in Underscore.Object.IProperty
public class MemberPair<T>
{
	public string Name { get; internal set; }
	public T Value { get; internal set; }
}

_.Object.Property.Pairs<int>(foo); // [{Name = "I", Value = 1}, {Name = "J", Value = 2}]
```

### IEnumerable\<MemberPair\<TPropertyValue>> Pairs\<TPropertyValue>(object target[, BindingFlags flags])
Retrieve all name-value pairs of properties on `target`.
```cs
// this class is not being defined for the example, just being shown. it is defined in Underscore.Object.IProperty
public class MemberPair<T>
{
	public string Name { get; internal set; }
	public T Value { get; internal set; }
}

_.Object.Property.Pairs(foo); // [{Name = "S", Value = "foobar"}, {Name = "I", Value = 1}, {Name = "J", Value = 2}]
```

## Values

### IEnumerable\<TPropertyValue> Values\<TPropertyValue>(object target[, BindingFlags flags])
Gets all values of all properties of type `TPropertyValue` on `target`.
```cs
_.Object.Values<int>(foo); // [1, 2]
```

### IEnumerable<object> Values(object target[, BindingFlags flags])
Gets all values of all properties on `target`.
```cs
_.Object.Values(foo); // [foobar, 1, 2]
```
