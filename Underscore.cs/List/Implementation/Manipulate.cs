using System;
using System.Collections.Generic;
using System.Threading;

namespace Underscore.List
{
    public class ManipulateComponent : IManipulateComponent, IDisposable
    {
        private ThreadLocal<Random> _rng;

        public ManipulateComponent( ) 
        {
            _rng = new ThreadLocal<Random>( ( ) => new Random( ) ); 
        }

        /// <summary>
        /// Swaps the elements at the specified indexes
        /// </summary>
        public bool Swap<T>( IList<T> list, int i, int j )
        {
            if ( i == j )
                return false;

            var len = list.Count;

            if ( i > len || i < 0 || j > len || j < 0 )
                return false;

            var tmp = list[ i ];
            list[ i ] = list[ j ];
            list[ j ] = tmp;

            return true;

        }

        /// <summary>
        /// Generates a shuffled version of the passed list or , if in place,
        /// shuffles and returns the passed list
        /// </summary>
        public IList<T> Shuffle<T>( IList<T> list, bool inplace )
        {
            var instance = _rng.Value;

            IList<T> ls = null;

            if ( inplace )
                ls = list;
            else
                ls = new List<T>( list );

            int len = ls.Count;
            int swapping = -1;

            for ( int i=0 ; i < len ; i++ )
            {
                swapping = instance.Next( i, ls.Count );
                Swap( ls, i, swapping );

            }

            return ls;

        }

        /// <summary>
        /// Generates a shuffled copy of the passed list
        /// </summary>
        public IList<T> Shuffle<T>( IList<T> list )
        {
            return Shuffle( list, false );
        }

        /// <summary>
        /// Rotates passed list
        /// </summary>
        public void Rotate<T>( IList<T> list, int change ) 
        {
            
            var len = list.Count;

            var shift = ( len + ( change % len ) ) % len;
            
            if(shift == 0)
                return;

            Queue<T> lhs = new Queue<T>( len - shift );
            Queue<T> rhs = new Queue<T>( len - ( len - shift ) );

            int i=0;

            for (; i +shift < len  ; i++ ) 
                lhs.Enqueue( list[ i ] );
            
            for(;i < len ; i++ )
                rhs.Enqueue( list[ i ] );
            

            int j=0;
            
            for ( ; j < len - (len - shift) ; j++ )
                list[ j ] = rhs.Dequeue( );

            for ( ; j < len ; j++ )
                list[ j ] = lhs.Dequeue( );

        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public IList<T> Sample<T>( IList<T> list ) 
        {
            var instance = _rng.Value;

            return Sample( list, instance.Next( 1, list.Count ) );
        }

        /// <summary>
        /// Generates a random sample of items from the passed list 
        /// </summary>
        public IList<T> Sample<T>( IList<T> list, int size ) 
        {
            return Sample( list , size , true );
        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public IList<T> Sample<T>( IList<T> list, int size, bool allUnique ) 
        {
            
            var instance = _rng.Value;
            int len = list.Count;
            var retv = new List<T>( size );


            if ( !allUnique )
                for ( int i=0 ; i < size ; i++ )
                    retv.Add( list[ instance.Next( 0, len - 1 ) ] );
            else
            {
                if ( size > len )
                    throw new InvalidOperationException( "Cannot create a unique sample larger than actual list" );
                var added = new HashSet<int>( );

                for ( int i=0 ; i < size ; i++ )
                {
                    var next = instance.Next( 0, len - 1 );

                    while ( !added.Add( next ) )
                        next = instance.Next( 0, len - 1 );

                    retv.Add( list[ next ] );
                }
            }

            return retv;
        }

        public IEnumerable<T> Extend<T>(IList<T> list, int size)
        {
            for (int i = 0; i < size; i++)
                yield return list[i%list.Count];
        }

        public IEnumerable<T> Cycle<T>(IList<T> list)
        {
            for(int i=0;;i++)
            {
                yield return list[i%list.Count];
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(_rng != null)
                {
                    _rng.Dispose();
                    _rng = null;
                }
            }
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
