using System;
using System.Collections.Generic;

namespace Underscore.Collection
{


    public class CreationComponent : ICreationComponent
    {


        /// <summary>
        /// creates a function that always returns a copy of the passed collection at the time it was called
        /// </summary>
        public Func<IEnumerable<T>> Snapshot<T>( IEnumerable<T> collection )
        {
            var tsnap = new List<T>( collection );
            return ( ) => new List<T>( tsnap );
        }

    }
}
