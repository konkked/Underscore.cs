using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Setup.Liteioc
{
	//simple di injection container 
	//to avoid dependence on outside resources
	public sealed class Kernel
	{
		private readonly Dictionary<Type, Type> _resolver;

		public Kernel()
		{
			_resolver = new Dictionary<Type, Type>();
		}

		public Kernel(params IKernelModule[] modules)
		{
			_resolver = new Dictionary<Type, Type>();

			foreach (var module in modules)
				module.Load(this);

		}

		public void Register<TInterface, TImplementation>()
			where TImplementation : TInterface
		{
			_resolver[typeof(TInterface)] = typeof(TImplementation);
		}

		public void Register<T>()
		{
			_resolver[typeof(T)] = typeof(T);
		}

		private object Resolve(Type contract)
		{
			var tinterface = contract;
			var implType = _resolver[tinterface];
			var ctors = implType.GetConstructors(BindingFlags.Public | BindingFlags.Instance);
			var targetCtor =
				ctors.FirstOrDefault(
					v => v.GetParameters().All(
						parameter => _resolver.ContainsKey(parameter.ParameterType)
					)
				);

			if (targetCtor == null)
			{
				//see if we have an empty one
				targetCtor = ctors.FirstOrDefault(a => !a.GetParameters().Any());
				if (targetCtor != null)
				{
					return targetCtor.Invoke(null);
				}

			}

			if (targetCtor == null)
				throw new InvalidOperationException(string.Format("Was not able to resolve type {0}", tinterface));

			var paramValues = targetCtor.GetParameters().Select(a => Resolve(a.ParameterType)).ToArray();
			return targetCtor.Invoke(paramValues);
		}

		public TInterface Resolve<TInterface>()
		{
			return (TInterface)Resolve(typeof(TInterface));
		}
	}
}
