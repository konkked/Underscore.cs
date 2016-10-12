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
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 1, 2, 3, 8, 9, 10 };

			var result = _.Collection.Difference(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_DifferenceBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };

			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "1", "2", "3", "8", "9", "10" };

			var result = _.Collection.DifferenceBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_Intersection()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 4, 5, 6, 7 };

			var result = _.Collection.Intersection(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_IntersectionBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "4", "5", "6", "7" };

			var result = _.Collection.IntersectionBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_Union()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var result = _.Collection.Union(a, b);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

		[Test]
		public void Collection_Set_UnionBy()
		{
			var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
			var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
			Func<int, string> transform = i => i.ToString();

			var expected = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

			var result = _.Collection.UnionBy(a, b, transform);

			Assert.IsTrue(expected.SequenceEqual(result));
		}

        [Test]
        public void CollectionExtensions_Set_Difference()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
            var expected = new[] { 1, 2, 3, 8, 9, 10 };

            var result = a.Difference(b);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_DifferenceBy()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var b = new[] { 4, 5, 6, 7, 8, 9, 10 };

            Func<int, string> transform = i => i.ToString();

            var expected = new[] { "1", "2", "3", "8", "9", "10" };

            var result = a.DifferenceBy(b, transform);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_Intersection()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
            var expected = new[] { 4, 5, 6, 7 };

            var result = a.Intersection(b);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_IntersectionBy()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
            Func<int, string> transform = i => i.ToString();

            var expected = new[] { "4", "5", "6", "7" };

            var result = a.IntersectionBy(b, transform);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Set_UnionBy()
        {
            var a = new[] { 1, 2, 3, 4, 5, 6, 7 };
            var b = new[] { 4, 5, 6, 7, 8, 9, 10 };
            Func<int, string> transform = i => i.ToString();

            var expected = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            var result = a.UnionBy(b, transform);

            Assert.IsTrue(expected.SequenceEqual(result));
        }
    }
}
