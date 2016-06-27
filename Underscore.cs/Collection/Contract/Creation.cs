using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface ICreationComponent 
    {

        /// <summary>
        /// creates a function that always returns a copy of the passed collection at the time it was called
        /// </summary>
        Func<IEnumerable<T>> Snapshot<T>(IEnumerable<T> collection);

        /// <summary>
        /// Returns an enumerable which cycles through collection until it reaches length iterations
        /// </summary>
        IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length);

        /// <summary>
        /// Returns an enumerable which cycles through collection infinitely
        /// </summary>
        IEnumerable<T> Cycle<T>(IEnumerable<T> collection);
    }
}
