using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.CompilerServices;

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

        public IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length)
        {
            using (var enmr = collection.GetEnumerator())
            {
                if(!enmr.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
                yield return enmr.Current;
                
                //make i = 1 instead of zero to account for the first return.
                for (int i = 1; i < length; i++)
                {
                    if (!enmr.MoveNext()) {  enmr.Reset();
                        enmr.MoveNext();
                    }

                    yield return enmr.Current;

                }
            }
        }

        public IEnumerable<T> Infinite<T>(IEnumerable<T> collection)
        {
            using (var enmr = collection.GetEnumerator())
            {
                if (!enmr.MoveNext()) throw new ApplicationException("Cannot extend an empty collection");
                yield return enmr.Current;

                //make i = 1 instead of zero to account for the first return.
                while(true)
                {

                    if (!enmr.MoveNext()) { enmr.Reset();
                        enmr.MoveNext();
                    }

                    yield return enmr.Current;

                }
            }
        }
        
    }
}
