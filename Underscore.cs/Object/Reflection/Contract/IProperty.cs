using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
	public interface IPropertyComponent
	{
		/// <summary>
		///     Searches for the properties of <paramref name="target"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		IEnumerable<PropertyInfo> All(object target);


		/// <summary>
		///     Searches for the properties of <paramref name="type"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="type">The Type whose properties are being searched</param>
		IEnumerable<PropertyInfo> All(Type type);


		/// <summary>
		///     Searches for the properties of <paramref name="target"></paramref>'s <see cref="Type"></see>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		IEnumerable<PropertyInfo> All(object target, BindingFlags flags);

		/// <summary>
		///     Searches for the properties of <paramref name="type"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		IEnumerable<PropertyInfo> All(Type type, BindingFlags flags);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <returns></returns>
		PropertyInfo Find(object target, string name);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		PropertyInfo Find(object target, string name, bool caseSensitive);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns></returns>
		PropertyInfo Find(object target, string name, BindingFlags flags);

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns></returns>
		PropertyInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <returns></returns>
		PropertyInfo Find(Type target, string name);

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		/// <returns></returns>
		PropertyInfo Find(Type target, string name, bool caseSensitive);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns></returns>
		PropertyInfo Find(Type target, string name, BindingFlags flags);


		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns></returns>
		PropertyInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		object GetValue(object target, string name);

		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		///     where property is accessible publically and related to the instance of the object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <returns>The property value of the specified object</returns>
		object GetValue(object target, string name, bool caseSensitive);


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns>The property value of the specified object</returns>
		object GetValue(object target, string name, BindingFlags flags);


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns>The property value of the specified object</returns>
		object GetValue(object target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <returns>The property value of the specified object</returns>
		T GetValue<T>(object target, string name);

		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <returns>The property value of the specified object</returns>
		T GetValue<T>(object target, string name, bool caseSensitive);

		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <typeparam name="T">The type of the value being returned</typeparam>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns>The property value of the specified object</returns>
		T GetValue<T>(object target, string name, BindingFlags flags);

		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <typeparam name="T">The type of the value being returned</typeparam>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		/// <returns>The property value of the specified object</returns>
		T GetValue<T>(object target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">the object whose properties are being searched</param>
		/// <param name="name">The name of the property being searched for</param>
		bool Has(object target, string name);


		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">The object to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		bool Has(object target, string name, bool caseSensitive);


		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">The object to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		bool Has(object target, string name, BindingFlags flags);

		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">The object to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		bool Has(object target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		bool Has(Type target, string name);


		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		bool Has(Type target, string name, bool caseSensitive);


		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		bool Has(Type target, string name, BindingFlags flags);

		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		bool Has(Type target, string name, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		void SetValue(object target, string name, object value);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		void SetValue(object target, string name, object value, bool caseSensitive);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		void SetValue(object target, string name, object value, BindingFlags flags);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		void SetValue(object target, string name, object value, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		void SetValue<T>(object target, string name, T value);

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		void SetValue<T>(object target, string name, T value, bool caseSensitive);


		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		void SetValue<T>(object target, string name, T value, BindingFlags flags);

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the property match is to be conducted.
		/// </param>
		void SetValue<T>(object target, string name, T value, bool caseSensitive, BindingFlags flags);


		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">The action to be executed at every step, parameter being passed is the current property's value</param>
		void Each(object target, Action<object> iter);


		/// <summary>
		///     Iterates over each of the properties of the target item, filtering passed on specified type
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		void Each<T>(object target, Action<T> iter);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step, first parameter being passed is the current property's value,
		///     second is the property's name
		/// </param>
		void Each(object target, Action<object, string> iter);


		/// <summary>
		///     Iterates over each of the properties of the target item, filtering passed on specified type
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		void Each<T>(object target, Action<T, string> iter);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		void Each(object target, Action<object, string, Action<object>> iter);


		/// <summary>
		///     Iterates over each of the properties of the target item, filtering passed on specified type
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		void Each<T>(object target, Action<T, string, Action<T>> iter);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each(object target, Action<object> iter, BindingFlags flags);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each<T>(object target, Action<T> iter, BindingFlags flags);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each(object target, Action<object, string> iter, BindingFlags flags);


		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each<T>(object target, Action<T, string> iter, BindingFlags flags);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each(object target, Action<object, string, Action<object>> iter, BindingFlags flags);

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		void Each<T>(object target, Action<T, string, Action<T>> iter, BindingFlags flags);

		/// <summary>
		///     Gets all of the properties of the specified type from the specified object
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		IEnumerable<PropertyInfo> OfType(object target, Type propertyTypeTarget);

		/// <summary>
		///     Gets all of the properties of the specified type from the specified object
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		IEnumerable<PropertyInfo> OfType(object target, Type propertyTypeTarget, BindingFlags flags);

		/// <summary>
		///     Gets all of the properties of the specified type
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		IEnumerable<PropertyInfo> OfType(Type target, Type propertyTypeTarget);

		/// <summary>
		///     Gets all of the properties of the specified type
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		IEnumerable<PropertyInfo> OfType(Type target, Type propertyTypeTarget, BindingFlags flags);


		/// <summary>
		///     Gets all of the values for publicly accessible properties of specified object
		/// </summary>
		/// <param name="target">The object whose properties values are being returned</param>
		/// <returns>Enumerable containing all of the properties values form passed object</returns>
		IEnumerable<object> Values(object target);


		/// <summary>
		///     Gets all of the values for publicly accessible properties of specified object
		/// </summary>
		/// <param name="target">The object whose properties values are being returned</param>
		/// <returns>Enumerable containing all of the properties values form passed object</returns>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		IEnumerable<object> Values(object target, BindingFlags flags);


		/// <summary>
		///     Get all of the values from properties of specified object
		/// </summary>
		/// <typeparam name="TPropertyValue">The type to filter the properties' values on</typeparam>
		/// <param name="target">The object whose properties' values are being returned</param>
		/// <returns>The values from the properties of specfied object of specified type</returns>
		IEnumerable<TPropertyValue> Values<TPropertyValue>(object target);


		/// <summary>
		///     Get all of the values from properties of specified object
		/// </summary>
		/// <typeparam name="TPropertyValue">The type to filter the properties' values on</typeparam>
		/// <param name="target">The object whose properties' values are being returned</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		/// <returns>The values from the properties of specfied object of specified type</returns>
		IEnumerable<TPropertyValue> Values<TPropertyValue>(object target, BindingFlags flags);


		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		IEnumerable<MemberPair<object>> Pairs(object target);


		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		IEnumerable<MemberPair<object>> Pairs(object target, BindingFlags flags);


		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <typeparam name="TPropertyValue">The type that is being used to filter returned pairs based off of property's type</typeparam>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target);

		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <typeparam name="TPropertyValue">The type that is being used to filter returned pairs based off of property's type</typeparam>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which pairs should be returned
		/// </param>
		/// <returns></returns>
		IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target, BindingFlags flags);
	}

	public class MemberPair<T>
	{
		public string Name { get; internal set; }
		public T Value { get; internal set; }
	}
}