using System.Collections.Generic;

namespace Underscore.List
{

    public interface IManipulateComponent 
    {
        /// <summary>
        /// Swaps the elements at the specified indexes
        /// </summary>
        bool Swap<T>( IList<T> list, int i, int j );

        /// <summary>
        /// Generates a shuffled version of the passed list or , if in place,
        /// shuffles and returns the passed list
        /// </summary>
        IList<T> Shuffle<T>( IList<T> list, bool inPlace );

        /// <summary>
        /// Generates a shuffled copy of the passed list
        /// </summary>
        IList<T> Shuffle<T>( IList<T> list );

        /// <summary>
        /// Rotates passed list
        /// </summary>
        void Rotate<T>( IList<T> list, int change );

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        IList<T> Sample<T>( IList<T> list );

        /// <summary>
        /// Generates a random sample of items from the passed list 
        /// </summary>
        IList<T> Sample<T>( IList<T> list, int size );

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        IList<T> Sample<T>( IList<T> list, int size, bool unique );

        IEnumerable<T> Extend<T>(IList<T> list, int size);

        IEnumerable<T> Infinite<T>(IList<T> list);
    }
}
