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
            Assert.IsTrue(_.Utility.IsTruthy("any"));
        }

        [Test]
        public void Utility_Object_Truthy_EmptyString()
        {
            Assert.IsFalse(_.Utility.IsTruthy(""));
        }

        [Test]
        public void Utility_Object_Truthy_NonZero()
        {
            Assert.IsTrue(_.Utility.IsTruthy(1));
        }

        [Test]
        public void Utility_Object_Truthy_Zero()
        {
            Assert.IsFalse(_.Utility.IsTruthy(0));
        }

        [Test]
        public void Utility_Object_Truthy_True()
        {
            Assert.IsTrue(_.Utility.IsTruthy(true));
        }

        [Test]
        public void Utility_Object_Truthy_False()
        {
            Assert.IsFalse(_.Utility.IsTruthy(false));
        }

        [Test]
        public void Utility_Object_Truthy_MiscObject()
        {
            Assert.IsTrue(_.Utility.IsTruthy(new object()));
        }

        [Test]
        public void Utility_Object_Truthy_NullObject()
        {
            Assert.IsFalse(_.Utility.IsTruthy(null));
        }
    }
}
