using Underscore.Setup;
using Underscore.Setup.Liteioc;

namespace Underscore
{
    public static class Bootstrapper
    {
        private static readonly Kernel s_kernel;

        static Bootstrapper()
        {
            s_kernel = new Kernel(
                new ActionModule(),
                new CollectionModule(),
                new FunctionModule(),
                new ListModule(),
                new UtilityModule(),
                new ObjectModule()
            );
        }

        public static Kernel Kernel
        {
            get { return s_kernel; }
        }
    }
}
