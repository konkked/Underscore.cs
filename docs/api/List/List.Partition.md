# List.Partition

- [Chunk](#chunk)
- [Combinations](#combinations)
- [Partition](#partition)
- [PartitionMatches](#partitionmatches)
- [Slice](#slice)
- [Split](#split)

## Chunk

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

## Combinations

###IEnumerable\<IEnumerable\<T\> Combinations\<T\>(IList\<T\> list)

Returns all possible combinations of items for a list

``` csharp
_.List.Combinations(new[]{1, 2, 3}) // returns { {},{1},{1,2},{2} }
```

## Partition

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

## PartitionMatches

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> PartitionMatches\<T\>(IList\<T\> collection, Func\<T, bool\> on)

Separates list into two halves based around items that match predicate and items that do not, where matching items are in the left side of the tuple.

``` csharp
_.List.PartitionMatches(new int[] {0, 1, 2, 3, 4, 5}, n => n % 2 == 0) // returns Tuple({0, 2, 4}, {1, 3, 5})
```

## Slice

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

## Split

### Tuple\<IList\<T\>,IList\<T\>\> Split\<T\>( IList\<T\> list )

Splits a list in half, with the first half being on the first item, the second half being on the second item

``` csharp
_.List.Split(new[]{1, 2, 3, 4}) //returns ( {1,2} , {3,4} )
```
