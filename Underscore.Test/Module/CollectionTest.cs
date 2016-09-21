using NUnit.Framework;
using Underscore.Collection;
using Underscore.Function;
using Underscore.Object.Reflection;
using Underscore.Utility;
using CompactComponent = Underscore.Function.CompactComponent;

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
				new DelegationComponent( new MethodComponent( new CacheComponent(new CompactComponent(), new Underscore.Utility.CompactComponent()),new PropertyComponent() )),
				new FilterComponent(),
				new PartitionComponent( new Underscore.List.PartitionComponent(new MathComponent())),
				new SetComponent(),
				new ZipComponent(),
                new UnZipComponent()
			);

			Assert.IsNotNull(result);
		}
	}
}
