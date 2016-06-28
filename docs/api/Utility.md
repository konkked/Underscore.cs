# Utility Module

## Compact
### Tuple\<\<Tuple\<T1, T2, T3, T4\>, T5\> Pack(T1 a, T2 b, T3 c, T4 d, T5 e)
Packs given arguments into tuples, grouped by each 4 arguments. Can take any number of arguments from 1-16, inclusive. If passed 4 or fewer arguments, just packs the given arguments into a single non-nested tuple. If given more than 4 arguments, any arguments that can't be packed into a sub-tuple of 4 are added as extra items to the main tuple (see example).
```
_.Utility.Pack(1, 2, 3, 4, 5); // returns Tuple(Tuple(1, 2, 3, 4), 5)
```

## Function
### Func<T> Constant(T value)
Returns a function which always returns the given value
```
int[] values = {1, 2, 3, 4, 5, 6};
var constFunc = _.Utility.Constant(values);

// change all the array values
for(int i = 0; i < values.Length; i++)
    values[i] *= 3;

constFunc(); // {1, 2, 3, 4, 5, 6}
```

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
_.Utility.UniqueId("foobar"); // looks like foobar_F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier)
```
_.Utility.UniqueId(); // looks like F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### int Random(int min, int max)
Generates a random integer between the given min and max, where min is inclusive and max is exclusive.
```
_.Random(-100, 100) // can be any integer in [-100..99]
```

### int Random(int max)
Generates a random integer between 0 and the given max, where max is exclusive.
```
_.Random(100); // can be any integer in [0..99]
```

### int Random()
Generates a random integer between 0 and Int32.MaxValue, max bound is exclusive
```
_.Random(); // can be any integer in [0..Integer.MaxValue - 1]
```

### int Abs(int i)
Returns the absolute value of the given value (performant implementation).
```
_.Abs(-100); // 100
_.Abs(100); // 100
```

### int Min(int i)
Returns the smaller of the two given values (performant implementation).
```
_.Min(1, 10); // 1
```

### int Max(int i)
Returns the larger of the two given values (performant implementation).
```
_.Max(1, 10); // 10
```
