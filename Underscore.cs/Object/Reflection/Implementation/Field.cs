using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public class FieldComponent : IFieldComponent
    {
        private readonly Members<FieldInfo> _fields;
 

        public FieldComponent(Function.ICacheComponent cacher)
        {
            _fields = new Members<FieldInfo>( 
                cacher, 
                null, 
                BindingFlags.Public | BindingFlags.Instance
            );

        }

        /// <summary>
        /// Retrieves all fields from the targeted type
        /// </summary>
        public IEnumerable<FieldInfo> All( object target ) 
        {
            return _fields.All( target.GetType() );
        }

        /// <summary>
        /// Finds all fields of a specific type
        /// </summary>
        public IEnumerable<FieldInfo> OfType( object target, Type type ) 
        {
            return _fields.All( target.GetType()).Where(a=> a.FieldType == type );
        }
        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string name, bool caseSensitive )
        {
            return caseSensitive ?
                CaseSensitiveFieldSearch( target, name ) :
                CaseInsensitiveFieldSearch( target, name );
        }


        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string field )
        {
            return Find( target, field, true );
        }




        /// <summary>
        /// Finds a public field by name
        /// </summary>
        public FieldInfo Find( object target, string name, Type type )
        {
            return OfType( target, type ).FirstOrDefault( a => a.Name == name );
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
            return (
                caseSensitive ? CaseSensitiveFieldSearch( target, name ) : CaseInsensitiveFieldSearch( target, name )
                ) != null;
        }


        /// <summary>
        /// Returns true if the field searching for exists in item
        /// </summary>
        public bool Has( object target, string name, Type type )
        {
            return Find( target, name, type ) != null;
        }

        private FieldInfo CaseInsensitiveFieldSearch( object target, string name )
        {
            var lfieldName = name.ToLowerInvariant( );
            return _fields.All( target ).FirstOrDefault( a => a.Name.ToLowerInvariant( ) == lfieldName );
        }

        private FieldInfo CaseSensitiveFieldSearch( object target, string name )
        {
            return _fields.All( target ).FirstOrDefault( a => a.Name == name );
        }



    }
}