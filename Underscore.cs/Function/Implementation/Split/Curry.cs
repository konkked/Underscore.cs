using System;

namespace Underscore.Function
{
	public class CurryComponent : ICurryComponent
	{
		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
						(e) => (f) => (g) => (h) =>
							(i) => (j) => (k) => (l) =>
								(m) => (n) => (o) => (p) =>
									function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
						(e) => (f) => (g) => (h) =>
							(i) => (j) => (k) => (l) =>
								(m) => (n) => (o) =>
									function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
						(e) => (f) => (g) => (h) =>
							(i) => (j) => (k) => (l) =>
								(m) => (n) =>
									function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
				   (i) => (j) => (k) => (l) =>
					   (m) =>
						   function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
				   (i) => (j) => (k) => (l) =>
						   function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
				   (i) => (j) => (k) =>
						   function(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
				   (i) => (j) =>
						   function(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
				   (i) =>
						   function(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) => (h) =>
						   function(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) => (g) =>
						   function(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> Curry<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, T1, T2, T3, T4, T5, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
			   (e) => (f) =>
						   function(a, b, c, d, e, f);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> Curry<T0, T1, T2, T3, T4, TResult>(Func<T0, T1, T2, T3, T4, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
				(e) =>
				  function(a, b, c, d, e);
		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> Curry<T0, T1, T2, T3, TResult>(Func<T0, T1, T2, T3, TResult> function)
		{
			return (a) => (b) => (c) => (d) =>
				  function(a, b, c, d);

		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, Func<T2, TResult>>> Curry<T0, T1, T2, TResult>(Func<T0, T1, T2, TResult> function)
		{
			return (a) => (b) => (c) => function(a, b, c);

		}

		/// <summary>
		/// Splits functions into a chain of functions
		/// </summary>
		public Func<T0, Func<T1, TResult>> Curry<T0, T1, TResult>(Func<T0, T1, TResult> function)
		{
			return (a) => (b) => function(a, b);
		}
	}
}
