using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
	public interface IDelegationComponent
	{
		/// <summary>
		/// attempts to invoke the method with the given name on every object in items
		/// performs a no-op on any objects which do not have the method
		/// </summary>
		IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName);

		/// <summary>
		/// attempts to invoke the method with the given name on every object in items,
		/// passing the given arguments to the method when it is called.
		/// performs a no-op on any objects which do not have the method
		/// </summary>
		IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments);
		
		/// <summary>
		/// Resolves an enumerable of functions into an enumerable of the passed function's results
		/// </summary>
		/// <typeparam name="T">Return Type of passed functions</typeparam>
		/// <param name="items">collection of functions</param>
		/// <returns>returns a list of elements</returns>
		IEnumerable<T> Resolve<T>(IEnumerable<Func<T>> items);
	}
}
