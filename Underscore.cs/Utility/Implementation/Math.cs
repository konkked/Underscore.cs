using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Underscore.Utility
{
    public class MathComponent : IMathComponent
    {
        private HashSet<string> _sharedUuidChecker;
        private Random _random;


        public MathComponent( ) 
        {
            _sharedUuidChecker = new HashSet<string>( );
            _random = new Random( );
        }

        private bool InternalIsUnique( string uuid )
        {
            return _sharedUuidChecker.Add( uuid );
        }

        private bool IsUnique( string uuid )
        {
            return _sharedUuidChecker.Add( uuid );
        }

        /// <summary>
        /// Generates a unique id
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string UniqueId( string prefix )
        {
            string retv = null;

            do
            {
                retv = prefix + "_" + UniqueId( );
            } while ( !InternalIsUnique( retv ) );

            return retv;
        }

        /// <summary>
        /// Generates a unique id string
        /// </summary>
        /// <returns></returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public string UniqueId( )
        {
            return Guid.NewGuid( ).ToString( "B" ).ToUpper( );
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <param name="min">Min possible value</param>
        /// <param name="max">Max possible value</param>
        /// <returns>A random number between <paramref name="min"/> and <paramref name="max"/></returns>
        public int Random( int min, int max )
        {
            return _random.Next( min, max );
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <param name="max">Max possible</param>
        /// <returns>a random number</returns>
        public int Random( int max )
        {
            return _random.Next( max );
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <returns>a random number</returns>
        public int Random( )
        {
            return _random.Next( );
        }

        private const int _absValueIntMask = ( sizeof( int ) * 8 ) - 1;

        /// <summary>
        /// Performantly calculates absolute value of an int
        /// </summary>
        /// <param name="i"></param>
        /// <returns>Absolute value of i</returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public int Abs( int i ) 
        {
            int mask = i >> _absValueIntMask;
            return ( i + mask ) ^ mask;
        }

        private const int _minMaxIntMask =  ( sizeof( int ) * 8 ) - 1;

        /// <summary>
        /// Performantly calculates minimum of the passed ints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The smallest of the two ints passed</returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public int Min( int x, int y )
        {
            return y + ( ( ( x - y ) & ( ( x - y ) >> _absValueIntMask ) ) );
        }

        /// <summary>
        /// Performantly calculates maximum of the passed ints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>The largest of the two ints passed</returns>
        [MethodImpl( MethodImplOptions.AggressiveInlining )]
        public int Max( int x, int y )
        {
            return x - ( ( ( x - y ) & ( ( x - y ) >> _absValueIntMask ) ) );
        }



    }
}
