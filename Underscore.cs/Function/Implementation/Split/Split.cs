using System;
namespace Underscore.Function
{
	public partial class SplitComponent : ISplitComponent
	{
		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, T3, T4, T5, T6, T7, Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
		{
			return
				(a, b, c, d, e, f, g, h) =>
					(i, j, k, l, m, n, o, p) =>
						function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, T3, T4, T5, T6, Func<T7, T8, T9, T10, T11, T12, T13, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
		{
			return
				(a, b, c, d, e, f, g) =>
					(h, i, j, k, l, m, n) =>
						function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, T3, T4, T5, Func<T6, T7, T8, T9, T10, T11, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
		{
			return
				(a, b, c, d, e, f) =>
					(g, h, i, j, k, l) =>
						function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, T3, T4, Func<T5, T6, T7, T8, T9, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
		{
			return
				(a, b, c, d, e) =>
					(f, g, h, i, j) =>
						function(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, T3, Func<T4, T5, T6, T7, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function)
		{
			return
				(a, b, c, d) =>
					(e, f, g, h) =>
						function(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, T2, Func<T3, T4, T5, TResult>> Split<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, T1, T2, T3, T4, T5, TResult> function)
		{
			return
				(a, b, c) =>
					(d, e, f) =>
						function(a, b, c, d, e, f);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, T1, Func<T2, T3, TResult>> Split<T0, T1, T2, T3, TResult>(Func<T0, T1, T2, T3, TResult> function)
		{
			return
				(a, b) =>
					(c, d) =>
						function(a, b, c, d);
		}

		/// <summary>
		/// Halves the passed function
		/// </summary>
		public Func<T0, Func<T1, TResult>> Split<T0, T1, TResult>(Func<T0, T1, TResult> function)
		{
			return
				(a) =>
					(b) =>
						function(a, b);
		}
	}
}
