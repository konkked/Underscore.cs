using System;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public partial class SynchComponent
	{
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
			return async () => await target(null);
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
			int doneChanging = 0;

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

						return Task.Run(() =>
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
						return Task.Run(() => function(a));
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
	}
}
