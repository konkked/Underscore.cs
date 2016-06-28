using Microsoft.VisualStudio.TestTools.UnitTesting;
using BindComponent = Underscore.Action.BindComponent;
using ComposeComponent = Underscore.Action.ComposeComponent;
using ConvertComponent = Underscore.Action.ConvertComponent;
using PartialComponent = Underscore.Action.PartialComponent;
using SplitComponent = Underscore.Action.SplitComponent;
using SynchComponent = Underscore.Action.SynchComponent;

namespace Underscore.Test.Module
{
    [TestClass]
    public class ActionTest
    {
        [TestMethod]
        public void ActionCreate()
        {
            var action = new Underscore.Module.Action( 
                new BindComponent(), 
                new PartialComponent(), 
                new SplitComponent(), 
                new ComposeComponent(),
                new SynchComponent(),
                new ConvertComponent()
            );
        }
    }
}
