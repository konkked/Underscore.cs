using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Underscore.Function;

namespace Underscore.Test.Function
{
    [TestClass]
    public class CacheTest
    {
		//TODO: Finish overload tests
        [TestMethod]
        public void Function_Cache_Memo_1Argument()
        {
            var callcount = 0;

            Func<string, string> testFn = a =>
            {
                callcount++;
                return a;
            };

            var testing = new CacheComponent();

            var memoized = testing.Memoize(testFn);

            var testStr = "test";

            var result = memoized(testStr);

            Assert.AreEqual(testStr, result);
            Assert.AreEqual(1, callcount);
            Assert.AreEqual(testStr, memoized(testStr));
            Assert.AreEqual(1, callcount);

            testStr = "test2";
            result = memoized(testStr);

            Assert.AreEqual(testStr, result);
            Assert.AreEqual(2, callcount);
            Assert.AreEqual(testStr, memoized("test2"));
            Assert.AreEqual(2, callcount);
        }
    }
}
