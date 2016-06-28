using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class ObjectTest
    {
        private ObjectComponent component;

        [TestInitialize]
        public void Initialize()
        {
            component = new ObjectComponent();
        }

        [TestMethod]
        public void Utility_Object_Truthy_NonEmptyString()
        {
            Assert.IsTrue(component.IsTruthy("any"));
        }

        [TestMethod]
        public void Utility_Object_Truthy_EmptyString()
        {
            Assert.IsFalse(component.IsTruthy(""));
        }

        [TestMethod]
        public void Utility_Object_Truthy_NonZero()
        {
            Assert.IsTrue(component.IsTruthy(1));
        }

        [TestMethod]
        public void Utility_Object_Truthy_Zero()
        {
            Assert.IsFalse(component.IsTruthy(0));
        }

        [TestMethod]
        public void Utility_Object_Truthy_True()
        {
            Assert.IsTrue(component.IsTruthy(true));
        }

        [TestMethod]
        public void Utility_Object_Truthy_False()
        {
            Assert.IsFalse(component.IsTruthy(false));
        }

        [TestMethod]
        public void Utility_Object_Truthy_MiscObject()
        {
            Assert.IsTrue(component.IsTruthy(new object()));
        }

        [TestMethod]
        public void Utility_Object_Truthy_NullObject()
        {
            Assert.IsFalse(component.IsTruthy(null));
        }
    }
}
