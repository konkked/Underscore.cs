using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class BeforeTest
	{
		private static ISynchComponent ModifyComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

        private ComposeComponent fn = new ComposeComponent();
	    private ISynchComponent testing = ModifyComponent();
        string[] arguments = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };

        [TestMethod]
	    public void Function_Synch_Before_NoArgs()
	    {
            int counter = 0;
            var befored = testing.Before(() => (counter++), 2);
            for (int i = 0; i < 2; i++)
                Assert.AreEqual(i, befored());

            for (int i = 0; i < 10; i++)
                Assert.AreEqual(1, befored());
        }

        [TestMethod]
        public void Function_Synch_Before_1Arg()
        {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string>((a) =>
            {
                invoked = true;
                return string.Join("", a, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("a" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("a1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

        [TestMethod]
	    public void Function_Synch_Before_2Arg()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string>((a, b) =>
            {
                invoked = true;
                return string.Join("", a, b, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("ab" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("ab1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_3Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string>((a, b, c) =>
            {
                invoked = true;
                return string.Join("", a, b, c, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abc" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abc1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_4Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string>((a, b, c, d) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcd" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcd1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_5Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcde" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcde1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_6Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdef" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdef1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_7Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefg" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefg1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

        


        [TestMethod]
        public void Function_Synch_Before_8Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefgh" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefgh1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_9Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghi" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghi1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_10Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghij" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghij1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_11Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijk" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijk1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_12Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijkl" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijkl1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_13Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklm" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklm1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_14Args()
	    {

            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmn" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmn1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }

	    [TestMethod]
	    public void Function_Synch_Before_15Args()
	    {


            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmno" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmno1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }


	    [TestMethod]
	    public void Function_Synch_Before_16Args()
	    {
            var invoked = false;


            var counter = 0;

            var beforing = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, counter++);
            });

            var befored = testing.Before(beforing, 2);

            for (int i = 0; i < 2; i++)
                Assert.AreEqual("abcdefghijklmnop" + i, fn.Apply(befored, arguments));

            for (int i = 2; i < 4; i++)
                Assert.AreEqual("abcdefghijklmnop1", fn.Apply(befored, arguments));


            Assert.IsTrue(invoked);
        }
        
	}
}
