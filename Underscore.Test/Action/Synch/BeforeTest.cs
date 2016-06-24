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
	public class BeforeTest
	{
		public ISynchComponent ManipulateDummy() { return new Underscore.Action.SynchComponent(new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()), new ConvertComponent(), new Underscore.Function.ConvertComponent()); }

	
		[TestMethod]
		public async Task ActionBefore()
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
				var befored = testing.Before(() => result = (counter++).ToString(), 2);
				for (var i = 0; i < 10; i++)
					befored();

				Assert.AreEqual("1", result);

			}, () =>
			{

				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string>((a, b) =>
				{
					counter++;
					result += string.Join("", a, b, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);

				Assert.AreEqual("ab1ab2", result);

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string>((a, b, c) =>
				{
					counter++;
					result += string.Join("", a, b, c, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);


				Assert.AreEqual("abc1abc2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string>((a, b, c, d) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcd1abcd2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string>((a, b, c, d) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);


				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcd1abcd2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcde1abcde2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdef1abcdef2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdefg1abcdefg2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);



				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);


				Assert.AreEqual("abcdefgh1abcdefgh2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);


				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdefghi1abcdefghi2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);


				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdefghij1abcdefghij2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdefghijk1abcdefghijk2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);



				Assert.AreEqual("abcdefghijkl1abcdefghijkl2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);


				Assert.AreEqual("abcdefghijklm1abcdefghijklm2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);


				Assert.AreEqual("abcdefghijklmn1abcdefghijklmn2", result);
				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;


				var counter = 0;
				var result = "";

				var beforing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
				{
					counter++;
					result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter);
					invoked = true;
				});

				var befored = testing.Before(beforing, 2);

				for (var i = 0; i < 4; i++)
					fn.Apply(befored, arguments);




				Assert.AreEqual("abcdefghijklmno1abcdefghijklmno2", result);
				Assert.IsTrue(invoked);
			});



		}
	}
}
