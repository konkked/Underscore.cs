# Utility Module

## Object
### bool IsTruthy(object target)
Returns false if target object is the default of its type, with the exception of strings which return false on empty, whitespace or null.
```
_.IsTruthy(0); // false
_.IsTruthy(1); // true

_.IsTruthy(null); // false
_.IsTruthy(new object()); // true

_.IsTruthy(""); // false
_.IsTruthy("    "); // false
_.IsTruthy("something"); // true

_.IsTruthy(false); // false
_.IsTruthy(true); // true
```

## Math
### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier) prefixed with the given string and "\_"
```
Console.WriteLine(_.Utility.UniqueId("foobar")); // looks like foobar_F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier)
```
Console.WriteLine(_.Utility.UniqueId()); // looks like F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### int Random(int min, int max)
Generates a random integer between the given min and max, where min is inclusive and max is exclusive.
```
Console.WriteLine(_.Random(-100, 100)) // can be any integer in [-100..99]
```

### int Random(int max)
Generates a random integer between 0 and the given max, where max is exclusive.
```
Console.WriteLine(_.Random(100)); // can be any integer in [0..99]
```

### int Random()
Generates a random integer between 0 and Int32.MaxValue, max bound is exclusive
```
Console.WriteLine(_.Random()); // can be any integer in [0..Integer.MaxValue - 1]
```

### int Abs(int i)
Returns the absolute value of the given value (performant implementation).
```
Console.WriteLine(_.Abs(-100)); // 100
Console.WriteLine(_.Abs(100)); // 100
```

### int Min(int i)
Returns the smaller of the two given values (performant implementation).
```
Console.WriteLine(_.Min(1, 10)); // 1
```

### int Max(int i)
Returns the larger of the two given values (performant implementation).
```
Console.WriteLine(_.Max(1, 10)); // 10
```
