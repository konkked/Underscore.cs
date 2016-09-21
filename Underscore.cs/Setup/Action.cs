using Underscore.Action;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
	public class ActionModule : IKernelModule
	{
		public void Load(Kernel kernel)
		{
			kernel.Register<IBindComponent, BindComponent>();
            kernel.Register<IPartialComponent, PartialComponent>();
			kernel.Register<ISplitComponent, SplitComponent>();
            kernel.Register<ICurryComponent, CurryComponent>();
            kernel.Register<IUncurryComponent, UncurryComponent>();
			kernel.Register<IConvertComponent, ConvertComponent>();
			kernel.Register<IComposeComponent, ComposeComponent>();
            kernel.Register<IApplyComponent, ApplyComponent>();
			kernel.Register<IAfterComponent, AfterComponent>();
            kernel.Register<IBeforeComponent, BeforeComponent>();
            kernel.Register<IDebounceComponent, DebounceComponent>();
            kernel.Register<IDelayComponent, DelayComponent>();
            kernel.Register<IOnceComponent, OnceComponent>();
            kernel.Register<IThrottleComponent, ThrottleComponent>();
            kernel.Register<Module.Action>();
		}
	}
}
