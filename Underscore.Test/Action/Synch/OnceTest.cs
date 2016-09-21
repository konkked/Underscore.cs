using System;
using ApplyComponent = Underscore.Action.ApplyComponent;
using NUnit.Framework;

namespace Underscore.Test.Action.Synch
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
		public void Action_Synch_Once_NoArguments()
		{
			var result = 0;
			var onced = _.Action.Once(() => result++);
			for (var i = 0; i < 10; i++)
				onced();

			Assert.AreEqual(1, result);
		}

		[Test]
		public void Action_Synch_Once_1Argument()
		{
			string result = "";

			var oncing = new Action<string>((a) =>
			{
				result += string.Join("", a);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("a", result);
		}

		[Test]
		public void Action_Synch_Once_2Arguments()
		{
			string result = "";

			var oncing = new Action<string, string>((a, b) =>
			{
				result += string.Join("", a, b);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("ab", result);
		}

		[Test]
		public void Action_Synch_Once_3Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string>((a, b, c) =>
			{
				result += string.Join("", a, b, c);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abc", result);
		}

		[Test]
		public void Action_Synch_Once_4Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string>((a, b, c, d) =>
			{
				result += string.Join("", a, b, c, d);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcd", result);
		}

		[Test]
		public void Action_Synch_Once_5Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
			{
				result += string.Join("", a, b, c, d, e);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcde", result);
		}

		[Test]
		public void Action_Synch_Once_6Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				result += string.Join("", a, b, c, d, e, f);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdef", result);
		}

		[Test]
		public void Action_Synch_Once_7Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				result += string.Join("", a, b, c, d, e, f, g);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefg", result);
		}

		[Test]
		public void Action_Synch_Once_8Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefgh", result);
		}

		[Test]
		public void Action_Synch_Once_9Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghi", result);
		}

		[Test]
		public void Action_Synch_Once_10Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghij", result);
		}

		[Test]
		public void Action_Synch_Once_11Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijk", result);
		}

		[Test]
		public void Action_Synch_Once_12Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijkl", result);
		}

		[Test]
		public void Action_Synch_Once_13Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklm", result);
		}

		[Test]
		public void Action_Synch_Once_14Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmn", result);
		}

		[Test]
		public void Action_Synch_Once_15Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmno", result);
		}

		[Test]
		public void Action_Synch_Once_16Arguments()
		{
			string result = "";

			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			});

			var onced = _.Action.Once(oncing);

			for (var i = 0; i < 100; i++)
				apply.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmnop", result);
		}
	}	
}
