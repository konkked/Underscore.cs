# Collection.Filter

***All methods in this section can also be called as extension methods from any IEnumerable using Underscore.Extensions***

- [Drop](#drop)
- [DropWhile](#dropwhile)
- [Pull](#pull)
- [TakeRight](#takeright)
- [TakeRightWhile](#takerightwhile)

## Drop

### IEnumerable\<T\> Drop\<T\>(IEnumerable\<T\> collection, int count)
Returns a copy of the collection with the given number of items dropped from the front.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.Drop(arr, 3); // { 4, 5, 6, 7, 8, 9 }
```

## DropWhile

### IEnumerable\<T\> DropWhile\<T\>(IEnumerable\<T\> collection, Func\<T, bool\> predicate)
Returns a copy of the collection with items dropped from the front until one matched the given predicate.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.DropWile(arr, i => i == 5); // { 5, 6, 7, 8, 9 }
```

## Pull

### IEnumerable\<T\> Pull\<T\>(IEnumerable\<T\> collection, params T[] toPull)
Returns a copy of the collection with the given items removed.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.Pull(arr, new[] { 1, 3, 5, 7, 9 }); // { 2, 4, 6, 8 }
```

## TakeRight

### IEnumerable<T> TakeRight<T>(IEnumerable<T> collection, int count)
Returns a collection with the given number of items taken from the back of the given collection, in order from right to left.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.TakeRight(arr, 3); // { 9, 8, 7 }
```

## TakeRightWhile

### IEnumerable<T> TakeRightWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
Returns a collection with items taken from the back of the given collection until the given predicate is matched.
```csharp
int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

_.Collection.TakeRightWhile(arr, i => i != 5); // { 9, 8, 7, 6 }
```
