using System;
using System.Collections.Generic;
using Underscore.Collection;

namespace Underscore.Module
{

    public class Collection :
        ICreationComponent,
        IPartitionComponent
    {
        private readonly ICreationComponent _creator;
        private readonly IPartitionComponent _partitioner;

        public Collection( 
            ICreationComponent creator,
            IPartitionComponent partitioner
        )
        {
            _creator = creator;
            _partitioner = partitioner;
        }


        public Func<IEnumerable<T>> Snapshot<T>( IEnumerable<T> collection )
        {
            return _creator.Snapshot( collection );
        }

        public IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length)
        {
            return _creator.Extend(collection, length);
        }

        public IEnumerable<T> Cycle<T>(IEnumerable<T> collection)
        {
            return _creator.Cycle(collection);
        }


        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, int size )
        {
            return _partitioner.Chunk( collection, size );
        }

        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, Func<T, bool> on )
        {
            return _partitioner.Chunk( collection, on );
        }

        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, int on )
        {
            return _partitioner.Partition( collection, on );
        }


        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, Func<T, bool> on )
        {
            return _partitioner.Partition( collection, on );
        }

        public IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> collection)
        {
            return _partitioner.Combinations(collection);
        }
    }
}
