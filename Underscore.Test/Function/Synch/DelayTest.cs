using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestFixture]
	public class DelayTest
	{
        private ISynchComponent component;
        private ComposeComponent compose;

        private readonly string[] arguments = Util.LowercaseCharArray;

        [SetUp]
        public void Initialize()
        {
            component = new SynchComponent();
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

        [Test]
        public void Function_Synch_Delay_NoArguments()
        {
            var timer = new Stopwatch();
            var delayed = _.Function.Delay(() => "worked", 100);

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

        [Test]
        public void Function_Synch_Delay_1Argument()
        {
            var invoked = false;

            var delaying = new Func<string, string>((a) =>
            {
                invoked = true;
                return Util.Join("", a);
            });

            var delayed = _.Function.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "a", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [Test]
        public void Function_Synch_Delay_2Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string>((a, b) =>
            {
                invoked = true;
				return Util.Join(a, b);
            });

            var delayed = _.Function.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "ab", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [Test]
        public void Function_Synch_Delay_3Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string, string>((a, b, c) =>
            {
                invoked = true;
				return Util.Join(a, b, c);
            });

            var delayed = _.Function.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abc", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [Test]
        public void Function_Synch_Delay_4Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string, string, string>((a, b, c, d) =>
            {
                invoked = true;
				return Util.Join(a, b, c, d);
            });

            var delayed = _.Function.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abcd", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

        [Test]
        public void Function_Synch_Delay_5Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
            {
                invoked = true;
                return Util.Join(a, b, c, d, e);
            });

            var timer = new Stopwatch();
            var delayed = _.Function.Delay(delaying, 100);

            timer.Start();

            Thread.MemoryBarrier();

            TestDelay(100, "abcde", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
            timer.Stop();
            Thread.MemoryBarrier();
            Assert.IsTrue(timer.ElapsedMilliseconds >= 100, "Not {0} >= {1} ", timer.Elapsed, 100);
        }

        [Test]
        public void Function_Synch_Delay_6Arguments()
        {
            var invoked = false;

            var delaying = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
            {
                invoked = true;
				return Util.Join(a, b, c, d, e, f);
            });

            var delayed = _.Function.Delay(delaying, 100);

            Thread.MemoryBarrier();

            TestDelay(100, "abcdef", compose.Apply(delayed, arguments));

            Assert.IsTrue(invoked);
        }

		[Test]
		public void Function_Synch_Delay_7Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefg", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_8Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefgh", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_9Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghi", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_10Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghij", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_11Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijk", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_12Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijkl", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_13Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijklm", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_14Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijklmn", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_15Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijklmno", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}

		[Test]
		public void Function_Synch_Delay_16Arguments()
		{
			var invoked = false;

			var delaying = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				invoked = true;
				return Util.Join(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
			});

			var delayed = _.Function.Delay(delaying, 100);

			Thread.MemoryBarrier();

			TestDelay(100, "abcdefghijklmnop", compose.Apply(delayed, arguments));

			Assert.IsTrue(invoked);
		}
  	}
}
