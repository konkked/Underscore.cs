using System;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.List
{
    public class DelegationComponent : IDelegationComponent
    {
        private readonly IMethodComponent _methodComponent;

	    public DelegationComponent()
	    {
		    _methodComponent = new MethodComponent();
	    }

        public DelegationComponent(IMethodComponent methodComponent)
        {
            _methodComponent = methodComponent;
        }

        /// <summary>
        /// Resolves a list of functions into a list
        /// </summary>
        public IList<T> Resolve<T>( IList<Func<T>> list )
        {
            return new List<T>( from i in list select i( ) );
        }
    }
}
