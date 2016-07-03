using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Collection
{
	[TestClass]
	public class FilterTest
	{
		private FilterComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new FilterComponent();
		}

		[TestMethod]
		public void Collection_Filter_Drop()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 4, 5, 6, 7, 8, 9, 10 };

			var result = component.Drop(target, 3);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Filter_DropWhile()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 6, 7, 8, 9, 10 };

			var result = component.DropWhile(target, i => i != 6);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Filter_Pull()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 1, 2, 3, 8, 9, 10 };

			var result = component.Pull(target, 4, 5, 6, 7);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Filter_TakeRight()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 10, 9, 8 };

			var result = component.TakeRight(target, 3);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[TestMethod]
		public void Collection_Filter_TakeRightWhile()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 10, 9, 8, 7 };

			var result = component.TakeRightWhile(target, i => i != 6);

			Assert.IsTrue(expected.SequenceEqual(result));
		}
	}
}
