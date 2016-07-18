using System;

namespace Underscore.Function
{
	public partial interface IBindComponent
	{
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, TResult>(Func<T1, TResult> function, T1 a);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a, T2 b);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o);

		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p);
	}
}