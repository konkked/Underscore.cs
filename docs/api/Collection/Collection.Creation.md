# Collection.Creation

- [Snapshot](#snapshot)
- [Extend](#extend)
- [Cycle](#cycle)

## Snapshot

### Func\<IEnumerable\<T\>\> Snapshot\<T\>(IEnumerable<T> collection)
Creates a function that always returns a copy of the passed collection at the time it was called.
```csharp
int[] arr = { 1, 2, 3, 4 };
Func<IEnumerable<int>> snapshot = _.Collection.Snapshot(arr);

int[] snapshotResult = snapshot(); // { 1, 2, 3, 4 }

// change arr
arr[1] = 30;

snapshotResult = snapshot(); // { 1, 2, 3, 4 }
```

## Extend

### IEnumerable\<T\> Extend\<T\>(IEnumerable\<T\> collection, int length)
Cycles through the given collection for "length" iterations.
```csharp
_.Collection.Extend(new int[] {1, 2, 3}, 12) // {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}
```

## Cycle

### IEnumerable\<T\> Cycle\<T\>(IEnumerable\<T\> collection)
Cycles through the given collection infinitely -- will continue cycling lazily as long as you iterate on it.
```csharp
_.Collection.Cycle(new int[] {1, 2, 3}) // {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3...}
```
