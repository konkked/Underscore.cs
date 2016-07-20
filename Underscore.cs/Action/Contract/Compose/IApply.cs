using System;

namespace Underscore.Action
{
	public partial interface IComposeComponent
	{
		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);

		/// <summary>
		/// Calls the passed action using the passed array of elements as it's parameters
		/// </summary>
		void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments);
	}
}
