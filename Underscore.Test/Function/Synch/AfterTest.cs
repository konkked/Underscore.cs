using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function.Synch
{
	[TestClass]
	public class AfterTest
	{
        private ISynchComponent component;
        private ComposeComponent compose;

        private string[] arguments = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p" };
        private const int repeatCount = 100000;
        private const int paramValue = 15000;

        private Func<Task<string>[]> mkArr = () => new Task<string>[repeatCount];

        [TestInitialize]
        public void Initialize()
        {
            component = new SynchComponent();
            compose = new ComposeComponent();
        }

        [TestMethod]
        public void Function_Synch_After_NoArguments()
        {
            var expected = new [] { "2", "2", "2", "3", "4", "5", "6", "7", "8", "9" };
            Func<string, string> function = (a) => a;

            var aftered = component.After(function, 3);

            List<Task<string>> tasks = new List<Task<string>>();

            for (int i = 0; i < 10; i++)
                tasks.Add(aftered(i.ToString()));

            foreach (var task in tasks)
                task.Wait();

            var results = new List<string>();

            foreach (var task in tasks)
                results.Add(task.Result);

            for (int i = 0; i < results.Count; i++)
                Assert.AreEqual(expected[i], results[i]);
        }

        [TestMethod]
        public void Function_Synch_After_1Argument()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;

            var aftering = new Func<string, string>((a) =>
            {
                invoked = true;
                return a;
            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(1).Concat(new[] { curr.ToString() }).ToArray());
            }

            for (int i = 0; i < repeatCount; i++)
            {
                arr[i].Wait();
            }

            for (int i = 0; i < paramValue; i++)
            {
                Assert.AreEqual("a", arr[i].Result);
            }

            for (int i = paramValue; i < repeatCount; i++)
            {
                Assert.AreEqual("a", arr[i].Result);
            }

            Assert.IsTrue(invoked);
        }

        [TestMethod]
        public void Function_Synch_After_2Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string>((a, b) =>
            {
                invoked = true;
                return string.Join("", a, b);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(1).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_3Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string>((a, b, c) =>
            {
                invoked = true;
                return string.Join("", a, b, c);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(2).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_4Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string>((a, b, c, d) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(3).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_5Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string>((a, b, c, d, e) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(4).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_6Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string>((a, b, c, d, e, f) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(5).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_7Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(6).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_8Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                Thread.MemoryBarrier();
                arr[i] = compose.Apply(aftered, arguments.Take(7).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_9Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(8).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_10Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                int curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(9).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_11Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(10).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_12Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(11).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_13Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(12).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_14Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(13).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_15Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(14).Concat(new[] { curr.ToString() }).ToArray());
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
        }

        [TestMethod]
        public void Function_Synch_After_16Arguments()
        {
            var invoked = false;
            var arr = mkArr();

            var counter = 0;


            var aftering = new Func<string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string, string>((a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) =>
            {
                invoked = true;
                return string.Join("", a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);

            });

            var aftered = component.After(aftering, paramValue);

            for (int i = 0; i < repeatCount; i++)
            {
                var curr = counter++;
                arr[i] = compose.Apply(aftered, arguments.Take(15).Concat(new[] { curr.ToString() }).ToArray());
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
        }
	}
}
