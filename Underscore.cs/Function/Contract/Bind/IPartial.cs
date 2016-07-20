using System;

namespace Underscore.Function
{
	public partial interface IBindComponent
	{
		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, TResult> Partial<T1, T2, TResult>( Func<T1, T2, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, TResult> Partial<T1, T2, T3, TResult>( Func<T1, T2, T3, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>( Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>( Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>( Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n );

		/// <summary>
		/// Binds the function partially, from left to right
		/// </summary>
		Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>( Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o );
	}
}