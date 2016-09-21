using Underscore.Function;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
	public class FunctionModule : IKernelModule
	{
		public void Load(Kernel kernel)
		{
			kernel.Register<IComposeComponent, ComposeComponent>();
			kernel.Register<IBindComponent, BindComponent>();
			kernel.Register<ISplitComponent, SplitComponent>();
			kernel.Register<IConvertComponent, ConvertComponent>();
			kernel.Register<IAfterComponent, AfterComponent>();
            kernel.Register<IBeforeComponent, BeforeComponent>();
            kernel.Register<IDebounceComponent, DebounceComponent>();
            kernel.Register<IDelayComponent, DelayComponent>();
            kernel.Register<IOnceComponent, OnceComponent>();
            kernel.Register<IAfterComponent, AfterComponent>();
            kernel.Register<ICacheComponent, CacheComponent>();
			kernel.Register<ICompactComponent, CompactComponent>();
			kernel.Register<IBooleanComponent, BooleanComponent>();
			kernel.Register<Module.Function>();
		}
	}
}
