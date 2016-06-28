using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;

namespace Underscore.Test.Module
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void CreateListModuleTest( )
        {
            var result = new global::Underscore.Module.List(
                new DelegationComponent(),
                new ManipulateComponent(),
                new PartitionComponent()
            );
        }
    }
}
