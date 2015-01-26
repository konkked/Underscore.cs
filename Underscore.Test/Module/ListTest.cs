using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;
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
                new DelegateComponent( ),
                new ManipulateComponent( ),
                new PartitionComponent( new MathComponent() )
            );


        }
    }
}
