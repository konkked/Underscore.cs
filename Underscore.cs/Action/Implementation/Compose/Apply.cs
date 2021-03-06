﻿using System;

namespace Underscore.Action
{
	public class ApplyComponent : IApplyComponent
	{
		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T> action, T[] arguments)
		{
			action(arguments[0]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10], arguments[11]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10], arguments[11], arguments[12]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10], arguments[11], arguments[12], arguments[13]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10], arguments[11], arguments[12], arguments[13], arguments[14]);
		}

		/// <summary>
		/// Calls a function using the passed array of arguments
		/// </summary>
		public void Apply<T>(Action<T, T, T, T, T, T, T, T, T, T, T, T, T, T, T, T> action, T[] arguments)
		{
			action(arguments[0], arguments[1], arguments[2], arguments[3], arguments[4], arguments[5], arguments[6], arguments[7], arguments[8], arguments[9], arguments[10], arguments[11], arguments[12], arguments[13], arguments[14], arguments[15]);
		}
	}
}
