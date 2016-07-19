using NUnit.Framework;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
	[TestFixture]
	public class ObjectTest
	{
		private ObjectComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new ObjectComponent();
		}

		[Test]
		public void Utility_Object_Truthy_NonEmptyString()
		{
			Assert.IsTrue(component.IsTruthy("any"));
		}

		[Test]
		public void Utility_Object_Truthy_EmptyString()
		{
			Assert.IsFalse(component.IsTruthy(""));
		}

		[Test]
		public void Utility_Object_Truthy_NonZero()
		{
			Assert.IsTrue(component.IsTruthy(1));
		}

		[Test]
		public void Utility_Object_Truthy_Zero()
		{
			Assert.IsFalse(component.IsTruthy(0));
		}

		[Test]
		public void Utility_Object_Truthy_True()
		{
			Assert.IsTrue(component.IsTruthy(true));
		}

		[Test]
		public void Utility_Object_Truthy_False()
		{
			Assert.IsFalse(component.IsTruthy(false));
		}

		[Test]
		public void Utility_Object_Truthy_MiscObject()
		{
			Assert.IsTrue(component.IsTruthy(new object()));
		}

		[Test]
		public void Utility_Object_Truthy_NullObject()
		{
			Assert.IsFalse(component.IsTruthy(null));
		}
	}
}
