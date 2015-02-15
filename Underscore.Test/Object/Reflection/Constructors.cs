using System;
using System.Linq;
using System.Reflection;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;
using Underscore.Object.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class ConstructorComponentTest
    {

        [TestMethod]
        public void FunctionalCtorTest5()
        {
            var strBuilder = new StringBuilder();

            
            object[] paramQueryArgs =
            {
                new[] {typeof (string), typeof (int), typeof (int), typeof (int)},
                new[] {"value", "startIndex", "length", "capacity"},
                new {capacity = typeof (int), value = typeof (string), length = typeof (int), startIndex = typeof (int)}
            };

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            DoFunctionalConstructorTest(strBuilder, a =>
            {
                var ls = a.GetParameters().ToArray();
                return ls.Length == 4
                    && ls.Any(b => b.Name == "capacity" && b.ParameterType == typeof(int))
                    && ls.Any(b => b.Name == "value" && b.ParameterType == typeof(string))
                    && ls.Any(b => b.Name == "startIndex" && b.ParameterType == typeof(int))
                    && ls.Any(b => b.Name == "length" && b.ParameterType == typeof(int));
            }, paramQueryArgs, flags);


        }

        [TestMethod]
        public void FunctionalCtorTest4()
        {

            var strBuilder = new StringBuilder();
            
            object[] paramQueryArgs =
            {
                new[] {typeof (string), typeof (int)}, 
                new[] {"value", "capacity"},
                new {capacity = typeof (int), value = typeof (string)}
            };

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;


            DoFunctionalConstructorTest(strBuilder, a =>
            {
                var ls = a.GetParameters().ToArray();
                return ls.Length >= 2
                    && ls.Any(b => b.Name == "capacity" && b.ParameterType == typeof(int))
                    && ls.Any(b => b.Name == "value" && b.ParameterType == typeof(string));
            }, paramQueryArgs, flags);
        }

        [TestMethod]
        public void FunctionalCtorTest3()
        {
            var strBuilder = new StringBuilder();
            object[] paramQueryArgs =
            {
                new[] {typeof (int), typeof (int)}, 
                new[] {"capacity", "maxCapacity"},
                new {capacity = typeof (int), maxCapacity = typeof (int)}
            };

            const BindingFlags flags = BindingFlags.Instance | BindingFlags.Public;

            DoFunctionalConstructorTest(strBuilder, a =>
            {
                var ls = a.GetParameters().ToArray();
                return ls.Length >= 2
                    && ls.Any(b => b.Name == "capacity" && b.ParameterType == typeof(int))
                    && ls.Any(b => b.Name == "maxCapacity" && b.ParameterType == typeof(int));
            }, paramQueryArgs, flags);

        }

        [TestMethod]
        public void FunctionalCtorTest2()
        {


            var strBuilder = new StringBuilder();


            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            object[] paramQueryArgs =
            {
                typeof(string), 
                new[] { typeof(string) }, 
                "value", 
                new[]{"value"}, 
                new { value= typeof(string) }
            };

            Func<ConstructorInfo, bool> filter = a =>
            {
                var ls = a.GetParameters().ToArray();
                return ls.Length >= 1 && ls.Any(b => b.Name == "value" && b.ParameterType == typeof (string));
            };


            DoFunctionalConstructorTest(strBuilder, filter, paramQueryArgs,flags);
        }

        private static void DoFunctionalConstructorTest<T>(T instance, Func<ConstructorInfo, bool> filter, object[] paramQueryArgs,BindingFlags flags)
        {
            var cacheComponent = new CacheComponent();
            var propComponent = new PropertyComponent(cacheComponent);
            var ctorComponent = new ConstructorComponent(cacheComponent, propComponent);


            var expectedToHave = new HashSet<ConstructorInfo>(typeof (T).GetConstructors(flags).Where(filter));


            var testingqtypenf = _.Function.Partial<Type, object, IEnumerable<ConstructorInfo>>(
                ctorComponent.Query,
                typeof (T)
                );

            var testingqtypewf =
                _.Function.Partial<Type, object, BindingFlags, IEnumerable<ConstructorInfo>>(
                    ctorComponent.Query,
                    typeof (T)
                    );

            var testingqobjnf = _.Function.Partial<object, object, IEnumerable<ConstructorInfo>>(ctorComponent.Query, instance);
            var testingqobjwf =
                _.Function.Partial<object, object, BindingFlags, IEnumerable<ConstructorInfo>>(ctorComponent.Query, instance);


            var resultSet =
                paramQueryArgs.Select(testingqtypenf)
                    .Concat(paramQueryArgs.Select(a => testingqtypewf(a, flags)))
                    .Concat(paramQueryArgs.Select(testingqobjnf))
                    .Concat(paramQueryArgs.Select(a => testingqobjwf(a, flags)));

            int i = 0;
            foreach (var result in resultSet)
            {
                Assert.IsTrue(result.All(expectedToHave.Contains), string.Join(", ", result.Select(a=>"("+string.Join(" , ",a.GetParameters().Select(b=>b.Name+":"+b.ParameterType.Name))+")")) + " Invocation "+i);
                i++;
            }
        }


        public void FunctionalCtorTest7()
        {


            var strBuilder = new StringBuilder();
            Func<ConstructorInfo, bool> filter = a =>
            {
                var ls = a.GetParameters().ToArray();
                return ls.Length >= 1 && ls.Any(b => b.Name == "capacity" && b.ParameterType == typeof (int));
            };


            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;
            object[] paramQueryArgs = { typeof(int), new[] { typeof(int) }, "capacity", new { capacity = typeof(int) } };

            DoFunctionalConstructorTest(strBuilder, filter, paramQueryArgs, flags);

        }

        [TestMethod]
        public void FunctionalCtorTestParameterless()
        {
            
            var cacheComponent = new CacheComponent();
            var propComponent = new PropertyComponent(cacheComponent);
            var ctorComponent = new ConstructorComponent(cacheComponent, propComponent);

            //get the ctor for string builder
            //empty ctor var strBuilder = new StringBuilder();

            var strBuilder = new StringBuilder();

            const BindingFlags flags = BindingFlags.Public | BindingFlags.Instance;

            var expecting = from i in typeof(StringBuilder).GetConstructors(flags) 
                            where !i.GetParameters().Any()
                            select i;


            var resultsSet = new IList<ConstructorInfo>[]
            {
                ctorComponent.Query(typeof (StringBuilder), new {}, flags).ToList(),
                ctorComponent.Query(typeof (StringBuilder), new {}).ToList(),
                ctorComponent.Query(strBuilder, new {}, flags).ToList(),
                ctorComponent.Query(strBuilder, new {}).ToList(),
                new[]{ctorComponent.Parameterless(typeof (StringBuilder))},
                new[]{ctorComponent.Parameterless(strBuilder)},
                new[]{ctorComponent.Parameterless(typeof (StringBuilder), flags)},
                new[]{ctorComponent.Parameterless(strBuilder, flags)},
            };
            //expecting should only be one 

            foreach (var results in resultsSet)
            {

                Assert.AreEqual(1, results.Count());
                Assert.AreEqual(expecting.First(), results.First());

            }

            Assert.IsTrue(ctorComponent.HasParameterless(strBuilder));
            Assert.IsTrue(ctorComponent.HasParameterless(strBuilder,flags));



        }

        private static IConstructorComponent CreateTestTarget()
        {
            var cacher = new CacheComponent();
            var props = new PropertyComponent(cacher);

            return new ConstructorComponent(cacher, props);
        }

        public class CtorParamlessTestClass
        {
            public CtorParamlessTestClass()
            {

            }
            
        }

        public class CtorStaticParamlessTestClass
        {
            private static readonly string s;
            public CtorStaticParamlessTestClass(string arg)
            {

            }

            static CtorStaticParamlessTestClass()
            {
                s = string.Empty;
            }
        }

        public class CtorPrivateParamlessTestClass
        {
            public CtorPrivateParamlessTestClass(string arg)
            {
                
            }

            private CtorPrivateParamlessTestClass()
            {

            }
        }

        public class CtorSingleParamOnly
        {
            public CtorSingleParamOnly(string arg)
            {

            }
        }

        public class CtorDoubleParamOnly
        {
            public CtorDoubleParamOnly(string arg1, string arg2)
            {

            }
        }

        public class CtorSingleAndParamless
        {

            public CtorSingleAndParamless(string arg)
            {

            }

            public CtorSingleAndParamless()
            {

            }
        }


        public class CtorDoubleAndParamless
        {

            public CtorDoubleAndParamless(string arg1, string arg2)
            {

            }

            public CtorDoubleAndParamless()
            {

            }
        }



        public class CtorDoubleAndSingleAndParamless
        {

            public CtorDoubleAndSingleAndParamless(string arg1, string arg2)
            {

            }

            public CtorDoubleAndSingleAndParamless(int arg)
            {

            }

            public CtorDoubleAndSingleAndParamless()
            {
                
            }
        }

        public class CtorDoubleAndSingle
        {
            public CtorDoubleAndSingle(string a, string b)
            {

            }

            public CtorDoubleAndSingle(string a)
            {

            }
        }



        [TestMethod]
        public void HasParameterlessPositive( )
        {
            var testing = CreateTestTarget( );

            var ctorParamlessTestTarget1 = new CtorParamlessTestClass();
            var ctorParamlessTestTarget2 = new CtorSingleAndParamless();
            var ctorParamlessTestTarget3 = new CtorDoubleAndParamless();
            var ctorParamlessTestTarget4 = new CtorDoubleAndSingleAndParamless();
            
            object[] testArgs =
            {
                ctorParamlessTestTarget1, 
                ctorParamlessTestTarget2,
                ctorParamlessTestTarget3, 
                ctorParamlessTestTarget4
            };

            foreach (var testArg in testArgs)
                Assert.IsTrue(testing.HasParameterless(testArg));

            Type[] testTypeArgs =
            {
                typeof (CtorParamlessTestClass), 
                typeof (CtorSingleAndParamless),
                typeof (CtorDoubleAndParamless), 
                typeof (CtorDoubleAndSingleAndParamless)
            };

            foreach (var testTypeArg in testTypeArgs)
            {
                Assert.IsTrue(testing.HasParameterless(testTypeArg));
            }


            var privateParamless = new CtorPrivateParamlessTestClass(null);
            var staticParamless = new CtorStaticParamlessTestClass(null);

            bool[] testBindingFlagsObjectResults =
            {
                testing.HasParameterless(privateParamless, BindingFlags.NonPublic | BindingFlags.Instance),
                testing.HasParameterless(staticParamless,  BindingFlags.NonPublic |BindingFlags.Static)
            };

            foreach (bool result in testBindingFlagsObjectResults)
                Assert.IsTrue(result);


        }

        [TestMethod]
        public void HasParameterlessNegative()
        {
            var testing = CreateTestTarget( );

            bool[] testResults =
            {
                testing.HasParameterless(new CtorSingleParamOnly(null)),
                testing.HasParameterless(new CtorDoubleParamOnly(null,null))
            };


            foreach (bool result in testResults)
                Assert.IsFalse(result);

        }

        [TestMethod]
        public void Parameterless1( )
        {
            var testing = CreateTestTarget( );
        }

        private static void TestFind<TTesting,TQuery>(TTesting obj, TQuery query, BindingFlags bindingFlags, bool positive)
        {

            var testing = CreateTestTarget();

            var type = typeof(TTesting);

            IEnumerable<ConstructorInfo> resultObjBindFlags,
                resultType,
                resultTypeBindFlags;

            var resultObj = resultObjBindFlags 
                = resultType = resultTypeBindFlags = null;


            if ((bindingFlags & BindingFlags.NonPublic) != BindingFlags.NonPublic)
            {
                resultObj = testing.Query(obj, query);
            }

            resultObjBindFlags = testing.Query(obj, query, bindingFlags);

            if ((bindingFlags & BindingFlags.NonPublic) != BindingFlags.NonPublic)
            {
                resultType = testing.Query(type, query);
            }

            resultTypeBindFlags = testing.Query(type, query, bindingFlags);

            var testResults = (new[]
                {
                    resultObj,
                    resultObjBindFlags,
                    resultType,
                    resultTypeBindFlags,
                })
                .Where(a=>a!=null)
                .Select(a => new HashSet<ConstructorInfo>(a))
                .ToArray();

            if (positive)
                foreach (var testResult in testResults)
                {
                    if (testResult == null) continue;

                    foreach (var comparing in testResults)
                        foreach (var result in testResult)
                        {
                            Assert.IsNotNull(result);
                            Assert.IsTrue(comparing.Contains(result));


                            //get the parameters we need, pass defaults, get object
                            var values = result.GetParameters();
                            var resultingInvocation =
                                result.Invoke(values.Select(a =>
                                {
                                    try
                                    {
                                        return Activator.CreateInstance(a.ParameterType);
                                    }
                                    catch
                                    {
                                        return null;
                                    }
                                }).ToArray());

                            Assert.IsTrue(resultingInvocation is TTesting);

                        }
                }
            else
                foreach (var result in testResults)
                    Assert.IsTrue(result == null || !result.Any());
            
        }

        [TestMethod]
        public void CtorFindSingleParameterPostiveEq( )
        {
            TestFind(new CtorSingleParamOnly(null), new {arg = typeof (string)},
                BindingFlags.Public | BindingFlags.Instance, true);
        }


        [TestMethod]
        public void CtorFindSingleParameterNegativeEq()
        {
            TestFind(new CtorSingleParamOnly(null), new { arg1 = typeof(string) },
                BindingFlags.Public | BindingFlags.Instance, false);
        }


        [TestMethod]
        public void CtorFindSingleParameterPostiveLike()
        {
            var target = new CtorSingleParamOnly(null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should match all ctor where at least one param name and type matching query obj
            TestFind( target , new{ arg=typeof(string)}, bflags, true);

            //should match all ctor where at least one param type matches a type in query obj
            TestFind(target, new[] {typeof (string)}, bflags, true);

            //when given an array of strings should match ctors with parameters that contain matching names
            TestFind(target, new[] {"arg"}, bflags, true);
        }



        [TestMethod]
        public void CtorFindSingleParameterNegativeLike()
        {
            var target = new CtorSingleParamOnly(null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should not match any ctor where none match any param name and type matching query obj
            TestFind(target, new { arg1 = typeof(string) }, bflags, false);

            //should not match any ctor where none match any param typs in query obj
            TestFind(target, new[] { typeof(int) }, bflags, false);

            //should not match any ctor where none match any param name in query obj
            TestFind(target, new[] { "arg1" }, bflags, false);
        }


        [TestMethod]
        public void CtorFindDoubleParameterPostiveEq()
        {

            var target = new CtorDoubleParamOnly(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should match when exist ctor exact match between arg name and arg type in query object
            TestFind(target, new { arg1 = typeof(string), arg2=typeof(string) },bflags, true);
        }


        [TestMethod]
        public void CtorFindDoubleParameterNegativeEq()
        {
            var target = new CtorDoubleParamOnly(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            TestFind(target, new { arg1 = typeof(string), arg = typeof(string) }, bflags, false);
            TestFind(target, new { arg = typeof(string), arg2 = typeof(string) }, bflags, false);
            TestFind(target, new { shouldnotfind1 = typeof(string), shouldnotfind2 = typeof(string) }, bflags, false);

        }


        [TestMethod]
        public void CtorFindDoubleParameterNegativeLike()
        {
            var target = new CtorDoubleParamOnly(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            // when given an other than a string[] or a type[]
            // should not match any ctor where 
            // all arg name type pairs cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            TestFind(target, new { arg1 = typeof(string) , nothere=typeof(string) }, bflags, true);
            TestFind(target, new { arg2 = typeof(string), nothere=typeof(string) }, bflags, true);

            //when given a type[ ]
            // should not match any ctor where 
            // all passed types cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            TestFind(target, new[] { typeof(int) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(string) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(int) }, bflags, true);

            // when given a string[ ]
            // should not match any ctors with parameters 
            // that cannot be mapped uniquely by name to passed string[]
            TestFind(target, new[] { "arg", "arg1" }, bflags, true);
            TestFind(target, new[] { "arg", "arg2" }, bflags, true);
            TestFind(target, new[] { "narg1", "narg2" }, bflags, true);
        }



        [TestMethod]
        public void CtorFindDoubleParameterPositiveLike()
        {
            var target = new CtorDoubleParamOnly(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should match all ctor where at least one param name and type matching query obj
            TestFind(target, new { arg1 = typeof(string) }, bflags, true);
            TestFind(target, new { arg2 = typeof(string) }, bflags, true);

            //should match all ctor where at least one param type matches a type in query obj
            TestFind(target, new[] { typeof(string) }, bflags, true);
            TestFind(target, new[] { typeof(string), typeof(string) }, bflags, true);

            //when given an array of strings should match ctors with parameters that contain matching names
            TestFind(target, new[] { "arg1"}, bflags, true);
            TestFind(target, new[] { "arg2" }, bflags, true);
            TestFind(target, new[] { "arg1", "arg2" }, bflags, true);
        }



        [TestMethod]
        public void CtorFindDoubleAndSingleAndParameterlessPositiveEq()
        {

            var target = new CtorDoubleParamOnly(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should match when exist ctor exact match between arg name and arg type in query object
            TestFind(target, new { arg1 = typeof(string), arg2 = typeof(string) }, bflags, true);
            TestFind(target, new { arg = typeof(int) }, bflags, true); 
            
            //should match when exists parameterless ctor
            TestFind(target, new { }, bflags, true);


        }


        [TestMethod]
        public void CtorFindDoubleAndSingleAndParameterlessNegativeEq()
        {
            var target = new CtorDoubleAndSingleAndParamless(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            TestFind(target, new { arg1 = typeof(string), arg = typeof(string) }, bflags, false);
            TestFind(target, new { arg = typeof(string), arg2 = typeof(string) }, bflags, false);
            TestFind(target, new { arg = typeof(int), arg2 = typeof(string) }, bflags, false);
            TestFind(target, new { arg1 = typeof(int), arg2 = typeof(int) }, bflags, false);
            TestFind(target, new { arg = typeof(int), arg1 = typeof(string), arg2=typeof(string) }, bflags, false);
            TestFind(target, new { shouldnotfind1 = typeof(string), shouldnotfind2 = typeof(string) }, bflags, false);

        }


        [TestMethod]
        public void CtorFindDoubleAndSingleAndParameterlessNegativeLike()
        {
            var target = new CtorDoubleAndSingleAndParamless(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            // when given an other than a string[] or a type[]
            // should not match any ctor where 
            // all arg name type pairs cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            //or null is passed
            TestFind(target, new { arg1 = typeof(string), nothere = typeof(string) }, bflags, true);
            TestFind(target, new { arg2 = typeof(string), nothere = typeof(string) }, bflags, true);
            TestFind(target, null as object , bflags, true);

            // when given a type[ ]
            // should not match any ctor where 
            // all passed types cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            TestFind(target, new[] { typeof(int) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(string) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(int) }, bflags, true);

            // when given a string[ ]
            // should not match any ctors with parameters 
            // that cannot be mapped uniquely by name to passed string[]
            TestFind(target, new[] { "arg", "arg1" }, bflags, true);
            TestFind(target, new[] { "arg", "arg2" }, bflags, true);
            TestFind(target, new[] { "narg1", "narg2" }, bflags, true);
        }



        [TestMethod]
        public void CtorFindDoubleAndSingleAndParameterlessPositiveLike()
        {
            var target = new CtorDoubleAndSingleAndParamless(null, null);
            const BindingFlags bflags = BindingFlags.Public | BindingFlags.Instance;

            //should match all ctor where at least one param name and type matching query obj
            TestFind(target, new { arg1 = typeof(string) }, bflags, true);
            TestFind(target, new { arg2 = typeof(string) }, bflags, true);

            //should match all ctor where at least one param type matches a type in query obj
            
            //matches single int param
            TestFind(target, new[] { typeof(int) }, bflags, true);
            
            //matches double string param
            TestFind(target, new[] { typeof(string), typeof(string) }, bflags, true);
            TestFind(target, new [] { typeof(string)}, bflags, true);
            
            //matches parameterless
            TestFind(target, new Type[] { }, bflags, true);


            //when given an array of strings should match ctors with parameters that contain matching names
            //matches double string param
            TestFind(target, new[] { "arg1" }, bflags, true);
            TestFind(target, new[] { "arg2" }, bflags, true);
            TestFind(target, new[] { "arg1", "arg2" }, bflags, true);
            TestFind(target, new[] { "arg2", "arg1" }, bflags, true);
            
            //matches single int param
            TestFind(target, new[] { "arg"}, bflags, true);
            
            //matches empty param
            TestFind(target, new string[] { }, bflags, true);
        }




        [TestMethod]
        public void CtorFindPrivateParameterPositiveEq()
        {

            var target = new CtorPrivateParamlessTestClass(null);
            const BindingFlags bflags = BindingFlags.NonPublic | BindingFlags.Instance;

            //should match when exists parameterless ctor
            TestFind(target, new { }, bflags, true);


        }


        [TestMethod]
        public void CtorFindPrivateParameterNegativeEq()
        {
            var target = new CtorPrivateParamlessTestClass(null);
            const BindingFlags bflags = BindingFlags.NonPublic | BindingFlags.Instance;

            // should not match when binding strings do not match
            TestFind(target, new { arg = typeof(string) }, bflags, true);

            // should not match unless exist ctor exact match between arg name and arg type in query object
            TestFind(target, new { arg1 = typeof( string ), arg = typeof( string ) }, bflags, false);
            TestFind(target, new { arg = typeof ( string ), arg2 = typeof( string ) }, bflags, false);
            TestFind(target, new { arg = typeof ( int ), arg2 = typeof( string ) }, bflags, false);
            TestFind(target, new { arg1 = typeof( int ), arg2 = typeof( int ) }, bflags, false);
            TestFind(target, new { arg = typeof ( int ), arg1 = typeof( string ), arg2 = typeof( string ) }, bflags, false);
            TestFind(target, new { shouldnotfind1 = typeof( string ), shouldnotfind2 = typeof( string ) }, bflags, false);

        }


        [TestMethod]
        public void CtorFindPrivateParameterNegativeLike()
        {
            var target = new CtorPrivateParamlessTestClass(null);
            const BindingFlags bflags = BindingFlags.NonPublic | BindingFlags.Instance;

            // when given an other than a string[] or a type[]
            // should not match any ctor where 
            // all arg name type pairs cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            //or null is passed
            TestFind(target, new { arg1 = typeof(string), nothere = typeof(string) }, bflags, true);
            TestFind(target, new { arg2 = typeof(string), nothere = typeof(string) }, bflags, true);
            TestFind(target, null as object, bflags, true);

            // when given a type[ ]
            // should not match any ctor where 
            // all passed types cannot be mapped 
            // to a specific parameter uniquely in the type ctor
            TestFind(target, new[] { typeof(int) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(string) }, bflags, true);
            TestFind(target, new[] { typeof(int), typeof(int) }, bflags, true);

            // when given a string[ ]
            // should not match any ctors with parameters 
            // that cannot be mapped uniquely by name to passed string[]
            TestFind(target, new[] { "arg", "arg1" }, bflags, true);
            TestFind(target, new[] { "arg", "arg2" }, bflags, true);
            TestFind(target, new[] { "narg1", "narg2" }, bflags, true);
        }



        [TestMethod]
        public void CtorFindPrivateParameterPositiveLike()
        {
            var target = new CtorPrivateParamlessTestClass(null);
            const BindingFlags bflags = BindingFlags.NonPublic | BindingFlags.Instance;

            //should match all ctor where at least one param name and type matching query obj
            
            //matches empty
            TestFind(target, new { }, bflags, true);


            //should match all ctor where at least one param type matches a type in query obj
            //or if empty match parameterless

            //matches parameterless
            TestFind(target, new Type[] { }, bflags, true);


            //when given an array of strings should match ctors with parameters that contain matching names
            //or if empty match parameterless

            //matches empty param
            TestFind(target, new string[] { }, bflags, true);
        }

        [TestMethod]
        public void CtorAll()
        {
            var testing = CreateTestTarget( );

            const BindingFlags publicFlag = BindingFlags.Public | BindingFlags.Instance;
            const BindingFlags privateFlag = BindingFlags.NonPublic | BindingFlags.Instance;
            const BindingFlags staticFlag = BindingFlags.NonPublic | BindingFlags.Static;

            var expecting = new[]
            {
                typeof (CtorParamlessTestClass).GetConstructors(publicFlag),
                typeof (CtorPrivateParamlessTestClass).GetConstructors(privateFlag),
                typeof (CtorDoubleAndSingle).GetConstructors(publicFlag),
                typeof (CtorDoubleAndSingleAndParamless).GetConstructors(publicFlag),
                typeof(CtorStaticParamlessTestClass).GetConstructors(staticFlag)
            };



            var results = new[]
            {
                Tuple.Create(
                    typeof (CtorParamlessTestClass),
                    new CtorParamlessTestClass() as object,
                    publicFlag
                    ),
                Tuple.Create(
                    typeof (CtorPrivateParamlessTestClass),
                    new CtorPrivateParamlessTestClass(null) as object,
                    privateFlag
                    ),
                Tuple.Create(
                    typeof (CtorDoubleAndSingle),
                    new CtorDoubleAndSingle(null) as object,
                    publicFlag
                    ),
                Tuple.Create(
                    typeof (CtorDoubleAndSingleAndParamless),
                    new CtorDoubleAndSingleAndParamless() as object,
                    publicFlag
                    ),
                Tuple.Create(
                    typeof (CtorStaticParamlessTestClass),
                    new CtorStaticParamlessTestClass(null) as object,
                    publicFlag
                    ),
            }.Zip(expecting, Tuple.Create)
                .Select(a =>
                    Tuple.Create(
                        new HashSet<ConstructorInfo>(a.Item2),
                        new HashSet<ConstructorInfo>(testing.All(a.Item1.Item2)),
                        new HashSet<ConstructorInfo>(testing.All(a.Item1.Item1)),
                        new HashSet<ConstructorInfo>(testing.All(a.Item1.Item1, a.Item1.Item3)),
                        new HashSet<ConstructorInfo>(testing.All(a.Item1.Item2, a.Item1.Item3))
                        )
                );

            foreach (var result in results)
            {
                var expect = result.Item1;
                bool hasOverlap = false;

                foreach (var typeResult in result.Item2)
                    if (hasOverlap |= expect.Contains(typeResult)) break;

                foreach (var objResult in result.Item3)
                    if (hasOverlap |= expect.Contains(objResult)) break;

                foreach (var typeResult in result.Item4)
                    if (hasOverlap |= expect.Contains(typeResult)) break;

                foreach (var objResult in result.Item5)
                    if (hasOverlap |= expect.Contains(objResult)) break;
            }
        }
    }
}
