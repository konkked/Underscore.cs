using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
	public interface IZipComponent
	{
		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(IEnumerable<T1> a, IEnumerable<T2> b);

		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c);

		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d);

		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e);

		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e, IEnumerable<T6> f);

		/// <summary>
		/// zips collections together into tuples
		/// of each collections' elements by index
		/// </summary>
		IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e, IEnumerable<T6> f, IEnumerable<T7> g);
	}
}
