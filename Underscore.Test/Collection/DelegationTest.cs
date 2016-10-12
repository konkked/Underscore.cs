using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
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

		private TestObj[] _testingItems;

		[SetUp]
		public void Initialize()
		{
			_testingItems = new[] { new TestObj(), new TestObj(), new TestObj(), new TestObj() };
		}

		[Test]
		public void Collection_Delegation_Invoke_WithoutArguments()
		{
			foreach (var item in _.Collection.Invoke(_testingItems, "MethodWithoutParameters"))
			{
				Assert.IsNull(item);
			}

			foreach (var item in _testingItems)
			{
				Assert.IsTrue(item.WasWithoutMethodCalled);
			}
		}

		public void Collection_Delegation_Invoke_WithArguments()
		{
			foreach (var item in _.Collection.Invoke(_testingItems, "MethodWithParameters", "str"))
			{
				Assert.IsNull(item);
			}

			foreach(var item in _testingItems)
			{ 
				Assert.IsTrue(item.WasWithMethodCalled);
				Assert.AreEqual("str", item.ParameterCalled);
			}
		}

		[Test]
		public void Collection_Delegation_Resolve()
		{
			var targetArr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			
			var target = new Func<int>[10];

			for (int i = 0; i < 10; i++)
			{
				var idx = i;
				target[i] = () => targetArr[idx];
			}

			var result = _.Collection.Resolve(target);


			for (int i = 0; i < 10; i++)
			{
				targetArr[i] *= 2;
			}

			result = _.Collection.Resolve(target);

			foreach (var items in Enumerable.Range(0, 10).Zip(result, Tuple.Create))
				Assert.AreEqual(items.Item1*2, items.Item2);
		}

        [Test]
        public void CollectionExtensions_Delegation_Invoke_WithoutArguments()
        {
            foreach (var item in _testingItems.Invoke("MethodWithoutParameters"))
            {
                Assert.IsNull(item);
            }

            foreach (var item in _testingItems)
            {
                Assert.IsTrue(item.WasWithoutMethodCalled);
            }
        }

        [Test]
        public void CollectionExtensions_Delegation_Invoke_WithArguments()
        {
            foreach (var item in _testingItems.Invoke("MethodWithParameters", "str"))
            {
                Assert.IsNull(item);
            }

            foreach (var item in _testingItems)
            {
                Assert.IsTrue(item.WasWithMethodCalled);
                Assert.AreEqual("str", item.ParameterCalled);
            }
        }

        [Test]
        public void CollectionExtensions_Delegation_Resolve()
        {
            var targetArr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var target = new Func<int>[10];

            for (int i = 0; i < 10; i++)
            {
                var idx = i;
                target[i] = () => targetArr[idx];
            }

            var result = target.Select(x => x).Resolve();


            for (int i = 0; i < 10; i++)
            {
                targetArr[i] *= 2;
            }

            result = target.Select(x => x).Resolve();

            foreach (var items in Enumerable.Range(0, 10).Zip(result, Tuple.Create))
                Assert.AreEqual(items.Item1 * 2, items.Item2);
        }
    }
}
