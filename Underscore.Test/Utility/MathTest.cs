using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
	[TestClass]
	public class MathTest
	{
		private MathComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new MathComponent();
		}

		[TestMethod]
		public void Utility_Math_Random_NoArguments()
		{
			var result = component.Random();

			Assert.IsTrue(result >= 0 && result < int.MaxValue);
		}

		[TestMethod]
		public void Utility_Math_Random_1Argument_Positive()
		{
			var result = component.Random(100);

			Assert.IsTrue(result >= 0 && result < 100);
		}

		[TestMethod]
		public void Utility_Math_Random_1Argument_Zero_ThrowsException()
		{
			var didThrow = false;

			try
			{
				component.Random(0);
			}
			catch (ArgumentException)
			{
				didThrow = true;
			}

			Assert.IsTrue(didThrow);
		}

		[TestMethod]
		public void Utility_Math_Random_1Argument_Negative_ThrowsException()
		{
			var didThrow = false;

			try
			{
				component.Random(-100);
			}
			catch (ArgumentException)
			{
				didThrow = true;
			}

			Assert.IsTrue(didThrow);
		}

		[TestMethod]
		public void Utility_Math_Random_2Arguments_NegativeMinPositiveMax()
		{
			var result = component.Random(-100, 100);

			Assert.IsTrue(result >= -100 && result < 100);
		}

		[TestMethod]
		public void Utility_Math_Random_2Arguments_NegativeMinNegativeMax()
		{
			var result = component.Random(-100, -30);

			Assert.IsTrue(result >= -100 && result < -30);
		}

		[TestMethod]
		public void Utility_Math_Random_2Arguments_PositiveMinPositiveMax()
		{
			var result = component.Random(30, 100);

			Assert.IsTrue(result >= 30 && result < 100);
		}

		[TestMethod]
		public void Utility_Math_Random_2Arguments_MinGreaterThanMax_ThrowsException()
		{
			var didThrow = false;

			try
			{
				component.Random(100, -100);
			}
			catch (ArgumentException)
			{
				didThrow = true;
			}

			Assert.IsTrue(didThrow);
		}

		[TestMethod]
		public void Utility_Math_Random_2Arguments_MinEqualToMax_ThrowsException()
		{
			var didThrow = false;

			try
			{
				component.Random(100, 100);
			}
			catch (ArgumentException)
			{
				didThrow = true;
			}

			Assert.IsTrue(didThrow);
		}

		[TestMethod]
		public void Utility_Math_UniqueId_IsUnique()
		{
			var hashset = new HashSet<string>();

			// the chances of a guid collision in a data set this size
			// are infintisemally small if the guid is being generated correctly
			for (int i = 0; i < 1000; i++)
				Assert.IsTrue(hashset.Add(component.UniqueId())); 
		}

		[TestMethod]
		public void Utility_Math_UniqueId_IsPrefixed()
		{
			var output = component.UniqueId("prefix");
			Assert.IsTrue(output.StartsWith("prefix"));
		}

		[TestMethod]
		public void Utility_Math_Abs_NegativeInput()
		{
			const int expected = 50;
			var result = component.Abs(-50);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Abs_PositiveInput()
		{
			const int expected = 50;
			var result = component.Abs(50);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Abs_ZeroInput()
		{
			const int expected = 0;
			var result = component.Abs(0);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Min_LeftSmaller()
		{
			const int expected = 1;
			var result = component.Min(1, 10);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Min_RightSmaller()
		{
			const int expected = 1;
			var result = component.Min(10, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Min_BothNegative()
		{
			const int expected = -10;
			var result = component.Min(-10, -1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Min_MixedNegativePositive()
		{
			const int expected = -10;
			var result = component.Min(-10, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Min_BothPositive()
		{
			const int expected = 1;
			var result = component.Min(10, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Max_LeftSmaller()
		{
			const int expected = 10;
			var result = component.Max(1, 10);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Max_RightSmaller()
		{
			const int expected = 10;
			var result = component.Max(10, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Max_BothNegative()
		{
			const int expected = -1;
			var result = component.Max(-10, -1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Max_MixedNegativePositive()
		{
			const int expected = 1;
			var result = component.Max(-10, 1);

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Utility_Math_Max_BothPositive()
		{
			const int expected = 10;
			var result = component.Max(10, 1);

			Assert.AreEqual(expected, result);
		}
	}
}
