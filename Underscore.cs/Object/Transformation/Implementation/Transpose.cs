using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Object.Reflection;

namespace Underscore.Object
{
	public class TransposeComponent : ITransposeComponent
	{
		private readonly IPropertyComponent _property;
        
		public TransposeComponent(IPropertyComponent property) 
		{
			_property = property;
		}

		/// <summary>
		/// returns the first property matching destination's type. 
		/// Failing that, returns the last field with its type assignable to destination
		/// </summary>
		private PropertyInfo FindBestPropertyReferenceMatch(PropertyInfo destination, IEnumerable<PropertyInfo> possibleMatches)
		{
			PropertyInfo result = null;

			foreach (var possibleMatch in possibleMatches)
			{
				// if we found something of a matching type return it
				if (destination.PropertyType == possibleMatch.PropertyType)
					return possibleMatch;
				
				// otherwise if possibleMatch can be assigned to destination and result
				var isAssignable = IsAssignableOneWay(destination, possibleMatch)
									&& IsAssignableToResult(result, possibleMatch);

				if (isAssignable)
					result = possibleMatch;
			}

			return result;
		}

		/// <summary>
		/// determines if possibleMatch can be assigned to destination
		/// </summary>
		private bool IsAssignableOneWay(PropertyInfo destination, PropertyInfo possibleMatch)
		{
			return destination.PropertyType.IsAssignableFrom(possibleMatch.PropertyType);
		}

		/// <summary>
		/// determines if the result is either null or only valid for a one-way assignment with possibleMatch
		/// </summary>
		private bool IsAssignableToResult(PropertyInfo result, PropertyInfo possibleMatch)
		{
			return result == null || OnlyAssignableOneWay(result, possibleMatch);
		}

		/// <summary>
		/// determines if possibleMatch is assignable to result but not vice-versa
		/// </summary>
		private bool OnlyAssignableOneWay(PropertyInfo destination, PropertyInfo possibleMatch)
		{
			return IsAssignableOneWay(destination, possibleMatch) &&
					!IsAssignableOneWay(possibleMatch, destination);
		}

		/// <summary>
		/// Takes all of the properties 
		/// from the source object and 
		/// puts them to the destination
		/// </summary>
		public void Transpose(object source, object destination)
		{
			var dest = _property.All(destination);
			var src = _property.All(source);

			var allMatches = from d in dest
							 join s in src on d.Name equals s.Name into matchGroups
							 select new { Destination = d, PossibleMatches = matchGroups };

			foreach (var matches in allMatches)
			{
				var destProp = matches.Destination;
				var srcProp = FindBestPropertyReferenceMatch(destProp, matches.PossibleMatches);

				if (srcProp != null && srcProp.GetValue(source) != null)
					destProp.SetValue(destination, srcProp.GetValue(source));

			}
		}


		private void CoalesceImpl(object first, object second) 
		{
			var allMatches = from d in _property.All(first).Select(a => new { a.Name, Value = a.GetMethod.Invoke(first, null), a }).Where(a => a.Value == null)
							 join s in _property.All(second).Select(a => new { a.Name, Value = a.GetMethod.Invoke(second, null), a }).Where(a => a.Value != null)
								on d.Name equals s.Name into matchGroups
							 select new { Dest = d, PossibleMatches = matchGroups };

			foreach (var matches in allMatches) 
			{
				var to = matches.Dest.a;
				var from = FindBestPropertyReferenceMatch(to, matches.PossibleMatches.Select(a => a.a));

				if (from != null)
					to.SetMethod.Invoke(first, new object[ ] { from.GetMethod.Invoke(second, null) });
			}
		}

		public TFirst Coalesce<TFirst>(TFirst first, object second)
		{
			CoalesceImpl(first, second);
			return first;
		}

		public TFirst Coalesce<TFirst>(TFirst first, object second, bool newObject) where TFirst : new()
		{
			var returning = newObject ? Coalesce(new TFirst(), first) : first;
			return Coalesce(returning, second);
		}
	}
}
