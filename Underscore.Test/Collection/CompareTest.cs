using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class CompareTest
	{
		[Test]
		public void Collection_Compare_IsSorted_StringArguments_SortedInput()
		{
			string[] input = { "a", "b", "c", "d", "e", "f" };
			Assert.IsTrue(_.Collection.IsSorted(input));
		}

		[Test]
		public void Collection_Compare_IsSorted_StringArguments_UnsortedInput()
		{
			string[] input = { "a", "b", "c", "z", "y", "x" };
			Assert.IsFalse(_.Collection.IsSorted(input));
		}

		[Test]
		public void Collection_Compare_IsSorted_IntArguments_SortedInput()
		{
			int[] input = { 1, 2, 3, 4, 5, 6 };
			Assert.IsTrue(_.Collection.IsSorted(input));
		}

		[Test]
		public void Collection_Compare_IsSorted_IntArguments_UnsortedInput()
		{
			int[] input = { 1, 2, 3, 6, 5, 4 };
			Assert.IsFalse(_.Collection.IsSorted(input));
		}

		[Test]
		public void Collection_Compare_IsSorted_Descending_SortedInput()
		{
			int[] input = { 6, 5, 4, 3, 2, 1 };
			Assert.IsTrue(_.Collection.IsSorted(input, true));
		}

		[Test]
		public void Collection_Compare_IsSorted_Descending_UnsortedInput()
		{
			int[] input = { 1, 2, 3, 6, 5, 4 };
			Assert.IsFalse(_.Collection.IsSorted(input, true));
		}

        [Test]
        public void CollectionExtensions_Compare_IsSorted_StringArguments_SortedInput()
        {
            string[] input = { "a", "b", "c", "d", "e", "f" };
            Assert.IsTrue(input.IsSorted());
        }

        [Test]
        public void CollectionExtensions_Compare_IsSorted_StringArguments_UnsortedInput()
        {
            string[] input = { "a", "b", "c", "z", "y", "x" };
            Assert.IsFalse(input.IsSorted());
        }

        [Test]
        public void CollectionExtensions_Compare_IsSorted_IntArguments_SortedInput()
        {
            int[] input = { 1, 2, 3, 4, 5, 6 };
            Assert.IsTrue(input.IsSorted());
        }

        [Test]
        public void CollectionExtensions_Compare_IsSorted_IntArguments_UnsortedInput()
        {
            int[] input = { 1, 2, 3, 6, 5, 4 };
            Assert.IsFalse(input.IsSorted());
        }

        [Test]
        public void CollectionExtensions_Compare_IsSorted_Descending_SortedInput()
        {
            int[] input = { 6, 5, 4, 3, 2, 1 };
            Assert.IsTrue(input.IsSorted(true));
        }

        [Test]
        public void CollectionExtensions_Compare_IsSorted_Descending_UnsortedInput()
        {
            int[] input = { 1, 2, 3, 6, 5, 4 };
            Assert.IsFalse(input.IsSorted(true));
        }
    }
}
