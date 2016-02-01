using System;
using System.Linq;

// This code has been automatically generated
// if you want to make changes make them on 
// the corresponding the text template file
// Boolean.tt
namespace Underscore.Function
{

	public class BooleanComponent : IBooleanComponent
	{
	
		
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<bool> Negate( Func<bool> fn)
		{
			return ()=>!fn();
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, bool> Negate<T1>( Func<T1, bool> fn)
		{
			return (a)=>!fn(a);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, bool> Negate<T1, T2>( Func<T1, T2, bool> fn)
		{
			return (a,b)=>!fn(a,b);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, bool> Negate<T1, T2, T3>( Func<T1, T2, T3, bool> fn)
		{
			return (a,b,c)=>!fn(a,b,c);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, bool> Negate<T1, T2, T3, T4>( Func<T1, T2, T3, T4, bool> fn)
		{
			return (a,b,c,d)=>!fn(a,b,c,d);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, bool> Negate<T1, T2, T3, T4, T5>( Func<T1, T2, T3, T4, T5, bool> fn)
		{
			return (a,b,c,d,e)=>!fn(a,b,c,d,e);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, bool> Negate<T1, T2, T3, T4, T5, T6>( Func<T1, T2, T3, T4, T5, T6, bool> fn)
		{
			return (a,b,c,d,e,f)=>!fn(a,b,c,d,e,f);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, bool> Negate<T1, T2, T3, T4, T5, T6, T7>( Func<T1, T2, T3, T4, T5, T6, T7, bool> fn)
		{
			return (a,b,c,d,e,f,g)=>!fn(a,b,c,d,e,f,g);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8>( Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> fn)
		{
			return (a,b,c,d,e,f,g,h)=>!fn(a,b,c,d,e,f,g,h);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i)=>!fn(a,b,c,d,e,f,g,h,i);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j)=>!fn(a,b,c,d,e,f,g,h,i,j);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k)=>!fn(a,b,c,d,e,f,g,h,i,j,k);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l)=>!fn(a,b,c,d,e,f,g,h,i,j,k,l);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m)=>!fn(a,b,c,d,e,f,g,h,i,j,k,l,m);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n)=>!fn(a,b,c,d,e,f,g,h,i,j,k,l,m,n);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o)=>!fn(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o);
		}
		
				
		/// <summary>
		/// Negates the logic of the passed function
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Negate<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> fn)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p)=>!fn(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p);
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<bool> Or( params Func<bool>[] fns)
		{
			return ()=>fns.Aggregate(false,(prev,current)=>prev || current());
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, bool> Or<T1>( params Func<T1, bool>[] fns)
		{
			return (a)=>fns.Aggregate(false,(prev,current)=>prev || current(a));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, bool> Or<T1, T2>( params Func<T1, T2, bool>[] fns)
		{
			return (a,b)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, bool> Or<T1, T2, T3>( params Func<T1, T2, T3, bool>[] fns)
		{
			return (a,b,c)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, bool> Or<T1, T2, T3, T4>( params Func<T1, T2, T3, T4, bool>[] fns)
		{
			return (a,b,c,d)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, bool> Or<T1, T2, T3, T4, T5>( params Func<T1, T2, T3, T4, T5, bool>[] fns)
		{
			return (a,b,c,d,e)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, bool> Or<T1, T2, T3, T4, T5, T6>( params Func<T1, T2, T3, T4, T5, T6, bool>[] fns)
		{
			return (a,b,c,d,e,f)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, bool> Or<T1, T2, T3, T4, T5, T6, T7>( params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns)
		{
			return (a,b,c,d,e,f,g)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k,l));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k,l,m));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k,l,m,n));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'or'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> Or<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p)=>fns.Aggregate(false,(prev,current)=>prev || current(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<bool> And( params Func<bool>[] fns)
		{
			return ()=>fns.Aggregate(true,(prev,current)=>prev && current());
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, bool> And<T1>( params Func<T1, bool>[] fns)
		{
			return (a)=>fns.Aggregate(true,(prev,current)=>prev && current(a));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, bool> And<T1, T2>( params Func<T1, T2, bool>[] fns)
		{
			return (a,b)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, bool> And<T1, T2, T3>( params Func<T1, T2, T3, bool>[] fns)
		{
			return (a,b,c)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, bool> And<T1, T2, T3, T4>( params Func<T1, T2, T3, T4, bool>[] fns)
		{
			return (a,b,c,d)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, bool> And<T1, T2, T3, T4, T5>( params Func<T1, T2, T3, T4, T5, bool>[] fns)
		{
			return (a,b,c,d,e)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, bool> And<T1, T2, T3, T4, T5, T6>( params Func<T1, T2, T3, T4, T5, T6, bool>[] fns)
		{
			return (a,b,c,d,e,f)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, bool> And<T1, T2, T3, T4, T5, T6, T7>( params Func<T1, T2, T3, T4, T5, T6, T7, bool>[] fns)
		{
			return (a,b,c,d,e,f,g)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, bool> And<T1, T2, T3, T4, T5, T6, T7, T8>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k,l));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k,l,m));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k,l,m,n));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o));
		}
		
				
		/// <summary>
		/// Creates an aggregate function that is a result of the passed functions being called and being 'and'ed together
		/// </summary>
		public Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool> And<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>( params Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, bool>[] fns)
		{
			return (a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p)=>fns.Aggregate(true,(prev,current)=>prev && current(a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p));
		}
		
		
	}

}