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
				a=>!a.IsSpecialName&& !a.Name.EndsWith(">k__BackingField"),
				BindingFlags.Public | BindingFlags.Instance
			);
		}

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The object whose properties are being returned</param>
		public IEnumerable<FieldInfo> All(object target)
		{
			return All(target.GetType());
		}

		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The Type whose properties are being returned</param>
		public IEnumerable<FieldInfo> All(Type target)
		{
			return _fields.All(target);
		}

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		public IEnumerable<FieldInfo> OfType(object target, Type type)
		{
			return OfType(target.GetType(), type);
		}


		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The Type whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		public IEnumerable<FieldInfo> OfType(Type target, Type type)
		{
			return _fields.All(target).Where(a => a.FieldType == type);
		}


		/// <summary>
		/// Returns all of the values of public instance fields
		/// </summary>
		/// <param name="target">The object whose fields' values are being returned</param>
		public IEnumerable<object> Values(object target)
		{
			return All(target).Select(a => a.GetValue(target));
		}


		/// <summary>
		/// Returns all of the values of public instance fields of a specific type
		/// </summary>
		/// <typeparam name="T">The type that the values are being filtered on</typeparam>
		/// <param name="target">The object whose fields' values are being returned</param>
		public IEnumerable<T> Values<T>(object target)
		{
			return OfType(target, typeof(T)).Select(a => (T)a.GetValue(target));
		}


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
		public FieldInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			return Find(target.GetType(), name, caseSensitive, flags);
		}


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
		public FieldInfo Find(object target, string name, BindingFlags flags)
		{
			return Find(target.GetType(), name, flags);
		}


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
		public FieldInfo Find(Type target, string name, BindingFlags flags)
		{
			return Find(target, name, true, flags);
		}


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
		public FieldInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
		{
			var lcname = name.ToLower();
			return (caseSensitive
				? All(target, flags).Where(a => a.Name == name)
				: All(target, flags).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
		}


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
		public FieldInfo Find(object target, string name, Type type, BindingFlags flags)
		{
			return Find(target.GetType(), name, type, flags);
		}


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
		public FieldInfo Find(object target, string name, Type type, bool caseSensitive, BindingFlags flags)
		{
			return Find(target.GetType(), name, type, caseSensitive, flags);
		}

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
		public FieldInfo Find(Type target, string name, Type type, BindingFlags flags)
		{
			return Find(target, name, type, true, flags);
		}


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
		public FieldInfo Find(Type target, string name, Type type, bool caseSensitive, BindingFlags flags)
		{
			var lcname = name.ToLower();
			return (caseSensitive
				? OfType(target, type, flags).Where(a => a.Name == name)
				: OfType(target, type, flags).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type object fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(object target, string name, BindingFlags flags)
		{
			return Find(target, name, flags) != null;
		}


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
		public bool Has(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			return Find(target, name, caseSensitive, flags) != null;
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(Type target, string name, BindingFlags flags)
		{
			return Find(target, name, flags) != null;
		}


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
		public bool Has(Type target, string name, bool caseSensitive, BindingFlags flags)
		{
			return Find(target, name, caseSensitive, flags) != null;
		}


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
		public bool Has(object target, string name, Type type, BindingFlags flags)
		{
			return Find(target, name, type, flags) != null;
		}



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
		public bool Has(object target, string name, Type type, bool caseSensitive, BindingFlags flags)
		{
			return Find(target, name, type, caseSensitive, flags) != null;
		}


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
		public bool Has(Type target, string name, Type type, BindingFlags flags)
		{
			return Find(target, name, type, flags) != null;
		}



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
		public bool Has(Type target, string name, Type type, bool caseSensitive, BindingFlags flags)
		{
			return Find(target, name, type, caseSensitive, flags) != null;
		}



		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The object whose properties are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<FieldInfo> All(object target, BindingFlags flags)
		{
			return _fields.All(target, flags);
		}


		/// <summary>
		/// Retrieves all fields from the targeted object
		/// </summary>
		/// <param name="target">The Type whose properties are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<FieldInfo> All(Type target, BindingFlags flags)
		{
			return _fields.All(target, flags);
		}

		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<FieldInfo> OfType(object target, Type type, BindingFlags flags)
		{
			return _fields.All(target, flags).Where(a => a.FieldType == type);
		}


		/// <summary>
		/// Finds all fields of a specific type from the targeted object
		/// </summary>
		/// <param name="target">The object whose fields are being searched</param>
		/// <param name="type">The type of the fields are being filtered on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<FieldInfo> OfType(Type target, Type type, BindingFlags flags)
		{
			return _fields.All(target, flags).Where(a => a.FieldType == type);
		}

		/// <summary>
		/// Returns all of the values of public instance fields
		/// </summary>
		/// <param name="target">The object whose fields' values are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<object> Values(object target, BindingFlags flags)
		{
			return All(target, flags).Select(a => a.GetValue(target));
		}

		/// <summary>
		/// Returns all of the values of public instance fields of a specific type
		/// </summary>
		/// <typeparam name="T">The type that the values are being filtered on</typeparam>
		/// <param name="target">The object whose fields' values are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public IEnumerable<T> Values<T>(object target, BindingFlags flags)
		{
			return OfType(target, typeof(T), flags).Select(a => (T)a.GetValue(target));
		}

		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The object whose class is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="caseSensitive">Is true when exact match is needed</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(object target, string name, bool caseSensitive)
		{
			return Find(target.GetType(), name, caseSensitive);
		}

		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The object whose class is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(object target, string field)
		{
			return Find(target, field, true);
		}


		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The Type  that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(Type target, string name)
		{
			return Find(target, name, true);
		}


		/// <summary>
		/// Finds a public instance field by name
		/// </summary>
		/// <param name="target">The Type  that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(Type target, string name, bool caseSensitive)
		{
			var lcname = name.ToLower();
			return (caseSensitive
				? All(target).Where(a => a.Name == name)
				: All(target).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
		}

		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(object target, string name, Type type)
		{
			return OfType(target, type).FirstOrDefault(a => a.Name == name);
		}



		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(object target, string name, Type type, bool caseSensitive)
		{
			return Find(target.GetType(), name, type, caseSensitive);
		}


		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The Type that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(Type target, string name, Type type)
		{
			return Find(target, name, type, true);
		}



		/// <summary>
		/// Finds a public instance field by name and type
		/// </summary>
		/// <param name="target">The object that is searched for the field</param>
		/// <param name="name">The name of the field that is being searched for</param>
		/// <param name="type">The type of the field that is being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <returns>A FieldInfo of the field who's name matches or null</returns>
		public FieldInfo Find(Type target, string name, Type type, bool caseSensitive)
		{
			var lcname = name.ToLower();
			return (caseSensitive
				? All(target).Where(a => a.Name == name)
				: All(target).Where(a => a.Name.ToLower() == lcname)
			).FirstOrDefault(a => a.FieldType == type);
		}

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		public bool Has(object target, string name)
		{
			return Has(target, name, true);
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		/// <param name="name">The name of the field being searched for</param>
		public bool Has(object target, string name, bool caseSensitive)
		{

			return Find(target, name, caseSensitive) != null;
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		public bool Has(Type target, string name, Type type, bool caseSensitive)
		{
			return Find(target, name, type, caseSensitive) != null;
		}



		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		public bool Has(Type target, string name)
		{
			return Find(target, name) != null;
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		public bool Has(Type target, string name, bool caseSensitive)
		{
			return Find(target, name, caseSensitive) != null;
		}

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of field being searched for</param>
		public bool Has(object target, string name, Type type)
		{
			return Find(target, name, type) != null;
		}


		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The object whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		/// <param name="caseSensitive">Specifies if the search should match only on exact case match</param>
		public bool Has(object target, string name, Type type, bool caseSensitive)
		{
			return Find(target, name, type, caseSensitive) != null;
		}

		/// <summary>
		/// Returns true if a public field exists for the specified criteria
		/// </summary>
		/// <param name="target">The Type whose fields are being search</param>
		/// <param name="name">The name of the field being searched for</param>
		/// <param name="type">The type of the field being searched for</param>
		public bool Has(Type target, string name, Type type)
		{
			return Find(target, name, type) != null;
		}

	}
}