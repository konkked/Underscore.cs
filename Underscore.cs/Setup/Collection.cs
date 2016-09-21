using Underscore.Collection;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
	public class CollectionModule : IKernelModule
	{
		public void Load(Kernel kernel)
		{
			kernel.Register<ICompareComponent, CompareComponent>();
			kernel.Register<ICreationComponent, CreationComponent>();
			kernel.Register<IDelegationComponent, DelegationComponent>();
			kernel.Register<IFilterComponent, FilterComponent>();
			kernel.Register<ISetComponent, SetComponent>();
			kernel.Register<IZipComponent, ZipComponent>();
            kernel.Register<IUnZipComponent, UnZipComponent>();
            kernel.Register<IPartitionComponent, PartitionComponent>();
			kernel.Register<List.IPartitionComponent, List.PartitionComponent>();
			kernel.Register<Module.Collection>();
		}
	}
}
