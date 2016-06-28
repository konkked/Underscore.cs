using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Collection.Contract
{
    public interface ICompareComponent
    {
        /// <summary>
        /// checks if a collection is sorted
        /// </summary>
        bool IsSorted<T>(IEnumerable<T> collection, bool descending) where T : IComparable;

        /// <summary>
        /// checks if two enumerables have equivalent sequences,
        /// using deep equality to compare the internal objects
        /// </summary>
        bool DeepEquals<T>(IEnumerable<T> a, IEnumerable<T> b);
    }
}
