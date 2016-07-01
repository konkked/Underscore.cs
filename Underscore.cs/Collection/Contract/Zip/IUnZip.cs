using System;
using System.Collections.Generic;

namespace Underscore.Collection.Contract.Zip
{
	public partial interface IZipComponent
	{
		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped);

		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> UnZip<T1, T2, T3>(IEnumerable<Tuple<T1, T2, T3>> zipped);

		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> UnZip<T1, T2, T3, T4>(IEnumerable<Tuple<T1, T2, T3, T4>> zipped);

		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> UnZip<T1, T2, T3, T4, T5>(IEnumerable<Tuple<T1, T2, T3, T4, T5>> zipped);

		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> UnZip<T1, T2, T3, T4, T5, T6>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> zipped);

		/// <summary>
		/// Unzip an enumerable of tuples into a single 
		/// tuple containing separate enumerables 
		/// for each of the values previously in the tuples
		/// </summary>
		Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> UnZip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> zipped);
	}
}
