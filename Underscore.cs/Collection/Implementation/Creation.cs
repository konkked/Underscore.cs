using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{
	public class CreationComponent : ICreationComponent
	{
		/// <summary>
		/// creates a function that always returns a copy of the passed collection at the time it was called
		/// </summary>
		public Func<IEnumerable<T>> Snapshot<T>(IEnumerable<T> collection)
		{
			// keep a local copy of the collection as it was passed
			var tsnap = new List<T>(collection);

			// return a new copy of it every time
			return () => new List<T>(tsnap);
		}

		/// <summary>
		/// cycles through collection for length iterations
		/// </summary>
		public IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length)
		{
			using (var iter = collection.GetEnumerator())
			{
			    bool hasReset = true;

			    try
			    {
                    // some IEnumerables (such as those returned by LINQ)
                    // don't have a reset method, so instead we need
                    // to default to using an array made from the enumerable
			        iter.Reset();
			    }
			    catch(NotImplementedException)
			    {
			        hasReset = false;
			    }

			    if (hasReset)
			    {
			        // make sure there's something to extend
			        if (!iter.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
			        // return the first value
			        yield return iter.Current;

			        //make i = 1 instead of zero to account for the first return.
			        for (int i = 1; i < length; i++)
			        {
			            // this check also moves to the next item 
			            // if we haven't hit the end,
			            // so we can just yield right after
			            if (!iter.MoveNext())
			            {
			                // restart the cycle if we hit the end of collection
			                iter.Reset();
			                iter.MoveNext();
			            }

			            yield return iter.Current;
			        }
			    }
			    else
			    {
			        var arr = collection.ToArray();
			        var count = 0;
			        var i = 0;

			        while (count < length)
			        {
                        // reset index if necessary
			            if (i == arr.Length) i = 0;

			            yield return arr[i];

			            i++;
			            count++;
			        }
			    }
			}
		}

		/// <summary>
		/// cycles through collection infinitely
		/// </summary>
		public IEnumerable<T> Cycle<T>(IEnumerable<T> collection)
		{
			using (var iter = collection.GetEnumerator())
			{
                bool hasReset = true;

                try
                {
                    // some IEnumerables (such as those returned by LINQ)
                    // don't have a reset method, so instead we need
                    // to default to using an array made from the enumerable
                    iter.Reset();
                }
                catch (NotImplementedException)
                {
                    hasReset = false;
                }

                if (hasReset)
                {
                    // make sure there's something to extend
                    if (!iter.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
                    // return the first value
                    yield return iter.Current;
                    
                    while(true)
                    {
                        // this check also moves to the next item 
                        // if we haven't hit the end,
                        // so we can just yield right after
                        if (!iter.MoveNext())
                        {
                            // restart the cycle if we hit the end of collection
                            iter.Reset();
                            iter.MoveNext();
                        }

                        yield return iter.Current;
                    }
                }
                else
                {
                    var arr = collection.ToArray();
                    var i = 0;

                    while (true)
                    {
                        // reset index if necessary
                        if (i == arr.Length) i = 0;

                        yield return arr[i];

                        i++;
                    }
                }
            }
		}
	}
}
