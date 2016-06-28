using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Collection.Contract;

namespace Underscore.Collection.Implementation
{
    public class SetComponent : ISetComponent
    {
        //TODO: Implement this
        public IEnumerable<T> Difference<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> DifferenceBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Intersection<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> IntersectionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Union<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> UnionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with)
        {
            throw new NotImplementedException();
        }
    }
}
