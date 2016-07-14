using NUnit.Framework;
using System;
using Underscore.Action;

namespace Underscore.Test.Action
{
    [TestFixture]
    public class ApplyTest
    {
        private ComposeComponent component;
        private string str;

        [SetUp]
        public void Initialize()
        {
            component = new ComposeComponent();
            str = "";
        }

        [Test]
        public void Action_Compose_Apply_1Argument()
        {
            var act = new Action<string>((a) => str += a);

            component.Apply(act, new[] { "a" });

            Assert.AreEqual("a", str);

        }

        [Test]
        public void Action_Compose_Apply_2Arguments()
        {
            var act = new Action<string, string>((a, b) => str += a + b);

            component.Apply(act, new[] { "a", "b" });

            Assert.AreEqual("ab", str);
        }

        [Test]
        public void Action_Compose_Apply_3Arguments()
        {
            var act = new Action<string, string, string>((a, b, c) => str += a + b + c);

            component.Apply(act, new[] { "a", "b", "c" });

            Assert.AreEqual("abc", str);
        }

        [Test]
        public void Action_Compose_Apply_4Arguments()
        {
            var act = new Action<string, string, string, string>((a, b, c, d) => str += a + b + c + d);

            component.Apply(act, new[] { "a", "b", "c", "d" });

            Assert.AreEqual("abcd", str);
        }

        [Test]
        public void Action_Compose_Apply_5Arguments()
        {
            var act = new Action<string, string, string, string, string>((a, b, c, d, e) => str += a + b + c + d + e);

            component.Apply(act, new[] { "a", "b", "c", "d", "e" });

            Assert.AreEqual("abcde", str);
        }

        [Test]
        public void Action_Compose_Apply_6Arguments()
        {
            var act = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) => str += a + b + c + d + e + f);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f" });

            Assert.AreEqual("abcdef", str);
        }

        [Test]
        public void Action_Compose_Apply_7Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) => str += a + b + c + d + e + f + g);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g" });

            Assert.AreEqual("abcdefg", str);
        }

        [Test]
        public void Action_Compose_Apply_8Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) => str += a + b + c + d + e + f + g + h);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h" });

            Assert.AreEqual("abcdefgh", str);
        }

        [Test]
        public void Action_Compose_Apply_9Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) => str += a + b + c + d + e + f + g + h + i);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i" });

            Assert.AreEqual("abcdefghi", str);
        }

        [Test]
        public void Action_Compose_Apply_10Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) => str += a + b + c + d + e + f + g + h + i + j);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j" });

            Assert.AreEqual("abcdefghij", str);
        }

        [Test]
        public void Action_Compose_Apply_11Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) => str += a + b + c + d + e + f + g + h + i + j + k);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k" });

            Assert.AreEqual("abcdefghijk", str);
        }

        [Test]
        public void Action_Compose_Apply_12Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) => str += a + b + c + d + e + f + g + h + i + j + k + l);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l" });

            Assert.AreEqual("abcdefghijkl", str);
        }

        [Test]
        public void Action_Compose_Apply_13Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) => str += a + b + c + d + e + f + g + h + i + j + k + l + m);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m" });

            Assert.AreEqual("abcdefghijklm", str);
        }

        [Test]
        public void Action_Compose_Apply_14Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n" });

            Assert.AreEqual("abcdefghijklmn", str);
        }

        [Test]
        public void Action_Compose_Apply_15Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o" });

            Assert.AreEqual("abcdefghijklmno", str);
        }

        [Test]
        public void Action_Compose_Apply_16Arguments()
        {
            var act = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => str += a + b + c + d + e + f + g + h + i + j + k + l + m + n + o + p);

            component.Apply(act, new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" });

            Assert.AreEqual("abcdefghijklmnop", str);
        }
    }
}
