using Underscore.Function;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
	public class FunctionModule : IKernelModule
	{
		public void Load(Kernel kernel)
		{
            kernel.Register<IApplyComponent, ApplyComponent>();
			kernel.Register<IComposeComponent, ComposeComponent>();
			kernel.Register<IBindComponent, BindComponent>();
            kernel.Register<IPartialComponent, PartialComponent>();
            kernel.Register<ISplitComponent, SplitComponent>();
            kernel.Register<ICurryComponent, CurryComponent>();
            kernel.Register<IUncurryComponent, UncurryComponent>();
			kernel.Register<IConvertComponent, ConvertComponent>();
			kernel.Register<IAfterComponent, AfterComponent>();
            kernel.Register<IBeforeComponent, BeforeComponent>();
            kernel.Register<IDebounceComponent, DebounceComponent>();
            kernel.Register<IDelayComponent, DelayComponent>();
            kernel.Register<IOnceComponent, OnceComponent>();
            kernel.Register<IThrottleComponent, ThrottleComponent>();
            kernel.Register<IAfterComponent, AfterComponent>();
            kernel.Register<ICacheComponent, CacheComponent>();
			kernel.Register<ICompactComponent, CompactComponent>();
			kernel.Register<IAndComponent, AndComponent>();
            kernel.Register<IOrComponent, OrComponent>();
            kernel.Register<INegateComponent, NegateComponent>();
			kernel.Register<Module.Function>();
		}
	}
}
