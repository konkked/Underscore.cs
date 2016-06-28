using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Collection.Contract;

namespace Underscore.Collection.Implementation
{
    public class FilterComponent : IFilterComponent
    {
        //TODO: Implement this
        public IEnumerable<T> Drop<T>(IEnumerable<T> collection, int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> DropWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Pull<T>(IEnumerable<T> collection, params T[] toPull)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> TakeRight<T>(IEnumerable<T> collection, int count)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> TakeRightWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> Unique<T>(IEnumerable<T> collection)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TResult> UniqueBy<TArg, TResult>(IEnumerable<TArg> collection, Func<TArg, TResult> iteratee)
        {
            throw new NotImplementedException();
        }
    }
}
