using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;
using Underscore.Collection;
using Underscore.Extensions;
using Underscore.Utility;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class CombinationsTest
	{
		[Test]
		public void Collection_Partition_Combinations_Unit()
		{
			var testing = new PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent()));
			CollectionCombinationsImpl(testing.Combinations);
		}

		[Test]
		public void Collection_Partition_Combinations_Integration()
		{
			var testing = new Func<IEnumerable<int>, IEnumerable<IEnumerable<int>>>(_.Collection.Combinations);
			CollectionCombinationsImpl(testing);
		}

		private static void CollectionCombinationsImpl(Func<IEnumerable<int>, IEnumerable<IEnumerable<int>>> testing)
		{
			int[] stuff = { 1, 2, 3, 4 };

			int[][] expecting = new[]
			{
				new int[] {},
				new[] {1},
				new[] {1, 2},
				new[] {2},
				new[] {1, 2, 3},
				new[] {2, 3},
				new[] {1, 3},
				new[] {3},
				new[] {1, 2, 3, 4},
				new[] {1, 2, 4},
				new[] {1, 3, 4},
				new[] {2, 3, 4},
				new[] {3, 4},
				new[] {2, 4},
				new[] {1, 4},
				new[] {4}
			};

			var permutation = testing(stuff).Select(a => a.ToList()).ToList();

			Assert.IsTrue(
				expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
		}

	    [Test]
	    public void CollectionExtensions_Partition_Combinations()
	    {
            var stuff = new [] { 1, 2, 3, 4 }.Select(x => x); // to convert to IEnumerable

            int[][] expecting =
            {
                new int[] {},
                new[] {1},
                new[] {1, 2},
                new[] {2},
                new[] {1, 2, 3},
                new[] {2, 3},
                new[] {1, 3},
                new[] {3},
                new[] {1, 2, 3, 4},
                new[] {1, 2, 4},
                new[] {1, 3, 4},
                new[] {2, 3, 4},
                new[] {3, 4},
                new[] {2, 4},
                new[] {1, 4},
                new[] {4}
            };

            var permutation = stuff.Combinations().Select(a => a.ToList()).ToList();

            Assert.IsTrue(
                expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
        }
	}
}
