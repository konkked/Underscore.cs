using System;
using System.Linq;
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
				Assert.IsNull(item);
			}

			foreach (var item in testingItems)
			{
				Assert.IsTrue(item.WasWithoutMethodCalled);
			}
		}

		public void Collection_Delegation_Invoke_WithArguments()
		{
			foreach (var item in component.Invoke(testingItems, "MethodWithParameters", "str"))
			{
				Assert.IsNull(item);
			}

			foreach(var item in testingItems)
			{ 
				Assert.IsTrue(item.WasWithMethodCalled);
				Assert.AreEqual("str", item.ParameterCalled);
			}
		}

		[TestMethod]
		public void Collection_Delegation_Resolve()
		{
			var targetArr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			var testing = new DelegationComponent(new MethodComponent(new MockUtilFunctionComponent(), new PropertyComponent()));
			var target = new Func<int>[10];

			for (int i = 0; i < 10; i++)
			{
				var idx = i;
				target[i] = () => targetArr[idx];
			}

			var result = testing.Resolve(target);


			for (int i = 0; i < 10; i++)
			{
				targetArr[i] *= 2;
			}

			result = testing.Resolve(target);

			foreach (var items in Enumerable.Range(0, 10).Zip(result, Tuple.Create))
				Assert.AreEqual(items.Item1*2, items.Item2);
		}
	}
}
