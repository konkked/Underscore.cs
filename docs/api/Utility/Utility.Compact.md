# Utility.Compact

## Pack

### Tuple\<\<Tuple\<T1, T2, T3, T4\>, T5\> Pack(T1 a, T2 b, T3 c, T4 d, T5 e)
Packs given arguments into tuples, grouped by each 4 arguments. Can take any number of arguments from 1-16, inclusive. If passed 4 or fewer arguments, just packs the given arguments into a single non-nested tuple. If given more than 4 arguments, any arguments that can't be packed into a sub-tuple of 4 are added as extra items to the main tuple (see example).
```csharp
_.Utility.Pack(1, 2, 3, 4, 5); // returns Tuple(Tuple(1, 2, 3, 4), 5)
```
