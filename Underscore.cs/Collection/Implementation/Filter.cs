using System;
using System.Collections.Generic;
using System.Linq;
using Underscore.Collection.Contract;

namespace Underscore.Collection.Implementation
{
    public class FilterComponent : IFilterComponent
    {
        public IEnumerable<T> Drop<T>(IEnumerable<T> collection, int count)
        {
	        var i = 1;

			foreach(var value in collection)
			{
				if (i > count)
					yield return value;

				i++;
			}
        }

        public IEnumerable<T> DropWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
        {
			// to track whether the predicate has been hit
	        var satisfied = true;

			foreach (var value in collection)
			{
				// only start returning items after the predicate has been hit
				satisfied = satisfied && predicate(value);

				if (!satisfied)
					yield return value;
			}
        }

        public IEnumerable<T> Pull<T>(IEnumerable<T> collection, params T[] toPull)
        {
	        return collection.Where(value => !toPull.Contains(value));
        }

	    public IEnumerable<T> TakeRight<T>(IEnumerable<T> collection, int count)
	    {
		    return collection.Reverse().Take(count);
	    }

        public IEnumerable<T> TakeRightWhile<T>(IEnumerable<T> collection, Func<T, bool> predicate)
        {
			return collection.Reverse().TakeWhile(predicate);
        }
    }
}
