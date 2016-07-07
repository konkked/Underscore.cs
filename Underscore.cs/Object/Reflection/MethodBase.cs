using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Function;
using Underscore.Utility;

namespace Underscore.Object.Reflection
{
    public abstract class MethodsBaseComponent<T>
        where T: MethodBase
    {

        protected IPropertyComponent _properties;
        protected Members<T> _collection;
        protected IFunctionComponent _util;

        protected abstract bool IsSpecialCase(string name);
        protected abstract IEnumerable<T> FilterSpecialCase(string name, object value, IEnumerable<T> current);

        private readonly Func<Type, object, IEnumerable<T>> _queryStore;
        private readonly Func<Type, object, BindingFlags, IEnumerable<T>> _flaggedQueryStore;

	    protected MethodsBaseComponent()
	    {
		    _properties = new PropertyComponent();
	    } 

        protected MethodsBaseComponent(ICacheComponent cacher, IPropertyComponent properties, Members<T> collection)
        {
            _properties = properties;
            _collection = collection;
            _queryStore = cacher.Memoize<Type, object, IEnumerable<T>>((o, a) => Query(this, o, a));
            _flaggedQueryStore = cacher.Memoize<Type, object, BindingFlags, IEnumerable<T>>((o, a, f) => Query(this, o, a, f));
        }

        private static IEnumerable<T> Query(MethodsBaseComponent<T> me, Type target, object query, BindingFlags flags = BindingFlags.Public | BindingFlags.Instance)
        {
            var currMethods = me.All(target,flags).Select(a => new { Method = a, Params = a.GetParameters().ToList() });

            if (query == null)
                return me.All(target);

            if (query is object[])
            {
                var argsArr = (object[])query;
                currMethods = currMethods.Where(a => a.Params.Count == argsArr.Length);

                for (int i = 0; i < argsArr.Length; i++)
                {
                    var instance = argsArr[i];
                    var index = i;

                    if (instance == null) continue;

                    if (instance is string)
                    {
                        var matchName = (string)instance;
                        currMethods = currMethods.Where(a => a.Params[index].Name == matchName);
                    }
                    else if (instance is Type)
                    {
                        var matchType = (Type)instance;

                        currMethods = currMethods.Where(a => matchType.IsAssignableFrom(a.Params[index].ParameterType)
                            && a.Params[index].ParameterType.IsAssignableFrom(matchType)
                        );
                    }
                }
            }
            else if (query is string)
            {
                var argName = (string)query;
                currMethods = currMethods.Where(a => a.Params.Count == 1 && a.Params[0].Name == argName);
            }

            else if (query is Type)
            {
                var argType = (Type)query;
                currMethods = currMethods.Where(a => a.Params.Count == 1 && a.Params[0].ParameterType == argType);
            }
            else
            {
                var properties = me._properties.All(query).Select(a => new
                {
                    Value = a.GetGetMethod().Invoke(query, null), a.Name
                });

                // empty anonymous object
                if (!properties.Any())
                {
                    currMethods = currMethods.Where(a => a.Params.Count == 0);
                }
                else
                {
                    foreach (var property in properties)
                    {
                        if (currMethods.FirstOrDefault() == null)
                            break;

                        var prop = property;

                        var argName = prop.Name;

                        if (me.IsSpecialCase(argName))
                        {
                            currMethods = me
                                .FilterSpecialCase(argName, prop.Value, currMethods.Select(a => a.Method))
                                .Select(a => new { Method = a, Params = a.GetParameters().ToList() });
                        }
                        else
                        {

                            if (!(prop.Value is Type))
                                throw new ArgumentException("for anonymous object query pattern is { [paramname] = [paramtype] }");

                            var argType = (Type)prop.Value;

                            currMethods = currMethods.Where(a =>
                                a.Params.FirstOrDefault(b => b.Name == argName && b.ParameterType == argType) != null);
                        }
                    }
                }
            }

            return !currMethods.Any() ? (new T[] { }) : currMethods.Select(a => a.Method);
        }

        /// <summary>
        /// Gets all of the methods from the target object, which arent associated with properties
        /// </summary>
        public abstract IEnumerable<T> All(object target);

        /// <summary>
        /// Gets all of the methods from the target object, which arent associated with properties
        /// </summary>
        public abstract IEnumerable<T> All(Type target);

        /// <summary>
        /// Gets all of the methods from the target object, which arent associated with properties
        /// </summary>
        public abstract IEnumerable<T> All(object target, BindingFlags flags);

        /// <summary>
        /// Gets all of the methods from the target object, which arent associated with properties
        /// </summary>
        public abstract IEnumerable<T> All(Type target, BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        public virtual IEnumerable<T> Query( object target, object query )
        {
            return _queryStore( target.GetType(), query );
        }

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        public virtual IEnumerable<T> Query( object target , object query , BindingFlags flags )
        {
            return _flaggedQueryStore(target.GetType(), query,flags);
        }

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        public virtual IEnumerable<T> Query( Type target , object query )
        {
            return _queryStore(target, query);
        }

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        public virtual IEnumerable<T> Query( Type target , object query , BindingFlags flags )
        {
            return _flaggedQueryStore(target, query,flags);
        }

    }
}
