using System;
using System.Collections.Generic;
using Underscore.List;

namespace Underscore.Module
{
    public class List :
        IManipulateComponent,
        IPartitionComponent
    {
        private readonly IManipulateComponent _manipulator;
        private readonly IPartitionComponent _partitioner;

        public List(
            IManipulateComponent manipulator,
            IPartitionComponent partitioner)
        {

            if (manipulator == null)
                throw new ArgumentNullException("manipulator");

            if (partitioner == null)
                throw new ArgumentNullException("partitioner");


            _manipulator = manipulator;
            _partitioner = partitioner;
        }

        /// <summary>
        /// Swaps the elements at the specified indexes
        /// </summary>
        public bool Swap<T>(IList<T> list, int i, int j)
        {
            return _manipulator.Swap(list, i, j);
        }

        /// <summary>
        /// Generates a shuffled version of the passed list or , if in place,
        /// shuffles and returns the passed list
        /// </summary>
        public IList<T> Shuffle<T>(IList<T> list, bool inPlace)
        {
            return _manipulator.Shuffle(list, inPlace);
        }

        /// <summary>
        /// Generates a shuffled version of the passed list or , if in place,
        /// shuffles and returns the passed list
        /// </summary>
        public IList<T> Shuffle<T>(IList<T> list)
        {
            return _manipulator.Shuffle(list);
        }

        /// <summary>
        /// Rotates passed list right
        /// </summary>
        public void Rotate<T>(IList<T> list, int change)
        {
            _manipulator.Rotate(list, change);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public IList<T> Sample<T>(IList<T> list)
        {
            return _manipulator.Sample(list);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public IList<T> Sample<T>(IList<T> list, int size)
        {
            return _manipulator.Sample(list, size);
        }

        /// <summary>
        /// Generates a random sample of items from the passed list
        /// </summary>
        public IList<T> Sample<T>(IList<T> list, int size, bool unique)
        {
            return _manipulator.Sample(list, size, unique);
        }


        /// <summary>
        /// Creates an enumerable extending the collection by cycling through the items for the extra items being added for the specified length
        /// </summary>
        public IEnumerable<T> Extend<T>(IList<T> list, int size)
        {
            return _manipulator.Extend(list, size);
        }

        /// <summary>
        /// Creates a cycle from the list
        /// </summary>
        public IEnumerable<T> Cycle<T>(IList<T> list)
        {
            return _manipulator.Cycle(list);
        }

        public Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IList<T> list, Func<T, bool> on)
        {
            return _partitioner.PartitionMatches(list, on);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="list">The list to take the slice from</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end)
        {
            return _partitioner.Slice(list, start, end);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list, if the slice is larger than the size of the list
        /// then the items are repeated
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="list">The list to take the slice from</param>
        /// <param name="start">The start index</param>
        /// <param name="end">The end index</param>
        /// <param name="allowOverflow">specifies if the slice should cycle on overflow</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end, bool allowOverflow)
        {
            return _partitioner.Slice(list, start, end, allowOverflow);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="step">step by this amount each iteration</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end, int step)
        {
            return _partitioner.Slice(list, start, end, step);
        }

        /// <summary>
        /// Takes a slice from a list, if start is greater then the end index
        /// the results are reversed, if the index is negative corresponds to the index
        /// from the back of the list
        /// </summary>
        /// <typeparam name="T">The type of the elements in the list</typeparam>
        /// <param name="start">The inclusive start index</param>
        /// <param name="end">The exclusive end index</param>
        /// <param name="step">step by this amount each iteration</param>
        /// <param name="allowOverflow">specifies if the slice should cycle on overflow</param>
        /// <returns>slice of the list</returns>
        public IList<T> Slice<T>(IList<T> list, int start, int end, int step, bool allowOverflow)
        {
            return _partitioner.Slice(list, start, end, step, allowOverflow);
        }

        /// <summary>
        /// Splits the list in half
        /// </summary>
        public Tuple<IList<T>, IList<T>> Split<T>(IList<T> list)
        {
            return _partitioner.Split(list);
        }

        /// <summary>
        /// Returns an enumerable of all the possible combinations of the passed items
        /// </summary>
        public IEnumerable<IEnumerable<T>> Combinations<T>(IList<T> list)
        {
            return _partitioner.Combinations(list);
        }


        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IList<T> list, int size)
        {
            return _partitioner.Chunk(list, size);
        }

        /// <summary>
        /// Breaks the list into smaller chunks
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IList<T> list, Func<T, bool> on)
        {
            return _partitioner.Chunk(list, on);
        }

        /// <summary>
        /// Breaks list into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items elements in list</typeparam>
        /// <param name="collection">list to partition</param>
        /// <param name="on">the index to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IList<T> list, int index)
        {
            return _partitioner.Partition(list, index);
        }

        /// <summary>
        /// Breaks list into two seperate parts
        /// </summary>
        /// <typeparam name="T">Type of items elements in list</typeparam>
        /// <param name="list">list to partition</param>
        /// <param name="on">the predicate to partition on</param>
        /// <returns>a Tuple containing the first partition in the first item, second partition in the second</returns>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IList<T> list, Func<T, bool> on)
        {
            return _partitioner.Partition(list, on);
        }
    }
}
