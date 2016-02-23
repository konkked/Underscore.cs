using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
    public class PropertyComponent : IPropertyComponent
    {
        private readonly Func<Type, IEnumerable<PropertyInfo>> _getValidProperties;
        private readonly Func<Type,Type, BindingFlags,IEnumerable<PropertyInfo>> _propertiesByType;
        private readonly Func<Type, BindingFlags, IEnumerable<PropertyInfo>> _getValidPropertiesWithBindingFlags;
        private readonly Func<Type, string, BindingFlags,PropertyInfo> _getProperty; 
        private const BindingFlags defaultFlags = BindingFlags.Public | BindingFlags.Instance ;

        public PropertyComponent( ICacheComponent cacher )
        {



            var tmpValidProps = _getValidPropertiesWithBindingFlags = (
                (t, f) => t.GetProperties(f).Where(a => a.GetGetMethod() != null
                    && a.GetIndexParameters().FirstOrDefault() == null
                ));

            _getValidPropertiesWithBindingFlags = cacher.Memoize(tmpValidProps);
            _getValidProperties = t => _getValidPropertiesWithBindingFlags(t, defaultFlags);
            _propertiesByType =
                (tme, tprop, flags) =>
                    _getValidPropertiesWithBindingFlags(tme, flags).Where(a => a.PropertyType == tprop);

            var tmpProp = _getProperty = (t, n, bf) => t.GetProperty(n,bf);

            _getProperty = cacher.Memoize(tmpProp);


        }


        private IEnumerable<PropertyInfo> Enumerate(Type type, BindingFlags flags)
        {
            return _getValidPropertiesWithBindingFlags(type, flags);
        }

        private IEnumerable<PropertyInfo> Enumerate( Type target )
        {
            return _getValidProperties( target );
        }

        /// <summary>
        /// Get all of the properties that the target has
        /// </summary>
        public IEnumerable<PropertyInfo> All( object target )
        {
            return Enumerate( target.GetType( ) );
        }

        public IEnumerable<PropertyInfo> All(Type type)
        {
            return Enumerate(type);
        }

        public IEnumerable<PropertyInfo> All(object target, BindingFlags flags)
        {
            return Enumerate(target.GetType(), flags);
        }

        public IEnumerable<PropertyInfo> All(Type type, BindingFlags flags)
        {
            return Enumerate(type, flags);
        }


        public void SetValue<T>(object target, string name, T value, bool caseSensitive, BindingFlags flags)
        {
            if (!caseSensitive)
                name = name.ToLower();

            var possible = OfType(target, typeof (T), flags);
            var propertyInfos = possible as PropertyInfo[] ?? possible.ToArray();
            if (propertyInfos.Any())
            {
                var assigning = propertyInfos.FirstOrDefault(a => (caseSensitive ? a.Name : a.Name.ToLower()) == name);

                if (assigning != null)
                    assigning.SetValue(target, value);

            }
        }

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object> iter )
        {
            Each(target, (o, s, a) => iter(o), defaultFlags );
        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object, string> iter )
        {
            Each(target, (o, s, a) => iter(o,s), defaultFlags);
        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object, string, Action<object>> iter )
        {
            Each(target, iter, defaultFlags);
        }

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T> iter )
        {
            Each(target, new Action<T,string,Action<T>> ( (o,s,a) => iter(o)));

        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T, string> iter )
        {
            Each(target, new Action<T, string, Action<T>>((o, s, a) => iter(o, s)));
        }

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T, string, Action<T>> iter )
        {
            Each(target,  iter, defaultFlags);
        }

        public void Each(object target, Action<object> iter, BindingFlags flags)
        {
            Each(target, (o,s,a)=>iter(o), defaultFlags);
        }

        public void Each<T>(object target, Action<T> iter, BindingFlags flags)
        {
            Each(target, new Action<T, string, Action<T>>((o,s,a)=>iter(o)), defaultFlags);
        }

        public void Each(object target, Action<object, string> iter, BindingFlags flags)
        {
            Each(target,((o, s, a) => iter(o, s)), defaultFlags);
        }

        public void Each<T>(object target, Action<T, string> iter, BindingFlags flags)
        {
            Each(target, new Action<T, string, Action<T>>((o, s, a) => iter(o,s)), defaultFlags);
        }

        public void Each(object target, Action<object, string, Action<object>> iter, BindingFlags flags)
        {
            foreach (var pr in Enumerate(target.GetType(),flags))
            {
                var pr1 = pr;
                iter(
                        pr.GetGetMethod().Invoke(target, null),
                        pr.Name,
                        pr.GetSetMethod() == null ?
                            null as Action<object> :
                            (o) => pr1.GetSetMethod().Invoke(target, new[] { o })
                    );
            }
        }

        public void Each<T>(object target, Action<T, string, Action<T>> iter, BindingFlags flags)
        {
            if (target == null) return;

            foreach (var pr in Enumerate(target.GetType()).Where(i => i.PropertyType == typeof(T)))
            {
                var pr1 = pr;
                iter(
                    (T)pr.GetValue(target),
                    pr.Name,
                    pr.GetSetMethod() == null || !pr.CanWrite ?
                        null :
                        new Action<T>(
                            (o) => pr1.SetValue(target, o)
                            )
                    );
            }
        }

        /// <summary>
        /// Gets all of the properties of the specified type
        /// </summary>
        public IEnumerable<PropertyInfo> OfType( object target, Type type )
        {
            return  Enumerate(target.GetType()).Where(a => a.PropertyType == type );
        }

        public IEnumerable<PropertyInfo> OfType(object target, Type type, BindingFlags flags)
        {
            return _propertiesByType(target.GetType(), type, flags);
        }

        public IEnumerable<object> Values(object target)
        {
            return Values(target, defaultFlags);
        }

        public IEnumerable<object> Values(object target, BindingFlags flags)
        {
            return All(target, flags).Where(a => a.CanRead).Select(a => a.GetValue(target));
        }

        public IEnumerable<TPropertyValue> Values<TPropertyValue>(object target)
        {
            return Values<TPropertyValue>(target,defaultFlags);
        }

        public IEnumerable<TPropertyValue> Values<TPropertyValue>(object target, BindingFlags flags)
        {
            return OfType(target, typeof(TPropertyValue),flags).Select(a => (TPropertyValue)a.GetValue(target));
        }


        private PropertyInfo PropertyCaseInsensitive<T>(object target, string name, BindingFlags flags = defaultFlags) 
        {
            var proplc = name.ToLower( );

            return OfType( target, typeof( T ),flags ).FirstOrDefault( a => a.Name.ToLower( ) == proplc ) ;
        }

        private PropertyInfo PropertyCaseSensitive<T>(object target, string name, BindingFlags flags = defaultFlags) 
        {
            return OfType( target, typeof( T ), flags ).FirstOrDefault( a => a.Name == name );
        }


        private PropertyInfo PropertyCaseInsensitive(object target, string name, BindingFlags flags = defaultFlags)
        {
            var proplc = name.ToLower();

            return All(target,flags).FirstOrDefault(a => a.Name.ToLower() == proplc);
        }


        private PropertyInfo PropertyCaseSensitive(object target, string name, BindingFlags flags = defaultFlags)
        {

            return _getProperty(target.GetType(), name,flags);
        }



        private PropertyInfo GetProperty(Type target, string name, bool caseSensitive, BindingFlags flags = defaultFlags)
        {
            return caseSensitive ? PropertyCaseSensitive( target, name,flags ) : PropertyCaseInsensitive( target, name, flags );
        }


        private PropertyInfo GetProperty(object target, string name, bool caseSensitive, BindingFlags flags = defaultFlags)
        {
            return caseSensitive ? PropertyCaseSensitive(target, name, flags) : PropertyCaseInsensitive(target, name, flags);
        }

        private PropertyInfo GetProperty<T>(object target, string name, bool caseSensitive, BindingFlags flags = defaultFlags)
        {
            return caseSensitive ? PropertyCaseSensitive<T>(target, name, flags) : PropertyCaseInsensitive<T>(target, name, flags);
        }

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        public bool Has( object target, string name, bool caseSensitive )
        {
            return GetProperty(target, name, caseSensitive) != null;
        }

        public bool Has(object target, string name, BindingFlags flags)
        {

            return GetProperty(target, name, true, flags) != null;
        }

        public bool Has(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            return GetProperty(target, name, caseSensitive,flags) != null;
        }

        public bool Has(Type target, string name)
        {
            return GetProperty(target, name,true) != null;
        }

        public bool Has(Type target, string name, bool caseSensitive)
        {
            return GetProperty(target, name, caseSensitive) != null;
        }

        public bool Has(Type target, string name, BindingFlags flags)
        {
            return GetProperty(target, name, true,flags) != null;
        }

        public bool Has(Type target, string name, bool caseSensitive, BindingFlags flags)
        {
            return GetProperty(target, name, caseSensitive, flags) != null;
        }

        public object GetValue(object target, string name, BindingFlags flags)
        {
            return GetValue(target, name, true, flags);
        }

        public object GetValue(object target, string name, bool caseSensitive)
        {
            return GetValue(target, name, caseSensitive, defaultFlags);
        }


        public T GetValue<T>(object target, string name, BindingFlags flags)
        {
            return GetValue<T>(target, name, true, flags);
        }

        public T GetValue<T>(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            var result = GetProperty<T>(target, name, caseSensitive,flags);


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
        /// Determines if an object has a property
        /// </summary>
        public bool Has( object target, string name )
        {
            return Has( target, name, true );
        }


        public object GetValue(object target, string name,bool caseSensitive, BindingFlags flags)
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

        public PropertyInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            return GetProperty(target, name, caseSensitive, flags);
        }

        public PropertyInfo Find(Type target, string name)
        {
            return GetProperty(target, name, true);
        }

        public PropertyInfo Find(Type target, string name, bool caseSensitive)
        {
            return GetProperty(target, name, caseSensitive);
        }

        public PropertyInfo Find(Type target, string name, BindingFlags flags)
        {
            return GetProperty(target, name, true, flags);
        }

        public PropertyInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
        {
            return GetProperty(target, name, caseSensitive, flags);
        }

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        public object GetValue( object target, string name ) 
        {
            return GetValue( target, name, true );
        }

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        public T GetValue<T>( object target, string name, bool caseSensitive )
        {
            return GetValue<T>(target, name, caseSensitive, defaultFlags);
        }

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        public void SetValue( object target, string name, object value, bool caseSensitive ) 
        {
            var result = GetProperty( target, name, caseSensitive );


            if ( result == null )
                throw new ArgumentException(
                    string.Format(
                        "property with name {0} does not match any properties in given target",
                        name
                    )
                );

            if ( !( ( value == null && !result.PropertyType.IsValueType ) || ( result.PropertyType.IsAssignableFrom( value.GetType( ) ) ) ) )
            {
                throw new ArgumentException( "passed value is an invalid type" );
            }

            result.SetValue( target, value );
        }

        public void SetValue(object target, string name, object value, BindingFlags flags)
        {
            SetValue(target, name, value, true, flags);
        }

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

            if (!((value == null && !result.PropertyType.IsValueType) || (result.PropertyType.IsInstanceOfType(value))))
            {
                throw new ArgumentException("passed value is an invalid type");
            }

            result.SetValue(target, value);
        }

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        public void SetValue( object target, string name, object value ) 
        {
            SetValue( target, name, value, true );
        }

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        public T GetValue<T>( object target, string name )
        {
            return GetValue<T>( target, name, true );
        }

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        public void SetValue<T>( object target, string name, T value, bool caseSensitive )
        {

            var result = OfType( target, typeof( T ) );
            
            if ( result == null )
                throw new InvalidOperationException( string.Format( "No property with requested type {0} in target object", typeof( T ).Name ) );

            PropertyInfo instance;

            if ( caseSensitive )
                instance = result.FirstOrDefault(a => a.Name == name);
            else
            {
                var lprop = name.ToLowerInvariant();
                instance = result.FirstOrDefault(a => a.Name.ToLowerInvariant( ) == lprop);
            }

            if(instance == null)
                throw new InvalidOperationException(
                    string.Format("No property with the requested type {0} and name {1} in target object", typeof(T), name )
                );

            instance.SetValue( target, value );

        }

        public void SetValue<T>(object target, string name, T value, BindingFlags flags)
        {
            SetValue<T>(target, name, value, true, flags);
        }

        /// <summary>
        /// Sets the value of the specified property
        /// </summary>
        public void SetValue<T>( object target, string name, T value )
        {
            SetValue( target, name, value, true );
        }

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        public PropertyInfo Find( object target, string name, bool caseSensitive )
        {
            return GetProperty( target, name, caseSensitive );
        }

        public PropertyInfo Find(object target, string name, BindingFlags flags)
        {

            return GetProperty(target, name, true,flags);
        }

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        public PropertyInfo Find( object target, string name )
        {
            return GetProperty( target, name, true );
        }

        public IEnumerable<MemberPair<object>> Pairs(object target)
        {
            return All(target).Select(a => new MemberPair<object> {Name = a.Name, Value = a.GetValue(target)});
        }

        public IEnumerable<MemberPair<object>> Pairs(object target, BindingFlags flags)
        {
            return All(target,flags).Select(a => new MemberPair<object> { Name = a.Name, Value = a.GetValue(target) });
        }

        public IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target)
        {
            return OfType(target,typeof(TPropertyValue)).Select(a => new MemberPair<TPropertyValue> { Name = a.Name, Value = (TPropertyValue)a.GetValue(target) });
        }

        public IEnumerable<MemberPair<TPropertyValue>> Pairs<TPropertyValue>(object target, BindingFlags flags)
        {
            return OfType(target, typeof(TPropertyValue)).Select(a => new MemberPair<TPropertyValue> { Name = a.Name, Value = (TPropertyValue)a.GetValue(target) });
        }
    }
}
