using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class FilterTest
	{
		[Test]
		public void Collection_Filter_Drop()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 4, 5, 6, 7, 8, 9, 10 };

			var result = _.Collection.Drop(target, 3);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Filter_DropWhile()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 6, 7, 8, 9, 10 };

			var result = _.Collection.DropWhile(target, i => i != 6);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Filter_Pull()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 1, 2, 3, 8, 9, 10 };

			var result = _.Collection.Pull(target, 4, 5, 6, 7);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Filter_TakeRight()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 10, 9, 8 };

			var result = _.Collection.TakeRight(target, 3);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Filter_TakeRightWhile()
		{
			int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int[] expected = { 10, 9, 8, 7 };

			var result = _.Collection.TakeRightWhile(target, i => i != 6);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

        [Test]
        public void CollectionExtensions_Filter_Drop()
        {
            int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 4, 5, 6, 7, 8, 9, 10 };

            var result = target.Drop(3);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Filter_DropWhile()
        {
            int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 6, 7, 8, 9, 10 };

            var result = target.DropWhile(i => i != 6);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Filter_Pull()
        {
            int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 1, 2, 3, 8, 9, 10 };

            var result = target.Pull(4, 5, 6, 7);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Filter_TakeRight()
        {
            int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 10, 9, 8 };

            var result = target.TakeRight(3);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Filter_TakeRightWhile()
        {
            int[] target = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] expected = { 10, 9, 8, 7 };

            var result = target.TakeRightWhile(i => i != 6);

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
