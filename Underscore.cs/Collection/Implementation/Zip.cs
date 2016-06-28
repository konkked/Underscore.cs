using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Collection.Contract;
using Underscore.Function;

namespace Underscore.Collection.Implementation
{
    public class ZipComponent : IZipComponent
    {
        public Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped)
        {
	        var a = new List<T1>();
			var b = new List<T2>();

	        foreach (var tuple in zipped)
	        {
		        a.Add(tuple.Item1);
		        b.Add(tuple.Item2);
	        }

	        return Tuple.Create(
				(IEnumerable<T1>) a,
				(IEnumerable<T2>) b
			);
        }

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
				// I'd like to make a method to zip all of the current
				// values, but typing is stopping that
				zipped.Add(Tuple.Create(
						(T1) iters[0].Current, 
						(T2) iters[1].Current
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
				// I'd like to make a method to zip all of the current
				// values, but typing is stopping that
				zipped.Add(Tuple.Create(
						(T1) iters[0].Current,
						(T2) iters[1].Current,
						(T3) iters[2].Current
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
				// I'd like to make a method to zip all of the current
				// values, but typing is stopping that
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
				// I'd like to make a method to zip all of the current
				// values, but typing is stopping that
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
				// I'd like to make a method to zip all of the current
				// values, but typing is stopping that
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

		//TODO Zip overloads

		/// <summary>
		/// zip items from multiple collections
		/// together into a single collection
		/// using a function which takes 
		/// an item from each of the collections
		/// as input
		/// </summary>
        public IEnumerable<TResult> ZipWith<TArg1, TArg2, TResult>(IEnumerable<TArg1> a, IEnumerable<TArg2> b, Func<TArg1, TArg2, TResult> zipper)
		{
			var zipped = new List<TResult>();
			var iters = GetAllEnumerators(a, b);

			// as long as all of the collections have remaining values
			while (IterateAll(iters))
			{
				// add the combined elements
				zipped.Add(
					zipper(
						(TArg1)iters[0].Current, 
						(TArg2)iters[1].Current
					)
				);
			}

			return zipped;
		}
		
		//TODO ZipWith overlaods
    }
}
