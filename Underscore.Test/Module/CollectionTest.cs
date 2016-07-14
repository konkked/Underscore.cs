using NUnit.Framework;
using Underscore.Collection;

namespace Underscore.Test.Module
{
    [TestFixture]
    public class CollectionTest
    {
        [Test]
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
