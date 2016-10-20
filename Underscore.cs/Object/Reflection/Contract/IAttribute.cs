using System.Collections.Generic;

namespace Underscore.Object.Reflection
{
	public interface IAttributeComponent
	{
		/// <summary>
		/// Checks to see if an object has an attribute
		/// </summary>
		bool Has<TAttribute>(object value) where TAttribute : System.Attribute;

		/// <summary>
		/// Returns the attribute of specified type from the passed object 
		/// </summary>
		TAttribute Find<TAttribute>(object value) where TAttribute : System.Attribute;

		/// <summary>
		/// Returns all instances of an attribute type from the passed object
		/// </summary>
		IEnumerable<TAttribute> All<TAttribute>(object value) where TAttribute : System.Attribute;
	}
}
