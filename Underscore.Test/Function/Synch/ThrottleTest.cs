﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class ThrottleTest
	{
        //TODO: finish all the overloads for this class

        [TestMethod]
        public async Task Function_Synch_Throttle_1Argument()
        {
            var testing = new SynchComponent();
            var timer = new Stopwatch();
            const int waiting = 1000;

            int cnt = 1;

            var targeting = new Func<string, string>((i) =>
            {
                Interlocked.Increment(ref cnt);
                return i + i;
            });

            var target = testing.Throttle(targeting, waiting);

            var continuing = new List<Task<string>>();

            timer.Start();

            var first = target("0");
            var firstResult = await first;

            Thread.MemoryBarrier();

            Assert.AreEqual(2, cnt);
            Assert.AreEqual("00", firstResult);


            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(2, cnt);

                continuing.Add(target((i + 1).ToString()));
            }

            foreach (var i in continuing)
            {
                var result = await i;
                Assert.AreEqual("100100", result);
            }

            timer.Stop();
            Thread.MemoryBarrier();
            Assert.AreEqual(3, cnt);

            Assert.IsTrue(Math.Abs(timer.ElapsedMilliseconds - waiting) < 20, "Elapsed time ({0}) differs too largely from designated waiting time ({1})", timer.ElapsedMilliseconds, waiting);
            Thread.MemoryBarrier();

            continuing.Clear();
            timer.Reset();
            timer.Start();

            await Task.Delay(2);

            Thread.MemoryBarrier();

            first = target("101");
            firstResult = await first;
            Assert.AreEqual(4, cnt);
            Assert.AreEqual("101101", firstResult);


            for (int i = 0; i < 100; i++)
            {
                Assert.AreEqual(4, cnt);
                continuing.Add(target((101 + i).ToString()));
            }
            foreach (var t in continuing)
            {
                var result = await t;
                Assert.AreEqual("200200", result);
            }

            timer.Stop();
            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);


            Assert.AreEqual(5, cnt);
        }

        [TestMethod]
        public async Task Function_Synch_Throttle_6Arguments()
        {
            var testing = new SynchComponent();
            var timer = new Stopwatch();
            int waiting = 25;

            int cnt = 0;

            timer.Start();

            var targeting = new Func<string, string, string, string, string, string, string>((s1, s2, s3, s4, s5, s6) =>
            {
                cnt++;
                var returning = string.Join(" ", s1, s2, s3, s4, s5, s6);
                return returning;
            });

            var target = testing.Throttle(targeting, waiting);

            var continuing = new List<Task>();


            for (int i = 0; i < 99; i++)
            {
                Assert.AreEqual(i == 0 ? 0 : 1, cnt);

                var j = i + 1;


                if (i == 0)
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                           ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1", a.Result))
                       );
                }
                else
                {
                    continuing.Add(
                        target(
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString(),
                            (j).ToString(),
                            (-j).ToString()
                           )
                            .ContinueWith(
                                a => Assert.AreEqual("99 -99 99 -99 99 -99", a.Result))
                       );
                }
            }

            Assert.AreEqual(1, cnt);


            for (int i = 0; i < 99; i++)
                await continuing[i];

            timer.Stop();

            Assert.AreEqual(2, cnt);

            Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
        }
	}
}
