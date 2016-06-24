using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;
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

	    private TestObj[] testingItems;
	    private DelegationComponent component;

		[TestInitialize]
	    public void Initialize()
	    {
			testingItems = new[] { new TestObj(), new TestObj(), new TestObj(), new TestObj() };

			component = new DelegationComponent(
					new MethodComponent(
						new CacheComponent(new CompactComponent(),
							new Underscore.Utility.CompactComponent()), new PropertyComponent()));
	    }

        [TestMethod]
        public void Collection_Delegation_Invoke_WithoutArguments()
        {
			foreach (var item in component.Invoke(testingItems, "MethodWithoutParameters"))
            {
                Assert.IsTrue(item.WasWithoutMethodCalled);
            }
        }

	    public void Collection_Delegation_Invoke_WithArguments()
	    {
			foreach (var item in component.Invoke(testingItems, "MethodWithParameters", "str"))
			{
				Assert.IsTrue(item.WasWithMethodCalled);
				Assert.AreEqual("str", item.ParameterCalled);
			}
		}
    }
}
