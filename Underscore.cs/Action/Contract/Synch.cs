using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
    public interface ISynchComponent
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
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action Before(System.Action action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1>  Before<T1>(System.Action<T1> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2>  Before<T1, T2>(System.Action<T1, T2> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3>  Before<T1, T2, T3>(System.Action<T1, T2, T3> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4>  Before<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5>  Before<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6>  Before<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7>  Before<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8>  Before<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int count);
				
        /// <summary>
        /// Returns a version of the passed function 
        /// that will only invoke a certain amount of times
        /// 
        /// All subsequent calls will receive the last invocation result
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>  Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int count);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<Task> Debounce(System.Action action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, Task> Debounce<T1>(System.Action<T1> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, Task> Debounce<T1, T2>(System.Action<T1, T2> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task> Debounce<T1, T2, T3>(System.Action<T1, T2, T3> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task> Debounce<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task> Debounce<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> Debounce<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> Debounce<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<Task> Delay(System.Action action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, Task> Delay<T1>(System.Action<T1> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, Task> Delay<T1, T2>(System.Action<T1, T2> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, Task> Delay<T1, T2, T3>(System.Action<T1, T2, T3> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task> Delay<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> Delay<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> Delay<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action Once(System.Action action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1>  Once<T1>(System.Action<T1> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2>  Once<T1, T2>(System.Action<T1, T2> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3>  Once<T1, T2, T3>(System.Action<T1, T2, T3> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4>  Once<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5>  Once<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6>  Once<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7>  Once<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8>  Once<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action);
				
		/// <summary>
        ///  Creates a version of the function that only runs once, 
        ///  all subsequent runs will return the same value
        /// </summary>
		System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>  Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<Task> Throttle(System.Action action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<Task> Throttle(System.Action action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, Task> Throttle<T1>(System.Action<T1> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, Task> Throttle<T1>(System.Action<T1> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, Task> Throttle<T1, T2>(System.Action<T1, T2> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, Task> Throttle<T1, T2>(System.Action<T1, T2> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(System.Action<T1, T2, T3> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task> Throttle<T1, T2, T3>(System.Action<T1, T2, T3> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>(System.Action<T1, T2, T3, T4, T5> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>(System.Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task> Throttle<T1, T2, T3, T4, T5, T6, T7>(System.Action<T1, T2, T3, T4, T5, T6, T7> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(System.Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action, int milliseconds, bool leading);
		
    }
}
