using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class DelayTest
	{
        private ISynchComponent component;
        private ComposeComponent compose;

        //TODO: make a utility to return this argument list
        private string[] arguments = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };

        //TODO: make a default constructor for this so we don't need a method just to get it
        public ISynchComponent GetComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

        [TestInitialize]
        public void Initialize()
        {
            component = GetComponent();
            compose = new ComposeComponent();
        }

        private void TestDelay(int waitTime, string expecting, Task<string> delayed) 
        {
            var timer = new Stopwatch();
            timer.Start();
            Thread.MemoryBarrier();
            delayed.Wait();
            Thread.MemoryBarrier();
            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= waitTime - 25);
            Assert.AreEqual(expecting, delayed.Result);
        }

        [TestMethod]
        public void Function_Synch_Delay_NoArguments()
        {
            var timer = new Stopwatch();
            var delayed = component.Delay(() => "worked", 100);

            timer.Start();
            Thread.MemoryBarrier();
            var taskResult = delayed();

            Thread.MemoryBarrier();

            taskResult.Wait();
            timer.Stop();

            Thread.MemoryBarrier();
            Assert.AreEqual("worked", taskResult.Result);
            Assert.IsTrue(timer.ElapsedMilliseconds >= 100 - 10, string.Format("Expecting at least {0} got {1}", 100, timer.ElapsedMilliseconds));
        }

        [TestMethod]
        public void Function_Synch_Delay_1Argument()
        {
            var invoked = false;

            var delaying = new Func<string, string>((a) =>
            {
                Assert.AreEqual("a", a);
                invoked = true;
                return string.Join("", a);
            });

            var delayed = component.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "a", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_Delay_2Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string>((a, b) =>
            {
                Assert.AreEqual("a", a);
                Assert.AreEqual("b", b);
                invoked = true;
                return string.Join("", a, b);
            });

            var delayed = component.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "ab", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_Delay_3Arguments()
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

            var delayed = component.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abc", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_Delay_4Arguments()
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

            var delayed = component.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abcd", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_Delay_5Arguments()
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
            var delayed = component.Delay(delaying, 100);

            timer.Start();

            Thread.MemoryBarrier();

            TestDelay(100, "abcde", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
            timer.Stop();
            Thread.MemoryBarrier();
            Assert.IsTrue(timer.ElapsedMilliseconds >= 100, "Not {0} >= {1} ", timer.Elapsed, 100);
        }

        [TestMethod]
        public void Function_Synch_Delay_6Arguments()
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

            var delayed = component.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abcdef", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }
  	}
}
