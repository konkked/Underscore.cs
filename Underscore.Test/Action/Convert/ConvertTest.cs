using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Action;

namespace Underscore.Test.Action
{
	[TestFixture]
	public class ConvertTest
	{
		private ConvertComponent component;
		private int[] output;

		private static int Sum(params int[] args)
		{
			return args.Aggregate(0, (total, next) => total + next);
		} 

		[SetUp]
		public void Initialize()
		{
			component = new ConvertComponent();
			output = new int[1];
		}

		
		// Expected for any given test is equal to the 
		// arithmetic progression from 1..n, 
		// where n is the number of arguments

		[Test]
		public void Action_Convert_ToFunction_NoArguments()
		{
			const int expected = 0;
			System.Action action = () => output[0] = Sum(0);

			_.Action.ToFunction(action).Invoke();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_1Argument()
		{
			const int expected = 1;
			Action<int> action = (a) => output[0] = Sum(a);

			_.Action.ToFunction(action).Invoke(1);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_2Arguments()
		{
			const int expected = 3;
			Action<int, int> action = (a, b) => output[0] = Sum(a, b);

			_.Action.ToFunction(action).Invoke(1, 2);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_3Arguments()
		{
			const int expected = 6;
			Action<int, int, int> action = (a, b, c) => output[0] = Sum(a, b, c);

			_.Action.ToFunction(action).Invoke(1, 2, 3);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_4Arguments()
		{
			const int expected = 10;
			Action<int, int, int, int> action = (a, b, c, d) => output[0] = Sum(a, b, c, d);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_5Arguments()
		{
			const int expected = 15;
			Action<int, int, int, int, int> action = (a, b, c, d, e) => output[0] = Sum(a, b, c, d, e);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_6Arguments()
		{
			const int expected = 21;
			Action<int, int, int, int, int, int> action = (a, b, c, d, e, f) => output[0] = Sum(a, b, c, d, e, f);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_7Arguments()
		{
			const int expected = 28;
			Action<int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g) => output[0] = Sum(a, b, c, d, e, f, g);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_8Arguments()
		{
			const int expected = 36;
			Action<int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h) => output[0] = Sum(a, b, c, d, e, f, g, h);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_9Arguments()
		{
			const int expected = 45;
			Action<int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i) => output[0] = Sum(a, b, c, d, e, f, g, h, i);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_10Arguments()
		{
			const int expected = 55;
			Action<int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_11Arguments()
		{
			const int expected = 66;
			Action<int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_12Arguments()
		{
			const int expected = 78;
			Action<int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_13Arguments()
		{
			const int expected = 91;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_14Arguments()
		{
			const int expected = 105;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_15Arguments()
		{
			const int expected = 120;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Convert_ToFunction_16Arguments()
		{
			const int expected = 136;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			_.Action.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

			Assert.AreEqual(expected, output[0]);
		}
	}
}
