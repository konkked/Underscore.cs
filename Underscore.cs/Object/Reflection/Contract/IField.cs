using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
	public interface IFieldComponent
	{
		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The object whose class is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="caseSensitive">Is true when exact match is needed</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, bool caseSensitive);

		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The object whose class is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name);

		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The Type  that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name);

		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The Type  that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, bool caseSensitive);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, Type type);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, Type type, bool caseSensitive);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The Type that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, Type type);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, Type type, bool caseSensitive);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		bool Has(object target, string name);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="name">The name of the field being searched for</param>
		bool Has(object target, string name, bool caseSensitive);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		bool Has(Type target, string name);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		bool Has(Type target, string name, bool caseSensitive);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of field being searched for</param>
		bool Has(object target, string name, Type type);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		bool Has(object target, string name, Type type, bool caseSensitive);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		bool Has(Type target, string name, Type type);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		bool Has(Type target, string name, Type type, bool caseSensitive);

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The object whose properties are being returned</param>
		IEnumerable<FieldInfo> All(object target);

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The Type whose properties are being returned</param>
		IEnumerable<FieldInfo> All(Type target);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		IEnumerable<FieldInfo> OfType(object target, Type type);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		IEnumerable<FieldInfo> OfType(Type target, Type type);

		/// <summary>
		/// Returns all of the values of public instance fields
		/// </summary>
		/// <param name="target">The object whose fields' values are being returned</param>
		IEnumerable<object> Values(object target);

		/// <summary>
		/// Returns all of the values of public instance fields of a specific type
		/// </summary>
		/// <typeparam name="T">The type that the values are being filtered on</typeparam>
		/// <param name="target">The object whose fields' values are being returned</param>
		IEnumerable<T> Values<T>(object target);

		/// <summary>
		/// Finds a public instance field by name 
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name 
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name 
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name 
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, Type type, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(object target, string name, Type type, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, Type type, BindingFlags flags);

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		FieldInfo Find(Type target, string name, Type type, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type object fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(object target, string name, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(object target, string name, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(Type target, string name, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(Type target, string name, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The Type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(object target, string name, Type type, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="type">The Type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(object target, string name, Type type, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The Type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(Type target, string name, Type type, BindingFlags flags);

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="type">The Type of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(Type target, string name, Type type, bool caseSensitive, BindingFlags flags);

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The object whose properties are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<FieldInfo> All(object target, BindingFlags flags);

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The Type whose properties are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<FieldInfo> All(Type target, BindingFlags flags);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<FieldInfo> OfType(object target, Type type, BindingFlags flags);

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<FieldInfo> OfType(Type target, Type type, BindingFlags flags);

		/// <summary>
		/// Returns all of the values of public instance fields
		/// </summary>
		/// <param name="target">The object whose fields' values are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<object> Values(object target, BindingFlags flags);

		/// <summary>
		/// Returns all of the values of public instance fields of a specific type
		/// </summary>
		/// <typeparam name="T">The type that the values are being filtered on</typeparam>
		/// <param name="target">The object whose fields' values are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<T> Values<T>(object target, BindingFlags flags);
	}
}