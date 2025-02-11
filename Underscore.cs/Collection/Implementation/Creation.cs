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
			var list = collection.ToList();
			while(length > 0)
				foreach (var item in list)
					if (length > 0)
					{
						length--;
						yield return item;
					}
		}

		/// <summary>
		/// cycles through collection infinitely
		/// </summary>
		public IEnumerable<T> Cycle<T>(IEnumerable<T> collection)
		{
			var list = collection.ToList();
			while (true)
				foreach (var item in list)
					yield return item;
		}
	}
}
