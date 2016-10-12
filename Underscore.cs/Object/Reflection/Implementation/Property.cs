using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Object.Reflection
{
	public class PropertyComponent : IPropertyComponent
	{
		private const BindingFlags defaultFlags = BindingFlags.Public | BindingFlags.Instance;

		/// <summary>
		///     Searches for the properties of <paramref name="target"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		public IEnumerable<PropertyInfo> All(object target)
		{
			return target.GetType().GetProperties(defaultFlags);
		}


		/// <summary>
		///     Searches for the properties of <paramref name="type"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="type">The Type whose properties are being searched</param>
		public IEnumerable<PropertyInfo> All(Type type)
		{
			return type.GetProperties(defaultFlags);
		}


		/// <summary>
		///     Searches for the properties of <paramref name="target"></paramref>'s <see cref="Type"></see>, using binding
		///     constraints provided
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		public IEnumerable<PropertyInfo> All(object target, BindingFlags flags)
		{
			return target.GetType().GetProperties(flags);
		}

		/// <summary>
		///     Searches for the properties of <paramref name="type"></paramref>, using binding constraints provided
		/// </summary>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify how the search is conducted, or Zero to return null.
		/// </param>
		public IEnumerable<PropertyInfo> All(Type type, BindingFlags flags)
		{
			return type.GetProperties(flags);
		}

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
		public void SetValue<T>(object target, string name, T value, bool caseSensitive, BindingFlags flags)
		{
			if (!caseSensitive)
				name = name.ToLower();

			var possible = OfType(target, typeof(T), flags);
			var propertyInfos = possible as PropertyInfo[] ?? possible.ToArray();
			if (propertyInfos.Any())
			{
				var assigning = propertyInfos.FirstOrDefault(a => (caseSensitive ? a.Name : a.Name.ToLower()) == name);

				if (assigning != null)
					assigning.SetValue(target, value);
			}
		}

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">The action to be executed at every step, parameter being passed is the current property's value</param>
		public void Each(object target, Action<object> iter)
		{
			Each(target, (o, s, a) => iter(o), defaultFlags);
		}

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="iter">
		///     The action to be executed at every step, first parameter being passed is the current property's value,
		///     second is the property's name
		/// </param>
		public void Each(object target, Action<object, string> iter)
		{
			Each(target, (o, s, a) => iter(o, s), defaultFlags);
		}

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="onEach">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		public void Each(object target, Action<object, string, Action<object>> onEach)
		{
			Each(target, onEach, defaultFlags);
		}

		/// <summary>
		///     Iterates over each of the properties of the target item, filtering passed on specified type
		/// </summary>
		/// <typeparam name="T">The type to filter the properties being iterated over based on the property's type</typeparam>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="onEach">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		public void Each<T>(object target, Action<T> onEach)
		{
			Each(target, new Action<T, string, Action<T>>((o, s, a) => onEach(o)));
		}

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
		public void Each<T>(object target, Action<T, string> iter)
		{
			Each(target, new Action<T, string, Action<T>>((o, s, a) => iter(o, s)));
		}

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
		public void Each<T>(object target, Action<T, string, Action<T>> iter)
		{
			Each(target, iter, defaultFlags);
		}


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
		public void Each(object target, Action<object> iter, BindingFlags flags)
		{
			Each(target, (o, s, a) => iter(o), defaultFlags);
		}


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
		public void Each<T>(object target, Action<T> iter, BindingFlags flags)
		{
			Each(target, new Action<T, string, Action<T>>((o, s, a) => iter(o)), defaultFlags);
		}


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
		public void Each(object target, Action<object, string> iter, BindingFlags flags)
		{
			Each(target, (o, s, a) => iter(o, s), defaultFlags);
		}


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
		public void Each<T>(object target, Action<T, string> iter, BindingFlags flags)
		{
			Each(target, new Action<T, string, Action<T>>((o, s, a) => iter(o, s)), defaultFlags);
		}

		/// <summary>
		///     Iterates over each of the properties of the target item
		/// </summary>
		/// <param name="target">The object whose properties are being iterated over</param>
		/// <param name="onEach">
		///     The action to be executed at every step.
		///     The first parameter being passed is the current property's value, second is the property's name,
		///     third is an action that allows setting the properties value if the property cannot be set the action is null
		/// </param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties to iterate over
		/// </param>
		public void Each(object target, Action<object, string, Action<object>> onEach, BindingFlags flags)
		{
			foreach (var pr in target.GetType().GetProperties(flags).Where(a => a.GetIndexParameters().Length == 0))
			{
				var pr1 = pr;
				onEach(
					pr.GetGetMethod().Invoke(target, null),
					pr.Name,
					pr.GetSetMethod() == null
						? null as Action<object>
						: o => pr1.GetSetMethod().Invoke(target, new[] { o })
					);
			}
		}


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
		public void Each<T>(object target, Action<T, string, Action<T>> iter, BindingFlags flags)
		{
			if (target == null) return;

			foreach (var pr in target.GetType().GetProperties(flags).Where(i => i.GetIndexParameters().Length == 0 && i.PropertyType == typeof(T)))
			{
				var pr1 = pr;
				iter(
					(T)pr.GetValue(target),
					pr.Name,
					pr.GetSetMethod() == null || !pr.CanWrite
						? null
						: new Action<T>(
							o => pr1.SetValue(target, o)
							)
					);
			}
		}

		/// <summary>
		///     Gets all of the properties of the specified type from the specified object
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		public IEnumerable<PropertyInfo> OfType(object target, Type propertyTypeTarget)
		{
			return target.GetType().GetProperties(defaultFlags).Where(a => a.PropertyType == propertyTypeTarget);
		}

		/// <summary>
		///     Gets all of the properties of the specified type from the specified object
		/// </summary>
		/// <param name="target">The object whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public IEnumerable<PropertyInfo> OfType(object target, Type propertyTypeTarget, BindingFlags flags)
		{
			return target.GetType().GetProperties(flags).Where(a => a.PropertyType == propertyTypeTarget);
		}

		/// <summary>
		///     Gets all of the properties of the specified type
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public IEnumerable<PropertyInfo> OfType(Type target, Type propertyTypeTarget)
		{
			return target.GetProperties(defaultFlags).Where(a => a.PropertyType == propertyTypeTarget);
		}

		/// <summary>
		///     Gets all of the properties of the specified type
		/// </summary>
		/// <param name="target">The Type whose properties are being searched</param>
		/// <param name="propertyTypeTarget">The type to filter the properties of the object on</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public IEnumerable<PropertyInfo> OfType(Type target, Type propertyTypeTarget, BindingFlags flags)
		{
			return target.GetProperties(flags).Where(a => a.PropertyType == propertyTypeTarget);
		}

		/// <summary>
		///     Gets all of the values for publicly accessible properties of specified object
		/// </summary>
		/// <param name="target">The object whose properties values are being returned</param>
		/// <returns>Enumerable containing all of the properties values form passed object</returns>
		public IEnumerable<object> Values(object target)
		{
			return Values(target, defaultFlags);
		}


		/// <summary>
		///     Gets all of the values for publicly accessible properties of specified object
		/// </summary>
		/// <param name="target">The object whose properties values are being returned</param>
		/// <returns>Enumerable containing all of the properties values form passed object</returns>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public IEnumerable<object> Values(object target, BindingFlags flags)
		{
			return All(target, flags).Where(a => a.CanRead).Select(a => a.GetValue(target));
		}


		/// <summary>
		///     Get all of the values from properties of specified object
		/// </summary>
		/// <typeparam name="TPropertyValue">The type to filter the properties' values on</typeparam>
		/// <param name="target">The object whose properties' values are being returned</param>
		/// <returns>The values from the properties of specfied object of specified type</returns>
		public IEnumerable<TPropertyValue> Values<TPropertyValue>(object target)
		{
			return Values<TPropertyValue>(target, defaultFlags);
		}

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
		public IEnumerable<TPropertyValue> Values<TPropertyValue>(object target, BindingFlags flags)
		{
			return OfType(target, typeof(TPropertyValue), flags).Select(a => (TPropertyValue)a.GetValue(target));
		}

		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">The object to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		public bool Has(object target, string name, bool caseSensitive)
		{
			return GetProperty(target, name, caseSensitive) != null;
		}

		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">The object to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public bool Has(object target, string name, BindingFlags flags)
		{
			return GetProperty(target, name, true, flags) != null;
		}

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
		public bool Has(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			return GetProperty(target, name, caseSensitive, flags) != null;
		}

		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		public bool Has(Type target, string name)
		{
			return GetProperty(target, name, true) != null;
		}

		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="caseSensitive">Indicates if match should only happen if cases match perfectly</param>
		public bool Has(Type target, string name, bool caseSensitive)
		{
			return GetProperty(target, name, caseSensitive) != null;
		}

		/// <summary>
		///     Determines if a type has a property
		/// </summary>
		/// <param name="target">The Type to do the search on</param>
		/// <param name="name">The name of the property being searched for</param>
		/// <param name="flags">
		///     A bitmask comprised of one or more <see cref="BindingFlags"></see>
		///     that specify which properties should be returned
		/// </param>
		public bool Has(Type target, string name, BindingFlags flags)
		{
			return GetProperty(target, name, true, flags) != null;
		}

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
		public bool Has(Type target, string name, bool caseSensitive, BindingFlags flags)
		{
			return GetProperty(target, name, caseSensitive, flags) != null;
		}

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
		public object GetValue(object target, string name, BindingFlags flags)
		{
			return GetValue(target, name, true, flags);
		}


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		///     where property is accessible publically and related to the instance of the object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <returns>The property value of the specified object</returns>
		public object GetValue(object target, string name, bool caseSensitive)
		{
			return GetValue(target, name, caseSensitive, defaultFlags);
		}


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
		public T GetValue<T>(object target, string name, BindingFlags flags)
		{
			return GetValue<T>(target, name, true, flags);
		}


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
		public T GetValue<T>(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			var result = GetProperty<T>(target, name, caseSensitive, flags);

			if (result == null)
				throw new ArgumentException(
					string.Format(
						"property with name {0} and type {1} does not match any properties in given target",
						name,
						typeof(T)
						)
					);

			return (T)result.GetValue(target);
		}

		/// <summary>
		///     Determines if an object has a property
		/// </summary>
		/// <param name="target">the object whose properties are being searched</param>
		/// <param name="name">The name of the property being searched for</param>
		public bool Has(object target, string name)
		{
			return Has(target, name, true);
		}


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
		public object GetValue(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			var result = GetProperty(target, name, caseSensitive, flags);

			if (result == null)
				throw new ArgumentException(
					string.Format(
						"property with name {0} does not match any properties in given target",
						name
						)
					);

			return result.GetValue(target);
		}

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
		public PropertyInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
		{
			return GetProperty(target, name, caseSensitive, flags);
		}

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <returns></returns>
		public PropertyInfo Find(Type target, string name)
		{
			return GetProperty(target, name, true);
		}

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		/// <returns></returns>
		public PropertyInfo Find(Type target, string name, bool caseSensitive)
		{
			return GetProperty(target, name, caseSensitive);
		}


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
		public PropertyInfo Find(Type target, string name, BindingFlags flags)
		{
			return GetProperty(target, name, true, flags);
		}


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
		public PropertyInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
		{
			return GetProperty(target, name, caseSensitive, flags);
		}


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		public object GetValue(object target, string name)
		{
			return GetValue(target, name, true);
		}


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <param name="caseSensitive">Indicates if match should be allowed only if name casing matches</param>
		/// <returns>The property value of the specified object</returns>
		public T GetValue<T>(object target, string name, bool caseSensitive)
		{
			return GetValue<T>(target, name, caseSensitive, defaultFlags);
		}

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		public void SetValue(object target, string name, object value, bool caseSensitive)
		{
			var result = GetProperty(target, name, caseSensitive);

			if (result == null)
				throw new ArgumentException(
					string.Format(
						"property with name {0} does not match any properties in given target",
						name
						)
					);

			if (
				!((value == null && !result.PropertyType.IsValueType) ||
				  result.PropertyType.IsAssignableFrom(value.GetType())))
			{
				throw new ArgumentException("passed value is an invalid type");
			}

			result.SetValue(target, value);
		}

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
		public void SetValue(object target, string name, object value, BindingFlags flags)
		{
			SetValue(target, name, value, true, flags);
		}

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
		public void SetValue(object target, string name, object value, bool caseSensitive, BindingFlags flags)
		{
			var result = GetProperty(target, name, caseSensitive);

			if (result == null)
				throw new ArgumentException(
					string.Format(
						"property with name {0} does not match any properties in given target",
						name
						)
					);

			if (!((value == null && !result.PropertyType.IsValueType) || result.PropertyType.IsInstanceOfType(value)))
			{
				throw new ArgumentException("passed value is an invalid type");
			}

			result.SetValue(target, value);
		}

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		public void SetValue(object target, string name, object value)
		{
			SetValue(target, name, value, true);
		}


		/// <summary>
		///     Returns the value of the property of specified name from the specified object
		/// </summary>
		/// <param name="target">The object whose property value will be returned</param>
		/// <param name="name">The name of the object to be returned</param>
		/// <returns>The property value of the specified object</returns>
		public T GetValue<T>(object target, string name)
		{
			return GetValue<T>(target, name, true);
		}

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		/// <param name="caseSensitive">Determines if the name match is case sensitive</param>
		public void SetValue<T>(object target, string name, T value, bool caseSensitive)
		{
			var result = OfType(target, typeof(T));

			if (result == null)
				throw new InvalidOperationException(string.Format(
					"No property with requested type {0} in target object", typeof(T).Name));

			PropertyInfo instance;

			if (caseSensitive)
				instance = result.FirstOrDefault(a => a.Name == name);
			else
			{
				var lprop = name.ToLowerInvariant();
				instance = result.FirstOrDefault(a => a.Name.ToLowerInvariant() == lprop);
			}

			if (instance == null)
				throw new InvalidOperationException(
					string.Format("No property with the requested type {0} and name {1} in target object", typeof(T),
						name)
					);

			instance.SetValue(target, value);
		}

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
		public void SetValue<T>(object target, string name, T value, BindingFlags flags)
		{
			SetValue(target, name, value, true, flags);
		}

		/// <summary>
		///     Sets the value of property in the specified target
		/// </summary>
		/// <param name="target">The object whose property is to be set</param>
		/// <param name="name">The name of the property who's value is going to change</param>
		/// <param name="value">Value that is going to be assigned to the property</param>
		public void SetValue<T>(object target, string name, T value)
		{
			SetValue(target, name, value, true);
		}

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <param name="caseSensitive">Indicates if the match should be successful only if name casing matches</param>
		public PropertyInfo Find(object target, string name, bool caseSensitive)
		{
			return GetProperty(target, name, caseSensitive);
		}

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
		public PropertyInfo Find(object target, string name, BindingFlags flags)
		{
			return GetProperty(target, name, true, flags);
		}

		/// <summary>
		///     Returns a property info from specfied object who matches the specified search criteria
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <param name="name">The name that the serarch is using to find the property</param>
		/// <returns></returns>
		public PropertyInfo Find(object target, string name)
		{
			return GetProperty(target, name, true);
		}

		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		public IEnumerable<MemberPair<object>> Pairs(object target)
		{
			return All(target).Select(a => new MemberPair<object> { Name = a.Name, Value = a.GetValue(target) });
		}


		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		public IEnumerable<MemberPair<object>> Pairs(object target, BindingFlags flags)
		{
			return All(target, flags).Select(a => new MemberPair<object> { Name = a.Name, Value = a.GetValue(target) });
		}


		/// <summary>
		///     Gets all of the public instance properties of specified object returning them as MemberPair objects, with
		///     properties Name and Value
		/// </summary>
		/// <typeparam name="TPropertyValue">The type that is being used to filter returned pairs based off of property's type</typeparam>
		/// <param name="target">The object whose properties are being targetted</param>
		/// <returns></returns>
		public IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target)
		{
			return
				OfType(target, typeof(TPropertyValue))
					.Select(
						a => new MemberPair<TPropertyValue> { Name = a.Name, Value = (TPropertyValue)a.GetValue(target) });
		}

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
		public IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target, BindingFlags flags)
		{
			return
				OfType(target, typeof(TPropertyValue))
					.Select(
						a => new MemberPair<TPropertyValue> { Name = a.Name, Value = (TPropertyValue)a.GetValue(target) });
		}

		private PropertyInfo PropertyCaseInsensitive<T>(object target, string name, BindingFlags flags = defaultFlags)
		{
			var proplc = name.ToLower();

			return OfType(target, typeof(T), flags).FirstOrDefault(a => a.Name.ToLower() == proplc);
		}

		private PropertyInfo PropertyCaseSensitive<T>(object target, string name, BindingFlags flags = defaultFlags)
		{
			return OfType(target, typeof(T), flags).FirstOrDefault(a => a.Name == name);
		}

		private PropertyInfo PropertyCaseInsensitive(object target, string name, BindingFlags flags = defaultFlags)
		{
			var proplc = name.ToLower();

			return All(target, flags).FirstOrDefault(a => a.Name.ToLower() == proplc);
		}

		private PropertyInfo PropertyCaseSensitive(Type target, string name, BindingFlags flags = defaultFlags)
		{
			return All(target, flags).FirstOrDefault(a => a.Name == name);
		}

		private PropertyInfo PropertyCaseInsensitive(Type target, string name, BindingFlags flags = defaultFlags)
		{
			var proplc = name.ToLower();

			return All(target, flags).FirstOrDefault(a => a.Name.ToLower() == proplc);
		}

		private PropertyInfo PropertyCaseSensitive(object target, string name, BindingFlags flags = defaultFlags)
		{
			return target.GetType().GetProperty(name, flags);
		}

		private PropertyInfo GetProperty(Type target, string name, bool caseSensitive, BindingFlags flags = defaultFlags)
		{
			return caseSensitive
				? PropertyCaseSensitive(target, name, flags)
				: PropertyCaseInsensitive(target, name, flags);
		}

		private PropertyInfo GetProperty(object target, string name, bool caseSensitive,
			BindingFlags flags = defaultFlags)
		{
			return caseSensitive
				? PropertyCaseSensitive(target, name, flags)
				: PropertyCaseInsensitive(target, name, flags);
		}

		private PropertyInfo GetProperty<T>(object target, string name, bool caseSensitive,
			BindingFlags flags = defaultFlags)
		{
			return caseSensitive
				? PropertyCaseSensitive<T>(target, name, flags)
				: PropertyCaseInsensitive<T>(target, name, flags);
		}
	}
}
