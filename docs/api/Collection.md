# Collection Module
***Note that while these are separated into categories here based on behavior, they are all called from _.Collection***

## Compare
### bool IsSorted\<T\>(IEnumerable\<T\> collection, bool descending = false) where T : IComparable
Checks whether an enumerable of IComparable items is sorted. Can check either ascending or descending, defaults to checking for ascending sort.
```csharp
int[] sortedIntArrAscending = { 1, 2, 3, 4, 5, 6, 7 };
int[] sortedIntArrDescending = { 7, 6, 5, 4, 3, 2, 1 };
int[] unsortedIntArr = { 1, 3, 2, 4, 6, 5, 7 };

_.Collection.IsSorted(sortedIntArrAscending); // true
_.Collection.IsSorted(sortedIntArrAscending, false); // true
_.Collection.IsSorted(sortedIntArrAscending, true); // false

_.Collection.IsSorted(sortedIntArrDescending); // false
_.Collection.IsSorted(sortedIntArrDescending, false); // false
_.Collection.IsSorted(sortedIntArrDescending, true); // true

_.Collection.IsSorted(unsortedIntArr); // false
_.Collection.IsSorted(unsortedIntArr, false); // false
_.Collection.IsSorted(unsortedIntArr, true); // false

string[] sortedStringArr = { "a", "b", "c", "d" };
string[] unsortedStringArr = { "c", "a", "b", "d" };

_.Collection.IsSorted(sortedStringArr); // true
_.Collection.IsSorted(unsortedStringArr); // false
```

## Creation
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

### IEnumerable\<T\> Extend\<T\>(IEnumerable\<T\> collection, int length)
Cycles through the given collection for "length" iterations.
```csharp
_.Collection.Extend(new int[] {1, 2, 3}, 12) // {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3}
```

### IEnumerable\<T\> Cycle\<T\>(IEnumerable\<T\> collection)
Cycles through the given collection infinitely -- will continue cycling lazily as long as you iterate on it.
```csharp
_.Collection.Cycle(new int[] {1, 2, 3}) // {1, 2, 3, 1, 2, 3, 1, 2, 3, 1, 2, 3...}
```

## Delegation
### IEnumerable\<T\> Invoke\<T\>(IEnumerable\<T\> items, string methodName)
Returns an IEnumerable consisting of the results of each item after having the method with name methodName being called.
```csharp
class Foo
{
    private static int counter = 0;
    public int Value;

    public void Bar() {
        value = counter;
        counter++;
    }
}

Foo[] items = new Foo[] {new Foo(), new Foo(), new Foo(), new Foo()}

IEnumerable<Foo> afterInvoke = _.Collection.Invoke(items, "Bar");

afterInvoke.Select(foo => foo.Value); // {1, 2, 3, 4}
```

### IEnumerable\<T\> Invoke\<T\>(IEnumerable\<T\> items, string methodName, params object[] arguments)
Returns an IEnumerable consisting of the results of each item after having the method with name methodName being called with the given arguments.
```csharp
class Foo
{
    public int Value;

    public void Bar(int n) {
        value = n;
    }
}

Foo[] items = new Foo[] {new Foo(), new Foo(), new Foo(), new Foo()}

IEnumerable<Foo> afterInvoke = _.Collection.Invoke(items, "Bar", new object[] {1});

afterInvoke.Select(foo => foo.Value); // {1, 1, 1, 1}
```

### IEnumerable\<T\> Resolve\<T\>(IList\<Func\<T\>\> list)
Executes a list of functions and returns the results
```csharp

Func<int>[] arr = { () => 1, () => 2, () => 3, () => 4 };

int[] resolved = _.List.Resolve(arr); // { 1, 2, 3, 4 }
```

## Filter
### IEnumerable\<T\> Drop\<T\>(IEnumerable\<T\> collection, int count)
Returns a copy of the collection with the given number of items dropped from the front.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.Drop(arr, 3); // { 4, 5, 6, 7, 8, 9 }
```

### IEnumerable\<T\> DropWhile\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> predicate)
Returns a copy of the collection with items dropped from the front until one matched the given predicate.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.DropWile(arr, i => i == 5); // { 5, 6, 7, 8, 9 }
```

### IEnumerable\<T\> Pull\<T\>(IEnumerable\<T\> collection, params T[] toPull)
Returns a copy of the collection with the given items removed.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.Pull(arr, new[] { 1, 3, 5, 7, 9 }); // { 2, 4, 6, 8 }
```

### IEnumerable<T> TakeRight<T>(IEnumerable<T> collection, int count)
Returns a collection with the given number of items taken from the back of the given collection, in order from right to left.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.TakeRight(arr, 3); // { 9, 8, 7 }
```

### IEnumerable<T> TakeRightWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
Returns a collection with items taken from the back of the given collection until the given predicate is matched.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.TakeRightWhile(arr, i => i != 5); // { 9, 8, 7, 6 }
```

## Partition
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

### Tuple\<IEnumerable\<T\>, IEnumerable\<T\>\> PartitionMatches\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> on)
Separates collection into two halves based around items that match predicate and items that do not, where matching items are in the left side of the tuple.
```csharp
_.Collection.PartitionMatches(new int[] {0, 1, 2, 3, 4, 5} , n => n % 2 == 0) // Tuple({0, 2, 4}, {1, 3, 5})
```

## Set
All of these functions return enumerables with no duplicate items.

### IEnumerable\<T\> Difference\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b);
Returns a collection with the objects which are not shared between the two given collections.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Difference(a, b); // { 1, 2, 3, 6, 7 }
```

### IEnumerable\<TResult\> DifferenceBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> with)
Returns a collection with the objects which are not shared between the two given collections.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.DifferenceBy(a, b, i => i % 30); // { 12, 13, 16, 20 }
```

### IEnumerable\<T\> Intersection\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b)
Returns a collection with the objects which are shared by both collections.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Intersection(a, b); // { 4, 5 }
```

### IEnumerable\<TResult\> IntersectionBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> transform)
Returns a collection with the shared outputs of the given function invoked over both collections.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.IntersectionBy(a, b, i => i % 30); // { 10, 14 }
```

### IEnumerable\<T\> Union\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b)
Returns a collection with the objects which are contained in either collection.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Union(a, b); // { 1, 2, 3, 4, 5, 6, 7 }
```

### IEnumerable\<TResult\> UnionBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> transform)
Returns a collection with all of the outputs from invoking the given function over both collections, removing all duplicates.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.UnionBy(a, b, i => i % 30); // { 10, 12, 14, 16, 13, 14, 20 }
```

## Zip

### IEnumerable\<Tuple\<T1, T2\>\> Zip\<T1, T2\>(IEnumerable\<T1\> a, IEnumerable\<T2\> b)
Zips given collections into a collection of tuples,  truncating to the length of the shortest collection given. each tuple has the element from each list at the current index. Can zip up to 7 collections together at once.
```csharp
int[] a {1, 2, 3, 4};
string[] b = {"a", "b", "c", "d"};
char[] c = {'e', 'f', 'g', 'h', 'i', 'j'};

_.Collection.Zip(a, b, c); // {Tuple(1, "a", 'e'), Tuple(2, "b", 'f'), Tuple(3, "c", 'g'), Tuple(4, "d", 'h')}
```

### Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped);
Unzips a collection of tuples into an enumerable for each member of the given tuple. Can unzip tuples of up to length 7.

```csharp
int[] a {1, 2, 3, 4};
string[] b = {"a", "b", "c", "d"};
char[] c = {'e', 'f', 'g', 'h'};

var zipped = _.Collection.Zip(a, b, c); // {Tuple(1, "a", 'e'), Tuple(2, "b", 'f'), Tuple(3, "c", 'g'), Tuple(4, "d", 'h')}

var unzipped = _.Collection.UnZip(zipped) // Tuple({1, 2, 3, 4}, {"a", "b", "c", "d"}, {'e', 'f', 'g', 'h'})
```
