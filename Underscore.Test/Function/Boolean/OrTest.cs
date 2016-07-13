using System;
using NUnit.Framework;
using System.Collections.Generic;
using Underscore.Function;

namespace Underscore.Test.Boolean
{
	// Generated using /codegen/boolean_or_test.py
	[TestFixture]
	public class OrTest
	{
		private BooleanComponent component;
		private bool[] wasCalled;

		[SetUp]
		public void Initialize()
		{
			component = new BooleanComponent();
			wasCalled = new[] {false, false, false, false};
		}

		[Test]
		public void Function_Boolean_Or_NoArguments_TrueInput()
		{
			var funcsToCombine = new List<Func<bool>>
			{
				() => (wasCalled[0] = true) && true,
				() => (wasCalled[1] = true) && true,
				() => (wasCalled[2] = true) && true,
				() => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined());
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_NoArguments_FalseInput()
		{
			var funcsToCombine = new List<Func<bool>>
			{
				() => (wasCalled[0] = true) && false,
				() => (wasCalled[1] = true) && false,
				() => (wasCalled[2] = true) && false,
				() => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined());
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_1Argument_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, bool>>
			{
				(a) => (wasCalled[0] = true) && true,
				(a) => (wasCalled[1] = true) && true,
				(a) => (wasCalled[2] = true) && true,
				(a) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_1Argument_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, bool>>
			{
				(a) => (wasCalled[0] = true) && false,
				(a) => (wasCalled[1] = true) && false,
				(a) => (wasCalled[2] = true) && false,
				(a) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_2Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, bool>>
			{
				(a, b) => (wasCalled[0] = true) && true,
				(a, b) => (wasCalled[1] = true) && true,
				(a, b) => (wasCalled[2] = true) && true,
				(a, b) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_2Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, bool>>
			{
				(a, b) => (wasCalled[0] = true) && false,
				(a, b) => (wasCalled[1] = true) && false,
				(a, b) => (wasCalled[2] = true) && false,
				(a, b) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_3Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, bool>>
			{
				(a, b, c) => (wasCalled[0] = true) && true,
				(a, b, c) => (wasCalled[1] = true) && true,
				(a, b, c) => (wasCalled[2] = true) && true,
				(a, b, c) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_3Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, bool>>
			{
				(a, b, c) => (wasCalled[0] = true) && false,
				(a, b, c) => (wasCalled[1] = true) && false,
				(a, b, c) => (wasCalled[2] = true) && false,
				(a, b, c) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_4Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, bool>>
			{
				(a, b, c, d) => (wasCalled[0] = true) && true,
				(a, b, c, d) => (wasCalled[1] = true) && true,
				(a, b, c, d) => (wasCalled[2] = true) && true,
				(a, b, c, d) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_4Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, bool>>
			{
				(a, b, c, d) => (wasCalled[0] = true) && false,
				(a, b, c, d) => (wasCalled[1] = true) && false,
				(a, b, c, d) => (wasCalled[2] = true) && false,
				(a, b, c, d) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_5Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, bool>>
			{
				(a, b, c, d, e) => (wasCalled[0] = true) && true,
				(a, b, c, d, e) => (wasCalled[1] = true) && true,
				(a, b, c, d, e) => (wasCalled[2] = true) && true,
				(a, b, c, d, e) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_5Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, bool>>
			{
				(a, b, c, d, e) => (wasCalled[0] = true) && false,
				(a, b, c, d, e) => (wasCalled[1] = true) && false,
				(a, b, c, d, e) => (wasCalled[2] = true) && false,
				(a, b, c, d, e) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_6Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_6Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_7Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_7Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_8Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_8Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_9Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_9Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_10Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_10Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_11Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_11Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_12Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_12Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_13Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_13Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_14Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_14Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_15Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_15Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_16Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[0] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[1] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[2] = true) && true,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[3] = true) && true,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsTrue(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsFalse(wasCalled[1]);
			Assert.IsFalse(wasCalled[2]);
			Assert.IsFalse(wasCalled[3]);
		}

		[Test]
		public void Function_Boolean_Or_16Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			var funcsToCombine = new List<Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool>>
			{
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[0] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[1] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[2] = true) && false,
				(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => (wasCalled[3] = true) && false,
			};

			var combined = component.Or(funcsToCombine[0], funcsToCombine[1], funcsToCombine[2], funcsToCombine[3]);

			Assert.IsFalse(combined(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
			Assert.IsTrue(wasCalled[0]);
			Assert.IsTrue(wasCalled[1]);
			Assert.IsTrue(wasCalled[2]);
			Assert.IsTrue(wasCalled[3]);
		}
	}
}