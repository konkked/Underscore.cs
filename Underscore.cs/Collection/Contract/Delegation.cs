using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface IDelegationComponent
    {
        IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName);
        IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments);
    }
}
