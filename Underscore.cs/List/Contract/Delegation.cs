using System;
using System.Collections.Generic;

namespace Underscore.List
{
    public interface IDelegationComponent 
    {

        /// <summary>
        /// Resolves a list of functions into a list
        /// </summary>
        /// <typeparam name="T">Return Type of passed functions</typeparam>
        /// <param name="list">collection of functions</param>
        /// <returns>returns a list of elements</returns>
        IList<T> Resolve<T>( IList<Func<T>> list );


    }

}
