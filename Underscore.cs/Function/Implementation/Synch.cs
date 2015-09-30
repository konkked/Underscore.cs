using System;
using System.Threading.Tasks;
using System.Threading;
namespace Underscore.Function
{
    public class SynchComponent: ISynchComponent
    {
	

		private readonly ICompactComponent _fnCompact;
		private readonly Utility.ICompactComponent _utilCompact;
	
		public SynchComponent( ICompactComponent fnCompact, Utility.ICompactComponent utilCompact )
		{
			
		_fnCompact = fnCompact;
	
		_utilCompact = utilCompact;
		
		}
	
		
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<Task<TResult>> After<TResult>(Func<TResult> function, int count)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = After(fn, count);
			return async()=>await target(null);
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that only invokes after being called 
        /// a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
        public Func<T, Task<TResult>> After<T, TResult>( Func<T, TResult> function, int count )
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
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, Task<TResult>> After<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b ) => await target(_utilCompact.Pack( a, b ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> After<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c ) => await target(_utilCompact.Pack( a, b, c ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> After<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d ) => await target(_utilCompact.Pack( a, b, c, d ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> After<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e ) => await target(_utilCompact.Pack( a, b, c, d, e ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> After<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f ) => await target(_utilCompact.Pack( a, b, c, d, e, f ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ));
		}

				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = After(fn, count);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ));
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<TResult> Before<TResult>(Func<TResult> function, int count)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = Before(fn, count);
			return ()=>target(null);
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
        public Func<T, TResult> Before<T, TResult>( Func<T, TResult> function, int count )
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
		public Func<T1, T2, TResult> Before<T1, T2, TResult>(Func<T1, T2, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b ) => target( _utilCompact.Pack( a, b ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c ) => target( _utilCompact.Pack( a, b, c ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d ) => target( _utilCompact.Pack( a, b, c, d ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e ) => target( _utilCompact.Pack( a, b, c, d, e ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f ) => target( _utilCompact.Pack( a, b, c, d, e, f ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g ) => target( _utilCompact.Pack( a, b, c, d, e, f, g ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k, l ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) );
		}

				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Before(fn, count);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) );
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = Debounce(fn, milliseconds);
			return async()=>await target(null);
		}


#pragma warning disable 4014
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Debounce<T, TResult>( Func<T, TResult> function, int milliseconds )
        {
            Task running  = null;


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default( TResult ) };
            var fn = function;
            return async ( targ ) =>
            {
                var curr = Task.Delay( milliseconds );

                if ( Interlocked.CompareExchange( ref settingUp, 1, 0 ) == 0 )
                {
                    Interlocked.Exchange(ref isready, 0);
                    Interlocked.Exchange(ref setting, 0);
                }

                Interlocked.Exchange( ref running, curr );

                Task result = null;

                while ( true )
                {

                    Interlocked.Exchange( ref result, running );
                    if (result == null)
                        break;

                    await result;
                    if ( Interlocked.CompareExchange( ref running, null, curr ) != curr ) continue;
                    if ( Interlocked.CompareExchange( ref setting, 1, 0 ) == 0)
                    {
                        Interlocked.Exchange(ref retv, new { result = fn(targ) });
                        Interlocked.CompareExchange(ref settingUp, 0, 1);
                        Interlocked.CompareExchange( ref isready, 1, 0 );
                    }

                    break;
                }

                while (isready == 0) await Task.Delay(1);

                return retv.result;
            };
        }
#pragma warning restore 4014

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b ) => await target(_utilCompact.Pack( a, b ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c ) => await target(_utilCompact.Pack( a, b, c ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d ) => await target(_utilCompact.Pack( a, b, c, d ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e ) => await target(_utilCompact.Pack( a, b, c, d, e ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f ) => await target(_utilCompact.Pack( a, b, c, d, e, f ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<Task<TResult>> Delay<TResult>(Func<TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = Delay(fn, milliseconds);
			return async()=>await target(null);
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
		public Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b ) => await target(_utilCompact.Pack( a, b ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c ) => await target(_utilCompact.Pack( a, b, c ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d ) => await target(_utilCompact.Pack( a, b, c, d ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e ) => await target(_utilCompact.Pack( a, b, c, d, e ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f ) => await target(_utilCompact.Pack( a, b, c, d, e, f ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ));
		}

				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Delay(fn, milliseconds);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ));
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<TResult> Once<TResult>(Func<TResult> function)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = Once(fn);
			return ()=>target(null);
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
		public Func<T1, T2, TResult> Once<T1, T2, TResult>(Func<T1, T2, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b ) => target( _utilCompact.Pack( a, b ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, TResult> Once<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c ) => target( _utilCompact.Pack( a, b, c ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, TResult> Once<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d ) => target( _utilCompact.Pack( a, b, c, d ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, TResult> Once<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e ) => target( _utilCompact.Pack( a, b, c, d, e ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, TResult> Once<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f ) => target( _utilCompact.Pack( a, b, c, d, e, f ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, TResult> Once<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g ) => target( _utilCompact.Pack( a, b, c, d, e, f, g ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k, l ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) );
		}

				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Once(fn);
			return ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => target( _utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) );
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = new Func<object, TResult>(a => origFn());
            var target = Throttle(fn, milliseconds, leading);
			return async()=>await target(null);
		}


#pragma warning disable 4014

        private Func<T, Task<TResult>> LockedThrottle<T, TResult>(Func<T, TResult> function, int milliseconds,
            bool leading)
        {

            var fn = function;
            int invocationStrDone = 0;
            int doneSettingValue = 0;
            object locking = new object();
            Timer previous = null;
            int inThrottle = 0;
            int doneSetting = 0;

            Task currentWaitingOn = null;

            var returning = new {retv = default(TResult)};
            var args = new {args = default(T)};

            int wait = milliseconds;
            return async targ =>
            {
                Task myWaitingOn = null;
                while (invocationStrDone == 1) await Task.Delay(1);

                Monitor.Enter(locking);
                try
                {
                    Interlocked.Increment(ref inThrottle);

                    if (inThrottle == 1)
                    {
                        if (previous != null)
                        {
                            previous.Dispose();
                            previous = null;
                        }
                        
                        currentWaitingOn = Task.Delay(wait);

                        Timer t = null;
                        t = new Timer(o =>
                        {

                            Monitor.Enter(locking);
                            try
                            {
                                Interlocked.Exchange(ref invocationStrDone, 1);
                                Interlocked.Exchange(ref doneSettingValue, 0);
                                Monitor.PulseAll(locking);
                                if (inThrottle > 1)
                                {
                                    var largs = args;

                                    Interlocked.Exchange(ref largs, args);
                                    Interlocked.Exchange(ref returning, new {retv = fn(largs.args)});
                                    Interlocked.Increment(ref doneSettingValue);


                                    while (doneSetting != inThrottle - 1)
                                    {
                                        Monitor.Exit(locking);
                                        Thread.SpinWait(32);
                                        Monitor.Enter(locking);
                                    }

                                    Interlocked.Exchange(ref inThrottle, 0);
                                    Interlocked.Exchange(ref doneSetting, 0);
                                    Interlocked.Exchange(ref currentWaitingOn, null);

                                }
                                Interlocked.Exchange(ref invocationStrDone, 0);
                            }
                            finally
                            {

                                previous = t;
                                t = null;
                                
                                if (Monitor.IsEntered(locking))
                                    Monitor.Exit(locking);
                            }


                        }, null, wait, Timeout.Infinite);

                        try
                        {
                            if (leading)
                                return fn(targ);
                        }
                        finally
                        {
                            doneSetting = 1;
                        }

                    }

                    if (invocationStrDone == 0)
                    {
                        Interlocked.Exchange(ref args, new {args = targ});

                        Thread.MemoryBarrier( );

                        while (doneSetting == 0)
                        {
                            Thread.MemoryBarrier( );
                            Monitor.Exit(locking);
                            await Task.Delay(1);
                            Monitor.Enter(locking);
                        }
                        
                        Thread.MemoryBarrier( );

                        Interlocked.Exchange(ref myWaitingOn, currentWaitingOn);
                    }
                }
                finally
                {
                    if (Monitor.IsEntered(locking)) Monitor.Exit(locking);
                }

                if ( myWaitingOn!=null ) await myWaitingOn;

                var myresult = returning;

                Monitor.Enter(locking);
                try
                {
                    while (doneSettingValue == 0)
                    {
                        Monitor.Exit(locking);
                        await Task.Delay(1);
                        Monitor.Enter(locking);
                    }
                
                    Interlocked.Exchange(ref myresult, returning);
                    Interlocked.Increment(ref doneSetting);
                    Monitor.PulseAll(locking);
                }
                finally
                {
                    if(Monitor.IsEntered(locking)) Monitor.Exit(locking);
                }

                return myresult.retv;



            };


        }


#pragma warning restore 4014
        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>( Func<T, TResult> function, int milliseconds, bool leading )
        {
            return LockedThrottle(function, milliseconds, leading);
        }
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, Task<TResult>> Throttle<T1, TResult>(Func<T1, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b ) => await target(_utilCompact.Pack( a, b ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c ) => await target(_utilCompact.Pack( a, b, c ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d ) => await target(_utilCompact.Pack( a, b, c, d ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e ) => await target(_utilCompact.Pack( a, b, c, d, e ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f ) => await target(_utilCompact.Pack( a, b, c, d, e, f ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async ( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => await target(_utilCompact.Pack( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds)
		{
			return Throttle ( function, milliseconds, true ) ;
		}
		
    }
}
