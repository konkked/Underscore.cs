using Underscore.List;

namespace Underscore.Setup
{
    public class ListModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
            kernel.Register<IDelegateComponent,DelegateComponent>( );
            kernel.Register<IManipulateComponent,ManipulateComponent>( );
            kernel.Register<IPartitionComponent,PartitionComponent>();
            kernel.Register<Module.List>();
        }
    }
}
