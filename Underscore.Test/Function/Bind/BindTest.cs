using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function
{
	[TestClass]
	public class BindTest
	{
		private BindComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new BindComponent();
		}

		[TestMethod]
		public void Function_Bind_1Argument()
		{
			const string expected = "a";
			Func<string, string> function = (a) => Util.Join(a);
			
			var bound = component.Bind(function, "a");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_2Argument()
		{
			const string expected = "ab";
			Func<string, string, string> function = (a, b) => Util.Join(a, b);

			var bound = component.Bind(function, "a", "b");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_3Argument()
		{
			const string expected = "abc";
			Func<string, string, string, string> function = (a, b, c) => Util.Join(a, b, c);

			var bound = component.Bind(function, "a", "b", "c");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_4Argument()
		{
			const string expected = "abcd";
			Func<string, string, string, string, string> function = (a, b, c, d) => Util.Join(a, b, c, d);

			var bound = component.Bind(function, "a", "b", "c", "d");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_5Argument()
		{
			const string expected = "abcde";
			Func<string, string, string, string, string, string> function = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var bound = component.Bind(function, "a", "b", "c", "d", "e");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_6Argument()
		{
			const string expected = "abcdef";
			Func<string, string, string, string, string, string, string> function = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_7Argument()
		{
			const string expected = "abcdefg";
			Func<string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_8Argument()
		{
			const string expected = "abcdefgh";
			Func<string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_9Argument()
		{
			const string expected = "abcdefghi";
			Func<string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_10Argument()
		{
			const string expected = "abcdefghij";
			Func<string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_11Argument()
		{
			const string expected = "abcdefghijk";
			Func<string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_12Argument()
		{
			const string expected = "abcdefghijkl";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_13Argument()
		{
			const string expected = "abcdefghijklm";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_14Argument()
		{
			const string expected = "abcdefghijklmn";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_15Argument()
		{
			const string expected = "abcdefghijklmno";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_16Argument()
		{
			const string expected = "abcdefghijklmnop";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p");
			var result = bound();

			Assert.AreEqual(expected, result);
		}
	}
}
