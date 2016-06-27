using System;

// This code has been automatically generated
// if you want to make changes make them on 
// the corresponding the text template file
// Compose.tt
namespace Underscore.Action
{
	public interface IComposeComponent
	{
        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Calls the passed action using the passed array of elements as it's parameters
        /// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action , T[] arguments);

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        Action<TStart> Compose<TStart, TEnd>(Func<TStart,TEnd> start, Action<TEnd> end);

        /// <summary>
        /// Creates a sigle composite action from the passed functions
        /// </summary>
        Action<TStart> Compose<TStart, TMid, TEnd>(Func<TStart,TMid> start, Func<TMid,TEnd> mid, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TEnd> b, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TEnd> c, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TEnd> d, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TEnd> e, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TEnd> f, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TEnd> g, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TEnd> h, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TEnd> i, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TEnd> j, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TEnd> k, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TEnd> l, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TEnd> m, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TEnd> n, Action<TEnd> end);

        /// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<TStart> Compose<TStart, TLink1, TLink2, TLink3, TLink4, TLink5, TLink6, TLink7, TLink8, TLink9, TLink10, TLink11, TLink12, TLink13, TLink14, TLink15, TEnd>(Func<TStart,TLink1> start, Func<TLink1,TLink2> a, Func<TLink2,TLink3> b, Func<TLink3,TLink4> c, Func<TLink4,TLink5> d, Func<TLink5,TLink6> e, Func<TLink6,TLink7> f, Func<TLink7,TLink8> g, Func<TLink8,TLink9> h, Func<TLink9,TLink10> i, Func<TLink10,TLink11> j, Func<TLink11,TLink12> k, Func<TLink12,TLink13> l, Func<TLink13,TLink14> m, Func<TLink14,TLink15> n, Func<TLink15,TEnd> o, Action<TEnd> end);

		/// <summary>
        /// Creates a composition of actions, executed in order all sharing the same parameter
        /// </summary>
        Action<T> Compose<T>(params Action<T>[] actions);
	}
}