using System;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function
{
	[TestFixture]
	public class SplitTest
	{
		private SplitComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new SplitComponent();
		}

		[Test]
		public void Func_Split_Split_2Arguments()
		{
			const string expected = "ab";
			Func<string, string, string> function = (a, b) => Util.Join(a, b);

			var result = component.Split(function)("a")("b");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_4Arguments()
		{
			const string expected = "abcd";
			Func<string, string, string, string, string> function = (a, b, c, d) => Util.Join(a, b, c, d);

			var result = component.Split(function)("a", "b")("c", "d");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_6Arguments()
		{
			const string expected = "abcdef";
			Func<string, string, string, string, string, string, string> function = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var result = component.Split(function)("a", "b", "c")("d", "e", "f");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_8Arguments()
		{
			const string expected = "abcdefgh";
			Func<string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var result = component.Split(function)("a", "b", "c", "d")("e", "f", "g", "h");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_10Arguments()
		{
			const string expected = "abcdefghij";
			Func<string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var result = component.Split(function)("a", "b", "c", "d", "e")("f", "g", "h", "i", "j");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f")("g", "h", "i", "j", "k", "l");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f", "g")("h", "i", "j", "k", "l", "m", "n");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Split_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f", "g", "h")("i", "j", "k", "l", "m", "n", "o", "p");

			Assert.AreEqual(expected, result);
		}
	}
}
