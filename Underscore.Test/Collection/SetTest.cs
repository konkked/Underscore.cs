using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Collection
{
	[TestClass]
	public class SetTest
	{
		private SetComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new SetComponent();
		}

		[TestMethod]
		public void Collection_Set_Difference()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 1, 2, 3, 8, 9, 10 };

			var result = component.Difference(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Set_DifferenceBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };

			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "1", "2", "3", "8", "9", "10" };

			var result = component.DifferenceBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Set_Intersection()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 4, 5, 6, 7 };

			var result = component.Intersection(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Set_IntersectionBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "4", "5", "6", "7" };

			var result = component.IntersectionBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Set_Union()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var result = component.Union(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Set_UnionBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

			var result = component.UnionBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}
	}
}
