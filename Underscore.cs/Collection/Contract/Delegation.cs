using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Underscore.Collection
{
    public interface IDelegationComponent
    {
        IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName);
        IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments);
    }
}
