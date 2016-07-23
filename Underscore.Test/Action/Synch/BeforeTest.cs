using System;
using ComposeComponent = Underscore.Action.ComposeComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;
using NUnit.Framework;

namespace Underscore.Test.Action.Synch
{
	[TestFixture]
	public class BeforeTest
	{
		private readonly string[] arguments = Util.LowercaseCharArray;
		private ComposeComponent funcCompose;
		private ISynchComponent component;

		private int counter;
		private string result;
		private bool invoked;

		[SetUp]
		public void Initialize()
		{
			funcCompose = new ComposeComponent();
			component = new SynchComponent();

			counter = 0;
			result = "";
			invoked = false;
		}

		[Test]
		public void Action_Synch_Before_NoArguments()
		{
			var befored = _.Action.Before(() => result = (counter++).ToString(), 2);
			for (var i = 0; i < 10; i++)
				befored();

			Assert.AreEqual("2", result);
		}

		[Test]
		public void Action_Synch_Before_2Arguments()
		{
			var beforing = new Action<string, string>((a, b) =>
			{
				counter++;
				result += string.Join("", a, b, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("ab1ab2", result);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_3Arguments()
		{
			var beforing = new Action<string, string, string>((a, b, c) =>
			{
				counter++;
				result += string.Join("", a, b, c, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abc1abc2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_4Arguments()
		{
			var beforing = new Action<string, string, string, string>((a, b, c, d) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcd1abcd2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_5Arguments()
		{
			var beforing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcde1abcde2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_6Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdef1abcdef2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_7Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefg1abcdefg2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_8Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefgh1abcdefgh2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_9Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghi1abcdefghi2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_10Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghij1abcdefghij2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_11Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghijk1abcdefghijk2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_12Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);
			
			Assert.AreEqual("abcdefghijkl1abcdefghijkl2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_13Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghijklm1abcdefghijklm2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_14Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghijklmn1abcdefghijklmn2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_15Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghijklmno1abcdefghijklmno2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_Before_16Arguments()
		{
			var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter);
				invoked = true;
			});

			var befored = _.Action.Before(beforing, 2);

			for (var i = 0; i < 4; i++)
				funcCompose.Apply(befored, arguments);

			Assert.AreEqual("abcdefghijklmnop1abcdefghijklmnop2", result);
			Assert.IsTrue(invoked);
		}
	}
}
