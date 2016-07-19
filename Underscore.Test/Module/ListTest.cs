using NUnit.Framework;
using System;
using Underscore.List;

namespace Underscore.Test.Module
{
    [TestFixture]
    public class ListTest
    {
        [Test]
        public void List_CreateModule()
        {
            var result = new global::Underscore.Module.List(
                new ManipulateComponent(),
                new Underscore.List.PartitionComponent()
                );
        }

        [Test]
        public void List_CreateModule_MissingManipulateComponent()
        {
            Assert.Throws<ArgumentNullException>(
                () => new Underscore.Module.List(null, new Underscore.List.PartitionComponent()),
                "Value cannot be null.\r\nParameter name: manipulator");
        }

        [Test]
        public void List_CreateModule_MissingPartitionComponent()
        {
            Assert.Throws<ArgumentNullException>(
                () => new Underscore.Module.List(new ManipulateComponent(), null),
                "Value cannot be null.\r\nParameter name: partitioner");

        }

    }
}
