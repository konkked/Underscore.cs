using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;

namespace Underscore.Test.Action.Split
{
	[TestClass]
	public class SplitTest
	{
		private SplitComponent component;
		private string[] output;

		[TestInitialize]
		public void Initialize()
		{
			component = new SplitComponent();
			output = new string[1];
		}

		private string Join(params string[] args)
		{
			return args.Aggregate(String.Empty, (total, curr) => total + curr);
		}

		[TestMethod]
		public void Action_Split_Split_2Arguments()
		{
			const string expected = "ab";
			Action<string, string> action = (a, b) => output[0] = Join(a, b);

			component.Split(action)("a")("b");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_4Arguments()
		{
			const string expected = "abcd";
			Action<string, string, string, string> action = (a, b, c, d) => output[0] = Join(a, b, c, d);

			component.Split(action)("a", "b")("c", "d");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_6Arguments()
		{
			const string expected = "abcdef";
			Action<string, string, string, string, string, string> action = (a, b, c, d, e, f) => output[0] = Join(a, b, c, d, e, f);

			component.Split(action)("a", "b", "c")("d", "e", "f");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_8Arguments()
		{
			const string expected = "abcdefgh";
			Action<string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h) => output[0] = Join(a, b, c, d, e, f, g, h);

			component.Split(action)("a", "b", "c", "d")("e", "f", "g", "h");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_10Arguments()
		{
			const string expected = "abcdefghij";
			Action<string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j) => output[0] = Join(a, b, c, d, e, f, g, h, i, j);

			component.Split(action)("a", "b", "c", "d", "e")("f", "g", "h", "i", "j");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Action<string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l) => output[0] = Join(a, b, c, d, e, f, g, h, i, j, k, l);

			component.Split(action)("a", "b", "c", "d", "e", "f")("g", "h", "i", "j", "k", "l");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => output[0] = Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			component.Split(action)("a", "b", "c", "d", "e", "f", "g")("h", "i", "j", "k", "l", "m", "n");

			Assert.AreEqual(expected, output[0]);
		}

		[TestMethod]
		public void Action_Split_Split_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => output[0] = Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			component.Split(action)("a", "b", "c", "d", "e", "f", "g", "h")("i", "j", "k", "l", "m", "n", "o", "p");

			Assert.AreEqual(expected, output[0]);
		}
	}
}
