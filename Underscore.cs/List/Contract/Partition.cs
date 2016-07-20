using System;
using System.Collections.Generic;

namespace Underscore.List
{

	public interface IPartitionComponent
	{

		
		/// <summary>
		/// Breaks the list into smaller chunks
		/// </summary>
		IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, int size );


		/// <summary>
		/// Breaks the list into smaller chunks
		/// </summary>
		IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, Func<T, bool> on );

		/// <summary>
		/// Breaks list into two seperate parts
		/// </summary>
		/// <typeparam name="T">Type of items elements in list</typeparam>
		/// <param name="list">list to partition</param>
		/// <param name="index">the index to partition on</param>
		/// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
		Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, int index );


		/// <summary>
		/// Breaks list into two seperate parts
		/// </summary>
		/// <typeparam name="T">Type of items elements in list</typeparam>
		/// <param name="list">list to partition</param>
		/// <param name="on">the predicate to partition on</param>
		/// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
		Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, Func<T, bool> on );

		/// <summary>
		/// Breaks list into two separate parts based on whether items match a given predicate
		/// </summary>
		/// <param name="on">the predicate to partition on</param>
		/// <returns>A tuple containing matching items in Item1 and non-matching items in Item2</returns>
		Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>( IList<T> list, Func<T, bool> on );

		/// <summary>
		/// Takes a slice from a list, if start is greater then the end index
		/// the results are reversed, if the index is negative corresponds to the index
		/// from the back of the list
		/// </summary>
		/// <typeparam name="T">The type of the elements in the list</typeparam>
		/// <param name="start">The inclusive start index</param>
		/// <param name="end">The exclusive end index</param>
		/// <returns>slice of the list</returns>
		IList<T> Slice<T>( IList<T> list, int start, int end );



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
		IList<T> Slice<T>(IList<T> list, int start, int end, bool allowOverflow);

		/// <summary>
		/// Splits the list in half
		/// </summary>
		Tuple<IList<T>, IList<T>> Split<T>( IList<T> list );

		/// <summary>
		/// Returns an enumerable of all the possible combinations of the passed items
		/// </summary>
		IEnumerable<IEnumerable<T>> Combinations<T>(IList<T> list);



	}

}
