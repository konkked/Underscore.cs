using System;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public class DelayComponent : IDelayComponent
	{
        private Function.CompactComponent _fnCompact;
        private Utility.CompactComponent _utilCompact;

        public DelayComponent(Function.CompactComponent fnCompact, Utility.CompactComponent utilCompact)
        {
            _fnCompact = fnCompact;
            _utilCompact = utilCompact;
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
			return async () => await target(null);
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
	}
}
