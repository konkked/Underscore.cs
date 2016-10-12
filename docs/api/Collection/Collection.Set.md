# Collection.Set

***All methods in this section can also be called as extension methods from any IEnumerable using Underscore.Extensions***

***All of these functions return an IEnumerable with no duplicate items.***

- [Difference](#difference)
- [DifferenceBy](#differenceby)
- [Intersection](#intersection)
- [IntersectionBy](#intersectionby)
- [Union](#union)
- [UnionBy](#unionby)

## Difference

### IEnumerable\<T\> Difference\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b);
Returns a collection with the objects which are not shared between the two given collections.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Difference(a, b); // { 1, 2, 3, 6, 7 }
```

## DifferenceBy

### IEnumerable\<TResult\> DifferenceBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> with)
Returns a collection with the objects which are not shared between the two given collections.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.DifferenceBy(a, b, i => i % 30); // { 12, 13, 16, 20 }
```

## Intersection

### IEnumerable\<T\> Intersection\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b)
Returns a collection with the objects which are shared by both collections.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Intersection(a, b); // { 4, 5 }
```

## IntersectionBy

### IEnumerable\<TResult\> IntersectionBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> transform)
Returns a collection with the shared outputs of the given function invoked over both collections.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.IntersectionBy(a, b, i => i % 30); // { 10, 14 }
```

## Union

### IEnumerable\<T\> Union\<T\>(IEnumerable\<T\> a, IEnumerable\<T\> b)
Returns a collection with the objects which are contained in either collection.
```csharp
int[] a = { 1, 2, 3, 4, 5};
int[] b = { 4, 5, 6, 7 };

_.Collection.Union(a, b); // { 1, 2, 3, 4, 5, 6, 7 }
```

## UnionBy

### IEnumerable\<TResult\> UnionBy\<TArg, TResult\>(IEnumerable\<TArg\> a, IEnumerable\<TArg\> b, Func\<TArg, TResult\> transform)
Returns a collection with all of the outputs from invoking the given function over both collections, removing all duplicates.
```csharp
int[] a = {10, 12, 14, 16};
int[] b = {40, 43, 44, 50};

_.Collection.UnionBy(a, b, i => i % 30); // { 10, 12, 14, 16, 13, 14, 20 }
```
