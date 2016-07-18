﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Underscore.Collection;
using Underscore.Utility;

namespace Underscore.Test.Collection.Partition
{
	[TestFixture]
	public class ChunkTest
	{
		private int[] target;
		private PartitionComponent component;

		[SetUp]
		public void Intitialize()
		{
			target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			component = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
		}

		[Test]
		public void Collection_Partition_Chunk_IndexEvenDistribution()
		{
			var expected = new List<List<int>>
			{
				new List<int> { 0, 1 },
				new List<int> { 2, 3 },
				new List<int> { 4, 5 },
				new List<int> { 6, 7 },
				new List<int> { 8, 9 }
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
				new List<int> { 0, 1, 2 },
				new List<int> { 3, 4, 5 },
				new List<int> { 6, 7, 8 },
				new List<int> { 9 }
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
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
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
				new List<int> { 0, 1 },
				new List<int> { 2, 3 },
				new List<int> { 4, 5 },
				new List<int> { 6, 7 },
				new List<int> { 8, 9 }
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
				new List<int> { 0 },
				new List<int> { 1 },
				new List<int> { 2 },
				new List<int> { 3 },
				new List<int> { 4 },
				new List<int> { 5 },
				new List<int> { 6 },
				new List<int> { 7 },
				new List<int> { 8 },
				new List<int> { 9 },
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
	}
}
