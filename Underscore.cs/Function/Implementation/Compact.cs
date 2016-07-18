using System;

namespace Underscore.Function
{
	public class CompactComponent : ICompactComponent
	{
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<T1, T2>, TResult> Pack<T1, T2, TResult>(Func<T1, T2, TResult> function)
		{
			return  a => function(a.Item1, a.Item2);
		}
		
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<T1, T2, T3>, TResult> Pack<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function)
		{
			return  a => function(a.Item1, a.Item2, a.Item3);
		}
		
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<T1, T2, T3, T4>, TResult> Pack<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function)
		{
			return  a => function(a.Item1, a.Item2, a.Item3, a.Item4);
		}
		
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, T5>, TResult> Pack<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, T5, T6>, TResult> Pack<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2, a.Item3);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, T5, T6, T7>, TResult> Pack<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2, a.Item3, a.Item4);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3);
		}
		
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3, a.Item4);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10, T11>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3, a.Item4, a.Item5);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3.Item1, a.Item3.Item2, a.Item3.Item3, a.Item3.Item4);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3.Item1, a.Item3.Item2, a.Item3.Item3, a.Item3.Item4, a.Item4);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3.Item1, a.Item3.Item2, a.Item3.Item3, a.Item3.Item4, a.Item4, a.Item5);
		}
		
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14, T15>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3.Item1, a.Item3.Item2, a.Item3.Item3, a.Item3.Item4, a.Item4, a.Item5, a.Item6);
		}
				
		/// <summary>
		///  Creates a new Function bound to the passed parameter
		/// </summary>
		public Func<Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, Tuple<T13, T14, T15, T16>>,TResult> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function)
		{
			return  a => function(a.Item1.Item1, a.Item1.Item2, a.Item1.Item3, a.Item1.Item4, a.Item2.Item1, a.Item2.Item2, a.Item2.Item3, a.Item2.Item4, a.Item3.Item1, a.Item3.Item2, a.Item3.Item3, a.Item3.Item4, a.Item4.Item1, a.Item4.Item2, a.Item4.Item3, a.Item4.Item4);
		}
	}
}
