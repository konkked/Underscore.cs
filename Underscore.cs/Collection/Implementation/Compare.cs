using System;
using System.Collections.Generic;
using Underscore.Object.Comparison;

namespace Underscore.Collection
{
    public class CompareComponent : ICompareComponent
    {
	    private readonly IEqualityComponent equalityComponent;

	    public CompareComponent()
	    {
		    equalityComponent = new EqualityComponent();
	    }

	    public CompareComponent(IEqualityComponent equalityComponent)
	    {
		    this.equalityComponent = equalityComponent;
	    }

		/// <summary>
		/// Determines whether the given array is sorted,
		/// can check for either ascending or descending
		/// sorts based on the passed boolean parameter (defaults to ascending)
		/// </summary>
        public bool IsSorted<T>(IEnumerable<T> collection, bool descending = false) where T : IComparable
        {
	        var iter = collection.GetEnumerator();

	        // get initial value
	        iter.MoveNext();
	        var prev = iter.Current;

	        while (iter.MoveNext())
	        {
				// compare the last value against the current one
		        var curr = iter.Current;

		        if (descending)
		        {
					// if it's descending and this value isn't smaller than
					// the last one, it isn't sorted
			        if (prev.CompareTo(curr) < 0)
				        return false;
		        }
		        else
		        {
					// if it's ascending and this value isn't 
					// bigger than the last one, it isn't sorted
			        if (prev.CompareTo(curr) > 0)
				        return false;
		        }

		        prev = curr;
	        }

	        return true;
        }
    }
}
