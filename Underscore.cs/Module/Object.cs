using Underscore.Object;
using Underscore.Object.Reflection;

namespace Underscore.Module
{

    //should only be public for testing and debugging purposes

    public class Object 
    {
        private readonly IPropertyComponent _property;
        private readonly IMethodComponent _method;
        private readonly IFieldComponent _field;
        private readonly ITransposeComponent _transformation;


        public Object(
            IPropertyComponent property,
            IMethodComponent method,
            IFieldComponent field,
            ITransposeComponent transformation) 
        {
            _property = property;
            _field = field;
            _method = method;
            _transformation = transformation;
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

        //transformation
        public ITransposeComponent Transpose { get { return _transformation; } }

    }
}
