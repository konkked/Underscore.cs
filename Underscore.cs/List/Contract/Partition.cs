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
        /// <param name="collection">list to partition</param>
        /// <param name="on">the index to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, int index );


        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, Func<T, bool> on );

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list, if the slice is larger than the size of the list
        /// then the items are repeated
        /// </summary>
        IList<T> Slice<T>( IList<T> list, int start, int end );

        /// <summary>
        /// Splits the list in half
        /// </summary>
        Tuple<IList<T>, IList<T>> Split<T>( IList<T> list );

        /// <summary>
        /// Returns a 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="applying"></param>
        /// <returns></returns>
        IEnumerable<IEnumerable<T>> Combinations<T>(IList<T> list);



    }

}
