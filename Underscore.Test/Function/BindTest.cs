using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using System.Threading.Tasks;

namespace Underscore.Test.Function
{
    [TestClass]
    public class BindTest
    {




        public static string ConcateAllToStrings<T0, T1, T2, T3>( T0 arg0, T1 arg1, T2 arg2, T3 arg3 )
        {
            return string.Join( " ", new object[ ] { arg0, arg1, arg2, arg3 } );
        }

        public static string ConcateAllToStrings<T0, T1, T2>( T0 arg0, T1 arg1, T2 arg2 )
        {
            return string.Join( " ", new object[ ] { arg0, arg1, arg2 } );
        }

        public static string ConcateAllToStrings<T0, T1>( T0 arg0, T1 arg1 )
        {
            return string.Join( " ", new object[ ] { arg0, arg1 } );
        }

        public static string ToString<T>( T value )
        {
            return value.ToString( );
        }


        [TestMethod]
        public async Task FunctionBind1( )
        {
            var _module = new BindComponent( );

            await Util.Tasks.Start(
                ( ) =>
                {
                    var resultMethod = _module.Bind( ConcateAllToStrings, "a", "b", "c", "d" );
                    var result = resultMethod( );
                    Assert.AreEqual( "a b c d", result );
                },
                ( ) =>
                {
                    var resultMethod = _module.Bind( ConcateAllToStrings, "a", 1, "b", 2 );
                    var result = resultMethod( );
                    Assert.AreEqual( "a 1 b 2", result );
                },
                ( ) =>
                {
                    //3 types
                    var resultMethod = _module.Bind( ConcateAllToStrings, "a", 1, 'b', "2" );
                    var result = resultMethod( );
                    Assert.AreEqual( result, "a 1 b 2" );
                },
                ( ) =>
                {
                    //4 types
                    var resultMethod = _module.Bind( ConcateAllToStrings, new { a = 'a' }, 1, 'b', "2" );
                    var result = resultMethod( );
                    Assert.AreEqual( ( ( new { a = 'a' } ).ToString( ) + " 1 b 2" ), result );
                }
            );
        }

        [TestMethod]
        public async Task FunctionBind2( )
        {

            var _module = new BindComponent( );

            //same type
            await Util.Tasks.Start(
                ( ) =>
                {
                    Assert.AreEqual( "a b c", _module.Bind( ConcateAllToStrings, "a", "b", "c" )( ) );
                },
                //2 types
                ( ) =>
                {
                    Assert.AreEqual( "a 1 b", _module.Bind( ConcateAllToStrings, "a", 1, "b" )( ) );
                },
                //3 types
                ( ) =>
                {
                    Assert.AreEqual( "a 1 b", _module.Bind( ConcateAllToStrings, "a", 1, 'b' )( ) );
                },
                ( ) =>
                {
                    Assert.AreEqual( ( new { a = 'a' } ).ToString( ) + " 1 b", _module.Bind( ConcateAllToStrings, new { a = 'a' }, 1, 'b' )( ) );
                } );
        }

        [TestMethod]
        public async Task FunctionBind3( )
        {

            var _module = new BindComponent( );

            await Util.Tasks.Start( ( ) =>
            {
                Assert.AreEqual("a b" , _module.Bind( ConcateAllToStrings, "a", "b" )( ) );
            },
                //2 types
            ( ) =>
            {
                Assert.AreEqual("a 1",_module.Bind( ConcateAllToStrings, "a", 1 )( ));
            },

            ( ) =>
            {
                Assert.AreEqual("a b",_module.Bind( ConcateAllToStrings, "a", 'b' )( ) );
            },

            ( ) =>
            {
                Assert.AreEqual( ( new { a = 'a' } ).ToString( ) + " 1"  , _module.Bind( ConcateAllToStrings, new { a = 'a' }, 1 )( )) ;
            } );
        }

        //why is one Parameter_Function taking the longest?
        //might be good to try and figure out why this is happening
        [TestMethod]
        public async Task FunctionBind4( )
        {

            var _module = new BindComponent( );

            var target = new object( );

            //same type
            await Util.Tasks.Start(
                ( ) =>
                {

                    Assert.AreEqual(
                        ( new { a = 'a' } ).ToString( ),
                        _module.Bind( ToString, new { a = 'a' } )( )
                    );

                },
                ( ) =>
                {
                    Assert.AreEqual( "a", _module.Bind( ToString, "a" )( ) );
                },
                ( ) =>
                {
                    Assert.AreEqual( target.ToString( ), _module.Bind( ToString, target )( ) );
                }
            );
        }

    }
}
