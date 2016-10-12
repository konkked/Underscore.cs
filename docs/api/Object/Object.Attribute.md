# Object.Attribute
***All Methods called from _.Object.Attribute property***

- [Has](#has)
- [Find](#find)
- [All](#all)

## Has

### bool Has\<TAttribute>(object value) where TAttribute : System.Attribute
Checks if there are any attributes of the given type on the given object/type.
```csharp
[Foo]
class AttributeTest
{
    [Bar]
    public string bar;
}

_.Object.Attribute.Has<Foo>(new AttributeTest()); // true
_.Object.Attribute.Has<Foo>(typeof(AttributeTest)); // true
_.Object.Attribute.Has<Bar>(new AttributeTest()); // false
_.Object.Attribute.Has<Bar(new AttributeTest().bar); // true
```

## Find

### TAttribute Find\<TAttribute>(object value) where TAttribute : System.Attribute
Finds the first attribute of the given type on the given object/type.
```csharp
[Foo("foo")]
[Foo("bar")]
class AttributeTest
{
    [Bar]
    public string bar;
}

_.Object.Attribute.Find<Foo>(new AttributeTest()); // Foo("foo")
_.Object.Attribute.Find<Foo>(typeof(AttributeTest)); // Foo("foo")
_.Object.Attribute.Find<Bar>(new AttributeTest()); // null
_.Object.Attribute.Find<Bar(new AttributeTest().bar); // Bar
```

## All

### IEnumerable\<TAttribute> All\<TAttribute>(object value) where TAttribute : System.Attribute
Returns all attributes of the given type on the given object/type.
```csharp
[Foo("foo")]
[Foo("bar")]
class AttributeTest
{
    [Bar]
    public string bar;
}

_.Object.Attribute.All<Foo>(new AttributeTest()); // [ Foo("foo"), Foo("bar") ]
_.Object.Attribute.All<Foo>(typeof(AttributeTest)); // [ Foo("foo"), Foo("bar") ]
_.Object.Attribute.All<Bar>(new AttributeTest()); // [ ]
_.Object.Attribute.All<Bar(new AttributeTest().bar); // [ Bar ]
```
