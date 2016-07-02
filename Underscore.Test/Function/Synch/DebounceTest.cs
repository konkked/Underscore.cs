using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
    //TODO: finish all debounce test overloads
	[TestClass]
	public class DebounceTest
	{
		public ISynchComponent ModifyComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

		//TODO: Reimplement Debounce Test
		//Realized that the current implementation is flawed
		//should rewrite and pass parameters instead of depending on an invoked value to be the 

		[TestMethod]
		public async Task Function_Synch_Debounce_NoArguments()
		{
			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 500;

			int cnt = 1;

			var targeting = new Func<string>(() =>
			{
				cnt++;
				var returning = cnt.ToString();
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task<string>>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				continuing.Add(target());
			}

			foreach (var i in continuing)
				Assert.AreEqual("2", await i);

			timer.Stop();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);

			continuing.Clear();
			timer.Reset();
			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(2, cnt);
				continuing.Add(target());
			}

			foreach (var t in continuing)
				Assert.AreEqual("3", await t);

			timer.Stop();

			Assert.AreEqual(3, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting, "Waiting({0}) was less then expected ({1})", timer.ElapsedMilliseconds, waiting);

		}

		[TestMethod]
		public async Task Function_Synch_Debounce_1Argument()
		{
			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int cnt = 1;

			var targeting = new Func<string, string>((a) =>
			{
				Interlocked.Increment(ref cnt);
				var returning = a;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				var calling = i.ToString();
				continuing.Add(target(calling).ContinueWith(a =>
				{
					Assert.AreEqual(2, cnt);
					Assert.IsTrue(int.Parse(a.Result) > 90);
				}));
			}

			foreach (var i in continuing)
				await i;

			timer.Stop();

			Thread.MemoryBarrier();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_2Arguments()
		{
			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 100;

			int cnt = 1;

			var ir = string.Empty;

			var targeting = new Func<string, string, string>((s1, s2) =>
			{
				cnt++;
				var returning = string.Join(" ", s1, s2, cnt.ToString());
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task<string>>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString()));
			}

			foreach (var i in continuing)
			{
				var a = await i;
				Assert.AreEqual(2, cnt);
				Assert.AreEqual("99 -99 2", a);
			}
			timer.Stop();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_3Arguments()
		{

			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 50;

			int cnt = 1;

			var targeting = new Func<string, string, string, string>((s1, s2, s3) =>
			{
				var returning = string.Join(" ", s1, s2, s3, cnt.ToString());
				cnt++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, cnt);
					Assert.AreEqual("99 -99 99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_4Arguments()
		{

			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 200;

			int cnt = 1;

			var targeting = new Func<string, string, string, string, string>((s1, s2, s3, s4) =>
			{
				var returning = string.Join(" ", s1, s2, s3, s4, cnt.ToString());
				cnt++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();
			Thread.MemoryBarrier();
			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString(), (-j).ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, cnt);
					Assert.AreEqual("99 -99 99 -99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Thread.MemoryBarrier();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting, "Not {0} >= {1}", timer.ElapsedMilliseconds, waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_5Arguments()
		{

			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int cnt = 1;

			var targeting = new Func<string, string, string, string, string, string>((s1, s2, s3, s4, s5) =>
			{
				var returning = string.Join(" ", s1, s2, s3, s4, s5, cnt.ToString());
				cnt++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
				var j = i;
				continuing.Add(target(j.ToString(), (-j).ToString(), j.ToString(), (-j).ToString(), j.ToString()).ContinueWith(a =>
				{
					Assert.AreEqual(2, cnt);
					Assert.AreEqual("99 -99 99 -99 99 1", a.Result);
				}));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[TestMethod]
		public async Task Function_Synch_Debounce_6Arguments()
		{

			var testing = ModifyComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int cnt = 1;

			var targeting = new Func<string, string, string, string, string, string, string>((s1, s2, s3, s4, s5, s6) =>
			{
				var returning = string.Join(" ", s1, s2, s3, s4, s5, s6, cnt.ToString());
				cnt++;
				return returning;
			});

			var target = testing.Debounce(targeting, waiting);

			var continuing = new List<Task>();

			timer.Start();

			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(1, cnt);
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
					   Assert.AreEqual(2, cnt);
					   Assert.AreEqual("99 -99 99 -99 99 -99 1", a.Result);
				   }));
			}

			foreach (var i in continuing)
				await i;
			timer.Stop();

			Assert.AreEqual(2, cnt);
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}
	}
}
