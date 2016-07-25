using System;
using NUnit.Framework;
using Moq;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
	[TestFixture]
	public class MethodTest
	{

		public class MethodInvokeTestTargetObject
		{

			public bool InvokeWithParametersAndReturnValueWasCalled { get; private set; }
			public string InvokeWithParametersAndReturnValueParameter1 { get; private set; }
			public string InvokeWithParametersAndReturnValueParameter2 { get; private set; }
			public List<string> InvokeWithParameterWithReturnValueParameter1History = new List<string>();
			public List<string> InvokeWithParameterWithReturnValueParameter2History = new List<string>();

			public string InvokeWithParametersAndReturnValue(string parameter1, string parameter2)
			{
				InvokeWithParametersAndReturnValueParameter1 = parameter1;
				InvokeWithParameterWithReturnValueParameter1History.Add(parameter1);
				InvokeWithParametersAndReturnValueParameter2 = parameter2;
				InvokeWithParameterWithReturnValueParameter2History.Add(parameter2);
				InvokeWithParametersAndReturnValueWasCalled = true;

				return parameter1 + " " + parameter2;
			}

			public bool InvokeWithParameterWithoutReturnValueWasCalled { get; private set; }
			public string InvokeWithParameterWithoutReturnValueParameter1 { get; private set; }
			public string InvokeWithParameterWithoutReturnValueParameter2 { get; private set; }
			public List<string> InvokeWithParameterWithoutReturnValueParameter1History = new List<string>();
			public List<string> InvokeWithParameterWithoutReturnValueParameter2History = new List<string>();

			public void InvokeWithParameterWithoutReturnValue(string parameter1, string parameter2)
			{
				InvokeWithParameterWithoutReturnValueWasCalled = true;
				InvokeWithParameterWithoutReturnValueParameter1 = parameter1;
				InvokeWithParameterWithoutReturnValueParameter1History.Add(parameter1);
				InvokeWithParameterWithoutReturnValueParameter2 = parameter2;
				InvokeWithParameterWithoutReturnValueParameter2History.Add(parameter2);
			}

			public bool InvokeWithoutParameterAndWithReturnValueWasCalled { get; private set; }

			private int _invokeWithoutParameterAndWithReturnValueCounter = 1;
			public string InvokeWithoutParameterAndWithReturnValue()
			{
				InvokeWithoutParameterAndWithReturnValueWasCalled = true;
				return ( _invokeWithoutParameterAndWithReturnValueCounter++ ).ToString( );
			}

			public bool InvokeWithoutParameterAndWithoutReturnValueWasCalled { get; private set; }

			public void InvokeWithoutParameterAndWithoutReturnValue()
			{
				InvokeWithoutParameterAndWithoutReturnValueWasCalled = true;
			}
		}

		[Test]
		public void Object_Method_Invoke_WithoutParameterAndWithoutReturnValue()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var result = _.Object.Method.Invoke(testingTarget, "InvokeWithoutParameterAndWithoutReturnValue");

			Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithoutReturnValueWasCalled);
			// when the method is a void just returns null;
			Assert.IsNull(result);
		}

		[Test]
		public void Object_Method_Invoke_WithoutParameterWithReturnValue()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			string result  = (string)_.Object.Method.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

			Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
			Assert.AreEqual("1",result);

			result = (string)_.Object.Method.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
			Assert.AreEqual("2", result);

		}

		[Test]
		public void Object_Method_Invoke_WithoutParameterWithReturnValueGeneric()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			string result = _.Object.Method.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

			Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
			Assert.AreEqual("1", result);

			result = _.Object.Method.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
			Assert.AreEqual("2", result);
		}

		[Test]
		public void Object_Method_Invoke_WithParameterWithoutReturnValue()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			object result = _.Object.Method.Invoke(testingTarget, "InvokeWithParameterWithoutReturnValue","a","b");

			Assert.IsTrue(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);
			Assert.IsNull(result);
			Assert.AreEqual("a",testingTarget.InvokeWithParameterWithoutReturnValueParameter1);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithoutReturnValueParameter2);
		}

		[Test]
		public void Object_Method_Invoke_WithParameterWithReturnValueNonGeneric()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			string result = (string)_.Object.Method.Invoke(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
			Assert.AreEqual("a b" , result);
			Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
			Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
		}

		[Test]
		public void Object_Method_Invoke_WithParameterWithReturnValueGeneric()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			string result = _.Object.Method.Invoke<string>(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
			Assert.AreEqual("a b", result);
			Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
			Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
		}

		[Test]
		public void Object_Method_Invoke_ForAllWithParameterWithoutReturnValueLazy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var result = _.Object.Method.InvokeForAll(testingTarget, "InvokeWithParameterWithoutReturnValue",
				new[] {new object[] {"a", "b"}, new object[] {"c", "d"}, new object[] {"e", "f"}});

			//At first is false because no methods have actually been called yet
			Assert.IsFalse(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);

			foreach (var value in result)
				Assert.IsNull(value);

			//Now will be true
			Assert.IsTrue(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[2]);

			Assert.AreEqual(3,testingTarget.InvokeWithParameterWithoutReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithoutReturnValueParameter2History.Count);

		}

		[Test]
		public void Object_Method_Invoke_ForAllWithParameterWithoutReturnValueGreedy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var result = _.Object.Method.InvokeForAll(testingTarget, "InvokeWithParameterWithoutReturnValue",
				new[] { new object[] { "a", "b" }, new object[] { "c", "d" }, new object[] { "e", "f" } },true);

			//Should be invoked right away, so in this test case the first pull will be true
			Assert.IsTrue(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);

			foreach (var value in result)
				Assert.IsNull(value);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithoutReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithoutReturnValueParameter2History[2]);

			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithoutReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithoutReturnValueParameter2History.Count);

		}

		[Test]
		public void Object_Method_Invoke_ForAllWithParameterWithReturnValueLazy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var tresult =
				_.Object.Method.InvokeForAll(testingTarget, "InvokeWithParametersAndReturnValue",
					new[] {new object[] {"a", "b"}, new object[] {"c", "d"}, new object[] {"e", "f"}});

			Assert.IsFalse(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
			var result = tresult.OfType<string>().ToArray();
			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);

			Assert.AreEqual("a b", result[0]);
			Assert.AreEqual("c d", result[1]);
			Assert.AreEqual("e f", result[2]);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithReturnValueParameter2History[2]);

			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter2History.Count);
		}

		[Test]
		public void Object_Method_Invoke_ForAllWithParameterWithReturnValueGreedy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var tresult =
				_.Object.Method.InvokeForAll(testingTarget, "InvokeWithParametersAndReturnValue",
					new[] { new object[] { "a", "b" }, new object[] { "c", "d" }, new object[] { "e", "f" } },true);

			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
			var result = tresult.OfType<string>().ToArray();

			Assert.AreEqual("a b", result[0]);
			Assert.AreEqual("c d", result[1]);
			Assert.AreEqual("e f", result[2]);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithReturnValueParameter2History[2]);

			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter2History.Count);
		}

		[Test]
		public void Object_Method_InvokeForAllWithParameterWithReturnValueGenericLazy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var tresult =
				_.Object.Method.InvokeForAll<string>(testingTarget, "InvokeWithParametersAndReturnValue",
					new[] { new object[] { "a", "b" }, new object[] { "c", "d" }, new object[] { "e", "f" } });

			Assert.IsFalse(testingTarget.InvokeWithParametersAndReturnValueWasCalled);

			var result = tresult.ToArray();

			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);

			Assert.AreEqual("a b", result[0]);
			Assert.AreEqual("c d", result[1]);
			Assert.AreEqual("e f", result[2]);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithReturnValueParameter2History[2]);

			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter2History.Count);
		}

		[Test]
		public void Object_Method_Invoke_ForAllWithParameterWithReturnGenericGreedy()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var tresult =
				_.Object.Method.InvokeForAll<string>(testingTarget, "InvokeWithParametersAndReturnValue",
					new[] { new object[] { "a", "b" }, new object[] { "c", "d" }, new object[] { "e", "f" } },true);

			Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);

			var result = tresult.ToArray();

			Assert.AreEqual("a b", result[0]);
			Assert.AreEqual("c d", result[1]);
			Assert.AreEqual("e f", result[2]);

			Assert.AreEqual("a", testingTarget.InvokeWithParameterWithReturnValueParameter1History[0]);
			Assert.AreEqual("b", testingTarget.InvokeWithParameterWithReturnValueParameter2History[0]);

			Assert.AreEqual("c", testingTarget.InvokeWithParameterWithReturnValueParameter1History[1]);
			Assert.AreEqual("d", testingTarget.InvokeWithParameterWithReturnValueParameter2History[1]);

			Assert.AreEqual("e", testingTarget.InvokeWithParameterWithReturnValueParameter1History[2]);
			Assert.AreEqual("f", testingTarget.InvokeWithParameterWithReturnValueParameter2History[2]);

			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter1History.Count);
			Assert.AreEqual(3, testingTarget.InvokeWithParameterWithReturnValueParameter2History.Count);
		}
		
		[Test]
		public void Object_Method_Query_TargetInstanceNoArgs()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var target = new MethodMethodsTestFixture();
			

			//all methods with no params
			var methods = _.Object.Method.Query(target, new { });
			var infos = methods as MethodInfo[] ?? methods.ToArray();

			//query does a deep search unlike all which will only give all from declaring type
			Assert.AreEqual(5, infos.Count());
			
			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowStringReturnValue"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ToString"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ToString"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "GetHashCode"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "GetHashCode"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "GetType"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "GetType"));

			Assert.IsTrue(infos.All(a=>a.GetParameters().Length == 0));

		}

		[Test]
		public void Object_Method_Query_TargetInstanceReturnType()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var target = new MethodMethodsTestFixture();
			
			//all void methods
			var methods = _.Object.Method.Query(target, new { @return=typeof(void) });
			var infos = methods as MethodInfo[] ?? methods.ToArray();

			Assert.AreEqual(4, infos.Count());
			
			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
			Assert.AreEqual(3, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
		}
		
		[Test]
		public void Object_Method_Query_TargetInstanceReturnOverride()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var target = new MethodMethodsTestFixture();

			//all void methods
			var methods = _.Object.Method.Query(target, new { @return = new { parameterType= typeof(string) } });
			var infos = methods as MethodInfo[] ?? methods.ToArray();

			Assert.AreEqual(1, infos.Count());
			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
		}
		
		[Test]
		public void Object_Method_Query_TargetInstanceOneArgNames()
		{
			var testingTarget = new MethodInvokeTestTargetObject();

			var target = new MethodMethodsTestFixture();
			
			var singleParamName1 = _.Object.Method.Query(target, "arg");
			var singleParamName2 = _.Object.Method.Query(target, new[] { "arg" });

			var singParamName1Arr = singleParamName1 as MethodInfo[] ?? singleParamName1.ToArray();
			Assert.IsTrue(singParamName1Arr.Count() == 1);

			var sngParamName2Arr = singleParamName2 as MethodInfo[] ?? singleParamName2.ToArray();
			Assert.IsTrue(sngParamName2Arr.Count() == 1);

			Assert.IsTrue(
				singParamName1Arr.Count(a => a.GetParameters().Count() == 1
				&& a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
			) == 1);

			Assert.AreEqual(singParamName1Arr.FirstOrDefault(), sngParamName2Arr.FirstOrDefault());
		}

		[Test]
		public void Object_Method_Query_TargetInstanceOneArgType()
		{

			
			var target = new MethodMethodsTestFixture();


			//gets the methods where the number of args with a single string parameter using just a type as an arg
			var byOneType = _.Object.Method.Query(target, typeof(string));

			//is logically equivelant to this linq expression
			Assert.IsTrue(
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a => a.GetParameters().Length == 1 
							&& a.GetParameters().First().ParameterType == typeof(string)
							&& !a.IsSpecialName
					 )
					.SequenceEqual(byOneType));

			//This should produce the same results
			var byOneTypeInArray = _.Object.Method.Query(target, new[] { typeof(string) });

			Assert.IsTrue(byOneType.SequenceEqual(byOneTypeInArray));
			

		}
		
		[Test]
		public void Object_Method_Query_TargetInstanceOneArgAnonObj()
		{

			
			var target = new MethodMethodsTestFixture();


			//gets the methods where the number of args with a single string parameter using just a type as an arg
			var byAnonObj = _.Object.Method.Query(target, new {arg= typeof(string)});

			//is logically equivelant to this linq expression
			Assert.IsTrue(
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a => a.GetParameters().Length == 1
							&& a.GetParameters().Count(b=>b.ParameterType == typeof(string) && b.Name=="arg")==1
							&& !a.IsSpecialName
					 )
					.SequenceEqual(byAnonObj));
			

		}

		[Test]
		public void Object_Methods_Query_InstanceTwoArgNames()
		{

			
			var target = new MethodMethodsTestFixture();


			//gets the methods with parameters named "arg1" and "arg2"
			var doubleParamNames = _.Object.Method.Query(target, new[] { "arg1","arg2" });


			Assert.IsTrue(
				//logicall equivelant to 
				typeof (MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							new[] {"arg1", "arg2"}.SequenceEqual(a.GetParameters().Select(b => b.Name).ToList()))
					.SequenceEqual(doubleParamNames));

			
			
		}
		
		[Test]
		public void Object_Methods_Query_InstanceTwoArgTypes()
		{

			
			var target = new MethodMethodsTestFixture();


			var doubleTypeParams = _.Object.Method.Query(target, new[] { typeof(string), typeof(string)});


			Assert.IsTrue(
				//is logically equivalent to the following
				typeof (MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							new[] {typeof (string), typeof (string)}.SequenceEqual(
								a.GetParameters().Select(b => b.ParameterType)))
					.SequenceEqual(doubleTypeParams));


		}
		
		[Test]
		public void Object_Methods_Query_InstanceTwoArgAnonymousObject()
		{
			var target = new MethodMethodsTestFixture();

			var dblAnonParam = _.Object.Method.Query(target, new{  arg1=typeof(string), arg2=typeof(string) });

			Assert.IsTrue(
				//is logically equivalent to the following
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							a.GetParameters().Count(b=>b.Name=="arg1" && b.ParameterType==typeof(string))==1 &&
							a.GetParameters().Count(b=>b.Name=="arg2" && b.ParameterType==typeof(string))==1
					)
					.SequenceEqual(dblAnonParam));

		}
		
		[Test]
		public void Object_Method_Query_TargetTypeNoArgs()
		{
			var target = typeof(MethodMethodsTestFixture);

			var methods = _.Object.Method.Query(target, new {});

			//query does a deep search unlike all which will only give all from declaring type
			Assert.AreEqual(5, methods.Count());

			Assert.IsNotNull(methods.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
			Assert.AreEqual(1, methods.Count(a => a.Name == "ShouldShowNoReturnValue"));

			Assert.IsNotNull(methods.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
			Assert.AreEqual(1, methods.Count(a => a.Name == "ShouldShowStringReturnValue"));

			Assert.IsNotNull(methods.FirstOrDefault(a => a.Name == "ToString"));
			Assert.AreEqual(1, methods.Count(a => a.Name == "ToString"));

			Assert.IsNotNull(methods.FirstOrDefault(a => a.Name == "GetHashCode"));
			Assert.AreEqual(1, methods.Count(a => a.Name == "GetHashCode"));

			Assert.IsNotNull(methods.FirstOrDefault(a => a.Name == "GetType"));
			Assert.AreEqual(1, methods.Count(a => a.Name == "GetType"));

			Assert.IsTrue(methods.All(a => a.GetParameters().Length == 0));
		}

		[Test]
		public void Object_Method_Query_TargetTypeReturnType()
		{

			var target = typeof(MethodMethodsTestFixture);

			//all void methods
			var methods = _.Object.Method.Query(target, new { @return = typeof(void) });
			var infos = methods as MethodInfo[] ?? methods.ToArray();

			Assert.AreEqual(4, infos.Count());

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
			Assert.AreEqual(3, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
		}

		[Test]
		public void Object_Method_Query_TargetTypeReturnOverride()
		{

			var target = typeof(MethodMethodsTestFixture);

			//all void methods
			var methods = _.Object.Method.Query(target, new { @return = new { parameterType = typeof(string) } });
			var infos = methods as MethodInfo[] ?? methods.ToArray();

			Assert.AreEqual(1, infos.Count());
			Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
			Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
		}

		[Test]
		public void Object_Method_Query_TargetTypeOneArgNames()
		{

			
			var target = typeof(MethodMethodsTestFixture);

			var singleParamName1 = _.Object.Method.Query(target, "arg");
			var singleParamName2 = _.Object.Method.Query(target, new[] { "arg" });

			var singParamName1Arr = singleParamName1 as MethodInfo[] ?? singleParamName1.ToArray();
			Assert.IsTrue(singParamName1Arr.Count() == 1);

			var sngParamName2Arr = singleParamName2 as MethodInfo[] ?? singleParamName2.ToArray();
			Assert.IsTrue(sngParamName2Arr.Count() == 1);

			Assert.IsTrue(
				singParamName1Arr.Count(a => a.GetParameters().Count() == 1
				&& a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
			) == 1);

			Assert.AreEqual(singParamName1Arr.FirstOrDefault(), sngParamName2Arr.FirstOrDefault());
		}

		[Test]
		public void Object_Method_Query_TargetTypeOneArgType()
		{

			
			var target = typeof(MethodMethodsTestFixture);


			//gets the methods where the number of args with a single string parameter using just a type as an arg
			var byOneType = _.Object.Method.Query(target, typeof(string));

			//is logically equivelant to this linq expression
			Assert.IsTrue(
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a => a.GetParameters().Length == 1
							&& a.GetParameters().First().ParameterType == typeof(string)
							&& !a.IsSpecialName
					 )
					.SequenceEqual(byOneType));

			//This should produce the same results
			var byOneTypeInArray = _.Object.Method.Query(target, new[] { typeof(string) });

			Assert.IsTrue(byOneType.SequenceEqual(byOneTypeInArray));


		}

		[Test]
		public void Object_Method_Query_TargetTypeOneArgAnonObj()
		{

			
			var target = typeof(MethodMethodsTestFixture);


			//gets the methods where the number of args with a single string parameter using just a type as an arg
			var byAnonObj = _.Object.Method.Query(target, new { arg = typeof(string) });

			//is logically equivelant to this linq expression
			Assert.IsTrue(
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a => a.GetParameters().Length == 1
							&& a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
							&& !a.IsSpecialName
					 )
					.SequenceEqual(byAnonObj));


		}

		[Test]
		public void Object_Methods_Query_TypeTwoArgNames()
		{

			
			var target = typeof(MethodMethodsTestFixture);


			//gets the methods with parameters named "arg1" and "arg2"
			var doubleParamNames = _.Object.Method.Query(target, new[] { "arg1", "arg2" });


			Assert.IsTrue(
				//logicall equivelant to 
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							new[] { "arg1", "arg2" }.SequenceEqual(a.GetParameters().Select(b => b.Name).ToList()))
					.SequenceEqual(doubleParamNames));



		}

		[Test]
		public void Object_Methods_Query_TypeTwoArgTypes()
		{

			
			var target = typeof(MethodMethodsTestFixture);


			var doubleTypeParams = _.Object.Method.Query(target, new[] { typeof(string), typeof(string) });


			Assert.IsTrue(
				//is logically equivalent to the following
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							new[] { typeof(string), typeof(string) }.SequenceEqual(
								a.GetParameters().Select(b => b.ParameterType)))
					.SequenceEqual(doubleTypeParams));


		}

		[Test]
		public void Object_Methods_Query_TypeTwoArgAnonymousObject()
		{

			var target = typeof(MethodMethodsTestFixture);


			var dblAnonParam = _.Object.Method.Query(target, new { arg1 = typeof(string), arg2 = typeof(string) });

			Assert.IsTrue(
				//is logically equivalent to the following
				typeof(MethodMethodsTestFixture).GetMethods()
					.Where(
						a =>
							a.GetParameters().Length == 2 &&
							!a.IsSpecialName &&
							a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
							a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1
					)
					.SequenceEqual(dblAnonParam));

		}
		
		[Test]
		public void Object_Methods_All_InstanceArg()
		{

			var target = new MethodMethodsTestFixture();
			var result = _.Object.Method.All(target);

			Assert.IsTrue(
				//should be logically equal to this
				typeof (MethodMethodsTestFixture).GetMethods()
				.Where(a => !a.IsSpecialName && a.DeclaringType==typeof(MethodMethodsTestFixture))
				.SequenceEqual(result));



		}

		[Test]
		public void Object_Method_All_TypeArg()
		{

			var target = typeof(MethodMethodsTestFixture);
			var result = _.Object.Method.All(target);

			Assert.IsTrue(
				//should be logically equal to this
				typeof(MethodMethodsTestFixture).GetMethods()
				.Where(a => !a.IsSpecialName && a.DeclaringType == typeof(MethodMethodsTestFixture))
				.SequenceEqual(result));


		}

		

		private static void SetupAll<T>(Mock<IPropertyComponent> mock, T targeting, IEnumerable<PropertyInfo> results)
		{
			var hresults = results;
			mock.Setup(
				a => a.All(It.Is<object>(
					b => (b != null && b.GetType() == typeof(T))
						 || (b != null && b.GetType() == typeof(Type) && ((Type)b) == typeof(T))
					))
				).Returns(hresults);
		}


		private class MethodMethodsTestFixture
		{
			public void ShouldShowNoReturnValue( ) { }
			private void ShouldntShowNoReturnValue( ) { }

			public void ShouldShowNoReturnValue( string arg ) { }
			private void ShouldntShowNoReturnValue( string arg ) { }

			public void ShouldShowNoReturnValue( string arg1, string arg2 ) { }
			private void ShouldntShowNoReturnValue( string arg, string arg2 ) { }

			public void ReturnAsAParameter(string @return) { }

			public string ShouldShowStringReturnValue( ) { return String.Empty; }
			private string ShouldntShowStringReturnValue( ) { return String.Empty; }

			public string PublicPropertyShouldNotShow { get; set; }
			private string PrivatePropertyShouldNotShow { get; set; }
		}

		private static IEnumerable<MethodInfo> AllMethodsInfo( ) 
		{
			return typeof( MethodMethodsTestFixture ).GetMethods( BindingFlags.Public | BindingFlags.Instance ).Where(a=>!a.IsSpecialName && !a.IsConstructor);
		}
		
		[Test]
		public void Object_Method_Find_TargetInstanceFindWithSingleItemNoParameters()
		{

			var target = new MethodMethodsTestFixture();

			var results = new[]
			{
						_.Object.Method.Find(target, "ShouldShowNoReturnValue"),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {}),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", new object[] {}),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", null)
			};

			//equivelant to
			var expecting =
				typeof (MethodMethodsTestFixture)
					.GetMethods()
					.First(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 0);

			Assert.IsTrue(results.All(a=>a==expecting));
		}

		[Test]
		public void Object_Method_Find_TargetInstanceFindWithSingleItemOneParameter()
		{

			var target = new MethodMethodsTestFixture();

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", typeof (string)),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof (string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg"}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", "arg")
			};

			//equivelant to
			var expecting =
				typeof (MethodMethodsTestFixture)
					.GetMethods()
					.First(
						a =>
							a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 1 &&
							a.GetParameters().Count(b => b.Name == "arg" && b.ParameterType == typeof (string)) == 1);

			Assert.IsTrue(results.All(a => a == expecting));
		}
		
		[Test]
		public void Object_Method_Find_TargetInstanceFindWithSingleItemTwoParameter()
		{

			var target = new MethodMethodsTestFixture();

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2=typeof(string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg1","arg2"}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof(string),typeof(string)}),
			};

			//equivelant to
			var expecting =
				typeof(MethodMethodsTestFixture)
					.GetMethods()
					.First(
						a =>
							a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2 &&
							a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
							a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1);

			Assert.IsTrue(results.All(a => a == expecting));
		}


		[Test]
		public void Object_Method_Find_TargetInstanceFindFailsForPrivateByDefault()
		{

			var target = new MethodMethodsTestFixture();

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue"),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {}),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {}),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", null)
			};

			Assert.IsTrue(results.All(a => a == null));
		}

		[Test]
		public void Object_Method_Find_TargetInstanceFindWorksForPrivateUsingBindingFlag()
		{

			var target = new MethodMethodsTestFixture();

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue",BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {},BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {},BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", null,BindingFlags.Instance|BindingFlags.NonPublic)
			};

			var expecting =
				typeof(MethodMethodsTestFixture).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
					.FirstOrDefault(a => a.Name == "ShouldntShowNoReturnValue");

			Assert.IsTrue(results.All(a => a == expecting));
		}


		[Test]
		public void Object_Method_Find_TargetInstanceFindFailsForPropertyMethods()
		{
			var target = new MethodMethodsTestFixture();

			Assert.IsNull(_.Object.Method.Find(target, "get_PublicPropertyShouldNotShow"));
			Assert.IsNull(_.Object.Method.Find(target, "get_PrivatePropertyShouldNotShow"));

			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new { value = typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new[] { typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", typeof(string)));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new[] { "value" }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", "value"));

			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow"));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new { value = typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new[] { typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", typeof(string)));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new[] { "value" }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", "value"));
		}


		[Test]
		public void Object_Method_Find_TargetTypeFindWithSingleItemNoParameters()
		{

			var target = typeof(MethodMethodsTestFixture);

			var results = new[]
			{
						_.Object.Method.Find(target, "ShouldShowNoReturnValue"),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {}),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", new object[] {}),
						_.Object.Method.Find(target, "ShouldShowNoReturnValue", null)
			};

			//equivelant to
			var expecting =
				typeof(MethodMethodsTestFixture)
					.GetMethods()
					.First(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 0);

			Assert.IsTrue(results.All(a => a == expecting));
		}

		[Test]
		public void Object_Method_Find_TargetTypeFindWithSingleItemOneParameter()
		{

			var target = typeof(MethodMethodsTestFixture);

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", typeof (string)),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof (string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg"}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", "arg")
			};

			//equivelant to
			var expecting =
				typeof(MethodMethodsTestFixture)
					.GetMethods()
					.First(
						a =>
							a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 1 &&
							a.GetParameters().Count(b => b.Name == "arg" && b.ParameterType == typeof(string)) == 1);

			Assert.IsTrue(results.All(a => a == expecting));
		}

		[Test]
		public void Object_Method_Find_TargetTypeFindWithSingleItemTwoParameter()
		{

			var target =  typeof(MethodMethodsTestFixture);

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2=typeof(string)}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg1","arg2"}),
				_.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof(string),typeof(string)}),
			};

			//equivelant to
			var expecting =
				typeof(MethodMethodsTestFixture)
					.GetMethods()
					.First(
						a =>
							a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2 &&
							a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
							a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1);

			Assert.IsTrue(results.All(a => a == expecting));
		}

		[Test]
		public void Object_Method_Find_TargetTypeFindFailsForPrivateByDefault()
		{

			var target = typeof(MethodMethodsTestFixture);

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue"),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {}),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {}),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", null)
			};

			Assert.IsTrue(results.All(a=>a==null));
		}

		[Test]
		public void Object_Method_Find_TargetTypeFindWorksForPrivateUsingBindingFlag()
		{

			var target = typeof(MethodMethodsTestFixture);

			var results = new[]
			{
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue",BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {},BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {},BindingFlags.Instance|BindingFlags.NonPublic),
				_.Object.Method.Find(target, "ShouldntShowNoReturnValue", null,BindingFlags.Instance|BindingFlags.NonPublic)
			};

			var expecting =
				typeof (MethodMethodsTestFixture).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
					.FirstOrDefault(a => a.Name == "ShouldntShowNoReturnValue");

			Assert.IsTrue(results.All(a => a == expecting));
		}
		
		[Test]
		public void Object_Method_Find_TargetTypeFindFailsForPropertyMethods()
		{
			var target = typeof (MethodMethodsTestFixture);

			Assert.IsNull(_.Object.Method.Find(target, "get_PublicPropertyShouldNotShow"));
			Assert.IsNull(_.Object.Method.Find(target, "get_PrivatePropertyShouldNotShow"));

			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new { value = typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new[] { typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", typeof(string)));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", new[] { "value" }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PublicPropertyShouldNotShow", "value"));

			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow"));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new { value = typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new[] { typeof(string) }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", typeof(string)));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", new[] { "value" }));
			Assert.IsNull(_.Object.Method.Find(target, "set_PrivatePropertyShouldNotShow", "value"));
		}
		
		[Test]
		public void Object_Method_Find_TargetInstanceReturnParameterOverride()
		{
			var target = new MethodMethodsTestFixture();

			var result = _.Object.Method.Find(target, new { @return = new { parameterType=typeof(string) } });

			Assert.IsNotNull(result);
			Assert.AreEqual(result, _.Object.Method.Find(target, "ReturnAsAParameter"));

		}


		[Test]
		public void Object_Method_Find_TargetTypeReturnParameterOverride()
		{
			var target = typeof(MethodMethodsTestFixture);

			var result = _.Object.Method.Find(target, new { @return = new { parameterType = typeof(string) } });

			Assert.IsNotNull(result);
			Assert.AreEqual(result, _.Object.Method.Find(target, "ReturnAsAParameter"));

		}

		[Test]
		public void Object_Method_Find_TargetInstanceSkippingArguments()
		{
			var target = new MethodMethodsTestFixture();

			var expecting = typeof (MethodMethodsTestFixture).GetMethods().FirstOrDefault(a=> a.Name == "ShouldShowNoReturnValue" &&  a.GetParameters().Length == 2);

			var result = _.Object.Method.Find(target, new [] {null, typeof(string)});

			Assert.AreEqual(expecting,result);
			
		}


		[Test]
		public void Object_Method_Find_TargetTypeSkippingArguments()
		{
			var target = typeof(MethodMethodsTestFixture);

			var expecting = typeof(MethodMethodsTestFixture).GetMethods().FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2);

			var result = _.Object.Method.Find(target, new[] { null, typeof(string) });

			Assert.AreEqual(expecting, result);

		}

		[Test]
		public void Object_Method_Has_TargetHasNoArgs()
		{
			var target = new MethodMethodsTestFixture();

			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue"));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new {}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new object[] {}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", null));

			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue"));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new {}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new object[] {}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", null));

			var shouldShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldShowNoReturnValue"),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new {}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new object[] {}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", null)
			};

			foreach (var result in shouldShowMethods)
				Assert.IsTrue(result);

			var shouldntShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue"),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new {}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new object[] {}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", null)
			};

			foreach (var result in shouldntShowMethods)
				Assert.IsFalse(result);
		}

		public void Object_Method_Has_TargetHasOneArg()
		{
			var target = new MethodMethodsTestFixture();
			

			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string)}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", typeof (string)));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {"arg"}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", "arg"));

			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new {arg = typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", typeof (string)));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {"arg"}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", "arg"));

			var shouldShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string)}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {"arg"})
			};

			foreach (var result in shouldShowMethods)
				Assert.IsTrue(result);

			var shouldntShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new {arg = typeof (string)}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string)}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {"arg"})
			};

			foreach (var result in shouldntShowMethods)
				Assert.IsFalse(result);

		}

		[Test]
		public void Object_Method_Has_TargetHasTwoArgs()
		{
			var target = new MethodMethodsTestFixture();
			

			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue",
				new {arg1 = typeof (string), arg2 = typeof (string)}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}));
			Assert.IsTrue(_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"}));

			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue",
				new {arg1 = typeof (string), arg2 = typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"}));

			var shouldShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2 = typeof (string)}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}),
				_.Object.Method.Has(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"})
			};

			foreach (var result in shouldShowMethods)
				Assert.IsTrue(result);

			var shouldntShowMethods = new[]
			{
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new {arg1 = typeof (string), arg2 = typeof (string)}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}),
				_.Object.Method.Has(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"})
			};

			foreach (var result in shouldntShowMethods)
				Assert.IsFalse(result);

		}

		[Test]
		public void Object_Method_Has_DoesNotMatchPropertyMethods()
		{
			var target = new MethodMethodsTestFixture();
			

			Assert.IsFalse(_.Object.Method.Has(target, "get_PublicPropertyShouldNotShow"));
			Assert.IsFalse(_.Object.Method.Has(target, "get_PrivatePropertyShouldNotShow"));

			Assert.IsFalse(_.Object.Method.Has(target, "set_PublicPropertyShouldNotShow", new {value = typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PublicPropertyShouldNotShow", new[] {typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PublicPropertyShouldNotShow", typeof (string)));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PublicPropertyShouldNotShow", new[] {"value"}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PublicPropertyShouldNotShow", "value"));

			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow"));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow", new {value = typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow", new[] {typeof (string)}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow", typeof (string)));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow", new[] {"value"}));
			Assert.IsFalse(_.Object.Method.Has(target, "set_PrivatePropertyShouldNotShow", "value"));

		}
		
		

	}
}
