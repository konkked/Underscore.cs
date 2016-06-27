using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class DelayTest
	{
		public ISynchComponent ModifyComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

		[TestMethod]
		public async Task FunctionDelay()
		{
			//if I didn't use this I would lose my mind
			var fn = new ComposeComponent();
			var testing = ModifyComponent();

			string[] arguments = new[] { "a", "b", "c", "d", "e", "f" };


			Action<int, string, Task<string>> TestDelay = (waitTime, expecting, delayed) =>
			{
				var timer = new Stopwatch();
				timer.Start();
				Thread.MemoryBarrier();
				delayed.Wait();
				Thread.MemoryBarrier();
				timer.Stop();
				Assert.IsTrue(timer.ElapsedMilliseconds >= waitTime - 25);
				Assert.AreEqual(expecting, delayed.Result);
			};


			await Util.Tasks.Start(() =>
			{
				var timer = new Stopwatch();
				var delayed = testing.Delay(() => "worked", 100);

				timer.Start();
				Thread.MemoryBarrier();
				var taskResult = delayed();

				Thread.MemoryBarrier();

				taskResult.Wait();
				timer.Stop();

				Thread.MemoryBarrier();
				Assert.AreEqual("worked", taskResult.Result);
				Assert.IsTrue(timer.ElapsedMilliseconds >= 100 - 10, string.Format("Expecting at least {0} got {1}", 100, timer.ElapsedMilliseconds));

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string>((a) =>
				{
					Assert.AreEqual("a", a);
					invoked = true;
					return string.Join("", a);
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, "a", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string, string>((a, b) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					invoked = true;
					return string.Join("", a, b);
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, "ab", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string, string, string>((a, b, c) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					Assert.AreEqual("c", c);
					invoked = true;
					return "abc";
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, "abc", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string, string, string, string>((a, b, c, d) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					Assert.AreEqual("c", c);
					Assert.AreEqual("d", d);
					invoked = true;
					return "abcd";
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, "abcd", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					Assert.AreEqual("c", c);
					Assert.AreEqual("d", d);
					Assert.AreEqual("e", e);
					invoked = true;
					return "abcde";
				});

				var timer = new Stopwatch();
				var delayed = testing.Delay(delaying, 100);

				timer.Start();

				Thread.MemoryBarrier();

				TestDelay(100, "abcde", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);
				timer.Stop();
				Thread.MemoryBarrier();
				Assert.IsTrue(timer.ElapsedMilliseconds >= 100, "Not {0} >= {1} ", timer.Elapsed, 100);

			}, () =>
			{

				var invoked = false;

				var delaying = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					Assert.AreEqual("c", c);
					Assert.AreEqual("d", d);
					Assert.AreEqual("e", e);
					Assert.AreEqual("f", f);
					invoked = true;
					return "abcdef";
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, "abcdef", fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			});
		}
	}
}
