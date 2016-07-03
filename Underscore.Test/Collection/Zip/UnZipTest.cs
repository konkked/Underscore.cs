using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Collection.Zip
{
	[TestClass]
	public class UnZipTest
	{
		private ZipComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new ZipComponent();
		}

		[TestMethod]
		public void Collection_Zip_UnZip_2Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			var zipped = component.Zip(toZipA, toZipB);
			var result = component.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
		}

		[TestMethod]
		public void Collection_Zip_UnZip_3Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			var zipped = component.Zip(toZipA, toZipB, toZipC);
			var result = component.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
		}

		[TestMethod]
		public void Collection_Zip_UnZip_4Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			var zipped = component.Zip(toZipA, toZipB, toZipC, toZipD);
			var result = component.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
		}

		[TestMethod]
		public void Collection_Zip_UnZip_5Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			var zipped = component.Zip(toZipA, toZipB, toZipC, toZipD, toZipE);
			var result = component.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
			Assert.IsTrue(result.Item5.SequenceEqual(toZipE));
		}

		[TestMethod]
		public void Collection_Zip_UnZip_6Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			var zipped = component.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF);
			var result = component.UnZip(zipped);

			Assert.IsTrue(result.Item1.SequenceEqual(toZipA));
			Assert.IsTrue(result.Item2.SequenceEqual(toZipB));
			Assert.IsTrue(result.Item3.SequenceEqual(toZipC));
			Assert.IsTrue(result.Item4.SequenceEqual(toZipD));
			Assert.IsTrue(result.Item5.SequenceEqual(toZipE));
			Assert.IsTrue(result.Item6.SequenceEqual(toZipF));
		}

		[TestMethod]
		public void Collection_Zip_UnZip_7Arguments()
		{
			int[] toZipA = { 1, 2, 3, 4, 5, 6 };
			int[] toZipB = { 2, 3, 4, 5, 6, 7 };
			int[] toZipC = { 3, 4, 5, 6, 7, 8 };
			int[] toZipD = { 4, 5, 6, 7, 8, 9 };
			int[] toZipE = { 5, 6, 7, 8, 9, 10 };
			int[] toZipF = { 6, 7, 8, 9, 10, 11 };
			int[] toZipG = { 7, 8, 9, 10, 11, 12 };
			var zipped = component.Zip(toZipA, toZipB, toZipC, toZipD, toZipE, toZipF, toZipG);
			var result = component.UnZip(zipped);

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
