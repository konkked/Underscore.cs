using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Underscore.Collection;
using Underscore.Extensions;
using Underscore.Utility;

namespace Underscore.Test.Collection.Partition
{
	[TestFixture]
	public class ChunkTest
	{
		private IEnumerable<int> target;

		[SetUp]
		public void Intitialize()
		{
			target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }.Select(x => x); // to convert to IEnumerable
		}

		[Test]
		public void Collection_Partition_Chunk_IndexEvenDistribution()
		{
			var expected = new List<List<int>>
			{
				new() { 0, 1 },
				new() { 2, 3 },
				new() { 4, 5 },
				new() { 6, 7 },
				new() { 8, 9 }
			};

			var result = _.Collection.Chunk(target, 2).ToList();

			Assert.AreEqual(expected.Count, result.Count);

			// for each chunk, make sure it's sequentially equal 
			// to its respective expected chunk
			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[Test]
		public void Collection_Partition_Chunk_IndexUnevenDistribution()
		{
			var expected = new List<List<int>>
			{
				new() { 0, 1, 2 },
				new() { 3, 4, 5 },
				new() { 6, 7, 8 },
				new() { 9 }
			};

			var result = _.Collection.Chunk(target, 3).ToList();

			Assert.AreEqual(expected.Count, result.Count);

			// for each chunk, make sure it's sequentially equal 
			// to its respective expected chunk
			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[Test]
		public void Collection_Partition_Chunk_PredicateNoMatches()
		{
			var expected = new List<List<int>>
			{
				new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			};

			var result = _.Collection.Chunk(target, n => n == 10).ToList();

			Assert.AreEqual(expected.Count, result.Count);

			// for each chunk, make sure it's sequentially equal 
			// to its respective expected chunk
			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[Test]
		public void Collection_Partition_Chunk_PredicateSomeMatches()
		{
			var expected = new List<List<int>>
			{
				new() { 0, 1 },
				new() { 2, 3 },
				new() { 4, 5 },
				new() { 6, 7 },
				new() { 8, 9 }
			};

			var result = _.Collection.Chunk(target, n => n % 2 == 0).ToList();

			Assert.AreEqual(expected.Count, result.Count);

			// for each chunk, make sure it's sequentially equal 
			// to its respective expected chunk
			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

		[Test]
		public void Collection_Partition_Chunk_PredicateAllMatches()
		{
			var expected = new List<List<int>>
			{
				new() { 0 },
				new() { 1 },
				new() { 2 },
				new() { 3 },
				new() { 4 },
				new() { 5 },
				new() { 6 },
				new() { 7 },
				new() { 8 },
				new() { 9 },
			};

			var result = _.Collection.Chunk(target, n => n % 1 == 0).ToList();

			Assert.AreEqual(expected.Count, result.Count);

			// for each chunk, make sure it's sequentially equal 
			// to its respective expected chunk
			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].SequenceEqual(result[i]));
			}
		}

        [Test]
        public void CollectionExtensions_Partition_Chunk_IndexEvenDistribution()
        {
            var expected = new List<List<int>>
            {
                new() { 0, 1 },
                new() { 2, 3 },
                new() { 4, 5 },
                new() { 6, 7 },
                new() { 8, 9 }
            };

            var result = ExtensionsImpl.Chunk(target,2).ToList();

            Assert.AreEqual(expected.Count, result.Count);

            // for each chunk, make sure it's sequentially equal 
            // to its respective expected chunk
            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].SequenceEqual(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Partition_Chunk_IndexUnevenDistribution()
        {
            var expected = new List<List<int>>
            {
                new() { 0, 1, 2 },
                new() { 3, 4, 5 },
                new() { 6, 7, 8 },
                new() { 9 }
            };

            var result = ExtensionsImpl.Chunk(target, 3).ToList();

            Assert.AreEqual(expected.Count, result.Count);

            // for each chunk, make sure it's sequentially equal 
            // to its respective expected chunk
            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].SequenceEqual(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Partition_Chunk_PredicateNoMatches()
        {
            var expected = new List<List<int>>
            {
                new() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
            };

            var result = target.Chunk(n => n == 10).ToList();

            Assert.AreEqual(expected.Count, result.Count);

            // for each chunk, make sure it's sequentially equal 
            // to its respective expected chunk
            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].SequenceEqual(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Partition_Chunk_PredicateSomeMatches()
        {
            var expected = new List<List<int>>
            {
                new() { 0, 1 },
                new() { 2, 3 },
                new() { 4, 5 },
                new() { 6, 7 },
                new() { 8, 9 }
            };

            var result = target.Chunk(n => n % 2 == 0).ToList();

            Assert.AreEqual(expected.Count(), result.Count);

            // for each chunk, make sure it's sequentially equal 
            // to its respective expected chunk
            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].SequenceEqual(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Partition_Chunk_PredicateAllMatches()
        {
            var expected = new List<List<int>>
            {
                new() { 0 },
                new() { 1 },
                new() { 2 },
                new() { 3 },
                new() { 4 },
                new() { 5 },
                new() { 6 },
                new() { 7 },
                new() { 8 },
                new() { 9 },
            };

            var result = target.Chunk(n => n % 1 == 0).ToList();

            Assert.AreEqual(expected.Count, result.Count);

            // for each chunk, make sure it's sequentially equal 
            // to its respective expected chunk
            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].SequenceEqual(result[i]));
            }
        }
    }
}
