﻿using System;
using System.Collections.Generic;
using Underscore.Collection;
using Underscore.Collection.Contract;
using Underscore.Collection.Contract.Zip;

namespace Underscore.Module
{
    public class Collection:
		ICompareComponent,
        ICreationComponent,
		IDelegationComponent,
        IPartitionComponent,
		IZipComponent
    {
	    private readonly ICompareComponent _compare;
        private readonly ICreationComponent _creator;
        private readonly IPartitionComponent _partitioner;
        private readonly IDelegationComponent _delegation;
	    private readonly IZipComponent _zip;

        public Collection(
			ICompareComponent compare,
            ICreationComponent creator,
			IDelegationComponent delegation,
            IPartitionComponent partitioner,
			IZipComponent zip
       )
        {

			if(compare == null)
				throw new ArgumentNullException("compare");

            if (creator == null)
                throw new ArgumentNullException("creator");

			if (delegation == null)
				throw new ArgumentNullException("delegation");

            if (partitioner == null)
                throw new ArgumentNullException("partitioner");

			if (zip == null)
				throw new ArgumentNullException("zip");

	        _compare = compare;
            _creator = creator;
			_delegation = delegation;
            _partitioner = partitioner;
	        _zip = zip;
        }

        /// <summary>
        /// Creates a snapshot of the collection at the time the method was called and can be called to return the value
        /// the collection was at when this method was called
        /// </summary>
        public Func<IEnumerable<T>> Snapshot<T>(IEnumerable<T> collection)
        {
            return _creator.Snapshot(collection);
        }

        /// <summary>
        /// Extends the collection to the specified length
        /// </summary>
        public IEnumerable<T> Extend<T>(IEnumerable<T> collection, int length)
        {
            return _creator.Extend(collection, length);
        }

        /// <summary>
        /// Creates a Cycle from the collection
        /// </summary>
        public IEnumerable<T> Cycle<T>(IEnumerable<T> collection)
        {
            return _creator.Cycle(collection);
        }

        /// <summary>
        /// Breaks the collection into chunks, splitting by size
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, int size)
        {
            return _partitioner.Chunk(collection, size);
        }

        /// <summary>
        /// Breaks the collection into chunks, splitting on the predicate on
        /// </summary>
        public IEnumerable<IEnumerable<T>> Chunk<T>(IEnumerable<T> collection, Func<T, bool> on)
        {
            return _partitioner.Chunk(collection, on);
        }

        /// <summary>
        /// Splits a collection into two halves, first contains all that items before the on index, the second
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, int on)
        {
            return _partitioner.Partition(collection, on);
        }

        /// <summary>
        /// Splits a collection into two halves, first contains all that pass predicate "on", second the ones that don't
        /// </summary>
        public Tuple<IEnumerable<T>, IEnumerable<T>> Partition<T>(IEnumerable<T> collection, Func<T, bool> on)
        {
            return _partitioner.Partition(collection, on);
        }

	    public Tuple<IEnumerable<T>, IEnumerable<T>> PartitionMatches<T>(IEnumerable<T> collection, Func<T, bool> @on)
	    {
		    return _partitioner.PartitionMatches(collection, on);
	    }

	    /// <summary>
        /// Returns all of the different possible combinations for a collection
        /// </summary>
        public IEnumerable<IEnumerable<T>> Combinations<T>(IEnumerable<T> collection)
        {
            return _partitioner.Combinations(collection);
        }

        /// <summary>
        /// Lazily invokes methods by name for each element in the collection
        /// </summary>
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName)
        {
            return _delegation.Invoke(items, methodName);
        }

        /// <summary>
        /// Lazily invokes methods by name for each element in the collection
        /// </summary>
        public IEnumerable<object> Invoke<T>(IEnumerable<T> items, string methodName, params object[] arguments)
        {
            return _delegation.Invoke(items, methodName, arguments);
        }

	    public IEnumerable<Tuple<T1, T2>> Zip<T1, T2>(IEnumerable<T1> a, IEnumerable<T2> b)
	    {
		    return _zip.Zip(a, b);
	    }

	    public IEnumerable<Tuple<T1, T2, T3>> Zip<T1, T2, T3>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c)
	    {
			return _zip.Zip(a, b, c);
	    }

	    public IEnumerable<Tuple<T1, T2, T3, T4>> Zip<T1, T2, T3, T4>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d)
	    {
			return _zip.Zip(a, b, c, d);
	    }

	    public IEnumerable<Tuple<T1, T2, T3, T4, T5>> Zip<T1, T2, T3, T4, T5>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e)
	    {
			return _zip.Zip(a, b, c, d, e);
	    }

	    public IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> Zip<T1, T2, T3, T4, T5, T6>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e,
		    IEnumerable<T6> f)
	    {
			return _zip.Zip(a, b, c, d, e, f);
	    }

	    public IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> Zip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<T1> a, IEnumerable<T2> b, IEnumerable<T3> c, IEnumerable<T4> d, IEnumerable<T5> e,
		    IEnumerable<T6> f, IEnumerable<T7> g)
	    {
			return _zip.Zip(a, b, c, d, e, f, g);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>> UnZip<T1, T2>(IEnumerable<Tuple<T1, T2>> zipped)
	    {
		    return _zip.UnZip(zipped);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>> UnZip<T1, T2, T3>(IEnumerable<Tuple<T1, T2, T3>> zipped)
	    {
			return _zip.UnZip(zipped);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>> UnZip<T1, T2, T3, T4>(IEnumerable<Tuple<T1, T2, T3, T4>> zipped)
	    {
			return _zip.UnZip(zipped);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>> UnZip<T1, T2, T3, T4, T5>(IEnumerable<Tuple<T1, T2, T3, T4, T5>> zipped)
	    {
			return _zip.UnZip(zipped);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>> UnZip<T1, T2, T3, T4, T5, T6>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6>> zipped)
	    {
			return _zip.UnZip(zipped);
	    }

	    public Tuple<IEnumerable<T1>, IEnumerable<T2>, IEnumerable<T3>, IEnumerable<T4>, IEnumerable<T5>, IEnumerable<T6>, IEnumerable<T7>> UnZip<T1, T2, T3, T4, T5, T6, T7>(IEnumerable<Tuple<T1, T2, T3, T4, T5, T6, T7>> zipped)
	    {
			return _zip.UnZip(zipped);
	    }

	    public Boolean IsSorted<T>(IEnumerable<T> collection, bool descending = false) where T : IComparable
	    {
		    return _compare.IsSorted(collection, descending);
	    }
    }
}
