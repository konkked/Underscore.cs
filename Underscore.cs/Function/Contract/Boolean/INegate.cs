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
	}
}
