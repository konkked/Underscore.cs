using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Underscore.Object.Reflection;

namespace Underscore.Object
{
    public class  DynamicComponent : IDynamicComponent
    {
        private readonly IPropertyComponent _property;

        public DynamicComponent( IPropertyComponent property ) 
        {
            _property = property;
        }


        public dynamic ToDynamic( object value )
        {
            IDictionary<string , object> expando = new ExpandoObject( );

            foreach ( var property in _property.All( value ) )
                expando.Add( property.Name , property.GetValue( value ) );

            return expando as ExpandoObject;
        }
    }
}
