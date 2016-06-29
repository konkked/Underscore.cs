using System;
using System.Collections.Generic;

namespace Underscore.Collection.Contract
{
    /// <summary>
    /// Utilities that apply set operations to enumerables
    /// </summary>
    public interface ISetComponent
    {
        /// <summary>
        /// Returns an enumerable containing all 
        /// elements from both collections
        /// </summary>
        IEnumerable<T> Union<T>(IEnumerable<T> a, IEnumerable<T> b);

        /// <summary>
        /// Returns an enumerable containing all 
        /// elements from both collections, 
        /// zipped using with
        /// </summary>
        IEnumerable<TResult> UnionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with);

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained by both lists
        /// </summary>
        IEnumerable<T> Intersection<T>(IEnumerable<T> a, IEnumerable<T> b);

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained by both lists,
        /// zipped using with
        /// </summary>
        IEnumerable<TResult> IntersectionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with);

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained in one list but not the other
        /// </summary>
        IEnumerable<T> Difference<T>(IEnumerable<T> a, IEnumerable<T> b);

        /// <summary>
        /// Returns an enumerable containing all
        /// elements contained in one list but not the other,
        /// zipped using with
        /// </summary>
        IEnumerable<TResult> DifferenceBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with);
    }
}
