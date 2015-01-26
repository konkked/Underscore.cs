using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public interface IMethodComponent
    {
        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        MethodInfo Find( object target, string name, bool caseSensitive );
        
        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        MethodInfo Find( object target, string name, object query );

        /// <summary>
        /// Finds the method with the corresponding name
        /// </summary>
        MethodInfo Find( object target, string name );

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        MethodInfo Find( object target, object query );

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        bool Has( object target, string name, object query );

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = typeOfArgument,...}
        /// current special case property is @return, which will match the return type
        /// if you wanted to search for an actual parameter named return use pattern {overrideObj
        /// </summary>
        bool Has( object target, object query );

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        bool Has( object target, string name );


        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = typeOfArgument,...}
        /// 
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query);

        /// <summary>
        /// Gets all of the methods from the target object
        /// </summary>
        IEnumerable<MethodInfo> All(object target);

    }

}