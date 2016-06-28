using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class BeforeTest
	{
		private ISynchComponent component;
		private ComposeComponent compose;

        string[] arguments = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };

		[TestInitialize]
		public void Initialize()
		{
			component = new SynchComponent();
			compose = new ComposeComponent();
		}

        [TestMethod]
	    public void Function_Synch_Before_NoArguments()
	    {
            var counter = 0;
            var befored = component.Before(() => (counter++), 2);
            for (var i = 0; i < 2; i++)
                Assert.AreEqual(i, befored());

            for (var i = 0; i < 10; i++)
                Assert.AreEqual(1, befored());
        }

        [TestMethod]
        public void Function_Synch_Before_1Argument()
        {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string>((a) =>
            {
                invoked = true;
                return string.Join("", a, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("a" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("a1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
	    public void Function_Synch_Before_2Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string>((a, b) =>
            {
                invoked = true;
                return string.Join("", a, b, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("ab" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("ab1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_3Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string>((a, b, c) =>
            {
                invoked = true;
                return string.Join("", a, b, c, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abc" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abc1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_4Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string>((a, b, c, d) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcd" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcd1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_5Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcde" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcde1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_6Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdef" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdef1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_7Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefg" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefg1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_Before_8Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefgh" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefgh1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_9Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghi" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghi1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_10Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghij" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghij1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_11Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijk" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijk1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_12Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijkl" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijkl1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_13Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklm" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklm1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_14Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmn" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmn1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_15Arguments()
	    {

            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmno" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmno1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_16Arguments()
	    {
            var invoked = false;

            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter++);
            });

            var befored = component.Before(beforing, 2);

            for (var i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmnop" + i, compose.Apply(befored, arguments));

            for (var i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmnop1", compose.Apply(befored, arguments));

            Assert.IsTrue(invoked);
        }

	}
}
