using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Function;
using Underscore.Object.Reflection;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Underscore.Test.Object.Reflection
{
    [TestClass]
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

        [TestMethod]
        public void Object_Method_Invoke_WithoutParameterAndWithoutReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var result = testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithoutReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithoutReturnValueWasCalled);
            // when the method is a void just returns null;
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Object_Method_Invoke_WithoutParameterWithReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            string result  = (string)testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
            Assert.AreEqual("1",result);

            result = (string)testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
            Assert.AreEqual("2", result);

        }

        [TestMethod]
        public void Object_Method_Invoke_WithoutParameterWithReturnValueGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            string result = testing.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
            Assert.AreEqual("1", result);

            result = testing.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
            Assert.AreEqual("2", result);
        }

        [TestMethod]
        public void Object_Method_Invoke_WithParameterWithoutReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            object result = testing.Invoke(testingTarget, "InvokeWithParameterWithoutReturnValue","a","b");

            Assert.IsTrue(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);
            Assert.IsNull(result);
            Assert.AreEqual("a",testingTarget.InvokeWithParameterWithoutReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParameterWithoutReturnValueParameter2);
        }

        [TestMethod]
        public void Object_Method_Invoke_WithParameterWithReturnValueNonGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            string result = (string)testing.Invoke(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

            Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
            Assert.AreEqual("a b" , result);
            Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
        }

        [TestMethod]
        public void Object_Method_Invoke_WithParameterWithReturnValueGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            string result = testing.Invoke<string>(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

            Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
            Assert.AreEqual("a b", result);
            Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
        }

        [TestMethod]
        public void Object_Method_Invoke_ForAllWithParameterWithoutReturnValueLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var result = testing.InvokeForAll(testingTarget, "InvokeWithParameterWithoutReturnValue",
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

        [TestMethod]
        public void Object_Method_Invoke_ForAllWithParameterWithoutReturnValueGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var result = testing.InvokeForAll(testingTarget, "InvokeWithParameterWithoutReturnValue",
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

        [TestMethod]
        public void Object_Method_Invoke_ForAllWithParameterWithReturnValueLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var tresult =
                testing.InvokeForAll(testingTarget, "InvokeWithParametersAndReturnValue",
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

        [TestMethod]
        public void Object_Method_Invoke_ForAllWithParameterWithReturnValueGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var tresult =
                testing.InvokeForAll(testingTarget, "InvokeWithParametersAndReturnValue",
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

        [TestMethod]
        public void Object_Method_InvokeForAllWithParameterWithReturnValueGenericLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var tresult =
                testing.InvokeForAll<string>(testingTarget, "InvokeWithParametersAndReturnValue",
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

        [TestMethod]
        public void Object_Method_Invoke_ForAllWithParameterWithReturnGenericGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = _.Object.Method;

            var tresult =
                testing.InvokeForAll<string>(testingTarget, "InvokeWithParametersAndReturnValue",
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
        
        [TestMethod]
        public void Object_Method_Query_TargetInstanceNoArgs()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();
            

            //all methods with no params
            var methods = testing.Query(target, new { });
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

        [TestMethod]
        public void Object_Method_Query_TargetInstanceReturnType()
        {

            var target = new MethodMethodsTestClass();
            
            //all void methods
            var methods = _.Object.Method.Query(target, new { @return=typeof(void) });
            var infos = methods as MethodInfo[] ?? methods.ToArray();

            Assert.AreEqual(4, infos.Count());
            
            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
            Assert.AreEqual(3, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
        }
        
        [TestMethod]
        public void Object_Method_Query_TargetInstanceReturnOverride()
        {

            var target = new MethodMethodsTestClass();

            //all void methods
            var methods = _.Object.Method.Query(target, new { @return = new { parameterType= typeof(string) } });
            var infos = methods as MethodInfo[] ?? methods.ToArray();

            Assert.AreEqual(1, infos.Count());
            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
        }
        
        [TestMethod]
        public void Object_Method_Query_TargetInstanceOneArgNames()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();
            
            var singleParamName1 = testing.Query(target, "arg");
            var singleParamName2 = testing.Query(target, new[] { "arg" });

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

        [TestMethod]
        public void Object_Method_Query_TargetInstanceOneArgType()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();


            //gets the methods where the number of args with a single string parameter using just a type as an arg
            var byOneType = testing.Query(target, typeof(string));

            //is logically equivelant to this linq expression
            Assert.IsTrue(
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a => a.GetParameters().Length == 1 
                            && a.GetParameters().First().ParameterType == typeof(string)
                            && !a.IsSpecialName
                     )
                    .SequenceEqual(byOneType));

            //This should produce the same results
            var byOneTypeInArray = testing.Query(target, new[] { typeof(string) });

            Assert.IsTrue(byOneType.SequenceEqual(byOneTypeInArray));
            

        }
        
        [TestMethod]
        public void Object_Method_Query_TargetInstanceOneArgAnonObj()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();


            //gets the methods where the number of args with a single string parameter using just a type as an arg
            var byAnonObj = testing.Query(target, new {arg= typeof(string)});

            //is logically equivelant to this linq expression
            Assert.IsTrue(
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a => a.GetParameters().Length == 1
                            && a.GetParameters().Count(b=>b.ParameterType == typeof(string) && b.Name=="arg")==1
                            && !a.IsSpecialName
                     )
                    .SequenceEqual(byAnonObj));
            

        }

        [TestMethod]
        public void Object_Methods_Query_InstanceTwoArgNames()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();


            //gets the methods with parameters named "arg1" and "arg2"
            var doubleParamNames = testing.Query(target, new[] { "arg1","arg2" });


            Assert.IsTrue(
                //logicall equivelant to 
                typeof (MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            new[] {"arg1", "arg2"}.SequenceEqual(a.GetParameters().Select(b => b.Name).ToList()))
                    .SequenceEqual(doubleParamNames));

            
            
        }
        
        [TestMethod]
        public void Object_Methods_Query_InstanceTwoArgTypes()
        {

            var testing = _.Object.Method;
            var target = new MethodMethodsTestClass();


            var doubleTypeParams = testing.Query(target, new[] { typeof(string), typeof(string)});


            Assert.IsTrue(
                //is logically equivalent to the following
                typeof (MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            new[] {typeof (string), typeof (string)}.SequenceEqual(
                                a.GetParameters().Select(b => b.ParameterType)))
                    .SequenceEqual(doubleTypeParams));


        }
        
        [TestMethod]
        public void Object_Methods_Query_InstanceTwoArgAnonymousObject()
        {

            var target = new MethodMethodsTestClass();


            var dblAnonParam = _.Object.Method.Query(target, new{  arg1=typeof(string), arg2=typeof(string) });

            Assert.IsTrue(
                //is logically equivalent to the following
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            a.GetParameters().Count(b=>b.Name=="arg1" && b.ParameterType==typeof(string))==1 &&
                            a.GetParameters().Count(b=>b.Name=="arg2" && b.ParameterType==typeof(string))==1
                    )
                    .SequenceEqual(dblAnonParam));

        }
        
        [TestMethod]
        public void Object_Method_Query_TargetTypeNoArgs()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);

            var methods = testing.Query(target, new {});

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

        [TestMethod]
        public void Object_Method_Query_TargetTypeReturnType()
        {

            var target = typeof(MethodMethodsTestClass);

            //all void methods
            var methods = _.Object.Method.Query(target, new { @return = typeof(void) });
            var infos = methods as MethodInfo[] ?? methods.ToArray();

            Assert.AreEqual(4, infos.Count());

            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
            Assert.AreEqual(3, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
        }

        [TestMethod]
        public void Object_Method_Query_TargetTypeReturnOverride()
        {

            var target = typeof(MethodMethodsTestClass);

            //all void methods
            var methods = _.Object.Method.Query(target, new { @return = new { parameterType = typeof(string) } });
            var infos = methods as MethodInfo[] ?? methods.ToArray();

            Assert.AreEqual(1, infos.Count());
            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ReturnAsAParameter"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ReturnAsAParameter"));
        }

        [TestMethod]
        public void Object_Method_Query_TargetTypeOneArgNames()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);

            var singleParamName1 = testing.Query(target, "arg");
            var singleParamName2 = testing.Query(target, new[] { "arg" });

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

        [TestMethod]
        public void Object_Method_Query_TargetTypeOneArgType()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);


            //gets the methods where the number of args with a single string parameter using just a type as an arg
            var byOneType = testing.Query(target, typeof(string));

            //is logically equivelant to this linq expression
            Assert.IsTrue(
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a => a.GetParameters().Length == 1
                            && a.GetParameters().First().ParameterType == typeof(string)
                            && !a.IsSpecialName
                     )
                    .SequenceEqual(byOneType));

            //This should produce the same results
            var byOneTypeInArray = testing.Query(target, new[] { typeof(string) });

            Assert.IsTrue(byOneType.SequenceEqual(byOneTypeInArray));


        }

        [TestMethod]
        public void Object_Method_Query_TargetTypeOneArgAnonObj()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);


            //gets the methods where the number of args with a single string parameter using just a type as an arg
            var byAnonObj = testing.Query(target, new { arg = typeof(string) });

            //is logically equivelant to this linq expression
            Assert.IsTrue(
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a => a.GetParameters().Length == 1
                            && a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
                            && !a.IsSpecialName
                     )
                    .SequenceEqual(byAnonObj));


        }

        [TestMethod]
        public void Object_Methods_Query_TypeTwoArgNames()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);


            //gets the methods with parameters named "arg1" and "arg2"
            var doubleParamNames = testing.Query(target, new[] { "arg1", "arg2" });


            Assert.IsTrue(
                //logicall equivelant to 
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            new[] { "arg1", "arg2" }.SequenceEqual(a.GetParameters().Select(b => b.Name).ToList()))
                    .SequenceEqual(doubleParamNames));



        }

        [TestMethod]
        public void Object_Methods_Query_TypeTwoArgTypes()
        {

            var testing = _.Object.Method;
            var target = typeof(MethodMethodsTestClass);


            var doubleTypeParams = testing.Query(target, new[] { typeof(string), typeof(string) });


            Assert.IsTrue(
                //is logically equivalent to the following
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            new[] { typeof(string), typeof(string) }.SequenceEqual(
                                a.GetParameters().Select(b => b.ParameterType)))
                    .SequenceEqual(doubleTypeParams));


        }

        [TestMethod]
        public void Object_Methods_Query_TypeTwoArgAnonymousObject()
        {

            var target = typeof(MethodMethodsTestClass);


            var dblAnonParam = _.Object.Method.Query(target, new { arg1 = typeof(string), arg2 = typeof(string) });

            Assert.IsTrue(
                //is logically equivalent to the following
                typeof(MethodMethodsTestClass).GetMethods()
                    .Where(
                        a =>
                            a.GetParameters().Length == 2 &&
                            !a.IsSpecialName &&
                            a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
                            a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1
                    )
                    .SequenceEqual(dblAnonParam));

        }
        
        [TestMethod]
        public void Object_Methods_All_InstanceArg()
        {

            var target = new MethodMethodsTestClass();
            var result = _.Object.Method.All(target);

            Assert.IsTrue(
                //should be logically equal to this
                typeof (MethodMethodsTestClass).GetMethods()
                .Where(a => !a.IsSpecialName && a.DeclaringType==typeof(MethodMethodsTestClass))
                .SequenceEqual(result));



        }

        [TestMethod]
        public void Object_Method_All_TypeArg()
        {

            var target = typeof(MethodMethodsTestClass);
            var result = _.Object.Method.All(target);

            Assert.IsTrue(
                //should be logically equal to this
                typeof(MethodMethodsTestClass).GetMethods()
                .Where(a => !a.IsSpecialName && a.DeclaringType == typeof(MethodMethodsTestClass))
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


        private class MethodMethodsTestClass
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
            return typeof( MethodMethodsTestClass ).GetMethods( BindingFlags.Public | BindingFlags.Instance ).Where(a=>!a.IsSpecialName && !a.IsConstructor);
        }
        
        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindWithSingleItemNoParameters()
        {

            var target = new MethodMethodsTestClass();

            var results = new[]
            {
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue"),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", new {}),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", new object[] {}),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", null)
            };

            //equivelant to
            var expecting =
                typeof (MethodMethodsTestClass)
                    .GetMethods()
                    .First(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 0);

            Assert.IsTrue(results.All(a=>a==expecting));
        }

        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindWithSingleItemOneParameter()
        {

            var target = new MethodMethodsTestClass();

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
                typeof (MethodMethodsTestClass)
                    .GetMethods()
                    .First(
                        a =>
                            a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 1 &&
                            a.GetParameters().Count(b => b.Name == "arg" && b.ParameterType == typeof (string)) == 1);

            Assert.IsTrue(results.All(a => a == expecting));
        }
        
        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindWithSingleItemTwoParameter()
        {

            var target = new MethodMethodsTestClass();

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2=typeof(string)}),
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg1","arg2"}),
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof(string),typeof(string)}),
            };

            //equivelant to
            var expecting =
                typeof(MethodMethodsTestClass)
                    .GetMethods()
                    .First(
                        a =>
                            a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2 &&
                            a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
                            a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1);

            Assert.IsTrue(results.All(a => a == expecting));
        }


        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindFailsForPrivateByDefault()
        {

            var target = new MethodMethodsTestClass();

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue"),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {}),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {}),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", null)
            };

            Assert.IsTrue(results.All(a => a == null));
        }

        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindWorksForPrivateUsingBindingFlag()
        {

            var target = new MethodMethodsTestClass();

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue",BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {},BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {},BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", null,BindingFlags.Instance|BindingFlags.NonPublic)
            };

            var expecting =
                typeof(MethodMethodsTestClass).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(a => a.Name == "ShouldntShowNoReturnValue");

            Assert.IsTrue(results.All(a => a == expecting));
        }


        [TestMethod]
        public void Object_Method_Find_TargetInstanceFindFailsForPropertyMethods()
        {
            var target = new MethodMethodsTestClass();

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


        [TestMethod]
        public void Object_Method_Find_TargetTypeFindWithSingleItemNoParameters()
        {

            var target = typeof(MethodMethodsTestClass);

            var results = new[]
            {
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue"),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", new {}),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", new object[] {}),
                        _.Object.Method.Find(target, "ShouldShowNoReturnValue", null)
            };

            //equivelant to
            var expecting =
                typeof(MethodMethodsTestClass)
                    .GetMethods()
                    .First(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 0);

            Assert.IsTrue(results.All(a => a == expecting));
        }

        [TestMethod]
        public void Object_Method_Find_TargetTypeFindWithSingleItemOneParameter()
        {

            var target = typeof(MethodMethodsTestClass);

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
                typeof(MethodMethodsTestClass)
                    .GetMethods()
                    .First(
                        a =>
                            a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 1 &&
                            a.GetParameters().Count(b => b.Name == "arg" && b.ParameterType == typeof(string)) == 1);

            Assert.IsTrue(results.All(a => a == expecting));
        }

        [TestMethod]
        public void Object_Method_Find_TargetTypeFindWithSingleItemTwoParameter()
        {

            var target =  typeof(MethodMethodsTestClass);

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2=typeof(string)}),
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {"arg1","arg2"}),
                _.Object.Method.Find(target, "ShouldShowNoReturnValue", new[] {typeof(string),typeof(string)}),
            };

            //equivelant to
            var expecting =
                typeof(MethodMethodsTestClass)
                    .GetMethods()
                    .First(
                        a =>
                            a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2 &&
                            a.GetParameters().Count(b => b.Name == "arg1" && b.ParameterType == typeof(string)) == 1 &&
                            a.GetParameters().Count(b => b.Name == "arg2" && b.ParameterType == typeof(string)) == 1);

            Assert.IsTrue(results.All(a => a == expecting));
        }

        [TestMethod]
        public void Object_Method_Find_TargetTypeFindFailsForPrivateByDefault()
        {

            var target = typeof(MethodMethodsTestClass);

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue"),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {}),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {}),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", null)
            };

            Assert.IsTrue(results.All(a=>a==null));
        }

        [TestMethod]
        public void Object_Method_Find_TargetTypeFindWorksForPrivateUsingBindingFlag()
        {

            var target = typeof(MethodMethodsTestClass);

            var results = new[]
            {
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue",BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new {},BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", new object[] {},BindingFlags.Instance|BindingFlags.NonPublic),
                _.Object.Method.Find(target, "ShouldntShowNoReturnValue", null,BindingFlags.Instance|BindingFlags.NonPublic)
            };

            var expecting =
                typeof (MethodMethodsTestClass).GetMethods(BindingFlags.NonPublic | BindingFlags.Instance)
                    .FirstOrDefault(a => a.Name == "ShouldntShowNoReturnValue");

            Assert.IsTrue(results.All(a => a == expecting));
        }
        
        [TestMethod]
        public void Object_Method_Find_TargetTypeFindFailsForPropertyMethods()
        {
            var target = typeof (MethodMethodsTestClass);

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
        
        [TestMethod]
        public void Object_Method_Find_TargetInstanceReturnParameterOverride()
        {
            var target = new MethodMethodsTestClass();

            var result = _.Object.Method.Find(target, new { @return = new { parameterType=typeof(string) } });

            Assert.IsNotNull(result);
            Assert.AreEqual(result, _.Object.Method.Find(target, "ReturnAsAParameter"));

        }


        [TestMethod]
        public void Object_Method_Find_TargetTypeReturnParameterOverride()
        {
            var target = typeof(MethodMethodsTestClass);

            var result = _.Object.Method.Find(target, new { @return = new { parameterType = typeof(string) } });

            Assert.IsNotNull(result);
            Assert.AreEqual(result, _.Object.Method.Find(target, "ReturnAsAParameter"));

        }

        [TestMethod]
        public void Object_Method_Find_TargetInstanceSkippingArguments()
        {
            var target = new MethodMethodsTestClass();

            var expecting = typeof (MethodMethodsTestClass).GetMethods().FirstOrDefault(a=> a.Name == "ShouldShowNoReturnValue" &&  a.GetParameters().Length == 2);

            var result = _.Object.Method.Find(target, new [] {null, typeof(string)});

            Assert.AreEqual(expecting,result);
            
        }


        [TestMethod]
        public void Object_Method_Find_TargetTypeSkippingArguments()
        {
            var target = typeof(MethodMethodsTestClass);

            var expecting = typeof(MethodMethodsTestClass).GetMethods().FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue" && a.GetParameters().Length == 2);

            var result = _.Object.Method.Find(target, new[] { null, typeof(string) });

            Assert.AreEqual(expecting, result);

        }

        [TestMethod]
        public void Object_Method_Has_TargetHasNoArgs()
        {
            var target = new MethodMethodsTestClass();

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
            var target = new MethodMethodsTestClass();
            var testing = _.Object.Method;

            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string)}));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", typeof (string)));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", new[] {"arg"}));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", "arg"));

            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", new {arg = typeof (string)}));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string)}));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", typeof (string)));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", new[] {"arg"}));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", "arg"));

            var shouldShowMethods = new[]
            {
                testing.Has(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}),
                testing.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string)}),
                testing.Has(target, "ShouldShowNoReturnValue", new[] {"arg"})
            };

            foreach (var result in shouldShowMethods)
                Assert.IsTrue(result);

            var shouldntShowMethods = new[]
            {
                testing.Has(target, "ShouldntShowNoReturnValue", new {arg = typeof (string)}),
                testing.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string)}),
                testing.Has(target, "ShouldntShowNoReturnValue", new[] {"arg"})
            };

            foreach (var result in shouldntShowMethods)
                Assert.IsFalse(result);

        }

        [TestMethod]
        public void Object_Method_Has_TargetHasTwoArgs()
        {
            var target = new MethodMethodsTestClass();
            var testing = _.Object.Method;

            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue",
                new {arg1 = typeof (string), arg2 = typeof (string)}));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}));
            Assert.IsTrue(testing.Has(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"}));

            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue",
                new {arg1 = typeof (string), arg2 = typeof (string)}));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}));
            Assert.IsFalse(testing.Has(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"}));

            var shouldShowMethods = new[]
            {
                testing.Has(target, "ShouldShowNoReturnValue", new {arg1 = typeof (string), arg2 = typeof (string)}),
                testing.Has(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                testing.Has(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"})
            };

            foreach (var result in shouldShowMethods)
                Assert.IsTrue(result);

            var shouldntShowMethods = new[]
            {
                testing.Has(target, "ShouldntShowNoReturnValue", new {arg1 = typeof (string), arg2 = typeof (string)}),
                testing.Has(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                testing.Has(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"})
            };

            foreach (var result in shouldntShowMethods)
                Assert.IsFalse(result);

        }

        [TestMethod]
        public void Object_Method_Has_DoesNotMatchPropertyMethods()
        {
            var target = new MethodMethodsTestClass();
            var testing = _.Object.Method;

            Assert.IsFalse(testing.Has(target, "get_PublicPropertyShouldNotShow"));
            Assert.IsFalse(testing.Has(target, "get_PrivatePropertyShouldNotShow"));

            Assert.IsFalse(testing.Has(target, "set_PublicPropertyShouldNotShow", new {value = typeof (string)}));
            Assert.IsFalse(testing.Has(target, "set_PublicPropertyShouldNotShow", new[] {typeof (string)}));
            Assert.IsFalse(testing.Has(target, "set_PublicPropertyShouldNotShow", typeof (string)));
            Assert.IsFalse(testing.Has(target, "set_PublicPropertyShouldNotShow", new[] {"value"}));
            Assert.IsFalse(testing.Has(target, "set_PublicPropertyShouldNotShow", "value"));

            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow"));
            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow", new {value = typeof (string)}));
            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow", new[] {typeof (string)}));
            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow", typeof (string)));
            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow", new[] {"value"}));
            Assert.IsFalse(testing.Has(target, "set_PrivatePropertyShouldNotShow", "value"));

        }
        
        

    }
}
