using System;
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

            if (property == null)
                throw new ArgumentNullException(nameof(property));

            if (method == null)
                throw new ArgumentNullException(nameof(method));

            if (field == null)
                throw new ArgumentNullException(nameof(field));

            if (constructor == null)
                throw new ArgumentNullException(nameof(constructor));

            if (transformation == null)
                throw new ArgumentNullException(nameof(transformation));

            if (attribute == null)
                throw new ArgumentNullException(nameof(attribute));

            if (dynamicComponent == null)
                throw new ArgumentNullException(nameof(dynamicComponent));

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

        /// <summary>
        /// Module that contains functionality regarding properties
        /// </summary>
        public IPropertyComponent Property { get { return _property; } }



        /// <summary>
        /// Module that contains functionality regarding fields
        /// </summary>
        public IFieldComponent Field { get { return _field; } }


        /// <summary>
        /// Module that contains functionality regarding methods
        /// </summary>
        public IMethodComponent Method { get { return _method; } }


        /// <summary>
        /// Module that contains functionality regarding attributes
        /// </summary>
        public IAttributeComponent Attribute { get { return _attribute;  } }


        /// <summary>
        /// Module that contains functionality regarding constructors
        /// </summary>
        public IConstructorComponent Constructor { get { return _constructor; } }

        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="destination">The object to take the properties from</param>
        /// <param name="source">The object to put the properties into</param>
        public void Transpose( object source , object destination )
        {
            _transformation.Transpose( source , destination );
        }

        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="first">The object to take the properties from</param>
        /// <param name="second">The object to put the properties into</param>
        public TFirst Coalesce<TFirst>( TFirst first , object second )
        {
            return _transformation.Coalesce( first , second );
        }

        /// <summary>
        /// Takes all of the properties 
        /// from the source object and 
        /// puts them to the destination
        /// </summary>
        /// <param name="first">The object to take the properties from</param>
        /// <param name="second">The object to put the properties into</param>
        /// <param name="newObject">used to indicate if the values should be changed in the first parameter or if a new object should be created</param>
        public TFirst Coalesce<TFirst>( TFirst first , object second , bool newObject ) where TFirst : new( )
        {
            return _transformation.Coalesce( first , second , newObject );
        }

        /// <summary>
        /// Creates a dynamic object
        /// </summary>
        /// <param name="target">the object used to create the dynamic object</param>
        /// <returns>a dynamic object with all of the properties of the passed target object</returns>
        public dynamic ToDynamic( object target )
        {
            return _dynamic.ToDynamic( target );
        }
    }
}
