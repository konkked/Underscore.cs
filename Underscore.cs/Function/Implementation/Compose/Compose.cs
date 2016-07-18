using System;
using System.Linq;

namespace Underscore.Function
{
	public partial class ComposeComponent : IComposeComponent
	{
		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TMid, TResult>(Func<TStart,TMid> start, Func<TMid,TResult> end)
		{
			return seed => end (start (seed));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> mid, Func<TLink2,TResult> end)
		{
			return seed => end (mid (start (seed)));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TResult> end)
		{
			return seed => end (b (a (start (seed))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TResult> end)
		{
			return seed => end (c (b (a (start (seed)))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TResult> end)
		{
			return seed => end (d (c (b (a (start (seed))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TResult> end)
		{
			return seed => end (e (d (c (b (a (start (seed)))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TResult> end)
		{
			return seed => end (f (e (d (c (b (a (start (seed))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TResult> end)
		{
			return seed => end (g (f (e (d (c (b (a (start (seed)))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TResult> end)
		{
			return seed => end (h (g (f (e (d (c (b (a (start (seed))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TResult> end)
		{
			return seed => end (i (h (g (f (e (d (c (b (a (start (seed)))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TResult> end)
		{
			return seed => end (j (i (h (g (f (e (d (c (b (a (start (seed))))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TResult> end)
		{
			return seed => end (k (j (i (h (g (f (e (d (c (b (a (start (seed)))))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TResult> end)
		{
			return seed => end (l (k (j (i (h (g (f (e (d (c (b (a (start (seed))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TResult> end)
		{
			return seed => end (m (l (k (j (i (h (g (f (e (d (c (b (a (start (seed)))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TLink15, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TLink15> n, Func<TLink15,TResult> end)
		{
			return seed => end (n (m (l (k (j (i (h (g (f (e (d (c (b (a (start (seed))))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of functions into a single function, 
		/// taking the parameter of the first function
		/// and returning the value from the invocation of the last function
		/// </summary>
		public Func<TStart,TResult> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TLink15, TLink16, TResult>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TLink15> n, Func<TLink15,TLink16> o, Func<TLink16,TResult> end)
		{
			return seed => end (o (n (m (l (k (j (i (h (g (f (e (d (c (b (a (start (seed)))))))))))))))));
		}

		/// <summary>
		/// Creates a composition of function taking the same result and input parameter
		/// </summary>
		public Func<T, T> Compose<T>(params Func<T, T>[] functions)
		{
			var targs = functions;

			if (targs.FirstOrDefault() == null)
				return null;

			if (targs.Skip(1).FirstOrDefault() == null)
				return t => targs[0](t);

			return (t) => targs.Aggregate(t, (curr, next) => next(curr));
		}
	}
}