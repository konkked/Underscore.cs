# Collection Module
## Creation
### Func\<IEnumerable\<T\>\> Snapshot\<T\>(IEnumerable<T> collection)
Creates a function that always returns a copy of the passed collection at the time it was called.
```
int[] myArray = { 1, 2, 3, 4 };
Func<IEnumerable<int>> myArraySnapshot = _.Collection.Snapshot(myArray);

int[] snapshotResult = myArraySnapshot(); // returns { 1, 2, 3, 4 }

myArray[1] = 30; // myArray is now { 1, 30, 3, 4 }

snapshotResult = myArraySnapshot(); // this still returns { 1, 2, 3, 4 }
```

### IEnumerable\<T\> Extend\<T\>(IEnumerable\<T\> collection, int length)
Cycles through the given collection for "length" iterations.
```
_.Collection.Extend(new int[] {1, 2, 3}, 12) // returns {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}
```

### IEnumerable\<T\> Cycle\<T\>(IEnumerable\<T\> collection)
Cycles through the given collection infinitely -- will continue cycling lazily as long as you iterate on it.
```
_.Collection.Cycle(new int[] {1, 2, 3}) // returns {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3...}
```

## Delegation
### TODO

## Partition
### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IEnumerable\<T\> collection, int size)
Separates given enumerable into chunks of the given size. If size is not evenly divisible into collection.Count(), the last chunk will have a smaller length of collection.Count() modulo size.
```
// when the list is chunked evenly
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5}, 2) // returns {{0, 1}, {2, 3}, {4, 5}}

// when the list is chunked unevenly
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, 3) // returns {{0, 1, 2}, {3, 4, 5}, {6}}
```

### IEnumerable\<IEnumerable\<T\>\> Chunk\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates given enumerable into chunks based on when items match a predicate, such that each chunk ends on the item before the next matched one (see examples);
```
// when no items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 3000 == 0) // returns {{0, 1, 2, 3, 4, 5, 6}}

// when some items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 2 == 0) // returns {{0, 1}, {2, 3}, {4, 5}, {6}}

// when all items match
_.Collection.Chunk(new int[] {0, 1, 2, 3, 4, 5, 6}, n => n % 1 == 0) // returns {{0}, {1}, {2}, {3}, {4}, {5}, {6}}
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IEnumerable\<T\> collection, int index)
Separates collection into two halves based around index (item at index is counted as being on right side).
```
_.Collection.Partition(new int[] {0, 1, 2, 3, 4, 5}, 3) // returns Tuple({0, 1, 2}, {3, 4, 5})
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> Partition\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates collection into two halves based around the first item matching the "on" argument (matched item is counted as being on the right side).
```
_.Collection.Partition(new int[] {0, 1, 2, 3, 4, 5}, n => n % 4 == 0) // returns Tuple({0, 1, 2, 3}, {4, 5})
```

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> PartitionMatches\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates collection into two halves based around items that match predicate and items that do not, where matching items are in the left side of the tuple.
```
_.Collection.PartitionMatches(new int[] {0, 1, 2, 3, 4, 5}, n => n % 2 == 0) // returns Tuple({0, 2, 4}, {1, 3, 5})
```
