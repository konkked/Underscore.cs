using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface IDelegationComponent
    {
        /// <summary>
        /// attempts to invoke the method with the given name on every object in items
        /// performs a no-op on any objects which do not have the method
        /// </summary>
        IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName);
        /// <summary>
        /// attempts to invoke the method with the given name on every object in items,
        /// passing the given arguments to the method when it is called.
        /// performs a no-op on any objects which do not have the method
        /// </summary>
        IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments);
    }
}
