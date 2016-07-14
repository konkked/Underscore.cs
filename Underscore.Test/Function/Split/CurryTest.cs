using System;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Split
{
	[TestFixture]
	public class CurryTest
	{
		private SplitComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new SplitComponent();
		}

		[Test]
		public void Func_Split_Curry_2Arguments()
		{
			const string expected = "ab";
			Func<string, string, string> function = (a, b) => Util.Join(a, b);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_3Arguments()
		{
			const string expected = "abc";
			Func<string, string, string, string> function = (a, b, c) => Util.Join(a, b, c);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_4Arguments()
		{
			const string expected = "abcd";
			Func<string, string, string, string, string> function = (a, b, c, d) => Util.Join(a, b, c, d);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_5Arguments()
		{
			const string expected = "abcde";
			Func<string, string, string, string, string, string> function = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_6Arguments()
		{
			const string expected = "abcdef";
			Func<string, string, string, string, string, string, string> function = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_7Arguments()
		{
			const string expected = "abcdefg";
			Func<string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_8Arguments()
		{
			const string expected = "abcdefgh";
			Func<string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_9Arguments()
		{
			const string expected = "abcdefghi";
			Func<string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_10Arguments()
		{
			const string expected = "abcdefghij";
			Func<string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_11Arguments()
		{
			const string expected = "abcdefghijk";
			Func<string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_13Arguments()
		{
			const string expected = "abcdefghijklm";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_15Arguments()
		{
			const string expected = "abcdefghijklmno";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Curry_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var curriedFunction = component.Curry(function);

			var result = curriedFunction("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o")("p");

			Assert.AreEqual(expected, result);
		}
	}
}
