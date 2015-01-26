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
            _math = math ;
            _function = function ;
            _object = obj ;
        }

        public string UniqueId( string prefix )
        {
            return _math.UniqueId( prefix );
        }

        public string UniqueId( )
        {
            return _math.UniqueId( );
        }

        public int Random( )
        {
            return _math.Random( );
        }

        public int Random( int max )
        {
            return _math.Random( max );
        }

        public int Random( int min, int max )
        {
            return _math.Random( min, max );
        }

        public void Noop( )
        {
            _function.Noop( );
        }

        public Func<T> Constant<T>( T value )
        {
            return _function.Constant( value );
        }

        public bool IsTruthy( object o )
        {
            return _object.IsTruthy( o );
        }


        public int Abs( int i )
        {
            return _math.Abs( i );
        }

        public int Min( int x, int y )
        {
            return _math.Min( x, y );
        }

        public int Max( int x, int y )
        {
            return _math.Max( x, y );
        }
    }
}
