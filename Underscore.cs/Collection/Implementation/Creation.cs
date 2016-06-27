using System;
using System.Collections.Generic;

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
                // make sure there's something to extend
                if(!iter.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
                // return the first value
                yield return iter.Current;
                
                //make i = 1 instead of zero to account for the first return.
                for (int i = 1; i < length; i++)
                {
                    // this check also moves to the next item 
                    // if we haven't hit the end,
                    // so we can just yield right after
                    if (!iter.MoveNext()) {
                        // restart the cycle if we hit the end of collection
                        iter.Reset();
                        iter.MoveNext();
                    }

                    yield return iter.Current;
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
                // make sure there's something to extend
                if (!iter.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
                // return the first value
                yield return iter.Current;
                
                // we're cycling infinitely
                while(true)
                {
                    // this check also moves to the next item 
                    // if we haven't hit the end,
                    // so we can just yield right after
                    if (!iter.MoveNext()) {
                        // restart the cycle if we hit the end of collection
                        iter.Reset();
                        iter.MoveNext();
                    }

                    yield return iter.Current;
                }
            }
        }
    }
}
