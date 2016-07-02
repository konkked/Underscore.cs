# Object Module

## Comparison
### bool AreEquatable(object a, object b, bool typeSensitive)
Returns true if two items are equal, checking for deep equality (checking for equality of nested objects). This is done by comparing the fields on each item, not the references. If two items of the same type are passed with no typeSensitive argument, the two types are compared using the type sensitive algorithm.
```csharp
public class Foo
{
    public Bar bar;
    public int number;
}

public class Bar
{
    public string str;
}

var base = new Foo
           {
               bar = new Bar
               {
                   str = "test";
               },
               number = 5
           };

var equalItem = new Foo
                {
                    bar = new Bar
                    {
                        str = "test";
                    },
                    number = 5
                };

var unequalItem = new Foo
                  {
                      bar = new Bar
                      {
                          str = "other";
                      },
                      number = 10
                  };

_.AreEquatable(base, equalItem); // true
_.AreEquatable(base, unequalItem); // false
_.AreEquatable(base, null); // false
_.AreEquatable(base, equalItem, true); // true
```
