using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Underscore.Test
{
    [TestClass]
    public class BootstrapperTest
    {
        [TestMethod]
        public void GetKernel()
        {
            var kernel = Bootstrapper.Kernel;
        }
    }
}
