using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using Underscore.Object.Reflection;

namespace Underscore.Test.Collection
{
    [TestClass]
    public class DelegationTest
    {
        public class TestObj
        {
            public void MethodWithoutParameters()
            {
                WasWithoutMethodCalled = true;
            }
            public bool WasWithoutMethodCalled { get; set; }


            public void MethodWithParameters(string str)
            {
                ParameterCalled = str;
                WasWithMethodCalled = true;
            }
            public string ParameterCalled { get; set; }
            public bool WasWithMethodCalled { get; set; }
        }

        [TestMethod]
        public void CollectionInvoke()
        {
            var testingItems = new[] {new TestObj(), new TestObj(), new TestObj(), new TestObj()};

            var testingVal =
                new Underscore.Collection.DelegationComponent(
                    new MethodComponent(
                        new CacheComponent(new Underscore.Function.CompactComponent(),
                            new Underscore.Utility.CompactComponent()), new PropertyComponent()));

            foreach (var item in testingVal.Invoke(testingItems, "MethodWithoutParameters"))
            {
                Assert.IsTrue(item.WasWithoutMethodCalled);
            }


            foreach (var item in testingVal.Invoke(testingItems, "MethodWithParameters","str"))
            {
                Assert.IsTrue(item.WasWithMethodCalled);
                Assert.AreEqual("str",item.ParameterCalled);
            }

        }
    }
}
