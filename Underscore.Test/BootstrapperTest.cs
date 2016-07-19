using NUnit.Framework;

namespace Underscore.Test
{
    [TestFixture]
    public class BootstrapperTest
    {
        [Test]
        public void GetKernel()
        {
            var kernel = Bootstrapper.Kernel;
        }
    }
}
