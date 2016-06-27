using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class AfterTest
	{
		public ISynchComponent ModifyComponent() { return new SynchComponent(new CompactComponent(), new Underscore.Utility.CompactComponent(), new Underscore.Utility.MathComponent()); }

		[TestMethod]
		public async Task FunctionAfter()
		{
			//if I didn't use this I would lose my mind
			var testing = ModifyComponent();
			var fn = new ComposeComponent();

			string[] arguments = new[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };


			int repeatCount = 100000;
			int paramValue = 15000;

			Func<Task<string>[]> mkArr = () => new Task<string>[repeatCount];

			await Util.Tasks.Start(() =>
			{

				int counter = 0;
				var timer = new Stopwatch();
				var aftered = testing.After(() => (counter++).ToString(), 3);

				List<Task<string>> results = new List<Task<string>>();

				for (int i = 0; i < 10; i++)
				{
					results.Add(aftered());
				}

				for (int i = 0; i < 3; i++)
				{
					results[i].Wait();
					var rslt = results[i].Result;
					Assert.AreEqual("0", rslt);
				}

				var shouldHave = new HashSet<string>();
				var actualResults = new HashSet<string>();

				foreach (var j in Enumerable.Range(3, 7))
					shouldHave.Add((j - 2).ToString());

				for (int i = 3; i < 10; i++)
				{
					results[i].Wait();
					var rslt = results[i].Result;
					Assert.IsTrue(actualResults.Add((rslt)));
					Assert.IsTrue(shouldHave.Contains(rslt));
				}

				Assert.AreEqual(shouldHave.Count, actualResults.Count);


			}, () =>
			{

				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string>((a, b) =>
				{
					invoked = true;
					return string.Join("", a, b);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(1).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("a" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("a" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string>((a, b, c) =>
				{
					invoked = true;
					return string.Join("", a, b, c);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(2).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("ab" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("ab" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string>((a, b, c, d) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(3).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abc" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abc" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(4).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcd" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcd" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);



			}, () =>
			{

				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(5).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcde" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcde" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(6).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdef" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdef" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					Thread.MemoryBarrier();
					arr[i] = fn.Apply(aftered, arguments.Take(7).Concat(new[] { curr.ToString() }).ToArray());
					Thread.MemoryBarrier();
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefg" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefg" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(8).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefgh" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefgh" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{

				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					int curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(9).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghi" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghi" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(10).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghij" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghij" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);

			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(11).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghijk" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghijk" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);

			}, () =>
			{



				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(12).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghijkl" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghijkl" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{


				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(13).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghijklm" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghijklm" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{



				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(14).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghijklmn" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghijklmn" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			}, () =>
			{



				var invoked = false;
				var arr = mkArr();

				var counter = 0;


				var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
				{
					invoked = true;
					return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

				});

				var aftered = testing.After(aftering, paramValue);

				for (int i = 0; i < repeatCount; i++)
				{
					var curr = counter++;
					arr[i] = fn.Apply(aftered, arguments.Take(15).Concat(new[] { curr.ToString() }).ToArray());
				}

				for (int i = 0; i < repeatCount; i++)
				{
					arr[i].Wait();
				}

				for (int i = 0; i < paramValue; i++)
				{
					Assert.AreEqual("abcdefghijklmno" + (paramValue - 1), arr[i].Result);
				}

				for (int i = paramValue; i < repeatCount; i++)
				{
					Assert.AreEqual("abcdefghijklmno" + i, arr[i].Result);
				}

				Assert.IsTrue(invoked);


			});

		}
	}
}
