using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function
{
    [TestClass]
    public class BindTest
    {
	    private BindComponent component;

	    private static string Join(params object[] args)
	    {
		    return string.Join(" ", args);
	    }

	    [TestInitialize]
	    public void Initialize()
	    {
		    component = new BindComponent();
	    }

	    [TestMethod]
	    public void Function_Bind_1Argument()
	    {
		    const string expected = "a";
		    Func<string, string> function = (a) => Join(a);
		    
			var bound = component.Bind(function, "a");
		    var result = bound();

			Assert.AreEqual(expected, result);
	    }

		[TestMethod]
		public void Function_Bind_2Argument()
		{
			const string expected = "a b";
			Func<string, string, string> function = (a, b) => Join(a, b);

			var bound = component.Bind(function, "a", "b");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_3Argument()
		{
			const string expected = "a b c";
			Func<string, string, string, string> function = (a, b, c) => Join(a, b, c);

			var bound = component.Bind(function, "a", "b", "c");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_4Argument()
		{
			const string expected = "a b c d";
			Func<string, string, string, string, string> function = (a, b, c, d) => Join(a, b, c, d);

			var bound = component.Bind(function, "a", "b", "c", "d");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_5Argument()
		{
			const string expected = "a b c d e";
			Func<string, string, string, string, string, string> function = (a, b, c, d, e) => Join(a, b, c, d, e);

			var bound = component.Bind(function, "a", "b", "c", "d", "e");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_6Argument()
		{
			const string expected = "a b c d e f";
			Func<string, string, string, string, string, string, string> function = (a, b, c, d, e, f) => Join(a, b, c, d, e, f);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_7Argument()
		{
			const string expected = "a b c d e f g";
			Func<string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g) => Join(a, b, c, d, e, f, g);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_8Argument()
		{
			const string expected = "a b c d e f g h";
			Func<string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h) => Join(a, b, c, d, e, f, g, h);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_9Argument()
		{
			const string expected = "a b c d e f g h i";
			Func<string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i) => Join(a, b, c, d, e, f, g, h, i);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_10Argument()
		{
			const string expected = "a b c d e f g h i j";
			Func<string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j) => Join(a, b, c, d, e, f, g, h, i, j);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_11Argument()
		{
			const string expected = "a b c d e f g h i j k";
			Func<string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k) => Join(a, b, c, d, e, f, g, h, i, j, k);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_12Argument()
		{
			const string expected = "a b c d e f g h i j k l";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l) => Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_13Argument()
		{
			const string expected = "a b c d e f g h i j k l m";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_14Argument()
		{
			const string expected = "a b c d e f g h i j k l m n";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_15Argument()
		{
			const string expected = "a b c d e f g h i j k l m n o";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o");
			var result = bound();

			Assert.AreEqual(expected, result);
		}

		[TestMethod]
		public void Function_Bind_16Argument()
		{
			const string expected = "a b c d e f g h i j k l m n o p";
			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> function = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var bound = component.Bind(function, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p");
			var result = bound();

			Assert.AreEqual(expected, result);
		}
    }
}
