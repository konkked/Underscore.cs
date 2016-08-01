using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
	public class AttributeComponent : IAttributeComponent
	{
		private readonly Func<object, IEnumerable<Attribute>> _getAttributes;
		
		public AttributeComponent(ICacheComponent cacheComponent)
		{
			_getAttributes = cacheComponent.Memoize<object, IEnumerable<Attribute>>(GetCustomAttributesImpl);
		}

		private IEnumerable<Attribute> GetCustomAttributesImpl(object obj)
		{
			if (obj == null) return new Attribute[] { };

			var typeOf = obj.GetType();

			if (typeof(MemberInfo).IsAssignableFrom(typeOf))
			{
				return ((MemberInfo)obj).GetCustomAttributes(true).Select(a => (Attribute)a);
			}

			if (obj is Type)
			{
				return ((Type)obj).GetCustomAttributes(true).Select(a => (Attribute)a);
			}

			return obj.GetType().GetCustomAttributes(true).Select(a => (Attribute)a);
		}

		public bool Has<TAttribute>(object value) where TAttribute : Attribute
		{
			return _getAttributes(value)
						.OfType<TAttribute>().Any();
		}

		public TAttribute Find<TAttribute>(object value) where TAttribute : Attribute
		{
			return _getAttributes(value)
						.OfType<TAttribute>().FirstOrDefault();
		}

		public IEnumerable<TAttribute> All<TAttribute>(object value) where TAttribute : Attribute
		{
			return _getAttributes(value)
						.OfType<TAttribute>();
		}
	}
}
