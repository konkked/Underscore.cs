using System;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Split
{
	[TestFixture]
	public class UncurryTest
	{
		private SplitComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new SplitComponent();
		}

		[Test]
		public void Func_Split_Uncurry_2Arguments()
		{
			const string expected = "ab";
			Func<string, string, string> action = (a, b) => Util.Join(a, b);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_3Arguments()
		{
			const string expected = "abc";
			Func<string, string, string, string> action = (a, b, c) => Util.Join(a, b, c);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_4Arguments()
		{
			const string expected = "abcd";
			Func<string, string, string, string, string> action = (a, b, c, d) => Util.Join(a, b, c, d);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_5Arguments()
		{
			const string expected = "abcde";
			Func<string, string, string, string, string, string> action = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_6Arguments()
		{
			const string expected = "abcdef";
			Func<string, string, string, string, string, string, string> action = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_7Arguments()
		{
			const string expected = "abcdefg";
			Func<string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_8Arguments()
		{
			const string expected = "abcdefgh";
			Func<string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_9Arguments()
		{
			const string expected = "abcdefghi";
			Func<string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_10Arguments()
		{
			const string expected = "abcdefghij";
			Func<string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_11Arguments()
		{
			const string expected = "abcdefghijk";
			Func<string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_12Arguments()
		{
			const string expected = "abcdefghijkl";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_13Arguments()
		{
			const string expected = "abcdefghijklm";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_14Arguments()
		{
			const string expected = "abcdefghijklmn";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_15Arguments()
		{
			const string expected = "abcdefghijklmno";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o");

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Func_Split_Uncurry_16Arguments()
		{
			const string expected = "abcdefghijklmnop";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var curriedFunction = _.Function.Curry(action);

			var uncurriedFunction = _.Function.Uncurry(curriedFunction);
			var result = uncurriedFunction("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p");

			Assert.AreEqual(expected, result);
		}
	}
}
