using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using Underscore.List;
using Underscore.Object.Reflection;
using Underscore.Utility;

namespace Underscore.Test.Module
{
    [TestClass]
    public class ListTest
    {
        [TestMethod]
        public void CreateListModuleTest( )
        {
            var result = new global::Underscore.Module.List(
                new DelegationComponent( new MethodComponent(new CacheComponent(new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent() ), new PropertyComponent() )  ),
                new ManipulateComponent( ),
                new PartitionComponent( new MathComponent() )
            );


        }
    }
}
