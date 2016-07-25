using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using SynchComponent = Underscore.Action.SynchComponent;

namespace Underscore.Test.Action.Synch
{
	[TestFixture]
	public class ThrottleTest
	{
		private static async Task SafeAwait(Task t, int timeout)
		{
			var to = Task.Delay(timeout * 1000);
			while (true)
			{
				if (to.IsCompleted) Assert.Fail("Failed to end in time, deadlock occurred");
				else if (t.IsCompleted) return;

				await Task.Delay(1);
			}
		}

		[Test]
		public async Task Action_Synch_Throttle_NoArguments()
		{
			

			var result = 0;

			var throttling = new System.Action(() => result++);
			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 100);

			Assert.AreEqual(0, result);

			for (var i = 0; i < 100; i++)
				tasks.Push(throttled());

			Assert.AreEqual(1, result);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual(2, result);
		}

		[Test]
		public async Task Action_Synch_Throttle_1Argument()
		{
			

			var results = "";

			var callCount = 0;

			var throttling = new Action<int>((i) =>
			{
				results = (i + 1).ToString();
				callCount++;
			});

			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 20);

			for (var i = 0; i < 100; i++)
				tasks.Push(throttled(i));

			Assert.AreEqual(1, callCount);
			Assert.AreEqual("1", results);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual(2, callCount);
			Assert.AreEqual("100", results);
		}

		[Test]
		public async Task Action_Synch_Throttle_2Arguments()
		{
			
			var failOnSignificantDelay = Task.Delay(1000);

			var results = new string[2];

			var callCount = 0;

			var throttling = new Action<int, int>((i, j) =>
			{
				results[0] = (i).ToString();
				results[1] = (j).ToString();
				callCount++;
			});
			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 100);


			var firstResult = throttled(1, -1);
			await firstResult;

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual(1, callCount);


			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i));

			while (tasks.Count != 0)
				await tasks.Pop();

			Thread.MemoryBarrier();
			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual(2, callCount);

			for (var j = 0; j < 10; j++)
			{

				firstResult = throttled(1, -1);
				await firstResult;
				Thread.MemoryBarrier();
				Assert.AreEqual("1", results[0]);
				Assert.AreEqual("-1", results[1]);
				Assert.AreEqual(3 + (2 * j), callCount);
				Thread.MemoryBarrier();

				for (var i = 1; i <= 100; i++)
					tasks.Push(throttled(i, -i));

				while (tasks.Count != 0)
					await tasks.Pop();

				Thread.MemoryBarrier();
				Assert.AreEqual("100", results[0]);
				Assert.AreEqual("-100", results[1]);
				Assert.AreEqual(4 + (2 * j), callCount);
				Thread.MemoryBarrier();
			}
		}

		[Test]
		public async Task Action_Synch_Throttle_3Arguments()
		{
			

			var results = new string[3];

			var callCount = 0;

			var throttling = new Action<int, int, int>((i, j, k) =>
			{
				results[0] = (i).ToString();
				results[1] = (j).ToString();
				results[2] = (k).ToString();
				callCount++;
			});
			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 500);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i));

			Thread.MemoryBarrier();

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual(1, callCount);

			Thread.MemoryBarrier();

			while (tasks.Count != 0)
				await tasks.Pop();

			Thread.MemoryBarrier();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual(2, callCount);

			Thread.MemoryBarrier();

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i));

			Thread.MemoryBarrier();

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual(3, callCount);

			while (tasks.Count != 0)
				await tasks.Pop();

			Thread.MemoryBarrier();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual(4, callCount);
		}


		[Test]
		public async Task Action_Synch_Throttle_4Arguments()
		{
			

			var results = new string[4];

			var callCount = 0;

			var throttling = new Action<int, int, int, int>((i, j, k, l) =>
			{
				results[0] = (i).ToString();
				results[1] = (j).ToString();
				results[2] = (k).ToString();
				results[3] = (l).ToString();
				callCount++;
			});
			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 500);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i, -i));

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual("-1", results[3]);
			Assert.AreEqual(1, callCount);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual("-100", results[3]);
			Assert.AreEqual(2, callCount);

			await Task.Delay(1);

			var first = throttled(0, 0, 0, 0);
			await SafeAwait(first, 10);

			Assert.AreEqual("0", results[0]);
			Assert.AreEqual("0", results[1]);
			Assert.AreEqual("0", results[2]);
			Assert.AreEqual("0", results[3]);
			Assert.AreEqual(3, callCount);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i, -i));

			while (tasks.Count != 0)
				await SafeAwait(tasks.Pop(), 10);

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual("-100", results[3]);
			Assert.AreEqual(4, callCount);
		}

		[Test]
		public async Task Action_Synch_Throttle_5Arguments()
		{
			

			var results = new string[5];

			var callCount = 0;

			var throttling = new Action<int, int, int, int, int>((i, j, k, l, m) =>
			{
				results[0] = (i).ToString();
				results[1] = (j).ToString();
				results[2] = (k).ToString();
				results[3] = (l).ToString();
				results[4] = (m).ToString();
				callCount++;
			});

			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 500);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i, -i, i));

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual("-1", results[3]);
			Assert.AreEqual("1", results[4]);
			Assert.AreEqual(1, callCount);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual("-100", results[3]);
			Assert.AreEqual("100", results[4]);
			Assert.AreEqual(2, callCount);
		}

		[Test]
		public async Task Action_Synch_Throttle_6Arguments()
		{
			

			var results = new string[6];

			var callCount = 0;

			var throttling = new Action<int, int, int, int, int, int>((i, j, k, l, m, n) =>
			{
				results[0] = (i).ToString();
				results[1] = (j).ToString();
				results[2] = (k).ToString();
				results[3] = (l).ToString();
				results[4] = (m).ToString();
				results[5] = (n).ToString();
				callCount++;
			});

			var tasks = new Stack<Task>();
			var throttled = _.Action.Throttle(throttling, 500);

			var first = throttled(1, -1, 1, -1, 1, -1);

			Assert.AreEqual(1, callCount);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i, -i, i, -i));

			await first;

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual("-1", results[3]);
			Assert.AreEqual("1", results[4]);
			Assert.AreEqual("-1", results[5]);
			Assert.AreEqual(1, callCount);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual("-100", results[3]);
			Assert.AreEqual("100", results[4]);
			Assert.AreEqual("-100", results[5]);
			Assert.AreEqual(2, callCount);

			first = throttled(1, -1, 1, -1, 1, -1);

			for (var i = 1; i <= 100; i++)
				tasks.Push(throttled(i, -i, i, -i, i, -i));

			await first;

			Assert.AreEqual("1", results[0]);
			Assert.AreEqual("-1", results[1]);
			Assert.AreEqual("1", results[2]);
			Assert.AreEqual("-1", results[3]);
			Assert.AreEqual("1", results[4]);
			Assert.AreEqual("-1", results[5]);
			Assert.AreEqual(3, callCount);

			while (tasks.Count != 0)
				await tasks.Pop();

			Assert.AreEqual("100", results[0]);
			Assert.AreEqual("-100", results[1]);
			Assert.AreEqual("100", results[2]);
			Assert.AreEqual("-100", results[3]);
			Assert.AreEqual("100", results[4]);
			Assert.AreEqual("-100", results[5]);
			Assert.AreEqual(4, callCount);
		}
	}
}
