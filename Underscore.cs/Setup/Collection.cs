using Underscore.Collection;
using Underscore.Collection.Contract;
using Underscore.Collection.Implementation;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
    public class CollectionModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
			kernel.Register<ICompareComponent, CompareComponent>();
            kernel.Register<ICreationComponent, CreationComponent>();
			kernel.Register<IDelegationComponent, DelegationComponent>();,
	        kernel.Register<IFilterComponent, FilterComponent>();
			kernel.Register<ISetComponent, SetComponent>();
			kernel.Register<IZipComponent, ZipComponent>();
            kernel.Register<IPartitionComponent, PartitionComponent>();
            kernel.Register<List.IPartitionComponent, List.PartitionComponent>();
            kernel.Register<Module.Collection>();
        }
    }
}
