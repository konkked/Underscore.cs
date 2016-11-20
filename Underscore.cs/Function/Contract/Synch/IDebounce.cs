using System;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public interface IDebounceComponent
	{
		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, Task<TResult>> Debounce<T1, TResult>(Func<T1, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds, bool lockless = false);

		/// <summary>
		/// Returns a debounced version of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds, bool lockless = false);
	}
}
