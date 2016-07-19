using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestFixture]
	public class ThrottleTest
	{
		[Test]
		public async Task Function_Synch_Throttle_1Argument()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			const int waiting = 25;

			int count = 1;

			var targeting = new Func<string, string>((i) =>
			{
				Interlocked.Increment(ref count);
				return i + i;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task<string>>();

			timer.Start();

			var first = target("0");
			var firstResult = await first;

			Thread.MemoryBarrier();

			Assert.AreEqual(2, count);
			Assert.AreEqual("00", firstResult);


			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(2, count);

				continuing.Add(target((i + 1).ToString()));
			}

			foreach (var i in continuing)
			{
				var result = await i;
				Assert.AreEqual("100100", result);
			}

			timer.Stop();
			Thread.MemoryBarrier();
			Assert.AreEqual(3, count);

			Assert.IsTrue(Math.Abs(timer.ElapsedMilliseconds - waiting) < 20, "Elapsed time ({0}) differs too largely from designated waiting time ({1})", timer.ElapsedMilliseconds, waiting);
			Thread.MemoryBarrier();

			continuing.Clear();
			timer.Reset();
			timer.Start();

			await Task.Delay(2);

			Thread.MemoryBarrier();

			first = target("101");
			firstResult = await first;
			Assert.AreEqual(4, count);
			Assert.AreEqual("101101", firstResult);


			for (int i = 0; i < 100; i++)
			{
				Assert.AreEqual(4, count);
				continuing.Add(target((101 + i).ToString()));
			}
			foreach (var t in continuing)
			{
				var result = await t;
				Assert.AreEqual("200200", result);
			}

			timer.Stop();
			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);


			Assert.AreEqual(5, count);
		}

		[Test]
		public async Task Function_Synch_Throttle_2Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string>((a, b) =>
			{
				count++;
				var returning = string.Join(" ", a, b);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg
						   ).ContinueWith(a => Assert.AreEqual("1 -1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_3Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string>((a, b, c) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_4Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string>((a, b, c, d) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_5Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_6Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos,
							neg
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos,
							neg
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_7Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos,
							neg,
							pos
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
					continuing.Add(
						target(
							pos,
							neg,
							pos,
							neg,
							pos,
							neg,
							pos
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_8Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_9Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_10Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_11Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_12Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_13Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_14Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_15Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);


			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}

		[Test]
		public async Task Function_Synch_Throttle_16Arguments()
		{
			var testing = new SynchComponent();
			var timer = new Stopwatch();
			int waiting = 25;

			int count = 0;

			timer.Start();

			var targeting = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
			{
				count++;
				var returning = string.Join(" ", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
				return returning;
			});

			var target = testing.Throttle(targeting, waiting);

			var continuing = new List<Task>();


			for (int i = 0; i < 99; i++)
			{
				Assert.AreEqual(i == 0 ? 0 : 1, count);

				var j = i + 1;

				var pos = j.ToString();
				var neg = (-j).ToString();

				if (i == 0)
				{
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
						   ).ContinueWith(a => Assert.AreEqual("1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1 -1 1 -1", a.Result))
					   );
				}
				else
				{
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
						   )
							.ContinueWith(
								a => Assert.AreEqual("99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99 99 -99", a.Result))
					   );
				}
			}

			Assert.AreEqual(1, count);

			for (int i = 0; i < 99; i++)
				await continuing[i];

			timer.Stop();

			Assert.AreEqual(2, count);

			Assert.IsTrue(timer.ElapsedMilliseconds >= waiting);
		}
	}
}
