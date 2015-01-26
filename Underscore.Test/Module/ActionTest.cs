using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Action;

namespace Underscore.Test.Module
{
    [TestClass]
    public class ActionTest
    {
        [TestMethod]
        public void ActionCreate( )
        {
            var binding = new BindingComponent();
            var partialComponent = new PartialComponent();
            var split = new SplitComponent();
            var compose = new ComposeComponent();

            var fnBind = new global::Underscore.Function.SynchComponent();
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
