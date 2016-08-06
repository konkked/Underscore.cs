using System;
using System.Collections.Generic;
using Underscore.Utility;

namespace Underscore.Module
{
	public class Utility :
		ICompactComponent,
		IFunctionComponent,
		IMathComponent,
		IObjectComponent,
		IStringComponent
	{
		private readonly ICompactComponent _compact;
		private readonly IFunctionComponent _function;
		private readonly IMathComponent _math;
		private readonly IObjectComponent _object;
		private readonly IStringComponent _string;

		public Utility(
			ICompactComponent compact,
			IFunctionComponent function,
			IMathComponent math,
			IObjectComponent obj,
			IStringComponent str)
		{
			if (compact == null)
				throw new ArgumentNullException("compact");

			if (function == null)
				throw new ArgumentNullException("function");

			if (math == null)
				throw new ArgumentNullException("math");

			if (obj == null)
				throw new ArgumentNullException("obj");

			if (str == null)
				throw new ArgumentNullException("str");

			_compact = compact;
			_math = math;
			_function = function;
			_object = obj;
			_string = str;
		}

		/// <summary>
		/// Creates a unique id (Guid as a string) with a prefix string
		/// </summary>
		public string UniqueId(string prefix)
		{
			return _math.UniqueId(prefix);
		}

		/// <summary>
		/// Creates a unique id (Guid as a string)
		/// </summary>
		public string UniqueId()
		{
			return _math.UniqueId();
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random()
		{
			return _math.Random();
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random(int max)
		{
			return _math.Random(max);
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random(int min, int max)
		{
			return _math.Random(min, max);
		}

		/// <summary>
		/// A method that does nothing
		/// </summary>
		public void Noop()
		{
			_function.Noop();
		}

		/// <summary>
		/// Creates a function that returns the constant that was passed
		/// </summary>
		public Func<T> Constant<T>(T value)
		{
			return _function.Constant(value);
		}

		/// <summary>
		/// Returns true if the object is truthy (similair to javascript)
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		public bool IsTruthy(object o)
		{
			return _object.IsTruthy(o);
		}

		/// <summary>
		/// Returns the absolute value of the int passed
		/// </summary>
		public int Abs(int i)
		{
			return _math.Abs(i);
		}

		/// <summary>
		/// Returns the min value between the two ints
		/// </summary>
		public int Min(int x, int y)
		{
			return _math.Min(x, y);
		}

		/// <summary>
		/// Returns the max value between the two ints
		/// </summary>
		public int Max(int x, int y)
		{
			return _math.Max(x, y);
		}

		public Tuple<T1, T2> Pack<T1, T2>(T1 a, T2 b)
		{
			return _compact.Pack(a, b);
		}

		public Tuple<T1, T2, T3> Pack<T1, T2, T3>(T1 a, T2 b, T3 c)
		{
			return _compact.Pack(a, b, c);
		}

		public Tuple<T1, T2, T3, T4> Pack<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
		{
			return _compact.Pack(a, b, c, d);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, T5> Pack<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return _compact.Pack(a, b, c, d, e);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, T5, T6> Pack<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return _compact.Pack(a, b, c, d, e, f);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, T5, T6, T7> Pack<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return _compact.Pack(a, b, c, d, e, f, g);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>> Pack<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10, T11> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14, T15> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, Tuple<T13, T14, T15, T16>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
		{
			return _compact.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		public string ToCamelCase(string s)
		{
			return _string.ToCamelCase(s);
		}

		public bool IsCamelCase(string s)
		{
			return _string.IsCamelCase(s);
		}

		public string ToPascalCase(string s)
		{
			return _string.ToPascalCase(s);
		}

		public bool IsPascalCase(string s)
		{
			return _string.IsPascalCase(s);
		}

		public string Capitalize(string s)
		{
			return _string.Capitalize(s);
		}

		public bool IsCapitalized(string s)
		{
			return _string.IsCapitalized(s);
		}

		public string ToSnakeCase(string s)
		{
			return _string.ToSnakeCase(s);
		}

		public bool IsSnakeCase(string s)
		{
			return _string.IsSnakeCase(s);
		}

		public string ToKebabCase(string s)
		{
			return _string.ToKebabCase(s);
		}

		public bool IsKebabCase(string s)
		{
			return _string.IsKebabCase(s);
		}

		public IEnumerable<string> Words(string s)
		{
			return _string.Words(s);
		}
	}
}
