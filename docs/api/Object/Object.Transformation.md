# Object.Transformation

- [Dynamic](#dynamic)
- [Transpose](#transpose)
- [Coalesce](#coalesce)

For all examples in this document, assume that the following class/object exists:
```cs
class Foo
{
    public string S { get; set; }
    public int I { get; set; }
}

var foo = new Foo()
{
    S = "foobar",
    I = 1
};
```

## ToDynamic

### dynamic ToDynamic(object target)
Creates a [dynamic](https://msdn.microsoft.com/en-us/library/dd264736.aspx) object with all the properties of `target` on it.
```cs
dynamic d = _.Object.ToDynamic(foo);

d.S == foo.S;
d.I == foo.I;
```

## Transpose

### void Transpose(object source, object destination)
Copies all of the properties from `source` onto `destination`.
```cs
var otherFoo = new Foo();
var anonymous = new {
    S = "",
    I = 0
};

_.Object.Transpose(foo, otherFoo);
_.Object.Transpose(foo, anonymous);

foo.S == otherFoo.S;
foo.I == otherFoo.I;
foo.S == anonymous.S;
foo.I == anonymous.I;
```


## Coalesce

### TFirst Coalesce<TFirst>(TFirst first, object second[, bool newObject])

Coalesce all properties from `second` onto `first`. If newObject is passed as `true`, a new object is returned. Otherwise, `first` is changed and then returned.
```cs
var otherFoo = new Foo();
var anonymous = new {
    S = "",
    I = 0
};

// coalesce to same type with newObject = true
var result = _.Object.Coalesce(otherFoo, foo, true); // otherFoo is still empty
result == {S = "foobar", I = 1}

// coalesce to same type without newObject being passed
result = _.Object.Coalesce(otherFoo, foo);
result == {S = "foobar", I = 1}
otherFoo == {S = "foobar", I = 1}

// coalesce from anonymous object
result = _.Object.Coalesce(otherFoo, anonymous);
result == {S = "", I = 0};
otherFoo == {S = "", I = 0};
```
