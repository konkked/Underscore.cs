using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Test.Function
{
    [TestClass]
    public class ComposeTest 
    {
        public string Add( string l, string r ) 
        {
            return l + r;
        }

        public Func<string,string> Add( string left ) 
        {
            return ( r ) => left + r;
        }


        [TestMethod]
        public async Task FunctionCompose1( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        Add( "1" ),
                        Add( "2" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "210", result );
            } );

        }

        [TestMethod]
        public async Task FunctionCompose2( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                        Add( "1" ),
                        Add( "2" ),
                        Add( "3" )
                );

                var result  = composeResult( "0" );

                Assert.AreEqual( "3210", result );
            } );
        }

        [TestMethod]
        public async Task FunctionCompose3( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose ( 
                    Add ( "1" ),    
                    Add ( "2" ),
                    Add ( "3" ),
                    Add ( "4" ),
                    Add ( "5" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "543210", result );
            
            } );
        }

        [TestMethod]
        public async Task FunctionCompose4( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                    Add( "1" ),
                    Add( "2" ),
                    Add( "3" ),
                    Add( "4" ),
                    Add( "5" ),
                    Add( "6" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "6543210", result );

            } );
        }

        [TestMethod]
        public async Task FunctionCompose5( )
        {
            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                    Add( "1" ),
                    Add( "2" ),
                    Add( "3" ),
                    Add( "4" ),
                    Add( "5" ),
                    Add( "6" ),
                    Add( "7" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "76543210", result );

            } );
        }

        [TestMethod]
        public async Task FunctionCompose6( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                    Add( "1" ),
                    Add( "2" ),
                    Add( "3" ),
                    Add( "4" ),
                    Add( "5" ),
                    Add( "6" ),
                    Add( "7" ),
                    Add( "8" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "876543210", result );

            } );
        }

        [TestMethod]
        public async Task FunctionCompose7( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                    Add( "1" ),
                    Add( "2" ),
                    Add( "3" ),
                    Add( "4" ),
                    Add( "5" ),
                    Add( "6" ),
                    Add( "7" ),
                    Add( "8" ),
                    Add( "9" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "9876543210", result );

            } );
        }

        [TestMethod]
        public async Task FunctionCompose8( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var composeResult = component.Compose(
                    Add( "1" ),
                    Add( "2" ),
                    Add( "3" ),
                    Add( "4" ),
                    Add( "5" ),
                    Add( "6" ),
                    Add( "7" ),
                    Add( "8" ),
                    Add( "9" ),
                    Add( "10" ),
                    Add( "11" ),
                    Add( "12" ),
                    Add( "13" ),
                    Add( "14" ),
                    Add( "15" ),
                    Add( "16" ),
                    Add( "17" )
                );

                var result = composeResult( "0" );

                Assert.AreEqual( "17161514131211109876543210", result );

            } );
        }

        [TestMethod]
        public async Task FunctionApply1( )
        {
            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" } );

                Assert.AreEqual( "abcdefghijklmnop", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply2( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" } );

                Assert.AreEqual( "abcdefghijklmno", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply3( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" } );

                Assert.AreEqual( "abcdefghijklmn", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply4( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" } );

                Assert.AreEqual( "abcdefghijklm", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply5( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) => str += a + b + c + d + e + f + g + h + i + j + k + l );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" } );

                Assert.AreEqual( "abcdefghijkl", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply6( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k ) => str += a + b + c + d + e + f + g + h + i + j + k );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" } );

                Assert.AreEqual( "abcdefghijk", str );
                Assert.AreEqual( str, result );

            } );
        }

        [TestMethod]
        public async Task FunctionApply7( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) => str += a + b + c + d + e + f + g + h + i + j );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" } );

                Assert.AreEqual( "abcdefghij", str );
                Assert.AreEqual( str, result );
            } );
        }

        [TestMethod]
        public async Task FunctionApply8( )
        {

            await Util.Tasks.Start( ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) => str += a + b + c + d + e + f + g + h + i );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i" } );

                Assert.AreEqual( "abcdefghi", str );
                Assert.AreEqual( str, result );

            } );
        }

        [TestMethod]
        public async Task FunctionApply9( )
        {
            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) => str += a + b + c + d + e + f + g + h );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g", "h" } );

                Assert.AreEqual( "abcdefgh", str );

                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) => str += a + b + c + d + e + f + g );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f", "g" } );

                Assert.AreEqual( "abcdefg", str );

                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string>( ( a, b, c, d, e, f ) => str += a + b + c + d + e + f );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e", "f" } );

                Assert.AreEqual( "abcdef", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string>( ( a, b, c, d, e ) => str += a + b + c + d + e );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d", "e" } );

                Assert.AreEqual( "abcde", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string>( ( a, b, c, d ) => str += a + b + c + d );

                var result = component.Apply( act, new[ ] { "a", "b", "c", "d" } );

                Assert.AreEqual( "abcd", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string>( ( a, b, c ) => str += a + b + c );

                var result = component.Apply( act, new[ ] { "a", "b", "c" } );

                Assert.AreEqual( "abc", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string>( ( a, b ) => str += a + b );

                var result = component.Apply( act, new[ ] { "a", "b" } );

                Assert.AreEqual( "ab", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string>( ( a ) => str += a );

                var result = component.Apply( act, new[ ] { "a" } );

                Assert.AreEqual( "a", str );
                Assert.AreEqual( str, result );

            } );
        }

        [TestMethod]
        public async Task FunctionCall( )
        {

            await Util.Tasks.Start( ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" );

                Assert.AreEqual( "abcdefghijklmnop", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" );

                Assert.AreEqual( "abcdefghijklmno", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" );

                Assert.AreEqual( "abcdefghijklmn", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => str += a + b + c + d + e + f + g + h + i + j + k + l + m );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" );

                Assert.AreEqual( "abcdefghijklm", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) => str += a + b + c + d + e + f + g + h + i + j + k + l );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" );

                Assert.AreEqual( "abcdefghijkl", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k ) => str += a + b + c + d + e + f + g + h + i + j + k );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" );

                Assert.AreEqual( "abcdefghijk", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) => str += a + b + c + d + e + f + g + h + i + j );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" );

                Assert.AreEqual( "abcdefghij", str );
                Assert.AreEqual( str, result );
            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) => str += a + b + c + d + e + f + g + h + i );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h", "i" );

                Assert.AreEqual( "abcdefghi", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) => str += a + b + c + d + e + f + g + h );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g", "h" );

                Assert.AreEqual( "abcdefgh", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) => str += a + b + c + d + e + f + g );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f", "g" );

                Assert.AreEqual( "abcdefg", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string, string>( ( a, b, c, d, e, f ) => str += a + b + c + d + e + f );

                var result = component.Call( act, "a", "b", "c", "d", "e", "f" );

                Assert.AreEqual( "abcdef", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {

                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string, string>( ( a, b, c, d, e ) => str += a + b + c + d + e );

                var result = component.Call( act, "a", "b", "c", "d", "e" );

                Assert.AreEqual( "abcde", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string, string>( ( a, b, c, d ) => str += a + b + c + d );

                var result = component.Call( act, "a", "b", "c", "d" );

                Assert.AreEqual( "abcd", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string, string>( ( a, b, c ) => str += a + b + c );

                var result = component.Call( act, "a", "b", "c" );

                Assert.AreEqual( "abc", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string, string>( ( a, b ) => str += a + b );

                var result = component.Call( act, "a", "b" );

                Assert.AreEqual( "ab", str );
                Assert.AreEqual( str, result );

            }, ( ) =>
            {
                var component = new ComposeComponent( );

                var str = "";

                var act = new Func<string,string>( ( a ) => str += a );

                var result = component.Call( act, "a" );

                Assert.AreEqual( "a", str );
                Assert.AreEqual( str, result );

            } );
        }
    }
}
