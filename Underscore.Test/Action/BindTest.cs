using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Action;
using System.Linq;

namespace Underscore.Test.Action
{
    [TestClass]
    public class BindTest
    {
        private static string Join( params string[ ] args )
        {
            return string.Join( " ", values: ( args ).Where( trg => trg != null ) );
        }



        #region Bind.Action


        private static bool[] _didRun = new bool[ 5 ];


        //actual action is basically useless, 
        //but want it to do something so compiler doesn't just throw out a stmt

        #region Bind.Action.TestHelpers

        public static void TestingAction<T0, T1, T2, T3, T4>( T0 arg0, T1 arg1, T2 arg2, T3 arg3, T4 arg4 )
        {
            _didRun[ 4 ] = true;
        }

        public static Action<T0, T1, T2, T3, T4> CreateTestingAction<T0, T1, T2, T3, T4>( int index, bool[ ] target )
        {
            return new Action<T0, T1, T2, T3, T4>( ( a, b, c, d, e ) =>
            {
                TestingAction( a, b, c, d, e );
                target[ index ] = true;
            } );
        }

        public static void TestingAction<T0, T1, T2, T3>( T0 arg0, T1 arg1, T2 arg2, T3 arg3 )
        {
            _didRun[ 3 ] = true;
        }

        public static Action<T0, T1, T2, T3> CreateTestingAction<T0, T1, T2, T3>( int index, bool[ ] target )
        {
            return new Action<T0, T1, T2, T3>( ( a, b, c, d ) =>
            {
                TestingAction( a, b, c, d );
                target[ index ] = true;
            } );
        }

        public static void TestingAction<T0, T1, T2>( T0 arg0, T1 arg1, T2 arg2 )
        {
            _didRun[ 2 ] = true;
        }

        public static Action<T0, T1, T2> CreateTestingAction<T0, T1, T2>( int index, bool[ ] target )
        {
            return new Action<T0, T1, T2>( ( a, b, c ) =>
            {
                TestingAction( a, b, c );
                target[ index ] = true;
            } );
        }

        public static void TestingAction<T0, T1>( T0 arg0, T1 arg1 )
        {
            _didRun[ 1 ] = true;
        }

        public static Action<T0, T1> CreateTestingAction<T0, T1>( int index, bool[ ] target )
        {
            return new Action<T0, T1>( ( a, b ) =>
            {
                TestingAction( a, b );
                target[ index ] = true;
            } );
        }

        public static void TestingAction<T>( T value )
        {
            _didRun[ 0 ] = true;
        }

        public static Action<TParam> CreateTestingAction<TParam>( int index, bool[ ] target )
        {
            return new Action<TParam>( a =>
            {
                TestingAction( a );
                target[ index ] = true;
            } );
        }

        #endregion

        [TestMethod]
        public async Task Bind_FourParameter_Action( )
        {
            var didRun = new bool[ 4 ];
            var _module = new BindingComponent( );


            //same
            await Util.Tasks.Start(
                _module.Bind( CreateTestingAction<string, string, string, string>( 0, didRun ), "a", "b", "c", "d" ),
                //2 types
                _module.Bind( CreateTestingAction<string, int, string, int>( 1, didRun ), "a", 1, "b", 2 ),
                //3 types
                _module.Bind( CreateTestingAction<string, int, char, string>( 2, didRun ), "a", 1, 'b', "2" ),
                //4 types
                _module.Bind( CreateTestingAction<double, int, char, string>( 3, didRun ), 0.0, 1, 'b', "2" )
            );

            foreach ( var b in didRun )
                Assert.IsTrue( b, "One of the testing methods failed to execute" );

        }

        [TestMethod]
        public async Task Bind_ThreeParameter_Action( )
        {

            var didRun = new bool[ 3 ];
            var _module = new BindingComponent( );

            //same
            await Util.Tasks.Start(
                _module.Bind( CreateTestingAction<string, string, string>( 0, didRun ), "a", "b", "c" ),
                //2 types
                _module.Bind( CreateTestingAction<string, int, string>( 1, didRun ), "a", 1, "b" ),
                //3 types
                _module.Bind( CreateTestingAction<string, int, char>( 2, didRun ), "a", 1, 'b' )
            );


            foreach ( var b in didRun )
                Assert.IsTrue( b, "One of the testing methods failed to execute" );
        }

        [TestMethod]
        public async Task Bind_TwoParameter_Action( )
        {

            var didRun = new bool[ 2 ];
            var _module = new BindingComponent( );


            //same type
            await Util.Tasks.Start(
                _module.Bind( CreateTestingAction<string, string>( 0, didRun ), "a", "b" ),
                //2 types
                _module.Bind( CreateTestingAction<string, int>( 1, didRun ), "a", 1 )
            );


            foreach ( var b in didRun )
                Assert.IsTrue( b, "One of the testing methods failed to execute" );
        }

        [TestMethod]
        public async Task Bind_OneParameter_Action( )
        {

            var didRun = new bool[ 1 ];
            var _module = new BindingComponent( );

            //same type
            await Util.Tasks.Start(
                _module.Bind( CreateTestingAction<string>( 0, didRun ), "" )
            );

            foreach ( var b in didRun )
                Assert.IsTrue( b, "One of the testing methods failed to execute" );
        }

        #endregion





    }
}
