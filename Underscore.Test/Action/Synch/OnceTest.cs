using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using ConvertComponent = Underscore.Action.ConvertComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Function.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class OnceTest
	{
		public ISynchComponent ManipulateDummy() { return new Underscore.Action.SynchComponent(new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()), new ConvertComponent(), new Underscore.Function.ConvertComponent()); }

		[TestMethod]
		public async Task ActionOnce()
		{
			//if I didn't use this I would lose my mind
			var fn = new Underscore.Action.ComposeComponent();
			var testing = ManipulateDummy();

			string[] arguments = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };

			await Util.Tasks.Start(() =>
			{

				var result = "";
				var counter = 0;
				var timer = new Stopwatch();
				var onced = testing.Once(() => result = (counter++).ToString());
				for (var i = 0; i < 10; i++)
					onced();

				Assert.AreEqual("0", result);

			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string>((a, b) =>
				{
					counter++;
					result = string.Join("", a, b, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("ab1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string>((a, b, c) =>
				{
					counter++;
					result = string.Join("", a, b, c, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abc1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string>((a, b, c, d) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcd1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string>((a, b, c, d) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcd1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcde1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdef1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefg1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefgh1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghi1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghij1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghijk1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghijkl1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghijklm1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghijklmn1", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;
				var result = "";

				var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
				{
					counter++;
					result = string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
					invoked = true;
				});

				var onced = testing.Once(oncing);

				for (var i = 0; i < 100; i++)
					fn.Apply(onced, arguments);

				Assert.AreEqual("abcdefghijklmno1", result);
				Assert.IsTrue(invoked);


			});



		}
	}
}
