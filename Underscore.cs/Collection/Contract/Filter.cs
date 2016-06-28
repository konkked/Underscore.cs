using System;
using System.Collections.Generic;

namespace Underscore.Collection.Contract
{
    public interface IFilterComponent
    {
        /// <summary>
        /// Returns an enumerable containing
        /// all unique elements from the
        /// given collection
        /// </summary>
        IEnumerable<T> Unique<T>(IEnumerable<T> collection);

        /// <summary>
        /// Returns an enumerable containing
        /// all elements from the given collection
        /// which produce a unique result from
        /// the given function
        /// </summary>
        IEnumerable<TResult> UniqueBy<TArg, TResult>(IEnumerable<TArg> collection, Func<TArg, TResult> iteratee);

        /// <summary>
        /// drops the given number of elements
        /// from the front of the collection
        /// </summary>
        IEnumerable<T> Drop<T>(IEnumerable<T> collection, int count);

        /// <summary>
        /// Drops elements from the front
        /// of a collection as long
        /// as the predicate is true
        /// </summary>
        IEnumerable<T> DropWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate);

        /// <summary>
        /// Takes the given number of elements
        /// from the end of the collection,
        /// ordered as they were in the
        /// original collection
        /// </summary>
        IEnumerable<T> TakeRight<T>(IEnumerable<T> collection, int count);

        /// <summary>
        /// Takes elements from the end of
        /// the collection as long as the
        /// given predicate is true,
        /// ordered as they were in the
        /// original collection
        /// </summary>
        IEnumerable<T> TakeRightWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate);

        /// <summary>
        /// Removes any occurrences of 
        /// the specified parameters
        /// from the collection
        /// </summary>
        IEnumerable<T> Pull<T>(IEnumerable<T> collection, params T[] toPull);
    }
}
