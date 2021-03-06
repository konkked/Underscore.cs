﻿using System;
using System.Linq;

namespace Underscore.Action
{
	public class ComposeComponent : IComposeComponent
	{
		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TEnd>(Func<TStart, TEnd> start, Action<TEnd> end)
		{
			return seed => end(start(seed));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TMid, TEnd>(Func<TStart, TMid> start, Func<TMid, TEnd> mid, Action<TEnd> end)
		{
			return seed => end(mid(start(seed)));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TEnd> b, Action<TEnd> end)
		{
			return seed => end(b(a(start(seed))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TEnd> c, Action<TEnd> end)
		{
			return seed => end(c(b(a(start(seed)))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TEnd> d, Action<TEnd> end)
		{
			return seed => end(d(c(b(a(start(seed))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TEnd> e, Action<TEnd> end)
		{
			return seed => end(e(d(c(b(a(start(seed)))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TEnd> f, Action<TEnd> end)
		{
			return seed => end(f(e(d(c(b(a(start(seed))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TEnd> g, Action<TEnd> end)
		{
			return seed => end(g(f(e(d(c(b(a(start(seed)))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TEnd> h, Action<TEnd> end)
		{
			return seed => end(h(g(f(e(d(c(b(a(start(seed))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TEnd> i, Action<TEnd> end)
		{
			return seed => end(i(h(g(f(e(d(c(b(a(start(seed)))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TEnd> j, Action<TEnd> end)
		{
			return seed => end(j(i(h(g(f(e(d(c(b(a(start(seed))))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TEnd> k, Action<TEnd> end)
		{
			return seed => end(k(j(i(h(g(f(e(d(c(b(a(start(seed)))))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TEnd> l, Action<TEnd> end)
		{
			return seed => end(l(k(j(i(h(g(f(e(d(c(b(a(start(seed))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TEnd> m, Action<TEnd> end)
		{
			return seed => end(m(l(k(j(i(h(g(f(e(d(c(b(a(start(seed)))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TEnd> n, Action<TEnd> end)
		{
			return seed => end(n(m(l(k(j(i(h(g(f(e(d(c(b(a(start(seed))))))))))))))));
		}

		/// <summary>
		/// Transforms a chain of function with an ending action into a single action, 
		/// each link in the chain will take the result from the previously invoked link
		/// The returned action takes the parameter of the first function
		/// </summary>
		public Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TLink15, TEnd>(Func<TStart, TLink1> start, Func<TLink1, TLink2> a, Func<TLink2, TLink3> b, Func<TLink3, TLink4> c, Func<TLink4, TLink5> d, Func<TLink5, TLink6> e, Func<TLink6, TLink7> f, Func<TLink7, TLink8> g, Func<TLink8, TLink9> h, Func<TLink9, TLink10> i, Func<TLink10, TLink11> j, Func<TLink11, TLink12> k, Func<TLink12, TLink13> l, Func<TLink13, TLink14> m, Func<TLink14, TLink15> n, Func<TLink15, TEnd> o, Action<TEnd> end)
		{
			return seed => end(o(n(m(l(k(j(i(h(g(f(e(d(c(b(a(start(seed)))))))))))))))));
		}

		/// <summary>
		/// Creates a composition of actions taking the same result and input parameter
		/// </summary>
		public Action<T> Compose<T>(params Action<T>[] actions)
		{
			if (actions == null) return null;

			return t => actions.Aggregate(t, (curr, next) => { next(curr); return curr; });
		}
	}
}
