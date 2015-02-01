using System;
using System.Threading.Tasks;

namespace Underscore.Function
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
		Func<Task<TResult>> After<TResult>(Func<TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, Task<TResult>> After<T1, TResult>(Func<T1, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, Task<TResult>> After<T1, T2, TResult>(Func<T1, T2, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, Task<TResult>> After<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> After<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> After<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> After<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int count);
				
        /// <summary>
        ///  Returns a version of the passed function 
        ///  that only invokes after being called 
        ///  a certain number of times,
        /// 
        /// all previous calls will receive 
        /// the first invocation results
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int count);
				
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
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<Task<TResult>> Debounce<TResult>(Func<TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, Task<TResult>> Debounce<T1, TResult>(Func<T1, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, Task<TResult>> Debounce<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task<TResult>> Debounce<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> Debounce<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> Debounce<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds);
				
        /// <summary>
        /// Returns a debounced version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Debounce<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<Task<TResult>> Delay<TResult>(Func<TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, Task<TResult>> Delay<T1, TResult>(Func<T1, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, Task<TResult>> Delay<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, Task<TResult>> Delay<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> Delay<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> Delay<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds);
				
		/// <summary>
        /// Creates a delayed version of passed function, delaying passed milliseconds value
        /// before executing
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Delay<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds);
				
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
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<Task<TResult>> Throttle<TResult>(Func<TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, Task<TResult>> Throttle<T1, TResult>(Func<T1, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, Task<TResult>> Throttle<T1, TResult>(Func<T1, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, Task<TResult>> Throttle<T1, T2, TResult>(Func<T1, T2, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, Task<TResult>> Throttle<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, Task<TResult>> Throttle<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, Task<TResult>> Throttle<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, int milliseconds, bool leading);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds);
				
		/// <summary>
        /// Returns a throttled version of the passed function
        /// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, Task<TResult>> Throttle<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, int milliseconds, bool leading);
		
    }
}
