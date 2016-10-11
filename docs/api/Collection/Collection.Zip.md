# Collection.Zip

- [Zip](#zip)
- [UnZip](#unzip)

## Zip

### IEnumerable\<Tuple\<T1, T2\>\> Zip\<T1, T2\>(IEnumerable\<T1\> a, IEnumerable\<T2\> b)
Zips given collections into a collection of tuples,  truncating to the length of the shortest collection given. each tuple has the element from each list at the current index. Can zip up to 7 collections together at once.
```csharp
int[] a {1, 2, 3, 4};
string[] b = {"a", "b", "c", "d"};
char[] c = {'e', 'f', 'g', 'h', 'i', 'j'};

_.Collection.Zip(a, b, c); // {Tuple(1, "a", 'e'), Tuple(2, "b", 'f'), Tuple(3, "c", 'g'), Tuple(4, "d", 'h')}
```

## UnZip

### Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped);
Unzips a collection of tuples into an enumerable for each member of the given tuple. Can unzip tuples of up to length 7.

```csharp
int[] a {1, 2, 3, 4};
string[] b = {"a", "b", "c", "d"};
char[] c = {'e', 'f', 'g', 'h'};

var zipped = _.Collection.Zip(a, b, c); // {Tuple(1, "a", 'e'), Tuple(2, "b", 'f'), Tuple(3, "c", 'g'), Tuple(4, "d", 'h')}

var unzipped = _.Collection.UnZip(zipped) // Tuple({1, 2, 3, 4}, {"a", "b", "c", "d"}, {'e', 'f', 'g', 'h'})
```
