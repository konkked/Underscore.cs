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

		FieldInfo Find(Type target, string name);
		FieldInfo Find(Type target, string name, bool caseSensitive);


		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find( object target, string name, Type type );
		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(object target, string name, Type type, bool caseSensitive);


		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(Type target, string name, Type type);
		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(Type target, string name, Type type, bool caseSensitive);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, bool caseSensitive);



		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, bool caseSensitive);



		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has( object target, string name, Type type );


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, Type type, bool caseSensitive);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, Type type);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, Type type, bool caseSensitive);


		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> All(object target);


		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> All(Type target);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> OfType(object target, Type type);


		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> OfType(Type target, Type type);

		IEnumerable<object> Values(object target);

		IEnumerable<T> Values<T>(object target);



		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(object target, string name, BindingFlags flags);

		FieldInfo Find(Type target, string name, BindingFlags flags);
		FieldInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(object target, string name, Type type, BindingFlags flags);
		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(object target, string name, Type type, bool caseSensitive, BindingFlags flags);


		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(Type target, string name, Type type, BindingFlags flags);
		/// <summary>
		/// Finds a public field by name
		/// </summary>
		FieldInfo Find(Type target, string name, Type type, bool caseSensitive, BindingFlags flags);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, bool caseSensitive, BindingFlags flags);



		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, bool caseSensitive, BindingFlags flags);



		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, Type type, BindingFlags flags);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(object target, string name, Type type, bool caseSensitive, BindingFlags flags);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, Type type, BindingFlags flags);


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		bool Has(Type target, string name, Type type, bool caseSensitive, BindingFlags flags);


		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> All(object target, BindingFlags flags);


		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> All(Type target, BindingFlags flags);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> OfType(object target, Type type, BindingFlags flags);


		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		IEnumerable<FieldInfo> OfType(Type target, Type type, BindingFlags flags);

		IEnumerable<object> Values(object target, BindingFlags flags);

		IEnumerable<T> Values<T>(object target, BindingFlags flags);

	}
}