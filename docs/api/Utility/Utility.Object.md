# Utility.Object

## IsTruthy

### bool IsTruthy(object target)
Returns false if target object is the default of its type, with the exception of strings which return false on empty, whitespace or null.
```csharp
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
