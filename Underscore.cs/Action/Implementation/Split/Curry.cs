using System;

namespace Underscore.Action
{
	public class CurryComponent : ICurryComponent
	{
		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Action<T15>>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action)
		{

			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) => (l) =>
				   (m) => (n) => (o) => (p) =>
						action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Action<T14>>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) => (l) =>
				   (m) => (n) => (o) =>
					   action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Action<T13>>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) => (l) =>
				   (m) => (n) =>
					   action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Action<T12>>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) => (l) =>
				   (m) =>
					   action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Action<T11>>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) => (l) =>
					   action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Action<T10>>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) => (k) =>
					   action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Action<T9>>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
			   (i) => (j) =>
					   action(a, b, c, d, e, f, g, h, i, j);
		}


		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Action<T8>>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8>(Action<T0, T1, T2, T3, T4, T5, T6, T7, T8> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) => (i) =>
					   action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Action<T7>>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6, T7>(Action<T0, T1, T2, T3, T4, T5, T6, T7> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) => (h) =>
					   action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Action<T6>>>>>>> Curry<T0, T1, T2, T3, T4, T5, T6>(Action<T0, T1, T2, T3, T4, T5, T6> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) => (g) =>
					   action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Action<T5>>>>>> Curry<T0, T1, T2, T3, T4, T5>(Action<T0, T1, T2, T3, T4, T5> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) => (f) =>
					   action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Func<T3, Action<T4>>>>> Curry<T0, T1, T2, T3, T4>(Action<T0, T1, T2, T3, T4> action)
		{
			return
				(a) => (b) => (c) => (d) =>
				(e) =>
					   action(a, b, c, d, e);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Func<T2, Action<T3>>>> Curry<T0, T1, T2, T3>(Action<T0, T1, T2, T3> action)
		{
			return
				(a) => (b) => (c) => (d) =>
					   action(a, b, c, d);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Func<T1, Action<T2>>> Curry<T0, T1, T2>(Action<T0, T1, T2> action)
		{
			return
				(a) => (b) => (c) =>
					   action(a, b, c);
		}

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions 
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		public Func<T0, Action<T1>> Curry<T0, T1>(Action<T0, T1> action)
		{
			return
				(a) => (b) => action(a, b);
		}
	}
}
