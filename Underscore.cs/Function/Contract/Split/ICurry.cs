using System;

namespace Underscore.Function
{
	public interface ICurryComponent
	{
		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, TResult>>
			Curry<T0, T1, TResult>(Func<T0, T1, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, TResult>>>
			Curry<T0, T1, T2, TResult>(Func<T0, T1, T2, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>>
			Curry<T0, T1, T2, T3, TResult>(Func<T0, T1, T2, T3, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>>
			Curry<T0, T1, T2, T3, T4, TResult>(Func<T0, T1, T2, T3, T4, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, T1, T2, T3, T4, T5, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function);

		/// <summary>
		/// Translates a function taking multiple arguments into a sequence of functions each taking a single argument
		/// each accepting one parameter associated cardinally 
		/// to the passed actions parameters
		/// final call is an action
		/// </summary>
		/// <param name="function">action to curry</param>
		/// <returns>Function chain resolving back to passed action</returns>
		Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>>
			Curry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function);
	}
}
