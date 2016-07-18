using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class DelayTest
	{
		private ComposeComponent compose;
		private ISynchComponent component;

		private readonly string[] arguments = Util.LowercaseCharArray;

		private void TestDelay(int waitTime, Task delayed)
		{
			var timer = new Stopwatch();
			timer.Start();
			Thread.MemoryBarrier();
			delayed.Wait();
			Thread.MemoryBarrier();
			timer.Stop();
			Assert.IsTrue(timer.ElapsedMilliseconds >= waitTime - 25);
		}

		[TestInitialize]
		public void Initialize()
		{
			compose = new ComposeComponent();
			component = new SynchComponent();
		}

		public void Action_Synch_Delay_NoArguments()
		{
			var invoked = false;
			var timer = new Stopwatch();
			var delayed = component.Delay(() => invoked = true, 100);
			var taskResult = delayed();

			Thread.MemoryBarrier();

			Assert.IsFalse(invoked);

			taskResult.Wait();

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_1Argument()
		{
			var invoked = false;

			var delaying = new Action<string>((a) =>
			{
				Assert.AreEqual("a", a);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			Thread.MemoryBarrier();

			Assert.IsFalse(invoked);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_2Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string>((a, b) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_3Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string>((a, b, c) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_4Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string>((a, b, c, d) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_5Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string>((a, b, c, d, e) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_6Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_7Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_8Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_9Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_10Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_11Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_12Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				Assert.AreEqual("l", l);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_13Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				Assert.AreEqual("l", l);
				Assert.AreEqual("m", m);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_14Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				Assert.AreEqual("l", l);
				Assert.AreEqual("m", m);
				Assert.AreEqual("n", n);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_15Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				Assert.AreEqual("l", l);
				Assert.AreEqual("m", m);
				Assert.AreEqual("n", n);
				Assert.AreEqual("o", o);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[TestMethod]
		public void Action_Synch_Delay_16Arguments()
		{
			var invoked = false;

			var delaying = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				Assert.AreEqual("a", a);
				Assert.AreEqual("b", b);
				Assert.AreEqual("c", c);
				Assert.AreEqual("d", d);
				Assert.AreEqual("e", e);
				Assert.AreEqual("f", f);
				Assert.AreEqual("g", g);
				Assert.AreEqual("h", h);
				Assert.AreEqual("i", i);
				Assert.AreEqual("j", j);
				Assert.AreEqual("k", k);
				Assert.AreEqual("l", l);
				Assert.AreEqual("m", m);
				Assert.AreEqual("n", n);
				Assert.AreEqual("o", o);
				Assert.AreEqual("p", p);
				invoked = true;
			});

			var delayed = component.Delay(delaying, 100);

			TestDelay(100, compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}
	}
}
