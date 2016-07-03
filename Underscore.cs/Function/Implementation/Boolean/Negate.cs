using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public partial class BooleanComponent : IBooleanComponent
	{
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<bool> Negate(Func<bool> fn)
		{
			return () => !fn();
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, bool> Negate<T1>(Func<T1, bool> fn)
		{
			return (a) => !fn(a);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, bool> Negate<T1, T2>(Func<T1, T2, bool> fn)
		{
			return (a, b) => !fn(a, b);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, bool> Negate<T1, T2, T3>(Func<T1, T2, T3, bool> fn)
		{
			return (a, b, c) => !fn(a, b, c);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, bool> Negate<T1, T2, T3, T4>(Func<T1, T2, T3, T4, bool> fn)
		{
			return (a, b, c, d) => !fn(a, b, c, d);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, bool> Negate<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, bool> fn)
		{
			return (a, b, c, d, e) => !fn(a, b, c, d, e);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, bool> Negate<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, bool> fn)
		{
			return (a, b, c, d, e, f) => !fn(a, b, c, d, e, f);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, bool> Negate<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, bool> fn)
		{
			return (a, b, c, d, e, f, g) => !fn(a, b, c, d, e, f, g);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> fn)
		{
			return (a, b, c, d, e, f, g, h) => !fn(a, b, c, d, e, f, g, h);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i) => !fn(a, b, c, d, e, f, g, h, i);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j) => !fn(a, b, c, d, e, f, g, h, i, j);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k) => !fn(a, b, c, d, e, f, g, h, i, j, k);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l) => !fn(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => !fn(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => !fn(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => !fn(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> fn)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => !fn(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}
	}
}
