using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{


    public class PartitionComponent : IPartitionComponent
    {
        private readonly List.IPartitionComponent _partitionComponent;

        public PartitionComponent(List.IPartitionComponent partitionComponent)
        {
            _partitionComponent = partitionComponent;
        }

		/// <summary>
		/// this needs a comment
		/// </summary>\
        private IEnumerable<T> Segment<T>(IEnumerator<T> iter, int size, out bool cont)
        {
            var ret = new List<T>();
            cont = true;
            bool hit = false;

            for (var i = 0; i < size; i++)
            {
                if (iter.MoveNext())
                {
                    hit = true;
                    ret.Add(iter.Current);
                }
                else
                {
                    cont = false;
                    break;
                }
            }

            return hit ? ret : null;
        }

        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, int size)
        {
            bool shouldContinue = collection != null && collection.Any();

            using (var iter = collection.GetEnumerator())
            {
                while (shouldContinue)
                {
                    //iteration of the enumerable is done in segment
                    var result = Segment(iter, size, out shouldContinue);

                    if (shouldContinue || result != null)
                        yield return result;

                    else yield break;
                }
            }
        }

        /// <summary>
        /// Breaks the collection into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, Func<T, bool> on)
        {
            using (var iter = collection.GetEnumerator())
            {
                var retv = new List<T>();
                while (iter.MoveNext())
                {
                    // don't include empty lists
                    if (on(iter.Current) && retv.Count != 0)
                    {
                        yield return retv;
                        retv = new List<T> { iter.Current };
                    }
                    else
                    {
                        retv.Add(iter.Current);
                    }
                }

                if (retv.Count != 0)
                    yield return retv;
                else
                    yield break;
            }
        }

        /// <summary>
        /// Breaks collection into two seperate parts
		/// split into items before the given index
		/// and items after the given index
		///
		/// e.g.
		///
		/// Partition([1,2,3,4,5], 2) would return
		/// Tuple([1,2],[3,4,5])
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, int index)
        {
            var left = new List<T>();
            var right = new List<T>();

	        int i = 0;

	        foreach (var value in collection)
	        {
		        if(i < index)
					left.Add(value);
				else
					right.Add(value);

		        i++;
	        }

            return Tuple.Create(
                (IEnumerable<T>) left,
                (IEnumerable<T>) right
            );
        }

        /// <summary>
        /// Breaks collection into two seperate parts,
        /// split into items before an item matches the given predicate
        /// and items after an item matches the given predicate
        ///
        /// e.g.
        ///
        /// Partition([1,2,3], n => n == 2) would return
        /// Tuple([1],[2,3])
        /// </summary>
		public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, Func<T, bool> on)
        {
            var left = new List<T>( );
            var right = new List<T>( );
	        bool hitPred = false;

	        foreach (var value in collection)
	        {
		        if (hitPred)
		        {
			        right.Add(value);
		        }
		        else
		        {
					// if we haven't hit the predicate yet,
					// check if we're hitting it now
			        if (on(value))
			        {
				        hitPred = true;
				        right.Add(value);
			        }
			        else
			        {
						left.Add(value);
			        }
		        }
	        }

            return Tuple.Create(
                (IEnumerable<T>) left,
				(IEnumerable<T>) right
            );
        }

		/// <summary>
		/// Breaks collection into two seperate parts,
		/// split into items that match the predicate
		/// and items that do not match the predicate
		///
		/// e.g.
		///
		/// Partition([1,2,3], n => n == 2) would return
		/// Tuple([2],[1,3])
		/// </summary>
	    public Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IEnumerable<T> collection, Func<T, bool> on)
	    {
			var left = new List<T>();
			var right = new List<T>();

			foreach (var value in collection)
			{
				if (on(value))
					left.Add(value);
				else
					right.Add(value);
			}

			return Tuple.Create(
				(IEnumerable<T>) left,
				(IEnumerable<T>) right
			);
	    }

        public IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> collection)
        {
            if(collection == null) throw new ArgumentNullException("collection");
            var ls = collection as IList<T> ?? collection.ToList();
            return _partitionComponent.Combinations(ls);
        }
    }
}
