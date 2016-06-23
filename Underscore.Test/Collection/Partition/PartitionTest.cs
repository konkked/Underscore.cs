using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;
using Underscore.Utility;

namespace Underscore.Test.Collection
{
	[TestClass]
	public class PartitionTest
	{
		private PartitionComponent component;
		private int[] target;

		[TestInitialize]
		public void Initialize()
		{
			component = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
			target = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
		}

		[TestMethod]
		public void Collection_Partition_Partition_IndexStartOfList()
		{
			var expected = Tuple.Create(
				new List<int> (),
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			);

			var result = component.Partition(target, 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_Partition_IndexMiddleOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4 },
				new List<int> { 5, 6, 7, 8, 9 }
			);

			var result = component.Partition(target, 5);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_Partition_IndexAtEndOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8 },
				new List<int> { 9 }
			);

			var result = component.Partition(target, 9);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_Partition_IndexPastEndOfList()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = component.Partition(target, 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_Partition_PredicateNoMatch()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = component.Partition(target, n => n == 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_Partition_PredicateHasMatch()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4 },
				new List<int> { 5, 6, 7, 8, 9 }
			);

			var result = component.Partition(target, n => n == 5);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_PartitionMatches_NoMatches()
		{
			var expected = Tuple.Create(
				new List<int>(),
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }
			);

			var result = component.PartitionMatches(target, n => n == 10);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_PartitionMatches_SomeMatches()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 2, 4, 6, 8 },
				new List<int> { 1, 3, 5, 7, 9 }
			);

			var result = component.PartitionMatches(target, n => n % 2 == 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}

		[TestMethod]
		public void Collection_Partition_PartitionMatches_AllMatches()
		{
			var expected = Tuple.Create(
				new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 },
				new List<int>()
			);

			var result = component.PartitionMatches(target, n => n % 1 == 0);

			Assert.IsTrue(expected.Item1.SequenceEqual(result.Item1));
			Assert.IsTrue(expected.Item2.SequenceEqual(result.Item2));
		}
	}
}
