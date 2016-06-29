using System;
using System.Threading;

namespace Underscore.Function
{
	public partial class SynchComponent : ISynchComponent
	{
		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		public Func<TResult> Once<TResult>(Func<TResult> function)
		{

			var origFn = function;
			var fn = new Func<object, TResult>(a => origFn());
			var target = Once(fn);
			return () => target(null);
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
	}
}
