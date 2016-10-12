using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Collection;
using Underscore.Extensions;

namespace Underscore.Test.Collection.Zip
{
	[TestFixture]
	public class ZipTest
	{
		[Test]
		public void Collection_Zip_2Arguments_SameTypes()
		{
			int[] toZipA = {1, 2, 3, 4, 5, 6};
			int[] toZipB = {2, 3, 4, 5, 6, 7};
			Tuple<int, int>[] expected =
			{
				Tuple.Create(1, 2),
				Tuple.Create(2, 3),
				Tuple.Create(3, 4),
				Tuple.Create(4, 5),
				Tuple.Create(5, 6),
				Tuple.Create(6, 7)
			};

			var result = _.Collection.Zip(toZipA, toZipB).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_2Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			Tuple<int, string>[] expected =
			{
				Tuple.Create(1, "a"),
				Tuple.Create(2, "b"),
				Tuple.Create(3, "c"),
				Tuple.Create(4, "d"),
				Tuple.Create(5, "e"),
				Tuple.Create(6, "f")
			};

			var result = _.Collection.Zip(toZipA, toZipB).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_2Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5};
			Tuple<int, int>[] expected =
			{
				Tuple.Create(1, 2),
				Tuple.Create(2, 3),
				Tuple.Create(3, 4),
				Tuple.Create(4, 5)
			};

			var result = _.Collection.Zip(toZipA, toZipB).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_3Arguments_SameTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			Tuple<int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3),
				Tuple.Create(2, 3, 4),
				Tuple.Create(3, 4, 5),
				Tuple.Create(4, 5, 6),
				Tuple.Create(5, 6, 7),
				Tuple.Create(6, 7, 8)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_3Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
			Tuple<int, string, double>[] expected =
			{
				Tuple.Create(1, "a", 3.0),
				Tuple.Create(2, "b", 4.0),
				Tuple.Create(3, "c", 5.0),
				Tuple.Create(4, "d", 6.0),
				Tuple.Create(5, "e", 7.0),
				Tuple.Create(6, "f", 8.0)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_3Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			Tuple<int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3),
				Tuple.Create(2, 3, 4),
				Tuple.Create(3, 4, 5),
				Tuple.Create(4, 5, 6)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_4Arguments_SameTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			Tuple<int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4),
				Tuple.Create(2, 3, 4, 5),
				Tuple.Create(3, 4, 5, 6),
				Tuple.Create(4, 5, 6, 7),
				Tuple.Create(5, 6, 7, 8),
				Tuple.Create(6, 7, 8, 9)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_4Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
			char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
			Tuple<int, string, double, char>[] expected =
			{
				Tuple.Create(1, "a", 3.0, 'z'),
				Tuple.Create(2, "b", 4.0, 'y'),
				Tuple.Create(3, "c", 5.0, 'x'),
				Tuple.Create(4, "d", 6.0, 'w'),
				Tuple.Create(5, "e", 7.0, 'v'),
				Tuple.Create(6, "f", 8.0, 'u')
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_4Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			Tuple<int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4),
				Tuple.Create(2, 3, 4, 5),
				Tuple.Create(3, 4, 5, 6),
				Tuple.Create(4, 5, 6, 7)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_5Arguments_SameTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			Tuple<int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5),
				Tuple.Create(2, 3, 4, 5, 6),
				Tuple.Create(3, 4, 5, 6, 7),
				Tuple.Create(4, 5, 6, 7, 8),
				Tuple.Create(5, 6, 7, 8, 9),
				Tuple.Create(6, 7, 8, 9, 10)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_5Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
			char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
			decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
			Tuple<int, string, double, char, decimal>[] expected =
			{
				Tuple.Create(1, "a", 3.0, 'z', 5m),
				Tuple.Create(2, "b", 4.0, 'y', 6m),
				Tuple.Create(3, "c", 5.0, 'x', 7m),
				Tuple.Create(4, "d", 6.0, 'w', 8m),
				Tuple.Create(5, "e", 7.0, 'v', 9m),
				Tuple.Create(6, "f", 8.0, 'u', 10m)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_5Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			Tuple<int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5),
				Tuple.Create(2, 3, 4, 5, 6),
				Tuple.Create(3, 4, 5, 6, 7),
				Tuple.Create(4, 5, 6, 7, 8)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_6Arguments_SameTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			Tuple<int, int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5, 6),
				Tuple.Create(2, 3, 4, 5, 6, 7),
				Tuple.Create(3, 4, 5, 6, 7, 8),
				Tuple.Create(4, 5, 6, 7, 8, 9),
				Tuple.Create(5, 6, 7, 8, 9, 10),
				Tuple.Create(6, 7, 8, 9, 10, 11)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_6Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
			char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
			decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
			float[] toZipF = { 6, 7, 8, 9, 10, 11 };
			Tuple<int, string, double, char, decimal, float>[] expected =
			{
				Tuple.Create(1, "a", 3.0, 'z', 5m, 6f),
				Tuple.Create(2, "b", 4.0, 'y', 6m, 7f),
				Tuple.Create(3, "c", 5.0, 'x', 7m, 8f),
				Tuple.Create(4, "d", 6.0, 'w', 8m, 9f),
				Tuple.Create(5, "e", 7.0, 'v', 9m, 10f),
				Tuple.Create(6, "f", 8.0, 'u', 10m, 11f)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_6Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			Tuple<int, int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5, 6),
				Tuple.Create(2, 3, 4, 5, 6, 7),
				Tuple.Create(3, 4, 5, 6, 7, 8),
				Tuple.Create(4, 5, 6, 7, 8, 9),
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_7Arguments_SameTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			int[] toZipG = { 7, 8, 9, 10, 11, 12 };
			Tuple<int, int, int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5, 6, 7),
				Tuple.Create(2, 3, 4, 5, 6, 7, 8),
				Tuple.Create(3, 4, 5, 6, 7, 8, 9),
				Tuple.Create(4, 5, 6, 7, 8, 9, 10),
				Tuple.Create(5, 6, 7, 8, 9, 10, 11),
				Tuple.Create(6, 7, 8, 9, 10, 11, 12)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_7Arguments_MixedTypes()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			string[] toZipB = { "a", "b", "c", "d", "e", "f" };
			double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
			char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
			decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
			float[] toZipF = { 6, 7, 8, 9, 10, 11 };
			long[] toZipG = { 7, 8, 9, 10, 11, 12 };
			Tuple<int, string, double, char, decimal, float, long>[] expected =
			{
				Tuple.Create(1, "a", 3.0, 'z', 5m, 6f, 7L),
				Tuple.Create(2, "b", 4.0, 'y', 6m, 7f, 8L),
				Tuple.Create(3, "c", 5.0, 'x', 7m, 8f, 9L),
				Tuple.Create(4, "d", 6.0, 'w', 8m, 9f, 10L),
				Tuple.Create(5, "e", 7.0, 'v', 9m, 10f, 11L),
				Tuple.Create(6, "f", 8.0, 'u', 10m, 11f, 12L)
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

		[Test]
		public void Collection_Zip_7Arguments_MixedLength()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7};
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			int[] toZipG = { 7, 8, 9, 10, 11, 12 };
			Tuple<int, int, int, int, int, int, int>[] expected =
			{
				Tuple.Create(1, 2, 3, 4, 5, 6, 7),
				Tuple.Create(2, 3, 4, 5, 6, 7, 8),
				Tuple.Create(3, 4, 5, 6, 7, 8, 9),
				Tuple.Create(4, 5, 6, 7, 8, 9, 10),
			};

			var result = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

			for (var i = 0; i < result.Count; i++)
			{
				Assert.IsTrue(expected[i].Equals(result[i]));
			}
		}

        [Test]
        public void CollectionExtensions_Zip_2Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            Tuple<int, int>[] expected =
            {
                Tuple.Create(1, 2),
                Tuple.Create(2, 3),
                Tuple.Create(3, 4),
                Tuple.Create(4, 5),
                Tuple.Create(5, 6),
                Tuple.Create(6, 7)
            };

            var result = toZipA.ZipToTuples(toZipB).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_2Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            Tuple<int, string>[] expected =
            {
                Tuple.Create(1, "a"),
                Tuple.Create(2, "b"),
                Tuple.Create(3, "c"),
                Tuple.Create(4, "d"),
                Tuple.Create(5, "e"),
                Tuple.Create(6, "f")
            };

            var result = toZipA.ZipToTuples(toZipB).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_2Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5 };
            Tuple<int, int>[] expected =
            {
                Tuple.Create(1, 2),
                Tuple.Create(2, 3),
                Tuple.Create(3, 4),
                Tuple.Create(4, 5)
            };

            var result = toZipA.ZipToTuples(toZipB).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_3Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            Tuple<int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3),
                Tuple.Create(2, 3, 4),
                Tuple.Create(3, 4, 5),
                Tuple.Create(4, 5, 6),
                Tuple.Create(5, 6, 7),
                Tuple.Create(6, 7, 8)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_3Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
            Tuple<int, string, double>[] expected =
            {
                Tuple.Create(1, "a", 3.0),
                Tuple.Create(2, "b", 4.0),
                Tuple.Create(3, "c", 5.0),
                Tuple.Create(4, "d", 6.0),
                Tuple.Create(5, "e", 7.0),
                Tuple.Create(6, "f", 8.0)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_3Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            Tuple<int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3),
                Tuple.Create(2, 3, 4),
                Tuple.Create(3, 4, 5),
                Tuple.Create(4, 5, 6)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_4Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            Tuple<int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4),
                Tuple.Create(2, 3, 4, 5),
                Tuple.Create(3, 4, 5, 6),
                Tuple.Create(4, 5, 6, 7),
                Tuple.Create(5, 6, 7, 8),
                Tuple.Create(6, 7, 8, 9)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_4Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
            char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
            Tuple<int, string, double, char>[] expected =
            {
                Tuple.Create(1, "a", 3.0, 'z'),
                Tuple.Create(2, "b", 4.0, 'y'),
                Tuple.Create(3, "c", 5.0, 'x'),
                Tuple.Create(4, "d", 6.0, 'w'),
                Tuple.Create(5, "e", 7.0, 'v'),
                Tuple.Create(6, "f", 8.0, 'u')
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_4Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            Tuple<int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4),
                Tuple.Create(2, 3, 4, 5),
                Tuple.Create(3, 4, 5, 6),
                Tuple.Create(4, 5, 6, 7)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_5Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            Tuple<int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5),
                Tuple.Create(2, 3, 4, 5, 6),
                Tuple.Create(3, 4, 5, 6, 7),
                Tuple.Create(4, 5, 6, 7, 8),
                Tuple.Create(5, 6, 7, 8, 9),
                Tuple.Create(6, 7, 8, 9, 10)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_5Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
            char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
            decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
            Tuple<int, string, double, char, decimal>[] expected =
            {
                Tuple.Create(1, "a", 3.0, 'z', 5m),
                Tuple.Create(2, "b", 4.0, 'y', 6m),
                Tuple.Create(3, "c", 5.0, 'x', 7m),
                Tuple.Create(4, "d", 6.0, 'w', 8m),
                Tuple.Create(5, "e", 7.0, 'v', 9m),
                Tuple.Create(6, "f", 8.0, 'u', 10m)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_5Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            Tuple<int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5),
                Tuple.Create(2, 3, 4, 5, 6),
                Tuple.Create(3, 4, 5, 6, 7),
                Tuple.Create(4, 5, 6, 7, 8)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_6Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            int[] toZipF = { 6, 7, 8, 9, 10, 11 };
            Tuple<int, int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5, 6),
                Tuple.Create(2, 3, 4, 5, 6, 7),
                Tuple.Create(3, 4, 5, 6, 7, 8),
                Tuple.Create(4, 5, 6, 7, 8, 9),
                Tuple.Create(5, 6, 7, 8, 9, 10),
                Tuple.Create(6, 7, 8, 9, 10, 11)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_6Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
            char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
            decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
            float[] toZipF = { 6, 7, 8, 9, 10, 11 };
            Tuple<int, string, double, char, decimal, float>[] expected =
            {
                Tuple.Create(1, "a", 3.0, 'z', 5m, 6f),
                Tuple.Create(2, "b", 4.0, 'y', 6m, 7f),
                Tuple.Create(3, "c", 5.0, 'x', 7m, 8f),
                Tuple.Create(4, "d", 6.0, 'w', 8m, 9f),
                Tuple.Create(5, "e", 7.0, 'v', 9m, 10f),
                Tuple.Create(6, "f", 8.0, 'u', 10m, 11f)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_6Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            int[] toZipF = { 6, 7, 8, 9, 10, 11 };
            Tuple<int, int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5, 6),
                Tuple.Create(2, 3, 4, 5, 6, 7),
                Tuple.Create(3, 4, 5, 6, 7, 8),
                Tuple.Create(4, 5, 6, 7, 8, 9),
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_7Arguments_SameTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7, 8, 9 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            int[] toZipF = { 6, 7, 8, 9, 10, 11 };
            int[] toZipG = { 7, 8, 9, 10, 11, 12 };
            Tuple<int, int, int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5, 6, 7),
                Tuple.Create(2, 3, 4, 5, 6, 7, 8),
                Tuple.Create(3, 4, 5, 6, 7, 8, 9),
                Tuple.Create(4, 5, 6, 7, 8, 9, 10),
                Tuple.Create(5, 6, 7, 8, 9, 10, 11),
                Tuple.Create(6, 7, 8, 9, 10, 11, 12)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_7Arguments_MixedTypes()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            string[] toZipB = { "a", "b", "c", "d", "e", "f" };
            double[] toZipC = { 3.0, 4.0, 5.0, 6.0, 7.0, 8.0 };
            char[] toZipD = { 'z', 'y', 'x', 'w', 'v', 'u' };
            decimal[] toZipE = { 5m, 6m, 7m, 8m, 9m, 10m };
            float[] toZipF = { 6, 7, 8, 9, 10, 11 };
            long[] toZipG = { 7, 8, 9, 10, 11, 12 };
            Tuple<int, string, double, char, decimal, float, long>[] expected =
            {
                Tuple.Create(1, "a", 3.0, 'z', 5m, 6f, 7L),
                Tuple.Create(2, "b", 4.0, 'y', 6m, 7f, 8L),
                Tuple.Create(3, "c", 5.0, 'x', 7m, 8f, 9L),
                Tuple.Create(4, "d", 6.0, 'w', 8m, 9f, 10L),
                Tuple.Create(5, "e", 7.0, 'v', 9m, 10f, 11L),
                Tuple.Create(6, "f", 8.0, 'u', 10m, 11f, 12L)
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }

        [Test]
        public void CollectionExtensions_Zip_7Arguments_MixedLength()
        {
            int[] toZipA = { 1, 2, 3, 4, 5, 6 };
            int[] toZipB = { 2, 3, 4, 5, 6, 7 };
            int[] toZipC = { 3, 4, 5, 6, 7, 8 };
            int[] toZipD = { 4, 5, 6, 7 };
            int[] toZipE = { 5, 6, 7, 8, 9, 10 };
            int[] toZipF = { 6, 7, 8, 9, 10, 11 };
            int[] toZipG = { 7, 8, 9, 10, 11, 12 };
            Tuple<int, int, int, int, int, int, int>[] expected =
            {
                Tuple.Create(1, 2, 3, 4, 5, 6, 7),
                Tuple.Create(2, 3, 4, 5, 6, 7, 8),
                Tuple.Create(3, 4, 5, 6, 7, 8, 9),
                Tuple.Create(4, 5, 6, 7, 8, 9, 10),
            };

            var result = toZipA.ZipToTuples(toZipB, toZipC, toZipD, toZipE, toZipF, toZipG).ToList();

            for (var i = 0; i < result.Count; i++)
            {
                Assert.IsTrue(expected[i].Equals(result[i]));
            }
        }
    }
}
