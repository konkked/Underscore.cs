using System;
using System.Collections.Generic;

namespace Underscore.Function
{
    public class CacheComponent : ICacheComponent
    {
        private readonly ICompactComponent _fncompactor;
        private readonly Utility.ICompactComponent _paramCompactor;

        public CacheComponent(ICompactComponent fncompactor, Utility.ICompactComponent paramCompactor)
        {
            _fncompactor = fncompactor;
            _paramCompactor = paramCompactor;
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg, TResult> Memoize<TArg, TResult>(Func<TArg, TResult> function)
        {
            // create a local cache to store results in
            var localStore = new Dictionary<TArg, TResult>();
            var locking = new object();
            var fn = function;
            return (a) =>
            {
                if (!localStore.ContainsKey(a))
                    // make sure the cache is thread-safe
                    lock (locking)
                    {
                        // double check that there's still no entry for this call
                        if (!localStore.ContainsKey(a))
                            localStore.Add(a, fn(a));
                    }
                // return whatever's in the cache
                return localStore[a];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b) => packedTarget(_paramCompactor.Pack(a, b));
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c) => packedTarget(_paramCompactor.Pack(a, b, c));
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d) => packedTarget(_paramCompactor.Pack(a, b, c, d));
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e) => packedTarget(_paramCompactor.Pack(a, b, c, d, e));
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k, l) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k, l, m) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o));
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
        {
            var fn = function;
            var packedTarget = Memoize(_fncompactor.Pack(function));
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => packedTarget(_paramCompactor.Pack(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p));
        }
    }
}
