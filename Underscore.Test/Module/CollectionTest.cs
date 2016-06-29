using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;
using Underscore.Collection.Implementation;
using Underscore.Collection.Implementation.Zip;

namespace Underscore.Test.Module
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void CreateCollectionModuleTest()
        {
            var result = new Underscore.Module.Collection(
				new CompareComponent(),
				new CreationComponent(),
				new DelegationComponent(),
                new PartitionComponent(),
				new ZipComponent()
			);

            Assert.IsNotNull(result);
        }
    }
}
