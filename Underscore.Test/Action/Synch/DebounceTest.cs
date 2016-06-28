using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SynchComponent = Underscore.Action.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class DebounceTest
	{
        [TestMethod]
		public async Task Action_Synch_Debounce_NoArguments()
		{
			var testing = new SynchComponent();
			var flag = false;

			var callcount = 0;

			var debounced =
				testing.Debounce(() =>
				{
					flag = true;
					callcount++;
				}, 15);

			var tasksRunning = new List<Task>();

			Assert.IsFalse(flag);
			Assert.AreEqual(0, callcount);

			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced());
            
			Assert.AreEqual(0, callcount);
			Assert.IsFalse(flag);

			foreach (var v in tasksRunning)
				await v;

			Assert.AreEqual(1, callcount);
			Assert.IsTrue(flag);

			flag = false;

			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced());

			Assert.AreEqual(1, callcount);
			Assert.IsFalse(flag);

			foreach (var v in tasksRunning)
				await v;

			Assert.AreEqual(2, callcount);
			Assert.IsTrue(flag);
		}

		[TestMethod]
		public async Task Action_Synch_Debounce_1Argument()
		{
			var testing = new SynchComponent();
			string result = null;
			var callCount = 0;

			var debounced = testing.Debounce(new Action<string>((i) =>
			{
				result = i;
				callCount++;
			}), 50);

			var tasksRunning = new List<Task>();

			for (var i = 0; i < 100; i++)
                tasksRunning.Add(debounced(i.ToString()));

			foreach (var task in tasksRunning)
				await task;

			Assert.AreEqual("99", result);
			Assert.AreEqual(1, callCount);
		}


		[TestMethod]
		public async Task Action_Synch_Debounce_2Arguments()
		{
			var testing = new SynchComponent();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();

			var result = new[] { "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string>((i, j) =>
			{
				flag = true;
				//should still only be the last called item
				result[0] += i;
				result[1] += j;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();
            
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg));
            }

            Assert.IsFalse(flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			foreach (var task in tasksRunning)
				await task;

			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);
			Assert.AreEqual("99", result[0]);
			Assert.AreEqual("-99", result[1]);
			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b");
			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

			Assert.AreEqual("99a", result[0]);
			Assert.AreEqual("-99b", result[1]);
			Assert.AreEqual(2, countCalling);
		}

		[TestMethod]
		public async Task Action_Synch_Debounce_3Arguments()
		{
			var testing = new SynchComponent();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();

			var result = new[] { "", "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string, string>((i, j, k) =>
			{
				flag = true;
				//should still only be the last called item
				result[0] += i;
				result[1] += j;
				result[2] += k;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();
            
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos));
            }

            Assert.IsFalse(flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);
			Assert.AreEqual("99", result[0]);
			Assert.AreEqual("-99", result[1]);
			Assert.AreEqual("99", result[2]);
			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c");
			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

			Assert.AreEqual("99a", result[0]);
			Assert.AreEqual("-99b", result[1]);
			Assert.AreEqual("99c", result[2]);
			Assert.AreEqual(2, countCalling);
		}


		[TestMethod]
		public async Task Action_Synch_Debounce_4Arguments()
		{
			var testing = new SynchComponent();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();


			var result = new[] { "", "", "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string, string, string>((i, j, k, l) =>
			{
				flag = true;
				//should still only be the last called item
				result[0] += i;
				result[1] += j;
				result[2] += k;
				result[3] += l;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();
            
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
			foreach (var t in result)
				Assert.AreEqual("", t);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);

			Assert.AreEqual("99", result[0]);
			Assert.AreEqual("-99", result[1]);
			Assert.AreEqual("99", result[2]);
			Assert.AreEqual("-99", result[3]);

			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c", "d");

			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual(2, countCalling);
		}


		[TestMethod]
		public async Task Action_Synch_Debounce_5Arguments()
		{
			var testing = new SynchComponent();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();

			var result = new[] { "", "", "", "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string, string, string, string>((i, j, k, l, m) =>
			{
				flag = true;
				//should still only be the last called item
				result[0] += i;
				result[1] += j;
				result[2] += k;
				result[3] += l;
				result[4] += m;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();
            
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
			foreach (String s in result)
				Assert.AreEqual("", s);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);

			Assert.AreEqual("99", result[0]);
			Assert.AreEqual("-99", result[1]);
			Assert.AreEqual("99", result[2]);
			Assert.AreEqual("-99", result[3]);
			Assert.AreEqual("99", result[4]);

			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c", "d", "e");
			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual(2, countCalling);
		}

		[TestMethod]
		public async Task Action_Synch_Debounce_6Arguments()
		{
			var testing = new SynchComponent();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();

			var result = new[] { "", "", "", "", "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string, string, string, string, string>((i, j, k, l, m, n) =>
			{
				flag = true;
				//should still only be the last called item
				result[0] += i;
				result[1] += j;
				result[2] += k;
				result[3] += l;
				result[4] += m;
				result[5] += n;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();
            
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);

			Assert.AreEqual("99", result[0]);
			Assert.AreEqual("-99", result[1]);
			Assert.AreEqual("99", result[2]);
			Assert.AreEqual("-99", result[3]);
			Assert.AreEqual("99", result[4]);
			Assert.AreEqual("-99", result[5]);

			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c", "d", "e", "f");
			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

			Assert.AreEqual("99a", result[0]);
			Assert.AreEqual("-99b", result[1]);
			Assert.AreEqual("99c", result[2]);
			Assert.AreEqual("-99d", result[3]);
			Assert.AreEqual("99e", result[4]);
			Assert.AreEqual("-99f", result[5]);
			Assert.AreEqual(2, countCalling);
		}

        [TestMethod]
        public async Task Action_Synch_Debounce_7Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();
           
            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_8Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_9Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_10Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_11Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_12Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                result[11] += l;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);
            Assert.AreEqual("-99", result[11]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual("-99l", result[11]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_13Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                result[11] += l;
                result[12] += m;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);
            Assert.AreEqual("-99", result[11]);
            Assert.AreEqual("99", result[12]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual("-99l", result[11]);
            Assert.AreEqual("99m", result[12]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_14Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                result[11] += l;
                result[12] += m;
                result[13] += n;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);
            Assert.AreEqual("-99", result[11]);
            Assert.AreEqual("99", result[12]);
            Assert.AreEqual("-99", result[13]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual("-99l", result[11]);
            Assert.AreEqual("99m", result[12]);
            Assert.AreEqual("-99n", result[13]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_15Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                result[11] += l;
                result[12] += m;
                result[13] += n;
                result[14] += o;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);
            Assert.AreEqual("-99", result[11]);
            Assert.AreEqual("99", result[12]);
            Assert.AreEqual("-99", result[13]);
            Assert.AreEqual("99", result[14]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual("-99l", result[11]);
            Assert.AreEqual("99m", result[12]);
            Assert.AreEqual("-99n", result[13]);
            Assert.AreEqual("99o", result[14]);
            Assert.AreEqual(2, countCalling);
        }

        [TestMethod]
        public async Task Action_Synch_Debounce_16Arguments()
        {
            var testing = new SynchComponent();
            var flag = false;
            const int waitingFor = 50;
            var timer = new Stopwatch();

            var result = new[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            var countCalling = 0;
            var debouncing = new Action<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
            {
                flag = true;
                // should still only be the last called item
                result[0] += a;
                result[1] += b;
                result[2] += c;
                result[3] += d;
                result[4] += e;
                result[5] += f;
                result[6] += g;
                result[7] += h;
                result[8] += i;
                result[9] += j;
                result[10] += k;
                result[11] += l;
                result[12] += m;
                result[13] += n;
                result[14] += o;
                result[15] += p;
                countCalling++;
            });

            var debounced =
                testing.Debounce(debouncing, waitingFor);

            var tasksRunning = new List<Task>();

            Assert.IsFalse(flag);
            Assert.AreEqual(false, flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            timer.Start();
            for (var i = 0; i < 100; i++)
            {
                var pos = i.ToString();
                var neg = (-i).ToString();
                tasksRunning.Add(debounced(pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg, pos, neg));
            }

            Assert.IsFalse(flag);
            foreach (var s in result)
                Assert.AreEqual("", s);

            foreach (var task in tasksRunning)
                await task;
            timer.Stop();

            Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
            Assert.IsTrue(flag);

            Assert.AreEqual("99", result[0]);
            Assert.AreEqual("-99", result[1]);
            Assert.AreEqual("99", result[2]);
            Assert.AreEqual("-99", result[3]);
            Assert.AreEqual("99", result[4]);
            Assert.AreEqual("-99", result[5]);
            Assert.AreEqual("99", result[6]);
            Assert.AreEqual("-99", result[7]);
            Assert.AreEqual("99", result[8]);
            Assert.AreEqual("-99", result[9]);
            Assert.AreEqual("99", result[10]);
            Assert.AreEqual("-99", result[11]);
            Assert.AreEqual("99", result[12]);
            Assert.AreEqual("-99", result[13]);
            Assert.AreEqual("99", result[14]);
            Assert.AreEqual("-99", result[15]);

            Assert.AreEqual(1, countCalling);

            var secondCallResult = debounced("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p");
            Assert.AreEqual(1, countCalling);

            //after wait period time has expired 
            Assert.AreNotSame(tasksRunning[0], secondCallResult);

            await secondCallResult;

            Assert.AreEqual("99a", result[0]);
            Assert.AreEqual("-99b", result[1]);
            Assert.AreEqual("99c", result[2]);
            Assert.AreEqual("-99d", result[3]);
            Assert.AreEqual("99e", result[4]);
            Assert.AreEqual("-99f", result[5]);
            Assert.AreEqual("99g", result[6]);
            Assert.AreEqual("-99h", result[7]);
            Assert.AreEqual("99i", result[8]);
            Assert.AreEqual("-99j", result[9]);
            Assert.AreEqual("99k", result[10]);
            Assert.AreEqual("-99l", result[11]);
            Assert.AreEqual("99m", result[12]);
            Assert.AreEqual("-99n", result[13]);
            Assert.AreEqual("99o", result[14]);
            Assert.AreEqual("-99p", result[15]);
            Assert.AreEqual(2, countCalling);
        }
    }
}
