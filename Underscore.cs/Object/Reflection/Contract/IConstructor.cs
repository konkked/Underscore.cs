using System;
using System.Collections.Generic;
using System.Reflection;

namespace Underscore.Object.Reflection
{

	public class Str
	{
		public void Strz()
		{
			var str = new String(c: 'A', count: 0);
		}
	}

	public interface IConstructorComponent
	{
		/// <summary>
		/// Returns true if the passed object's type has a public instance parameterless constructor
		/// </summary>
		/// <param name="target">The object whose constructors are going to be searched</param>
		bool HasParameterless(object target);

		/// <summary>
		/// Retunrns true if the passed object's type has a parameterless constructor
		/// </summary>
		/// <param name="target">The object whose constructors are going to be searched</param>
		/// <param name="flags">flags of the parameterless constructor </param>
		bool HasParameterless(object target, BindingFlags flags);

		/// <summary>
		/// Retunrns true if the passed type has a public instance parameterless constructor
		/// </summary>
		/// <param name="target">The type whose constructors are going to be searched</param>
		bool HasParameterless(Type target);

		/// <summary>
		/// Retunrns true if the passed type has a parameterless constructor
		/// </summary>
		/// <param name="target">The type whose constructors are going to be searched</param>
		/// <param name="flags">flags of the parameterless constructor</param>
		bool HasParameterless(Type target, BindingFlags flags);


		/// <summary>
		/// Returns the target object's type's public instance parameterless constructor
		/// </summary>
		/// <param name="target">The object whose Type's constructors are going to be searched</param>
		ConstructorInfo Parameterless(object target);

		/// <summary>
		/// Returns the target object's type's parameterless constructor
		/// </summary>
		/// <param name="flags">flags of the parameterless constructor</param>
		/// <param name="target">The object whose Type's constructors are going to be searched</param>
		ConstructorInfo Parameterless(object target, BindingFlags flags);

		/// <summary>
		/// Returns the target's instance public parameterless constructor
		/// </summary>
		/// <param name="target">The type whose constructors are going to be searched</param>
		ConstructorInfo Parameterless(Type target);

		/// <summary>
		/// Returns the target's parameterless constructor
		/// </summary>
		/// <param name="flags">flags for the constructor</param>
		/// <param name="target">The type whose constructors are going to be searched</param>
		ConstructorInfo Parameterless(Type target, BindingFlags flags);

		/// <summary>
		/// Returns the type's public instance constructor with the least amount of parameters
		/// </summary>
		/// <param name="target">The Type whose constructors are going to be searched</param>
		ConstructorInfo Simplest(Type target);

		/// <summary>
		/// Returns the object's type's public instance constructor with the least amount of parameters
		/// </summary>
		/// <param name="target">The object whose Type's constructors are going to be searched</param>
		ConstructorInfo Simplest(object target);

		/// <summary>
		/// Returns the type's constructor with the least amount of parameters
		/// </summary>
		/// <param name="flags">flags for the constructor</param>
		/// <param name="target">The Type whose constructors are going to be searched</param>
		ConstructorInfo Simplest(Type target, BindingFlags flags);

		/// <summary>
		/// Returns the object's type's constructor with the least amount of parameters
		/// </summary>
		/// <param name="flags"></param>
		/// <param name="target">The object whose constructors are going to be searched</param>
		ConstructorInfo Simplest(object target, BindingFlags flags);

		/// <summary>
		/// Returns a public constructor based off of the query object passed
		/// </summary>
		/// <example>
		/// <code>
		/// //this will return the constructor of string with parameters c and count with matching types
		/// _.Object.Constructor.Find(typeof(string), new { c=typeof(char), count=typeof(int) } 
		/// // this will find the same, matching on the constructor with the first type being a char second being an int
		/// _.Object.Constructor.Find(typeof(string),new[]{typeof(char),typeof(int)})
		/// //this will find the same matching on the name of the parameters
		/// _.Object.Constructor.Find(typeof(string),new[]{"c","count"})
		/// </code>
		/// </example>
		ConstructorInfo Find(Type target, object query);

		/// <summary>
		/// Returns a public constructor based off of the query object passed
		/// </summary>
		/// <example>
		/// <code>
		/// //this will return the constructor of string with parameters c and count with matching types
		/// _.Object.Constructor.Find(typeof(string), new { c=typeof(char), count=typeof(int) } 
		/// // this will find the same, matching on the constructor with the first type being a char second being an int
		/// _.Object.Constructor.Find(typeof(string),new[]{typeof(char),typeof(int)})
		/// //this will find the same matching on the name of the parameters
		/// _.Object.Constructor.Find(typeof(string),new[]{"c","count"})
		/// </code>
		/// </example>
		ConstructorInfo Find(Type target, object query, BindingFlags flags);

		/// <summary>
		/// Returns a public constructor based off of the query object passed
		/// </summary>
		/// <example>
		/// <code>
		/// //this will return the constructor of string with parameters c and count with matching types
		/// _.Object.Constructor.Find(typeof(string), new { c=typeof(char), count=typeof(int) } 
		/// // this will find the same, matching on the constructor with the first type being a char second being an int
		/// _.Object.Constructor.Find(typeof(string),new[]{typeof(char),typeof(int)})
		/// //this will find the same matching on the name of the parameters
		/// _.Object.Constructor.Find(typeof(string),new[]{"c","count"})
		/// </code>
		/// </example>
		ConstructorInfo Find(object target, object query);

		/// <summary>
		/// Returns a public constructor based off of the query object passed
		/// </summary>
		/// <example>
		/// <code>
		/// //this will return the constructor of string with parameters c and count with matching types
		/// _.Object.Constructor.Find(typeof(string), new { c=typeof(char), count=typeof(int) } 
		/// // this will find the same, matching on the constructor with the first type being a char second being an int
		/// _.Object.Constructor.Find(typeof(string),new[]{typeof(char),typeof(int)})
		/// //this will find the same matching on the name of the parameters
		/// _.Object.Constructor.Find(typeof(string),new[]{"c","count"})
		/// </code>
		/// </example>
		ConstructorInfo Find(object target, object query, BindingFlags flags);

		/// <summary>
		/// Returns a public constructors based off of the query object passed
		/// </summary>
		/// <example>
		/// <code>
		/// //this will return the constructor of string with parameters c and count with matching types
		/// _.Object.Constructor.Find(typeof(string), new { c=typeof(char), count=typeof(int) } 
		/// // this will find the same, matching on the constructor with the first type being a char second being an int
		/// _.Object.Constructor.Find(typeof(string),new[]{typeof(char),typeof(int)})
		/// //this will find the same matching on the name of the parameters
		/// _.Object.Constructor.Find(typeof(string),new[]{"c","count"})
		/// </code>
		/// </example>
		IEnumerable<ConstructorInfo> Query(Type target, object query);

		IEnumerable<ConstructorInfo> Query(Type target, object query, BindingFlags flags);

		IEnumerable<ConstructorInfo> Query(object target, object query);

		IEnumerable<ConstructorInfo> Query(object target, object query, BindingFlags flags);

		IEnumerable<ConstructorInfo> All(Type target);

		IEnumerable<ConstructorInfo> All(Type target, BindingFlags flags);

		IEnumerable<ConstructorInfo> All(object target);

		IEnumerable<ConstructorInfo> All(object target, BindingFlags flags);

	}
}
