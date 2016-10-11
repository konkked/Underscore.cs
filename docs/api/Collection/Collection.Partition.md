# Collection.Partition

- [Chunk](#chunk)
- [Partition](#partition)
- [PartitionMatches](#partitionmatches)

## Chunk

### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IEnumerable\<T\> collection, int size)
Separates given enumerable into chunks of the given size. If size is not evenly divisible into collection.Count(), the last chunk will have a smaller length of collection.Count() modulo size.
```csharp
// when the list is chunked evenly
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5}, 2) // {{0, 1}, {2, 3}, {4, 5}}

// when the list is chunked unevenly
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, 3) // {{0, 1, 2}, {3, 4, 5}, {6}}
```

### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates given enumerable into chunks based on when items match a predicate, such that each chunk ends on the item before the next matched one (see examples);
```csharp
// when no items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 3000 == 0) // {{0, 1, 2, 3, 4, 5, 6}}

// when some items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 2 == 0) // {{0, 1}, {2, 3}, {4, 5}, {6}}

// when all items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 1 == 0) // {{0}, {1}, {2}, {3}, {4}, {5}, {6}}
```

## Partition

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IEnumerable\<T\> collection, int index)
Separates collection into two halves based around index (item at index is counted as being on right side).
```csharp
_.Collection.Partition(new int[] {0, 1, 2, 3, 4, 5}, 3) // Tuple({0, 1, 2}, {3, 4, 5})
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates collection into two halves based around the first item matching the "on" argument (matched item is counted as being on the right side).
```csharp
_.Collection.Partition(new int[] {0, 1, 2, 3, 4, 5}, n => n % 4 == 0) // Tuple({0, 1, 2, 3}, {4, 5})
```

## PartitionMatches

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> PartitionMatches\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates collection into two halves based around items that match predicate and items that do not, where matching items are in the left side of the tuple.
```csharp
_.Collection.PartitionMatches(new int[] {0, 1, 2, 3, 4, 5} , n => n % 2 == 0) // Tuple({0, 2, 4}, {1, 3, 5})
```
