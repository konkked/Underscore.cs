# Utility.Function

## Constant

### Func<T> Constant(T value)
Returns a function which always returns the given value
```csharp
int[] values = {1, 2, 3, 4, 5, 6};
var constFunc = _.Utility.Constant(values);

// change all the array values
for(int i = 0; i < values.Length; i++)
    values[i] *= 3;

constFunc(); // {1, 2, 3, 4, 5, 6}
```
