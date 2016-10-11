# List.Creation

- [Extend](#extend)
- [Cycle](#cycle)

## Extend

### IEnumerable\<T\> Extend\<T\>(IList\<T\> list, int size)

Creates an enumerable from the content of the passed list with the specified size

```csharp
_.List.Extend(new[] {1, 2, 3, 4}, 10); // returns { 1,2,3,4,1,2,3,4,1,2}
```

## Cycle

### IEnumerable\<T\> Cycle\<T\>(IList\<T\> list)

Creates an infinitely long enumerable from the content of the passed list

```csharp
_.List.Cycle(new[] {1, 2, 3, 4}); // returns {1,2,3,4,1,2,3,4,1,2,3,4....... infinitely}
```
