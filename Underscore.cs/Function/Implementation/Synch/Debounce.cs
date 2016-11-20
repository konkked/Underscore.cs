﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public class DebounceComponent : IDebounceComponent
	{
        private readonly Function.ICompactComponent _fnCompact;
        private readonly Utility.ICompactComponent _utilCompact;

        public DebounceComponent(Function.ICompactComponent fnCompact, Utility.ICompactComponent utilCompact)
        {
            _fnCompact = fnCompact;
            _utilCompact = utilCompact;
        }

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds, bool lockless = false)
		{
			var origFn = function;
			var fn = new Func<object, TResult>(a => origFn());
			var target = Debounce(fn, milliseconds, lockless);
			return async () => await target(null);
		}

#pragma warning disable 4014
		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T, Task<TResult>> Debounce<T, TResult>(Func<T, TResult> function, int milliseconds, bool lockless = false)
		{
		    return lockless ? LocklessDebounce(function, milliseconds) : LockDebounce(function, milliseconds);
		}

	    private Func<T, Task<TResult>> LockDebounce<T, TResult>(Func<T, TResult> function, int milliseconds)
        {
	        var mutex = new object();
	        bool canExecute = true;
            var retv = default(TResult);

	        return async (targ) =>
	        {
	            if (!canExecute)
	                return default(TResult);

	            lock (mutex)
	            {
	                if (!canExecute)
	                    return default(TResult);

	                canExecute = false;
	                retv = function(targ);
	            }

                await Task.Delay(milliseconds);
	            canExecute = true;

                return default(TResult);
	        };
        }

	    private Func<T, Task<TResult>> LocklessDebounce<T, TResult>(Func<T, TResult> function, int milliseconds, bool lockless = false)
	    {
            Task running = null;

            int settingUp = 0;
            int setting = 0;
            int isReady = 0;
            var retv = new { result = default(TResult) };
            var fn = function;
            return async (targ) =>
            {
                var curr = Task.Delay(milliseconds);

                if (Interlocked.CompareExchange(ref settingUp, 1, 0) == 0)
                {
                    Interlocked.Exchange(ref isReady, 0);
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
                        Interlocked.CompareExchange(ref isReady, 1, 0);
                    }

                    break;
                }

                while (isReady == 0) await Task.Delay(1);

                return retv.result;
            };
        }
#pragma warning restore 4014

        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
        public Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b) => await target(_utilCompact.Pack(a, b));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c) => await target(_utilCompact.Pack(a, b, c));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d) => await target(_utilCompact.Pack(a, b, c, d));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e) => await target(_utilCompact.Pack(a, b, c, d, e));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f) => await target(_utilCompact.Pack(a, b, c, d, e, f));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g) => await target(_utilCompact.Pack(a, b, c, d, e, f, g));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k, l) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
		}


		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds, bool lockless = false)
		{

			var origFn = function;
			var fn = _fnCompact.Pack(origFn);
			var target = Debounce(fn, milliseconds, lockless);
			return async (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => await target(_utilCompact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
		}
	}
}
