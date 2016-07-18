using System;

namespace Underscore.Action
{
	public partial interface ISynchComponent
	{
		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		System.Action Once(System.Action action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1> Once<T1>(Action<T1> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2> Once<T1, T2>(Action<T1, T2> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3> Once<T1, T2, T3>(Action<T1, T2, T3> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4> Once<T1, T2, T3, T4>(Action<T1, T2, T3, T4> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5> Once<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6> Once<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7> Once<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8> Once<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> action);

		/// <summary>
		///  Creates a version of the function that only runs once, 
		///  all subsequent runs will return the same value
		/// </summary>
		Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> Once<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> action);
	}
}
