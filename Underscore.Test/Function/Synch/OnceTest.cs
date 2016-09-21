using System;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestFixture]
	public class OnceTest
	{
		private ApplyComponent apply;

		private readonly string[] arguments = Util.LowercaseCharArray;

		[SetUp]
		public void Initialize()
		{
            apply = new ApplyComponent();
		}

		[Test]
		public void Function_Synch_Once_NoArguments()
		{
			string result = "";
			int counter = 0;
			var onced = _.Function.Once(() => result = (counter++).ToString());
			for (int i = 0; i < 10; i++)
				onced();

			Assert.AreEqual("0", result);
		}

		[Test]
		public void Function_Synch_Once_1Argument()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string>((a) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("a1", v);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_2Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string>((a, b) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("ab1", v);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_3Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string>((a, b, c) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abc1", v);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_4Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string>((a, b, c, d) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcd1", v);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_5Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcde1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_6Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdef1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_7Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefg1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_8Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefgh1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_9Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghi1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_10Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghij1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_11Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijk1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_12Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijkl1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_13Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijklm1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_14Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijklmn1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_15Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijklmno1", v);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Once_16Arguments()
		{
			var invoked = false;

			var counter = 0;

			var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				counter++;
				invoked = true;
				return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter);
			});

			var onced = _.Function.Once(oncing);
			string[] result = new string[100];
			for (int i = 0; i < 100; i++)
				result[i] = apply.Apply(onced, arguments);

			foreach (var v in result)
				Assert.AreEqual("abcdefghijklmnop1", v);

			Assert.IsTrue(invoked);
		}
	}
}
