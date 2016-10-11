# Collection.Compare

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
