using System.Linq;
using NUnit.Framework;
using Underscore.Collection;

namespace Underscore.Test.Collection.Zip
{
	[TestFixture]
	public class UnZipTest
	{
		private ZipComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new ZipComponent();
		}

		[Test]
		public void Collection_Zip_UnZip_2Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			var zipped = _.Collection.Zip(toZipA, toZipB);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
		}

		[Test]
		public void Collection_Zip_UnZip_3Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			var zipped = _.Collection.Zip(toZipA, toZipB, toZipC);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
		}

		[Test]
		public void Collection_Zip_UnZip_4Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			var zipped = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
		}

		[Test]
		public void Collection_Zip_UnZip_5Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			var zipped = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
			Assert.IsTrue(result.Item5.SequenceEqual(toZipE));
		}

		[Test]
		public void Collection_Zip_UnZip_6Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			var zipped = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
			Assert.IsTrue(result.Item5.SequenceEqual(toZipE));
			Assert.IsTrue(result.Item6.SequenceEqual(toZipF));
		}

		[Test]
		public void Collection_Zip_UnZip_7Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			int[] toZipG = { 7, 8, 9, 10, 11, 12 };
			var zipped = _.Collection.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF, toZipG);
			var result = _.Collection.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
			Assert.IsTrue(result.Item5.SequenceEqual(toZipE));
			Assert.IsTrue(result.Item6.SequenceEqual(toZipF));
			Assert.IsTrue(result.Item7.SequenceEqual(toZipG));
		}
	}
}
