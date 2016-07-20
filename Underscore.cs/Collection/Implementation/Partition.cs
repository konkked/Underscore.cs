using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{


	public class PartitionComponent : IPartitionComponent
	{
		private readonly List.IPartitionComponent _partitionComponent;

		public PartitionComponent()
		{
			_partitionComponent = new List.PartitionComponent();
		}

		public PartitionComponent(List.IPartitionComponent partitionComponent)
		{
			_partitionComponent = partitionComponent;
		}

		/// <summary>
		/// segment
		/// </summary>
		private IEnumerable<T> Segment<T>(IEnumerator<T> iter, int size, out bool cont)
		{
			var ret = new List<T>();
			// we want the calling method to know if we can keep going
			cont = true;
			bool hit = false;

			// add items up until size or end of iter's collection
			for (var i = 0; i < size; i++)
			{
				if (iter.MoveNext())
				{
					// keep adding values if there are any
					hit = true;
					ret.Add(iter.Current);
				}
				else
				{
					// if there's nothing left, break
					cont = false;
					break;
				}
			}

			// if we didn't hit anything, 
			// there's nothing to return so return null
			return hit ? ret : null;
		}

		/// <summary>
		/// Breaks the collection into smaller chunks
		/// </summary>
		public IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, int size)
		{
			// we need a non-empty collection to be able to chunk it
			if (collection == null || !collection.Any())
				yield break;

			using (var iter = collection.GetEnumerator())
			{
				// if we reach here we must have a collection to do something to
				bool shouldContinue = true;

				while (shouldContinue)
				{
					// iteration of the enumerable is done in segment
					var result = Segment(iter, size, out shouldContinue);

					// as long as we keep getting results, yield them
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
			if (collection == null || !collection.Any())
				yield break;

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
				// if we haven't reached the index yet, 
				// it goes in the left partition,
				// otherwise it goes in the right partition
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
					// if we've hit the predicate,
					// add it to the right
					right.Add(value);
				}
				else
				{
					// if we haven't hit the predicate yet,
					// check if we're hitting it now
					if (on(value))
					{
						// if we've hit it set flag
						// and put value in right partition
						hitPred = true;
						right.Add(value);
					}
					else
					{
						// otherwise we're still in the left partition
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
				// if it matches the predicate, put it in the left
				// otherwise, put it in the right
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
			// need to have a collection to do combinations of it
			if(collection == null) throw new ArgumentNullException("collection");
			// if it's a list, just cast it. Otherwise we'll need to turn it into one
			var ls = collection as IList<T> ?? collection.ToList();
			return _partitionComponent.Combinations(ls);
		}
	}
}
