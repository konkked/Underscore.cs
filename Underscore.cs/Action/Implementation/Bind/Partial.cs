using System;

namespace Underscore.Action
{
	public partial class BindComponent : IBindComponent
	{
		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2> Partial<T1, T2>(Action<T1, T2> action, T1 a)
		{
			return (b) => action(a, b);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a)
		{
			return (b, c) => action(a, b, c);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3> Partial<T1, T2, T3>(Action<T1, T2, T3> action, T1 a, T2 b)
		{
			return (c) => action(a, b, c);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a)
		{
			return (b, c, d) => action(a, b, c, d);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b)
		{
			return (c, d) => action(a, b, c, d);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4> Partial<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, T1 a, T2 b, T3 c)
		{
			return (d) => action(a, b, c, d);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a)
		{
			return (b, c, d, e) => action(a, b, c, d, e);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b)
		{
			return (c, d, e) => action(a, b, c, d, e);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c)
		{
			return (d, e) => action(a, b, c, d, e);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5> Partial<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e) => action(a, b, c, d, e);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a)
		{
			return (b, c, d, e, f) => action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b)
		{
			return (c, d, e, f) => action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f) => action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f) => action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6> Partial<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f) => action(a, b, c, d, e, f);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a)
		{
			return (b, c, d, e, f, g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b)
		{
			return (c, d, e, f, g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7> Partial<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g) => action(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a)
		{
			return (b, c, d, e, f, g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8> Partial<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h) => action(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i) => action(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j) => action(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k) => action(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11, T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T12> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l) => action(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11, T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T12, T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T13> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m) => action(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11, T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T12, T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T13, T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T14> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11, T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T12, T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T13, T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T14, T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n, o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T15> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return (o) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T8, T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T9, T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T10, T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T11, T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T12, T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T13, T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T14, T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n, o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T15, T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return (o, p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		public Action<T16> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
		{
			return (p) => action(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}
	}
}
