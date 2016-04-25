using System;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object;
using Underscore.Object.Comparison;
using Underscore.Object.Reflection;

namespace Underscore.Module
{

    public class Object : ITransposeComponent, IDynamicComponent, IEqualityComponent
    {
        private readonly IPropertyComponent _property;
        private readonly IMethodComponent _method;
        private readonly IFieldComponent _field;
        private readonly ITransposeComponent _transformation;
        private readonly IConstructorComponent _constructor;
        private readonly IAttributeComponent _attribute;
        private readonly IDynamicComponent _dynamic;
        private readonly IEqualityComponent _equality;


        public Object(
            IPropertyComponent property,
            IMethodComponent method,
            IFieldComponent field,
            IConstructorComponent constructor,
            ITransposeComponent transformation,
            IAttributeComponent attribute,
            IDynamicComponent dynamicComponent, 
            IEqualityComponent equality) 
        {
            
            if (property == null)
                throw new ArgumentNullException("property");

            if (method == null)
                throw new ArgumentNullException("method");

            if (field == null)
                throw new ArgumentNullException("field");

            if (constructor == null)
                throw new ArgumentNullException("constructor");

            if (transformation == null)
                throw new ArgumentNullException("transformation");

            if (attribute == null)
                throw new ArgumentNullException("attribute");

            if (dynamicComponent == null)
                throw new ArgumentNullException("dynamicComponent");

            if (equality == null)
                throw new ArgumentNullException("equality");


            _property = property;
            _field = field;
            _method = method;
            _transformation = transformation;
            _constructor = constructor;
            _attribute = attribute;
            _dynamic = dynamicComponent;
            _equality = equality;
        }

 
        /// <summary>
        /// Returns null, useful ft generor anonymous type declarations to avoid having to cast null to an object
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


        /// <summary>
        /// Creates a new generic type using the default constructor and the passed types as the generic type parameters
        /// </summary>
        /// <param name="genericTypeDefinition"></param>
        /// <param name="genericTypeArguments"></param>
        /// <returns></returns>
        public object NewGenericFromDefinition(Type genericTypeDefinition, params Type[] genericTypeArguments)
        {
            if (!genericTypeDefinition.IsGenericTypeDefinition)
                throw new ArgumentException("Must be a generic type definition", "genericTypeDefinition");

                return Activator.CreateInstance(genericTypeDefinition.MakeGenericType(genericTypeArguments));
        }

        /// <summary>
        /// Creates a new generic type using the best matched constructor and the passed types as the generic type parameters
        /// and the passed objects as the parameters
        /// </summary>
        /// <param name="genericTypeDefinition"></param>
        /// <param name="typeArguments"></param>
        /// <param name="constructorParameter"></param>
        /// <returns></returns>
        public object NewGenericFromDefinition(Type genericTypeDefinition, IEnumerable<Type> typeArguments,
            params object[] constructorParameter)
        {
            if (!genericTypeDefinition.IsGenericTypeDefinition)
                throw new ArgumentException("Must be a generic type definition", "genericTypeDefinition");

            
            var typeArr =  typeArguments as Type[] ?? typeArguments.ToArray();
                   
    
            var gtype = genericTypeDefinition.MakeGenericType(typeArr);

            var queryObj = constructorParameter.Select(a => a == null ? null : a.GetType()).ToArray();

            var constructor = _constructor.Find(gtype, queryObj);

            if(constructor == null)
                throw new ArgumentException("No constructors found matching the parameters passed as possible parameters");

            return constructor.Invoke(constructorParameter);
        }

        public bool AreEquatable(object a, object b)
        {
            return _equality.AreEquatable(a, b);
        }

        public bool AreEquatable(object a, object b, bool typeSensitive)
        {
            return _equality.AreEquatable(a, b, typeSensitive);
        }

        public bool AreEquatable<T>(T a, T b)
        {
            return _equality.AreEquatable(a, b);
        }
    }
}
