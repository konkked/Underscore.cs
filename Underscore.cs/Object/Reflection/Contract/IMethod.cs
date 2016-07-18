using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
	public interface IMethodComponent
	{
		/// <summary>
		///     Searches for the methods of <paramref name="target"> </paramref>
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		IEnumerable<MethodInfo> All(Type target);



		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		IEnumerable<MethodInfo> All(object target);



		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The Type whose methods are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<MethodInfo> All(Type target, BindingFlags flags);



		/// <summary>
		///     Searches for the methods of <paramref name="target"></paramref>'s <see cref="Type"></see>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The object whose methods are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		IEnumerable<MethodInfo> All(object target, BindingFlags flags);


		/// <summary>
		/// Returns first method info of the specfied target that has the specified name
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Indicates if the search should only match when name cases match</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find( object target, string name, bool caseSensitive );

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
		MethodInfo Find( object target, string name, object query );



		/// <summary>
		/// Returns first method info of the specfied target that has the specified name
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find( object target, string name );

		/// <summary>
		/// Returns the first method in specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="query">Query object used to specify how search is conducted</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find( object target, object query );


		/// <summary>
		/// Returns the first method in specified target that matches specified name
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <param name="caseSensitive">Specifies if the search</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find(Type target, string name, bool caseSensitive);


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
		MethodInfo Find(Type target, string name, object query);


		/// <summary>
		/// Returns the first method in specfied target with specified name
		/// </summary>
		/// <param name="target">The Type whose properties are being search</param>
		/// <param name="name">The name of the method being searched for</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find(Type target, string name);


		/// <summary>
		/// Returns first method info of the specfied target that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object whose properties are being search</param>
		/// <param name="query">The query object to specify how search is conducted</param>
		/// <returns><see cref="MethodInfo"></see> of the matching method or null if no method is found</returns>
		MethodInfo Find(Type target, object query);


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
		MethodInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);

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
		MethodInfo Find(object target, string name, object query, BindingFlags flags);

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
		MethodInfo Find(object target, string name, BindingFlags flags);

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
		MethodInfo Find(object target, object query, BindingFlags flags);

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
		MethodInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);


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
		MethodInfo Find(Type target, string name, object query, BindingFlags flags);


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
		MethodInfo Find(Type target, string name, BindingFlags flags);

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
		MethodInfo Find(Type target, object query, BindingFlags flags);

		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="query">The query object</param>
		bool Has( object target, string name, object query );

		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="query">The query object</param>
		bool Has( object target, object query );

		/// <summary>
		/// Returns true if the specfied target has a method with the specified name.
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		bool Has( object target, string name );



		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern and has the specified name.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query request pattern object used to modify the search</param>
		/// <param name="name">The name of the method testing for</param>
		bool Has(Type target, string name, object query);

		/// <summary>
		/// Returns true if the specfied target has a method that matches query request pattern.
		/// Pattern is in this form {argname = typeof(ArgumentType),...} or [ "argname" ]  or [ typeof(ArgumentType) ]
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="query">The query request pattern object used to modify the search</param>
		bool Has(Type target, object query);


		/// <summary>
		/// Returns true if the specfied target has a method with the specified name.
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="name">The name of the method testing for</param>
		bool Has(Type target, string name);


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
		bool Has(object target, string name, object query, BindingFlags flags);


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
		bool Has(object target, object query, BindingFlags flags);

		/// <summary>
		/// Returns true if the specfied target has a method that matches the specified name.
		/// </summary>
		/// <param name="target">The object being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(object target, string name, BindingFlags flags);


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
		bool Has(Type target, string name, object query, BindingFlags flags);

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
		bool Has(Type target, object query, BindingFlags flags);

		/// <summary>
		/// Returns true if the specfied target has a method that has the specified name.
		/// </summary>
		/// <param name="target">The Type being searched</param>
		/// <param name="name">The name of the method testing for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted
		/// </param>
		bool Has(Type target, string name, BindingFlags flags);

		/// <summary>
		/// Queries methods from target matching the query request 
		/// 
		/// query pattern is in this form {argName = typeof(ArgumentType),...}
		/// Special Cases:
		/// @return matches the return value of the method
		/// </summary>
		IEnumerable<MethodInfo> Query(object target, object query);

		/// <summary>
		/// Queries methods from target matching the query request 
		/// 
		/// query pattern is in this form {argname = TypeOfArgument,...}
		/// Special Cases:
		/// @return - matches on return type match
		/// </summary>
		IEnumerable<MethodInfo> Query(Type target, object query);

		/// <summary>
		/// Queries methods from target matching the query request 
		/// 
		/// query pattern is in this form {argName = typeof(ArgumentType),...}
		/// Special Cases:
		/// @return matches the return value of the method
		/// </summary>
		IEnumerable<MethodInfo> Query(object target, object query, BindingFlags flags);

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
		IEnumerable<MethodInfo> Query(Type target, object query, BindingFlags flags);


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
		IEnumerable<MethodInfo> Query(object target, object query,string name, bool caseSenstive);

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
		IEnumerable<MethodInfo> Query(Type target, object query,string name, bool caseSenstive);

		/// <summary>
		/// Queries methods from target matching the query request 
		/// 
		/// query pattern is in this form {argName = typeof(ArgumentType),...}
		/// Special Cases:
		/// @return matches the return value of the method
		/// </summary>
		IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive, BindingFlags flags);


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
		IEnumerable<MethodInfo> Query(Type target, object query,string name, bool caseSenstive, BindingFlags flags);

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
		IEnumerable<MethodInfo> Query(object target, object query, string name);

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
		IEnumerable<MethodInfo> Query(Type target, object query, string name);

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
		IEnumerable<MethodInfo> Query(object target, object query, string name,BindingFlags flags);

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
		IEnumerable<MethodInfo> Query(Type target, object query, string name, BindingFlags flags);

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
		object Invoke(object target, string name, BindingFlags flags);



		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		object Invoke(object target, string name);




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
		object Invoke(object target, string name, BindingFlags flags, params object[] arguments);

		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		object Invoke(object target, string name,  params object[] arguments);



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
		T Invoke<T>(object target, string name, BindingFlags flags);



		/// <summary>
		/// Invokes a method of specified name and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The result of the invocations</returns>
		T Invoke<T>(object target, string name);



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
		T Invoke<T>(object target, string name, BindingFlags flags, params object[] arguments);

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <returns>The results of the invocations</returns>
		T Invoke<T>(object target, string name, params object[] arguments);


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
		IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets);


		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <returns>The results of the invocations</returns>
		IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets);

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <returns>The results of the invocations</returns>
		IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets);


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
		IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets);

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
		IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy);


		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <returns>The results of the invocations</returns>
		IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets, bool greedy);

		/// <summary>
		/// Invokes a method of specified name once for each passed array of arguments and returns the results of the invocation
		/// </summary>
		/// <typeparam name="T">The return type of the methods being called</typeparam>
		/// <param name="target">The object whose method is being invoked</param>
		/// <param name="name">The name of the method being invoked</param>
		/// <param name="argumentSets">The arguments being passed to the invoked method</param>
		/// <param name="greedy">Indicates if the methods should be executed on call or when enumerating through return enumerable</param>
		/// <returns>The results of the invocations</returns>
		IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets, bool greedy);


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
		IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets,bool greedy);


	}

}