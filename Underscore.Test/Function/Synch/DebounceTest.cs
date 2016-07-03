using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class DebounceTest
	{
		[TestMethod]
		public async Task Function_Synch_Debounce_NoArguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string>(() =>
			{
				count++;
				var returning = count.ToString();
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task<string>>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				continuing.Add(target());
			}

			foreach (var i in continuing)
				Assert.AreEqual("2", await i);

			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);

			continuing.Clear();
			timer.Reset();
			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(2, count);
				continuing.Add(target());
			}

			foreach (var t in continuing)
				Assert.AreEqual("3", await t);

			timer.Stop();

			Assert.AreEqual(3, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting, "Waiting({0}) was less then expected ({1})", timer.ElapsedMilliseconds, waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_1Argument()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string>((a) =>
			{
				Interlocked.Increment(ref count);
				var returning = a;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var calling = i.ToString();
				continuing.Add(target(calling).ContinueWith(a =>
				{
					Assert.AreEqual(2, count);
					Assert.IsTrue(int.Parse(a.Result) > 90);
				}));
			}

			foreach (var i in continuing)
				await i;

			timer.Stop();

			Thread.MemoryBarrier();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_2Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var ir = string.Empty;

			var targeting = new Func<string, string, string>((a, b) =>
			{
				count++;
				var returning = string.Join(" ", a, b, count.ToString());
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task<string>>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString()));
			}

			foreach (var i in continuing)
			{
				var a = await i;
				Assert.AreEqual(2, count);
				Assert.AreEqual("99 -99 2", a);
			}
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_3Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string>((a, b, c) =>
			{
				var returning = string.Join(" ", a, b, c, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, count);
					Assert.AreEqual("99 -99 99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_4Arguments()
		{

			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string>((a, b, c, d) =>
			{
				var returning = string.Join(" ", a, b, c, d, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();
			Thread.MemoryBarrier();
			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString(), (-j).ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, count);
					Assert.AreEqual("99 -99 99 -99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Thread.MemoryBarrier();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting, "Not {0} >= {1}", timer.ElapsedMilliseconds, waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_5Arguments()
		{

			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString(), (-j).ToString(), j.ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, count);
					Assert.AreEqual("99 -99 99 -99 99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_6Arguments()
		{

			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var j = i;
				continuing.Add(
					target(
						(j).ToString(),
						(-j).ToString(),
						(j).ToString(),
						(-j).ToString(),
						(j).ToString(),
						(-j).ToString()
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_7Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_8Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_9Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_10Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_11Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_12Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_13Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_14Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_15Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_16Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			var waiting = 25;

			var count = 1;

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, count.ToString());
				count++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (var i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, count);
				var pos = i.ToString();
				var neg = (-i).ToString();
				continuing.Add(
					target(
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg,
						pos,
						neg
				   ).ContinueWith(a =>
				   {
					   Assert.AreEqual(2, count);
					   Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, count);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}
	}
}
