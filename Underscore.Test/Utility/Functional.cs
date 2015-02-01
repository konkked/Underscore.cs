using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class Functional
    {
        [TestMethod]
        public async Task UtilityConstant()
        {

            await Util.Tasks.Start( ( ) =>
            {

                var testing = new FunctionComponent( );

                var values = new { a = "1234", b = "4567", c = 12 };

                var result = testing.Constant( values );

                Assert.AreSame( values, result( ) );
                values = new { a = "abc", b = "1234", c = 34 };
                Assert.AreNotSame( values, result( ) );

            } );
        }


        [TestMethod]
        public async Task UtilityMemo( )
        {
            var callcount = 0;

            Func<string,string> testFn = ( a ) => {
                callcount++;
                return a;
            };

            await Util.Tasks.Start( ( ) =>
            {

                var testing = new global::Underscore.Function.CacheComponent( );

                var memoized = testing.Memoize( testFn );

                var testStr = "test";

                var result = memoized( testStr );

                Assert.AreEqual( testStr, result );
                Assert.AreEqual( 1, callcount );
                Assert.AreEqual( testStr, memoized( "test" ) );
                Assert.AreEqual( 1, callcount );

                testStr = "test2";
                result = memoized( testStr );

                Assert.AreEqual( testStr, result );
                Assert.AreEqual( 2, callcount );
                Assert.AreEqual( testStr, memoized( "test2" ) );
                Assert.AreEqual( 2, callcount );


            } );
        }


        [TestMethod]
        public void UtilityNoop( ) 
        {
            var testing = new FunctionComponent( );
            testing.Noop( );
        }
    }
}
