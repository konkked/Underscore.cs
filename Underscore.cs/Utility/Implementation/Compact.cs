using System;

namespace Underscore.Utility
{
	public class CompactComponent : ICompactComponent
	{
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<T1, T2> Pack<T1, T2>(T1 a, T2 b)
		{
			return Tuple.Create(a, b);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<T1, T2, T3> Pack<T1, T2, T3>(T1 a, T2 b, T3 c)
		{
			return Tuple.Create(a, b, c);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<T1, T2, T3, T4> Pack<T1, T2, T3, T4>(T1 a, T2 b, T3 c, T4 d)
		{
			return Tuple.Create(a, b, c, d);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, T5> Pack<T1, T2, T3, T4, T5>(T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), e);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, T5, T6> Pack<T1, T2, T3, T4, T5, T6>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), e, f);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, T5, T6, T7> Pack<T1, T2, T3, T4, T5, T6, T7>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), e, f, g);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>> Pack<T1, T2, T3, T4, T5, T6, T7, T8>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h));
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), i);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), i, j);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, T9, T10, T11> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), i, j, k);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), Tuple.Create(i, j, k, l));
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), Tuple.Create(i, j, k, l), m);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), Tuple.Create(i, j, k, l), m, n);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, T13, T14, T15> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), Tuple.Create(i, j, k, l), m, n, o);
		}
				
		/// <summary>
		///  Creates a tuple of objects segmented into Tuples of 4 
		///  for any argument count greater than 8, with the 
		///  remaining parameters being included at the end 
		///  of the tuple  
		/// </summary>
		public Tuple<Tuple<T1, T2, T3, T4>, Tuple<T5, T6, T7, T8>, Tuple<T9, T10, T11, T12>, Tuple<T13, T14, T15, T16>> Pack<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p)
		{
			return Tuple.Create(Tuple.Create(a, b, c, d), Tuple.Create(e, f, g, h), Tuple.Create(i, j, k, l), Tuple.Create(m, n, o, p));
		}
	}
}
