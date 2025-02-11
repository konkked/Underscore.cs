using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class SetTest
	{
		[Test]
		public void Collection_Set_Difference()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];
			int[] expected = [1, 2, 3, 8, 9, 10];

			var result = _.Collection.Difference(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_DifferenceBy()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];

			string[] expected = ["1", "2", "3", "8", "9", "10"];

			var result = _.Collection.DifferenceBy(a, b, i => i.ToString());

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_Intersection()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];
			int[] expected = [4, 5, 6, 7];

			var result = _.Collection.Intersection(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_IntersectionBy()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];

			string[] expected = ["4", "5", "6", "7"];

			var result = _.Collection.IntersectionBy(a, b, i => i.ToString());

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_Union()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];
			int[] expected = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

			var result = _.Collection.Union(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_UnionBy()
		{
			int[] a = [1, 2, 3, 4, 5, 6, 7];
			int[] b = [4, 5, 6, 7, 8, 9, 10];

			string[] expected = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];

			var result = _.Collection.UnionBy(a, b, i => i.ToString());

			Assert.IsTrue(expected.SequenceEqual(result));
		}

        [Test]
        public void CollectionExtensions_Set_Difference()
        {
            int[] a = [1, 2, 3, 4, 5, 6, 7];
            int[] b = [4, 5, 6, 7, 8, 9, 10];
            int[] expected = [1, 2, 3, 8, 9, 10];

            var result = a.Difference(b);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_DifferenceBy()
        {
            int[] a = [1, 2, 3, 4, 5, 6, 7];
            int[] b = [4, 5, 6, 7, 8, 9, 10];

            Func<int, string> transform = i => i.ToString();

            string[] expected = ["1", "2", "3", "8", "9", "10"];

            var result = a.DifferenceBy(b, transform);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_Intersection()
        {
            int[] a = [1, 2, 3, 4, 5, 6, 7];
            int[] b = [4, 5, 6, 7, 8, 9, 10];
            int[] expected = [4, 5, 6, 7];

            var result = a.Intersection(b);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_IntersectionBy()
        {
            int[] a = [1, 2, 3, 4, 5, 6, 7];
            int[] b = [4, 5, 6, 7, 8, 9, 10];

            string[] expected = ["4", "5", "6", "7"];

            var result = a.IntersectionBy(b, i => i.ToString());

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_UnionBy()
        {
            int[] a = [1, 2, 3, 4, 5, 6, 7];
            int[] b = [4, 5, 6, 7, 8, 9, 10];

            string[] expected = ["1", "2", "3", "4", "5", "6", "7", "8", "9", "10"];

            var result = ExtensionsImpl.UnionBy(a, b, i=>i.ToString());

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
