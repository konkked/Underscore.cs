using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public partial interface ISplitComponent
	{
		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, Func<T1, TResult>> Split<T0, T1, TResult>(Func<T0, T1, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, Func<T2, T3, TResult>> Split<T0, T1, T2, T3, TResult>(Func<T0, T1, T2, T3, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, Func<T3, T4, T5, TResult>> Split<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, T1, T2, T3, T4, T5, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, T3, Func<T4, T5, T6, T7, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, T3, T4, Func<T5, T6, T7, T8, T9, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, T3, T4, T5, Func<T6, T7, T8, T9, T10, T11, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function);

		/// <summary>
		/// Halves the passed action as function that returns action that can invoke the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, T3, T4, T5, T6, Func<T7, T8, T9, T10, T11, T12, T13, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function);

		/// <summary>
		/// Halves the passed action
		/// </summary>
		/// <returns>
		/// a function taking first half of arguments 
		/// that returns an action that takes the other half, 
		/// invocation of returned method would be the same as invoking
		/// the passed action with all parameters from the first function call
		/// and the following action call
		/// </returns>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult>> Split<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function);
	}
}
