using System;

namespace Underscore.Action
{
	public class ConvertComponent : IConvertComponent
	{
		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<object> ToFunction(System.Action action)
		{
			return () =>
			{
				action();
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, object> ToFunction<T1>(Action<T1> action)
		{
			return a =>
			{
				action(a);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, object> ToFunction<T1, T2>(Action<T1, T2> action)
		{
			return (a, b) =>
			{
				action(a, b);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, object> ToFunction<T1, T2, T3>(Action<T1, T2, T3> action)
		{
			return (a, b, c) =>
			{
				action(a, b, c);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, object> ToFunction<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action)
		{
			return (a, b, c, d) =>
			{
				action(a, b, c, d);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, object> ToFunction<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action)
		{
			return (a, b, c, d, e) =>
			{
				action(a, b, c, d, e);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, object> ToFunction<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action)
		{
			return (a, b, c, d, e, f) =>
			{
				action(a, b, c, d, e, f);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, object> ToFunction<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action)
		{
			return (a, b, c, d, e, f, g) =>
			{
				action(a, b, c, d, e, f, g);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action)
		{
			return (a, b, c, d, e, f, g, h) =>
			{
				action(a, b, c, d, e, f, g, h);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
		{
			return (a, b, c, d, e, f, g, h, i) =>
			{
				action(a, b, c, d, e, f, g, h, i);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
		{
			return (a, b, c, d, e, f, g, h, i, j) =>
			{
				action(a, b, c, d, e, f, g, h, i, j);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k, l);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k, l, m);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
				return null;
			};
		}

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
				return null;
			};
		}
	}
}
