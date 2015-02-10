using Underscore.Object;
using Underscore.Object.Reflection;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
    public class ObjectModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
            kernel.Register<IFieldComponent,FieldComponent>( );
            kernel.Register<IMethodComponent, MethodComponent>( );        
            kernel.Register<IPropertyComponent,PropertyComponent>();                
            kernel.Register<ITransposeComponent,TransposeComponent>();

            kernel.Register<Module.Object>();
        }
    }
}
