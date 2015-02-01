using System;

// This code has been automatically generated
// if you want to make changes make them on 
// the corresponding the text template file
// Bind.tt
namespace Underscore.Function
{

	public class BindingComponent : IBindingComponent
	{

		
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, TResult>( Func<T1, TResult> function, T1 a )
		{
			return ( )=>function( a );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, TResult>( Func<T1, T2, TResult> function, T1 a, T2 b )
		{
			return ( )=>function( a, b );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, T1 a, T2 b, T3 c )
		{
			return ( )=>function( a, b, c );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c, T4 d )
		{
			return ( )=>function( a, b, c, d );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e )
		{
			return ( )=>function( a, b, c, d, e );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f )
		{
			return ( )=>function( a, b, c, d, e, f );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g )
		{
			return ( )=>function( a, b, c, d, e, f, g );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h )
		{
			return ( )=>function( a, b, c, d, e, f, g, h );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k, l );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k, l, m );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k, l, m, n );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o );
		}
		
				
		/// <summary>
        ///  Creates a new Function bound to the passed parameter
        /// </summary>
		public Func<TResult> Bind<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o, T16 p )
		{
			return ( )=>function( a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p );
		}
		
		
	}

}

