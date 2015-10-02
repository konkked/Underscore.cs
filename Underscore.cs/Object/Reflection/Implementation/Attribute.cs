using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
    public class AttributeComponent : IAttributeComponent
    {

        private readonly Func<object , IEnumerable<System.Attribute>> _getAttributes;

        private IEnumerable<System.Attribute> GetCustomAttributesImpl( object obj )
        {
            if(obj == null) return new System.Attribute[]{};

            var typeOf = obj.GetType();

            

            if ( typeof( MemberInfo ).IsAssignableFrom( typeOf ) )
            {
                return ((MemberInfo)obj).GetCustomAttributes(true).Select(a=>(System.Attribute)a);
            }

            if ( typeof( Type ).IsAssignableFrom( obj.GetType( ) ) )
            {
                return ( (Type)obj ).GetCustomAttributes( true ).Select( a => (System.Attribute)a );
            }

            return obj.GetType( ).GetCustomAttributes( true ).Select( a => (System.Attribute)a );
        }

        public AttributeComponent( ICacheComponent cacheComponent ) 
        {
            _getAttributes = cacheComponent.Memoize<object , IEnumerable<System.Attribute>>( GetCustomAttributesImpl );
        }

        public bool Has<TAttribute>( object value ) where TAttribute : System.Attribute
        {
            return _getAttributes( value )
                        .OfType<TAttribute>( ).Any( );
        }

        public TAttribute Find<TAttribute>( object value ) where TAttribute : System.Attribute
        {
            return _getAttributes( value )
                        .OfType<TAttribute>( ).FirstOrDefault( );
        }

        public IEnumerable<TAttribute> All<TAttribute>( object value ) where TAttribute : System.Attribute
        {
            return _getAttributes( value )
                        .OfType<TAttribute>( );
        }
    }
}
