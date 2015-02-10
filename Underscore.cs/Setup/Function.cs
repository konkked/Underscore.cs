using Underscore.Function;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{

    public class FunctionModule : IKernelModule
    {
        public void Load(Kernel kernel )
        {
            kernel.Register<IComposeComponent, ComposeComponent>();
            kernel.Register<IBindComponent, BindComponent>();
            kernel.Register<ISplitComponent,SplitComponent>();
            kernel.Register<IPartialComponent,PartialComponent>();
            kernel.Register<IConvertComponent,ConvertComponent>();
            kernel.Register<ISynchComponent,SynchComponent>();
            kernel.Register<ICacheComponent , CacheComponent>();
            kernel.Register<ICompactComponent, CompactComponent>();
            kernel.Register<Module.Function>();
        }
    }
}
