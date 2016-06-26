using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;

namespace Underscore.Test.Action
{
	[TestClass]
	public class ConvertTest
	{
		private ConvertComponent component;
		private int[] output;

		private static int Sum(params int[] args)
		{
			return args.Aggregate(0, (total, next) => total + next);
		} 

		[TestInitialize]
		public void Initialize()
		{
			component = new ConvertComponent();
			output = new int[1];
		}

		
		// Expected for any given test is equal to the 
		// arithmetic progression from 1..n, 
		// where n is the number of arguments

		[TestMethod]
		public void Action_Convert_ToFunction_NoArguments()
		{
			const int expected = 0;
			System.Action action = () => output[0] = Sum(0);

			component.ToFunction(action).Invoke();

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_1Argument()
		{
			const int expected = 1;
			Action<int> action = (a) => output[0] = Sum(a);

			component.ToFunction(action).Invoke(1);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_2Arguments()
		{
			const int expected = 3;
			Action<int, int> action = (a, b) => output[0] = Sum(a, b);

			component.ToFunction(action).Invoke(1, 2);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_3Arguments()
		{
			const int expected = 6;
			Action<int, int, int> action = (a, b, c) => output[0] = Sum(a, b, c);

			component.ToFunction(action).Invoke(1, 2, 3);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_4Arguments()
		{
			const int expected = 10;
			Action<int, int, int, int> action = (a, b, c, d) => output[0] = Sum(a, b, c, d);

			component.ToFunction(action).Invoke(1, 2, 3, 4);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_5Arguments()
		{
			const int expected = 15;
			Action<int, int, int, int, int> action = (a, b, c, d, e) => output[0] = Sum(a, b, c, d, e);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_6Arguments()
		{
			const int expected = 21;
			Action<int, int, int, int, int, int> action = (a, b, c, d, e, f) => output[0] = Sum(a, b, c, d, e, f);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_7Arguments()
		{
			const int expected = 28;
			Action<int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g) => output[0] = Sum(a, b, c, d, e, f, g);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_8Arguments()
		{
			const int expected = 36;
			Action<int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h) => output[0] = Sum(a, b, c, d, e, f, g, h);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_9Arguments()
		{
			const int expected = 45;
			Action<int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i) => output[0] = Sum(a, b, c, d, e, f, g, h, i);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_10Arguments()
		{
			const int expected = 55;
			Action<int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_11Arguments()
		{
			const int expected = 66;
			Action<int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_12Arguments()
		{
			const int expected = 78;
			Action<int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_13Arguments()
		{
			const int expected = 91;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_14Arguments()
		{
			const int expected = 105;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_15Arguments()
		{
			const int expected = 120;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15);

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Convert_ToFunction_16Arguments()
		{
			const int expected = 136;
			Action<int, int, int, int, int, int, int, int, int, int, int, int, int, int, int, int> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => output[0] = Sum(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			component.ToFunction(action).Invoke(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);

			Assert.AreEqual(expected, output[0]);
		}
	}
}
