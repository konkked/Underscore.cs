using System;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Generic;
namespace Underscore.Function
{
    public class SynchComponent: ISynchComponent
    {
		private readonly ICompactComponent _fnCompact;
		private readonly Utility.ICompactComponent _utilCompact;
        private readonly Utility.IMathComponent _math;

        public SynchComponent(ICompactComponent fnCompact , Utility.ICompactComponent utilCompact , Utility.IMathComponent mathComponent)
        {
            _fnCompact = fnCompact;

            _utilCompact = utilCompact;

            _math = mathComponent;
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
        public Func<T, Task<TResult>> After<T, TResult>(Func<T, TResult> function, int count)
        {
            int counter = count;

            var first = default(TResult);
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
                                return Task.Run(() => first);
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
                        return Task.Run(()=>function(a));
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
			return async (a, b) => await target(_utilCompact.Pack(a, b));
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
			return async (a, b, c) => await target(_utilCompact.Pack(a, b, c));
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
			return async (a, b, c, d) => await target(_utilCompact.Pack(a, b, c, d));
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
			return async (a, b, c, d, e) => await target(_utilCompact.Pack(a, b, c, d, e));
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
			return async (a, b, c, d, e, f) => await target(_utilCompact.Pack(a, b, c, d, e, f));
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
			return async (a, b, c, d, e, f, g) => await target(_utilCompact.Pack(a, b, c, d, e, f, g));
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
			return async (a, b, c, d, e, f, g, h) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
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
			return async (a, b, c, d, e, f, g, h, i) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
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
			return async (a, b, c, d, e, f, g, h, i, j) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
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
			return async (a, b, c, d, e, f, g, h, i, j, k) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
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
        public Func<T, TResult> Before<T, TResult>(Func<T, TResult> function, int count)
        {
            int counter = count;
            TResult tresult = default(TResult);

            return (a) =>
            {
                if (Interlocked.Decrement(ref counter) >= 0)
                    return tresult = function(a);

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
			return (a, b) => target(_utilCompact.Pack(a, b));
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
			return (a, b, c) => target(_utilCompact.Pack(a, b, c));
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
			return (a, b, c, d) => target(_utilCompact.Pack(a, b, c, d));
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
			return (a, b, c, d, e) => target(_utilCompact.Pack(a, b, c, d, e));
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
			return (a, b, c, d, e, f) => target(_utilCompact.Pack(a, b, c, d, e, f));
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
			return (a, b, c, d, e, f, g) => target(_utilCompact.Pack(a, b, c, d, e, f, g));
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
			return (a, b, c, d, e, f, g, h) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
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
			return (a, b, c, d, e, f, g, h, i) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
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
			return (a, b, c, d, e, f, g, h, i, j) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
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
			return (a, b, c, d, e, f, g, h, i, j, k) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
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
        public Func<T, Task<TResult>> Debounce<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            Task running  = null;


            int settingUp = 0;
            int setting = 0;
            int isready = 0;
            var retv = new { result = default(TResult) };
            var fn = function;
            return async (targ) =>
            {
                var curr = Task.Delay(milliseconds);

                if (Interlocked.CompareExchange(ref settingUp, 1, 0) == 0)
                {
                    Interlocked.Exchange(ref isready, 0);
                    Interlocked.Exchange(ref setting, 0);
                }

                Interlocked.Exchange(ref running, curr);

                Task result = null;

                while (true)
                {
                    Interlocked.Exchange(ref result, running);

                    if (result == null)
                        break;

                    await result;
                    if (Interlocked.CompareExchange(ref running, null, curr) != curr) continue;
                    if (Interlocked.CompareExchange(ref setting, 1, 0) == 0)
                    {
                        Interlocked.Exchange(ref retv, new { result = fn(targ) });
                        Interlocked.CompareExchange(ref settingUp, 0, 1);
                        Interlocked.CompareExchange(ref isready, 1, 0);
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
			return async (a, b) => await target(_utilCompact.Pack(a, b));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c) => await target(_utilCompact.Pack(a, b, c));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d) => await target(_utilCompact.Pack(a, b, c, d));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e) => await target(_utilCompact.Pack(a, b, c, d, e));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f) => await target(_utilCompact.Pack(a, b, c, d, e, f));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g) => await target(_utilCompact.Pack(a, b, c, d, e, f, g));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k, l) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
		}

				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Debounce(fn, milliseconds);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
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
        public Func<T, Task<TResult>> Delay<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
            return async (t) =>
            {
                await Task.Delay(milliseconds);
                Thread.MemoryBarrier();
                return function(t);
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
			return async (a, b) => await target(_utilCompact.Pack(a, b));
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
			return async (a, b, c) => await target(_utilCompact.Pack(a, b, c));
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
			return async (a, b, c, d) => await target(_utilCompact.Pack(a, b, c, d));
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
			return async (a, b, c, d, e) => await target(_utilCompact.Pack(a, b, c, d, e));
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
			return async (a, b, c, d, e, f) => await target(_utilCompact.Pack(a, b, c, d, e, f));
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
			return async (a, b, c, d, e, f, g) => await target(_utilCompact.Pack(a, b, c, d, e, f, g));
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
			return async (a, b, c, d, e, f, g, h) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
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
			return async (a, b, c, d, e, f, g, h, i) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
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
			return async (a, b, c, d, e, f, g, h, i, j) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
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
			return async (a, b, c, d, e, f, g, h, i, j, k) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
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
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
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
        public Func<T, TResult> Once<T, TResult>(Func<T, TResult> function)
        {
            int ran = 0;
            TResult result = default(TResult);

            return (targ) =>
            {
                if (Interlocked.CompareExchange(ref ran, 1, 0) == 0)
                    result = function(targ);
                

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
			return (a, b) => target(_utilCompact.Pack(a, b));
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
			return (a, b, c) => target(_utilCompact.Pack(a, b, c));
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
			return (a, b, c, d) => target(_utilCompact.Pack(a, b, c, d));
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
			return (a, b, c, d, e) => target(_utilCompact.Pack(a, b, c, d, e));
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
			return (a, b, c, d, e, f) => target(_utilCompact.Pack(a, b, c, d, e, f));
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
			return (a, b, c, d, e, f, g) => target(_utilCompact.Pack(a, b, c, d, e, f, g));
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
			return (a, b, c, d, e, f, g, h) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
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
			return (a, b, c, d, e, f, g, h, i) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
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
			return (a, b, c, d, e, f, g, h, i, j) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
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
			return (a, b, c, d, e, f, g, h, i, j, k) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
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
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
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


        private interface IPicker<T>
        {
            void Add(T value);
            T Get();
        }

        private class LastPicker<T> : IPicker<T>
        {
            private System.Collections.Concurrent.ConcurrentStack<T> _timestamped = new System.Collections.Concurrent.ConcurrentStack<T>();
            private bool _lastPlaced = false;
            private T _last;
            public void Add(T value)
            {
                _timestamped.Push(value);
            }

            public T Get()
            {

                if (!_lastPlaced)
                {
                    lock (this)
                    {
                        if (!_lastPlaced)
                        {
                            var setting = default(T);
                            bool gotLast = false;

                            while (_timestamped.Count > 0 && !gotLast)
                                gotLast = _timestamped.TryPop(out setting);

                            _last = setting;
                            _lastPlaced = true;
                        }
                    }
                }
                Thread.MemoryBarrier();
                return _last;
            }

        }

        private class FirstPicker<T> : IPicker<T>
        {
            private System.Collections.Concurrent.ConcurrentQueue<T> _timestamped = new System.Collections.Concurrent.ConcurrentQueue<T>();
            private bool _lastPlaced = false;
            private T _last;
            public void Add(T value)
            {
                Thread.MemoryBarrier();
                _timestamped.Enqueue(value);
                Thread.MemoryBarrier();
            }

            public T Get()
            {

                if (!_lastPlaced)
                {
                    lock (this)
                    {
                        if (!_lastPlaced)
                        {
                            var setting = default(T);
                            bool gotLast = false;

                            while (_timestamped.Count > 0 && !gotLast)
                                gotLast = _timestamped.TryDequeue(out setting);

                            _last = setting;
                            _lastPlaced = true;
                        }
                    }
                }
                Thread.MemoryBarrier();
                return _last;
            }

        }

        private class FirstSetter<T>
        {
            private bool wasSet = false;
            private T value;

            public T Get(Func<T> setter)
            {
                if (!wasSet)
                    lock (this)
                        if (!wasSet)
                        {
                            value = setter();
                            wasSet = true;
                        }
                return value;
            }

        }

        private class ThrottleHandler<TParam,TResult>
        {
            private readonly Func<TParam,TResult> _executing;
            private readonly object _lock = new object();
            private readonly DateTime _stop;
            private readonly Utility.IMathComponent _math;
            private IPicker<TParam> _parameterSelector;
            private FirstSetter<TResult> _executor;
            private readonly bool _leading;


            public ThrottleHandler(Utility.IMathComponent math , Func<TParam , TResult> executing , int milliseconds , bool takeFirst = false)
            {
                _executing = executing;
                _stop = DateTime.Now + new TimeSpan(0 , 0 , 0 , 0 , milliseconds);
                _math = math;
                _leading = takeFirst;

                if (_leading)
                    _parameterSelector = new FirstPicker<TParam>();
                else
                    _parameterSelector = new LastPicker<TParam>();

                _executor = new FirstSetter<TResult>();

            }

            private Tuple<DateTime , TParam> TimestampParameters(TParam parameters)
            {
                return Tuple.Create(DateTime.Now , parameters);
            }

            public async Task<TResult> Result(TParam arguments)
            {
                if (!Done())
                    _parameterSelector.Add(arguments);
                

                Thread.MemoryBarrier();

                await DelayDone();
                var parameters = _parameterSelector.Get();

                Thread.MemoryBarrier();
                var result = _executor.Get(() => _executing(parameters));
                return result;
            }

            public bool Done()
            {
                return DateTime.Now > _stop;
            }

            public async Task DelayDone()
            {
                var wtf = (int)( _stop  - DateTime.Now).TotalMilliseconds;
                await Task.Delay(_math.Max(0 , wtf));
            }
        }

        private Func<T , Task<TResult>> ThrottleImpl<T , TResult>(Func<T , TResult> function , int milliseconds , bool leading = true)
        {
            var fn = function;
            ThrottleHandler<T , TResult> throttler = null;
            var hashset = new HashSet<object>();
            object fnlock = null;
            var sharedLock = new object();
            DateTime firstCalled = DateTime.MinValue;

            return async targ =>
            {

                object localHandle = new object();
                object localLock;
                HashSet<object> localHashset;
                ThrottleHandler<T , TResult> localThrottler;
                TResult returning;

                lock (sharedLock)
                {
                    if ((DateTime.Now - firstCalled).TotalMilliseconds >= milliseconds)
                    {
                        fnlock = null;
                        throttler = null;
                        hashset = null;
                        firstCalled = DateTime.Now;
                    }

                    bool isFirst = false;
                    if (fnlock == null)
                    {
                        fnlock = new object();
                        firstCalled = DateTime.Now;
                        isFirst = true;
                    }


                    localLock = fnlock;

                    if (throttler == null)
                        throttler = new ThrottleHandler<T , TResult>(_math , function , milliseconds , false);

                    localThrottler = throttler;

                    if (hashset == null)
                        hashset = new HashSet<object>();

                    localHashset = hashset;


                    if (isFirst && leading)
                    {
                        return fn(targ);
                    }

                }


                lock (localLock)
                    localHashset.Add(localHandle);

                returning = await throttler.Result(targ);

                lock (localLock)
                    localHashset.Remove(localHandle);

                lock (sharedLock)
                    if (localHashset == hashset && localHashset != null && localHashset.Count == 0)
                    {

                        if (localLock == fnlock)
                        {
                            fnlock = null;
                        }

                        if (localThrottler == throttler)
                        {
                            throttler = null;
                        }

                        if (localHashset == hashset)
                        {
                            hashset = null;
                        }

                    }


                return returning;

            };
        }

#pragma warning restore 4014
        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
        /// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
        public Func<T, Task<TResult>> Throttle<T, TResult>(Func<T, TResult> function, int milliseconds, bool leading)
        {
            return ThrottleImpl(function, milliseconds, leading);
        }
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, Task<TResult>> Throttle<T1, TResult>(Func<T1, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b) => await target(_utilCompact.Pack(a, b));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c) => await target(_utilCompact.Pack(a, b, c));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d) => await target(_utilCompact.Pack(a, b, c, d));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e) => await target(_utilCompact.Pack(a, b, c, d, e));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f) => await target(_utilCompact.Pack(a, b, c, d, e, f));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g) => await target(_utilCompact.Pack(a, b, c, d, e, f, g));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k, l) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds, bool leading)
		{
			
            var origFn = function;
            var fn = _fnCompact.Pack(origFn);
            var target = Throttle(fn, milliseconds, leading);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
		}

				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds)
		{
			return Throttle (function, milliseconds, true) ;
		}
		
    }
}
