using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using ConvertComponent = Underscore.Action.ConvertComponent;
using ISynchComponent = Underscore.Action.ISynchComponent;
using SynchComponent = Underscore.Function.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestClass]
	public class DebounceTest
	{
		public ISynchComponent ManipulateDummy()
		{
			return new Underscore.Action.SynchComponent(
				new SynchComponent(
					new CompactComponent(), 
					new Underscore.Utility.CompactComponent(), 
					new Underscore.Utility.MathComponent()
				), 
				new ConvertComponent(), 
				new Underscore.Function.ConvertComponent()
			);
		}

		[TestMethod]
		public async Task Action_Synch_Debounce_NoArguments()
		{
			var testing = ManipulateDummy();
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

			//crude but simple and with least amount of variables to make mistakes with
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
			var testing = ManipulateDummy();
			string result = null;
			var callCount = 0;

			var target = testing.Debounce(new Action<string>((i) =>
			{
				result = i;
				callCount++;
			}), 50);

			var waitingfor = new List<Task>();

			for (var i = 0; i < 100; i++)
				waitingfor.Add(target(i.ToString()));

			foreach (var v in waitingfor)
				await v;

			Assert.AreEqual("99", result);
			Assert.AreEqual(1, callCount);
		}


		[TestMethod]
		public async Task Action_Synch_Debounce_2Arguments()
		{
			var testing = ManipulateDummy();
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

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced(i.ToString(), (-i).ToString()));

			//crude but simple and with least amount of variables to screw things up
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
			var testing = ManipulateDummy();
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

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced(i.ToString(), (-i).ToString(), i.ToString()));

			//crude but simple and with least amount of variables to screw things up
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
			var testing = ManipulateDummy();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();


			var result = new[] { "", "", "", "" };
			var expected = new[] { "", "", "", "" };
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

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
			for (var i = 0; i < 100; i++)
			{
				expected[0] = expected[2] = i.ToString();
				expected[1] = expected[3] = (-i).ToString();
				tasksRunning.Add(
					debounced(expected[0], expected[1], expected[2], expected[3])
				);
			}
			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			foreach (var t in result)
				Assert.AreEqual("", t);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);

			Assert.AreEqual(expected[0], result[0]);
			Assert.AreEqual(expected[1], result[1]);
			Assert.AreEqual(expected[2], result[2]);
			Assert.AreEqual(expected[3], result[3]);

			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c", "d");

			expected[0] += "a";
			expected[1] += "b";
			expected[2] += "c";
			expected[3] += "d";

			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

			Assert.AreEqual(expected[0], result[0]);
			Assert.AreEqual(expected[1], result[1]);
			Assert.AreEqual(expected[2], result[2]);
			Assert.AreEqual(expected[3], result[3]);
			Assert.AreEqual(2, countCalling);
		}


		[TestMethod]
		public async Task Action_Synch_Debounce_5Arguments()
		{
			var testing = ManipulateDummy();
			var flag = false;
			const int waitingFor = 50;
			var timer = new Stopwatch();


			var result = new[] { "", "", "", "", "" };
			var expected = new[] { "", "", "", "", "" };
			var countCalling = 0;
			var debouncing = new Action<string, string, string, string, string>((i, j, k, l, m) =>
			{
				flag = true;
				//should still only be the last called item
				expected[0] = result[0] += i;
				expected[1] = result[1] += j;
				expected[2] = result[2] += k;
				expected[3] = result[3] += l;
				expected[4] = result[4] += m;
				countCalling++;
			});

			var debounced =
				testing.Debounce(debouncing, waitingFor);

			var tasksRunning = new List<Task>();

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced(i.ToString(), (-i).ToString(), i.ToString(), (-i).ToString(), (i).ToString()));

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			foreach (String s in result)
				Assert.AreEqual("", s);

			foreach (var task in tasksRunning)
				await task;
			timer.Stop();

			Assert.IsTrue(timer.ElapsedMilliseconds >= waitingFor);
			Assert.IsTrue(flag);

			Assert.AreEqual(expected[0], result[0]);
			Assert.AreEqual(expected[1], result[1]);
			Assert.AreEqual(expected[2], result[2]);
			Assert.AreEqual(expected[3], result[3]);
			Assert.AreEqual(expected[4], result[4]);

			Assert.AreEqual(1, countCalling);

			var secondCallResult = debounced("a", "b", "c", "d", "e");
			Assert.AreEqual(1, countCalling);

			//after wait period time has expired 
			Assert.AreNotSame(tasksRunning[0], secondCallResult);

			await secondCallResult;

			Assert.AreEqual(expected[0], result[0]);
			Assert.AreEqual(expected[1], result[1]);
			Assert.AreEqual(expected[2], result[2]);
			Assert.AreEqual(expected[3], result[3]);
			Assert.AreEqual(expected[4], result[4]);
			Assert.AreEqual(2, countCalling);

		}

		[TestMethod]
		public async Task Action_Synch_Debounce_6Arguments()
		{
			var testing = ManipulateDummy();
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

			//crude but simple and with least amount of variables to screw things up
			Assert.IsFalse(flag);
			Assert.AreEqual(false, flag);
			foreach (var s in result)
				Assert.AreEqual("", s);

			timer.Start();
			for (var i = 0; i < 100; i++)
				tasksRunning.Add(debounced(i.ToString(), (-i).ToString(), i.ToString(), (-i).ToString(), (i).ToString(), (-i).ToString()));

			//crude but simple and with least amount of variables to screw things up
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
	}
}
