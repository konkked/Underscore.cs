# Utility.Math

- [UniqueId](#uniqueid)
- [Random](#random)
- [Abs](#abs)
- [Min](#min)
- [Max](#max)

## UniqueId

### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier) prefixed with the given string and "\_"
```csharp
_.Utility.UniqueId("foobar"); // looks like foobar_F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

### string UniqueId(string prefix)
Returns a GUID (Globally Unique Identifier)
```csharp
_.Utility.UniqueId(); // looks like F9168C5E-CEB2-4FAA-B6BF-329BF39FA1E4
```

## Random

### int Random(int min, int max)
Generates a random integer between the given min and max, where min is inclusive and max is exclusive.
```csharp
_.Random(-100, 100) // can be any integer in [-100..99]
```

### int Random(int max)
Generates a random integer between 0 and the given max, where max is exclusive.
```csharp
_.Random(100); // can be any integer in [0..99]
```

### int Random()
Generates a random integer between 0 and Int32.MaxValue, max bound is exclusive
```csharp
_.Random(); // can be any integer in [0..Integer.MaxValue - 1]
```

## Abs

### int Abs(int i)
Returns the absolute value of the given value (performant implementation).
```csharp
_.Abs(-100); // 100
_.Abs(100); // 100
```

## Min

### int Min(int i)
Returns the smaller of the two given values (performant implementation).
```csharp
_.Min(1, 10); // 1
```

## Max

### int Max(int i)
Returns the larger of the two given values (performant implementation).
```csharp
_.Max(1, 10); // 10
```
