using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Underscore.Action;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using ComposeComponent = Underscore.Function.ComposeComponent;
using SynchComponent = Underscore.Function.SynchComponent;

namespace Underscore.Test.Action
{
    [TestClass]
    public class ModifyTest
    {
        public ISynchComponent ManipulateDummy( ) { return new global::Underscore.Action.SynchComponent(new SynchComponent(), new ConvertComponent(), new global::Underscore.Function.ConvertComponent()); }

        [TestMethod]
        public async Task ActionDebounce( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var locking = new object( );

            var callcount = 0;

            var debounced = 
                testing.Debounce( ( ) =>
                {
                    flag = true;
                    callcount++;
                }, 5 );

            var tasksRunning = new List<Task>( );

            Assert.AreEqual( false, flag );
            Assert.AreEqual( 0, callcount );
            
            for(int i=0;i<100;i++)
                tasksRunning.Add( debounced( ) );
           
            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( 0, callcount );

            foreach (var v in tasksRunning)
                await v;
            Assert.AreEqual(1, callcount);
            Assert.IsTrue(flag);

            flag = false;

            for (int i = 0; i < 100; i++)
                tasksRunning.Add(debounced());

            Assert.IsFalse(flag);
            Assert.AreEqual(1, callcount);

            foreach (var v in tasksRunning)
                await v;
            Assert.AreEqual(2, callcount);
            Assert.IsTrue(flag);
        }

        [TestMethod]
        public async Task ActionDebounce1( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            string result =  null;
            int callCount = 0;

            var target = testing.Debounce(new Action<string>((i) =>
            {
                result = i;
                callCount++;
            
            }),50);


            var waitingfor = new List<Task>();

            for (int i = 0; i < 100; i++)
                waitingfor.Add(target(i.ToString()));


            foreach (var v in waitingfor)
                await v;

            Assert.AreEqual("99", result);

            Assert.AreEqual(1, callCount);



        }


        [TestMethod]
        public async Task ActionDebounce2( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var locking = new object( );
            var waitingFor = 50;
            var timer = new Stopwatch();


            var rslt = new[]{"",""};
            int countCalling = 0;
            var debouncing  = new Action<string,string>( ( i,j ) =>
            {
                flag = true;
                //should still only be the last called item
                rslt[0] += i;
                rslt[ 1 ] += j;
                countCalling++;
            }  );

            var debounced = 
                testing.Debounce( debouncing, waitingFor);

            var tasksRunning = new List<Task>( );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( false, flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            timer.Start( );
            for ( int i=0 ; i < 100 ; i++ )
                tasksRunning.Add( debounced( i.ToString( ), (-i).ToString() ) );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            foreach ( var task in tasksRunning )
                await task;
            timer.Stop( );

            Assert.IsTrue( timer.ElapsedMilliseconds >= waitingFor );
            Assert.IsTrue( flag );
            Assert.AreEqual(  "99"  , rslt[ 0 ]);
            Assert.AreEqual( "-99"  , rslt[ 1 ]);
            Assert.AreEqual( 1, countCalling );

            var secondCallResult = debounced( "a","b" );
            Assert.AreEqual( 1, countCalling );

            //after wait period time has expired 
            Assert.AreNotSame( tasksRunning[ 0 ], secondCallResult );

            
            await secondCallResult;
            
            Assert.AreEqual( "99a", rslt[ 0 ] );
            Assert.AreEqual( "-99b", rslt[ 1 ] );
            Assert.AreEqual( 2, countCalling );

        }


        [TestMethod]
        public async Task ActionDebounce3( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var locking = new object( );
            var waitingFor = 50;
            var timer = new Stopwatch( );


            var rslt = new[ ] { "", "" ,""};
            int countCalling = 0;
            var debouncing  = new Action<string, string, string>( ( i, j,k ) =>
            {
                flag = true;
                //should still only be the last called item
                rslt[ 0 ] += i;
                rslt[ 1 ] += j;
                rslt[ 2 ] += k;
                countCalling++;
            } );

            var debounced = 
                testing.Debounce( debouncing, waitingFor );

            var tasksRunning = new List<Task>( );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( false, flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            timer.Start( );
            for ( int i=0 ; i < 100 ; i++ )
                tasksRunning.Add( debounced( i.ToString( ), ( -i ).ToString( ) , i.ToString() ) );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            foreach ( var task in tasksRunning )
                await task;
            timer.Stop( );

            Assert.IsTrue( timer.ElapsedMilliseconds >= waitingFor );
            Assert.IsTrue( flag );
            Assert.AreEqual( "99", rslt[ 0 ] );
            Assert.AreEqual( "-99", rslt[ 1 ] );
            Assert.AreEqual( "99", rslt[ 2 ] );
            Assert.AreEqual( 1, countCalling );

            var secondCallResult = debounced( "a", "b", "c" );
            Assert.AreEqual( 1, countCalling );

            //after wait period time has expired 
            Assert.AreNotSame( tasksRunning[ 0 ], secondCallResult );


            await secondCallResult;

            Assert.AreEqual( "99a", rslt[ 0 ] );
            Assert.AreEqual( "-99b", rslt[ 1 ] );
            Assert.AreEqual( "99c", rslt[ 2 ] );
            Assert.AreEqual( 2, countCalling );

        }


        [TestMethod]
        public async Task ActionDebounce4( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var locking = new object( );
            var waitingFor = 50;
            var timer = new Stopwatch( );


            var rslt = new[ ] { "", "","","" };
            int countCalling = 0;
            var debouncing  = new Action<string, string, string,string>( ( i, j, k,l ) =>
            {
                flag = true;
                //should still only be the last called item
                rslt[ 0 ] += i;
                rslt[ 1 ] += j;
                rslt[ 2 ] += k;
                rslt[ 3 ] += l;
                countCalling++;
            } );

            var debounced = 
                testing.Debounce( debouncing, waitingFor );

            var tasksRunning = new List<Task>( );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( false, flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            timer.Start( );
            for ( int i=0 ; i < 100 ; i++ )
                tasksRunning.Add( debounced( i.ToString( ), ( -i ).ToString( ), i.ToString( ), (-i).ToString( ) ) );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            foreach ( var task in tasksRunning )
                await task;
            timer.Stop( );

            Assert.IsTrue( timer.ElapsedMilliseconds >= waitingFor );
            Assert.IsTrue( flag );
            
            Assert.AreEqual( "99", rslt[ 0 ] );
            Assert.AreEqual( "-99", rslt[ 1 ] );
            Assert.AreEqual( "99", rslt[ 2 ] );
            Assert.AreEqual( "-99", rslt[ 3 ] );

            Assert.AreEqual( 1, countCalling );

            var secondCallResult = debounced( "a", "b", "c" ,"d");
            Assert.AreEqual( 1, countCalling );

            //after wait period time has expired 
            Assert.AreNotSame( tasksRunning[ 0 ], secondCallResult );


            await secondCallResult;

            Assert.AreEqual( "99a", rslt[ 0 ] );
            Assert.AreEqual( "-99b", rslt[ 1 ] );
            Assert.AreEqual( "99c", rslt[ 2 ] );
            Assert.AreEqual( "-99d", rslt[ 3 ] );
            Assert.AreEqual( 2, countCalling );

        }


        [TestMethod]
        public async Task ActionDebounce5( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var waitingFor = 50;
            var timer = new Stopwatch( );


            var rslt = new[ ] { "", "", "", "","" };
            int countCalling = 0;
            var debouncing  = new Action<string, string, string, string,string>( ( i, j, k, l,m ) =>
            {
                flag = true;
                //should still only be the last called item
                rslt[ 0 ] += i;
                rslt[ 1 ] += j;
                rslt[ 2 ] += k;
                rslt[ 3 ] += l;
                rslt[ 4 ] += m;
                countCalling++;
            } );

            var debounced = 
                testing.Debounce( debouncing, waitingFor );

            var tasksRunning = new List<Task>( );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( false, flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            timer.Start( );
            for ( int i=0 ; i < 100 ; i++ )
                tasksRunning.Add( debounced( i.ToString( ), ( -i ).ToString( ), i.ToString( ), ( -i ).ToString( ), (i).ToString() ) );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            foreach ( var task in tasksRunning )
                await task;
            timer.Stop( );

            Assert.IsTrue( timer.ElapsedMilliseconds >= waitingFor );
            Assert.IsTrue( flag );

            Assert.AreEqual( "99", rslt[ 0 ] );
            Assert.AreEqual( "-99", rslt[ 1 ] );
            Assert.AreEqual( "99", rslt[ 2 ] );
            Assert.AreEqual( "-99", rslt[ 3 ] );
            Assert.AreEqual( "99", rslt[ 4 ] );

            Assert.AreEqual( 1, countCalling );

            var secondCallResult = debounced( "a", "b", "c", "d","e" );
            Assert.AreEqual( 1, countCalling );

            //after wait period time has expired 
            Assert.AreNotSame( tasksRunning[ 0 ], secondCallResult );


            await secondCallResult;

            Assert.AreEqual( "99a", rslt[ 0 ] );
            Assert.AreEqual( "-99b", rslt[ 1 ] );
            Assert.AreEqual( "99c", rslt[ 2 ] );
            Assert.AreEqual( "-99d", rslt[ 3 ] );
            Assert.AreEqual( "99e", rslt[ 4 ] );
            Assert.AreEqual( 2, countCalling );

        }

        [TestMethod]
        public async Task ActionDebounce6( )
        {
            /*
             * Only test needed, all other implementations 
             * will use same mechanism with bind functionality
             */
            var testing = ManipulateDummy( );
            var flag = false;
            var locking = new object( );
            var waitingFor = 50;
            var timer = new Stopwatch( );


            var rslt = new[ ] { "", "", "", "", "","" };
            int countCalling = 0;
            var debouncing  = new Action<string, string, string, string, string,string>( ( i, j, k, l, m,n ) =>
            {
                flag = true;
                //should still only be the last called item
                rslt[ 0 ] += i;
                rslt[ 1 ] += j;
                rslt[ 2 ] += k;
                rslt[ 3 ] += l;
                rslt[ 4 ] += m;
                rslt[ 5 ] += n;
                countCalling++;
            } );

            var debounced = 
                testing.Debounce( debouncing, waitingFor );

            var tasksRunning = new List<Task>( );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            Assert.AreEqual( false, flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            timer.Start( );
            for ( int i=0 ; i < 100 ; i++ )
                tasksRunning.Add( debounced( i.ToString( ), ( -i ).ToString( ), i.ToString( ), ( -i ).ToString( ), ( i ).ToString( ),( -i ).ToString( ) ) );

            //crude but simple and with least amount of variables to screw things up
            Assert.IsFalse( flag );
            for ( int i=0 ; i < rslt.Length ; i++ )
                Assert.AreEqual( "", rslt[ i ] );

            foreach ( var task in tasksRunning )
                await task;
            timer.Stop( );

            Assert.IsTrue( timer.ElapsedMilliseconds >= waitingFor );
            Assert.IsTrue( flag );

            Assert.AreEqual( "99", rslt[ 0 ] );
            Assert.AreEqual( "-99", rslt[ 1 ] );
            Assert.AreEqual( "99", rslt[ 2 ] );
            Assert.AreEqual( "-99", rslt[ 3 ] );
            Assert.AreEqual( "99", rslt[ 4 ] );
            Assert.AreEqual( "-99", rslt[ 5 ] );

            Assert.AreEqual( 1, countCalling );

            var secondCallResult = debounced( "a", "b", "c", "d", "e" ,"f" );
            Assert.AreEqual( 1, countCalling );

            //after wait period time has expired 
            Assert.AreNotSame( tasksRunning[ 0 ], secondCallResult );


            await secondCallResult;

            Assert.AreEqual( "99a", rslt[ 0 ] );
            Assert.AreEqual( "-99b", rslt[ 1 ] );
            Assert.AreEqual( "99c", rslt[ 2 ] );
            Assert.AreEqual( "-99d", rslt[ 3 ] );
            Assert.AreEqual( "99e", rslt[ 4 ] );
            Assert.AreEqual( "-99f", rslt[ 5 ] );
            Assert.AreEqual( 2, countCalling );

        }

        [TestMethod]
        public async Task ActionThrottle( ) 
        {
            var testing = ManipulateDummy();

            string[][] results = Enumerable.Range( 0, 6 ).Select( a => Enumerable.Range(0,a+1).Select(b=>b.ToString()).ToArray( )).ToArray( );

            await Util.Tasks.Start( ( ) =>
            {
                int result = 0;

                var throttling = new System.Action( ( ) => result++);
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                Assert.AreEqual( 0, result );

                for ( int i=0 ; i < 100 ; i++ )
                    tasks.Push( throttled( ) );

                Assert.AreEqual( 1, result );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( 2, result );


            }, ( ) =>
            {
                int index = 0;

                int callCount = 0;

                var throttling = new Action<int>( ( i ) =>
                {
                    results[ index ][ 0 ] = ( i + 1 ).ToString( );
                    callCount++;
                } );
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=0 ; i < 100 ; i++ )
                    tasks.Push( throttled( i ) );

                Assert.AreEqual( 1, callCount );
                Assert.AreEqual( "1", results[ index ][ 0 ] );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( 2, callCount );
                Assert.AreEqual( "100", results[ index ][ 0 ] );

            }, ( ) =>
            {
                int index = 1;

                int callCount = 0;

                var throttling = new Action<int, int>( ( i, j ) =>
                {
                    results[ index ][ 0 ] = ( i ).ToString( );
                    results[ index ][ 1 ] = ( j ).ToString( );
                    callCount++;
                } );
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=1 ; i <= 100 ; i++ )
                    tasks.Push( throttled( i, -i ) );

                Assert.AreEqual( "1", results[ index ][ 0 ] );
                Assert.AreEqual( "-1", results[ index ][ 1 ] );
                Assert.AreEqual( 1, callCount );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( "100", results[ index ][ 0 ] );
                Assert.AreEqual( "-100", results[ index ][ 1 ] );
                Assert.AreEqual( 2, callCount );


            }, ( ) =>
            {
                int index = 2;

                int callCount = 0;

                var throttling = new Action<int, int, int>( ( i, j, k ) =>
                {
                    results[ index ][ 0 ] = ( i ).ToString( );
                    results[ index ][ 1 ] = ( j ).ToString( );
                    results[ index ][ 2 ] = ( k ).ToString( );
                    callCount++;
                } );
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=1 ; i <= 100 ; i++ )
                    tasks.Push( throttled( i, -i, i ) );

                Assert.AreEqual( "1", results[ index ][ 0 ] );
                Assert.AreEqual( "-1", results[ index ][ 1 ] );
                Assert.AreEqual( "1", results[ index ][ 2 ] );
                Assert.AreEqual( 1, callCount );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( "100", results[ index ][ 0 ] );
                Assert.AreEqual( "-100", results[ index ][ 1 ] );
                Assert.AreEqual( "100", results[ index ][ 2 ] );
                Assert.AreEqual( 2, callCount );

            }, ( ) =>
            {
                int index = 3;

                int callCount = 0;

                var throttling = new Action<int, int, int, int>( ( i, j, k, l ) =>
                {
                    results[ index ][ 0 ] = ( i ).ToString( );
                    results[ index ][ 1 ] = ( j ).ToString( );
                    results[ index ][ 2 ] = ( k ).ToString( );
                    results[ index ][ 3 ] = ( l ).ToString( );
                    callCount++;
                } );
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=1 ; i <= 100 ; i++ )
                    tasks.Push( throttled( i, -i, i, -i ) );

                Assert.AreEqual( "1", results[ index ][ 0 ] );
                Assert.AreEqual( "-1", results[ index ][ 1 ] );
                Assert.AreEqual( "1", results[ index ][ 2 ] );
                Assert.AreEqual( "-1", results[ index ][ 3 ] );
                Assert.AreEqual( 1, callCount );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( "100", results[ index ][ 0 ] );
                Assert.AreEqual( "-100", results[ index ][ 1 ] );
                Assert.AreEqual( "100", results[ index ][ 2 ] );
                Assert.AreEqual( "-100", results[ index ][ 3 ] );
                Assert.AreEqual( 2, callCount );

            }, ( ) =>
            {
                int index = 4;


                int callCount = 0;

                var throttling = new Action<int, int, int, int, int>( ( i, j, k, l, m ) =>
                {
                    results[ index ][ 0 ] = ( i ).ToString( );
                    results[ index ][ 1 ] = ( j ).ToString( );
                    results[ index ][ 2 ] = ( k ).ToString( );
                    results[ index ][ 3 ] = ( l ).ToString( );
                    results[ index ][ 4 ] = ( m ).ToString( );
                    callCount++;
                } );
                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=1 ; i <= 100 ; i++ )
                    tasks.Push( throttled( i, -i, i, -i, i ) );

                Assert.AreEqual( "1", results[ index ][ 0 ] );
                Assert.AreEqual( "-1", results[ index ][ 1 ] );
                Assert.AreEqual( "1", results[ index ][ 2 ] );
                Assert.AreEqual( "-1", results[ index ][ 3 ] );
                Assert.AreEqual( "1", results[ index ][ 4 ] );
                Assert.AreEqual( 1, callCount );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( "100", results[ index ][ 0 ] );
                Assert.AreEqual( "-100", results[ index ][ 1 ] );
                Assert.AreEqual( "100", results[ index ][ 2 ] );
                Assert.AreEqual( "-100", results[ index ][ 3 ] );
                Assert.AreEqual( "100", results[ index ][ 4 ] );
                Assert.AreEqual( 2, callCount );


            }, ( ) => {
                int index = 5;


                int callCount = 0;

                var throttling = new Action< int, int, int, int, int, int >( ( i, j, k, l, m,n ) =>
                {
                    results[ index ][ 0 ] = ( i ).ToString( );
                    results[ index ][ 1 ] = ( j ).ToString( );
                    results[ index ][ 2 ] = ( k ).ToString( );
                    results[ index ][ 3 ] = ( l ).ToString( );
                    results[ index ][ 4 ] = ( m ).ToString( );
                    results[ index ][ 5 ] = ( n ).ToString( );
                    callCount++;
                } );

                Stack<Task> tasks = new Stack<Task>( );
                var throttled = testing.Throttle( throttling, 500 );

                for ( int i=1 ; i <= 100 ; i++ )
                    tasks.Push( throttled( i, -i, i, -i,  i , -i ) );

                Assert.AreEqual( "1", results[ index ][ 0 ] );
                Assert.AreEqual( "-1", results[ index ][ 1 ] );
                Assert.AreEqual( "1", results[ index ][ 2 ] );
                Assert.AreEqual( "-1", results[ index ][ 3 ] );
                Assert.AreEqual( "1", results[ index ][ 4 ] );
                Assert.AreEqual( "-1", results[ index ][ 5 ] );
                Assert.AreEqual( 1, callCount );

                while ( tasks.Count != 0 )
                    tasks.Pop( ).Wait( );

                Assert.AreEqual( "100", results[ index ][ 0 ] );
                Assert.AreEqual( "-100", results[ index ][ 1 ] );
                Assert.AreEqual( "100", results[ index ][ 2 ] );
                Assert.AreEqual( "-100", results[ index ][ 3 ] );
                Assert.AreEqual( "100", results[ index ][ 4 ] );
                Assert.AreEqual( "-100", results[ index ][ 5 ] );
                Assert.AreEqual( 2, callCount );

            } );
        }

        [TestMethod]
        public async Task ActionDelay( )
        {
            //if I didn't use this I would lose my mind
            var fn = new ComposeComponent( );
            var testing = ManipulateDummy();

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f"};


            Action<int, Task> TestDelay = ( waitTime, delayed ) =>
            {
                var timer = new Stopwatch( );
                timer.Start( );
                Thread.MemoryBarrier( );
                delayed.Wait( );
                Thread.MemoryBarrier( );
                timer.Stop( );
                Assert.IsTrue( timer.ElapsedMilliseconds >= waitTime - 25 );
            };


            await Util.Tasks.Start(() =>
            {

                string result = "";
                var timer = new Stopwatch();
                var delayed = testing.Delay(() => result = "worked", 100);
                var taskResult = delayed();

                Thread.MemoryBarrier();

                Assert.AreEqual("", result);

                taskResult.Wait();

                Assert.AreEqual("worked", result);


            },( ) =>
                {

                    var invoked = false;

                    var delaying = new Action<string,string>( ( a , b ) =>
                    {
                        Assert.AreEqual( "a", a );
                        Assert.AreEqual( "b", b );
                        invoked = true;
                    } );
                    
                    var delayed = testing.Delay( delaying, 100 );

                    Thread.MemoryBarrier( );
                    
                    TestDelay(100, fn.Apply( delayed, arguments ) );
                    
                    Assert.IsTrue( invoked );

                }, ( ) =>
                {

                    var invoked = false;

                    var delaying = new Action<string,string,string>( ( a, b , c) =>
                    {
                        Assert.AreEqual( "a", a );
                        Assert.AreEqual( "b", b );
                        Assert.AreEqual( "c", c );
                        invoked = true;
                    } );

                    var delayed = testing.Delay( delaying, 100 );

                    Thread.MemoryBarrier( );
                    
                    TestDelay(100, fn.Apply( delayed, arguments ) );
                    
                    Assert.IsTrue( invoked );

                }, ( ) =>
                {

                    var invoked = false;

                    var delaying = new Action<string,string,string,string>( ( a, b, c, d  ) =>
                    {
                        Assert.AreEqual( "a", a );
                        Assert.AreEqual( "b", b );
                        Assert.AreEqual( "c", c );
                        Assert.AreEqual( "d", d );
                        invoked = true;
                    } );

                     var delayed = testing.Delay( delaying, 100 );

                    Thread.MemoryBarrier( );
                    
                    TestDelay(100, fn.Apply( delayed, arguments ) );
                    
                    Assert.IsTrue( invoked );

                }, ( ) =>
                {

                    var invoked = false;

                    var delaying = new Action<string, string, string, string,string>( ( a, b, c, d,e ) =>
                    {
                        Assert.AreEqual( "a", a );
                        Assert.AreEqual( "b", b );
                        Assert.AreEqual( "c", c );
                        Assert.AreEqual( "d", d );
                        Assert.AreEqual( "e", e );
                        invoked = true;
                    } );

                    var timer = new Stopwatch( );
                    var delayed = testing.Delay( delaying, 100 );

                    timer.Start( );

                    Thread.MemoryBarrier( );

                    var task = fn.Apply( delayed, arguments );

                    Thread.MemoryBarrier( );

                    Assert.IsFalse( invoked );

                    task.Wait( );

                    Thread.MemoryBarrier( );

                    Assert.IsTrue( invoked );
                    timer.Stop( );
                    Assert.IsTrue( timer.ElapsedMilliseconds >= 100 );

                }, ( ) =>
                {

                    var invoked = false;

                    var delaying = new Action<string, string, string, string, string,string>( ( a, b, c, d, e, f ) =>
                    {
                        Assert.AreEqual( "a", a );
                        Assert.AreEqual( "b", b );
                        Assert.AreEqual( "c", c );
                        Assert.AreEqual( "d", d );
                        Assert.AreEqual( "e", e );
                        Assert.AreEqual( "f", f );
                        invoked = true;
                    } );

                    var delayed = testing.Delay( delaying, 100 );

                    Thread.MemoryBarrier( );
                    
                    TestDelay(100, fn.Apply( delayed, arguments ) );
                    
                    Assert.IsTrue( invoked );

                } );
        }

        [TestMethod]
        public async Task ActionOnce( ) 
        {
            //if I didn't use this I would lose my mind
            var fn = new global::Underscore.Action.ComposeComponent( );
            var testing = ManipulateDummy( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f","g","h","i","j","k","l","m","n" ,"o","p"};

            await Util.Tasks.Start(()=>{ 
            
                string result = "";
                int counter = 0;
                var timer = new Stopwatch();
                var onced = testing.Once(()=>result=(counter++).ToString());
                for ( int i=0 ; i < 10 ; i++ )
                    onced( );

                Assert.AreEqual( "0", result );

            },( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string,string>( ( a , b ) =>
                {
                    counter++;
                    result = string.Join( "", a, b ,counter);
                    invoked = true;
                } );
                    
                var onced = testing.Once( oncing  );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "ab1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string,string >( ( a, b , c ) =>
                {
                    counter++;
                    result = string.Join( "", a, b,c,  counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abc1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string,string,string>( ( a, b, c,d ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c,d, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcd1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string,string,string>( ( a, b, c, d ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcd1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string,string>( ( a, b, c, d,e ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d,e, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcde1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string,string>( ( a, b, c, d, e, f ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e,f, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdef1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string,string,string>( ( a, b, c, d, e, f,g ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d,e,f,g, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefg1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h , counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefgh1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h,i, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghi1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i,j, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghij1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string,string,string,string>( ( a, b, c, d, e, f, g, h, i, j, k ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i, j, k, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghijk1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string,string,string,string,string>( ( a, b, c, d, e, f, g, h, i, j, k,l ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i, j, k,l, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghijkl1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m,counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghijklm1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string >( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m,n, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghijklmn1", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;

                var counter = 0;
                string result = "";

                var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string,string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) =>
                {
                    counter++;
                    result = string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n,o, counter );
                    invoked = true;
                } );

                var onced = testing.Once( oncing );

                for ( int i=0 ; i < 100 ; i++ )
                    fn.Apply( onced, arguments );

                Assert.AreEqual( "abcdefghijklmno1", result );
                Assert.IsTrue( invoked );


            } );



        }

        [TestMethod]
        public async Task ActionAfter( )
        {
            //if I didn't use this I would lose my mind
            var fn = new ComposeComponent( );
            var testing = ManipulateDummy( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" ,"o","p"};

            await Util.Tasks.Start(()=>
            {
                string result = "";
                int counter = 0;
                var timer = new Stopwatch();
                var aftered = testing.After(3, () => result = (counter++).ToString());

                var tasks = new Task[10];
                for (int i = 0; i < 10; i++)
                    tasks[i] = aftered();

                for (int i = 0; i < 10; i++)
                    tasks[i].Wait();

                Assert.AreEqual("7", result);
            }, ( ) =>
            {

                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string>( ( a, b ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[i] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                
                Assert.AreEqual( "ab1ab2", result );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string>( ( a, b, c ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abc1abc2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string>( ( a, b, c, d ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcd1abcd2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string>( ( a, b, c, d ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcd1abcd2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string>( ( a, b, c, d, e ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcde1abcde2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string>( ( a, b, c, d, e, f ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdef1abcdef2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefg1abcdefg2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefgh1abcdefgh2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghi1abcdefghi2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );


                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghij1abcdefghij2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghijk1abcdefghijk2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghijkl1abcdefghijkl2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual("abcdefghijklm1abcdefghijklm2", result);
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghijklmn1abcdefghijklmn2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                var arr = new Task[ 4 ];

                var counter = 0;
                string result = "";

                var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter );
                    invoked = true;
                } );

                var aftered = testing.After(3, aftering );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ] = fn.Apply( aftered, arguments );

                for ( int i=0 ; i < 4 ; i++ )
                    arr[ i ].Wait( );

                Assert.AreEqual( "abcdefghijklmno1abcdefghijklmno2", result );
                Assert.IsTrue( invoked );


            } );



        }

        [TestMethod]
        public async Task ActionBefore( )
        {
            //if I didn't use this I would lose my mind
            var fn = new global::Underscore.Action.ComposeComponent( );
            var testing = ManipulateDummy( );

            string[] arguments = new[ ] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" ,"o","p"};

            await Util.Tasks.Start( ( ) =>
            {

                string result = "";
                int counter = 0;
                var timer = new Stopwatch( );
                var befored = testing.Before( 2, ( ) => result = ( counter++ ).ToString( ) );
                for ( int i=0 ; i < 10 ; i++ )
                    befored( );

                Assert.AreEqual( "1", result );

            }, ( ) =>
            {

                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string>( ( a, b ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ;i++ )
                    fn.Apply( befored, arguments );

                Assert.AreEqual( "ab1ab2", result );

                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string>( ( a, b, c ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );


                Assert.AreEqual( "abc1abc2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string>( ( a, b, c, d ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcd1abcd2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string>( ( a, b, c, d ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );


                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcd1abcd2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string>( ( a, b, c, d, e ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );
                
                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcde1abcde2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string>( ( a, b, c, d, e, f ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdef1abcdef2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdefg1abcdefg2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );



                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );


                Assert.AreEqual( "abcdefgh1abcdefgh2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );


                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdefghi1abcdefghi2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );


                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdefghij1abcdefghij2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdefghijk1abcdefghijk2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

                      

                Assert.AreEqual( "abcdefghijkl1abcdefghijkl2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {

                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );
         

                Assert.AreEqual( "abcdefghijklm1abcdefghijklm2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );
        

                Assert.AreEqual( "abcdefghijklmn1abcdefghijklmn2", result );
                Assert.IsTrue( invoked );


            }, ( ) =>
            {


                var invoked = false;
                   

                var counter = 0;
                string result = "";

                var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>( ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) =>
                {
                    counter++;
                    result += string.Join( "", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter );
                    invoked = true;
                } );

                var befored = testing.Before( 2, beforing );

                for ( int i=0 ; i < 4 ; i++ )
                    fn.Apply( befored, arguments );

 
                      

                Assert.AreEqual( "abcdefghijklmno1abcdefghijklmno2", result );
                Assert.IsTrue( invoked );


            } );



        }
    }
}
