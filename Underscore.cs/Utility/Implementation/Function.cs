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
		public Func<T> Constant<T>(T value)
		{
			var tvalue = value;
			return () => tvalue;
		}

		/// <summary>
		/// Does nothing
		/// </summary>
		public void Noop()
		{

		}
	}
}
