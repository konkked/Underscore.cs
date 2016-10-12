# Function.Boolean

- [And](#and)
- [Negate](#negate)
- [Or](#or)

## And

### Func<bool> And(params Func<bool>[] fns)
```
bool[] wasCalled = {false, false, false};
Func<bool> func1 = () => (wasCalled[0] = true) && true;
Func<bool> func2 = () => (wasCalled[1] = true) && false;
Func<bool> func3 = () => (wasCalled[2] = true) && true;

var orCombined = _.Function.And(func1, func2, func3);

onCombined(); // false
wasCalled; // {true, true, false}
```

## Negate

### Func\<T1, bool\> Negate(Func<T1, bool> toNegate)
Returns a function which returns the opposite of toNegate whenever it is called;
```
Func<string, string, bool> equals = (a, b) => a == b;
Func<string, string, bool> notEquals = _.Function.Negate(equals);

equals("foo", "foo"); // true
notEquals("foo", "foo"); // false

equals("foo", "bar"); // false
notEquals("foo", "bar"); // true
```

## Or

### Func<bool> Or(params Func<bool>[] fns)
Returns a function which aggregates the results of all the given functions as a logical "or" does, including short-circuiting to avoid processing functions more than necessary
```
bool[] wasCalled = {false, false, false};
Func<bool> func1 = () => (wasCalled[0] = true) && false;
Func<bool> func2 = () => (wasCalled[1] = true) && true;
Func<bool> func3 = () => (wasCalled[2] = true) && false;

var orCombined = _.Function.Or(func1, func2, func3);

onCombined(); // true
wasCalled; // {true, true, false}
```
