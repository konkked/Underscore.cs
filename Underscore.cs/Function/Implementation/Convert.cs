using System;

namespace Underscore.Function
{
	public class ConvertComponent : IConvertComponent
	{
		public System.Action ToAction(Func<object> function)
		{
			return () => function();
		}

		public Action<T1> ToAction<T1>(Func<T1,object> function)
		{

			return (a) => function(a);
		}

		public Action<T1, T2> ToAction<T1, T2>(Func<T1, T2,object> function)
		{
			return (a, b) => function(a, b);
		}

		public Action<T1, T2, T3> ToAction<T1, T2, T3>(Func<T1, T2, T3,object> function)
		{
			return (a, b, c) => function(a, b, c);
		}

		public Action<T1, T2, T3, T4> ToAction<T1, T2, T3, T4>(Func<T1, T2, T3, T4,object> function)
		{
			return (a, b, c, d) => function(a, b, c, d);
		}

		public Action<T1, T2, T3, T4, T5> ToAction<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5,object> function)
		{
			return (a, b, c, d, e) => function(a, b, c, d, e);
		}

		public Action<T1, T2, T3, T4, T5, T6> ToAction<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6,object> function)
		{
			return (a, b, c, d, e, f) => function(a, b, c, d, e, f);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7> ToAction<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7,object> function)
		{
			return (a, b, c, d, e, f, g) => function(a, b, c, d, e, f, g);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8> ToAction<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8,object> function)
		{
			return (a, b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9,object> function)
		{
			return (a, b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j,k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j,k, l, m, n, o);
		}

		public Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> ToAction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16,object> function)
		{
			return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p ) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}
	}
}
