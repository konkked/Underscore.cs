using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;
using Underscore.Function;
using Underscore.List;
using Underscore.Object.Reflection;
using Underscore.Utility;
using CompactComponent = Underscore.Utility.CompactComponent;
using DelegationComponent = Underscore.Collection.DelegationComponent;

namespace Underscore.Test.Module
{
    [TestClass]
    public class CollectionTest
    {
        [TestMethod]
        public void CreateListModuleTest()
        {
            var result = new global::Underscore.Module.Collection(new CreationComponent(),
                new Underscore.Collection.PartitionComponent(new Underscore.List.PartitionComponent(new MathComponent())),
                new DelegationComponent(
                    new MethodComponent(
                        new CacheComponent(new Underscore.Function.CompactComponent(),
                            new Underscore.Utility.CompactComponent()), new PropertyComponent())));

            Assert.IsNotNull(result);
        }
    }
}
