using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Module
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void CreateListModuleTest()
        {
            var result = new Underscore.Module.Collection(
				new CreationComponent(),
                new PartitionComponent(),
                new DelegationComponent()
			);

            Assert.IsNotNull(result);
        }
    }
}
