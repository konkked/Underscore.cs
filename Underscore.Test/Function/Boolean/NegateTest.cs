using System;
using NUnit.Framework;
using Underscore.Function;
namespace Underscore.Test.Boolean
{
	// Generated using /codegen/boolean_negate_test.py
	[TestFixture]
	public class NegateTest
	{
		private BooleanComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new BooleanComponent();
		}

		[Test]
		public void Function_Boolean_Negate_NoArguments_TrueInput()
		{
			Func<bool> toNegate = () => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated());
		}

		[Test]
		public void Function_Boolean_Negate_NoArguments_FalseInput()
		{
			Func<bool> toNegate = () => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated());
		}

		[Test]
		public void Function_Boolean_Negate_1Argument_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, bool> toNegate = (a) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj));
		}

		[Test]
		public void Function_Boolean_Negate_1Argument_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, bool> toNegate = (a) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj));
		}

		[Test]
		public void Function_Boolean_Negate_2Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, bool> toNegate = (a, b) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_2Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, bool> toNegate = (a, b) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_3Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, bool> toNegate = (a, b, c) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_3Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, bool> toNegate = (a, b, c) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_4Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, bool> toNegate = (a, b, c, d) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_4Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, bool> toNegate = (a, b, c, d) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_5Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, bool> toNegate = (a, b, c, d, e) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_5Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, bool> toNegate = (a, b, c, d, e) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_6Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_6Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_7Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_7Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_8Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_8Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_9Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_9Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_10Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_10Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_11Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_11Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_12Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_12Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_13Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_13Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_14Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_14Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_15Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_15Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_16Arguments_TrueInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => true;

			var negated = _.Function.Negate(toNegate);

			Assert.IsFalse(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

		[Test]
		public void Function_Boolean_Negate_16Arguments_FalseInput()
		{
			// this is just used to fill params
			var obj = new object();
			Func<object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, object, bool> toNegate = (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => false;

			var negated = _.Function.Negate(toNegate);

			Assert.IsTrue(negated(obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj, obj));
		}

	}
}