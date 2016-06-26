using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class FunctionTest
    {
        [TestMethod]
        public void Utility_Function_Constant()
        {
            var testing = new FunctionComponent();

            var values = new { a = "1234", b = "4567", c = 12 };

            var result = testing.Constant(values);

            Assert.AreSame(values, result());
            values = new { a = "abc", b = "1234", c = 34 };
            Assert.AreNotSame(values, result());
        }
    }
}
