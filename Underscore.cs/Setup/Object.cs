using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Setup
{
    public class ObjectModule : IKernelModule
    {
        public void Load(Kernel kernel)
        {
            kernel.Register<IFieldComponent,FieldComponent>( );
            kernel.Register<IMethodComponent, MethodComponent>( );        
            kernel.Register<IPropertyComponent,PropertyComponent>();                
            kernel.Register<ITransformComponent,TransformComponent>();

            kernel.Register<Module.Object>();
        }
    }
}
