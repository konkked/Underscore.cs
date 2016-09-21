using System;

namespace Underscore.Function
{
	public interface IUncurryComponent
	{
		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>
		   Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, Func<T15, TResult>>>>>>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>
		   Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, Func<T14, TResult>>>>>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, Func<T13, TResult>>>>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, Func<T12, TResult>>>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, Func<T11, TResult>>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, Func<T10, TResult>>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, Func<T9, TResult>>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, Func<T8, TResult>>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, T7, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, Func<T7, TResult>>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, T6, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, T6, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, Func<T6, TResult>>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, T5, TResult>
			Uncurry<T0, T1, T2, T3, T4, T5, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, Func<T5, TResult>>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, T4, TResult>
			Uncurry<T0, T1, T2, T3, T4, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, Func<T4, TResult>>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, T3, TResult>
			Uncurry<T0, T1, T2, T3, TResult>(Func<T0, Func<T1, Func<T2, Func<T3, TResult>>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, T2, TResult>
			Uncurry<T0, T1, T2, TResult>(Func<T0, Func<T1, Func<T2, TResult>>> function);

		/// <summary>
		/// Translates a sequence of functions each taking one argument into a single action
		/// </summary>
		Func<T0, T1, TResult>
			Uncurry<T0, T1, TResult>(Func<T0, Func<T1, TResult>> function);
	}
}
