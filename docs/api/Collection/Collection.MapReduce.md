# Collection.MapReduce

***All methods in this section can also be called as extension methods from any IEnumerable using Underscore.Extensions***

## Map

### IEnumerable<U> Map<T, U>(IEnumerable<T> collection, Func<T, U> transform)
Maps a collection to a new collection using the given transformation function, like underscore.js's map or LINQ's Select.
```cs
IEnumerable<int> target = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.Map(target, i => i * 2); // [ 2, 4, 6, 8, 10, 12, 16, 18]
```

## Reduce
Reduces a collection to a single value using the given reduction function, like underscore.js's map, LINQ's Aggregate or haskell's fold. If no seed value (starting value for reduction) is given to the function, the default of the return value is used. If the return value is a reference type and no seed is provided, the default constructor is used to create it. As such, any reductions to a reference type must either have a seed provided or reduce to a type that has a default constructor.
```cs
class ReduceTester
{
    public int Value { get; private set; }

    public ReduceTester()
    {
        Value = 0;
    }

    public ReduceTester Add(int n)
    {
        Value += n;

        return this;
    }
}

IEnumerable<int> target = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

var valResult = _.Collection.Reduce(target, (int total, int next) => total + next)
valResult // 45

// reference type no seed
var refResult = _.Collection.Reduce(target, (ReduceTester total, int next) => total.Add(next));
refResult.Value // 45

// reduction using seed
var seedResult = _.Collection.Reduce(target, "", (total, next) => total + next);
seedResult // "123456789"
```
