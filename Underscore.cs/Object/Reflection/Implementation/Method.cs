using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public class MethodComponent : MethodsBaseComponent<MethodInfo>,IMethodComponent
    {
        

        private readonly static HashSet<string> s_specialRules;
        private readonly IPropertyComponent _property;

        static MethodComponent()
        {
            s_specialRules = new HashSet<string> {"return"};
        }


        public MethodComponent( Function.ICacheComponent cacher , IPropertyComponent property )
            : base(cacher, property,
                new Members<MethodInfo>(
                    a=>!a.IsConstructor && !a.IsSpecialName , 
                    BindingFlags.DeclaredOnly |BindingFlags.Public | BindingFlags.Instance 
                )
            )
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

        public override IEnumerable<MethodInfo> All( object target )
        {
            return _collection.All( target );
        }

        protected override bool IsSpecialCase( string name )
        {
            return s_specialRules.Contains( name );
        }

        protected override IEnumerable<MethodInfo> FilterSpecialCase( string name, object value, IEnumerable<MethodInfo> current )
        {
            
            
            if ( !IsSpecialCase( name ) )
                throw new InvalidOperationException( "Not a special case query rule" );

            if ( name == "return" ) 
            {
                if ( !( value is Type ) ) 
                {
                    const string doesNotHaveRequiredPropertyMsg ="Method query special case override requires a property with name '{0}' for the override object",
                        doesNotHaveRequiredTypeForPropertyMsg = "Method query special case override object requires property with name '{0} to have type {1} for the override object";


                    //check if is override
                    var isOverrideProperty = _property.Find( value, "isOverride" );
                    
                    if(isOverrideProperty == null)
                        throw new InvalidOperationException ( string.Format ( doesNotHaveRequiredPropertyMsg , "isOverride" ) ) ;

                    object isOverrideObj = isOverrideProperty.GetValue( value );

                    if(!( isOverrideObj is bool))
                        throw new InvalidOperationException(string.Format( doesNotHaveRequiredTypeForPropertyMsg , "isOverride",typeof(bool)));
                    
                    var typeProperty = _property.Find(value,"type");
 
                    if(typeProperty == null)
                        throw new InvalidOperationException(string.Format( doesNotHaveRequiredPropertyMsg,"type") );

                    var typeObject = typeProperty.GetValue(value);

                    if(!(typeObject is Type))
                        throw new InvalidOperationException(string.Format(doesNotHaveRequiredTypeForPropertyMsg , "type" , typeof(Type)));

                    Type type = (Type)typeObject;
                    bool isOverride = (bool) isOverrideObj;
                    
                    if ( isOverride ) 
                    {
                        return current.Where(a=>a.GetParameters().FirstOrDefault(b=>b.Name == "@return" && b.ParameterType == type) != null);
                    }
                    // not sure what to do in this case... 
                    throw new InvalidOperationException("Method query special case override object had parameter isOverride set to false, which is not allowed");
                }
                    
                var lookingFor = ( Type ) value;
                return current.Where( a => a.ReturnType == lookingFor );

            }

            // This is an internal exception
            // The special case was defined (otherwise this method wouldnt have been called) but was not implemented in this section
            throw new NotImplementedException( "Internal Exception: special case was assigned but not implemented , property name : " + name );

        }

        private MethodInfo CaseSensitiveGetMethod( object target, string name )
        {
            return All( target ).FirstOrDefault( t => t.Name == name );
        }

        private MethodInfo CaseInsensitiveGetMethod( object target, string name )
        {
            var lname = name.ToLowerInvariant( );
            return All( target ).FirstOrDefault( a => a.Name.ToLowerInvariant( ) == lname );
        }


        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        public MethodInfo Find( object target, string name )
        {
            return Find( target, name, true );
        }

        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        public MethodInfo Find( object target, string name, bool caseSensitive )
        {
            if ( caseSensitive )
                return CaseSensitiveGetMethod( target, name );
            else
                return CaseInsensitiveGetMethod( target, name );
        }



        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public MethodInfo Find( object target, string name, object query )
        {

            if ( query == null )
                query = new { };

            return Query( target, query )
                .FirstOrDefault( a => a.Name == name );
        }


        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        public bool Has( object target, string name )
        {
            return Find( target, name,true ) != null;
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

        public override IEnumerable<MethodInfo> Query( Type target , object query )
        {
            return base.Query(target, query);
        }

        public override IEnumerable<MethodInfo> Query( Type target , object query , BindingFlags flags )
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
        public bool Has( object target, string name, object query )
        {
            return Find( target, name, query ) != null;
        }


        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public bool Has( object target, object query )
        {
            return Find( target, query ) != null;
        }


        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        public MethodInfo Find( object target, object query )
        {
            return Query( target, query ).FirstOrDefault();
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