using System.Collections.Generic;
using System.Linq;
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
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName)
		{
		    return items.Select(item => _methodComponent.Invoke(item, methodName));
		}

        /// <summary>
		/// returns an IEnumerable consisting of the results of 
		/// each item after having the method with
		/// name methodName being called with arguments
		/// </summary>
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments)
		{
		    return items.Select(item => _methodComponent.Invoke(item, methodName, arguments));
		}
    }
}
