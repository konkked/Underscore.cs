using System;
using NUnit.Framework;
using Underscore.Function;
using System.Linq;

namespace Underscore.Test.Function{
	// Generated using /codegen/partial_test.py
	[TestFixture]
	public class PartialTest
	{
		private const string Arg1 = "a";
		private const string Arg2 = "b";
		private const string Arg3 = "c";
		private const string Arg4 = "d";
		private const string Arg5 = "e";
		private const string Arg6 = "f";
		private const string Arg7 = "g";
		private const string Arg8 = "h";
		private const string Arg9 = "i";
		private const string Arg10 = "j";
		private const string Arg11 = "k";
		private const string Arg12 = "l";
		private const string Arg13 = "m";
		private const string Arg14 = "n";
		private const string Arg15 = "o";
		private const string Arg16 = "p";

		private BindComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new BindComponent();
		}

		[Test]
		public void Function_Partial_2Arguments1Bound()
		{
			const string expected = "ab";

			Func<string, string, string> toBind = (a, b) => Util.Join(a, b);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_3Arguments1Bound()
		{
			const string expected = "abc";

			Func<string, string, string, string> toBind = (a, b, c) => Util.Join(a, b, c);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_3Arguments2Bound()
		{
			const string expected = "abc";

			Func<string, string, string, string> toBind = (a, b, c) => Util.Join(a, b, c);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_4Arguments1Bound()
		{
			const string expected = "abcd";

			Func<string, string, string, string, string> toBind = (a, b, c, d) => Util.Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_4Arguments2Bound()
		{
			const string expected = "abcd";

			Func<string, string, string, string, string> toBind = (a, b, c, d) => Util.Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_4Arguments3Bound()
		{
			const string expected = "abcd";

			Func<string, string, string, string, string> toBind = (a, b, c, d) => Util.Join(a, b, c, d);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_5Arguments1Bound()
		{
			const string expected = "abcde";

			Func<string, string, string, string, string, string> toBind = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_5Arguments2Bound()
		{
			const string expected = "abcde";

			Func<string, string, string, string, string, string> toBind = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_5Arguments3Bound()
		{
			const string expected = "abcde";

			Func<string, string, string, string, string, string> toBind = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_5Arguments4Bound()
		{
			const string expected = "abcde";

			Func<string, string, string, string, string, string> toBind = (a, b, c, d, e) => Util.Join(a, b, c, d, e);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_6Arguments1Bound()
		{
			const string expected = "abcdef";

			Func<string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_6Arguments2Bound()
		{
			const string expected = "abcdef";

			Func<string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_6Arguments3Bound()
		{
			const string expected = "abcdef";

			Func<string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_6Arguments4Bound()
		{
			const string expected = "abcdef";

			Func<string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_6Arguments5Bound()
		{
			const string expected = "abcdef";

			Func<string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f) => Util.Join(a, b, c, d, e, f);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments1Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments2Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments3Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments4Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments5Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_7Arguments6Bound()
		{
			const string expected = "abcdefg";

			Func<string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g) => Util.Join(a, b, c, d, e, f, g);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments1Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments2Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments3Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments4Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments5Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments6Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_8Arguments7Bound()
		{
			const string expected = "abcdefgh";

			Func<string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h) => Util.Join(a, b, c, d, e, f, g, h);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments1Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments2Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments3Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments4Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments5Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments6Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments7Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_9Arguments8Bound()
		{
			const string expected = "abcdefghi";

			Func<string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i) => Util.Join(a, b, c, d, e, f, g, h, i);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments1Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments2Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments3Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments4Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments5Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments6Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments7Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments8Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_10Arguments9Bound()
		{
			const string expected = "abcdefghij";

			Func<string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j) => Util.Join(a, b, c, d, e, f, g, h, i, j);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments1Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments2Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments3Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments4Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments5Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments6Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments7Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments8Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments9Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_11Arguments10Bound()
		{
			const string expected = "abcdefghijk";

			Func<string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k) => Util.Join(a, b, c, d, e, f, g, h, i, j, k);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments1Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments2Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments3Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments4Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments5Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments6Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments7Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments8Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments9Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments10Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11, Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_12Arguments11Bound()
		{
			const string expected = "abcdefghijkl";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
			var result = binding(Arg12);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments1Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments2Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments3Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments4Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments5Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments6Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments7Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments8Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments9Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments10Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11, Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments11Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
			var result = binding(Arg12, Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_13Arguments12Bound()
		{
			const string expected = "abcdefghijklm";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);
			var result = binding(Arg13);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments1Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments2Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments3Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments4Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments5Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments6Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments7Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments8Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments9Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments10Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11, Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments11Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
			var result = binding(Arg12, Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments12Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);
			var result = binding(Arg13, Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_14Arguments13Bound()
		{
			const string expected = "abcdefghijklmn";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);
			var result = binding(Arg14);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments1Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments2Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments3Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments4Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments5Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments6Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments7Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments8Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments9Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments10Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11, Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments11Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
			var result = binding(Arg12, Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments12Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);
			var result = binding(Arg13, Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments13Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);
			var result = binding(Arg14, Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_15Arguments14Bound()
		{
			const string expected = "abcdefghijklmno";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);
			var result = binding(Arg15);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments1Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1);
			var result = binding(Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments2Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2);
			var result = binding(Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments3Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3);
			var result = binding(Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments4Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4);
			var result = binding(Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments5Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5);
			var result = binding(Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments6Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6);
			var result = binding(Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments7Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7);
			var result = binding(Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments8Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8);
			var result = binding(Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments9Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9);
			var result = binding(Arg10, Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments10Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10);
			var result = binding(Arg11, Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments11Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11);
			var result = binding(Arg12, Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments12Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12);
			var result = binding(Arg13, Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments13Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13);
			var result = binding(Arg14, Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments14Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14);
			var result = binding(Arg15, Arg16);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Function_Partial_16Arguments15Bound()
		{
			const string expected = "abcdefghijklmnop";

			Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> toBind = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

			var binding = component.Partial(toBind, Arg1, Arg2, Arg3, Arg4, Arg5, Arg6, Arg7, Arg8, Arg9, Arg10, Arg11, Arg12, Arg13, Arg14, Arg15);
			var result = binding(Arg16);

			Assert.AreEqual(expected, result);
		}

	}
}