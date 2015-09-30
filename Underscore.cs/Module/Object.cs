using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Module
{

    public class Object 
    {
        private readonly IPropertyComponent _property;
        private readonly IMethodComponent _method;
        private readonly IFieldComponent _field;
        private readonly ITransposeComponent _transformation;
        private readonly IConstructorComponent _constructor;


        public Object(
            IPropertyComponent property,
            IMethodComponent method,
            IFieldComponent field,
            IConstructorComponent constructor,
            ITransposeComponent transformation) 
        {
            _property = property;
            _field = field;
            _method = method;
            _transformation = transformation;
            _constructor = constructor;
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

        public void Transpose(object source, object destination)
        {
            _transformation.Transpose( source , destination );
        }

        public IConstructorComponent Constructor { get { return _constructor; } }

    }
}
