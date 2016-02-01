using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Function
{
    [TestClass]
    public class BooleanTest
    {
        [TestMethod]
        public void FunctionNegate()
        {
            var testing = new BooleanComponent();
            var function = testing.Negate( () => true);

            Assert.IsFalse(function());

            var fn2 = testing.Negate(new Func<string, bool>(s => s == "s"));
            Assert.IsTrue(fn2("l"));
            Assert.IsFalse(fn2("s"));

        }

        [TestMethod]
        public void FunctionOrPositive()
        {
            bool[] wasCalled = {false, false, false, false};
            Func<string,string, bool>[] toCall =
            {
                (s,s2) => wasCalled[0] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[1] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[2] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[3] = s == "s1" && s2 == "s2"
            };
            var testing = new BooleanComponent();
            var result = testing.Or(toCall);
            Assert.IsTrue(result("s1","s2"));
            Assert.IsTrue(wasCalled[0]);
            Assert.IsFalse(wasCalled[1]);
            Assert.IsFalse(wasCalled[2]);
            Assert.IsFalse(wasCalled[3]);

        }


        [TestMethod]
        public void FunctionOrNegative()
        {
            bool[] wasCalled = { true, true, true, true};
            Func<string, string, bool>[] toCall =
            {
                (s,s2) => wasCalled[0] = s != "s1" && s2 != "s2",
                (s,s2) => wasCalled[1] = s != "s1" && s2 != "s2",
                (s,s2) => wasCalled[2] = s != "s1" && s2 != "s2",
                (s,s2) => wasCalled[3] = s != "s1" && s2 != "s2"
            };
            var testing = new BooleanComponent();
            var result = testing.Or(toCall);
            Assert.IsFalse(result("s1", "s2"));
            foreach (var b in wasCalled)
            {
                Assert.IsFalse(b);
            }
        }



        [TestMethod]
        public void FunctionAndPositive()
        {
            bool[] wasCalled = { false, false, false, false };
            Func<string, string, bool>[] toCall =
            {
                (s,s2) => wasCalled[0] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[1] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[2] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[3] = s == "s1" && s2 == "s2"
            };
            var testing = new BooleanComponent();
            var result = testing.And(toCall);
            Assert.IsTrue(result("s1", "s2"));
            foreach (var b in wasCalled)
            {
                Assert.IsTrue(b);
            }
        }


        [TestMethod]
        public void FunctionAndNegative()
        {
            bool[] wasCalled = { true, true, true, true };
            Func<string, string, bool>[] toCall =
            {
                (s,s2) => wasCalled[0] = s != "s1" && s2 != "s2",
                (s,s2) => wasCalled[1] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[2] = s == "s1" && s2 == "s2",
                (s,s2) => wasCalled[3] = s == "s1" && s2 == "s2"
            };
            var testing = new BooleanComponent();
            var result = testing.And(toCall);
            Assert.IsFalse(result("s1", "s2"));
            Assert.IsFalse(wasCalled[0]);

            for(int i=1;i<wasCalled.Length;i++)
                Assert.IsTrue(wasCalled[i]);
        }
    }
}
