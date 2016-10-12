using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class PartitionTest
	{
		private IEnumerable<int> _target;

		[SetUp]
		public void Initialize()
		{
			_target = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}.Select(x => x);
		}

		[Test]
		public void Collection_Partition_Partition_IndexStartOfList()
		{
			var expected = Tuple.Create(
				new List<int> (),
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			);

			var result = _.Collection.Partition(_target, 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_Partition_IndexMiddleOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4 },
				new List<int> { 5, 6, 7, 8, 9 }
			);

			var result = _.Collection.Partition(_target, 5);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_Partition_IndexAtEndOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
				new List<int> { 9 }
			);

			var result = _.Collection.Partition(_target, 9);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_Partition_IndexPastEndOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = _.Collection.Partition(_target, 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_Partition_PredicateNoMatch()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = _.Collection.Partition(_target, n => n == 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_Partition_PredicateHasMatch()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4 },
				new List<int> { 5, 6, 7, 8, 9 }
			);

			var result = _.Collection.Partition(_target, n => n == 5);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_PartitionMatches_NoMatches()
		{
			var expected = Tuple.Create(
				new List<int>(),
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			);

			var result = _.Collection.PartitionMatches(_target, n => n == 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_PartitionMatches_SomeMatches()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 2, 4, 6, 8 },
				new List<int> { 1, 3, 5, 7, 9 }
			);

			var result = _.Collection.PartitionMatches(_target, n => n % 2 == 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[Test]
		public void Collection_Partition_PartitionMatches_AllMatches()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = _.Collection.PartitionMatches(_target, n => n % 1 == 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

        [Test]
        public void CollectionExtensions_Partition_Partition_IndexStartOfList()
        {
            var expected = Tuple.Create(
                new List<int>(),
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            );

            var result = _target.Partition(0);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_Partition_IndexMiddleOfList()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4 },
                new List<int> { 5, 6, 7, 8, 9 }
            );

            var result = _target.Partition(5);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_Partition_IndexAtEndOfList()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
                new List<int> { 9 }
            );

            var result = _target.Partition(9);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_Partition_IndexPastEndOfList()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int>()
            );

            var result = _target.Partition(10);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_Partition_PredicateNoMatch()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int>()
            );

            var result = _target.Partition(n => n == 10);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_Partition_PredicateHasMatch()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4 },
                new List<int> { 5, 6, 7, 8, 9 }
            );

            var result = _target.Partition(n => n == 5);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_PartitionMatches_NoMatches()
        {
            var expected = Tuple.Create(
                new List<int>(),
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            );

            var result = _target.PartitionMatches(n => n == 10);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_PartitionMatches_SomeMatches()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 2, 4, 6, 8 },
                new List<int> { 1, 3, 5, 7, 9 }
            );

            var result = _target.PartitionMatches(n => n % 2 == 0);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }

        [Test]
        public void CollectionExtensions_Partition_PartitionMatches_AllMatches()
        {
            var expected = Tuple.Create(
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int>()
            );

            var result = _target.PartitionMatches(n => n % 1 == 0);

            Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
            Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
        }
    }
}
