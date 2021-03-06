﻿using System;
using System.Collections.Generic;

namespace Underscore.Collection
{
    public interface IMapReduceComponent
    {
        /// <summary>
        /// Maps an enumerable of items to a
        /// new enumerable of items using the given function,
        /// like underscore.js's map or LINQ's Select
        /// </summary>
        IEnumerable<U> Map<T, U>(IEnumerable<T> collection, Func<T, U> transform);

        /// <summary>
        /// Reduces a collection using the given function by applying reducer to the result of
        /// applying reducer to the previous item in the enumerable, starting with a seed value.
        ///  
        /// If no seed is provided, uses the default value of U as a starting value.
        /// If U is not a value type and no seed is provided, it must have a default constructor,
        /// which will be used to create a seed.
        /// 
        /// works like underscore.js's reduce, LINQ's Aggregate or Haskell's fold
        /// </summary>
        /// <typeparam name="T">type of the enumerable being reduced</typeparam>
        /// <typeparam name="U">type to reduce to</typeparam>
        U Reduce<T, U>(IEnumerable<T> collection, Func<U, T, U> reducer);

        /// <summary>
        /// Reduces a collection using the given function by applying reducer to the result of
        /// applying reducer to the previous item in the enumerable, starting with a seed value.
        ///  
        /// If no seed is provided, uses the default value of U as a starting value.
        /// If U is not a value type and no seed is provided, it must have a default constructor,
        /// which will be used to create a seed.
        /// 
        /// works like underscore.js's reduce, LINQ's Aggregate or Haskell's fold
        /// </summary>
        /// <typeparam name="T">type of the enumerable being reduced</typeparam>
        /// <typeparam name="U">type to reduce to</typeparam>
        U Reduce<T, U>(IEnumerable<T> collection, U seed, Func<U, T, U> reducer);
    }
}
