using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;

namespace Underscore.Test.Action.Split
{
	[TestClass]
	public class CurryTest
	{
		private static
			Action
				<string, string, string, string, string, string, string, string, string, string, string, string, string,
					string, string, string> CreateSplitterTest(bool[] reference,
						string a, string b, string c, string d, string e, string f, string g, string h, string i,
						string j, string k, string l, string m, string n, string o, string p)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o, _p) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p },
					new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o, _p });

				reference[0] = true;
			};
		}

		private static
			Action
				<string, string, string, string, string, string, string, string, string, string, string, string, string,
					string, string> CreateSplitterTest(bool[] reference,
						string a, string b, string c, string d, string e, string f, string g, string h, string i,
						string j, string k, string l, string m, string n, string o)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o) =>
			{

				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k, l, m, n, _o },
					new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n, _o });

				reference[0] = true;
			};
		}


		private static
			Action
				<string, string, string, string, string, string, string, string, string, string, string, string, string,
					string> CreateSplitterTest(bool[] reference,
						string a, string b, string c, string d, string e, string f, string g, string h, string i,
						string j, string k, string l, string m, string n)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k, l, m, n },
					new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m, _n });

				reference[0] = true;
			};
		}


		private static
			Action
				<string, string, string, string, string, string, string, string, string, string, string, string, string>
			CreateSplitterTest(bool[] reference,
				string a, string b, string c, string d, string e, string f, string g, string h, string i, string j,
				string k, string l, string m)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k, l, m },
					new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l, _m });

				reference[0] = true;
			};
		}

		private static
			Action<string, string, string, string, string, string, string, string, string, string, string, string>
			CreateSplitterTest(bool[] reference,
				string a, string b, string c, string d, string e, string f, string g, string h, string i, string j,
				string k, string l)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k, l },
					new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k, _l });

				reference[0] = true;
			};
		}

		private static Action<string, string, string, string, string, string, string, string, string, string, string>
			CreateSplitterTest(bool[] reference,
				string a, string b, string c, string d, string e, string f, string g, string h, string i, string j,
				string k)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j, k }, new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j, _k });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string, string, string, string, string, string, string>
			CreateSplitterTest(bool[] reference,
				string a, string b, string c, string d, string e, string f, string g, string h, string i, string j)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i, _j) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i, j }, new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i, _j });


				reference[0] = true;
			};
		}

		private static Action<string, string, string, string, string, string, string, string, string> CreateSplitterTest
			(bool[] reference,
				string a, string b, string c, string d, string e, string f, string g, string h, string i)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h, _i) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h, i }, new[] { _a, _b, _c, _d, _e, _f, _g, _h, _i });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string, string, string, string, string> CreateSplitterTest(
			bool[] reference,
			string a, string b, string c, string d, string e, string f, string g, string h)
		{
			return (_a, _b, _c, _d, _e, _f, _g, _h) =>
			{
				Util.Compare.All(new[] { a, b, c, d, e, f, g, h }, new[] { _a, _b, _c, _d, _e, _f, _g, _h });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string, string, string, string> CreateSplitterTest(
			bool[] reference,
			string a, string b, string c, string d, string e, string f, string g)
		{
			return (_a, _b, _c, _d, _e, _f, _g) =>
			{

				Util.Compare.All(new[] { a, b, c, d, e, f, g }, new[] { _a, _b, _c, _d, _e, _f, _g });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string, string, string> CreateSplitterTest(bool[] reference,
			string a, string b, string c, string d, string e, string f)
		{
			return (_a, _b, _c, _d, _e, _f) =>
			{

				Util.Compare.All(new[] { a, b, c, d, e, f }, new[] { _a, _b, _c, _d, _e, _f });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string, string> CreateSplitterTest(bool[] reference,
			string a, string b, string c, string d, string e)
		{
			return (_a, _b, _c, _d, _e) =>
			{

				Util.Compare.All(new[] { a, b, c, d, e }, new[] { _a, _b, _c, _d, _e });

				reference[0] = true;
			};
		}


		private static Action<string, string, string, string> CreateSplitterTest(bool[] reference,
			string a, string b, string c, string d)
		{
			return (_a, _b, _c, _d) =>
			{

				Util.Compare.All(new[] { a, b, c, d }, new[] { _a, _b, _c, _d });

				reference[0] = true;
			};
		}


		private static Action<string, string, string> CreateSplitterTest(bool[] reference, string a, string b, string c)
		{
			return (_a, _b, _c) =>
			{

				Util.Compare.All(new[] { a, b, c }, new[] { _a, _b, _c });


				reference[0] = true;
			};
		}



		private static Action<string, string> CreateSplitterTest(bool[] reference, string a, string b)
		{
			return (_a, _b) =>
			{

				Util.Compare.All(new[] { a, b }, new[] { _a, _b });


				reference[0] = true;
			};
		}


		//TODO: make some tests for uncurry

		[TestMethod]
		public async Task ActionCurry1()
		{
			var splitter = new SplitComponent();

			await Util.Tasks.Start(() =>
			{

				var reference = new[] { false };

				var result = splitter.Curry(
					CreateSplitterTest(
						reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p")
					);

				result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o")("p");
				Assert.IsTrue(reference[0]);
			});
		}

		[TestMethod]
		public void ActionCurry2()
		{

			var splitter = new SplitComponent();

			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n")("o");
			Assert.IsTrue(reference[0]);
		}


		[TestMethod]
		public void ActionCurry3()
		{
			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry4()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry5()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry6()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry7()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry8()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry9()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g")
				);

			result("a")("b")("c")("d")("e")("f")("g");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry10()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f")
				);

			result("a")("b")("c")("d")("e")("f");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry11()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e")
				);

			result("a")("b")("c")("d")("e");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry12()
		{
			var splitter = new SplitComponent();

			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d")
				);

			result("a")("b")("c")("d");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry13()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c")
				);

			result("a")("b")("c");
			Assert.IsTrue(reference[0]);
		}

		[TestMethod]
		public void ActionCurry14()
		{

			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b")
				);

			result("a")("b");
			Assert.IsTrue(reference[0]);
		}


		[TestMethod]
		public void ActionCurry15()
		{
			var splitter = new SplitComponent();
			var reference = new[] { false };

			var result = splitter.Curry(
				CreateSplitterTest(
					reference, "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n")
				);

			result("a")("b")("c")("d")("e")("f")("g")("h")("i")("j")("k")("l")("m")("n");
			Assert.IsTrue(reference[0]);
		}
	}
}
