using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using ConvertComponent = Underscore.Action.ConvertComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Action.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class DelayTest
	{
        private ComposeComponent compose;
        private ISynchComponent component;

		public ISynchComponent GetSynchComponent() {
            return new SynchComponent(
                new Underscore.Function.SynchComponent(
                    new CompactComponent(), 
                    new Underscore.Utility.CompactComponent(), 
                    new Underscore.Utility.MathComponent()
                    ), 
                new ConvertComponent(), 
                new Underscore.Function.ConvertComponent()
                );
        }

		[TestMethod]
		public async Task ActionDelay()
		{
			var fn = new ComposeComponent();
			var testing = GetSynchComponent();

			string[] arguments = { "a", "b", "c", "d", "e", "f" };


			Action<int, Task> TestDelay = (waitTime, delayed) =>
			{
				var timer = new Stopwatch();
				timer.Start();
				Thread.MemoryBarrier();
				delayed.Wait();
				Thread.MemoryBarrier();
				timer.Stop();
				Assert.IsTrue(timer.ElapsedMilliseconds >= waitTime - 25);
			};


			await Util.Tasks.Start(() =>
			{

				var result = "";
				var timer = new Stopwatch();
				var delayed = testing.Delay(() => result = "worked", 100);
				var taskResult = delayed();

				Thread.MemoryBarrier();

				Assert.AreEqual("", result);

				taskResult.Wait();

				Assert.AreEqual("worked", result);


			}, () =>
			{

				var invoked = false;

				var delaying = new Action<string, string>((a, b) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					invoked = true;
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
			{

				var invoked = false;

				var delaying = new Action<string, string, string>((a, b, c) =>
				{
					Assert.AreEqual("a", a);
					Assert.AreEqual("b", b);
					Assert.AreEqual("c", c);
					invoked = true;
				});

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
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

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			}, () =>
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

				var timer = new Stopwatch();
				var delayed = testing.Delay(delaying, 100);

				timer.Start();

				Thread.MemoryBarrier();

				var task = fn.Apply(delayed, arguments);

				Thread.MemoryBarrier();

				Assert.IsFalse(invoked);

				task.Wait();

				Thread.MemoryBarrier();

				Assert.IsTrue(invoked);
				timer.Stop();
				Assert.IsTrue(timer.ElapsedMilliseconds >= 100);

			}, () =>
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

				var delayed = testing.Delay(delaying, 100);

				Thread.MemoryBarrier();

				TestDelay(100, fn.Apply(delayed, arguments));

				Assert.IsTrue(invoked);

			});
		}
	}
}
