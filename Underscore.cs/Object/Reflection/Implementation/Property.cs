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
        private readonly Func<Type,Type, IEnumerable<PropertyInfo>> _propertiesByType;


        public PropertyComponent( ICacheComponent cacher )
        {
            ICacheComponent cacher1 = cacher; 

            _getValidProperties = cacher1.Memoize( new Func<Type, IEnumerable<PropertyInfo>>(
                t  => t.GetProperties(BindingFlags.Public | BindingFlags.Instance) .Where( a => a.GetGetMethod( ) != null
                    && a.GetIndexParameters( ).FirstOrDefault( ) == null
                ) ) );

            _propertiesByType = cacher1.Memoize(
               new Func<Type, Type, IEnumerable<PropertyInfo>>(
                   ( t1, t2 ) => All( t1 ).Where( a => a.PropertyType == t2 ) )
           );
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


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object> iter )
        {
            foreach ( var pr in Enumerate( target.GetType( ) ) )
                iter( pr.GetGetMethod( ).Invoke( target, null ) );
        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object, string> iter )
        {
            foreach ( var pr in Enumerate( target.GetType( ) ) )
                iter( pr.GetGetMethod( ).Invoke( target, null ), pr.Name );
        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each( object target, Action<object, string, Action<object>> iter )
        {

            foreach ( var pr in Enumerate( target.GetType( ) ) )
            {
                var pr1 = pr;
                iter(
                        pr.GetGetMethod( ).Invoke( target, null ),
                        pr.Name,
                        pr.GetSetMethod( ) == null ?
                            null as Action<object> :
                            ( o ) => pr1.GetSetMethod( ).Invoke( target, new[ ] { o } )
                    );
            }
        }

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T> iter )
        {
            if ( target != null )
                foreach ( var pr in Enumerate( target.GetType( ) ).Where( i => i.PropertyType == typeof(T) ) )
                            iter( ( T ) pr.GetValue( target ) );
            
        }


        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T, string> iter )
        {

            if ( target != null )
                foreach ( var pr in Enumerate( target.GetType() ).Where( i => i.PropertyType == typeof( T ) ) )
                    iter( ( T ) pr.GetGetMethod( ).Invoke( target, null ), pr.Name );
        }

        /// <summary>
        /// Iterates overeach of the properties of the target item
        /// </summary>
        public void Each<T>( object target, Action<T, string, Action<T>> iter )
        {
            if ( target != null )
                foreach ( var pr in Enumerate( target.GetType() ).Where( i => i.PropertyType == typeof( T ) ) )
                {
                    var pr1 = pr;
                    iter(
                        ( T ) pr.GetValue( target ),
                        pr.Name,
                        pr.GetSetMethod( ) == null || !pr.CanWrite ?
                            null :
                            new Action<T>(
                                ( o ) => pr1.SetValue( target, o )
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


        private PropertyInfo PropertyCaseInsensitive<T>( object target, string name ) 
        {
            var proplc = name.ToLower( );

            return OfType( target, typeof( T ) ).FirstOrDefault( a => a.Name.ToLower( ) == proplc ) ;
        }

        private PropertyInfo PropertyCaseSensitive<T>( object target, string name ) 
        {
            return OfType( target, typeof( T ) ).FirstOrDefault( a => a.Name == name );
        }

        private PropertyInfo PropertyCaseInsensitive( object target, string name ) 
        {
            var proplc = name.ToLower( );

            return All( target ).FirstOrDefault( a => a.Name.ToLower( ) == proplc ) ;
        }

        private PropertyInfo PropertyCaseSensitive( object target, string name ) 
        {
            return All( target ).FirstOrDefault( a => a.Name == name );
        }

        private PropertyInfo GetProperty( object target, string name, bool caseSensitive )
        {
            if ( caseSensitive )
                return PropertyCaseSensitive( target, name );
            else
                return PropertyCaseInsensitive( target, name );
        }

        private PropertyInfo GetProperty<T>( object target, string name, bool caseSensitive )
        {
            if ( caseSensitive )
                return PropertyCaseSensitive<T>( target, name );
            else
                return PropertyCaseInsensitive<T>( target, name );
        }

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        public bool Has( object target, string name, bool caseSensitive )
        {
            return GetProperty( target, name, caseSensitive ) != null;
        }

        /// <summary>
        /// Determines if an object has a property
        /// </summary>
        public bool Has( object target, string name )
        {
            return Has( target, name, true );
        }

        /// <summary>
        /// Gets the value of the specified property
        /// </summary>
        public object GetValue( object target, string name, bool caseSensitive ) 
        {
            var result = GetProperty( target, name, caseSensitive );
            
            if ( result == null )
                throw new ArgumentException( 
                    string.Format(
                        "property with name {0} does not match any properties in given target",
                        name
                    )
                );

            return result.GetValue( target );

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
            var result = GetProperty<T>( target, name, caseSensitive );
            
            
            if ( result == null )
                throw new ArgumentException(
                    string.Format(
                        "property with name {0} and type {1} does not match any properties in given target",
                        name,
                        typeof(T)
                    )
                );

            return (T)result.GetValue( target );

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
            else if ( !( ( value == null && !result.PropertyType.IsValueType ) || ( result.PropertyType.IsAssignableFrom( value.GetType( ) ) ) ) )
            {
                throw new ArgumentException( "passed value is an invalid type" );
            }
            else 
            {
                result.SetValue( target, value );
            }


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

        /// <summary>
        /// Finds the corresponding property info from the targeted object
        /// </summary>
        public PropertyInfo Find( object target, string name )
        {
            return GetProperty( target, name, true );
        }
    }
}
