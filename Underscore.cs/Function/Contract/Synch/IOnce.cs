using System;

namespace Underscore.Function
{
	public partial interface ISynchComponent
	{
		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<TResult> Once<TResult>(Func<TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, TResult> Once<T1, TResult>(Func<T1, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, TResult> Once<T1, T2, TResult>(Func<T1, T2, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, TResult> Once<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, TResult> Once<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, TResult> Once<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, TResult> Once<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, TResult> Once<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function);
	}
}
