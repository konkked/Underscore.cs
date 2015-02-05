using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Test.Function
{
        [TestClass]
        public class SplitTest
        {

            private static Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
                string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o, string p )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o, _p ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    Assert.AreEqual( l, _l );

                    Assert.AreEqual( m, _m );

                    Assert.AreEqual( n, _n );

                    Assert.AreEqual( n, _n );

                    Assert.AreEqual( o, _o );

                    Assert.AreEqual( p, _p );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o, _p );
                };
            }

            private static Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
        string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n, string o )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    Assert.AreEqual( l, _l );

                    Assert.AreEqual( m, _m );

                    Assert.AreEqual( n, _n );

                    Assert.AreEqual( n, _n );

                    Assert.AreEqual( o, _o );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o );

                };
            }


            private static Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
        string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m, string n )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    Assert.AreEqual( l, _l );

                    Assert.AreEqual( m, _m );

                    Assert.AreEqual( n, _n );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m,_n );
                };
            }


            private static Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
        string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l, string m )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    Assert.AreEqual( l, _l );

                    Assert.AreEqual( m, _m );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m );
                };
            }

            private static Func<string, string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
        string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k, string l )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    Assert.AreEqual( l, _l );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l );
                };
            }

            private static Func<string, string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f, string g, string h, string i, string j, string k )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    Assert.AreEqual( k, _k );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k );
                };
            }


            private static Func<string, string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f, string g, string h, string i, string j )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i, _j ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    Assert.AreEqual( j, _j );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i, _j );
                };
            }

            private static Func<string, string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f, string g, string h, string i )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h, _i ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    Assert.AreEqual( i, _i );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h, _i);
                };
            }


            private static Func<string, string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f, string g, string h )
            {
                return ( _a, _b, _c, _d, _e, _f, _g, _h ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    Assert.AreEqual( h, _h );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g, _h );
                };
            }


            private static Func<string, string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f, string g )
            {
                return ( _a, _b, _c, _d, _e, _f, _g ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    Assert.AreEqual( g, _g );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f, _g );
                };
            }


            private static Func<string, string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e, string f )
            {
                return ( _a, _b, _c, _d, _e, _f ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    Assert.AreEqual( f, _f );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e, _f );
                };
            }


            private static Func<string, string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d, string e )
            {
                return ( _a, _b, _c, _d, _e ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    Assert.AreEqual( e, _e );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d, _e);
                };
            }


            private static Func<string, string, string, string, string> CreateSplitterTest( bool[ ] reference,
    string a, string b, string c, string d )
            {
                return ( _a, _b, _c, _d ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    Assert.AreEqual( d, _d );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c, _d);
                };
            }


            private static Func<string, string, string, string> CreateSplitterTest( bool[ ] reference, string a, string b, string c )
            {
                return ( _a, _b, _c ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    Assert.AreEqual( c, _c );

                    reference[ 0 ] = true;


                    return string.Join( "", _a, _b, _c );

                };
            }

            private static Func<string, string, string> CreateSplitterTest( bool[ ] reference, string a, string b )
            {
                return ( _a, _b ) =>
                {
                    Assert.AreEqual( a, _a );

                    Assert.AreEqual( b, _b );

                    reference[ 0 ] = true;

                    return string.Join( "", _a, _b );

                };
            }

            [TestMethod]
            public void FunctionSplit( )
            {
                var splitter = new SplitComponent( );
                bool[] reference = new[ ] { false };

                //can hit every line of code by splitting the largest case multiple times 
                var result = 
            splitter.Split(
                    CreateSplitterTest(
                        reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" ) );

                var retv = 
                    splitter.Split
                    (
                        splitter.Split(
                            splitter.Split(
                                    result( "a", "b", "c", "d", "e", "f", "g", "h" ) )( "i", "j", "k", "l" )
                            )( "m", "n" )
                )( "o" )( "p" );

                Assert.IsTrue( reference[ 0 ] );
                Assert.AreEqual( "abcdefghijklmnop", retv );
            }

            [TestMethod]
            public async Task FunctionCurry( )
            {
                var splitter = new SplitComponent( );

                await Util.Tasks.Start( ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" )( "l" )( "m" )( "n" )( "o" )( "p" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijklmnop", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" )( "l" )( "m" )( "n" )( "o" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijklmno", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" )( "l" )( "m" )( "n" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijklmn", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" )( "l" )( "m" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijklm", retv );

                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" )( "l" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijkl", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" )( "k" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghijk", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" )( "j" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghij", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h", "i" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" )( "i" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcdefghi", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g", "h" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" )( "h" );
                    Assert.IsTrue( reference[ 0 ] );

                    Assert.AreEqual( "abcdefgh", retv );

                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f", "g" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" )( "g" );
                    Assert.IsTrue( reference[ 0 ] );

                    Assert.AreEqual( "abcdefg", retv );

                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e", "f" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" )( "f" );
                    Assert.IsTrue( reference[ 0 ] );


                    Assert.AreEqual( "abcdef", retv );

                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d", "e" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" )( "e" );
                    Assert.IsTrue( reference[ 0 ] );


                    Assert.AreEqual( "abcde", retv );


                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c", "d" )
                    );

                    var retv = result( "a" )( "b" )( "c" )( "d" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abcd", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b", "c" )
                    );

                    var retv = result( "a" )( "b" )( "c" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "abc", retv );
                }, ( ) =>
                {

                    var reference = new[ ] { false };

                    var result = splitter.Curry(
                        CreateSplitterTest(
                            reference, "a", "b" )
                    );

                    var retv = result( "a" )( "b" );
                    Assert.IsTrue( reference[ 0 ] );
                    Assert.AreEqual( "ab", retv );
                } );


            }

        }
}
