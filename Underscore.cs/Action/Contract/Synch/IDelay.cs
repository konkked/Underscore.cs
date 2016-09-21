using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public interface IDelayComponent
	{
		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<Task> Delay(System.Action action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, Task> Delay<T1>(Action<T1> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, Task> Delay<T1, T2>(Action<T1, T2> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, Task> Delay<T1, T2, T3>(Action<T1, T2, T3> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> Delay<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds);

		/// <summary>
		/// Creates a delayed version of passed function, delaying passed milliseconds value
		/// before executing
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds);
	}
}
