using Underscore.List;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
    public class ListModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
            kernel.Register<IManipulateComponent,ManipulateComponent>( );
            kernel.Register<IPartitionComponent,PartitionComponent>();
            kernel.Register<Module.List>();
        }
    }
}
