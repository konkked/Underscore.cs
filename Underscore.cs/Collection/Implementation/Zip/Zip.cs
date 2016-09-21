using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{
	public class ZipComponent : IZipComponent
	{
		private bool IterateAll(IEnumerable<IEnumerator> iterators)
		{
			return iterators.Aggregate(true, (current, iter) => current & iter.MoveNext());
		}

		private IEnumerator[] GetAllEnumerators(params IEnumerable[] enumerables)
		{
			return enumerables.Select(collection => collection.GetEnumerator()).ToArray();
		}

		/// <summary>
		/// zip items from multiple enumerators 
		/// together into tuples based on index
		/// will only zip as far as the length 
		/// of the shortest given collection
		/// </summary>
		public IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(IEnumerable<T1> a, IEnumerable<T2> b)
		{
			var zipped = new List<Tuple<T1, T2>>();
			var iters = GetAllEnumerators(a, b);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current
					)
				);
			}

			return zipped;
		}

		/// <summary>
		/// zip items from multiple enumerators 
		/// together into tuples based on index
		/// will only zip as far as the length 
		/// of the shortest given collection
		/// </summary>
		public IEnumerable<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
		{
			var zipped = new List<Tuple<T1, T2, T3>>();
			var iters = GetAllEnumerators(a, b, c);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current,
						(T3)iters[2].Current
					)
				);
			}

			return zipped;
		}

		/// <summary>
		/// zip items from multiple enumerators 
		/// together into tuples based on index
		/// will only zip as far as the length 
		/// of the shortest given collection
		/// </summary>
		public IEnumerable<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
		{
			var zipped = new List<Tuple<T1, T2, T3, T4>>();
			var iters = GetAllEnumerators(a, b, c, d);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current,
						(T3)iters[2].Current,
						(T4)iters[3].Current
					)
				);
			}

			return zipped;
		}

		/// <summary>
		/// zip items from multiple enumerators 
		/// together into tuples based on index
		/// will only zip as far as the length 
		/// of the shortest given collection
		/// </summary>
		public IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e)
		{
			var zipped = new List<Tuple<T1, T2, T3, T4, T5>>();
			var iters = GetAllEnumerators(a, b, c, d, e);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current,
						(T3)iters[2].Current,
						(T4)iters[3].Current,
						(T5)iters[4].Current
					)
				);
			}

			return zipped;
		}

		/// <summary>
		/// zip items from multiple enumerators 
		/// together into tuples based on index
		/// will only zip as far as the length 
		/// of the shortest given collection
		/// </summary>
		public IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e, IEnumerable<T6> f)
		{
			var zipped = new List<Tuple<T1, T2, T3, T4, T5, T6>>();
			var iters = GetAllEnumerators(a, b, c, d, e, f);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current,
						(T3)iters[2].Current,
						(T4)iters[3].Current,
						(T5)iters[4].Current,
						(T6)iters[5].Current
					)
				);
			}

			return zipped;
		}

		public IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e,
			IEnumerable<T6> f, IEnumerable<T7> g)
		{
			var zipped = new List<Tuple<T1, T2, T3, T4, T5, T6, T7>>();
			var iters = GetAllEnumerators(a, b, c, d, e, f, g);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// can't do this with LINQ because
				// each item has a different cast
				zipped.Add(Tuple.Create(
						(T1)iters[0].Current,
						(T2)iters[1].Current,
						(T3)iters[2].Current,
						(T4)iters[3].Current,
						(T5)iters[4].Current,
						(T6)iters[5].Current,
						(T7)iters[6].Current
					)
				);
			}

			return zipped;
		}
	}
}
