using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Action;

namespace Underscore.Test.Action
{
    [TestFixture]
    public class BindTest
    {
	    private BindComponent component;
		private string[] output;
	    private string expected;

	    [SetUp]
	    public void Initialize()
	    {
		    component = new BindComponent();
		    output = new[] { "" };
	    }

		[Test]
		public void Action_Bind_OneParameter()
		{
			expected = "a";
			Action<string> action = (a) => output[0] = Util.Join(a);

			var bound = component.Bind(action, "a");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_2Parameters()
		{
			expected = "ab";
			Action<string, string> action = (a, b) =>
			{
				output[0] = Util.Join(a, b);
			};

			var bound = component.Bind(action, "a", "b");

			bound();

			Assert.AreEqual(expected, output[0]);
        }

		[Test]
        public void Action_Bind_3Parameters()
        {
			expected = "abc";
			Action<string, string, string> action = (a, b, c) =>
			{
				output[0] = Util.Join(a, b, c);
			};

			var bound = component.Bind(action, "a", "b", "c");

			bound();

			Assert.AreEqual(expected, output[0]);
        }

        [Test]
        public void Action_Bind_4Parameters()
        {
			expected = "abcd";
			Action<string, string, string, string> action = (a, b, c, d) =>
			{
				output[0] = Util.Join(a, b, c, d);
			};

			var bound = component.Bind(action, "a", "b", "c", "d");

			bound();

			Assert.AreEqual(expected, output[0]);
        }

		[Test]
		public void Action_Bind_5Parameters()
		{
			expected = "abcde";
			Action<string, string, string, string, string> action = (a, b, c, d, e) =>
			{
				output[0] = Util.Join(a, b, c, d, e);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_6Parameters()
		{
			expected = "abcdef";
			Action<string, string, string, string, string, string> action = (a, b, c, d, e, f) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_7Parameters()
		{
			expected = "abcdefg";
			Action<string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_8Parameters()
		{
			expected = "abcdefgh";
			Action<string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_9Parameters()
		{
			expected = "abcdefghi";
			Action<string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_10Parameters()
		{
			expected = "abcdefghij";
			Action<string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_11Parameters()
		{
			expected = "abcdefghijk";
			Action<string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_12Parameters()
		{
			expected = "abcdefghijkl";
			Action<string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_13Parameters()
		{
			expected = "abcdefghijklm";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_14Parameters()
		{
			expected = "abcdefghijklmn";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_15Parameters()
		{
			expected = "abcdefghijklmno";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o");

			bound();

			Assert.AreEqual(expected, output[0]);
		}

		[Test]
		public void Action_Bind_16Parameters()
		{
			expected = "abcdefghijklmnop";
			Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string> action = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				output[0] = Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			};

			var bound = component.Bind(action, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p");

			bound();

			Assert.AreEqual(expected, output[0]);
		}
    }
}
