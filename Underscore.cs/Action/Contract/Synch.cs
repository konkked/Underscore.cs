using System;
using System.Threading.Tasks;

namespace Underscore.Action
{
    public interface ISynchComponent
    {
        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<Task> Debounce( System.Action action, int milliseconds );


        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T,Task> Debounce<T>( Action<T> action, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,Task> Debounce<T1,T2>( Action<T1,T2> action, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3, Task> Debounce<T1,T2,T3>( Action<T1,T2,T3> action, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4, Task> Debounce<T1,T2,T3,T4>( Action<T1,T2,T3,T4> action, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4,T5, Task> Debounce<T1,T2,T3,T4,T5>( Action<T1,T2,T3,T4,T5> action, int milliseconds );

        /// <summary>
        /// Creates a new Debounced version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <param name="action">The action to debounce</param>
        /// <param name="milliseconds">The action to debounce</param>
        /// <returns></returns>
        Func<T1,T2,T3,T4,T5,T6,Task> Debounce<T1,T2,T3,T4,T5,T6>( Action<T1,T2,T3,T4,T5,T6> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<Task> Throttle( System.Action action, int milliseconds );


        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T, Task> Throttle<T>( Action<T> action, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <param name="leading"></param>
        /// <returns></returns>
        Func<T,Task> Throttle<T>( Action<T> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2,Task> Throttle<T1, T2>( Action<T1, T2> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2 , Task> Throttle<T1, T2>( Action<T1, T2> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3,Task> Throttle<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3 , Task> Throttle<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task> Throttle<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4 , Task> Throttle<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, Task> Throttle<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5,Task> Throttle<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, Task> Throttle<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6 , Task> Throttle<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds, bool leading );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<Task> Delay( System.Action action, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T, Task> Delay<T>( Action<T> action, int milliseconds);

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, Task> Delay<T1, T2>( Action<T1, T2> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, Task> Delay<T1, T2, T3>( Action<T1, T2, T3> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task> Delay<T1, T2, T3, T4>( Action<T1, T2, T3, T4> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5,Task> Delay<T1, T2, T3, T4, T5>( Action<T1, T2, T3, T4, T5> action, int milliseconds );

        /// <summary>
        /// Creates a new Throttled version of the passed action, which will delay its execution 
        /// until after the wait period has elapsed since the last call 
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action">The action to Throttle</param>
        /// <param name="milliseconds">The action to Throttle</param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6,Task> Delay<T1, T2, T3, T4, T5, T6>( Action<T1, T2, T3, T4, T5, T6> action, int milliseconds );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        System.Action Once( System.Action action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T> Once<T>( Action<T> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1,T2> Once<T1,T2>( Action<T1,T2> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2,T3> Once<T1, T2,T3>( Action<T1, T2,T3> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3,T4> Once<T1, T2, T3,T4>( Action<T1, T2, T3,T4> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4,T5> Once<T1, T2, T3, T4,T5>( Action<T1, T2, T3, T4,T5> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5,T6> Once<T1, T2, T3, T4, T5,T6>( Action<T1, T2, T3, T4, T5,T6> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6,T7> Once<T1, T2, T3, T4, T5, T6,T7>( Action<T1, T2, T3, T4, T5, T6,T7> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7,T8> Once<T1, T2, T3, T4, T5, T6, T7,T8>( Action<T1, T2, T3, T4, T5, T6, T7,T8> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8,T9> Once<T1, T2, T3, T4, T5, T6, T7, T8,T9>( Action<T1, T2, T3, T4, T5, T6, T7, T8,T9> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9,T10> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10,T11> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11,T12> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12,T13> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,T14> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14,T15> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16>( Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<Task> After( int count , System.Action action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T, Task > After<T>( int count , Action<T> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, Task > After<T1, T2>( int count , Action<T1, T2> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, Task > After<T1, T2, T3>( int count , Action<T1, T2, T3> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, Task > After<T1, T2, T3, T4>( int count , Action<T1, T2, T3, T4> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, Task > After<T1, T2, T3, T4, T5>( int count , Action<T1, T2, T3, T4, T5> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, Task > After<T1, T2, T3, T4, T5, T6>( int count , Action<T1, T2, T3, T4, T5, T6> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, Task > After<T1, T2, T3, T4, T5, T6, T7>( int count , Action<T1, T2, T3, T4, T5, T6, T7> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, Task > After<T1, T2, T3, T4, T5, T6, T7, T8>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// 
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// 
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13,Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action );

        /// <summary>
        /// Creates a version of the function that will only execute After
        /// </summary>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, Task > After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( int count , Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="action"></param>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <returns></returns>
        Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16, Task> After<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16> action );


        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        System.Action Before( int count, System.Action action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T> Before<T>( int count, Action<T> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2> Before<T1, T2>( int count, Action<T1, T2> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3> Before<T1, T2, T3>( int count, Action<T1, T2, T3> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4> Before<T1, T2, T3, T4>( int count, Action<T1, T2, T3, T4> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5> Before<T1, T2, T3, T4, T5>( int count, Action<T1, T2, T3, T4, T5> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6> Before<T1, T2, T3, T4, T5, T6>( int count, Action<T1, T2, T3, T4, T5, T6> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7> Before<T1, T2, T3, T4, T5, T6, T7>( int count, Action<T1, T2, T3, T4, T5, T6, T7> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8> Before<T1, T2, T3, T4, T5, T6, T7, T8>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action );

        /// <summary>
        /// Creates a version of the function that will only execute Before
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action );

        /// <summary>
        /// Creates a version of the function that will only execute once
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <typeparam name="T3"></typeparam>
        /// <typeparam name="T4"></typeparam>
        /// <typeparam name="T5"></typeparam>
        /// <typeparam name="T6"></typeparam>
        /// <typeparam name="T16"></typeparam>
        /// <typeparam name="T15"></typeparam>
        /// <typeparam name="T14"></typeparam>
        /// <typeparam name="T13"></typeparam>
        /// <typeparam name="T12"></typeparam>
        /// <typeparam name="T11"></typeparam>
        /// <typeparam name="T10"></typeparam>
        /// <typeparam name="T9"></typeparam>
        /// <typeparam name="T8"></typeparam>
        /// <typeparam name="T7"></typeparam>
        /// <param name="count"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16> Before<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16>( int count, Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15,T16> action );
    }
}
