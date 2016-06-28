using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;
using Underscore.Object.Reflection;

namespace Underscore.Test.List
{
    [TestClass]
    public class DelegateTester
    {
        [TestMethod]
        public void List_Delegation_Resolve()
        {
            var targetArr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testing = new DelegationComponent(new MethodComponent(new MockUtilFunctionComponent(), new PropertyComponent()));
            var target = new Func<int>[10];

            for (var i = 0; i < 10; i++)
            {
                var idx = i;
                target[i] = () => targetArr[idx];
            }

            var result = testing.Resolve(target);

            for (var i = 0; i < 10; i++)
                Assert.AreEqual(i, result[i]);

            for (var i = 0; i < 10; i++)
            {
                targetArr[i] *= 2;
            }

            result = testing.Resolve(target);

            for (var i = 0; i > 10; i++) 
            {
                Assert.AreEqual(i * 2, result[i]);
            }
        }
    }
}
