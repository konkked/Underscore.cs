using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;
using System.Threading.Tasks;
using System.Linq;

namespace Underscore.Test.Action
{
    [TestClass]
    public class ComposeTest
    {
        public Action<string> TestComposeEnd( string s ) 
        {
            return ( t ) =>
            {
                Assert.AreEqual( s, t );
            };
        }

        public Func<string,string> TestComposeStart(string s)
        {
            return (t)=>{
                return "Start"+s+t; 
            };
        }

        public Func<string,string> TestComposeLinks(string s)
        {
            return (t)=>
            {
                return t+s;
            };
        }

		[TestMethod]
		public async Task ActionCompose1 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeEnd( "Start12" )
                );

                composeResult( "2" );
            } );

        }
		
        [TestMethod]
		public async Task ActionCompose2 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeEnd( "Start123" )
                );

                composeResult( "2" );
            } );
        }
		
        [TestMethod]
		public async Task ActionCompose3 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeLinks( "4" ),
                        TestComposeEnd( "Start1234" )
                );

                composeResult( "2" );
            } );
        }

		[TestMethod]
		public async Task ActionCompose4 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeLinks( "4" ),
                        TestComposeLinks( "5" ),
                        TestComposeEnd( "Start12345" )
                );

                composeResult( "2" );
            } );
        }

		[TestMethod]
		public async Task ActionCompose5 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeLinks( "4" ),
                        TestComposeLinks( "5" ),
                        TestComposeLinks( "6" ),
                        TestComposeEnd( "Start123456" )
                );

                composeResult( "2" );
            } );
        }
		
        [TestMethod]
		public async Task ActionCompose6 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeLinks( "4" ),
                        TestComposeLinks( "5" ),
                        TestComposeLinks( "6" ),
                        TestComposeLinks( "7" ),
                        TestComposeEnd( "Start1234567" )
                );

                composeResult( "2" );
            } );
        }
		
        [TestMethod]
		public async Task ActionCompose7 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        TestComposeStart( "1" ),
                        TestComposeLinks( "3" ),
                        TestComposeLinks( "4" ),
                        TestComposeLinks( "5" ),
                        TestComposeLinks( "6" ),
                        TestComposeLinks( "7" ),
                        TestComposeLinks( "8" ),
                        TestComposeEnd( "Start12345678" )
                );

                composeResult( "2" );
            } );
        }
		
        [TestMethod]
		public async Task ActionCompose8 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string>( a => str += a );

                var composeResult = component.Compose( act, act, act, act, act );

                composeResult( "1" );
                Assert.AreEqual( Enumerable.Range( 0, 5 ).Select( a => "1" ).Aggregate( ( a, b ) => a + b ), str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply1 ( )
        {
            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" } );

                Assert.AreEqual( "abcdefghijklmnop", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply2 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" } );

                Assert.AreEqual( "abcdefghijklmno", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply3 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" } );

                Assert.AreEqual( "abcdefghijklmn", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply4 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" } );

                Assert.AreEqual( "abcdefghijklm", str );
            } );
        }

		[TestMethod]
		public async Task ActionApply5 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) => str += a + b + c + d + e + f + g + h + i + j + k + l );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" } );

                Assert.AreEqual( "abcdefghijkl", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply6 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k ) => str += a + b + c + d + e + f + g + h + i + j + k );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" } );

                Assert.AreEqual( "abcdefghijk", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply7 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) => str += a + b + c + d + e + f + g + h + i + j );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" } );

                Assert.AreEqual( "abcdefghij", str );
            } );
        }
		
        [TestMethod]
		public async Task ActionApply8 ( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) => str += a + b + c + d + e + f + g + h + i );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i" } );

                Assert.AreEqual( "abcdefghi", str );
            } );
        }

        [TestMethod]
		public async Task ActionApply9 ( )
        {
            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) => str += a + b + c + d + e + f + g + h );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h" } );

                Assert.AreEqual( "abcdefgh", str );
            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) => str += a + b + c + d + e + f + g );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g" } );

                Assert.AreEqual( "abcdefg", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string>( ( a, b, c, d, e, f ) => str += a + b + c + d + e + f );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f" } );

                Assert.AreEqual( "abcdef", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string>( ( a, b, c, d, e ) => str += a + b + c + d + e );

                component.Apply( act, new[ ] { "a", "b", "c", "d", "e" } );

                Assert.AreEqual( "abcde", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string>( ( a, b, c, d ) => str += a + b + c + d );

                component.Apply( act, new[ ] { "a", "b", "c", "d" } );

                Assert.AreEqual( "abcd", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string>( ( a, b, c ) => str += a + b + c );

                component.Apply( act, new[ ] { "a", "b", "c" } );

                Assert.AreEqual( "abc", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string>( ( a, b ) => str += a + b );

                component.Apply( act, new[ ] { "a", "b" } );

                Assert.AreEqual( "ab", str );

            },( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string>( ( a ) => str += a );

                component.Apply( act, new[ ] { "a" } );

                Assert.AreEqual( "a", str );

            } );
        }

		[TestMethod]
		public async Task ActionCall ( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" );

                Assert.AreEqual( "abcdefghijklmnop", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" );

                Assert.AreEqual( "abcdefghijklmno", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" );

                Assert.AreEqual( "abcdefghijklmn", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" );

                Assert.AreEqual( "abcdefghijklm", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) => str += a + b + c + d + e + f + g + h + i + j + k + l );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");

                Assert.AreEqual( "abcdefghijkl", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k) => str += a + b + c + d + e + f + g + h + i + j + k );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" );

                Assert.AreEqual( "abcdefghijk", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h, i, j ) => str += a + b + c + d + e + f + g + h + i + j );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" );

                Assert.AreEqual( "abcdefghij", str );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) => str += a + b + c + d + e + f + g + h + i );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i");

                Assert.AreEqual( "abcdefghi", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h ) => str += a + b + c + d + e + f + g + h  );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h" );

                Assert.AreEqual( "abcdefgh", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) => str += a + b + c + d + e + f + g );

                component.Call( act, "a", "b", "c", "d", "e", "f", "g" );

                Assert.AreEqual( "abcdefg", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string, string>( ( a, b, c, d, e, f) => str += a + b + c + d + e + f );

                component.Call( act, "a", "b", "c", "d", "e", "f" );

                Assert.AreEqual( "abcdef", str );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string, string>( ( a, b, c, d, e ) => str += a + b + c + d + e );

                component.Call( act, "a", "b", "c", "d", "e" );

                Assert.AreEqual( "abcde", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string, string>( ( a, b, c, d) => str += a + b + c + d );

                component.Call( act, "a", "b", "c", "d" );

                Assert.AreEqual( "abcd", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string, string>( ( a, b, c ) => str += a + b + c );

                component.Call( act, "a", "b", "c" );

                Assert.AreEqual( "abc", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string, string>( ( a, b ) => str += a + b );

                component.Call( act, "a", "b" );

                Assert.AreEqual( "ab", str );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Action<string>( ( a ) => str += a );

                component.Call( act, "a" );

                Assert.AreEqual( "a", str );

            } );
        }

    }
}
