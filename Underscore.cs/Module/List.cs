using System;
using System.Collections.Generic;
using Underscore.List;

namespace Underscore.Module
{


    public class List : 
        IDelegateComponent,
        IManipulateComponent,
        IPartitionComponent
    {
        private readonly IManipulateComponent _manipulator;
        private readonly IPartitionComponent _partitioner;
        private readonly IDelegateComponent _delegator;

        public List( 
            IDelegateComponent delegator,
            IManipulateComponent manipulator,
            IPartitionComponent partitioner
        ) 
        {
            _delegator = delegator;
            _manipulator = manipulator;
            _partitioner = partitioner;
        }

        public IList<T> Resolve<T>( IList<Func<T>> target )
        {
            return _delegator.Resolve( target );
        }

        public IList<Func<T>> Delegate<T>( IList<T> target )
        {
            return _delegator.Delegate( target );
        }

        public bool Swap<T>( IList<T> list, int i, int j )
        {
            return _manipulator.Swap( list, i, j );
        }

        public IList<T> Shuffle<T>( IList<T> list, bool inPlace )
        {
            return _manipulator.Shuffle( list, inPlace );
        }

        public IList<T> Shuffle<T>( IList<T> list )
        {
            return _manipulator.Shuffle( list );
        }

        public void Rotate<T>( IList<T> list, int change )
        {
            _manipulator.Rotate( list, change );
        }

        public IList<T> Sample<T>( IList<T> list )
        {
            return _manipulator.Sample( list );
        }

        public IList<T> Sample<T>( IList<T> list, int size )
        {
            return _manipulator.Sample( list, size );
        }

        public IList<T> Sample<T>( IList<T> list, int size, bool unique )
        {
            return _manipulator.Sample( list, size, unique );
        }

        public IList<T> Slice<T>( IList<T> list, int start, int end )
        {
            return _partitioner.Slice( list, start, end );
        }

        public Tuple<IList<T>, IList<T>> Split<T>( IList<T> list )
        {
            return _partitioner.Split( list );
        }

        public IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, int size )
        {
            return _partitioner.Chunk( list, size );
        }

        public IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, Func<T, bool> on )
        {
            return _partitioner.Chunk( list, on );
        }

        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, int index )
        {
            return _partitioner.Partition( list, index );
        }

        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, Func<T, bool> on )
        {
            return _partitioner.Partition( list, on );
        }
    }
}
