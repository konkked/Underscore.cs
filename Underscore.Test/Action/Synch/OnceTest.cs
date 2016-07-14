using System;
using System.Linq;
using ComposeComponent = Underscore.Action.ComposeComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;
using NUnit.Framework;

namespace Underscore.Test.Action.Synch
{
	[TestFixture]
	public class OnceTest
	{
        private ComposeComponent compose;
        private ISynchComponent component;

        [SetUp]
        public void Initialize()
        {
            compose = new ComposeComponent();
            component = new SynchComponent();
        }

        [Test]
        public void Action_Synch_Once_NoArguments()
        {
            var result = 0;
            var onced = component.Once(() => result++);
            for (var i = 0; i < 10; i++)
                onced();

            Assert.AreEqual(1, result);
        }

        [Test]
        public void Action_Synch_Once_1Argument()
        {
	        string result = "";

	        var arguments = Util.LowercaseCharArray.Take(1).ToArray();

            var oncing = new Action<string>((a) =>
            {
                result += string.Join("", a);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("a", result);
        }

        [Test]
        public void Action_Synch_Once_2Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(2).ToArray();

            var oncing = new Action<string, string>((a, b) =>
            {
                result += string.Join("", a, b);
            });

            var onced = component.Once(oncing);
			
            for (var i = 0; i < 100; i++)
				compose.Apply(onced, arguments);

            Assert.AreEqual("ab", result);
        }

        [Test]
        public void Action_Synch_Once_3Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(3).ToArray();

            var oncing = new Action<string, string, string>((a, b, c) =>
            {
                result += string.Join("", a, b, c);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abc", result);
        }

        [Test]
        public void Action_Synch_Once_4Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(4).ToArray();

            var oncing = new Action<string, string, string, string>((a, b, c, d) =>
            {
                result += string.Join("", a, b, c, d);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcd", result);
        }

        [Test]
        public void Action_Synch_Once_5Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(5).ToArray();

            var oncing = new Action<string, string, string, string, string>((a, b, c, d, e) =>
            {
                result += string.Join("", a, b, c, d, e);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcde", result);
        }

        [Test]
        public void Action_Synch_Once_6Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(6).ToArray();

            var oncing = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
            {
                result += string.Join("", a, b, c, d, e, f);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdef", result);
        }

        [Test]
        public void Action_Synch_Once_7Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(7).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
            {
                result += string.Join("", a, b, c, d, e, f, g);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefg", result);
        }

        [Test]
        public void Action_Synch_Once_8Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(8).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefgh", result);
        }

        [Test]
        public void Action_Synch_Once_9Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(9).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghi", result);
        }

        [Test]
        public void Action_Synch_Once_10Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(10).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghij", result);
        }

        [Test]
        public void Action_Synch_Once_11Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(11).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j, k);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghijk", result);
        }

        [Test]
        public void Action_Synch_Once_12Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(12).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghijkl", result);
        }

        [Test]
        public void Action_Synch_Once_13Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(13).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghijklm", result);
        }

        [Test]
        public void Action_Synch_Once_14Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(14).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghijklmn", result);
        }

        [Test]
        public void Action_Synch_Once_15Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(15).ToArray();

            var oncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
            {
                result += string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
            });

            var onced = component.Once(oncing);

            for (var i = 0; i < 100; i++)
                compose.Apply(onced, arguments);

            Assert.AreEqual("abcdefghijklmno", result);
        }

        [Test]
        public void Action_Synch_Once_16Arguments()
		{
			string result = "";

			var arguments = Util.LowercaseCharArray.Take(16).ToArray();

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
