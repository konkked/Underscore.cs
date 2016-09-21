using System;

namespace Underscore.Function
{
	public interface IBeforeComponent
	{
		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<TResult> Before<TResult>(Func<TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, TResult> Before<T1, TResult>(Func<T1, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, TResult> Before<T1, T2, TResult>(Func<T1, T2, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, TResult> Before<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, TResult> Before<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, TResult> Before<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, TResult> Before<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, TResult> Before<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count);

		/// <summary>
		/// Returns a version of the passed function 
		/// that will only invoke a certain amount of times
		/// 
		/// All subsequent calls will receive the last invocation result
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count);
	}
}
