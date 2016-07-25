using System;
using System.Collections.Generic;

namespace Underscore.Function
{
	public class CacheComponent : ICacheComponent
	{
		private readonly ICompactComponent _fnCompactor;
		private readonly Utility.ICompactComponent _paramCompactor;

		public CacheComponent()
		{
			_fnCompactor = new CompactComponent();
			_paramCompactor = new Utility.CompactComponent();
		}

		public CacheComponent(ICompactComponent fnCompactor, Utility.ICompactComponent paramCompactor)
		{
			_fnCompactor = fnCompactor;
			_paramCompactor = paramCompactor;
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg">The type of the argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg, TResult> Memoize<TArg, TResult>(Func<TArg, TResult> function)
		{
			var localStore = new Dictionary<TArg, TResult>();
			var locking = new object();
			var fn = function;
			return (a) =>
			{
				if (a == null)
					return fn(a);

				if (!localStore.ContainsKey(a))
					lock (locking)
					{
						if (!localStore.ContainsKey(a))
							localStore.Add(a, fn(a));
					}
				return localStore[a];
			};
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
		/// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b) => packedTarget(_paramCompactor.Pack(a, b));
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
		/// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
		/// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c) => packedTarget(_paramCompactor.Pack(a, b, c));
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
		/// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
		/// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
		/// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d) => packedTarget(_paramCompactor.Pack(a, b, c,d));
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
		/// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
		/// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
		/// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
		/// <typeparam name="TArg5">The type of the fifth argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
		{
			var localStore = new Dictionary<Tuple<Tuple<TArg1, TArg2, TArg3, TArg4>, TArg5>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e) => packedTarget(_paramCompactor.Pack(a, b, c, d, e));
		}

		/// <summary>
		/// Creates a memoized version of the passed function
		/// </summary>
		/// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
		/// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
		/// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
		/// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
		/// <typeparam name="TArg5">The type of the fifth argument of the passed function</typeparam>
		/// <typeparam name="TArg6">The type of the sixth argument of the passed function</typeparam>
		/// <typeparam name="TResult">The type of the result of the passed function</typeparam>
		/// <param name="function">The function to memoize</param>
		/// <returns>A memoized version of the passed function</returns>
		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7,Tuple<TArg8>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8,TArg9>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h,i) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9,TArg10>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i,j) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i,j));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10,TArg11>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j,k) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j,k));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
			Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11,TArg12>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j, k,l) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k,l));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
			Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12,TArg13>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j, k, l,m) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l,m));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
			<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
			Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13,TArg14>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j, k, l, m,n) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m,n));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
			<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
				TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14,TArg15>>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n,o) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n,o));
		}

		public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
			<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
				TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
		{
			var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14, TArg15,TArg16>>>, TResult>();
			var fn = function;
			var packedTarget = Memoize(_fnCompactor.Pack(function));
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p));
		}
	}
}
