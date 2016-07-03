using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface ICompareComponent
    {
        /// <summary>
        /// checks if a collection is sorted
        /// </summary>
        bool IsSorted<T>(IEnumerable<T> collection, bool descending = false) where T : IComparable;
    }
}
