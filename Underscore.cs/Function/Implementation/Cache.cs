using System;
using System.Collections.Generic;

namespace Underscore.Function
{
    public class CacheComponent : ICacheComponent
    {
        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg">The type of the argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg, TResult> Memoize<TArg, TResult>(Func<TArg, TResult> function)
        {
            var localStore = new Dictionary<TArg, TResult>();
            var fn = function;
            return (a) =>
            {
                if (!localStore.ContainsKey(a))
                    localStore.Add(a, fn(a));

                return localStore[a];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
        /// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>(Func<TArg1, TArg2, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2>, TResult>();
            var fn = function;
            return (a, b) =>
            {
                var key = Tuple.Create(a, b);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b));

                return localStore[key];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
        /// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
        /// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>(Func<TArg1, TArg2, TArg3, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3>, TResult>();
            var fn = function;
            return (a, b, c) =>
            {
                var key = Tuple.Create(a, b, c);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c));

                return localStore[key];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
        /// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
        /// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
        /// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4>, TResult>();
            var fn = function;
            return (a, b, c, d) =>
            {
                var key = Tuple.Create(a, b, c, d);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d));

                return localStore[key];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
        /// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
        /// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
        /// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
        /// <typeparam name="TArg5">The type of the fifth argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5>, TResult>();
            var fn = function;
            return (a, b, c, d, e) =>
            {
                var key = Tuple.Create(a, b, c, d, e);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e));

                return localStore[key];
            };
        }

        /// <summary>
        /// Creates a memoized version of the passed function
        /// </summary>
        /// <typeparam name="TArg1">The type of the first argument of the passed function</typeparam>
        /// <typeparam name="TArg2">The type of the second argument of the passed function</typeparam>
        /// <typeparam name="TArg3">The type of the third argument of the passed function</typeparam>
        /// <typeparam name="TArg4">The type of the fourth argument of the passed function</typeparam>
        /// <typeparam name="TArg5">The type of the fifth argument of the passed function</typeparam>
        /// <typeparam name="TArg6">The type of the sixth argument of the passed function</typeparam>
        /// <typeparam name="TResult">The type of the result of the passed function</typeparam>
        /// <param name="function">The function to memoize</param>
        /// <returns>A memoized version of the passed function</returns>
        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f) =>
            {
                var key = Tuple.Create(a, b, c, d, e, f);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6,TArg7>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f,g) =>
            {
                var key = Tuple.Create(a, b, c, d, e, f,g);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f,g));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7,Tuple<TArg8>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g,h) =>
            {
                var key = Tuple.Create(a, b, c, d, e, f, g,h);

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g,h));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8,TArg9>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h,i) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8,TArg9>>(a, b, c, d, e, f,g, Tuple.Create(h,i));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h,i));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9,TArg10>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i,j) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9,TArg10>>(a, b, c, d, e, f, g, Tuple.Create(h, i,j));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i,j));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10,TArg11>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j,k) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10,TArg11>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j,k));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j,k));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11,TArg12>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j, k,l) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11,TArg12>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j, k,l));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j, k,l));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12,TArg13>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j, k, l,m) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12,TArg13>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j, k, l,m));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j, k, l,m));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13,TArg14>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j, k, l, m,n) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13,TArg14>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j, k, l, m,n));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j, k, l, m,n));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14,TArg15>>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n,o) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14,TArg15>>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j, k, l, m, Tuple.Create(n,o)));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j, k, l, m, n,o));

                return localStore[key];
            };
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
        {
            var localStore = new Dictionary<Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14, TArg15,TArg16>>>, TResult>();
            var fn = function;
            return (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p) =>
            {
                var key = new Tuple<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, Tuple<TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, Tuple<TArg14, TArg15,TArg16>>>(a, b, c, d, e, f, g, Tuple.Create(h, i, j, k, l, m, Tuple.Create(n, o,p)));

                if (!localStore.ContainsKey(key))
                    localStore.Add(key, fn(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o,p));

                return localStore[key];
            };
        }
    }
}
