using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Underscore.Utility
{
	public class MathComponent : IMathComponent
	{
		private HashSet<string> _sharedUuidChecker;
		private static readonly object _randomLock = new object();
		private static readonly Random _baseRandom = new Random();
		[ThreadStatic] private static Random _threadInstance;

		private Random InternalRandom
		{
			get
			{
				if (_threadInstance == null)
					lock (_randomLock)
						_threadInstance = new Random(_baseRandom.Next());

				return _threadInstance;
				
			}
		}

		public MathComponent() 
		{
			_sharedUuidChecker = new HashSet<string>();
		}

		private bool InternalIsUnique(string uuid)
		{
			return _sharedUuidChecker.Add(uuid);
		}

		/// <summary>
		/// Generates a unique id, optionally prefixed by a string
		/// </summary>
		public string UniqueId(string prefix)
		{
			string retv;

			do
			{
				retv = prefix + "_" + UniqueId();
			} while (!InternalIsUnique(retv));

			return retv;
		}

		/// <summary>
		/// Generates a unique id string
		/// </summary>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string UniqueId()
		{
			return Guid.NewGuid().ToString("B").ToUpper();
		}

		/// <summary>
		/// Generates a random integer in specified range
		/// </summary>
		/// <param name="min">Min possible value</param>
		/// <param name="max">Max possible value, exclusive</param>
		/// <returns>A random number between <paramref name="min"/> and <paramref name="max"/></returns>
		public int Random(int min, int max)
		{
			if (min >= max)
				throw new ArgumentException("min must be less than (and not equal to) max");

			return InternalRandom.Next(min, max);
		}

		/// <summary>
		/// Generates a random integer between 0 and max
		/// </summary>
		/// <param name="max">Max of range, exclusive. Must be greater than 0</param>
		/// <returns>a random number</returns>
		public int Random(int max)
		{
			if (max <= 0)
				throw new ArgumentException("max must be greater than 0");

			return InternalRandom.Next(max);
		}

		/// <summary>
		/// Generates a random positive integer
		/// </summary>
		/// <returns>a random number</returns>
		public int Random()
		{
			return InternalRandom.Next();
		}

		private const int _absValueIntMask = (sizeof(int) * 8) - 1;

		/// <summary>
		/// Performantly calculates absolute value of an int
		/// </summary>
		/// <param name="i"></param>
		/// <returns>Absolute value of i</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Abs(int i) 
		{
			int mask = i >> _absValueIntMask;
			return (i + mask) ^ mask;
		}

		/// <summary>
		/// Performantly calculates minimum of the passed ints
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>The smallest of the two ints passed</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Min(int x, int y)
		{
			return y + (((x - y) & ((x - y) >> _absValueIntMask)));
		}

		/// <summary>
		/// Performantly calculates maximum of the passed ints
		/// </summary>
		/// <param name="x"></param>
		/// <param name="y"></param>
		/// <returns>The largest of the two ints passed</returns>
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Max(int x, int y)
		{
			return x - (((x - y) & ((x - y) >> _absValueIntMask)));
		}
	}
}
