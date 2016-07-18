using System;
using Underscore.Utility;

namespace Underscore.Module
{
	public class Utility :
		IFunctionComponent,
		IMathComponent,
		IObjectComponent
	{
		private readonly IMathComponent _math;
		private readonly IFunctionComponent _function;
		private readonly IObjectComponent _object;

		public Utility(
			IFunctionComponent function,
			IMathComponent math,
			IObjectComponent obj)
		{
			if (function == null)
				throw new ArgumentNullException("function");

			if (math == null)
				throw new ArgumentNullException("math");

			if (obj == null)
				throw new ArgumentNullException("obj");

			_math = math;
			_function = function;
			_object = obj;
		}

		/// <summary>
		/// Creates a unique id (Guid as a string) with a prefix string
		/// </summary>
		public string UniqueId(string prefix)
		{
			return _math.UniqueId(prefix);
		}

		/// <summary>
		/// Creates a unique id (Guid as a string)
		/// </summary>
		public string UniqueId()
		{
			return _math.UniqueId();
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random()
		{
			return _math.Random();
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random(int max)
		{
			return _math.Random(max);
		}

		/// <summary>
		/// returns a thread safe random number
		/// </summary>
		public int Random(int min, int max)
		{
			return _math.Random(min, max);
		}

		/// <summary>
		/// A method that does nothing
		/// </summary>
		public void Noop()
		{
			_function.Noop();
		}

		/// <summary>
		/// Creates a function that returns the constant that was passed
		/// </summary>
		public Func<T> Constant<T>(T value)
		{
			return _function.Constant(value);
		}

		/// <summary>
		/// Returns true if the object is truthy (similair to javascript)
		/// </summary>
		/// <param name="o"></param>
		/// <returns></returns>
		public bool IsTruthy(object o)
		{
			return _object.IsTruthy(o);
		}

		/// <summary>
		/// Returns the absolute value of the int passed
		/// </summary>
		public int Abs(int i)
		{
			return _math.Abs(i);
		}

		/// <summary>
		/// Returns the min value between the two ints
		/// </summary>
		public int Min(int x, int y)
		{
			return _math.Min(x, y);
		}

		/// <summary>
		/// Returns the max value between the two ints
		/// </summary>
		public int Max(int x, int y)
		{
			return _math.Max(x, y);
		}
	}
}
