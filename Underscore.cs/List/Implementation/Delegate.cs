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

        /// <summary>
        ///  Delegates a list of values into a list of functions
        /// </summary>
        public IList<Func<T>> Delegate<T>( IList<T> list )
        {
            var tlist = list;
            return new List<Func<T>>( from i in Enumerable.Range( 0, tlist.Count ) select new Func<T>( ( ) => tlist[ i ] ) );
        }

    }
}
