using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Function;
using System.Linq;

namespace Underscore.Test.Function
{
    [TestClass]
    public class PartialTest
    {
        private static string Join( params string[ ] args )
        {
            return string.Join( " ", values: ( args ).Where( trg => trg != null ) );
        }

        private static string BindPartialFunctionTarget( string a, string b, string c, string d, string e )
        {
            return Join( a, b, c, d, e );
        }

        private static string BindPartialFunctionTarget( string a, string b, string c, string d )
        {
            return Join( a, b, c, d );
        }

        private static string BindPartialFunctionTarget( string a, string b, string c )
        {
            return Join( a, b, c );
        }

        private static string BindPartialFunctionTarget( string a, string b )
        {
            return Join( a, b );
        }

        [TestMethod]
        public async Task BindPartial_Function( )
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

            var partialBinder = new PartialComponent( );

            await Util.Tasks.Start( ( ) =>
            {

                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = new Func<string, string, string, string, string, string>( BindPartialFunctionTarget );

                var binding1 = partialBinder.Partial( tobind, a );
                var binding2 = partialBinder.Partial( tobind, a, b );
                var binding3 = partialBinder.Partial( tobind, a, b, c );
                var binding4 = partialBinder.Partial( tobind, a, b, c, d );

                var result1 = binding1( b, c, d, e );

                var result2 = binding2( c, d, e );

                var result3 = binding3( d, e );

                var result4 = binding4( e );

                var expecting = expected[ 0 ];

                var results = new[ ] { result1, result2, result3, result4 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            }, ( ) =>
            {
                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = new Func<string, string, string, string, string>( BindPartialFunctionTarget );

                var binding1 = partialBinder.Partial( tobind, a );
                var binding2 = partialBinder.Partial( tobind, a, b );
                var binding3 = partialBinder.Partial( tobind, a, b, c );

                var result1 = binding1( b, c, d );

                var result2 = binding2( c, d );

                var result3 = binding3( d );

                var expecting = expected[ 1 ];

                var results = new[ ] { result1, result2, result3 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );

            }, ( ) =>
            {

                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = new Func<string, string, string, string>( BindPartialFunctionTarget );

                var binding1 = partialBinder.Partial( tobind, a );
                var binding2 = partialBinder.Partial( tobind, a, b );

                var result1 = binding1( b, c );

                var result2 = binding2( c );

                var expecting = expected[ 2 ];

                var results = new[ ] { result1, result2 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            }, ( ) =>
            {


                var result = new string[ 1 ];

                Func<string> getResult = ( ) => result[ 0 ];

                var tobind = new Func<string, string, string>( BindPartialFunctionTarget );

                var binding1 = partialBinder.Partial( tobind, a );

                var result1 = binding1( b );

                var expecting = expected[ 3 ];

                var results = new[ ] { result1 };

                foreach ( var r in results )
                    Assert.AreEqual( expecting, r );
            } );
        }
    }
}
