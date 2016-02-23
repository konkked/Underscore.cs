using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public interface IPropertyComponent 
    {

        /// <summary>
        /// Get all of the properties that the target has
        /// </summary>
        IEnumerable<PropertyInfo> All(object target);

        /// <summary>
        /// Get all of the properties that the target has
        /// </summary>
        IEnumerable<PropertyInfo> All(Type type);


        /// <summary>
        /// Get all of the properties that the target has
        /// </summary>
        IEnumerable<PropertyInfo> All(object target, BindingFlags flags);

        /// <summary>
        /// Get all of the properties that the target has
        /// </summary>
        IEnumerable<PropertyInfo> All(Type type, BindingFlags flags);



        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(object target, string name);

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(object target, string name, bool caseSensitive);


        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(object target, string name, BindingFlags flags);

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);



        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(Type target, string name);

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(Type target, string name, bool caseSensitive);


        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(Type target, string name, BindingFlags flags);

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        PropertyInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);





        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        object GetValue(object target, string name);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        /// <returns>Returns the value of the property</returns>
        object GetValue(object target, string name, bool caseSensitive);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        object GetValue(object target, string name, BindingFlags flags);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        /// <returns>Returns the value of the property</returns>
        object GetValue(object target, string name, bool caseSensitive, BindingFlags flags);
        



        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        T GetValue<T>(object target, string name);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        /// <returns>Returns the value of the property</returns>
        T GetValue<T>(object target, string name, bool caseSensitive);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        T GetValue<T>(object target, string name, BindingFlags flags);

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        /// <returns>Returns the value of the property</returns>
        T GetValue<T>(object target, string name, bool caseSensitive, BindingFlags flags);


        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(object target, string name);

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has( object target, string name, bool caseSensitive );


        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(object target, string name, BindingFlags flags);

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(object target, string name, bool caseSensitive, BindingFlags flags);



        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(Type target, string name);

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(Type target, string name, bool caseSensitive);


        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(Type target, string name, BindingFlags flags);

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        bool Has(Type target, string name, bool caseSensitive, BindingFlags flags);


        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue(object target, string name, object value);


        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue( object target, string name, object value, bool caseSensitive );


        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue(object target, string name, object value, BindingFlags flags);


        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue(object target, string name, object value, bool caseSensitive, BindingFlags flags);



        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue<T>(object target, string name, T value);

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue<T>( object target, string name, T value, bool caseSensitive );


        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue<T>(object target, string name, T value, BindingFlags flags);

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        void SetValue<T>(object target, string name, T value, bool caseSensitive, BindingFlags flags);



        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object> iter);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T> iter);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object, string> iter);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T, string> iter);


        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object, string, Action<object>> iter);

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T, string, Action<T>> iter);


        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object> iter, BindingFlags flags);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T> iter, BindingFlags flags);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object, string> iter,BindingFlags flags);

        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T, string> iter, BindingFlags flags);


        /// <summary>
        /// Iterates over each of the properties of the target item
        /// </summary>
        void Each(object target, Action<object, string, Action<object>> iter, BindingFlags flags);

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        void Each<T>(object target, Action<T, string, Action<T>> iter, BindingFlags flags);

        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>
        IEnumerable<PropertyInfo> OfType(object target, Type type);

        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>
        IEnumerable<PropertyInfo> OfType(object target, Type type, BindingFlags flags);


        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>

        IEnumerable<object> Values(object target);

        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>

        IEnumerable<object> Values(object target, BindingFlags flags);

        /// <summary>
        /// Returns an enumerable representing all the property values of a specific target obj
        /// </summary>

        IEnumerable<TPropertyValue> Values<TPropertyValue>(object target);


        /// <summary>
        /// Returns an enumerable representing all the property values of a specific target obj
        /// </summary>
        IEnumerable<TPropertyValue> Values<TPropertyValue>(object target, BindingFlags flags);


        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>

        IEnumerable<MemberPair<object>> Pairs(object target);

        /// <summary>
        /// Finds all fields of a specific type from the targeted object
        /// </summary>

        IEnumerable<MemberPair<object>> Pairs(object target, BindingFlags flags);

        /// <summary>
        /// Returns an enumerable representing all the property values of a specific target obj
        /// </summary>

        IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target);


        /// <summary>
        /// Returns an enumerable representing all the property values of a specific target obj
        /// </summary>
        IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target, BindingFlags flags);
    }

    public class MemberPair<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
