using System;
using System.Collections.Generic;
using Underscore.Collection;

namespace Underscore.Module
{

    public class Collection :
        ICreationComponent,
        IPartitionComponent,
        IDelegationComponent
    {
        private readonly ICreationComponent _creator;
        private readonly IPartitionComponent _partitioner;
        private readonly IDelegationComponent _delegation;

        public Collection( 
            ICreationComponent creator,
            IPartitionComponent partitioner,
            IDelegationComponent delegation
        )
        {

            if (creator == null)
                throw new ArgumentNullException("creator");

            if (partitioner == null)
                throw new ArgumentNullException("partitioner");

            if (delegation == null)
                throw new ArgumentNullException("delegation");

            _creator = creator;
            _partitioner = partitioner;
            _delegation = delegation;
        }

        /// <summary>
        /// Creates a snapshot of the collection at the time the method was called and can be called to return the value
        /// the collection was at when this method was called
        /// </summary>
        public Func<IEnumerable<T>> Snapshot<T>( IEnumerable<T> collection )
        {
            return _creator.Snapshot( collection );
        }

        /// <summary>
        /// Extends the collection to the specified length
        /// </summary>
        public IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length)
        {
            return _creator.Extend(collection, length);
        }

        /// <summary>
        /// Creates a Cycle from the collection
        /// </summary>
        public IEnumerable<T> Cycle<T>(IEnumerable<T> collection)
        {
            return _creator.Cycle(collection);
        }

        /// <summary>
        /// Breaks the collection into chunks, splitting by size
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, int size )
        {
            return _partitioner.Chunk( collection, size );
        }

        /// <summary>
        /// Breaks the collection into chunks, splitting on the predicate on
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, Func<T, bool> on )
        {
            return _partitioner.Chunk( collection, on );
        }


        /// <summary>
        /// Splits a collection into two halves, first contains all that items before the on index, the second
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, int on )
        {
            return _partitioner.Partition( collection, on );
        }


        /// <summary>
        /// Splits a collection into two halves, first contains all that pass predicate "on", second the ones that don't
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, Func<T, bool> on )
        {
            return _partitioner.Partition( collection, on );
        }

	    public Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IEnumerable<T> collection, Func<T, bool> @on)
	    {
		    return _partitioner.PartitionMatches(collection, on);
	    }

	    /// <summary>
        /// Returns all of the different possible combinations for a collection
        /// </summary>
        public IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> collection)
        {
            return _partitioner.Combinations(collection);
        }

        /// <summary>
        /// Lazily invokes methods by name for each element in the collection
        /// </summary>
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName)
        {
            return _delegation.Invoke(items, methodName);
        }

        /// <summary>
        /// Lazily invokes methods by name for each element in the collection
        /// </summary>
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments)
        {
            return _delegation.Invoke(items, methodName, arguments);
        }


        /// <summary>
        /// Resolves an enumerable of functions into an enumerable of the passed function's results
        /// </summary>
        /// <typeparam name="T">Return Type of passed functions</typeparam>
        /// <param name="items">collection of functions</param>
        /// <returns>returns a list of elements</returns>
        public IEnumerable<T> Resolve<T>(IEnumerable<Func<T>> items)
        {
            return _delegation.Resolve(items);
        }
    }
}
