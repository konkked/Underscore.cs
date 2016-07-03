using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public partial interface IBooleanComponent
	{
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
