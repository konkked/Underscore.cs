using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Action;
using System.Linq;

namespace Underscore.Test.Action
{
    [TestClass]
    public class PartialTest
    {
        private static string Join( params string[ ] args )
        {
            return string.Join( " ", values: ( args ).Where( trg => trg != null ) );
        }


        #region BindPartialAction.Helpers

        private static Action<string, string, string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string, string, string> fn )
        {
            return ( a, b, c, d, e ) => result[ 0 ] = fn( a, b, c, d, e );
        }

        private static Action<string, string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string, string> fn )
        {
            return ( a, b, c, d ) => result[ 0 ] = fn( a, b, c, d );
        }

        private static Action<string, string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string, string> fn )
        {
            return ( a, b, c ) => result[ 0 ] = fn( a, b, c );
        }

        private static Action<string, string> BindPartialActionTarget( string[ ] result, Func<string, string, string> fn )
        {
            return ( a, b ) => result[ 0 ] = fn( a, b );
        }

        private static Action<string> BindPartialActionTarget( string[ ] result, Func<string, string> fn )
        {
            return ( a ) => result[ 0 ] = fn( a );
        }

        #endregion

        #region BindPartialAction.Tests

        [TestMethod]
        public async Task BindPartial_Action( )
        {
            var a = "a";
            var b = "b";
            var c = "c";
            var d = "d";
            var e = "e";

            var expected = new[ ]{
                "a b c d e",
                "a b c d",
                "a b c",
                "a b"
            };

            var _module = new PartialComponent( );

            await Util.Tasks.Start( ( ) =>
            {

                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = BindPartialActionTarget( result, ( _a, _b, _c, _d, _e ) => Join( _a, _b, _c, _d, _e ) );

                var binding1 = _module.Partial( tobind, a );
                var binding2 = _module.Partial( tobind, a, b );
                var binding3 = _module.Partial( tobind, a, b, c );
                var binding4 = _module.Partial( tobind, a, b, c, d );

                binding1( b, c, d, e );
                var result1 = getResult( );

                binding2( c, d, e );
                var result2 = getResult( );

                binding3( d, e );
                var result3 = getResult( );

                binding4( e );
                var result4 = getResult( );

                var expecting = expected[ 0 ];

                var results = new[ ] { result1, result2, result3, result4 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            }, ( ) =>
            {

                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = BindPartialActionTarget( result, ( _a, _b, _c, _d ) => Join( _a, _b, _c, _d ) );

                var binding1 = _module.Partial( tobind, a );
                var binding2 = _module.Partial( tobind, a, b );
                var binding3 = _module.Partial( tobind, a, b, c );

                binding1( b, c, d );
                var result1 = getResult( );

                binding2( c, d );
                var result2 = getResult( );

                binding3( d );
                var result3 = getResult( );

                var expecting = expected[ 1 ];

                var results = new[ ] { result1, result2, result3 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );

            }, ( ) =>
            {

                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = BindPartialActionTarget( result, ( _a, _b, _c ) => Join( _a, _b, _c ) );

                var binding1 = _module.Partial( tobind, a );
                var binding2 = _module.Partial( tobind, a, b );

                binding1( b, c );
                var result1 = getResult( );

                binding2( c );
                var result2 = getResult( );

                var expecting = expected[ 2 ];

                var results = new[ ] { result1, result2 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            }, ( ) =>
            {


                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = BindPartialActionTarget( result, ( _a, _b ) => Join( _a, _b ) );

                var binding1 = _module.Partial( tobind, a );

                binding1( b );
                var result1 = getResult( );

                var expecting = expected[ 3 ];

                var results = new[ ] { result1 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            } );
        }

        #endregion
    }
}
