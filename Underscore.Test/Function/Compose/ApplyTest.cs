using NUnit.Framework;
using System;
using Underscore.Function;

namespace Underscore.Test.Function
{
	[TestFixture]
	public class ApplyTest
	{
		private ComposeComponent component;
		private string str;

		[SetUp]
		public void Initialize()
		{
			component = new ComposeComponent();
			str = "";
		}

		[Test]
		public void Function_Compose_Apply_1Argument()
		{
			var function = new Func<string, string>((a) => str += a);

			var result = component.Apply(function, new[] { "a" });

			Assert.AreEqual("a", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_2Arguments()
		{
			var function = new Func<string, string, string>((a, b) => str += a + b);

			var result = component.Apply(function, new[] { "a", "b" });

			Assert.AreEqual("ab", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_3Arguments()
		{
			var function = new Func<string, string, string, string>((a, b, c) => str += a + b + c);

			var result = component.Apply(function, new[] { "a", "b", "c" });

			Assert.AreEqual("abc", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_4Arguments()
		{
			var function = new Func<string, string, string, string, string>((a, b, c, d) => str += a + b + c + d);

			var result = component.Apply(function, new[] { "a", "b", "c", "d" });

			Assert.AreEqual("abcd", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_5Arguments()
		{
			var function = new Func<string, string, string, string, string, string>((a, b, c, d, e) => str += a + b + c + d + e);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e" });

			Assert.AreEqual("abcde", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_6Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) => str += a + b + c + d + e + f);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f" });

			Assert.AreEqual("abcdef", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_14Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" });

			Assert.AreEqual("abcdefghijklmn", str);
			Assert.AreEqual(str, result);
		}

		

		[Test]
		public void Function_Compose_Apply_7Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) => str += a + b + c + d + e + f + g);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g" });

			Assert.AreEqual("abcdefg", str);

			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_8Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) => str += a + b + c + d + e + f + g + h);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h" });

			Assert.AreEqual("abcdefgh", str);

			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_9Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) => str += a + b + c + d + e + f + g + h + i);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" });

			Assert.AreEqual("abcdefghi", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_10Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) => str += a + b + c + d + e + f + g + h + i + j);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" });

			Assert.AreEqual("abcdefghij", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_11Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) => str += a + b + c + d + e + f + g + h + i + j + k);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" });

			Assert.AreEqual("abcdefghijk", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_12Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) => str += a + b + c + d + e + f + g + h + i + j + k + l);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" });

			Assert.AreEqual("abcdefghijkl", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_13Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) => str += a + b + c + d + e + f + g + h + i + j + k + l + m);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" });

			Assert.AreEqual("abcdefghijklm", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_15Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" });

			Assert.AreEqual("abcdefghijklmno", str);
			Assert.AreEqual(str, result);
		}

		[Test]
		public void Function_Compose_Apply_16Arguments()
		{
			var function = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p);

			var result = component.Apply(function, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" });

			Assert.AreEqual("abcdefghijklmnop", str);
			Assert.AreEqual(str, result);
		}
	}
}
