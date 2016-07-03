using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public partial class SynchComponent : ISynchComponent
	{
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
			return () => target(null);
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
	}
}
