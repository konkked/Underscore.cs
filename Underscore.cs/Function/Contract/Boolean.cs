using System;

// This code has been automatically generated
// if you want to make changes make them on 
// the corresponding the text template file
// Boolean.tt
namespace Underscore.Function
{

	public interface IBooleanComponent
	{

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<bool> Negate(Func<bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, bool> Negate<T1>(Func<T1, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, bool> Negate<T1, T2>(Func<T1, T2, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, bool> Negate<T1, T2, T3>(Func<T1, T2, T3, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, bool> Negate<T1, T2, T3, T4>(Func<T1, T2, T3, T4, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, bool> Negate<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, bool> Negate<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, bool> Negate<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> fn);

		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> fn);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<bool> Or(params Func<bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, bool> Or<T1>(params Func<T1, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, bool> Or<T1, T2>(params Func<T1, T2, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, bool> Or<T1, T2, T3>(params Func<T1, T2, T3, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, bool> Or<T1, T2, T3, T4>(params Func<T1, T2, T3, T4, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, bool> Or<T1, T2, T3, T4, T5>(params Func<T1, T2, T3, T4, T5, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, bool> Or<T1, T2, T3, T4, T5, T6>(params Func<T1, T2, T3, T4, T5, T6, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, bool> Or<T1, T2, T3, T4, T5, T6, T7>(params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<bool> And(params Func<bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, bool> And<T1>(params Func<T1, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, bool> And<T1, T2>(params Func<T1, T2, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, bool> And<T1, T2, T3>(params Func<T1, T2, T3, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, bool> And<T1, T2, T3, T4>(params Func<T1, T2, T3, T4, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, bool> And<T1, T2, T3, T4, T5>(params Func<T1, T2, T3, T4, T5, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, bool> And<T1, T2, T3, T4, T5, T6>(params Func<T1, T2, T3, T4, T5, T6, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, bool> And<T1, T2, T3, T4, T5, T6, T7>(params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> And<T1, T2, T3, T4, T5, T6, T7, T8>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns);

		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns);
	}
}