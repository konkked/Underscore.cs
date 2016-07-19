using System;
using NUnit.Framework;
using Underscore.Action;

namespace Underscore.Test.Action.Split
{
	[TestFixture]
	public class CurryTest
	{
		private SplitComponent component;
		private string[] output;

		[SetUp]
		public void Initialize()
		{
			component = new SplitComponent();
			output = new string[1];
		}

		[Test]
		public void Action_Split_Curry_2Arguments()
		{
			const string expected = "ab";
			Action<string, string> action = (a, b) => output[0] = Util.Join(a, b);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_3Arguments()
		{
			const string expected = "abc";
			Action<string, string, string> action = (a, b, c) => output[0] = Util.Join(a, b, c);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_4Arguments()
		{
			const string expected = "abcd";
			Action<string, string, string, string> action = (a, b, c, d) => output[0] = Util.Join(a, b, c, d);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_5Arguments()
		{
			const string expected = "abcde";
			Action<string, string, string, string, string> action = (a, b, c, d, e) => output[0] = Util.Join(a, b, c, d, e);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_6Arguments()
		{
			const string expected = "abcdef";
			Action<string, string, string, string, string, string> action = (a, b, c, d, e, f) => output[0] = Util.Join(a, b, c, d, e, f);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_7Arguments()
		{
			const string expected = "abcdefg";
			Action<string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g) => output[0] = Util.Join(a, b, c, d, e, f, g);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_8Arguments()
		{
			const string expected = "abcdefgh";
			Action<string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h) => output[0] = Util.Join(a, b, c, d, e, f, g, h);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_9Arguments()
		{
			const string expected = "abcdefghi";
			Action<string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_10Arguments()
		{
			const string expected = "abcdefghij";
			Action<string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_11Arguments()
		{
			const string expected = "abcdefghijk";
			Action<string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Action<string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_13Arguments()
		{
			const string expected = "abcdefghijklm";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_15Arguments()
		{
			const string expected = "abcdefghijklmno";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o");

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Split_Curry_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var curriedAction = _.Action.Curry(action);

			curriedAction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o")("p");

			Assert.AreEqual(expected, output[0]);
		}
	}
}
