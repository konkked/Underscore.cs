using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Underscore.Function;

namespace Underscore.Object.Reflection
{
    public class MethodComponent : MethodsBaseComponent<MethodInfo>,IMethodComponent
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
		    if(s_specialRules == null)
				InitSpecialRules();

			_property = new PropertyComponent();
	    }

		private static void InitSpecialRules()
	    {
		    s_specialRules = new HashSet<string> {"return"};
	    }

        public MethodComponent(Function.ICacheComponent cacher , IPropertyComponent property)
            : base(cacher, property, Members)
        {
            _property = property;
        }

        //TODO : break up into some sort of oop based special case rule object

        public override IEnumerable<MethodInfo> All(Type target)
        {
            return _collection.All(target);
        }

        public override IEnumerable<MethodInfo> All(object target, BindingFlags flags)
        {
            return _collection.All(target, flags);
        }

        public override IEnumerable<MethodInfo> All(Type target, BindingFlags flags)
        {
            return _collection.All(target, flags);
        }

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

                var lookingFor = (Type) value;
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
        /// Finds a method info from target by name
        /// </summary>
        public MethodInfo Find(object target, string name)
        {
            return Find(target, name, true);
        }

        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        public MethodInfo Find(object target, string name, bool caseSensitive)
        {
            if (caseSensitive)
                return CaseSensitiveGetMethod(target, name);
            else
                return CaseInsensitiveGetMethod(target, name);
        }

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public MethodInfo Find(object target, string name, object query)
        {

            if (query == null)
                query = new { };

            return Query(target, query)
                .FirstOrDefault(a => a.Name == name);
        }

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        public bool Has(object target, string name)
        {
            return Find(target, name,true) != null;
        }

        public bool Has(Type target, string name, object query)
        {
            return Find(target, name, query) != null;
        }

        public bool Has(Type target, object query)
        {
            return Find(target,  query) != null;
        }

        public bool Has(Type target, string name)
        {
            return Find(target, name) != null;
        }

        public bool Has(object target, string name, object query, BindingFlags flags)
        {
            return Find(target, name, query, flags) != null;
        }

        public bool Has(object target, object query, BindingFlags flags)
        {
            return Find(target, query, flags) != null;
        }

        public bool Has(object target, string name, BindingFlags flags)
        {
            return Find(target, name, flags) != null;
        }

        public bool Has(Type target, string name, object query, BindingFlags flags)
        {
            return Find(target, name, query, flags) != null;
        }

        public bool Has(Type target, object query, BindingFlags flags)
        {
            return Find(target, query, flags) != null;
        }

        public bool Has(Type target, string name, BindingFlags flags)
        {
            return Find(target, name, flags) != null;
        }

        public override IEnumerable<MethodInfo> Query(Type target , object query , BindingFlags flags)
        {
            return base.Query(target, query);
        }

        public IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive)
        {
            return Query(target.GetType(), query, name);
        }

        public IEnumerable<MethodInfo> Query(Type target, object query, string name, bool caseSenstive)
        {
            var lcname = name.ToLower();
            return caseSenstive
                ? base.Query(target, query).Where(a => a.Name == name)
                : base.Query(target, query).Where(a => a.Name.ToLower() == lcname);
        }

        public IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive, BindingFlags flags)
        {
            return Query(target.GetType(), query, name, caseSenstive, flags);
        }

        public IEnumerable<MethodInfo> Query(Type target, object query, string name, bool caseSenstive, BindingFlags flags)
        {
            var lcname = name.ToLower();
            return caseSenstive
                ? base.Query(target, query, flags).Where(a => a.Name == name)
                : base.Query(target, query, flags).Where(a => a.Name.ToLower() == lcname);
        }

        public IEnumerable<MethodInfo> Query(object target, object query, string name)
        {
            return Query(target.GetType(), query, name);
        }

        public IEnumerable<MethodInfo> Query(Type target, object query, string name)
        {
            return base.Query(target, query).Where(a => a.Name == name);
        }

        public IEnumerable<MethodInfo> Query(object target, object query, string name, BindingFlags flags)
        {
            return Query(target.GetType(), query, name, flags);
        }

        public IEnumerable<MethodInfo> Query(Type target, object query, string name, BindingFlags flags)
        {
            return base.Query(target, query, flags).Where(a => a.Name == name);
        }

        public object Invoke(object target, string name, BindingFlags flags)
        {
            var method = Find(target,name,new {}, flags);

            if (method != null)
                return method.Invoke(target, null);

            return null;
        }

        public object Invoke(object target, string name)
        {
            var method = Find(target, name, new { });

            if (method != null)
                return method.Invoke(target, null);

            return null;
        }

        public T Invoke<T>(object target, string name, BindingFlags flags)
        {
            var method = Query(target, new { }, name, flags).FirstOrDefault(a=>a.ReturnType == typeof(T));

            if (method != null)
                return (T)method.Invoke(target, null);

            return default(T);
        }

        public T Invoke<T>(object target, string name)
        {
            var method = Query(target, new { }, name).FirstOrDefault(a => a.ReturnType == typeof(T));

            if (method != null)
                return (T)method.Invoke(target, null);

            return default(T);
        }

        public object Invoke(object target, string name, BindingFlags flags, params object[] arguments)
        {
            var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

            var method = Find(target, name, typeArrayPassing, flags);

            if (method != null)
                return method.Invoke(target, arguments);

            return null;
        }

        public object Invoke(object target, string name, params object[] arguments)
        {
            var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

            var method = Find(target, name, typeArrayPassing);

            if (method != null)
                return method.Invoke(target, arguments);

            return null;
        }

        public T Invoke<T>(object target, string name, BindingFlags flags, params object[] arguments)
        {
            var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

            var method = Query(target, typeArrayPassing, name, flags).FirstOrDefault(a => a.ReturnType == typeof(T));

            if (method != null)
                return (T)method.Invoke(target, arguments);

            return default(T);
        }

        public T Invoke<T>(object target, string name, params object[] arguments)
        {
            var typeArrayPassing = arguments.Select(a => a != null ? a.GetType() : null).ToArray();

            var method = Query(target, typeArrayPassing, name).FirstOrDefault(a => a.ReturnType == typeof(T));

            if (method != null)
                return (T)method.Invoke(target, arguments);

            return default(T);
        }

        public IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets)
        {
            return InvokeForAll(target, name, flags, argumentSets, false);
        }

        public IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets)
        {
            return InvokeForAll(target, name,argumentSets, false);
        }

        public IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets)
        {
            return InvokeForAll<T>(target, name, flags, argumentSets, false);
        }

        public IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets)
        {
            return InvokeForAll<T>(target, name, argumentSets, false);
        }

        public IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy)
        {
            var returning =  argumentSets.Select(argumentSet => Invoke(target, name, flags, argumentSet));

            return greedy ? returning.ToList() : returning;
        }

        public IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets, bool greedy)
        {
            var returning = argumentSets.Select(argumentSet => Invoke(target, name, argumentSet));

            return greedy ? returning.ToList() : returning;
        }

        public IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy)
        {
            var returning = argumentSets.Select(argumentSet => Invoke<T>(target, name, flags, argumentSet));

            return greedy ? returning.ToList() : returning;
        }

        public IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets, bool greedy)
        {
            var returning = argumentSets.Select(argumentSet => Invoke<T>(target, name, argumentSet));

            return greedy ? returning.ToList() : returning;
        }

        public MethodInfo Find(Type target, object query)
        {
            return Query(target, query).FirstOrDefault();
        }

        public MethodInfo Find(object target, string name, bool caseSensitive, BindingFlags flags)
        {
            return Find(target.GetType(), name, caseSensitive, flags);
        }

        public MethodInfo Find(object target, string name, object query, BindingFlags flags)
        {
            return Find(target.GetType(),name, query, flags);
        }

        public MethodInfo Find(object target, string name, BindingFlags flags)
        {
            return Find(target.GetType(), name, flags);
        }

        public MethodInfo Find(object target, object query, BindingFlags flags)
        {
            return Find(target.GetType(), query, flags);
        }

        public MethodInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags)
        {
            var lcname = name.ToLower();
            return caseSensitive
                ? All(target, flags).FirstOrDefault(a => a.Name == name)
                : All(target, flags).FirstOrDefault(a => a.Name.ToLower() == lcname);
        }

        public MethodInfo Find(Type target, string name, object query, BindingFlags flags)
        {
            return base.Query(target, query, flags).FirstOrDefault(a => a.Name == name);
        }

        public MethodInfo Find(Type target, string name, BindingFlags flags)
        {
            return All(target, flags).FirstOrDefault(a => a.Name == name);
        }

        public MethodInfo Find(Type target, object query, BindingFlags flags)
        {
            return base.Query(target, query, flags).FirstOrDefault();
        }

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public bool Has(object target, string name, object query)
        {
            return Find(target, name, query) != null;
        }

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public bool Has(object target, object query)
        {
            return Find(target, query) != null;
        }

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public MethodInfo Find(object target, object query)
        {
            return Query(target, query).FirstOrDefault();
        }

        public MethodInfo Find(Type target, string name, bool caseSensitive)
        {
            var lcname = name.ToLower();
            return (caseSensitive
                ? All(target).Where(a => a.Name == name)
                : All(target).Where(a => a.Name.ToLower() == lcname)).FirstOrDefault();
        }

        public MethodInfo Find(Type target, string name, object query)
        {
            return base.Query(target, query).FirstOrDefault(a => a.Name == name);
        }

        public MethodInfo Find(Type target, string name)
        {
            return All(target).FirstOrDefault(a => a.Name == name);
        }
    }
}