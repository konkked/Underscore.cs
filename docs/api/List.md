# List Module
***Note that while these are separated into categories here based on behavior, they are all called from _.List***

***All methods in this section can also be called as an extension method from any IList using Underscore.Extensions***

# Manipulate

### bool Swap\<T\>(IList\<T\> collection, int i,int j)

Swaps two items in a list, returns true if it was successful

``` csharp
var ls = new[]{1,2,3,4};
_.List.Swap(ls, 0, 1); // returns true, ls is now {2,1,3,4}
```

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

### void Rotate\<T\>(IList\<T\> list, int change)

rotates the passed list, if the passed change value is positive values are shifted forward if the change value is negative values are shifted backwards  

```csharp
var ls = new int[]{1, 2, 3};
_.List.Rotate(ls, 2);
//ls is now {3,2,1}
```


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

### IEnumerable\<T\> Extend\<T\>(IList\<T\> list, int size)

Creates an enumerable from the content of the passed list with the specified size

```csharp
_.List.Extend(new[] {1, 2, 3, 4}, 10); // returns { 1,2,3,4,1,2,3,4,1,2}
```

### IEnumerable\<T\> Cycle\<T\>(IList\<T\> list)

Creates an infinitely long enumerable from the content of the passed list

```csharp
_.List.Cycle(new[] {1, 2, 3, 4}); // returns {1,2,3,4,1,2,3,4,1,2,3,4....... infinitely}
```

## Partition
### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IList\<T\> list, int size)

Separates list into chunks of the passed size. If size is not evenly divisible into list.Count, the last chunk will have a smaller length of list.Count modulo size.

``` csharp
// when the list is chunked into smaller collections of size 2
_.List.Chunk(new int[] {0, 1, 2, 3, 4, 5}, 2) // returns {{0, 1}, {2, 3}, {4, 5}}

// when the list is chunked into smaller collections of size 3
_.List.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, 3) // returns {{0, 1, 2}, {3, 4, 5}, {6}}
```

### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IList\<T\> list, Func\<T, bool\> on)

Separates list into chunks based on when items match a predicate, such that each chunk ends on the item before the next matched one (see examples)

``` csharp
// when no items match
_.List.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 3000 == 0) // returns {{0, 1, 2, 3, 4, 5, 6}}

// when some items match
_.List.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 2 == 0) // returns {{0, 1}, {2, 3}, {4, 5}, {6}}

// when all items match
_.List.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 1 == 0) // returns {{0}, {1}, {2}, {3}, {4}, {5}, {6}}
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IList\<T\> collection, int index)

Separates list into two halves based around index (item at index is counted as being on right side).

``` csharp
_.List.Partition(new int[] {0, 1, 2, 3, 4, 5}, 3) // returns Tuple({0, 1, 2}, {3, 4, 5})
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IList\<T\> collection, Func\<T, bool\> on)

Separates list into two halves based around the first item matching the "on" argument (matched item is counted as being on the right side).

``` csharp
_.List.Partition(new int[] {0, 1, 2, 3, 4, 5}, n => n % 4 == 0) // returns Tuple({0, 1, 2, 3}, {4, 5})
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> PartitionMatches\<T\>(IList\<T\> collection, Func\<T, bool\> on)

Separates list into two halves based around items that match predicate and items that do not, where matching items are in the left side of the tuple.

``` csharp
_.List.PartitionMatches(new int[] {0, 1, 2, 3, 4, 5}, n => n % 2 == 0) // returns Tuple({0, 2, 4}, {1, 3, 5})
```

### IList\<T\> Slice\<T\>(IList\<T\> list, int start, int end)

Takes a slice from a list from start index to end index

``` csharp
//positive increasing indexes
_.List.Slice(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 0, 3) // returns {1,2,3,4}

//positive increasing indexes
_.List.Slice(new[] {1, 2, 3, 4, 5, 6, 7, 8, 9}, 3, 0) // returns {4,3,2,1}

//postive overflow index wrap around
_.List.Slice(new[]{1, 2, 3, 4}, 0, 6) //returns {1,2,3,4,1,2,3}

//negative underflow index wrap around
_.List.Slice(new[]{1, 2, 3, 4}, -6, 0) //returns{3,4,1,2,3,4,1}

//negative index wrap around
_.List.Slice(new[]{1, 2, 3, 4}, -1, -2) //returns last two items from list {4,3}
```

### Tuple\<IList\<T\>,IList\<T\>\> Split\<T\>( IList\<T\> list )

Splits a list in half, with the first half being on the first item, the second half being on the second item

``` csharp
_.List.Split(new[]{1, 2, 3, 4}) //returns ( {1,2} , {3,4} )
```


###IEnumerable\<IEnumerable\<T\> Combinations\<T\>(IList\<T\> list)

Returns all possible combinations of items for a list

``` csharp
_.List.Combinations(new[]{1, 2, 3}) // returns { {},{1},{1,2},{2} }
```
