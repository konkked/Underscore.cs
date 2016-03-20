using System;
using Underscore.Utility;

namespace Underscore.Module
{

    public class Utility : 
        IFunctionComponent , 
        IMathComponent , 
        IObjectComponent
    {



        private readonly IMathComponent _math;
        private readonly IFunctionComponent _function;
        private readonly IObjectComponent _object;


        public Utility(
            IFunctionComponent function, 
            IMathComponent math, 
            IObjectComponent obj )
        {
            if(function == null)
                throw new ArgumentNullException(nameof(function));

            if(math == null)
                throw new ArgumentNullException(nameof(math));

            if(obj == null)
                throw new ArgumentNullException(nameof(obj));

            _math = math ;
            _function = function ;
            _object = obj ;
        }

        /// <summary>
        /// Creates a unique id (Guid as a string) with a prefix string
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string UniqueId( string prefix )
        {
            return _math.UniqueId( prefix );
        }


        /// <summary>
        /// Creates a unique id (Guid as a string)
        /// </summary>
        /// <param name="prefix"></param>
        /// <returns></returns>
        public string UniqueId( )
        {
            return _math.UniqueId( );
        }


        /// <summary>
        /// returns a thread safe random number
        /// </summary>
        /// <returns></returns>
        public int Random( )
        {
            return _math.Random( );
        }

        /// <summary>
        /// returns a thread safe random number
        /// </summary>
        /// <returns></returns>
        public int Random( int max )
        {
            return _math.Random( max );
        }

        /// <summary>
        /// returns a thread safe random number
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public int Random( int min, int max )
        {
            return _math.Random( min, max );
        }

        /// <summary>
        /// A method that does nothing
        /// </summary>
        public void Noop( )
        {
            _function.Noop( );
        }

        /// <summary>
        /// Creates a function that returns the constant that was passed
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public Func<T> Constant<T>( T value )
        {
            return _function.Constant( value );
        }

        /// <summary>
        /// Returns true if the object is truthy (similair to javascript)
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool IsTruthy( object o )
        {
            return _object.IsTruthy( o );
        }


        /// <summary>
        /// Returns the absolute value of the int passed
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public int Abs( int i )
        {
            return _math.Abs( i );
        }


        /// <summary>
        /// Returns the min value between the two ints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Min( int x, int y )
        {
            return _math.Min( x, y );
        }


        /// <summary>
        /// Returns the max value between the two ints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Max( int x, int y )
        {
            return _math.Max( x, y );
        }

    }
}
