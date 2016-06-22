using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Function;
using Underscore.Object.Reflection;
using System.Linq.Expressions;
using System.Text;

namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class Method
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
        public void MethodInvokeWithoutParameterAndWithoutReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            var result = testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithoutReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithoutReturnValueWasCalled);
            // when the method is a void just returns null;
            Assert.IsNull(result);
        }


        [TestMethod]
        public void MethodInvokeWithoutParameterWithReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            string result  = (string)testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
            Assert.AreEqual("1",result);

            result = (string)testing.Invoke(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
            Assert.AreEqual("2", result);

        }

        [TestMethod]
        public void MethodInvokeWithoutParameterWithReturnValueGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            string result = testing.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");

            Assert.IsTrue(testingTarget.InvokeWithoutParameterAndWithReturnValueWasCalled);
            Assert.AreEqual("1", result);

            result = testing.Invoke<string>(testingTarget, "InvokeWithoutParameterAndWithReturnValue");
            Assert.AreEqual("2", result);
        }


        [TestMethod]
        public void MethodInvokeWithParameterWithoutReturnValue()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            object result = testing.Invoke(testingTarget, "InvokeWithParameterWithoutReturnValue","a","b");

            Assert.IsTrue(testingTarget.InvokeWithParameterWithoutReturnValueWasCalled);
            Assert.IsNull(result);
            Assert.AreEqual("a",testingTarget.InvokeWithParameterWithoutReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParameterWithoutReturnValueParameter2);
        }

        [TestMethod]
        public void MethodInvokeWithParameterWithReturnValueNonGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            string result = (string)testing.Invoke(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

            Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
            Assert.AreEqual("a b" , result);
            Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
        }

        [TestMethod]
        public void MethodInvokeWithParameterWithReturnValueGeneric()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

            string result = testing.Invoke<string>(testingTarget, "InvokeWithParametersAndReturnValue", "a", "b");

            Assert.IsTrue(testingTarget.InvokeWithParametersAndReturnValueWasCalled);
            Assert.AreEqual("a b", result);
            Assert.AreEqual("a", testingTarget.InvokeWithParametersAndReturnValueParameter1);
            Assert.AreEqual("b", testingTarget.InvokeWithParametersAndReturnValueParameter2);
        }



        [TestMethod]
        public void MethodInvokeForAllWithParameterWithoutReturnValueLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodInvokeForAllWithParameterWithoutReturnValueGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodInvokeForAllWithParameterWithReturnValueLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodInvokeForAllWithParameterWithReturnValueGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodInvokeForAllWithParameterWithReturnValueGenericLazy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodInvokeForAllWithParameterWithReturnGenericGreedy()
        {
            var testingTarget = new MethodInvokeTestTargetObject();
            var testing = SetupMethodsComponent();

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
        public void MethodsAll1()
        {

            var target = new MethodMethodsTestClass();

            IMethodComponent testing = SetupMethodsComponent();// = new Underscore.Object.Reflection.Methods()


                var methods = testing.All(target);

            var methodInfos = methods as MethodInfo[] ?? methods.ToArray();
            var targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");
                Assert.IsNotNull(targetMethod);

                var results = methodInfos.Where(a => a.Name == "ShouldShowNoReturnValue");
            var enumerable = results as MethodInfo[] ?? results.ToArray();
            Assert.AreEqual(3, enumerable.Count(a => a.Name == "ShouldShowNoReturnValue"));
                //no param
                var noRetMethods = enumerable.Where(a => a.ReturnType == typeof(void));
            var retMethods = noRetMethods as MethodInfo[] ?? noRetMethods.ToArray();
            Assert.IsNotNull(retMethods.FirstOrDefault(), "Missing no parametered method");
                //one param
                Assert.AreEqual(1, (
                    from m in retMethods
                    let parameters = m.GetParameters()
                    where parameters.Count() == 1
                        && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg") == 1
                        && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing single parametered method"
                );
                //two params
                Assert.AreEqual(1, (
                    from m in retMethods
                    let parameters = m.GetParameters()
                    where parameters.Count() == 2
                        && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg1") == 1
                        && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg2") == 1
                        && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing double parametered method"
                );

                //no param string return type
                targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue");

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, methodInfos.Count(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.IsTrue(
                    targetMethod.ReturnType == typeof(string)
                    && !targetMethod.GetParameters().Any()
                );

                Assert.AreEqual(5, methodInfos.Count());

                //all methods with no params
                methods = testing.Query(target, new { });
            var infos = methods as MethodInfo[] ?? methods.ToArray();
            targetMethod = infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");

                Assert.AreEqual(2, infos.Count());

                Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
                Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

                Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowStringReturnValue"));


                var singleParamTypeString1 = testing.Query(target, typeof(string));
                var singleParamTypeString2 = testing.Query(target, new[] { typeof(string) });

            var paramTypeString1 = singleParamTypeString1 as MethodInfo[] ?? singleParamTypeString1.ToArray();
            Assert.IsTrue(paramTypeString1.Count() == 2);
                Assert.IsNotNull(paramTypeString1.FirstOrDefault());

                var targetingSingleParam = paramTypeString1.FirstOrDefault();
                Assert.IsNotNull(targetingSingleParam);
                Assert.IsTrue(targetingSingleParam.GetParameters().Count() == 1 && targetingSingleParam.GetParameters().Count(a => a.Name == "arg" && a.ParameterType == typeof(string)) == 1);

                Assert.AreEqual(paramTypeString1.FirstOrDefault(), singleParamTypeString2.FirstOrDefault());

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


                var dblParamType = testing.Query(target, new[] { typeof(string), typeof(string) });

            var dblParamTypeArr = dblParamType as MethodInfo[] ?? dblParamType.ToArray();
            Assert.AreEqual(1, dblParamTypeArr.Count());
                targetMethod = dblParamTypeArr.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamTypeArr.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));

                var dblParamName = testing.Query(target, new[] { "arg1", "arg2" });
            var dblParamNameArr = dblParamName as MethodInfo[] ?? dblParamName.ToArray();
            targetMethod = dblParamNameArr.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamNameArr.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));


        }

        [TestMethod]
        public void MethodsTypeAll1()
        {
            // Test behave differently when they are called from another method
            // even though it is a type get's treated like a general object
            // which is why the tests are repeated
            var target =  typeof(MethodMethodsTestClass);

            IMethodComponent testing = SetupMethodsComponent();// = new Underscore.Object.Reflection.Methods()


            var methods = testing.All(target);

            var methodInfos = methods as MethodInfo[] ?? methods.ToArray();
            var targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");
            Assert.IsNotNull(targetMethod);

            var results = methodInfos.Where(a => a.Name == "ShouldShowNoReturnValue");
            var enumerable = results as MethodInfo[] ?? results.ToArray();
            Assert.AreEqual(3, enumerable.Count(a => a.Name == "ShouldShowNoReturnValue"));
            //no param
            var noRetMethods = enumerable.Where(a => a.ReturnType == typeof(void));
            var retMethods = noRetMethods as MethodInfo[] ?? noRetMethods.ToArray();
            Assert.IsNotNull(retMethods.FirstOrDefault(), "Missing no parametered method");
            //one param
            Assert.AreEqual(1, (
                from m in retMethods
                let parameters = m.GetParameters()
                where parameters.Count() == 1
                    && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg") == 1
                    && m.ReturnType == typeof(void)
                select m
                ).Count(),
                "Missing single parametered method"
            );
            //two params
            Assert.AreEqual(1, (
                from m in retMethods
                let parameters = m.GetParameters()
                where parameters.Count() == 2
                    && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg1") == 1
                    && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg2") == 1
                    && m.ReturnType == typeof(void)
                select m
                ).Count(),
                "Missing double parametered method"
            );

            //no param string return type
            targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue");

            Assert.IsNotNull(targetMethod);
            Assert.AreEqual(1, methodInfos.Count(a => a.Name == "ShouldShowStringReturnValue"));
            Assert.IsTrue(
                targetMethod.ReturnType == typeof(string)
                && !targetMethod.GetParameters().Any()
            );

            Assert.AreEqual(5, methodInfos.Count());

            //all methods with no params
            methods = testing.Query(target, new { });
            var infos = methods as MethodInfo[] ?? methods.ToArray();
            targetMethod = infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");

            Assert.AreEqual(2, infos.Count());

            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowNoReturnValue"));

            Assert.IsNotNull(infos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
            Assert.AreEqual(1, infos.Count(a => a.Name == "ShouldShowStringReturnValue"));


            var singleParamTypeString1 = testing.Query(target, typeof(string));
            var singleParamTypeString2 = testing.Query(target, new[] { typeof(string) });

            var paramTypeString1 = singleParamTypeString1 as MethodInfo[] ?? singleParamTypeString1.ToArray();
            Assert.IsTrue(paramTypeString1.Count() == 2);
            Assert.IsNotNull(paramTypeString1.FirstOrDefault());

            var targetingSingleParam = paramTypeString1.FirstOrDefault();
            Assert.IsNotNull(targetingSingleParam);
            Assert.IsTrue(targetingSingleParam.GetParameters().Count() == 1 && targetingSingleParam.GetParameters().Count(a => a.Name == "arg" && a.ParameterType == typeof(string)) == 1);

            Assert.AreEqual(paramTypeString1.FirstOrDefault(), singleParamTypeString2.FirstOrDefault());

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


            var dblParamType = testing.Query(target, new[] { typeof(string), typeof(string) });

            var dblParamTypeArr = dblParamType as MethodInfo[] ?? dblParamType.ToArray();
            Assert.AreEqual(1, dblParamTypeArr.Count());
            targetMethod = dblParamTypeArr.FirstOrDefault();

            Assert.IsNotNull(targetMethod);
            Assert.AreEqual(1, dblParamTypeArr.Count());
            Assert.AreEqual(2, targetMethod.GetParameters().Count());

            Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
            Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));

            var dblParamName = testing.Query(target, new[] { "arg1", "arg2" });
            var dblParamNameArr = dblParamName as MethodInfo[] ?? dblParamName.ToArray();
            targetMethod = dblParamNameArr.FirstOrDefault();

            Assert.IsNotNull(targetMethod);
            Assert.AreEqual(1, dblParamNameArr.Count());
            Assert.AreEqual(2, targetMethod.GetParameters().Count());

            Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
            Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));


        }

        private static Type Type<T>(T example)
        {
            return typeof(T);
        }

        private static IEnumerable<PropertyInfo> PropertiesOf<T>(T example)
        {
            return typeof(T).GetProperties(BindingFlags.Instance | BindingFlags.Public);
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

        private IMethodComponent SetupMethodsComponent1523724033()
        {
            // need to create an old school mock for this...might be an easier way 
            // but feel like this is the most clear way to do this

            var mock = new Mock<IPropertyComponent>();

            var empty = new { };
            SetupAll(mock, empty, PropertiesOf(empty));

            var one = new { arg = typeof(string) };
            SetupAll(mock, one, PropertiesOf(one));

            var two = new { arg1 = typeof(string), arg2 = typeof(string) };
            SetupAll(mock, two, PropertiesOf(two));

            var mk = mock.Object;

            return new MethodComponent(new MockUtilFunctionComponent(), mk);



        }

        private static Expression<Func<T, bool>> EqualTo<T>( T comparing ) 
        {
            return a => comparing.Equals( a ) ;
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


        private static void SetupDoubleArgMock( Mock<IMethodComponent> mock )
        {
            //should return all methods with one param type string
            //expected results


            var methodsActuals = AllMethodsInfo( );



            var expectingForQueryEmpty = methodsActuals
                .Where( a => a.Name == "ShouldShowNoReturnValue" || a.Name == "ShouldShowStringReturnValue" )
                .Select( a => new { Target = a, Parameters = a.GetParameters( ) } )
                .Where(

                    a => a.Parameters.Count( ) == 2
                        && a.Parameters.First( ).ParameterType == typeof( string )
                        && a.Parameters.First( ).Name == "arg1"
                        && a.Parameters.Skip( 1 ).First( ).ParameterType == typeof( string )
                        && a.Parameters.Skip( 1 ).First( ).Name == "arg2"
                )
                .Select( a => a.Target );


            var forQueryEmpty = expectingForQueryEmpty as MethodInfo[] ?? expectingForQueryEmpty.ToArray();
            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is( EqualTo( new { arg1 = typeof( string ), arg2 = typeof( string ) } ) )
                )
            )
            .Returns( forQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is<Type[]>( b => b.Length == 2 && b[0] == typeof(string) && b[1] == typeof(string ) )
                )
            )
            .Returns( forQueryEmpty );


            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is<string[]>( b => b.Count( ) == 2 && b[0] == "arg1" && b[1] == "arg2" )
                )
            )
            .Returns( forQueryEmpty );



        
        
        }
        
        private static void SetupSingleArgMock( Mock<IMethodComponent> mock )
        {
            //should return all methods with one param type string
            //expected results
            

            var methodsActuals = AllMethodsInfo( );



            var expectingForQueryEmpty = methodsActuals
                .Where( a => a.Name == "ShouldShowNoReturnValue" || a.Name == "ShouldShowStringReturnValue" )
                .Select( a => new { Target = a, Parameters = a.GetParameters( ) } )
                .Where(

                    a => a.Parameters.Count( ) == 1
                        && a.Parameters.First( ).ParameterType == typeof( string )
                        && a.Parameters.First( ).Name == "arg"
                        && !a.Target.IsSpecialName
                )
                .Select( a => a.Target );

            var forQueryEmpty = expectingForQueryEmpty as MethodInfo[] ?? expectingForQueryEmpty.ToArray();
            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is( EqualTo( new { arg = typeof(string) } ) ) 
                ) 
            )
            .Returns( forQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    typeof(string) 
                )
            )
            .Returns( forQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    typeof( string )
                )
            )
            .Returns( forQueryEmpty);


            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    "arg"
                )
            )
            .Returns( forQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    It.Is( EqualTo( new { arg = typeof( string ) } ) )
                )
            )
            .Returns( forQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is<object[]>( 
                        b => b.Length == 1 
                            && ( 
                                ( b[0] is Type && typeof(string) == ( (Type) b[0] ) )
                                || ( b[0] is string && "arg" == ((string)b[0]) )
                            )
                    )
                )
            )
            .Returns( forQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is<object>( b => b == null ) 
                ) 
            )
            .Returns( forQueryEmpty );
        
        }

        private static void SetupEmptyMock( Mock<IMethodComponent> mock )
        {
            var methodsActuals = AllMethodsInfo( );

            //should return all methods with no parameters
            //expected results
            var expectingForQueryEmpty = methodsActuals
                .Where( a => 
                    a.GetParameters( ).FirstOrDefault( ) == null && 
                    a.Name == "ShouldShowNoReturnValue" || a.Name == "ShouldShowStringReturnValue" 
                );

            var forQueryEmpty = expectingForQueryEmpty as MethodInfo[] ?? expectingForQueryEmpty.ToArray();
            mock.Setup( a => a.Query( It.Is<object>( b => ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), It.Is( EqualTo( new { } ) ) ) )
                .Returns( forQueryEmpty );

            mock.Setup( a => a.Query( It.Is<object>( b => ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), It.Is<object[]>( b => b.Length == 0 ) ) )
                .Returns( forQueryEmpty );

            mock.Setup( a => a.Query(It.IsAny<object>(), It.Is<object>(b=> b == null || !(b is string && ((string)b).Contains("Shouldnt") ) ) ) )
                .Returns( forQueryEmpty );
        }
        

        [TestMethod]
        public async Task ObjectMethodFind_PrivateMethodsNotShownByDefault()
        {
            var target = new MethodMethodsTestClass();


            await Util.Tasks.Start(
                () =>
                {
                    var cacher = new CacheComponent(new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    var expecting = typeof (MethodMethodsTestClass)
                        .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                        .First(a => a.GetParameters().FirstOrDefault() == null);

                    var results = new[]
                    {
                        testing.Find(target, "ShouldShowNoReturnValue"),
                        testing.Find(target, "ShouldShowNoReturnValue", new {}),
                        testing.Find(target, "ShouldShowNoReturnValue", new object[] {}),
                        testing.Find(target, "ShouldShowNoReturnValue", null)
                    };


                    var allNotNull = !results.Aggregate(false, (prev, curr) => prev || curr == null);

                    Assert.IsTrue(allNotNull,
                        "One of the targeting Find results returned null when expecting corresponding method info");


                    var allEqual = results.Aggregate(expecting, (prev, curr) => prev == curr ? curr : null) != null;

                    Assert.IsTrue(allEqual,
                        "One of the targeting Find results were not equal, all calls to empty find should be eqiv");

                    results = new[]
                    {
                        testing.Find(target, "ShouldntShowNoReturnValue"),
                        testing.Find(target, "ShouldntShowNoReturnValue", new {}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new object[] {}),
                        testing.Find(target, "ShouldntShowNoReturnValue", null)
                    };

                    var allNull = results.Aggregate(true, (prev, curr) => prev && curr == null);

                    Assert.IsTrue(allNull,
                        "One of the invalid calls to Find found a method when expecting all to return null");


                });
        }



        [TestMethod]
        public async Task ObjectMethodFind_SingleParameter()
        {
            var target = new MethodMethodsTestClass();


            await Util.Tasks.Start(
                () =>
                {

                    var expecting = typeof (MethodMethodsTestClass)
                        .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                        .First(a => a.GetParameters().Count() == 1
                                    && a.GetParameters().First().ParameterType == typeof (string)
                                    && a.GetParameters().First().Name == "arg");

                    var cacher = new CacheComponent(new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    var results = new[]
                    {
                        testing.Find(target, "ShouldShowNoReturnValue", new {arg = typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", typeof (string)),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {"arg"}),
                        testing.Find(target, "ShouldShowNoReturnValue", "arg")
                    };

                    var allNotNull = !results.Aggregate(false, (prev, curr) => prev || curr == null);

                    Assert.IsTrue(allNotNull,
                        "One of the targeting Find results returned null when expecting corresponding method info");


                    var allEqual = results.Aggregate(expecting, (prev, curr) => prev == curr ? curr : null) != null;

                    Assert.IsTrue(allEqual,
                        "One of the targeting Find results were not equal, all calls to empty find should be eqiv");


                    results = new[]
                    {
                        testing.Find(target, "ShouldntShowNoReturnValue", new {arg = typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", typeof (string)),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {"arg"}),
                        testing.Find(target, "ShouldntShowNoReturnValue", "arg")
                    };

                    var allNull = results.Aggregate(true, (prev, curr) => prev && curr == null);

                    Assert.IsTrue(allNull,
                        "One of the invalid calls to Find found a method when expecting all to return null");

                });
        }



        [TestMethod]
        public async Task ObjectMethodFind_TwoParameters()
        {
            var target = new MethodMethodsTestClass();


            await Util.Tasks.Start(
                () =>
                {
                    var expecting = typeof (MethodMethodsTestClass)
                        .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                        .First(a => a.GetParameters().Count() == 2
                                    && a.GetParameters().First().ParameterType == typeof (string)
                                    && a.GetParameters().First().Name == "arg1"
                                    && a.GetParameters().Skip(1).First().ParameterType == typeof (string)
                                    && a.GetParameters().Skip(1).First().Name == "arg2"
                                    && a.Name == "ShouldShowNoReturnValue");

                    var cacher = new CacheComponent(new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    var results = new[]
                    {
                        testing.Find(target, "ShouldShowNoReturnValue",
                            new {arg1 = typeof (string), arg2 = typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"})
                    };

                    var allNotNull = !results.Aggregate(false, (prev, curr) => prev || curr == null);

                    Assert.IsTrue(allNotNull,
                        "One of the targeting Find results returned null when expecting corresponding method info");


                    var allEqual = results.Aggregate(expecting, (prev, curr) => prev == curr ? curr : null) != null;

                    Assert.IsTrue(allEqual,
                        "One of the targeting Find results were not equal, all calls to empty find should be eqiv");


                    results = new[]
                    {
                        testing.Find(target, "ShouldntShowNoReturnValue",
                            new {arg1 = typeof (string), arg2 = typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"})
                    };

                    var allNull = results.Aggregate(true, (prev, curr) => prev && curr == null);

                    Assert.IsTrue(allNull,
                        "One of the invalid calls to Find found a method when expecting all to return null");


                    results = new[]
                    {
                        testing.Find(target, "ShouldShowNoReturnValue",
                            new {arg1 = typeof (string), arg2 = typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                        testing.Find(target, "ShouldShowNoReturnValue", new[] {"arg1", "arg2"})
                    };


                    allNotNull = !results.Aggregate(false, (prev, curr) => prev || curr == null);

                    Assert.IsTrue(allNotNull,
                        "One of the targeting Find results returned null when expecting corresponding method info");


                    allEqual = results.Aggregate(expecting, (prev, curr) => prev == curr ? curr : null) != null;

                    Assert.IsTrue(allEqual,
                        "One of the targeting Find results were not equal, all calls to empty find should be eqiv");

                    results = new[]
                    {
                        testing.Find(target, "ShouldntShowNoReturnValue",
                            new {arg1 = typeof (string), arg2 = typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {typeof (string), typeof (string)}),
                        testing.Find(target, "ShouldntShowNoReturnValue", new[] {"arg1", "arg2"})
                    };

                });
        }


        [TestMethod]
        public async Task ObjectMethodFind_PropertyMethodsNotShown()
        {
            var target = new MethodMethodsTestClass();


            await Util.Tasks.Start(
                () =>
                {
                    var cacher = new CacheComponent(new Underscore.Function.CompactComponent(),
                    new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    Assert.IsNull(testing.Find(target, "get_PublicPropertyShouldNotShow"));
                    Assert.IsNull(testing.Find(target, "get_PrivatePropertyShouldNotShow"));

                    Assert.IsNull(testing.Find(target, "set_PublicPropertyShouldNotShow", new {value = typeof (string)}));
                    Assert.IsNull(testing.Find(target, "set_PublicPropertyShouldNotShow", new[] {typeof (string)}));
                    Assert.IsNull(testing.Find(target, "set_PublicPropertyShouldNotShow", typeof (string)));
                    Assert.IsNull(testing.Find(target, "set_PublicPropertyShouldNotShow", new[] {"value"}));
                    Assert.IsNull(testing.Find(target, "set_PublicPropertyShouldNotShow", "value"));

                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow"));
                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow", new {value = typeof (string)}));
                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow", new[] {typeof (string)}));
                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow", typeof (string)));
                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow", new[] {"value"}));
                    Assert.IsNull(testing.Find(target, "set_PrivatePropertyShouldNotShow", "value"));

                });
        }


        [TestMethod]
        public void ObjectMethodFind_ReturnParameterOverride()
        {
            var target = new MethodMethodsTestClass();


            //ReturnAsAParameter
            var cacher = new CacheComponent(new CompactComponent(), new Underscore.Utility.CompactComponent());
            var testing = new MethodComponent(cacher, new PropertyComponent());

            var result = testing.Find(target, new { @return = new { parameterType=typeof(string) } });

            Assert.IsNotNull(result);
            Assert.AreEqual(result, testing.Find(target, "ReturnAsAParameter"));

        }


        [TestMethod]
        public async Task ObjectMethodFind_SkippingArguments()
        {
            var target = new MethodMethodsTestClass();


            await Util.Tasks.Start(
                () =>
                {
                    //ReturnAsAParameter
                    var cacher = new CacheComponent(new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    var expecting = typeof (MethodMethodsTestClass).GetMethods().FirstOrDefault(a=> a.Name == "ShouldShowNoReturnValue" &&  a.GetParameters().Length == 2);

                    var result = testing.Find(target, new [] {null, typeof(string)});
                    
                    Assert.AreEqual(expecting,result);

                });
        }

        [TestMethod]
        public async Task ObjectMethodHas( )
        {
            var target = new MethodMethodsTestClass( );


            await Util.Tasks.Start(
                ( ) =>
                {
                    var cacher = new CacheComponent( new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue" ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new { } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new object[ ] { } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", null ) );

                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue" ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new { } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new object[ ] { } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", null ) );

                    var shouldShowMethods = new[ ]{
                        testing.Has( target, "ShouldShowNoReturnValue" ),
                        testing.Has(target,"ShouldShowNoReturnValue",new{}),
                        testing.Has(target,"ShouldShowNoReturnValue",new object[]{}),
                        testing.Has(target,"ShouldShowNoReturnValue",null)
                    };

                    foreach ( var result in shouldShowMethods )
                        Assert.IsTrue( result );

                    var shouldntShowMethods = new[ ]{
                        testing.Has(target,"ShouldntShowNoReturnValue"),
                        testing.Has(target,"ShouldntShowNoReturnValue",new{}),
                        testing.Has(target,"ShouldntShowNoReturnValue",new object[]{}),
                        testing.Has(target,"ShouldntShowNoReturnValue",null)
                    };

                    foreach ( var result in shouldntShowMethods )
                        Assert.IsFalse( result );

                },
                ( ) =>
                {


                    var cacher = new CacheComponent( new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new { arg = typeof( string ) } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new[ ] { typeof( string ) } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", typeof( string ) ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new[ ] { "arg" } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", "arg" ) );


                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new { arg = typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new[ ] { typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", typeof( string ) ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new[ ] { "arg" } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", "arg" ) );


                    
                    var shouldShowMethods = new[ ]{
                        testing.Has( target, "ShouldShowNoReturnValue", new { arg = typeof( string ) } ),
                        testing.Has(target,"ShouldShowNoReturnValue",new []{ typeof(string)}),
                        testing.Has(target,"ShouldShowNoReturnValue",new[]{"arg"})
                    };

                    
                    foreach ( var result in shouldShowMethods )
                        Assert.IsTrue( result );

                    var shouldntShowMethods = new[ ]{ 
                        testing.Has( target, "ShouldntShowNoReturnValue", new { arg = typeof( string ) } ),
                        testing.Has(target,"ShouldntShowNoReturnValue",new []{ typeof(string)}),
                        testing.Has(target,"ShouldntShowNoReturnValue",new[]{"arg"})
                    };

                    foreach ( var result in shouldntShowMethods )
                        Assert.IsFalse( result );

                },
                ( ) =>
                {

                    var cacher = new CacheComponent( new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new[ ] { typeof( string ), typeof( string ) } ) );
                    Assert.IsTrue( testing.Has( target, "ShouldShowNoReturnValue", new[ ] { "arg1", "arg2" } ) );

                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new[ ] { typeof( string ), typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "ShouldntShowNoReturnValue", new[ ] { "arg1", "arg2" } ) );

                    var shouldShowMethods = new[ ]{
                        testing.Has( target, "ShouldShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ),
                        testing.Has(target,"ShouldShowNoReturnValue",new []{ typeof(string), typeof(string)}),
                        testing.Has(target,"ShouldShowNoReturnValue",new[]{"arg1","arg2"})
                    };

                    foreach ( var result in shouldShowMethods )
                        Assert.IsTrue( result );

                    var shouldntShowMethods = new[ ]{ 
                        testing.Has( target, "ShouldntShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof(string) } ),
                        testing.Has(target,"ShouldntShowNoReturnValue",new []{ typeof(string),typeof(string)}),
                        testing.Has(target,"ShouldntShowNoReturnValue",new[]{"arg1", "arg2"})
                    };

                    foreach ( var result in shouldntShowMethods )
                        Assert.IsFalse( result );

                },
                ( ) =>
                {
                    var cacher = new CacheComponent( new Underscore.Function.CompactComponent(), new Underscore.Utility.CompactComponent());
                    var testing = new MethodComponent(cacher, new PropertyComponent());

                    Assert.IsFalse( testing.Has( target, "get_PublicPropertyShouldNotShow" ) );
                    Assert.IsFalse( testing.Has( target, "get_PrivatePropertyShouldNotShow" ) );

                    Assert.IsFalse( testing.Has( target, "set_PublicPropertyShouldNotShow", new { value = typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "set_PublicPropertyShouldNotShow", new[ ] { typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "set_PublicPropertyShouldNotShow", typeof( string ) ) );
                    Assert.IsFalse( testing.Has( target, "set_PublicPropertyShouldNotShow", new[ ] { "value" } ) );
                    Assert.IsFalse( testing.Has( target, "set_PublicPropertyShouldNotShow", "value" ) );

                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow" ) );
                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow", new { value = typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow", new[ ] { typeof( string ) } ) );
                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow", typeof( string ) ) );
                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow", new[ ] { "value" } ) );
                    Assert.IsFalse( testing.Has( target, "set_PrivatePropertyShouldNotShow", "value" ) );

                }

            );

        }


        [TestMethod]
        public async Task MethodsAll2()
        {

            var target = new MethodMethodsTestClass();

            IMethodComponent testing = SetupMethodsComponent();// = new Underscore.Object.Reflection.Methods()


            await Util.Tasks.Start(() =>
            {
                var methods = testing.All(target);

                var methodInfos = methods as MethodInfo[] ?? methods.ToArray();
                var targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");
                Assert.IsNotNull(targetMethod);

                var results = methodInfos.Where(a => a.Name == "ShouldShowNoReturnValue");
                var resultArr = results as MethodInfo[] ?? results.ToArray();
                Assert.AreEqual(3, resultArr.Count(a => a.Name == "ShouldShowNoReturnValue"));
                //no param
                var noRetMethods = resultArr.Where(a => a.ReturnType == typeof(void));
                var noRetMethodsArr = noRetMethods as MethodInfo[] ?? noRetMethods.ToArray();
                Assert.IsNotNull(noRetMethodsArr.FirstOrDefault(), "Missing no parametered method");
                //one param
                Assert.AreEqual(1, (
                    from m in noRetMethodsArr
                    let parameters = m.GetParameters()
                    where parameters.Count() == 1
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg") == 1
                          && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing single parametered method"
                    );
                //two params
                Assert.AreEqual(1, (
                    from m in noRetMethodsArr
                    let parameters = m.GetParameters()
                    where parameters.Count() == 2
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg1") == 1
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg2") == 1
                          && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing double parametered method"
                    );

                //no param string return type
                targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue");

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, methodInfos.Count(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.IsTrue(
                    targetMethod.ReturnType == typeof(string)
                    && !targetMethod.GetParameters().Any()
                    );

                Assert.AreEqual(5, methodInfos.Count());

                //all methods with no params
                methods = testing.Query(target, new { });
                var methodsArr = methods as MethodInfo[] ?? methods.ToArray();
                targetMethod = methodsArr.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");

                Assert.AreEqual(2, methodsArr.Count());

                Assert.IsNotNull(methodsArr.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
                Assert.AreEqual(1, methodsArr.Count(a => a.Name == "ShouldShowNoReturnValue"));

                Assert.IsNotNull(methodsArr.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.AreEqual(1, methodsArr.Count(a => a.Name == "ShouldShowStringReturnValue"));


                var singleParamTypeString1 = testing.Query(target, typeof(string));
                var singleParamTypeString2 = testing.Query(target, new[] { typeof(string) });

                var singParamTypeArr = singleParamTypeString1 as MethodInfo[] ?? singleParamTypeString1.ToArray();
                Assert.IsTrue(singParamTypeArr.Count() == 2);
                Assert.IsNotNull(singParamTypeArr.FirstOrDefault());

                var targetingSingleParam = singParamTypeArr.FirstOrDefault();
                Assert.IsTrue(targetingSingleParam.GetParameters().Count() == 1 && targetingSingleParam.GetParameters().Count(a => a.Name == "arg" && a.ParameterType == typeof(string)) == 1);

                Assert.AreEqual(singParamTypeArr.FirstOrDefault(), singleParamTypeString2.FirstOrDefault());

                var singleParamName1 = testing.Query(target, "arg");
                var singleParamName2 = testing.Query(target, new[] { "arg" });

                Assert.IsTrue(singleParamName1.Count() == 1);
                Assert.IsTrue(singleParamName2.Count() == 1);

                Assert.IsTrue(
                    singleParamName1.Count(a => a.GetParameters().Count() == 1
                                                && a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
                        ) == 1);

                Assert.AreEqual(singleParamName1.FirstOrDefault(), singleParamName2.FirstOrDefault());


                var dblParamType = testing.Query(target, new[] { typeof(string), typeof(string) });

                Assert.AreEqual(1, dblParamType.Count());
                targetMethod = dblParamType.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamType.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));

                var dblParamName = testing.Query(target, new[] { "arg1", "arg2" });
                targetMethod = dblParamName.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamName.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));



            });
        }



        [TestMethod]
        public async Task MethodsTypeAll2()
        {

            var target = typeof(MethodMethodsTestClass);

            IMethodComponent testing = SetupMethodsComponent();// = new Underscore.Object.Reflection.Methods()


            await Util.Tasks.Start(() =>
            {
                var methods = testing.All(target);

                var methodInfos = methods as MethodInfo[] ?? methods.ToArray();
                var targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");
                Assert.IsNotNull(targetMethod);

                var results = methodInfos.Where(a => a.Name == "ShouldShowNoReturnValue");
                var resultArr = results as MethodInfo[] ?? results.ToArray();
                Assert.AreEqual(3, resultArr.Count(a => a.Name == "ShouldShowNoReturnValue"));
                //no param
                var noRetMethods = resultArr.Where(a => a.ReturnType == typeof(void));
                var noRetMethodsArr = noRetMethods as MethodInfo[] ?? noRetMethods.ToArray();
                Assert.IsNotNull(noRetMethodsArr.FirstOrDefault(), "Missing no parametered method");
                //one param
                Assert.AreEqual(1, (
                    from m in noRetMethodsArr
                    let parameters = m.GetParameters()
                    where parameters.Count() == 1
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg") == 1
                          && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing single parametered method"
                    );
                //two params
                Assert.AreEqual(1, (
                    from m in noRetMethodsArr
                    let parameters = m.GetParameters()
                    where parameters.Count() == 2
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg1") == 1
                          && parameters.Count(a => a.ParameterType == typeof(string) && a.Name == "arg2") == 1
                          && m.ReturnType == typeof(void)
                    select m
                    ).Count(),
                    "Missing double parametered method"
                    );

                //no param string return type
                targetMethod = methodInfos.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue");

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, methodInfos.Count(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.IsTrue(
                    targetMethod.ReturnType == typeof(string)
                    && !targetMethod.GetParameters().Any()
                    );

                Assert.AreEqual(5, methodInfos.Count());

                //all methods with no params
                methods = testing.Query(target, new { });
                var methodsArr = methods as MethodInfo[] ?? methods.ToArray();
                targetMethod = methodsArr.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue");

                Assert.AreEqual(2, methodsArr.Count());

                Assert.IsNotNull(methodsArr.FirstOrDefault(a => a.Name == "ShouldShowNoReturnValue"));
                Assert.AreEqual(1, methodsArr.Count(a => a.Name == "ShouldShowNoReturnValue"));

                Assert.IsNotNull(methodsArr.FirstOrDefault(a => a.Name == "ShouldShowStringReturnValue"));
                Assert.AreEqual(1, methodsArr.Count(a => a.Name == "ShouldShowStringReturnValue"));


                var singleParamTypeString1 = testing.Query(target, typeof(string));
                var singleParamTypeString2 = testing.Query(target, new[] { typeof(string) });

                var singParamTypeArr = singleParamTypeString1 as MethodInfo[] ?? singleParamTypeString1.ToArray();
                Assert.IsTrue(singParamTypeArr.Count() == 2);
                Assert.IsNotNull(singParamTypeArr.FirstOrDefault());

                var targetingSingleParam = singParamTypeArr.FirstOrDefault();
                Assert.IsTrue(targetingSingleParam.GetParameters().Count() == 1 && targetingSingleParam.GetParameters().Count(a => a.Name == "arg" && a.ParameterType == typeof(string)) == 1);

                Assert.AreEqual(singParamTypeArr.FirstOrDefault(), singleParamTypeString2.FirstOrDefault());

                var singleParamName1 = testing.Query(target, "arg");
                var singleParamName2 = testing.Query(target, new[] { "arg" });

                Assert.IsTrue(singleParamName1.Count() == 1);
                Assert.IsTrue(singleParamName2.Count() == 1);

                Assert.IsTrue(
                    singleParamName1.Count(a => a.GetParameters().Count() == 1
                                                && a.GetParameters().Count(b => b.ParameterType == typeof(string) && b.Name == "arg") == 1
                        ) == 1);

                Assert.AreEqual(singleParamName1.FirstOrDefault(), singleParamName2.FirstOrDefault());


                var dblParamType = testing.Query(target, new[] { typeof(string), typeof(string) });

                Assert.AreEqual(1, dblParamType.Count());
                targetMethod = dblParamType.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamType.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));

                var dblParamName = testing.Query(target, new[] { "arg1", "arg2" });
                targetMethod = dblParamName.FirstOrDefault();

                Assert.IsNotNull(targetMethod);
                Assert.AreEqual(1, dblParamName.Count());
                Assert.AreEqual(2, targetMethod.GetParameters().Count());

                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg1"));
                Assert.AreEqual(1, targetMethod.GetParameters().Count(a => a.ParameterType == typeof(string) && a.Name == "arg2"));



            });
        }

        private IMethodComponent SetupMethodsComponent()
        {
            // need to create an old school mock for this...might be an easier way 
            // but feel like this is the most clear way to do this

            var mock = new Mock<IPropertyComponent>();

            var empty = new { };
            SetupAll(mock, empty, PropertiesOf(empty));

            var one = new { arg = typeof(string) };
            SetupAll(mock, one, PropertiesOf(one));

            var two = new { arg1 = typeof(string), arg2 = typeof(string) };
            SetupAll(mock, two, PropertiesOf(two));

            var mk = mock.Object;

            return new MethodComponent(new MockUtilFunctionComponent(), mk);



        }
        
    }
}
