using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Function
{
	public interface ICompactComponent
	{
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<T1, T2>, TResult> Pack<T1, T2, TResult>(Func<T1, T2, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<T1, T2, T3>, TResult> Pack<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<T1, T2, T3, T4>, TResult> Pack<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, T5>, TResult> Pack<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, T5, T6>, TResult> Pack<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function);
		
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, T5, T6, T7>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10, T11>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14, T15>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function);
				
		/// <summary>
		///  Creates a new Function with the parameters packed into a single object
		/// </summary>
		Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, Tuple<T13, T14, T15, T16>>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function);
	}
}
