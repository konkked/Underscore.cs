using System;
using System.Collections.Generic;
using Underscore.Collection;
using Underscore.Function;
using Underscore.List;
using Underscore.Object.Reflection;
using Underscore.Utility;
using CompactComponent = Underscore.Function.CompactComponent;
using PartitionComponent = Underscore.Collection.PartitionComponent;

namespace Underscore.Extensions
{
    public static class Extensions
    {
        private static readonly Module.Collection _collection = new Module.Collection(
            new CompareComponent(), 
            new CreationComponent(), 
            new DelegationComponent(
                new MethodComponent(
                    new CacheComponent(
                        new CompactComponent(), 
                        new Utility.CompactComponent()
                    ), 
                new PropertyComponent()
                )
            ), 
            new FilterComponent(),
            new MapReduceComponent(),
            new PartitionComponent(
                new List.PartitionComponent(
                    new MathComponent()
                )
            ),
            new SetComponent(), 
            new ZipComponent(), 
            new UnZipComponent()  
        );

        private static readonly Module.List _list = new Module.List(
            new ManipulateComponent(), 
            new List.PartitionComponent(
                new MathComponent()
            )
        );

        private static readonly StringComponent _string = new StringComponent();

        #region Compare
        /// <summary>
        /// checks if a collection is sorted
        /// </summary>
        public static bool IsSorted<T>(this IEnumerable<T> collection, bool descending = false)
            where T : IComparable
        {
            return _collection.IsSorted(collection, descending);
        }
        #endregion

        #region Creation
        /// <summary>
        /// creates a function that always returns a copy of the passed collection at the time it was called
        /// </summary>
        public static Func<IEnumerable<T>> Snapshot<T>(this IEnumerable<T> collection)
        {
            return _collection.Snapshot(collection);
        }

        /// <summary>
        /// Returns an enumerable which cycles through collection until it reaches length iterations
        /// </summary>
        public static IEnumerable<T> Extend<T>(this IEnumerable<T> collection, int length)
        {
            return _collection.Extend(collection, length);
        }

        /// <summary>
        /// Returns an enumerable which cycles through collection infinitely
        /// </summary>
        public static IEnumerable<T> Cycle<T>(this IEnumerable<T> collection)
        {
            return _collection.Cycle(collection);
        }
        #endregion

        #region Delegation
        /// <summary>
        /// attempts to invoke the method with the given name on every object in items
        /// performs a no-op on any objects which do not have the method
        /// </summary>
        public static IEnumerable<object> Invoke<T>(this IEnumerable<T> items, string methodName)
        {
            return _collection.Invoke(items, methodName);
        }

        /// <summary>
        /// attempts to invoke the method with the given name on every object in items,
        /// passing the given arguments to the method when it is called.
        /// performs a no-op on any objects which do not have the method
        /// </summary>
        public static IEnumerable<object> Invoke<T>(this IEnumerable<T> items, string methodName, params object[] arguments)
        {
            return _collection.Invoke(items, methodName, arguments);
        }

        /// <summary>
        /// Resolves an enumerable of functions into an enumerable of the passed function's results
        /// </summary>
        /// <typeparam name="T">Return Type of passed functions</typeparam>
        /// <param name="items">collection of functions</param>
        /// <returns>returns a list of elements</returns>
        public static IEnumerable<T> Resolve<T>(this IEnumerable<Func<T>> items)
        {
            return _collection.Resolve(items);
        }
        #endregion

        #region Filter
        /// <summary>
        /// drops the given number of elements
        /// from the front of the collection
        /// </summary>
        public static IEnumerable<T> Drop<T>(this IEnumerable<T> collection, int count)
        {
            return _collection.Drop(collection, count);
        }

        /// <summary>
        /// Drops elements from the front
        /// of a collection as long
        /// as the predicate is true
        /// </summary>
        public static IEnumerable<T> DropWhile<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return _collection.DropWhile(collection, predicate);
        }

        /// <summary>
        /// Removes any occurrences of 
        /// the specified parameters
        /// from the collection
        /// </summary>
        public static IEnumerable<T> Pull<T>(this IEnumerable<T> collection, params T[] toPull)
        {
            return _collection.Pull(collection, toPull);
        }

        /// <summary>
        /// Takes the given number of elements
        /// from the end of the collection,
        /// ordered as they were in the
        /// original collection
        /// </summary>
        public static IEnumerable<T> TakeRight<T>(this IEnumerable<T> collection, int count)
        {
            return _collection.TakeRight(collection, count);
        }

        /// <summary>
        /// Takes elements from the end of
        /// the collection as long as the
        /// given predicate is true,
        /// ordered as they were in the
        /// original collection
        /// </summary>
        public static IEnumerable<T> TakeRightWhile<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            return _collection.TakeRightWhile(collection, predicate);
        }
        #endregion

        #region MapReduce
        public static IEnumerable<U> Map<T, U>(this IEnumerable<T> collection, Func<T, U> transform)
        {
            return _collection.Map(collection, transform);
        }

        public static U Reduce<T, U>(this IEnumerable<T> collection, Func<U, T, U> reducer)
        {
            return _collection.Reduce(collection, reducer);
        }

        public static U Reduce<T, U>(this IEnumerable<T> collection, U seed, Func<U, T, U> reducer)
        {
            return _collection.Reduce(collection, seed, reducer);
        }
        #endregion

        #region Partition

        /// <summary>
        /// Breaks the collection into smaller chunks based on size
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> collection, int size)
        {
            return _collection.Chunk(collection, size);
        }

        /// <summary>
        /// Breaks the collection into smaller chunks based on hitting elements which match a predicate
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IEnumerable<T> collection, Func<T, bool> on)
        {
            return _collection.Chunk(collection, on);
        }

        /// <summary>
        /// Breaks collection into two seperate parts
        /// split into items before the given index
        /// and items after the given index
        /// 
        /// e.g.
        /// 
        /// Partition([1,2,3,4,5], 2) would return
        /// Tuple([1,2],[3,4,5])
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(this IEnumerable<T> collection, int around)
        {
            return _collection.Partition(collection, around);
        }

        /// <summary>
        /// Breaks collection into two seperate parts,
        /// split into items before an item matches the given predicate
        /// and items after an item matches the given predicate
        /// 
        /// e.g.
        /// 
        /// Partition([1,2,3], n => n == 2) would return
        /// Tuple([1],[2,3])
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(this IEnumerable<T> collection, Func<T, bool> on)
        {
            return _collection.Partition(collection, on);
        }

        /// <summary>
        /// Breaks collection into two seperate parts,
        /// split into items that match the predicate
        /// and items that do not match the predicate
        /// 
        /// e.g.
        /// 
        /// Partition([1,2,3], n => n == 2) would return
        /// Tuple([2],[1,3])
        /// </summary>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(this IEnumerable<T> collection, Func<T, bool> on)
        {
            return _collection.PartitionMatches(collection, on);
        }

        /// <summary>
        /// Returns all combinations of the collection being passed 
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IEnumerable<T> collection)
        {
            return _collection.Combinations(collection);
        }
        #endregion

        #region Set
        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained in one list but not the other
        /// </summary>
        public static IEnumerable<T> Difference<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return _collection.Difference(a, b);
        }

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained in one list but not the other
        /// after both collections have had transform called on them
        /// </summary>
        public static IEnumerable<TResult> DifferenceBy<TArg, TResult>(this IEnumerable<TArg> a, IEnumerable<TArg> b,
            Func<TArg, TResult> transform)
        {
            return _collection.DifferenceBy(a, b, transform);
        }

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained by both lists
        /// </summary>
        public static IEnumerable<T> Intersection<T>(this IEnumerable<T> a, IEnumerable<T> b)
        {
            return _collection.Intersection(a, b);
        }

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained by both collections after
        /// both collections have had transform called on them
        /// </summary>
        public static IEnumerable<TResult> IntersectionBy<TArg, TResult>(this IEnumerable<TArg> a, IEnumerable<TArg> b,
            Func<TArg, TResult> transform)
        {
            return _collection.IntersectionBy(a, b, transform);
        }

        /// <summary>
        /// Returns an enumerable containing all 
        /// elements from both collections after
        /// both collections have had transform called on them
        /// </summary>
        public static IEnumerable<TResult> UnionBy<TArg, TResult>(this IEnumerable<TArg> a, IEnumerable<TArg> b,
            Func<TArg, TResult> transform)
        {
            return _collection.UnionBy(a, b, transform);
        }
        #endregion

        #region Zip

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2>> ZipToTuples<T1, T2>(this IEnumerable<T1> a, IEnumerable<T2> b)
        {
            return _collection.Zip(a, b);
        }

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3>> ZipToTuples<T1, T2, T3>(this IEnumerable<T1> a, IEnumerable<T2> b,
            IEnumerable<T3> c)
        {
            return _collection.Zip(a, b, c);
        }

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4>> ZipToTuples<T1, T2, T3, T4>(this IEnumerable<T1> a,
            IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
        {
            return _collection.Zip(a, b, c, d);
        }

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5>> ZipToTuples<T1, T2, T3, T4, T5>(this IEnumerable<T1> a,
            IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e)
        {
            return _collection.Zip(a, b, c, d, e);
        }

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> ZipToTuples<T1, T2, T3, T4, T5, T6>(
            this IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e,
            IEnumerable<T6> f)
        {
            return _collection.Zip(a, b, c, d, e, f);
        }

        /// <summary>
        /// zips collections together into tuples
        /// of each collections' elements by index
        /// </summary>
        public static IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> ZipToTuples<T1, T2, T3, T4, T5, T6, T7>(
            this IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e,
            IEnumerable<T6> f, IEnumerable<T7> g)
        {
            return _collection.Zip(a, b, c, d, e, f, g);
        }

        /// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		public static Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZipFromTuples<T1, T2>(this IEnumerable<Tuple<T1, T2>> zipped)
        {
            return _collection.UnZip(zipped);
        }

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> UnZipFromTuples<T1, T2, T3>(
            this IEnumerable<Tuple<T1, T2, T3>> zipped)
        {
            return _collection.UnZip(zipped);
        }

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> UnZipFromTuples<T1, T2, T3, T4>(this IEnumerable<Tuple<T1, T2, T3, T4>> zipped)
        {
            return _collection.UnZip(zipped);
        }

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> UnZipFromTuples<T1, T2, T3, T4, T5>(this IEnumerable<Tuple<T1, T2, T3, T4, T5>> zipped)
        {
            return _collection.UnZip(zipped);
        }

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> UnZipFromTuples<T1, T2, T3, T4, T5, T6>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> zipped)
        {
            return _collection.UnZip(zipped);
        }

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        public static Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> UnZipFromTuples<T1, T2, T3, T4, T5, T6, T7>(this IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> zipped)
        {
            return _collection.UnZip(zipped);
        }
        #endregion

        #region List
        #region Manipulate

        /// <summary>
        /// Swaps the elements at the specified indexes
        /// </summary>
        public static bool Swap<T>(this IList<T> list, int i, int j)
        {
            return _list.Swap(list, i, j);
        }

        /// <summary>
        /// Generates a shuffled version of the passed list or, if in place,
        /// shuffles and returns the passed list
        /// </summary>
        public static IList<T> Shuffle<T>(this IList<T> list, bool inPlace = false)
        {
            return _list.Shuffle(list, inPlace);
        }

        /// <summary>
        /// Rotates passed list in place
        /// </summary>
        public static void Rotate<T>(this IList<T> list, int change)
        {
            _list.Rotate(list, change);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public static IList<T> Sample<T>(this IList<T> list)
        {
            return _list.Sample(list);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list of given size
        /// </summary>
        public static IList<T> Sample<T>(this IList<T> list, int size)
        {
            return _list.Sample(list, size);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list of given size,
        /// containing only unique items if passed bool is true
        /// </summary>
        public static IList<T> Sample<T>(this IList<T> list, int size, bool unique)
        {
            return _list.Sample(list, size, unique);
        }

        /// <summary>
        /// Creates an enumerable extending the collection by cycling 
        /// through the items repeatedly until the given size is reached
        /// </summary>
        public static IEnumerable<T> Extend<T>(this IList<T> list, int size)
        {
            return _list.Extend(list, size);
        }

        /// <summary>
        /// Cycles through the given list indefinitely
        /// </summary>
        public static IEnumerable<T> Cycle<T>(this IList<T> list)
        {
            return _list.Cycle(list);
        }
        #endregion

        #region Partition

        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IList<T> list, int size)
        {
            return _list.Chunk(list, size);
        }

        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Chunk<T>(this IList<T> list, Func<T, bool> on)
        {
            return _list.Chunk(list, on);
        }

        /// <summary>
        /// Breaks list into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items elements in list</typeparam>
        /// <param name="list">list to partition</param>
        /// <param name="index">the index to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(this IList<T> list, int index)
        {
            return _list.Partition(list, index);
        }


        /// <summary>
        /// Breaks list into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items elements in list</typeparam>
        /// <param name="list">list to partition</param>
        /// <param name="on">the predicate to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(this IList<T> list, Func<T, bool> on)
        {
            return _list.Partition(list, on);
        }

        /// <summary>
        /// Breaks list into two separate parts based on whether items match a given predicate
        /// </summary>
        /// <param name="on">the predicate to partition on</param>
        /// <returns>A tuple containing matching items in Item1 and non-matching items in Item2</returns>
        public static Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(this IList<T> list, Func<T, bool> on)
        {
            return _list.PartitionMatches(list, on);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <returns>slice of the list</returns>
        public static IList<T> Slice<T>(this IList<T> list, int start, int end)
        {
            return _list.Slice(list, start, end);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list, if the slice is larger than the size of the list
        /// then the items are repeated
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="allowOverflow">specifies if the slice should cycle on overflow</param>
        /// <returns>slice of the list</returns>
        public static IList<T> Slice<T>(this IList<T> list, int start, int end, bool allowOverflow)
        {
            return _list.Slice(list, start, end, allowOverflow);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="step">step by this amount each iteration</param>
        /// <returns>slice of the list</returns>
        public static IList<T> Slice<T>(this IList<T> list, int start, int end, int step)
        {
            return _list.Slice(list, start, end, step);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="step">step by this amount each iteration</param>
        /// <param name="allowOverflow">specifies if the slice should cycle on overflow</param>
        /// <returns>slice of the list</returns>
        public static IList<T> Slice<T>(this IList<T> list, int start, int end, int step, bool allowOverflow)
        {
            return _list.Slice(list, start, end, step, allowOverflow);
        }

        /// <summary>
        /// Splits the list in half
        /// </summary>
        public static Tuple<IList<T>, IList<T>> Split<T>(this IList<T> list)
        {
            return _list.Split(list);
        }

        /// <summary>
        /// Returns an enumerable of all the possible combinations of the passed items
        /// </summary>
        public static IEnumerable<IEnumerable<T>> Combinations<T>(this IList<T> list)
        {
            return _list.Combinations(list);
        }
        #endregion
        #endregion

        #region String
        /// <summary>
		/// Converts the given string to camelCase
		/// </summary>
		public static string ToCamelCase(this string s)
        {
            return _string.ToCamelCase(s);
        }

        /// <summary>
        /// Checks if the given string is camelCase
        /// </summary>
        public static bool IsCamelCase(this string s)
        {
            return _string.IsCamelCase(s);
        }

        /// <summary>
        /// Converts the given string to PascalCase
        /// </summary>
        public static string ToPascalCase(this string s)
        {
            return _string.ToPascalCase(s);
        }

        /// <summary>
        /// Checks if a string is PascalCase
        /// </summary>
        public static bool IsPascalCase(this string s)
        {
            return _string.IsPascalCase(s);
        }

        /// <summary>
        /// Capitalizes the first character of a string
        /// </summary>
        public static string Capitalize(this string s)
        {
            return _string.Capitalize(s);
        }

        /// <summary>
        /// Checks if the first character of a string is capitalized
        /// </summary>
        public static bool IsCapitalized(this string s)
        {
            return _string.IsCapitalized(s);
        }

        /// <summary>
        /// Converts a string to snake_case
        /// </summary>
        public static string ToSnakeCase(this string s)
        {
            return _string.ToSnakeCase(s);
        }

        /// <summary>
        /// Checks if a string is snake_case
        /// </summary>
        public static bool IsSnakeCase(this string s)
        {
            return _string.IsSnakeCase(s);
        }

        /// <summary>
        /// Converts a string to kebab-case
        /// </summary>
        public static string ToKebabCase(this string s)
        {
            return _string.ToKebabCase(s);
        }

        /// <summary>
        /// Checks if a string is kebab-case
        /// </summary>
        public static bool IsKebabCase(this string s)
        {
            return _string.IsKebabCase(s);
        }

        /// <summary>
        /// Converts a string into an enumerable of words,
        /// delimited via spaces. "words" that don't contain letters
        /// are removed, and non-letter characters are removed from
        /// each word
        /// </summary>
        public static IEnumerable<string> Words(this string s)
        {
            return _string.Words(s);
        }
        #endregion
    }
}
