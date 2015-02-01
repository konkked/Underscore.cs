using Underscore.Action;

namespace Underscore.Setup
{
    public class ActionModule : IKernelModule
    {
        public void Load(Kernel kernel )
        {
            kernel.Register<IBindComponent, BindComponent>();
            kernel.Register<IPartialComponent,PartialComponent>();
            kernel.Register<ISplitComponent, SplitComponent>();
            kernel.Register<IConvertComponent,ConvertComponent>();
            kernel.Register<IComposeComponent, ComposeComponent>();
            kernel.Register<ISynchComponent,SynchComponent>();
            kernel.Register<Module.Action>();
        }
    }
}
