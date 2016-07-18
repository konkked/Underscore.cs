using System;
using System.Collections.Generic;
using System.Linq;

namespace Underscore.Utility
{
	public class ObjectComponent : IObjectComponent
	{
		/// <summary>
		/// Returns true if an object is truthy,
		/// if the value is not the default
		/// value of the that type then returns true
		/// with the exception of strings 
		/// which return false if empty, whitespace or null
		/// </summary>
		public bool IsTruthy(object target)
		{
			if (target == null)
				return false;

			var s = target as string;
			if (s != null)
				return !string.IsNullOrWhiteSpace(s);
			
			if (IsNumber(target) )
			{
				var result = Convert.ToDecimal(target);
				result = decimal.Ceiling(result);
				var intResult = decimal.ToInt32(result);

				return intResult != 0;
			}
			
			if (target is bool) 
			{
				return (bool) target;
			}

			if (target is IEnumerable<object>)
			{
				return ((IEnumerable<object>) target).Any();
			}

			// if the type is a reference type then the default is null
			// if is value type will pass with stmt
			return 
				//otherwise is a value type or is a class type with a value
				(
					//if it is a class type, then done
					!target.GetType().IsValueType ||
					//otherwise check and see if the default for the value type is
					//the value of the passed object
					target != Activator.CreateInstance(target.GetType())
			   );
		}

		private bool IsNumber(object o)
		{
			return (o is int) ||
				   (o is uint) ||
				   (o is decimal) ||
				   (o is double) ||
				   (o is long) ||
				   (o is ulong);
		}
	}
}
