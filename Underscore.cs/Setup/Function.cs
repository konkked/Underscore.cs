using Underscore.Function;

namespace Underscore.Setup
{

    public class FunctionModule : IKernelModule
    {
        public void Load(Kernel kernel )
        {
            kernel.Register<IComposeComponent, ComposeComponent>();
            kernel.Register<IBindingComponent, BindingComponent>();
            kernel.Register<ISplitComponent,SplitComponent>();
            kernel.Register<IPartialComponent,PartialComponent>();
            kernel.Register<IConvertComponent,ConvertComponent>();
            kernel.Register<ISynchComponent,SynchComponent>();
            kernel.Register<ICacheComponent , CacheComponent>();
            kernel.Register<Module.Function>();
        }
    }
}
