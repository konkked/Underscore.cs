using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class OnceTest
	{
		public ISynchComponent ModifyComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

		[TestMethod]
		public async Task FunctionOnce()
		{
			//if I didn't use this I would lose my mind
			var fn = new ComposeComponent();
			var testing = ModifyComponent();


			string[] arguments = "abcdefghijklmnopqrstuvwxyz".Select(a => a.ToString()).ToArray();

			await Util.Tasks.Start(() =>
			{

				string result = "";
				int counter = 0;
				var timer = new Stopwatch();
				var onced = testing.Once(() => result = (counter++).ToString());
				for (int i = 0; i < 10; i++)
					onced();

				Assert.AreEqual("0", result);

			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string>((a) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("a1", v);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string>((a, b) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("ab1", v);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string>((a, b, c) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abc1", v);
				Assert.IsTrue(invoked);



			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string>((a, b, c, d) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcd1", v);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcde1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdef1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefg1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefgh1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefgh1", v);

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghi1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghij1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghijk1", v);

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghijkl1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghijklm1", v);

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghijklmn1", v);

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;

				var counter = 0;

				var oncing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
				{
					counter++;
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
				});

				var onced = testing.Once(oncing);
				string[] result = new string[100];
				for (int i = 0; i < 100; i++)
					result[i] = fn.Apply(onced, arguments);

				foreach (var v in result)
					Assert.AreEqual("abcdefghijklmno1", v);

				Assert.IsTrue(invoked);


			});
		}
	}
}
