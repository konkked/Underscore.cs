using System;

namespace Underscore.Function
{

	public class PartialComponent : IPartialComponent
	{

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, TResult> Partial<T1, T2, TResult>(Func<T1, T2, TResult> function, T1 a)
		{
			return (b) => function(a, b);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a)
		{
			return (b, c) => function(a, b, c);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, TResult> Partial<T1, T2, T3, TResult>(Func<T1, T2, T3, TResult> function, T1 a, T2 b)
		{
			return (c) => function(a, b, c);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a)
		{
			return (b, c, d) => function(a, b, c, d);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b)
		{
			return (c, d) => function(a, b, c, d);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, TResult> Partial<T1, T2, T3, T4, TResult>(Func<T1, T2, T3, T4, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d) => function(a, b, c, d);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a)
		{
			return (b, c, d, e) => function(a, b, c, d, e);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b)
		{
			return (c, d, e) => function(a, b, c, d, e);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e) => function(a, b, c, d, e);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, TResult> Partial<T1, T2, T3, T4, T5, TResult>(Func<T1, T2, T3, T4, T5, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e) => function(a, b, c, d, e);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a)
		{
			return (b, c, d, e, f) => function(a, b, c, d, e, f);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f) => function(a, b, c, d, e, f);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f) => function(a, b, c, d, e, f);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f) => function(a, b, c, d, e, f);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, TResult> Partial<T1, T2, T3, T4, T5, T6, TResult>(Func<T1, T2, T3, T4, T5, T6, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f) => function(a, b, c, d, e, f);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g) => function(a, b, c, d, e, f, g);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h) => function(a, b, c, d, e, f, g, h);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i) => function(a, b, c, d, e, f, g, h, i);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j) => function(a, b, c, d, e, f, g, h, i, j);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k) => function(a, b, c, d, e, f, g, h, i, j, k);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T12, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l) => function(a, b, c, d, e, f, g, h, i, j, k, l);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T12, T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T13, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m) => function(a, b, c, d, e, f, g, h, i, j, k, l, m);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T12, T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T13, T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T14, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T12, T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T13, T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T14, T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n, o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T15, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return (o) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a)
		{
			return (b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b)
		{
			return (c, d, e, f, g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c)
		{
			return (d, e, f, g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d)
		{
			return (e, f, g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e)
		{
			return (f, g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f)
		{
			return (g, h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g)
		{
			return (h, i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T9, T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h)
		{
			return (i, j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T10, T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i)
		{
			return (j, k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T11, T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j)
		{
			return (k, l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T12, T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k)
		{
			return (l, m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T13, T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l)
		{
			return (m, n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T14, T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m)
		{
			return (n, o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T15, T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n)
		{
			return (o, p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

        /// <summary>
        /// Binds the function partially, from left to right
        /// </summary>
		public Func<T16, TResult> Partial<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> function, T1 a, T2 b, T3 c, T4 d, T5 e, T6 f, T7 g, T8 h, T9 i, T10 j, T11 k, T12 l, T13 m, T14 n, T15 o)
		{
			return (p) => function(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
		}

	}

}