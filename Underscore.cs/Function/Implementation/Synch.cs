using System;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
    public class SynchComponent : ISynchComponent
    {


/* * Reason:
 *  Debounce does an interlocked exchange rather than locking to compare tasks
 *  at times when we are grabbing and exchanging items we don't want to wait on them
 *  leaving the compiler warning is confusing and might cause someone who doesn't understand what is
 *  going on to think there is an issue with the code
 */
#pragma warning disable 

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<Task<TResult>> Debounce<TResult>( Func<TResult> function, int milliseconds)
        {
            Task running  = null;

            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange( ref retv, new { result =  fn() } );
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;

                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Debounce<T, TResult>( Func<T, TResult> function, int milliseconds )
        {
            Task running  = null;

            object lockingon = new object( );


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange( ref retv, new { result =  fn( targ ) } );
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;
                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };
        }
        
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds )
        {
            Task running  = null;


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ1, targ2 ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange( ref retv, new { result = fn(targ1, targ2 ) } );
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;


                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds)
        {
            Task running  = null;



            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ1, targ2, targ3 ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange( ref retv, new { result = fn(targ1, targ2, targ3 ) } );
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;

                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds)
        {
            Task running  = null;



            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ1, targ2, targ3, targ4 ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange(ref retv, new { result = fn(targ1, targ2, targ3, targ4) });
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;

                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };
        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
        {

            Task running  = null;


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ1, targ2, targ3, targ4, targ5 ) =>
            {
                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange(ref retv, new { result = fn(targ1, targ2, targ3, targ4,targ5) });
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;

                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };

        }

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds )
        {


            Task running  = null;

            object lockingon = new object( );


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ1, targ2, targ3, targ4, targ5, targ6 ) =>
            {

                Thread.MemoryBarrier( );

                var curr = Task.Delay( milliseconds );

                Thread.MemoryBarrier( );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange( ref setting, 0 );
                    Interlocked.Exchange( ref isready, 0 );
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    Interlocked.Exchange( ref result, running );

                    if ( result == null )
                    {
                        Thread.MemoryBarrier( );

                        if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0 )
                        {
                            Interlocked.Exchange(ref retv, new { result = fn(targ1, targ2, targ3, targ4,targ5,targ6) });
                            Interlocked.CompareExchange( ref isready, 1, 0 );
                            Interlocked.CompareExchange( ref settingUp, 0, 1 );
                        }

                        break;
                    }

                    await result;

                    Interlocked.CompareExchange( ref running, null, curr );
                }

                while ( true )
                {
                    Thread.MemoryBarrier( );

                    if ( isready == 1 )
                        break;

                    Thread.MemoryBarrier( );

                    Thread.SpinWait( 32 );

                }

                return retv.result;
            };


        }

#pragma warning restore

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task<TResult>> Throttle<TResult>( Func<TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds, true );
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<Task<TResult>> Throttle<TResult>( Func<TResult> function, int milliseconds, bool leading )
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;



            return () =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn();
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object , Task<TResult>> toReturn = async (handle) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn() };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return Throttle(function, milliseconds, true);
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>( Func<T, TResult> function, int milliseconds, bool leading )
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;
            
            var returning = new {result = default(TResult)};
            
            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;



            return (_a) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn(a);
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object,T,Task<TResult>> toReturn = async (handle,ts) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();
                            
                            await Task.Delay(1);

                            if ( finalHandle == handle )
                            {
                                r = new { result = fn(ts) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1) ;

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);
                    
                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a);
                    
                    Thread.MemoryBarrier();
                    
                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds, true );
        }
        
        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading)
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;

            return (_a,_b) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                var b = _b;
                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn(a,b);
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object, T1,T2, Task<TResult>> toReturn = async (handle, t1,t2) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn(t1,t2) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a,b);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds, true );
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading)
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;

            return (_a, _b, _c) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                var b = _b;
                var c = _c;

                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn(a,b,c);
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object, T1, T2, T3, Task<TResult>> toReturn = async (handle, t1, t2,t3) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn(t1, t2,t3) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a, b,c);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds, true );
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading)
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;

            return (_a, _b, _c,_d) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                var b = _b;
                var c = _c;
                var d = _d;

                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn(a, b, c,d);
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object, T1, T2, T3,T4, Task<TResult>> toReturn = async (handle, t1, t2, t3,t4) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn(t1, t2, t3,t4) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a, b, c,d);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds, true );
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading)
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;

            return (_a, _b, _c, _d, _e) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                var b = _b;
                var c = _c;
                var d = _d;
                var e = _e;

                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn( a, b, c, d, e );
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object, T1, T2, T3, T4,T5, Task<TResult>> toReturn = async (handle, t1, t2, t3, t4,t5) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;
                        

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn(t1, t2, t3, t4,t5) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a, b, c, d,e);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds )
        {
            return Throttle( function, milliseconds,true );
        }

        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading)
        {
            int firstTriggered = 0;
            int waitTriggered = 0;
            int cleaningUp = 0;
            int setting = 0;
            int doneSetting = 0;
            object finalHandle = null;
            int doneComparing = 0;

            Task delaying = null;

            var returning = new { result = default(TResult) };

            //issues sometimes occur with mem in closures 
            // (at least in previous .net versions they did)
            // so copying local copy of values just in case
            var fn = function;
            var waitms = milliseconds;
            var lead = leading;

            return (_a, _b, _c, _d, _e,_f) =>
            {
                //issue with a referencing different values at same call
                Thread.MemoryBarrier();
                var a = _a;
                var b = _b;
                var c = _c;
                var d = _d;
                var e = _e;
                var f = _f;

                Thread.MemoryBarrier();
                object localHandle = new object();
                Thread.MemoryBarrier();


                //if the current task enters into a bad state then want the task to continue from the top
                //this would happen on fringes in between invocation strings
                // example:
                //  wait time is 500 ms, the cleanup process takes 1 ms, cleanup starts at 503 ms, call is made
                //  502.9999 ms, the cleanup flag is not set but before the new task is generated the clean flag is 
                //  set, if this occurs want this call to be counted in the next string of invocations
                //  so start from the top
                while (true)
                {

                    //when the reduction process is in effect do not allow other threads to invoke
                    while (cleaningUp == 1) Thread.MemoryBarrier();



                    if (Interlocked.CompareExchange(ref firstTriggered, 1, 0) == 0)
                    {
                        try
                        {
                            //setup current run string
                            Thread.MemoryBarrier();


                            if (lead)
                            {
                                var firstReturned = fn(a, b, c, d, e,f);
                                return Task.Factory.StartNew(() => firstReturned);
                            }
                        }
                        finally
                        {
                            Thread.MemoryBarrier();
                            //set the delay
                            Interlocked.Exchange(ref delaying, Task.Delay(waitms));
                            //return the result value
                            Interlocked.CompareExchange(ref waitTriggered, 1, 0);

                            Interlocked.CompareExchange(ref doneSetting, 0, 1);
                            Interlocked.CompareExchange(ref setting, 0, 1);
                        }

                    }

                    Thread.MemoryBarrier();
                    while (true)
                        if (waitTriggered == 1) break;
                        else
                        {
                            Thread.SpinWait(16);
                            Thread.MemoryBarrier();
                        }


                    Task delayingLocalCopy = null;
                    Interlocked.Exchange(ref delayingLocalCopy, delaying);

                    //in a bad state, start from the top
                    if (delayingLocalCopy == null || cleaningUp == 1)
                        continue;
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref returning, null);
                    Thread.MemoryBarrier();
                    Interlocked.Exchange(ref finalHandle, localHandle);
                    Thread.MemoryBarrier();

                    Func<object, T1, T2, T3, T4, T5, T6, Task<TResult>> toReturn = async (handle, t1, t2, t3, t4, t5,t6) =>
                    {
                        var r = returning;
                        Thread.MemoryBarrier();

                        if (delaying != null)
                            await delaying;

                        // at this point the delay is done, we are cleaning up
                        Interlocked.CompareExchange(ref cleaningUp, 1, 0);


                        Thread.MemoryBarrier();
                        while (finalHandle != null)
                        {
                            Thread.MemoryBarrier();

                            await Task.Delay(1);

                            if (finalHandle == handle)
                            {
                                r = new { result = fn(t1, t2, t3, t4, t5,t6) };
                                Interlocked.Exchange(ref returning, r);

                                Thread.MemoryBarrier();
                                Interlocked.CompareExchange(ref doneComparing, 1, 0);
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref finalHandle, null);
                                return r.result;
                            }

                            Thread.MemoryBarrier();
                            if (finalHandle == null) break;
                        }

                        while (doneComparing == 0) await Task.Delay(1);

                        Interlocked.Exchange(ref r, returning);

                        return r.result;
                    };

                    Thread.MemoryBarrier();

                    Interlocked.Exchange(ref finalHandle, localHandle);

                    Thread.MemoryBarrier();

                    var local = toReturn(localHandle, a, b, c, d, e,f);

                    Thread.MemoryBarrier();

                    Thread.MemoryBarrier();
                    local.ContinueWith(t =>
                    {
                        t.Wait(50);

                        Thread.MemoryBarrier();

                        //all of the tasks should have completed, 
                        // so we can clean up
                        Thread.MemoryBarrier();
                        Interlocked.CompareExchange(ref firstTriggered, 0, 1);
                        Interlocked.CompareExchange(ref waitTriggered, 0, 1);
                        Interlocked.CompareExchange(ref cleaningUp, 0, 1);
                        Thread.MemoryBarrier();
                    });

                    return local;

                }

            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<Task<TResult>> Delay<TResult>( Func<TResult> function, int milliseconds )
        {
            return async ( ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( );
            };
        }
        
        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T, Task<TResult>> Delay<T, TResult>( Func<T, TResult> function, int milliseconds )
        {
            return async ( t ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t );
            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
        public Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>( Func<T1, T2, TResult> function, int milliseconds )
        {
            return async ( t1, t2 ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t1,t2 );
            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, 
        /// delaying execution by passed milliseconds value
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, int milliseconds )
        {
            return async ( t1, t2 , t3) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t1, t2 , t3);
            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, 
        /// delaying execution by passed milliseconds value
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, int milliseconds )
        {
            return async ( t1, t2, t3, t4 ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t1, t2, t3, t4 );
            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, 
        /// delaying execution by passed milliseconds value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds )
        {
            return async ( t1, t2, t3, t4, t5 ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t1, t2, t3, t4, t5 );
            };
        }

        /// <summary>
        /// Creates a delayed version of passed function, 
        /// delaying execution by passed milliseconds value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds )
        {
            return async ( t1, t2, t3, t4, t5,t6 ) =>
            {
                await Task.Delay( milliseconds );
                Thread.MemoryBarrier( );
                return function( t1, t2, t3, t4, t5,t6 );
            };
        }


        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<TResult> Once<TResult>( Func<TResult> function )
        {
            int ran = 0;
            TResult result = default(TResult);

            return ( ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 ) 
                    result = function( );
                

                return result;
            };

        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T, TResult> Once<T, TResult>( Func<T, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, TResult> Once<T1, T2, TResult>( Func<T1, T2, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, TResult> Once<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, TResult> Once<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, TResult> Once<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, TResult> Once<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only invokes once, 
        ///  all subsequent invocations will return the same value as the first one
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Once<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7);
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only invokes once, 
        ///  all subsequent invocations will return the same value as the first one
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only invokes once, 
        ///  all subsequent invocations will return the same value as the first one
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9 );
                

                return result;
            };
        }

        /// <summary>
        ///  Creates a version of the function that only invokes once, 
        ///  all subsequent invocations will return the same value as the first one
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9 , targ10 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9 , targ10 );
               

                return result;
            };
        }
        
        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10 , targ11 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11 );
                

                return result;
            };
        }
        
        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12 );
                

                return result;
            };
        }
        
        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12, targ13 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12 , targ13 );

                return result;
            };
        }
        
        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12, targ13, targ14 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12, targ13, targ14 );
                

                return result;
            };
        }
        
        /// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function )
        {
            int ran = 0;
            TResult result = default( TResult );

            return ( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12, targ13, targ14, targ15 ) =>
            {
                if ( Interlocked.CompareExchange( ref ran, 1, 0 ) == 0 )
                    result = function( targ1, targ2, targ3, targ4, targ5, targ6, targ7, targ8, targ9, targ10, targ11, targ12, targ13, targ14, targ15 );
                

                return result;
            };
        }
        
        /**End Once**/

        /*Start After*/

        /// <summary>
        /// 
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times.
        /// 
        /// All previous calls will receive 
        /// the first invocation results
        /// 
        /// </summary>
        public Func<Task<TResult>> After<TResult>( int count, Func<TResult> function)
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return ( ) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function();

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(function);
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T, Task<TResult>> After<T, TResult>( int count, Func<T, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging=0;

            return (a) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(()=>function(a));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, Task<TResult>> After<T1, T2, TResult>( int count, Func<T1, T2, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a,b) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a,b);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a,b));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, Task<TResult>> After<T1, T2, T3, TResult>( int count, Func<T1, T2, T3, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a,b,c) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a,b,c);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a,b,c));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }
        
        /// <summary>
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, Task<TResult>> After<T1, T2, T3, T4, TResult>( int count, Func<T1, T2, T3, T4, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a,b,c,d) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }
        
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, Task<TResult>> After<T1, T2, T3, T4, T5, TResult>( int count, Func<T1, T2, T3, T4, T5, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> After<T1, T2, T3, T4, T5, T6, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e,f) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e,f));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e,f,g) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e,f,g);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e,f,g));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function )
        {
            int counter = count;
            int doneChanging = 0;

            var first = default( TResult );

            return (a, b, c, d, e, f, g,h) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g,h);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g,h));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h,i) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h,i);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h,i));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i,j) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i,j);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i,j));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i, j,k) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j,k);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j,k));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function )
        {
            int counter = count;

            var first = default( TResult );
            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i, j, k,l) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j, k,l);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j, k,l));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i, j, k, l,m) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j, k, l,m);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;
                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j, k, l,m));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i, j, k, l,m,n) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j, k, l, m,n);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j, k, l, m,n));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function )
        {
            int counter = count;

            var first = default( TResult );

            int doneChanging = 0;


            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n,o) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j, k, l, m, n,o);

                            Thread.MemoryBarrier();
                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {

                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n,o));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
        {
            int counter = count;

            var first = default(TResult);

            int doneChanging = 0;

            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p) =>
            {
                try
                {

                    int thisTask;
                    Thread.MemoryBarrier();
                    if ((thisTask = Interlocked.Decrement(ref counter)) >= 0)
                    {
                        Thread.MemoryBarrier();

                        if (thisTask == 0)
                        {
                            first = function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p);

                            Thread.MemoryBarrier();

                            try
                            {
                                return Task.Factory.StartNew(() => first);
                            }
                            finally
                            {
                                Thread.MemoryBarrier();
                                Interlocked.Exchange(ref doneChanging, 1);
                            }
                        }

                        return Task.Factory.StartNew(() =>
                        {
                            Thread.MemoryBarrier();


                            while (doneChanging == 0)
                            {
                                if (doneChanging == 1)
                                    break;

                                Thread.MemoryBarrier();
                            }

                            return first;

                        });

                    }
                    else
                    {
                        return Task.Factory.StartNew(() => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p));
                    }
                }
                finally
                {
                    Thread.MemoryBarrier();
                }
            };
        }

        /* End After */

        /*Start Before*/

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<TResult> Before<TResult>( int count, Func<TResult> function )
        {
            int counter = count;
            TResult tresult = default(TResult);

            return ( ) =>
            {
                if ( Interlocked.Decrement( ref counter ) >= 0 )
                    return tresult = function( );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T, TResult> Before<T, TResult>( int count, Func<T, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, TResult> Before<T1, T2, TResult>( int count, Func<T1, T2, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>( int count, Func<T1, T2, T3, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a , b , c ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>( int count, Func<T1, T2, T3, T4, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>( int count, Func<T1, T2, T3, T4, T5, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f , g) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k, l ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k, l );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k, l,m ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k, l, m );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k, l, m , n) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k, l, m, n );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o );

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( int count, Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function )
        {
            int counter = count;
            TResult tresult = default( TResult );

            return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p ) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ,p);

                return tresult;
            };
        }

        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function )
        {
            var result = default( TResult );
            int didRun = 0;

            return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) =>
            {
                if ( Interlocked.CompareExchange( ref didRun, 1, 0 ) == 0 )
                    result = function( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p );
                return result;
            };
        }

        /* End Before */

    }
}
