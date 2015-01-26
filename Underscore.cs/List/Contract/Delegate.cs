using System;
using System.Collections.Generic;

namespace Underscore.List
{
    public interface IDelegateComponent 
    {

        /// <summary>
        /// Resolves a list of functions into a list
        /// </summary>
        /// <typeparam name="T">Return Type of passed functions</typeparam>
        /// <param name="list">collection of functions</param>
        /// <returns>returns a list of elements</returns>
        IList<T> Resolve<T>( IList<Func<T>> list );


        /// <summary>
        /// Creates a list of functions that return 
        /// an element from the passed list when invoked 
        /// </summary>
        /// <typeparam name="T">Type of the items in the list</typeparam>
        /// <param name="list">list to create references to</param>
        /// <returns>list of functions references list item at its index at the time of invocation</returns>
        IList<Func<T>> Delegate<T>( IList<T> list );
    }

}
