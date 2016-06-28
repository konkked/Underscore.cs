using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public class FieldComponent : IFieldComponent
    {
        private readonly Members<FieldInfo> _fields;

        public FieldComponent()
        {
            _fields = new Members<FieldInfo>( 
                null, 
                BindingFlags.Public | BindingFlags.Instance
            );

        }

        /// <summary>
        /// Retrieves all fields from the targeted type
        /// </summary>
        public IEnumerable<FieldInfo> All( object target )
        {
            return All(target.GetType());
        }

        public IEnumerable<FieldInfo> All(Type target)
        {
            return _fields.All(target);
        }

        /// <summary>
        /// Finds all fields of a specific type
        /// </summary>
        public IEnumerable<FieldInfo> OfType( object target, Type type ) 
        {
            return OfType(target.GetType(),type);
        }

        public IEnumerable<FieldInfo> OfType(Type target, Type type)
        {
            return _fields.All(target).Where(a => a.FieldType == type);
        }

        public IEnumerable<object> Values(object target)
        {
            return All(target).Select(a => a.GetValue(target));
        }


        public IEnumerable<T> Values<T>(object target)
        {
            return OfType(target,typeof(T)).Select(a => (T)a.GetValue(target));
        }

        public FieldInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            return Find(target.GetType(), name,  caseSensitive, flags);
        }

        public FieldInfo Find(object target, string name, BindingFlags flags)
        {
            return Find(target.GetType(), name, flags);
        }

        public FieldInfo Find(Type target, string name, BindingFlags flags)
        {
            return Find(target, name, true,  flags);
        }

        public FieldInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
        {
            var lcname = name.ToLower();
            return (caseSensitive
                ? All(target, flags).Where(a => a.Name == name)
                : All(target, flags).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
        }

        public FieldInfo Find(object target, string name, Type type, BindingFlags flags)
        {
            return Find(target.GetType(), name, type,  flags);
        }

        public FieldInfo Find(object target, string name, Type type, bool caseSensitive, BindingFlags flags)
        {
            return Find(target.GetType(), name, type, caseSensitive, flags);
        }

        public FieldInfo Find(Type target, string name, Type type, BindingFlags flags)
        {
            return Find(target, name, type, true, flags);
        }

        public FieldInfo Find(Type target, string name, Type type, bool caseSensitive, BindingFlags flags)
        {
            var lcname = name.ToLower();
            return (caseSensitive
                ? OfType(target, type, flags).Where(a => a.Name == name)
                : OfType(target, type, flags).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
        }

        public bool Has(object target, string name, BindingFlags flags)
        {
            return Find(target, name,  flags) != null;
        }

        public bool Has(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            return Find(target, name, caseSensitive, flags) != null;
        }

        public bool Has(Type target, string name, BindingFlags flags)
        {
            return Find(target, name, flags) != null;
        }

        public bool Has(Type target, string name, bool caseSensitive, BindingFlags flags)
        {
            return Find(target, name, caseSensitive, flags) != null;
        }

        public bool Has(object target, string name, Type type, BindingFlags flags)
        {
            return Find(target, name, type, flags) != null;
        }

        public bool Has(object target, string name, Type type, bool caseSensitive, BindingFlags flags)
        {
            return Find(target, name, type,caseSensitive, flags) != null;
        }

        public bool Has(Type target, string name, Type type, BindingFlags flags)
        {
            return Find(target, name, type, flags) != null;
        }

        public bool Has(Type target, string name, Type type, bool caseSensitive, BindingFlags flags)
        {
            return Find(target, name, type, caseSensitive, flags) != null;
        }

        public IEnumerable<FieldInfo> All(object target, BindingFlags flags)
        {
            return _fields.All(target, flags);
        }

        public IEnumerable<FieldInfo> All(Type target, BindingFlags flags)
        {
            return _fields.All(target, flags);
        }

        public IEnumerable<FieldInfo> OfType(object target, Type type, BindingFlags flags)
        {
            return _fields.All(target, flags).Where(a => a.FieldType == type);
        }

        public IEnumerable<FieldInfo> OfType(Type target, Type type, BindingFlags flags)
        {
            return _fields.All(target, flags).Where(a => a.FieldType == type);
        }

        public IEnumerable<object> Values(object target, BindingFlags flags)
        {
            return All(target, flags).Select(a => a.GetValue(target));
        }

        public IEnumerable<T> Values<T>(object target, BindingFlags flags)
        {
            return OfType(target, typeof (T), flags).Select(a => (T) a.GetValue(target));
        }

        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string name, bool caseSensitive )
        {
            return Find(target.GetType(), name, caseSensitive);
        }


        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string field )
        {
            return Find( target, field, true );
        }

        public FieldInfo Find(Type target, string name)
        {
            return Find(target, name, true);
        }

        public FieldInfo Find(Type target, string name, bool caseSensitive)
        {
            var lcname = name.ToLower();
            return (caseSensitive
                ? All(target).Where(a => a.Name == name)
                : All(target).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
        }


        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string name, Type type )
        {
            return OfType( target, type ).FirstOrDefault( a => a.Name == name );
        }

        public FieldInfo Find(object target, string name, Type type, bool caseSensitive)
        {
            return Find(target.GetType(), name, type, caseSensitive);
        }

        public FieldInfo Find(Type target, string name, Type type)
        {
            return Find(target, name, type, true);
        }

        public FieldInfo Find(Type target, string name, Type type, bool caseSensitive)
        {
            var lcname = name.ToLower( );
            return ( caseSensitive
                ? All( target ).Where( a => a.Name == name )
                : All( target ).Where( a => a.Name.ToLower() == lcname )
            ).FirstOrDefault(a => a.FieldType == type);
        }


        /// <summary>
        /// Returns true if the field searching for exists in item
        /// </summary>
        public bool Has( object target, string name )
        {
            return Has( target, name, true );
        }

        /// <summary>
        /// Returns true if the field searching for exists in item
        /// </summary>
        public bool Has( object target, string name, bool caseSensitive )
        {

            return Find(target, name, caseSensitive) != null;
        }


        public bool Has(Type target, string name, Type type, bool caseSensitive)
        {
            return Find(target, name, type, caseSensitive) != null;
        }


        public bool Has(Type target, string name)
        {
            return Find(target, name) != null;
        }

        public bool Has(Type target, string name, bool caseSensitive)
        {
            return Find(target, name, caseSensitive) != null;
        }


        /// <summary>
        /// Returns true if the field searching for exists in item
        /// </summary>
        public bool Has( object target, string name, Type type )
        {
            return Find( target, name, type ) != null;
        }

        public bool Has(object target, string name, Type type, bool caseSensitive)
        {
            return Find(target, name, type, caseSensitive) != null;
        }

        public bool Has(Type target, string name, Type type)
        {
            return Find(target, name, type) != null;
        }




    }
}