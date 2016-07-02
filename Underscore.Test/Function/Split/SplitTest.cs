using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function
{
	[TestClass]
	public class SplitTest
	{
		private SplitComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new SplitComponent();
		}

		private string Join(params string[] args)
		{
			return args.Aggregate(String.Empty, (total, curr) => total + curr);
		}

		[TestMethod]
		public void Func_Split_Split_2Arguments()
		{
			const string expected = "ab";
			Func<string, string, string> function = (a, b) => Join(a, b);

			var result = component.Split(function)("a")("b");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_4Arguments()
		{
			const string expected = "abcd";
			Func<string, string, string, string, string> function = (a, b, c, d) => Join(a, b, c, d);

			var result = component.Split(function)("a", "b")("c", "d");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_6Arguments()
		{
			const string expected = "abcdef";
			Func<string, string, string, string, string, string, string> function = (a, b, c, d, e, f) => Join(a, b, c, d, e, f);

			var result = component.Split(function)("a", "b", "c")("d", "e", "f");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_8Arguments()
		{
			const string expected = "abcdefgh";
			Func<string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h) => Join(a, b, c, d, e, f, g, h);

			var result = component.Split(function)("a", "b", "c", "d")("e", "f", "g", "h");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_10Arguments()
		{
			const string expected = "abcdefghij";
			Func<string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j) => Join(a, b, c, d, e, f, g, h, i, j);

			var result = component.Split(function)("a", "b", "c", "d", "e")("f", "g", "h", "i", "j");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l) => Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f")("g", "h", "i", "j", "k", "l");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f", "g")("h", "i", "j", "k", "l", "m", "n");

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Func_Split_Split_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var result = component.Split(function)("a", "b", "c", "d", "e", "f", "g", "h")("i", "j", "k", "l", "m", "n", "o", "p");

			Assert.AreEqual(expected, result);
		}
	}
}
