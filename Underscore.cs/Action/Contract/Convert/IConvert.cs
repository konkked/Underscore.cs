using System;

namespace Underscore.Action
{
	public interface IConvertComponent
	{
		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<object> ToFunction(System.Action action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, object> ToFunction<T1>(Action<T1> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, object> ToFunction<T1, T2>(Action<T1, T2> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, object> ToFunction<T1, T2, T3>(Action<T1, T2, T3> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, object> ToFunction<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, object> ToFunction<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, object> ToFunction<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, object> ToFunction<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action);

		/// <summary>
		/// Returns a function that does the given action and returns null
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, object> ToFunction<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action);
	}
}
