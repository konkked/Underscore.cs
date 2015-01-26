using System;

namespace Underscore.Utility
{
    public class FunctionComponent : IFunctionComponent
    {


        /// <summary>
        /// Returns a function that always returns the passed value
        /// </summary>
        /// <typeparam name="T">The type of the target</typeparam>
        /// <param name="value">The target object</param>
        /// <returns>Function that always returns value</returns>
        public Func<T> Constant<T>( T value )
        {
            var tvalue = value;
            return ( ) => tvalue;
        }


        /// <summary>
        /// Creates a reference to a new value, hidden by a closure
        /// </summary>
        /// <typeparam name="T">The type of the value being passed</typeparam>
        /// <param name="value">The value being passed</param>
        /// <returns>
        /// A Tuple containing an to set the value
        /// as the first item, and a function to 
        /// get the value in the second item
        /// </returns>
        public Tuple<Action<T>, Func<T>> Reference<T>( T value ) 
        {
            var holding = value;

            return Tuple.Create ( new Action<T>(( t ) => value = t), 
                new Func<T>( ( ) => value ) 
            ) ;
        }

        /// <summary>
        /// Does nothing
        /// </summary>
        public void Noop( )
        {

        }
    }
}
