using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface IPartitionComponent 
    {
        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, int size );

        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, Func<T, bool> on );
        
        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, int on );


        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, Func<T,bool> on );
    }

}
