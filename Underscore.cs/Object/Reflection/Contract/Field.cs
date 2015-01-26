using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public interface IFieldComponent
    {
        /// <summary>
        /// Finds a public field by name
        /// </summary>
        FieldInfo Find( object target, string name, bool caseSensitive );
        
        /// <summary>
        /// Finds a public field by name
        /// </summary>
        FieldInfo Find( object target, string name );


        /// <summary>
        /// Finds a public field by name
        /// </summary>
        FieldInfo Find( object target, string name, Type type );

        /// <summary>
        /// Returns true if a public field exists for the specified criteria
        /// </summary>
        bool Has( object target, string name, Type type );

        /// <summary>
        /// Returns true if a public field exists for the specified criteria
        /// </summary>
        bool Has( object target, string name, bool caseSensitive );

        /// <summary>
        /// Returns true if a public field exists for the specified criteria
        /// </summary>
        bool Has( object target, string name );

        /// <summary>
        /// Retrieves all fields from the targeted object
        /// </summary>
        IEnumerable<FieldInfo> All(object target);

        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>
        IEnumerable<FieldInfo> OfType(object target, Type type);

    }
}