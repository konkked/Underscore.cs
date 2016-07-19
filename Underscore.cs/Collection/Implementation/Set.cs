using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Collection
{
    public class SetComponent : ISetComponent
    {
		/// <summary>
		/// Returns an enumerable containing all
		/// elements contained in one list but not the other
		/// </summary>
        public IEnumerable<T> Difference<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
			var hashSetA = new HashSet<T>(a);
			var hashSetB = new HashSet<T>(b);

			return hashSetA.Where(item => !hashSetB.Contains(item)).
				Concat(hashSetB.Where(item => !hashSetA.Contains(item)));
        }

		/// <summary>
		/// Returns an enumerable containing all
		/// elements contained in one list but not the other
		/// after both collections have had transform called on them
		/// </summary>
        public IEnumerable<TResult> DifferenceBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> transform)
        {
			var transformedA = a.Select(transform);
			var transformedB = b.Select(transform);
			var hashSetA = new HashSet<TResult>(transformedA);
			var hashSetB = new HashSet<TResult>(transformedB);

			return hashSetA.Where(item => !hashSetB.Contains(item)).
				Concat(hashSetB.Where(item => !hashSetA.Contains(item)));
        }

		/// <summary>
		/// Returns an enumerable containing all
		/// elements contained by both lists
		/// </summary>
        public IEnumerable<T> Intersection<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
			var hashSet = new HashSet<T>(a);

			return b.Where(item => hashSet.Contains(item));
        }

		/// <summary>
		/// Returns an enumerable containing all
		/// elements contained by both collections after
		/// both collections have had transform called on them
		/// </summary>
        public IEnumerable<TResult> IntersectionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with)
		{
			var transformedA = a.Select(with);
			var transformedB = b.Select(with);
			var hashSet = new HashSet<TResult>(transformedA);

			return transformedB.Where(item => hashSet.Contains(item));
		}

		/// <summary>
		/// Returns an enumerable containing all 
		/// elements from both collections
		/// </summary>
        public IEnumerable<T> Union<T>(IEnumerable<T> a, IEnumerable<T> b)
        {
			var hashSet = new HashSet<T>(a);

			// only get unique items from a
			var unioned = hashSet.ToList();

			unioned.AddRange(b.Where(item => !hashSet.Contains(item)));

			return unioned;
        }

		/// <summary>
		/// Returns an enumerable containing all 
		/// elements from both collections after
		/// both collections have had transform called on them,
		/// only adding unique items
		/// </summary>
        public IEnumerable<TResult> UnionBy<TArg, TResult>(IEnumerable<TArg> a, IEnumerable<TArg> b, Func<TArg, TResult> with)
        {
			var transformedA = a.Select(with);
			var transformedB = b.Select(with);
			var hashSet = new HashSet<TResult>(transformedA);

			// only get unique items from a
			var unioned = hashSet.ToList();

			unioned.AddRange(transformedB.Where(item => !hashSet.Contains(item)));

			return unioned;
        }
    }
}
