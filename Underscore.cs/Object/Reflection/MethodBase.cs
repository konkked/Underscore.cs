using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Utility;

namespace Underscore.Object.Reflection
{
    public abstract class MethodsBaseComponent<T>
        where T: MethodBase
    {


        private static IEnumerable<T> Query( MethodsBaseComponent<T> me, object target, object query )
        {
            var currMethods = me.All( target ).Select( a => new { Method = a, Params = a.GetParameters( ).ToList( ) } );

            if ( query == null )
                return me.All( target );

            if ( query is object[ ] )
            {
                var argsArr = ( object[ ] ) query;
                currMethods = currMethods.Where( a => a.Params.Count == argsArr.Length );

                for ( int i=0 ; i < argsArr.Length ; i++ )
                {
                    var instance = argsArr[ i ];
                    var index = i;

                    if ( instance is string )
                    {
                        var matchName = ( string ) instance;
                        currMethods = currMethods.Where( a => a.Params[ index ].Name == matchName );
                    }
                    else if ( instance is Type )
                    {
                        var matchType = ( Type ) instance;

                        currMethods = currMethods.Where( a => matchType.IsAssignableFrom( a.Params[ index ].ParameterType )
                            && a.Params[ index ].ParameterType.IsAssignableFrom( matchType )
                        );
                    }
                }


            }
            else if ( query is string )
            {
                var argName = ( string ) query;
                currMethods = currMethods.Where( a => a.Params.Count == 1 && a.Params[ 0 ].Name == argName );
            }

            else if ( query is Type )
            {
                var argType = ( Type ) query;
                currMethods = currMethods.Where( a => a.Params.Count == 1 && a.Params[ 0 ].ParameterType == argType );
            }
            else
            {

                var properties = me._properties.All( query ).Select( a => new
                {
                    Value = a.GetGetMethod( ).Invoke( query, null ),
                    Name = a.Name
                } );

                //empty anonymous object
                if ( properties.Count( ) == 0 )
                {
                    currMethods = currMethods.Where( a => a.Params.Count == 0 );
                }
                else
                {
                    foreach ( var property in properties )
                    {
                        if ( currMethods.FirstOrDefault( ) == null )
                            break;

                        var prop = property;

                        var argName = prop.Name;

                        if ( me.IsSpecialCase( argName ) )
                        {
                            currMethods = me
                                .FilterSpecialCase( argName, prop.Value, currMethods.Select( a => a.Method ) )
                                .Select( a => new { Method = a, Params = a.GetParameters( ).ToList( ) } );
                        }
                        else
                        {
                            if ( !( prop.Value is Type ) )
                                throw new ArgumentException( "for anonymous object query pattern is { [paramname] = [paramtype] }" );

                            var argType = ( Type ) prop.Value;

                            currMethods = currMethods.Where( a =>
                                a.Params.FirstOrDefault( b => b.Name == argName && b.ParameterType == argType ) != null );
                        }

                    }
                }


            }

            if ( currMethods.Count( ) == 0 )
                return ( new T[ ] { } );
            else
                return currMethods.Select( a => a.Method );

        }


        protected IPropertyComponent _properties;
        protected Members<T> _collection;
        protected IFunctionComponent _util;

        protected abstract bool IsSpecialCase( string name );
        protected abstract IEnumerable<T> FilterSpecialCase( string name, object value, IEnumerable<T> current );

        private readonly Func<object,object,IEnumerable<T>> _queryStore;

        protected MethodsBaseComponent(Function.ICacheComponent cacher, IPropertyComponent properties , Members<T> collection )
        {
            _properties = properties;
            _collection = collection;
            _queryStore = cacher.Memoize<object,object,IEnumerable<T>>( ( o, a ) => Query( this, o, a ) );
        }


        /// <summary>
        /// Gets all of the methods from the target object, which arent associated with properties
        /// </summary>
        /// <param name="target">The object to look for methods on</param>
        /// <returns>An enumerable of all public methods</returns>
        public abstract IEnumerable<T> All( object target );


        /// <summary>
        /// Queries methods from target matching the query request
        /// </summary>
        /// <param name="target">The object to search on</param>
        /// <param name="query">
        /// The query object, can take several forms,
        /// can be a type which will find a method 
        /// with one parameter matching the passed type
        /// 
        /// Can be an array of types finding a method 
        /// which has arguments with matching types 
        /// of requested corresponding cardinally
        /// 
        /// Can be an array of names finding a method 
        /// which has arguments with matching names
        /// requested, corresponding cardinally
        /// 
        /// Can be an empty anonymous object, 
        /// which returns all methods with no parameters
        /// 
        /// Can be an object with parameters in the format
        /// argumentName = argumentType
        /// Looks for matching matching arguments and types
        /// in parameters
        /// 
        /// Object can also include the following special cases
        /// 
        /// @return - matches the return type
        /// 
        /// 
        /// Special cases can be overriden by including an object with value 
        /// with properties 
        /// 
        /// overrideSpecialCase = true ( if it is false or not a bool will throw exception )
        /// type = type of parameter searching for
        /// </param>
        /// <returns>The methods that satisfies the criteria passed</returns>
        public IEnumerable<T> Query( object target, object query )
        {
            return _queryStore( target, query );
        }



    }
}
