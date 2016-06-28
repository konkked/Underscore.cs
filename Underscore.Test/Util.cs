using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using Underscore.Collection;

namespace Underscore.Test
{
    class MockUtilFunctionComponent : global::Underscore.Function.ICacheComponent, global::Underscore.Utility.IFunctionComponent
    {

        public void Noop( )
        {
        }

        public Func<TArg, TResult> Memoize<TArg, TResult>( Func<TArg, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TResult> Memoize<TArg1, TArg2, TResult>( Func<TArg1, TArg2, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TResult> Memoize<TArg1, TArg2, TArg3, TResult>( Func<TArg1, TArg2, TArg3, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TResult>( Func<TArg1, TArg2, TArg3, TArg4, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TResult>( Func<TArg1, TArg2, TArg3, TArg4, TArg5, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult>( Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TResult> function )
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> Memoize<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult>(
            Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TResult> function)
        {
            return function;
        }

        public Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> Memoize
            <TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15,
                TArg16, TResult>(Func<TArg1, TArg2, TArg3, TArg4, TArg5, TArg6, TArg7, TArg8, TArg9, TArg10, TArg11, TArg12, TArg13, TArg14, TArg15, TArg16, TResult> function)
        {
            return function;
        }

        public Func<T> Constant<T>( T value )
        {
            var val = value;
            return ( ) => val;
        }

        public Tuple<Action<T>, Func<T>> Reference<T>( T value )
        {
            T tmp = default( T );
            return Tuple.Create(new Action<T>(( v ) => tmp = v ) ,  new Func<T>(( ) => tmp) );
        }
    }


    //added chaining
    public static class TaskExtensions
    {
        public static Task Start(this System.Action action) 
        {
            return Task.Run(action);
        }

        public static Task<T> Start<T>(this Func<T> function) 
        {
            return Task.Run(function);
        }
    }

    public static class Util
    {
	    public static string[] LowercaseCharArray 
	    {
			// we could do this programmatically
			// but this is simpler and faster
		    get { return new[] { "a", "b", "c", "d", "e", "f", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }; }
	    }

        public static class Compare
        {
            public static void All(params Tuple<object, object>[] tuples)
            {
                foreach (var tuple in tuples)
                {
                    if (tuple.Item1 == null)
                        Assert.IsNull(tuple.Item2);
                    else
                    {
                        Assert.AreEqual(tuple.Item1, tuple.Item2);
                    }
                }
            }

            public static void All(object[] expected, object[] actual)
            {
                Assert.AreEqual(expected.Length, actual.Length);
                All(expected.Zip(actual, Tuple.Create).ToArray());
            }
        }

        public static class Tasks 
        {
            public static async Task Start(params System.Action[] actions)
            {
                var tasks = new Task[actions.Length];

                for (int i = 0; i < actions.Length; i++)
                    tasks[i] = Task.Run(actions[i]);

                foreach (var action in actions)
                    await Task.Run(action);

            }

            public static async Task<T[]> Start<T>(params Func<T>[] functions) 
            {
                var tasks = new Task<T>[functions.Length];
                var results = new T[functions.Length];

                for (int i = 0; i < functions.Length; i++)
                    tasks[i] = Task.Run(functions[i]);

                for (int i = 0; i < functions.Length; i++)
                    results[i] = await tasks[i];

                return results;
            }
        }
    }
}
