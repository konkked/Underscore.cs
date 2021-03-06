﻿using Underscore.Object;
using Underscore.Object.Comparison;
using Underscore.Object.Reflection;
using Underscore.Setup.Liteioc;

namespace Underscore.Setup
{
	public class ObjectModule : IKernelModule
	{
		public void Load(Kernel kernel)
		{
			kernel.Register<IFieldComponent, FieldComponent>();
			kernel.Register<IMethodComponent, MethodComponent>();
			kernel.Register<IPropertyComponent, PropertyComponent>();
			kernel.Register<ITransposeComponent, TransposeComponent>();
			kernel.Register<IDynamicComponent, DynamicComponent>();
			kernel.Register<IConstructorComponent, ConstructorComponent>();
			kernel.Register<IAttributeComponent, AttributeComponent>();
			kernel.Register<IEqualityComponent, EqualityComponent>();
			kernel.Register<Module.Object>();
		}
	}
}
