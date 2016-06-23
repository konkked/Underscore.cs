using System.Collections.Generic;
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

		/// <summary>
		/// returns an IEnumerable consisting of the results of 
		/// each item after having the method with
		/// name methodName being called
		/// </summary>
        public IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName)
        {
            foreach (var item in items)
            {
                _methodComponent.Invoke(item, methodName);
                yield return item;
            }
        }

		/// <summary>
		/// returns an IEnumerable consisting of the results of 
		/// each item after having the method with
		/// name methodName being called with arguments
		/// </summary>
        public IEnumerable<T> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments)
        {
            foreach (var item in items)
            {
                _methodComponent.Invoke(item, methodName, arguments);
                yield return item;
            }
        }
    }
}
