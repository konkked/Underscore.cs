using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{


    public class PartitionComponent : IPartitionComponent
    {

        private IEnumerable<T> Segment<T>( IEnumerator<T> iter, int size, out bool cont )
        {
            var ret= new List<T>( );
            cont = true;
            bool hit = false;
            for ( var i=0 ; i < size ; i++ )
            {
                if ( iter.MoveNext( ) )
                {
                    hit = true;
                    ret.Add( iter.Current );
                }
                else
                {
                    cont = false;
                    break;
                }
            }

            return hit ? ret : null;
        }

        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, int size )
        {

            bool shouldContinue = collection!=null && collection.Any();

            using ( var iter = collection.GetEnumerator( ) )
            {
                while ( shouldContinue )
                {
                    //iteration of the enumerable is done in segment
                    var result = Segment( iter, size, out shouldContinue );
                    
                    if ( shouldContinue || result != null )
                        yield return result;
                    
                    else yield break;
                }
            }

        }

        private IEnumerable<T> Segment<T>( IEnumerator<T> iter, Func<T, bool> on, out bool cont )
        {
            var ret = new List<T>( );
            cont = true;

            while ( iter.MoveNext( ) )
            {
                if ( on( iter.Current ) )
                    return ret;
                else
                    ret.Add( iter.Current );

                return ret;
            }

            cont = false;
            return ret;
        }

        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>( IEnumerable<T> collection, Func<T, bool> on )
        {

            using ( var iter = collection.GetEnumerator( ) )
            {
                bool shouldContinue = iter.MoveNext();
                var retv = new List<T>();
                while ( shouldContinue ) 
                {
                    //dont include empty lists
                    if ( on( iter.Current ) && retv.Count!=0)
                    {
                        yield return retv;
                        retv = new List<T>( );
                        retv.Add( iter.Current );
                    }
                    else 
                    {
                        retv.Add( iter.Current );
                    }

                    shouldContinue = iter.MoveNext( );
                }

                if ( retv.Count != 0 )
                    yield return retv;
                else
                    yield break;
            }
        }

        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, int on )
        {
            bool shouldContinue=true;
            var left = new List<T>( );
            var right = new List<T>( );
            using ( var iter = collection.GetEnumerator( ) )
            {
                int i = 0;

                while ( i != on )
                {
                    i++;
                    if ( iter.MoveNext( ) )
                    {
                        left.Add( iter.Current );
                    }
                    else
                    {
                        shouldContinue = false;
                        break;
                    }
                }

                if ( shouldContinue )
                {
                    while ( iter.MoveNext( ) )
                    {
                        right.Add( iter.Current );
                    }
                }
            }

            return Tuple.Create(
                left as IEnumerable<T>,
                right as IEnumerable<T>
            );
        }

        /// <summary>
        /// Breaks collection into two seperate parts
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>( IEnumerable<T> collection, Func<T, bool> on )
        {
            bool shouldContinue=true;
            var left = new List<T>( );
            var right = new List<T>( );
            using ( var iter = collection.GetEnumerator( ) )
            {
                while ( true )
                {
                    if ( iter.MoveNext( ) )
                    {
                        left.Add( iter.Current );

                        if ( on( iter.Current ) ) 
                        {
                            break;
                        }
                    }
                    else
                    {
                        shouldContinue = false;
                        break;
                    }
                }

                if ( shouldContinue )
                {
                    while ( iter.MoveNext( ) )
                    {
                        right.Add( iter.Current );
                    }
                }
            }

            return Tuple.Create(
                left as IEnumerable<T>,
                right as IEnumerable<T>
            );
        }

    }
}
