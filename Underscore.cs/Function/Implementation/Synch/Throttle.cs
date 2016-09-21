using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public class ThrottleComponent : IThrottleComponent
	{
        private Utility.MathComponent _math;
        private Function.CompactComponent _fnCompact;
        private Utility.CompactComponent _utilCompact;

        public ThrottleComponent(Utility.MathComponent math, Function.CompactComponent fnCompact, Utility.CompactComponent utilCompact)
        {
            _fnCompact = fnCompact;
            _utilCompact = utilCompact;
            _math = math;
        }

		/// <summary>
		/// Returns a throttled version of the passed function
		/// </summary>
		public Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds, bool leading)
		{
			var origFn = function;
			var fn = new Func<object, TResult>(a => origFn());
			var target = Throttle(fn, milliseconds, leading);
			return async () => await target(null);
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

		private class ThrottleHandler<TParam, TResult>
		{
			private readonly Func<TParam, TResult> _executing;
			private readonly object _lock = new object();
			private readonly DateTime _stop;
			private readonly Utility.IMathComponent _math;
			private IPicker<TParam> _parameterSelector;
			private FirstSetter<TResult> _executor;
			private readonly bool _leading;


			public ThrottleHandler(Utility.IMathComponent math, Func<TParam, TResult> executing, int milliseconds, bool takeFirst = false)
			{
				_executing = executing;
				_stop = DateTime.Now + new TimeSpan(0, 0, 0, 0, milliseconds);
				_math = math;
				_leading = takeFirst;

				if (_leading)
					_parameterSelector = new FirstPicker<TParam>();
				else
					_parameterSelector = new LastPicker<TParam>();

				_executor = new FirstSetter<TResult>();

			}

			private Tuple<DateTime, TParam> TimestampParameters(TParam parameters)
			{
				return Tuple.Create(DateTime.Now, parameters);
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
				var wtf = (int)(_stop - DateTime.Now).TotalMilliseconds;
				await Task.Delay(_math.Max(0, wtf));
			}
		}
		private Func<T, Task<TResult>> ThrottleImpl<T, TResult>(Func<T, TResult> function, int milliseconds, bool leading = true)
		{
			var fn = function;
			ThrottleHandler<T, TResult> throttler = null;
			var hashset = new HashSet<object>();
			object fnlock = null;
			var sharedLock = new object();
			DateTime firstCalled = DateTime.MinValue;

			return async targ =>
			{

				object localHandle = new object();
				object localLock;
				HashSet<object> localHashset;
				ThrottleHandler<T, TResult> localThrottler;
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
						throttler = new ThrottleHandler<T, TResult>(_math, function, milliseconds, false);

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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
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
			return Throttle(function, milliseconds, true);
		}
	}
}
