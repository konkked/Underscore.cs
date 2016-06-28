using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Collection.Contract;

namespace Underscore.Collection.Implementation
{
    public class CompareComponent : ICompareComponent
    {
        //TODO: Implement this
        public bool DeepEquals<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            throw new NotImplementedException();
        }

        public bool IsSorted<T>(IEnumerable<T> collection, bool descending) where T : IComparable
        {
            throw new NotImplementedException();
        }
    }
}
