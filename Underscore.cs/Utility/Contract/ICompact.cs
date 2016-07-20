using System;

namespace Underscore.Utility
{
	public interface ICompactComponent
	{
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<T1, T2> Pack<T1, T2>(T1 a, T2 b);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<T1, T2, T3> Pack<T1, T2, T3>(T1 a, T2 b, T3 c);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<T1, T2, T3, T4> Pack<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, T5> Pack<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e);
		
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, T5, T6> Pack<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, T5, T6, T7> Pack<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>> Pack<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10, T11> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m);
		
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14, T15> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o);
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, Tuple<T13, T14, T15, T16>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p);
	}
}
