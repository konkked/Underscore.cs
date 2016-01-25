using System;
using System.Collections.Generic;
using System.Linq;
using Underscore.Utility;

namespace Underscore.List
{

    public class PartitionComponent : IPartitionComponent
    {
        private readonly IMathComponent _math;

        public PartitionComponent( IMathComponent math ) 
        {
            _math = math;
        }

        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, int size )
        {
            int len = list.Count;

            if ( len < size ) 
            {
                var copy = new T[ list.Count ];
                list.CopyTo( copy, 0 );

                return new[]{ copy };
            }

            var partCount = list.Count / size;
            
            if ( list.Count % size != 0 )
                partCount++;

            return Enumerable.Range( 0, partCount )
                .Select(
                    chunkIndex =>{
                        
                        var chunkSize = size ;
                        var chunkEndLen = (chunkIndex+1)*size ;

                        if( chunkEndLen > len )
                        {
                            chunkSize =  len - ( chunkEndLen - size ) ;
                        }

                        return Enumerable.Range( 0, chunkSize )
                            .Select( b => list[ ( chunkIndex * size ) + b ] );
                    }
                );
        }

        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IList<T> list, Func<T, bool> on )
        {
            var curr = new List<T>( );

            for ( int i=0 ; i < list.Count ; i++ )
            {
                for ( ; i < list.Count && !on( list[ i ] ) ; i++ )
                {
                    curr.Add( list[ i ] );
                }

                if ( i >= list.Count )
                    break;

                yield return curr;

                curr = new List<T>( );
                //the instance that was broken on
                //
                curr.Add( list[ i ] );
            }

            if ( curr.Count != 0 )
                yield return curr;
        }

        /// <summary>
        /// Breaks list into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items elements in list</typeparam>
        /// <param name="collection">list to partition</param>
        /// <param name="on">the index to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, int index )
        {
            return Tuple.Create(
                   Enumerable.Range( 0, index ).Select( a => list[ a ] ),
                   Enumerable.Range( index, list.Count - ( index ) ).Select( a => list[ a ] )
            );
        }

        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items in collection</typeparam>
        /// <param name="collection">collection to partition</param>
        /// <param name="on">the condition to partition</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second, the element partitioned will be the first element of the second partition </returns>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, Func<T, bool> on ) 
        {
            for ( int i=0 ; i < list.Count ; i++ )
                if ( on( list[ i ] ) )
                    return Partition<T>( list, i );

            return Tuple.Create( new T[ ] { } as IEnumerable<T>, new List<T>( list ) as IEnumerable<T>);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list, if the slice is larger than the size of the list
        /// then the items are repeated
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="list">The list to take the slice from</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>( IList<T> list, int start, int end )
        {
            int count = list.Count;
            var len = end - start;
            T[] returning;

            int offset = ( ( _math.Max( _math.Abs( start ), _math.Abs( end ) ) / count ) + 1 ) * count;

            if ( len < 0 )
            {
                len = -len;
                len++;

                returning = new T[ len ];

                int j=0;


                //shift left
                for ( int i=start ; i >= end ; i-- )
                {
                    returning[ j++ ] = list[ ( i + offset ) % count ];
                }
            } else 
            {
                len ++;
                returning = new T[ len ];

                int j=0;
                for ( int i=start ; i <= end ; i++ ) 
                {
                    returning[ j++ ] = list[ ( i + offset ) % count ];

                }
            }

            return returning;

        }

        /// <summary>
        /// Splits the list in half
        /// </summary>
        /// <typeparam name="T">The elements of the list</typeparam>
        /// <param name="list">the list to be split</param>
        /// <returns>Tuple containing the two halves of the list</returns>
        public Tuple<IList<T>, IList<T>> Split<T>( IList<T> list )
        {
            var til = list.Count / 2;
            if ( list.Count % 2 == 0 )
                til--;
            return Tuple.Create( new List<T>( Enumerable.Range( 0, til + 1 ).Select( a => list[ a ] ) ) as IList<T>,
                new List<T>( Enumerable.Range( til + 1, list.Count - ( til + 1 ) ).Select( a => list[ a ] ) ) as IList<T>
            );
        }

        public IEnumerable<IEnumerable<T>> Combinations<T>(IList<T> list)
        {
            if(list== null) throw new ArgumentNullException("list");

            yield return new T[] {};

            foreach (var value in NonEmptyPermutate(list))
                yield return value;
        }


        private IEnumerable<IEnumerable<T>> NonEmptyPermutate<T>(IList<T> collection, int index = -1)
        {
            if (index <= -1)
                index = collection.Count - 1;

            if (index == 0)
                return new List<IEnumerable<T>> { new[] { collection[0] } };

            var permutations = NonEmptyPermutate(collection, index - 1).ToList();
            return permutations.Concat(permutations.Select(a => a.Concat(new[] { collection[index] })).Concat(new[] { new[] { collection[index] } }));
        }

    }
}
