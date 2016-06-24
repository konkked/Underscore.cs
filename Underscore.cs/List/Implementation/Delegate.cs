using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.List
{
    public class DelegateComponent : IDelegateComponent
    {
        /// <summary>
        /// Resolves a list of functions into a list
        /// </summary>
        public IList<T> Resolve<T>( IList<Func<T>> list )
        {
            return new List<T>( from i in list select i( ) );
        }


    }
}
