using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{
    public interface IMethodComponent
    {
        /// <summary>
        /// Gets all of the methods from the target object
        /// </summary>
        IEnumerable<MethodInfo> All(Type target);


        /// <summary>
        /// Gets all of the methods from the target object
        /// </summary>
        IEnumerable<MethodInfo> All(object target);


        /// <summary>
        /// Gets all of the methods from the target object
        /// </summary>
        IEnumerable<MethodInfo> All(Type target, BindingFlags flags);


        /// <summary>
        /// Gets all of the methods from the target object
        /// </summary>
        IEnumerable<MethodInfo> All(object target, BindingFlags flags);

        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        MethodInfo Find( object target, string name, bool caseSensitive );
        
        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
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
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find( object target, object query );



        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        MethodInfo Find(Type target, string name, bool caseSensitive);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(Type target, string name, object query);


        /// <summary>
        /// Finds the method with the corresponding name
        /// </summary>
        MethodInfo Find(Type target, string name);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(Type target, object query);


        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        MethodInfo Find(object target, string name, bool caseSensitive, BindingFlags flags);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(object target, string name, object query, BindingFlags flags);

        /// <summary>
        /// Finds the method with the corresponding name
        /// </summary>
        MethodInfo Find(object target, string name, BindingFlags flags);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = typeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(object target, object query, BindingFlags flags);

        /// <summary>
        /// Finds a method info from target by name
        /// </summary>
        MethodInfo Find(Type target, string name, bool caseSensitive, BindingFlags flags);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(Type target, string name, object query, BindingFlags flags);


        /// <summary>
        /// Finds the method with the corresponding name
        /// </summary>
        MethodInfo Find(Type target, string name, BindingFlags flags);

        /// <summary>
        /// Finds the first method info from target matching the requested name 
        /// and the query request pattern.
        /// pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        MethodInfo Find(Type target, object query, BindingFlags flags);

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has( object target, string name, object query );

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has( object target, object query );

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        bool Has( object target, string name );


        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(Type target, string name, object query);

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(Type target, object query);

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        bool Has(Type target, string name);


        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(object target, string name, object query, BindingFlags flags);

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(object target, object query, BindingFlags flags);

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        bool Has(object target, string name, BindingFlags flags);


        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(Type target, string name, object query, BindingFlags flags);

        /// <summary>
        /// Determines the if the target object has a matching method 
        /// arguments patter is the same as query pattern {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        bool Has(Type target, object query, BindingFlags flags);

        /// <summary>
        /// Determines if the target object contains 
        /// a method with the specified name
        /// </summary>
        bool Has(Type target, string name, BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query, BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query, BindingFlags flags);


        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query,string name, bool caseSenstive);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query,string name, bool caseSenstive);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query, string name, bool caseSenstive, BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query,string name, bool caseSenstive, BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query, string name);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query, string name);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argName = typeof(ArgumentType),...}
        /// Special Cases:
        /// @return matches the return value of the method
        /// </summary>
        IEnumerable<MethodInfo> Query(object target, object query, string name,BindingFlags flags);

        /// <summary>
        /// Queries methods from target matching the query request 
        /// 
        /// query pattern is in this form {argname = TypeOfArgument,...}
        /// Special Cases:
        /// @return - matches on return type match
        /// </summary>
        IEnumerable<MethodInfo> Query(Type target, object query, string name, BindingFlags flags);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        object Invoke(object target, string name, BindingFlags flags);



        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        object Invoke(object target, string name);



        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        object Invoke(object target, string name, BindingFlags flags, params object[] arguments);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        object Invoke(object target, string name,  params object[] arguments);



        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        T Invoke<T>(object target, string name, BindingFlags flags);



        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        T Invoke<T>(object target, string name);



        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        T Invoke<T>(object target, string name, BindingFlags flags, params object[] arguments);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        T Invoke<T>(object target, string name, params object[] arguments);


        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="argumentSets"></param>
        /// <returns></returns>
        IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets);


        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="argumentSets"></param>
        /// <returns></returns>
        IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="argumentSets"></param>
        /// <returns></returns>
        IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="argumentSets"></param>
        /// <returns></returns>
        IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets);


        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="argumentSets"></param>
        /// <param name="greedy"></param>
        /// <returns></returns>
        IEnumerable<object> InvokeForAll(object target, string name, BindingFlags flags, object[][] argumentSets, bool greedy);


        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="argumentSets"></param>
        /// <param name="greedy"></param>
        /// <returns></returns>
        IEnumerable<object> InvokeForAll(object target, string name, object[][] argumentSets, bool greedy);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="argumentSets"></param>
        /// <param name="greedy"></param>
        /// <returns></returns>
        IEnumerable<T> InvokeForAll<T>(object target, string name, object[][] argumentSets, bool greedy);

        /// <summary>
        /// Invokes method for object if it has one, if it does not then it will do nothing
        /// </summary>
        /// <param name="target"></param>
        /// <param name="name"></param>
        /// <param name="flags"></param>
        /// <param name="argumentSets"></param>
        /// <param name="greedy"></param>
        /// <returns></returns>
        IEnumerable<T> InvokeForAll<T>(object target, string name, BindingFlags flags, object[][] argumentSets,bool greedy);


    }

}