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
        /// <param name="index">the index to partition on</param>
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
        /// <param name="on">the condition to partition</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second, the element partitioned will be the first element of the second partition </returns>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IList<T> list, Func<T, bool> on ) 
        {
            for ( int i=0 ; i < list.Count ; i++ )
                if ( on( list[ i ] ) )
                    return Partition( list, i );

            return Tuple.Create( new T[ ] { } as IEnumerable<T>, new List<T>( list ) as IEnumerable<T>);
        }

        /// <summary>
        /// Splits enumerable into two seperate collections based off of the passed func, all items passing the condition 
        /// are placed in the first item in the tuple and the others placed in the second item in the tuple
        /// </summary>
        /// <typeparam name="T">Type of the items in the enumerable</typeparam>
        /// <param name="on">the condition to partition using</param>
        /// <returns>a tuple containing items passing the condition on the Item1 and the other items in Item2</returns>
	    public Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IList<T> list, Func<T, bool> on)
	    {
			var left = new List<T>();
		    var right = new List<T>();

		    for (var i = 0; i < list.Count; i++)
		    {
			    if(on(list[i]))
					left.Add(list[i]);
			    else
					right.Add(list[i]);
		    }

		    return Tuple.Create(
			    (IEnumerable<T>) left,
			    (IEnumerable<T>) right
			);
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
        public IList<T> Slice<T>(IList<T> list, int start, int end)
        {
            return Slice(list, start, end, false);
        }


        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="step">The increase of the index</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end, int step)
        {
            return Slice(list, start, end, step,false);
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
        public IList<T> Slice<T>(IList<T> list, int start, int end, bool allowOverflow)
        {
            return SliceImpl(list, start, end, allowOverflow, null);
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
        /// <param name="step">The step of the index</param>
        /// <param name="allowOverflow">specifies if the slice should cycle on overflow</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end, int step, bool allowOverflow)
        {
           
            return SliceImpl(list, start, end,allowOverflow,step);
        }


        private IList<T> SliceImpl<T>( IList<T> list, int start, int end, bool allowOverflow, int? pstep )
        {


            if (!allowOverflow)
            {
                if (start < -list.Count)
                {
                    throw new IndexOutOfRangeException(
                        "start index value must be greater than or equal to -list.Count unless allowOverflow option is used, actual value was " +
                        start);
                }

                if (start >= list.Count)
                {
                    throw new IndexOutOfRangeException(
                        "start index value must be less than list.Count unless allowOverflow option is used, actual value was " +
                        start);
                }

                if (end < -list.Count)
                {
                    throw new IndexOutOfRangeException(
                        "end index value must be greater than or equal to -list.Count unless allowOverflow option is used, actual value was " +
                        end);
                }


                if (end >= list.Count)
                {
                    throw new IndexOutOfRangeException(
                        "end index value must be less than list.Count unless allowOverflow option is used, actual value was " +
                        end);
                }

                if ((start < 0 && end >= 0) || (start >= 0 && end < 0))
                {
                    throw new InvalidOperationException(
                        "When using a negative index both values must be negative, actual values were " + start +
                        " for start and " + end + " for end");
                }

            }

            int count = list.Count;
            var len = ( end - start );
            
            T[] returning;
            
            //creates an offset for handling negative indexes
            int offset = ( ( _math.Max( _math.Abs( start ), _math.Abs( end )  )   / count ) + 1 ) * count;

            if(pstep.HasValue && pstep.Value == 0)
                throw new InvalidOperationException("Cannot have a zero value step");

            int step = 1;
            //when the len is negative we are going backwards
            if ( len < 0 )
            {

                if (pstep.HasValue)
                {
                    //if we are going backwards and a value was passed
                    //the value has to be negative or we're going to 
                    //throw an invalid operation exception
                    if(pstep.Value>=0)
                        throw new InvalidOperationException("Cannot have a backwards slice with a forward (postive) step, value passed " + pstep.Value);

                    step = -pstep.Value;
                }

                if (len % step == 0)
                    len /= step;
                else
                    len = (len / step) - 1;
                
                len = -len;

                returning = new T[ len ];
                

                int j =0;
                for ( int i=start ; i > end ; i-=step )
                {
                    returning[j] = list[ ( i + offset ) % count ];
                    j++;
                }

            }
            else if (len > 0)
            {

                if (pstep.HasValue)
                {
                    //if we are going forwards and the passed step is negative
                    //will throw an exception 
                    if (pstep.Value <= 0)
                        throw new InvalidOperationException("Cannot have a forward slice with a backwards (negative) step, value passed " + pstep.Value);

                    step = pstep.Value;
                }

                if (len % step == 0)
                    len /= step;
                else
                    len = (len / step) + 1;

                returning = new T[len];
                
                if (step < 0)
                {
                    var t = start;
                    start = end;
                    end = t;
                    step = -step;
                }

                int j = 0;
                for (int i = start; i < end; i+=step)
                {
                    returning[j] = list[ (i + offset ) % count ];
                    j++;
                }

            }
            else
            {
                returning = new T[] {};
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

        /// <summary>
        /// Creates an enumerable with all of the possible combinations of the list in it
        /// </summary>
        public IEnumerable<IEnumerable<T>> Combinations<T>(IList<T> list)
        {
            if(list== null) throw new ArgumentNullException("list");

            yield return new T[] {};

            foreach (var value in CombinationsImpl(list))
                yield return value;
        }


        private IEnumerable<IEnumerable<T>> CombinationsImpl<T>(IList<T> collection, int index = -1)
        {
            //initialize the index to the last index of the list
            if (index <= -1)
                index = collection.Count - 1;

            //yield a collection with just the first item in it 
            if (index == 0)
                return new List<IEnumerable<T>> { new[] { collection[0] } };

            //get all of the items after this item
            // ( Recursive call )
            var permutations = CombinationsImpl(collection, index - 1).ToList();
            
            //return a collection of items with and without the item at the current index
            return permutations.Concat(permutations.Select(a => a.Concat(new[] { collection[index] })).Concat(new[] { new[] { collection[index] } }));
        }

    }
}
