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
        public IList<T> Resolve<T>(IList<Func<T>> list)
        {
            var values = new List<T>();

            for (var i = 0; i < list.Count; i++)
            {
                // sorry this syntax is so ugly
                values.Add(list[i]());
            }

            return values;
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
