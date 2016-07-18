using System;
using ComposeComponent = Underscore.Action.ComposeComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class OnceTest
	{
		private ComposeComponent compose;
		private ISynchComponent component;

		private readonly string[] arguments = Util.LowercaseCharArray;

		private string result = "";

		[TestInitialize]
		public void Initialize()
		{
			compose = new ComposeComponent();
			component = new SynchComponent();
		}

		[TestMethod]
		public void Action_Synch_Once_NoArguments()
		{
			var result = 0;
			var onced = component.Once(() => result++);
			for (var i = 0; i < 10; i++)
				onced();

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void Action_Synch_Once_1Argument()
		{
			var oncing = new Action<string>((a) =>
			{
				result += string.Join("", a);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("a", result);
		}

		[TestMethod]
		public void Action_Synch_Once_2Arguments()
		{
			var oncing = new Action<string, string>((a, b) =>
			{
				result += string.Join("", a, b);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("ab", result);
		}

		[TestMethod]
		public void Action_Synch_Once_3Arguments()
		{
			var oncing = new Action<string, string, string>((a, b, c) =>
			{
				result += string.Join("", a, b, c);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abc", result);
		}

		[TestMethod]
		public void Action_Synch_Once_4Arguments()
		{
			var oncing = new Action<string, string, string, string>((a, b, c, d) =>
			{
				result += string.Join("", a, b, c, d);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcd", result);
		}

		[TestMethod]
		public void Action_Synch_Once_5Arguments()
		{
			var oncing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
			{
				result += string.Join("", a, b, c, d, e);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcde", result);
		}

		[TestMethod]
		public void Action_Synch_Once_6Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				result += string.Join("", a, b, c, d, e, f);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdef", result);
		}

		[TestMethod]
		public void Action_Synch_Once_7Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				result += string.Join("", a, b, c, d, e, f, g);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefg", result);
		}

		[TestMethod]
		public void Action_Synch_Once_8Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefgh", result);
		}

		[TestMethod]
		public void Action_Synch_Once_9Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghi", result);
		}

		[TestMethod]
		public void Action_Synch_Once_10Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghij", result);
		}

		[TestMethod]
		public void Action_Synch_Once_11Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijk", result);
		}

		[TestMethod]
		public void Action_Synch_Once_12Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijkl", result);
		}

		[TestMethod]
		public void Action_Synch_Once_13Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklm", result);
		}

		[TestMethod]
		public void Action_Synch_Once_14Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmn", result);
		}

		[TestMethod]
		public void Action_Synch_Once_15Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmno", result);
		}

		[TestMethod]
		public void Action_Synch_Once_16Arguments()
		{
			var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			});

			var onced = component.Once(oncing);

			for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

			Assert.AreEqual("abcdefghijklmnop", result);
		}
	}
}
