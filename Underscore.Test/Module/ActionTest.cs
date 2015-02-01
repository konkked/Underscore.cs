using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
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
        public void ActionCreate( )
        {
            var binding = new BindComponent();
            var partialComponent = new PartialComponent();
            var split = new SplitComponent();
            var compose = new ComposeComponent();

            var fnBind = new global::Underscore.Function.SynchComponent( new CompactComponent(), new Underscore.Utility.CompactComponent());
            var fnSynch = new global::Underscore.Function.ConvertComponent();
            var actionCvt = new ConvertComponent();

            var action = new global::Underscore.Module.Action( 
                binding, 
                partialComponent, 
                split, 
                compose,
                new SynchComponent(fnBind,actionCvt,fnSynch),
                actionCvt
                );
        }

    }
}
