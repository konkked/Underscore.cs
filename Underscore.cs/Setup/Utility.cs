using Underscore.Utility;

namespace Underscore.Setup
{
    public class UtilityModule : IKernelModule
    {
        public void Load( Kernel kernel)
        {
        
            kernel.Register<IFunctionComponent,FunctionComponent>( );
            kernel.Register<IMathComponent,MathComponent>( );
            kernel.Register<IObjectComponent,ObjectComponent>( );
            kernel.Register<Module.Utility>();
        
        }
    }
}
