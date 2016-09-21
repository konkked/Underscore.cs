using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
	public interface IAfterComponent
	{
		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<Task> After(System.Action action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, Task> After<T1>(System.Action<T1> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, Task> After<T1, T2>(System.Action<T1, T2> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, Task> After<T1, T2, T3>(System.Action<T1, T2, T3> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, Task> After<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, Task> After<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> After<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> After<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> After<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count);

		/// <summary>
		///  Returns a version of the passed function 
		///  that only invokes after being called 
		///  a certain number of times,
		/// 
		/// all previous calls will receive 
		/// the first invocation results
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count);
	}
}
