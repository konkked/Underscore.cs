using NUnit.Framework;
using Moq;
using System.Reflection;
using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Transformation
{
    [TestFixture]
    public class DynamicTest
    {
        public class Person
        {
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string NickName { get; set; }

            public string MiddleName { get; set; }

            public string Title { get; set; }

            public string Suffix { get; set; }

            public int Age { get; set; }
        }

        [Test]
        public void Object_Transformation_Dynamic()
        {
            var a = "a";
            var b = 1;
            var c = 12.0;

            var testTarget = new { a, b, c };

            var prop = new Mock<IPropertyComponent>();

            prop.Setup(s=>s.All(It.Is<object>(r=> r == testTarget)))
                .Returns(testTarget.GetType().GetProperties(BindingFlags.Public|BindingFlags.Instance));

            var testing = new DynamicComponent(prop.Object);

            var result = testing.ToDynamic(testTarget);

            Assert.AreEqual(a , result.a);
            Assert.AreEqual(b , result.b);
            Assert.AreEqual(c , result.c);
        }
    }
}
