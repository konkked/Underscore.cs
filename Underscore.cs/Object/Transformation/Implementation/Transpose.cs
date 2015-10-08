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


        private void CoalesceImpl( object first , object second ) 
        {
            var allMatches = from d in _property.All( first ).Select( a => new { a.Name , Value = a.GetMethod.Invoke( first , null ) , a } ).Where( a => a.Value == null )
                             join s in _property.All( second ).Select( a => new { a.Name , Value = a.GetMethod.Invoke( second , null ), a } ).Where( a => a.Value != null )
                                on d.Name equals s.Name into matchGroups
                             select new { Dest = d , PossibleMatches = matchGroups };

            foreach ( var matches in allMatches ) 
            {
                var to = matches.Dest.a;
                var from = FindBestPropertyReferenceMatch( to , matches.PossibleMatches.Select( a => a.a ) );

                if ( from != null )
                    to.SetMethod.Invoke( first , new object[ ] { from.GetMethod.Invoke( second , null ) } );
            }


        }

        public TFirst Coalesce<TFirst>( TFirst first , object second )
        {
            CoalesceImpl( first , second );
            return first;
        }

        public TFirst Coalesce<TFirst>( TFirst first , object second , bool newObject ) where TFirst : new( )
        {
            TFirst returning = newObject ? Coalesce( new TFirst( ) , first ) : first;
            return Coalesce( returning , second );
        }
    }
}
