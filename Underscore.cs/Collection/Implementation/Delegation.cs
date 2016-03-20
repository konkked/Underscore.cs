using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Object.Reflection;

namespace Underscore.Collection
{
    public class DelegationComponent : IDelegationComponent
    {
        private readonly IMethodComponent _methodComponent;

        public DelegationComponent(IMethodComponent methodComponent)
        {
            _methodComponent = methodComponent;
        }

        public IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName)
        {
            foreach (var item in items)
            {
                _methodComponent.Invoke(item, methodName);
                yield return item;
            }
        }

        public IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments)
        {
            foreach (var item in items)
            {
                _methodComponent.Invoke(item, methodName,arguments);
                yield return item;
            }
        }
    }
}
