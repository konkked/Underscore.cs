using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Collection.Contract
{
    public interface IZipComponent
    {
        /// <summary>
        /// Combines two enumerables into a single enumerable, combining each element with the given function
        /// </summary>
        IEnumerable<TResult> ZipWith<TArg1, TArg2, TResult>(IEnumerable<TArg1> a, IEnumerable<TArg2> b, Func<TArg1, TArg2, TResult> zipper);

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

        // and so on

        /// <summary>
        /// Unzip an enumerable of tuples into a single 
        /// tuple containing separate enumerables 
        /// for each of the values previously in the tuples
        /// </summary>
        Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped);

        // there will be an unzip for every zip
    }
}
