using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Underscore.Function;

namespace Underscore.Test.Function
{

    [TestClass]
    public class SynchTest
    {
        public ISynchComponent ModifyComponent( ) { return new SynchComponent( new CompactComponent(), new Underscore.Utility.CompactComponent() ); }

        //TODO: Reimplement Debounce Test
        //Realized that the current implementation is flawed
        //should rewrite and pass parameters instead of depending on an invoked value to be the 

        [TestMethod]
        public async Task FunctionDebounce( ) 
        {
            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 500;
            
            int cnt = 1;

            var targeting = new Func<string>( ( ) => {
                cnt++;
                var returning = cnt.ToString( );
                return returning;
            });

            var target = testing.Debounce(targeting,waiting);

            var continuing = new List<Task<string>>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                continuing.Add(target());
            }

            foreach ( var i in continuing )
                Assert.AreEqual( "2", await i);
            
            timer.Stop( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds > waiting );

            continuing.Clear( );
            timer.Reset( );
            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ ) 
            {
                Assert.AreEqual( 2, cnt );
                continuing.Add(target( ));
            }

            foreach ( var t in continuing )
                Assert.AreEqual("3",await t);

            timer.Stop( );

            Assert.AreEqual( 3, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting, "Waiting( {0} ) was less then expected ({1})" ,timer.ElapsedMilliseconds,waiting);
            
        }

        [TestMethod]
        public async Task FunctionDebounce1( ) 
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 25;

            int cnt = 1;
            string expecting = "";

            var targeting = new Func<string,string>( ( a ) =>
            {
                Interlocked.Increment( ref cnt );
                var returning = a;
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting );

            var continuing = new List<Task>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var calling = i.ToString( );
                continuing.Add( target( calling ).ContinueWith( a =>
                {
                    Assert.AreEqual( 2, cnt );
                    Assert.IsTrue( int.Parse(a.Result) > 90 );
                } ) );
            }

            foreach ( var i in continuing )
                await i;

            timer.Stop( );

            Thread.MemoryBarrier( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionDebounce2( )
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 100;

            int cnt = 1;

            var ir = string.Empty;

            var targeting = new Func<string,string, string>( ( s1,s2 ) =>
            {
                cnt++;
                var returning = string.Join( " ", s1, s2, cnt.ToString( ) );
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting);

            var continuing = new List<Task<string>>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var  j = i;
                continuing.Add( target( j.ToString( ) , (-j).ToString() ) );
            }

            foreach (var i in continuing)
            {
                var a = await i;
                Assert.AreEqual(2, cnt);
                Assert.AreEqual("99 -99 2", a);
            }
            timer.Stop( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionDebounce4( )
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 50;

            int cnt = 1;

            var targeting = new Func<string, string, string, string>( ( s1, s2,s3 ) =>
            {
                var returning = string.Join( " ", s1, s2,s3, cnt.ToString( ) );
                cnt++;
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting );

            var continuing = new List<Task>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var  j = i;
                continuing.Add( target( j.ToString( ), ( -j ).ToString( ) , j.ToString( ) ).ContinueWith( a =>
                {
                    Assert.AreEqual( 2, cnt );
                    Assert.AreEqual( "99 -99 99 1", a.Result );
                } ) );
            }

            foreach ( var i in continuing )
                await i;
            timer.Stop( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionDebounce5( )
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 200;

            int cnt = 1;

            var targeting = new Func<string, string, string,string , string>( ( s1, s2, s3, s4 ) =>
            {
                var returning = string.Join( " ", s1, s2, s3,s4, cnt.ToString( ) );
                cnt++;
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting );

            var continuing = new List<Task>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var  j = i;
                continuing.Add( target( j.ToString( ), ( -j ).ToString( ), j.ToString( ), ( -j ).ToString( ) ).ContinueWith( a =>
                {
                    Assert.AreEqual( 2, cnt );
                    Assert.AreEqual( "99 -99 99 -99 1", a.Result );
                } ) );
            }

            foreach ( var i in continuing )
                await i;
            timer.Stop( );

            Thread.MemoryBarrier( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionDebounce6( )
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 25;

            int cnt = 1;

            var targeting = new Func<string, string, string, string, string,string>( ( s1, s2, s3, s4,s5 ) =>
            {
                var returning = string.Join( " ", s1, s2, s3, s4, s5, cnt.ToString( ) );
                cnt++;
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting );

            var continuing = new List<Task>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var  j = i;
                continuing.Add( target( j.ToString( ), ( -j ).ToString( ), j.ToString( ), ( -j ).ToString( ), j.ToString( ) ).ContinueWith( a =>
                {
                    Assert.AreEqual( 2, cnt );
                    Assert.AreEqual( "99 -99 99 -99 99 1", a.Result );
                } ) );
            }

            foreach ( var i in continuing )
                await i;
            timer.Stop( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionDebounce7( )
        {

            var testing = ModifyComponent( );
            var timer = new Stopwatch( );
            int waiting = 25;

            int cnt = 1;

            var targeting = new Func<string, string, string, string, string,string, string>( ( s1, s2, s3, s4, s5, s6 ) =>
            {
                var returning = string.Join( " ", s1, s2, s3, s4, s5, s6, cnt.ToString( ) );
                cnt++;
                return returning;
            } );

            var target = testing.Debounce( targeting, waiting );

            var continuing = new List<Task>( );

            timer.Start( );

            for ( int i=0 ; i < 100 ; i++ )
            {
                Assert.AreEqual( 1, cnt );
                var  j = i;
                continuing.Add( 
                    target( 
                        ( j ).ToString( ), 
                        ( -j ).ToString( ), 
                        ( j ).ToString( ), 
                        ( -j ).ToString( ), 
                        ( j ).ToString( ) , 
                        ( -j ).ToString( ) 
                    ).ContinueWith( a =>
                {
                    Assert.AreEqual( 2, cnt );
                    Assert.AreEqual( "99 -99 99 -99 99 -99 1", a.Result );
                } ) );
            }

            foreach ( var i in continuing )
                await i;
            timer.Stop( );

            Assert.AreEqual( 2, cnt );
            Assert.IsTrue( timer.ElapsedMilliseconds >= waiting );
        }

        [TestMethod]
        public async Task FunctionThrottle3()
        {
            
            var testing = ModifyComponent();
            var timer = new Stopwatch();
            int waiting = 25;

            int cnt = 0;

            timer.Start();

            var targeting = new Func<string, string, string, string, string, string, string>((s1, s2, s3, s4, s5, s6) =>
            {
                cnt++;
                var returning = string.Join(" ", s1, s2, s3, s4, s5, s6);
                return returning;
            });

            var target = testing.Throttle(targeting, waiting);

            var continuing = new List<Task>();


            for (int i = 0; i < 99; i++)
            {
                Assert.AreEqual(i == 0 ? 0 : 1, cnt);

                var j = i + 1;


                if (i == 0)
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                            ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1", a.Result))
                        );
                }
                else
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                            )
                            .ContinueWith(
                                a => Assert.AreEqual("99 -99 99 -99 99 -99", a.Result))
                        );
                }
            }

            Assert.AreEqual(1, cnt);


            for (int i = 0; i < 99; i++)
                await continuing[i];

            timer.Stop();

            Assert.AreEqual(2, cnt);

            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);


        }

        [TestMethod]
        public async Task FunctionThrottle2()
        {

            var testing = ModifyComponent();
            var timer = new System.Diagnostics.Stopwatch();
            int waiting = 10;

            int cnt = 0;

            var targeting = new Func<string, string, string, string, string, string, string>((s1, s2, s3, s4, s5, s6) =>
            {
                cnt++;
                var returning = string.Join(" ", s1, s2, s3, s4, s5, s6);
                return returning;
            });

            var target = testing.Throttle(targeting, waiting);

            var continuing = new List<Task>();

            timer.Start();


            for (int i = 0; i < 99; i++)
            {
                Assert.AreEqual(i == 0 ? 0 : 1, cnt);

                var j = i + 1;


                if (i == 0)
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                            ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1", a.Result))
                        );
                }
                else
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                            )
                            .ContinueWith(
                                a => Assert.AreEqual("99 -99 99 -99 99 -99", a.Result))
                        );
                }
            }

            foreach (var v in continuing)
                await v;

            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);


            Assert.AreEqual(2, cnt);
        }

        [TestMethod]
        public async Task FunctionThrottle()
        {
            var testing = ModifyComponent();
            var timer = new Stopwatch();
            const int waiting = 10;

            int cnt = 1;

            var targeting = new Func<string, string>((i) =>
            {
                Interlocked.Increment(ref cnt);
                return i + i;
            });

            var target = testing.Throttle(targeting, waiting);

            var continuing = new List<Task<string>>();

            timer.Start();

            var first = target("0");
            var firstResult = await first;

            Assert.AreEqual(2, cnt);
            Assert.AreEqual("00", firstResult);


            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(2, cnt);

                continuing.Add(target((i + 1).ToString()));
            }

            foreach (var i in continuing)
            {
                var result = await i;
                Assert.AreEqual("100100", result);
            }

            timer.Stop();

            Assert.AreEqual(3, cnt);
            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);

            continuing.Clear();
            timer.Reset();
            timer.Start();

            await Task.Delay(2);

            first = target("101");
            firstResult = await first;
            Assert.AreEqual(4, cnt);
            Assert.AreEqual("101101", firstResult);


            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(4, cnt);
                continuing.Add(target((101 + i).ToString()));
            }
            foreach (var t in continuing)
            {
                var result = await t;
                Assert.AreEqual("200200", result);
            }
        
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);


            Assert.AreEqual(5, cnt);
        }

        [TestMethod]
        public async Task FunctionDelay( ) 
        {
            //if I didn't use this I would lose my mind
            var fn = new ComposeComponent( );
            var testing = ModifyComponent( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f" };


            Action<int,string, Task<string>> TestDelay = ( waitTime,expecting, delayed ) =>
            {
                var timer = new Stopwatch( );
                timer.Start( );
                Thread.MemoryBarrier( );
                delayed.Wait( );
                Thread.MemoryBarrier( );
                timer.Stop( );
                Assert.IsTrue( timer.ElapsedMilliseconds >= waitTime - 25 );
                Assert.AreEqual( expecting, delayed.Result );
            };


            await Util.Tasks.Start( ( ) =>
            {
                var timer = new Stopwatch( );
                var delayed = testing.Delay( ( ) => "worked", 100 );
                
                timer.Start( );
                
                var taskResult = delayed( );
                
                Thread.MemoryBarrier( );
                
                taskResult.Wait( );
                timer.Stop( );

                Assert.AreEqual( "worked", taskResult.Result );
                Assert.IsTrue( timer.ElapsedMilliseconds >= 100 , string.Format("Expecting at least {0} got {1}", 100,timer.ElapsedMilliseconds));

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string,string>( ( a) =>
                {
                    Assert.AreEqual( "a", a );
                    invoked = true;
                    return string.Join( "", a );
                } );

                var delayed = testing.Delay( delaying, 100 );

                Thread.MemoryBarrier( );

                TestDelay( 100,"a", fn.Apply( delayed, arguments ) );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string, string,string>( ( a, b ) =>
                {
                    Assert.AreEqual( "a", a );
                    Assert.AreEqual( "b", b );
                    invoked = true;
                    return string.Join( "", a, b );
                } );

                var delayed = testing.Delay( delaying, 100 );

                Thread.MemoryBarrier( );

                TestDelay( 100,"ab", fn.Apply( delayed, arguments ) );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string,string, string, string>( ( a, b, c ) =>
                {
                    Assert.AreEqual( "a", a );
                    Assert.AreEqual( "b", b );
                    Assert.AreEqual( "c", c );
                    invoked = true;
                    return "abc";
                } );

                var delayed = testing.Delay( delaying, 100 );

                Thread.MemoryBarrier( );

                TestDelay( 100,"abc", fn.Apply( delayed, arguments ) );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string,string, string, string, string>( ( a, b, c, d ) =>
                {
                    Assert.AreEqual( "a", a );
                    Assert.AreEqual( "b", b );
                    Assert.AreEqual( "c", c );
                    Assert.AreEqual( "d", d );
                    invoked = true;
                    return "abcd";
                } );

                var delayed = testing.Delay( delaying, 100 );

                Thread.MemoryBarrier( );

                TestDelay( 100,"abcd",fn.Apply( delayed, arguments ) );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string,string, string, string, string, string>( ( a, b, c, d, e ) =>
                {
                    Assert.AreEqual( "a", a );
                    Assert.AreEqual( "b", b );
                    Assert.AreEqual( "c", c );
                    Assert.AreEqual( "d", d );
                    Assert.AreEqual( "e", e );
                    invoked = true;
                    return "abcde";
                } );

                var timer = new Stopwatch( );
                var delayed = testing.Delay( delaying, 100 );

                timer.Start( );

                Thread.MemoryBarrier( );

                TestDelay( 100, "abcde", fn.Apply(delayed,arguments ));

                Assert.IsTrue( invoked );
                timer.Stop( );
                Assert.IsTrue( timer.ElapsedMilliseconds >= 100 );

            }, ( ) =>
            {

                var invoked = false;

                var delaying = new Func<string,string, string, string, string, string, string>( ( a, b, c, d, e, f ) =>
                {
                    Assert.AreEqual( "a", a );
                    Assert.AreEqual( "b", b );
                    Assert.AreEqual( "c", c );
                    Assert.AreEqual( "d", d );
                    Assert.AreEqual( "e", e );
                    Assert.AreEqual( "f", f );
                    invoked = true;
                    return "abcdef";
                } );

                var delayed = testing.Delay( delaying, 100 );

                Thread.MemoryBarrier( );

                TestDelay( 100,"abcdef", fn.Apply( delayed, arguments ) );

                Assert.IsTrue( invoked );

            } );
        }

        [TestMethod]
        public async Task FunctionOnce( ) 
        {
            //if I didn't use this I would lose my mind
            var fn = new ComposeComponent( );
            var testing = ModifyComponent( );


            string[] arguments = "abcdefghijklmnopqrstuvwxyz".Select(a=>a.ToString( )).ToArray( );

            await Util.Tasks.Start( ( ) =>
            {

                string result = "";
                int counter = 0;
                var timer = new Stopwatch( );
                var onced = testing.Once( ( ) => result = ( counter++ ).ToString( ) );
                for ( int i=0 ; i < 10 ; i++ )
                    onced( );

                Assert.AreEqual( "0", result );

            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string>( ( a ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[i]= fn.Apply( onced, arguments );

                foreach(var v in result)
                    Assert.AreEqual( "a1", v);
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string,string, string>( ( a, b ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "ab1", v );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                
                var oncing = new Func<string,string, string, string>( ( a, b, c ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abc1", v );
                Assert.IsTrue( invoked );



            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                
                var oncing = new Func<string, string, string, string, string>( ( a, b, c, d ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcd1", v );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string,string>( ( a, b, c, d,e ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d,e, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcde1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string,string>( ( a, b, c, d, e,f ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e,f, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdef1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g  ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f , g , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefg1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g,h ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefgh1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefgh1", v );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string,string,string,string>( ( a, b, c, d, e, f, g, h, i ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghi1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghij1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j , k ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghijk1", v );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k , l ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghijkl1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l,m ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghijklm1", v );

                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m,n ) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m,n, counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghijklmn1", v );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;

                var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ,o) =>
                {
                    counter++;
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o , counter );
                } );

                var onced = testing.Once( oncing );
                string[] result = new string[ 100 ];
                for ( int i=0 ; i < 100 ; i++ )
                    result[ i ] = fn.Apply( onced, arguments );

                foreach ( var v in result )
                    Assert.AreEqual( "abcdefghijklmno1", v );

                Assert.IsTrue( invoked );


            } );
        }

        [TestMethod]
        public async Task FunctionAfter( )
        {
            //if I didn't use this I would lose my mind
            var testing = ModifyComponent( );
            var fn = new ComposeComponent( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" ,"o","p"};


            int repeatCount = 100000;
            int paramValue = 15000;

            Func <Task<string>[]> mkArr = ()=> new Task<string>[repeatCount];

            await Util.Tasks.Start( ( ) =>
            {

                int counter = 0;
                var timer = new Stopwatch( );
                var aftered = testing.After( ( ) => ( counter++ ).ToString( ),3 );

                List<Task<string>> results = new List<Task<string>>( );

                for ( int i=0 ; i < 10 ; i++ ) 
                {
                    results.Add( aftered( ) );
                }

                for ( int i=0 ; i < 3 ; i++ ) 
                {
                    results[ i ].Wait( );
                    var rslt = results[ i ].Result;
                    Assert.AreEqual( "0", rslt );
                }

                var shouldHave = new HashSet<string>();
                var actualResults = new HashSet<string>();

                foreach (var j in Enumerable.Range(3, 7))
                    shouldHave.Add((j - 2).ToString());

                for ( int i=3 ; i < 10 ; i++ ) 
                {
                    results[ i ].Wait( );
                    var rslt = results[ i ].Result;
                    Assert.IsTrue(actualResults.Add((rslt)));
                    Assert.IsTrue( shouldHave.Contains( rslt));
                }

                Assert.AreEqual(shouldHave.Count , actualResults.Count);


            }, ( ) =>
            {

                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string,string, string>( ( a, b ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b );
                    
                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(1).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ ) 
                {
                    Assert.AreEqual( "a" + ( paramValue - 1 ), arr[ i ].Result );
                }

                for ( int i=paramValue ; i < repeatCount ; i++ ) 
                {
                    Assert.AreEqual( "a" + i, arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string,string>( ( a, b, c ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c );

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(2).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "ab"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "ab" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string,string>( ( a, b, c,d ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(3).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abc"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abc" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string,string>( ( a, b, c, d, e ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(4).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcd"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcd" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );



            }, ( ) =>
            {

                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string,string>( ( a, b, c, d, e, f ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(5).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcde"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcde" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(6).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdef"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdef" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g , h ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g , h );

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    Thread.MemoryBarrier();
                    arr[ i ] = fn.Apply( aftered, arguments.Take(7).Concat( new[]{ curr.ToString() } ).ToArray() );
                    Thread.MemoryBarrier();
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefg"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefg" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h , i ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i );

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(8).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i < paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefgh"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefgh" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i , j ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j );

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    int curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(9).Concat( new[]{ curr.ToString() } ).ToArray());
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghi"+(paramValue - 1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghi"+i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k  ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k );

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(10).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghij"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghij" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );

            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k,l ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k,l);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(11).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghijk"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghijk" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );

            }, ( ) =>
            {



                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l,m ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l,m);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(12).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghijkl"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghijkl" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string,string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m,n ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(13).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklm"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklm" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }, ( ) =>
            {



                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n,o ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n,o);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(14).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklmn"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklmn" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            } , ( ) =>
            {



                var invoked = false;
                var arr = mkArr();

                var counter = 0;
                

                var aftering = new Func<string,string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n,o ,p) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n,o,p);

                } );

                var aftered = testing.After( aftering , paramValue);

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    var curr = counter++;
                    arr[ i ] = fn.Apply( aftered, arguments.Take(15).Concat( new[]{ curr.ToString() } ).ToArray() );
                }

                for ( int i=0 ; i < repeatCount ; i++ )
                {
                    arr[ i ].Wait( );
                }

                for ( int i=0 ; i<paramValue ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklmno"+(paramValue-1), arr[ i ].Result );
                }

                for ( int i=paramValue; i < repeatCount ; i++ )
                {
                    Assert.AreEqual( "abcdefghijklmno" + i , arr[ i ].Result );
                }

                Assert.IsTrue( invoked );


            }  );

        }

        [TestMethod]
        public async Task FunctionBefore( ) 
        {

            var fn = new ComposeComponent( );
            var testing = ModifyComponent( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e",  "f",  "g",  "h",  "i",  "j",  "k",  "l",  "m",  "n", "o", "p" };

            await Util.Tasks.Start( ( ) =>
            {

                int counter = 0;
                var befored = testing.Before( () =>(counter++), 2);
                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( i, befored( ));

                for(int i=0;i<10;i++)
                    Assert.AreEqual( 1, befored());

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string,string, string>( ( a, b ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual("ab"+i, fn.Apply( befored, arguments ));

                for ( int i=2 ; i < 4 ;i++ )
                    Assert.AreEqual("ab1",fn.Apply(befored,arguments));


                    Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string,string>( ( a, b,c ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b,c, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abc" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abc1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string,string>( ( a, b, c,d ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d,counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcd" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcd1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string,string,string>( ( a, b, c, d, e ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c,d,e, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcde" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcde1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string,string>( ( a, b, c, d, e, f ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c,d,e,f, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdef" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdef1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c,d,e,f,g, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefg" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefg1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefg" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefg1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g,h ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g,h, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefgh" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefgh1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h,i ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghi" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghi1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i,j ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i,j, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghij" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghij1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j,k ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j,k, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijk" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijk1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k , l ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k,l, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijkl" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijkl1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l , m ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijklm" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijklm1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m,n ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n , counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijklmn" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijklmn1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string,string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m , n,o) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n ,o, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijklmno" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijklmno1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n,o,p ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m,n,o, p,counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijklmnop" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijklmnop1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            }, ( ) =>
            {

                var invoked = false;


                var counter = 0;

                var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p ) =>
                {
                    invoked = true;
                    return string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p, counter++ );
                } );

                var befored = testing.Before( beforing , 2);

                for ( int i=0 ; i < 2 ; i++ )
                    Assert.AreEqual( "abcdefghijklmnop" + i, fn.Apply( befored, arguments ) );

                for ( int i=2 ; i < 4 ; i++ )
                    Assert.AreEqual( "abcdefghijklmnop1", fn.Apply( befored, arguments ) );


                Assert.IsTrue( invoked );

            } );
        }

    }
}
