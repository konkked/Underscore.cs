using System;
using System.Threading.Tasks;
using System.Threading;
using ComposeComponent = Underscore.Function.ComposeComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;
using NUnit.Framework;

namespace Underscore.Test.Action.Synch
{
	[TestFixture]
	public class AfterTest
	{
		private readonly string[] arguments = Util.LowercaseCharArray;
		private ComposeComponent funcCompose;

		private int counter;
		private string result;
		private bool invoked;
		private Task[] arr;
		[SetUp]
		public void Initialize()
		{
			funcCompose = new ComposeComponent();
			
			counter = 0;
			result = "";
			invoked = false;
			arr = new Task[4];
		}

		[Test]
		public void Action_Synch_After_NoArguments()
		{
			const string expected = "aaaaaaa";
			var aftered = _.Action.After(() => result += "a", 3);

			for (var i = 0; i < 10; i++)
				aftered();
			
			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Action_Synch_After_2Arguments()
		{
			var aftering = new Action<string, string>((a, b) =>
			{
				counter++;
				result += string.Join("", a, b, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < arr.Length; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < arr.Length; i++)
				arr[i].Wait();


			Assert.AreEqual("ab1ab2", result);

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_3Arguments()
		{
			var aftering = new Action<string, string, string>((a, b, c) =>
			{
				counter++;
				result += string.Join("", a, b, c, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abc1abc2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_4Arguments()
		{
			var aftering = new Action<string, string, string, string>((a, b, c, d) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcd1abcd2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_5Arguments()
		{
			var aftering = new Action<string, string, string, string, string>((a, b, c, d, e) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcde1abcde2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_6Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);


			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdef1abcdef2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_7Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);


			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefg1abcdefg2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_8Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);


			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefgh1abcdefgh2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_9Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);


			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghi1abcdefghi2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_10Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);


			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghij1abcdefghij2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_11Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijk1abcdefghijk2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_12Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijkl1abcdefghijkl2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_13Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijklm1abcdefghijklm2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_14Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijklmn1abcdefghijklmn2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_15Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijklmno1abcdefghijklmno2", result);
			Assert.IsTrue(invoked);
		}

		[Test]
		public void Action_Synch_After_16Arguments()
		{
			var aftering = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				counter++;
				result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter);
				invoked = true;
			});

			var aftered = _.Action.After(aftering, 3);

			for (var i = 0; i < 4; i++)
				arr[i] = funcCompose.Apply(aftered, arguments);

			for (var i = 0; i < 4; i++)
				arr[i].Wait();

			Assert.AreEqual("abcdefghijklmnop1abcdefghijklmnop2", result);
			Assert.IsTrue(invoked);
		}
	}
}
