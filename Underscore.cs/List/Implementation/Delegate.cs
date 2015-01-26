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
        /// <typeparam name="T">Return Type of passed functions</typeparam>
        /// <param name="list">collection of functions</param>
        /// <returns>returns a list of elements</returns>
        public IList<T> Resolve<T>( IList<Func<T>> list )
        {
            return new List<T>( from i in list select i( ) );
        }

        /// <summary>
        /// Creates a list of functions that return 
        /// an element from the passed list when invoked 
        /// </summary>
        /// <typeparam name="T">Type of the items in the list</typeparam>
        /// <param name="list">list to create references to</param>
        /// <returns>list of functions references list item at its index at the time of invocation</returns>
        public IList<Func<T>> Delegate<T>( IList<T> list )
        {
            var tlist = list;
            return new List<Func<T>>( from i in Enumerable.Range( 0, tlist.Count ) select new Func<T>( ( ) => tlist[ i ] ) );
        }

    }
}
