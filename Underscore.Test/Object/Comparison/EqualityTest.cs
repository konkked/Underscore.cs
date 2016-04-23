using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Object.Comparison;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Comparison
{
    [TestClass]
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


        [TestMethod()]
        public void Equality_Compare_DifferentTypes()
        {
            IEqualityComponent testing = new EqualityComponent(new PropertyComponent());

            var item1 =
                new
                {
                    Property1 = "Value1",
                    Property2 = "Value2",
                    Property3 = new {NestedObject = new {SomeInternalProperty = "Value"}, NestedProperty = "NestedValue"}
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


            Assert.IsTrue(testing.AreEquatable(item2,item1));
            Assert.IsTrue(testing.AreEquatable(item1, item2));
        }


        [TestMethod()]
        public void Equality_Compare_SameTypes()
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
