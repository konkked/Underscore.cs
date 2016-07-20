using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
	public class MethodComponent : MethodsBaseComponent<MethodInfo>, IMethodComponent
	{
		private static HashSet<string> s_specialRules;
		private readonly IPropertyComponent _property;

		private static Members<MethodInfo> Members
		{
			get
			{
				return new Members<MethodInfo>(
								a => !a.IsConstructor && !a.IsSpecialName,
								BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance
							);
			}
		}

		public MethodComponent()
			: base(new CacheComponent(), new PropertyComponent(), Members)
		{
			if (s_specialRules == null)
				InitSpecialRules();

			_property = new PropertyComponent();
		}

		//Initializes special rules for the query method
		private static void InitSpecialRules()
		{
			s_specialRules = new HashSet<string> { "return" };
		}

		public MethodComponent(Function.ICacheComponent cacher, IPropertyComponent property)
			: base(cacher, property, Members)
		{
			_property = property;
		}


		/// <summary>
		///     Searches for the methods of <paramref name="target"> </paramref>
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		public override IEnumerable<MethodInfo> All(Type target)
		{
			return _collection.All(target);
		}

		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>'s <see cref="Type"></see>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public override IEnumerable<MethodInfo> All(object target, BindingFlags flags)
		{
			return _collection.All(target, flags);
		}

		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The Type whose methods are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public override IEnumerable<MethodInfo> All(Type target, BindingFlags flags)
		{
			return _collection.All(target, flags);
		}

		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		public override IEnumerable<MethodInfo> All(object target)
		{
			return _collection.All(target);
		}

		protected override bool IsSpecialCase(string name)
		{
			return s_specialRules.Contains(name);
		}

		protected override IEnumerable<MethodInfo> FilterSpecialCase(string name, object value,
			IEnumerable<MethodInfo> current)
		{

			if (!IsSpecialCase(name))
				throw new InvalidOperationException("Not a special case query rule");

			if (name == "return")
			{
				if (!(value is Type))
				{
					//check for the property parameterType
					if (!_property.Has(value, "parameterType"))
					{
						throw new InvalidOperationException(
							"@return is a special query property, if you need to override it, assign it an object with the property 'propertyType' containing the type of the parameter '@return' you're expecting a method / constructor to have to satisy");
					}

					var ntype = _property.GetValue<Type>(value, "parameterType");
					return
						current.Where(
							a =>
								a.GetParameters().FirstOrDefault(b => b.Name == "return" && b.ParameterType == ntype) !=
								null);
				}

				var lookingFor = (Type)value;
				return current.Where(a => a.ReturnType == lookingFor);

			}

			return current;
		}

		private MethodInfo CaseSensitiveGetMethod(object target, string name)
		{
			return All(target).FirstOrDefault(t => t.Name == name);
		}

		private MethodInfo CaseInsensitiveGetMethod(object target, string name)
		{
			var lname = name.ToLowerInvariant();
			return All(target).FirstOrDefault(a => a.Name.ToLowerInvariant() == lname);
		}



		/// <summary>
		/// Returns first method info of the specfied target that has the specified name
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name)
		{
			return Find(target, name, true);
		}


		/// <summary>
		/// Returns first method info of the specfied target that has the specified name
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Indicates if the search should only match when name cases match</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name, bool caseSensitive)
		{
			if (caseSensitive)
				return CaseSensitiveGetMethod(target, name);

			return CaseInsensitiveGetMethod(target, name);
		}


		/// <summary>
		/// Returns first method info of the specfied target that matches query request pattern and matches specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="query">The query request pattern object used to modify the search</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name, object query)
		{

			if (query == null)
				query = new { };

			return Query(target, query)
				.FirstOrDefault(a => a.Name == name);
		}


		/// <summary>
		/// Returns true if the specfied target has a method with the specified name.
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		public bool Has(object target, string name)
		{
			return Find(target, name, true) != null;
		}



		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query request pattern object used to modify the search</param>
		/// <param name="name">The name of the method testing for</param>
		public bool Has(Type target, string name, object query)
		{
			return Find(target, name, query) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query request pattern object used to modify the search</param>
		public bool Has(Type target, object query)
		{
			return Find(target, query) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method with the specified name.
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="name">The name of the method testing for</param>
		public bool Has(Type target, string name)
		{
			return Find(target, name) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="query">The query object</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(object target, string name, object query, BindingFlags flags)
		{
			return Find(target, name, query, flags) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="query">The query object</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(object target, object query, BindingFlags flags)
		{
			return Find(target, query, flags) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches the specified name.
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(object target, string name, BindingFlags flags)
		{
			return Find(target, name, flags) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query object</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(Type target, string name, object query, BindingFlags flags)
		{
			return Find(target, name, query, flags) != null;
		}

		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query object</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(Type target, object query, BindingFlags flags)
		{
			return Find(target, query, flags) != null;
		}

		/// <summary>
		/// Returns true if the specfied target has a method that has the specified name.
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		public bool Has(Type target, string name, BindingFlags flags)
		{
			return Find(target, name, flags) != null;
		}

		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The type whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>All methods that match the query passed that match the provided flags</returns>
		public override IEnumerable<MethodInfo> Query(Type target, object query, BindingFlags flags)
		{
			return base.Query(target, query);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="caseSenstive">Indicates if the match should only happen if the name cases match</param>
		/// <returns>All methods that match the query passed with the specified name</returns>
		public IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive)
		{
			return Query(target.GetType(), query, name);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The type whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="caseSenstive">Indicates if the match should only happen if the name cases match</param>
		/// <returns>All methods that match the query passed with the specified name</returns>
		public IEnumerable<MethodInfo> Query(Type target, object query, string name, bool caseSenstive)
		{
			var lcname = name.ToLower();
			return caseSenstive
				? base.Query(target, query).Where(a => a.Name == name)
				: base.Query(target, query).Where(a => a.Name.ToLower() == lcname);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="caseSenstive">Indicates if the match should only happen if the name cases match</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>All methods that match the query passed with the specified name and match the provided flags</returns>
		public IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive, BindingFlags flags)
		{
			return Query(target.GetType(), query, name, caseSenstive, flags);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The type whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="caseSenstive">Indicates if the match should only happen if the name cases match</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>All methods that match the query passed with the specified name and match the provided flags</returns>
		public IEnumerable<MethodInfo> Query(Type target, object query, string name, bool caseSenstive, BindingFlags flags)
		{
			var lcname = name.ToLower();
			return caseSenstive
				? base.Query(target, query, flags).Where(a => a.Name == name)
				: base.Query(target, query, flags).Where(a => a.Name.ToLower() == lcname);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <returns>All methods that match the query passed with the specified name</returns>
		public IEnumerable<MethodInfo> Query(object target, object query, string name)
		{
			return Query(target.GetType(), query, name);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The type whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <returns>All methods that match the query passed with the specified name </returns>
		public IEnumerable<MethodInfo> Query(Type target, object query, string name)
		{
			return base.Query(target, query).Where(a => a.Name == name);
		}


		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>All methods that match the query passed with the specified name and match the provided flags</returns>
		public IEnumerable<MethodInfo> Query(object target, object query, string name, BindingFlags flags)
		{
			return Query(target.GetType(), query, name, flags);
		}

		/// <summary>
		/// Returns all methods of the specified target that match the specified query pattern object and name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The type whose methods are being searched</param>
		/// <param name="query">The query pattern object used to modify the search </param>
		/// <param name="name">The name of the methods being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		/// <returns>All methods that match the query passed with the specified name and match the provided flags</returns>
		public IEnumerable<MethodInfo> Query(Type target, object query, string name, BindingFlags flags)
		{
			return base.Query(target, query, flags).Where(a => a.Name == name);
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The result of the invocations</returns>
		public object Invoke(object target, string name, BindingFlags flags)
		{
			var method = Find(target, name, new { }, flags);

			if (method != null)
				return method.Invoke(target, null);

			return null;
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		public object Invoke(object target, string name)
		{
			var method = Find(target, name, new { });

			if (method != null)
				return method.Invoke(target, null);

			return null;
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The result of the invocations</returns>
		public T Invoke<T>(object target, string name, BindingFlags flags)
		{
			var method = Query(target, new { }, name, flags).FirstOrDefault(a => a.ReturnType == typeof(T));

			if (method != null)
				return (T)method.Invoke(target, null);

			return default(T);
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		public T Invoke<T>(object target, string name)
		{
			var method = Query(target, new { }, name).FirstOrDefault(a => a.ReturnType == typeof(T));

			if (method != null)
				return (T)method.Invoke(target, null);

			return default(T);
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The result of the invocations</returns>
		public object Invoke(object target, string name, BindingFlags flags, params object[] arguments)
		{
			var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

			var method = Find(target, name, typeArrayPassing, flags);

			if (method != null)
				return method.Invoke(target, arguments);

			return null;
		}


		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		public object Invoke(object target, string name, params object[] arguments)
		{
			var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

			var method = Find(target, name, typeArrayPassing);

			if (method != null)
				return method.Invoke(target, arguments);

			return null;
		}

		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The result of the invocations</returns>
		public T Invoke<T>(object target, string name, BindingFlags flags, params object[] arguments)
		{
			var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

			var method = Query(target, typeArrayPassing, name, flags).FirstOrDefault(a => a.ReturnType == typeof(T));

			if (method != null)
				return (T)method.Invoke(target, arguments);

			return default(T);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The results of the invocations</returns>
		public T Invoke<T>(object target, string name, params object[] arguments)
		{
			var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

			var method = Query(target, typeArrayPassing, name).FirstOrDefault(a => a.ReturnType == typeof(T));

			if (method != null)
				return (T)method.Invoke(target, arguments);

			return default(T);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets)
		{
			return InvokeForAll(target, name, flags, argumentSets, false);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets)
		{
			return InvokeForAll(target, name, argumentSets, false);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets)
		{
			return InvokeForAll<T>(target, name, flags, argumentSets, false);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets)
		{
			return InvokeForAll<T>(target, name, argumentSets, false);
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy)
		{
			var returning = argumentSets.Select(argumentSet => Invoke(target, name, flags, argumentSet));

			return greedy ? returning.ToList() : returning;
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets, bool greedy)
		{
			var returning = argumentSets.Select(argumentSet => Invoke(target, name, argumentSet));

			return greedy ? returning.ToList() : returning;
		}


		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which methods to invoke
		/// </param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy)
		{
			var returning = argumentSets.Select(argumentSet => Invoke<T>(target, name, flags, argumentSet));

			return greedy ? returning.ToList() : returning;
		}

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <returns>The results of the invocations</returns>
		public IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets, bool greedy)
		{
			var returning = argumentSets.Select(argumentSet => Invoke<T>(target, name, argumentSet));

			return greedy ? returning.ToList() : returning;
		}


		/// <summary>
		/// Returns first method info of the specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="query">The query object to specify how search is conducted</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, object query)
		{
			return Query(target, query).FirstOrDefault();
		}



		/// <summary>
		/// Returns first method info of the specfied target that matches query request pattern and matches specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Indicates if the search should only match if name casing is exact</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			return Find(target.GetType(), name, caseSensitive, flags);
		}


		/// <summary>
		/// Returns first method info of the specfied target that matches query request pattern and matches specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name"></param>
		/// <param name="query">The query object to specify how search is conducted</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name, object query, BindingFlags flags)
		{
			return Find(target.GetType(), name, query, flags);
		}




		/// <summary>
		/// Returns the first method target has a method that matches the specified name.
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, string name, BindingFlags flags)
		{
			return Find(target.GetType(), name, flags);
		}


		/// <summary>
		/// Returns the first method info of the specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="query">The query object to specify how search is conducted</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, object query, BindingFlags flags)
		{
			return Find(target.GetType(), query, flags);
		}


		/// <summary>
		/// Returns the first method info of the specfied target that matches the specified name.
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Indicates if the search should only match if name casing is exact</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
		{
			var lcname = name.ToLower();
			return caseSensitive
				? All(target, flags).FirstOrDefault(a => a.Name == name)
				: All(target, flags).FirstOrDefault(a => a.Name.ToLower() == lcname);
		}


		/// <summary>
		/// Returns the first method info of specfied target that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="query">The query object to specify how search is conducted</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name, object query, BindingFlags flags)
		{
			return base.Query(target, query ?? new {}, flags).FirstOrDefault(a => a.Name == name);
		}


		/// <summary>
		/// Returns the first method in specfied target that has the specified name.
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name, BindingFlags flags)
		{
			return All(target, flags).FirstOrDefault(a => a.Name == name);
		}

		/// <summary>
		/// Returns the first method in specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="query">Query object used to specify how search is conducted</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, object query, BindingFlags flags)
		{
			return base.Query(target, query ?? new {}, flags).FirstOrDefault();
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="query">The query object</param>
		public bool Has(object target, string name, object query)
		{
			return Find(target, name, query) != null;
		}


		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="query">The query object</param>
		public bool Has(object target, object query)
		{
			return Find(target, query) != null;
		}

		/// <summary>
		/// Returns the first method in specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="query">Query object used to specify how search is conducted</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(object target, object query)
		{
			return Query(target, query).FirstOrDefault();
		}

		/// <summary>
		/// Returns the first method in specified target that matches specified name
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Specifies if the search</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name, bool caseSensitive)
		{
			var lcname = name.ToLower();
			return (caseSensitive
				? All(target).Where(a => a.Name == name)
				: All(target).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
		}

		/// <summary>
		/// Returns the first method in specfied target with specified name
		/// and that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="query">Query object used to specify how search is conducted</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name, object query)
		{
			return base.Query(target, query).FirstOrDefault(a => a.Name == name);
		}

		/// <summary>
		/// Returns the first method in specfied target with specified name
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		public MethodInfo Find(Type target, string name)
		{
			return All(target).FirstOrDefault(a => a.Name == name);
		}
	}
}