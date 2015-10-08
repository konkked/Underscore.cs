using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Module
{

    public class Object : ITransposeComponent, IDynamicComponent
    {
        private readonly IPropertyComponent _property;
        private readonly IMethodComponent _method;
        private readonly IFieldComponent _field;
        private readonly ITransposeComponent _transformation;
        private readonly IConstructorComponent _constructor;
        private readonly IAttributeComponent _attribute;
        private readonly IDynamicComponent _dynamic;


        public Object(
            IPropertyComponent property,
            IMethodComponent method,
            IFieldComponent field,
            IConstructorComponent constructor,
            ITransposeComponent transformation,
            IAttributeComponent attribute,
            IDynamicComponent dynamicComponent) 
        {
            _property = property;
            _field = field;
            _method = method;
            _transformation = transformation;
            _constructor = constructor;
            _attribute = attribute;
            _dynamic = dynamicComponent;
        }

 
        /// <summary>
        /// Returns null, useful for anonymous type declarations to avoid having to cast null to an object
        /// </summary>
        public T Null<T>() where T : class
        {
            return null;
        }

        public IPropertyComponent Property { get { return _property; } }

        public IFieldComponent Field { get { return _field; } }

        public IMethodComponent Method { get { return _method; } }

        public IAttributeComponent Attribute { get { return _attribute;  } }

        public IConstructorComponent Constructor { get { return _constructor; } }


        public void Transpose( object source , object destination )
        {
            _transformation.Transpose( source , destination );
        }

        public TFirst Coalesce<TFirst>( TFirst first , object second )
        {
            return _transformation.Coalesce( first , second );
        }

        public TFirst Coalesce<TFirst>( TFirst first , object second , bool newObject ) where TFirst : new( )
        {
            return _transformation.Coalesce( first , second , newObject );
        }

        public dynamic ToDynamic( object target )
        {
            return _dynamic.ToDynamic( target );
        }
    }
}
