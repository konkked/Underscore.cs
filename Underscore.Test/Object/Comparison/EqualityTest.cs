using NUnit.Framework;
using Underscore.Object.Comparison;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Comparison
{
    [TestFixture]
    public class EqualityComponentTest
    {
        public class EqualityTestObject
        {
            public string Property1 { get; set; }
            public string Property2 { get; set; }
            public EqualityTestObject2 Property3 { get; set; }
        }

        public class EqualityTestObject2
        {
            public string NestedProperty { get; set; }
            public EqualityTestObject3 NestedObject { get; set; }
        }

        public class EqualityTestObject3
        {
            public string SomeInternalProperty { get; set; }
        }

        [Test]
        public void Object_Comparison_Equality_TypeInsensitiveSameType()
        {
            IEqualityComponent testing = new EqualityComponent();

            var item1 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            var item2 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            Assert.IsTrue(testing.AreEquatable(item2, item1));
            Assert.IsTrue(testing.AreEquatable(item1, item2));
        }

        [Test]
        public void Object_Comparison_Equality_TypeInsensitiveDifferentTypes()
        {
            IEqualityComponent testing = new EqualityComponent(new PropertyComponent());

            var item1 =
                new
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new { NestedObject = new { SomeInternalProperty = "Value" }, NestedProperty = "NestedValue" }
                };

            var item2 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            Assert.IsTrue(testing.AreEquatable(item2, item1));
            Assert.IsTrue(testing.AreEquatable(item1, item2));
        }

        [Test]
        public void Object_Comparison_Equality_TypeSensitiveSameType()
        {
            IEqualityComponent testing = new EqualityComponent(new PropertyComponent());

            var item1 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            var item2 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            Assert.IsTrue(testing.AreEquatable(item2, item1, true));
            Assert.IsTrue(testing.AreEquatable(item1, item2, true));
        }

        [Test]
        public void Object_Comparison_Equality_TypeSensitiveDifferentTypes()
        {
            IEqualityComponent testing = new EqualityComponent(new PropertyComponent());

            var item1 =
                new
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new { NestedObject = new { SomeInternalProperty = "Value" }, NestedProperty = "NestedValue" }
                };

            var item2 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            Assert.IsFalse(testing.AreEquatable(item2, item1, true));
            Assert.IsFalse(testing.AreEquatable(item1, item2, true));
        }

        [Test]
        public void Object_Comparison_Equality_IsCommunicative()
        {
            IEqualityComponent testing = new EqualityComponent(new PropertyComponent());

            var item1 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            var item2 =
                new EqualityTestObject
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new EqualityTestObject2()
                    {
                        NestedProperty = "NestedValue",
                        NestedObject = new EqualityTestObject3
                        {
                            SomeInternalProperty = "Value"
                        }
                    }
                };

            Assert.IsTrue(testing.AreEquatable(item2, item1));
            Assert.IsTrue(testing.AreEquatable(item1, item2));
        }
    }
}
