using System;

namespace Underscore.Utility
{
    public interface IFunctionComponent
    {
        /// <summary>
        /// Does nothing
        /// </summary>
        void Noop();

        /// <summary>
        /// Returns a function that always returns the passed value
        /// </summary>
        /// <typeparam name="T">The type of the target</typeparam>
        /// <param name="value">The target object</param>
        /// <returns>Function that always returns value</returns>
        Func<T> Constant<T>(T value);
    }
}
