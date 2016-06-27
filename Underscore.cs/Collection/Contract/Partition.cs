using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface IPartitionComponent 
    {
        /// <summary>
        /// Breaks the collection into smaller chunks based on size
        /// </summary>
        IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, int size);

        /// <summary>
        /// Breaks the collection into smaller chunks based on hitting elements which match a predicate
        /// </summary>
        IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, Func<T, bool> on);

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
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, int on);


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
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, Func<T,bool> on);

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
		Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IEnumerable<T> collection, Func<T, bool> on);

        /// <summary>
        /// Returns all combinations of the collection being passed 
        /// </summary>
        IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> collection);
    }

}
