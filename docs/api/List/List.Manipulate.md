# List.Manipulate

***All methods in this section can also be called as extension methods from any IList using Underscore.Extensions***

- [Swap](#swap)
- [Shuffle](#shuffle)
- [Rotate](#rotate)
- [Sample](#sample)

## Swap

### bool Swap\<T\>(IList\<T\> collection, int i,int j)

Swaps two items in a list, returns true if it was successful

``` csharp
var ls = new[]{1,2,3,4};
_.List.Swap(ls, 0, 1); // returns true, ls is now {2,1,3,4}
```

## Shuffle

### IList\<T\> Shuffle\<T\>(IList\<T\> ls)

Returns a list of randomly shuffle items from passed list

``` csharp
_.List.Shuffle(new int[] {1, 2, 3}); // could return {3,2,1} or {2,3,1} or {1,3,2}
```

### IList\<T\> Shuffle\<T\>(IList\<T\> ls, bool inplace)

Returns a list of randomly shuffle items from passed list, if inplace is passed as true shuffling is done in same list and that list is returned

``` csharp
var ls = new int[] {1, 2, 3};
var nls = _.List.Shuffle(ls,true); // could return {3,2,1} or {2,3,1} or {1,3,2}
ls == nls // this will be true
```

## Rotate

### void Rotate\<T\>(IList\<T\> list, int change)

Rotates the passed list in place, if the passed change value is positive values are shifted forward if the change value is negative values are shifted backwards  

```csharp
var ls = new int[]{1, 2, 3};
_.List.Rotate(ls, 2);
// ls is now {3,2,1}
```

## Sample

### IList\<T\> Sample\<T\>(IList\<T\> list)

Generates a random sample from the passed list
```csharp
_.List.Sample(new[]{1, 2, 3}); // could return {3,2,1} or {3,2} or {3} or {2,3,1} or {2,3} etc.
```

### IList\<T\> Sample\<T\>(IList\<T\> list, int size)

Generates a random sample from the passed list of specified size
(by default random sample is unique)
```csharp
_.List.Sample(new[] {1, 2, 3, 4}, 2); // could return {1,2} or {2,3} or {3,4} or {3,2}
```

### IList\<T\> Sample\<T\>(IList\<T\> list, int size, bool unique)

Generates a random sample from the passed list of specified size if unique is true each item in the list will only be used once.
If the size is larger than the size of the list and unique is specified you'll get an invalid operation exception saying that cannot create a unique sample larger than actual list

```csharp
_.List.Sample(new[] {1, 2, 3, 4}, 2, true); // could return {1,2} or {2,3} or {3,4} or {3,2}
_.List.Sample(new[] {1, 2, 3, 4}, 2, false); // could return {1,1} or {1,2} or {2,3} or {3,3}
_.List.Sample(new[] {1, 2, 3, 4}, 8, true); // Throws an exception
```
