using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Object.Reflection;
using Underscore.Utility;

namespace Underscore.Object
{
    public class TransposeComponent : ITransposeComponent
    {
        private readonly IPropertyComponent _property;

        public TransposeComponent( IPropertyComponent property ) 
        {
            _property = property;
        }

        private PropertyInfo FindBestPropertyReferenceMatch( PropertyInfo destination, IEnumerable<PropertyInfo> possibleMatches )
        {
            PropertyInfo result = null;

            foreach ( var possibleMatch in possibleMatches )
            {
                if ( destination.PropertyType == possibleMatch.PropertyType )
                    return possibleMatch;

                //is assignable to
                if ( destination.PropertyType.IsAssignableFrom( possibleMatch.PropertyType )
                    && ( result == null || (
                    result.PropertyType.IsAssignableFrom( possibleMatch.PropertyType )
                    && !possibleMatch.PropertyType.IsAssignableFrom( result.PropertyType )
                    ) )
                )
                    result = possibleMatch;
            }

            return result;
        }

        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        public void Transpose( object source , object destination )
        {
            var dst = _property.All( destination );
            var src = _property.All( source );

            var allMatches = from d in dst
                             join s in src on d.Name equals s.Name into matchGroups
                             select new { Destination = d, PossibleMatches = matchGroups };

            foreach ( var matches in allMatches )
            {
                var destProp = matches.Destination;
                var srcProp = FindBestPropertyReferenceMatch( destProp, matches.PossibleMatches );

                if ( srcProp != null && srcProp.GetValue( source ) != null )
                    destProp.SetValue( destination, srcProp.GetValue( source ) );

            }

        }
    
    }
}
