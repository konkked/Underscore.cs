﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Linq;
using Underscore.Object.Reflection;


namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class Property
    {
        public class Person
        {

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string NickName { get; set; }

            public string MiddleName { get; set; }

            public string Title { get; set; }

            public string Suffix { get; set; }

            public int Age { get; set; }

        }

        class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public decimal Salary { get; set; }
        }


        [TestMethod]
        public void ObjectPropertyHas( )
        {

            var person = new Person( );



            var _prop = new PropertyComponent(new Underscore.Function.CacheComponent());

            Assert.IsTrue( _prop.Has( person, "FirstName" ) );
            Assert.IsFalse( _prop.Has( person, "DoesNotHave" ) );
            Assert.IsTrue( _prop.Has( person, "firstname", false ) );
            Assert.IsFalse( _prop.Has( person, "firstname", true ) );

        }

        [TestMethod]
        public void ObjectPropertyFind( )
        {
            var properties = typeof( Person ).GetProperties( BindingFlags.Public | BindingFlags.Instance ) ; 
            var person = new Person( );


            var _prop = new PropertyComponent( new Underscore.Function.CacheComponent());

            var expecting = properties.First( a => a.Name == "FirstName" );
            var result = _prop.Find( person, "FirstName" );
            Assert.AreEqual( expecting, result );

            result = _prop.Find( person, "firstname", false );
            Assert.AreEqual( expecting, result );

            result = _prop.Find( person, "DoesNotHave" );

            Assert.IsNull( result );

            result = _prop.Find( person, "firstname", true ) ;
            Assert.IsNull( result );

            result = _prop.Find( person, "firstname" );
            Assert.IsNull( result );

        }

        [TestMethod]
        public async Task ObjectPropertyGetSet( ) 
        {

            var _prop = new PropertyComponent(new Underscore.Function.CacheComponent());

            await Util.Tasks.Start( ( ) =>
            {
                var person = new Person
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    MiddleName = "MiddleName",
                    NickName = "NickName",
                    Suffix = "Suffix",
                    Title = "Title",
                    Age = 24
                };


                int intExpecting =person.Age;
                int intResult = _prop.GetValue<int>( person, "Age" );
                Assert.AreEqual( intExpecting, intResult );

                string expecting = person.FirstName;
                string result = _prop.GetValue<string>( person, "FirstName" );
                Assert.AreEqual( expecting, result );


                expecting = person.MiddleName;
                result = _prop.GetValue<string>( person, "MiddleName" );
                Assert.AreEqual( expecting, result );

                expecting = person.LastName;
                result = _prop.GetValue<string>( person, "LastName" );
                Assert.AreEqual( expecting, result );

                expecting = person.NickName;
                result = _prop.GetValue<string>( person, "NickName" );
                Assert.AreEqual( expecting, result );

                expecting = person.Suffix;
                result = _prop.GetValue<string>( person, "Suffix" );
                Assert.AreEqual( expecting, result );

                expecting = person.Title;
                result = _prop.GetValue<string>( person, "Title" );
                Assert.AreEqual( expecting, result );

            },( ) =>
            {
                var person = new Person
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    MiddleName = "MiddleName",
                    NickName = "NickName",
                    Suffix = "Suffix",
                    Title = "Title",
                    Age = 24
                };


                object intExpecting =person.Age;
                object intResult = _prop.GetValue( person, "Age" );
                Assert.AreEqual( intExpecting, intResult );

                object expecting = person.FirstName;
                object result = _prop.GetValue( person, "FirstName" );
                Assert.AreEqual( expecting, result );


                expecting = person.MiddleName;
                result = _prop.GetValue( person, "MiddleName" );
                Assert.AreEqual( expecting, result );

                expecting = person.LastName;
                result = _prop.GetValue( person, "LastName" );
                Assert.AreEqual( expecting, result );

                expecting = person.NickName;
                result = _prop.GetValue( person, "NickName" );
                Assert.AreEqual( expecting, result );

                expecting = person.Suffix;
                result = _prop.GetValue( person, "Suffix" );
                Assert.AreEqual( expecting, result );

                expecting = person.Title;
                result = _prop.GetValue( person, "Title" );
                Assert.AreEqual( expecting, result );

            }, ( ) =>
            {
                var person = new Person
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    MiddleName = "MiddleName",
                    NickName = "NickName",
                    Suffix = "Suffix",
                    Title = "Title",
                    Age = 24
                };


                int intExpecting =12;
                _prop.SetValue<int>( person, "Age", intExpecting );
                int intResult = person.Age;

                Assert.AreEqual( intExpecting, intResult );

                string expecting = "Jon";
                _prop.SetValue<string>( person, "FirstName" ,expecting);
                string result = person.FirstName;

                Assert.AreEqual( expecting, result );



                expecting = "Midding";
                _prop.SetValue<string>( person, "MiddleName", expecting );
                result = person.MiddleName;

                Assert.AreEqual( expecting, result );

                expecting = "DurpDurp";
                _prop.SetValue<string>( person, "LastName", expecting );
                result = person.LastName;
                
                Assert.AreEqual( expecting, result );
                
                expecting = "NewNickName";
                _prop.SetValue<string>( person, "NickName", expecting );
                result = person.NickName;
                
                Assert.AreEqual( expecting, result );
                
                expecting = "NewSuffix";
                _prop.SetValue<string>( person, "Suffix", expecting );
                result = person.Suffix;

                Assert.AreEqual( expecting, result );


                expecting = "NewTitle";
                _prop.SetValue<string>( person, "Title", expecting );
                result = person.Title;

                Assert.AreEqual( expecting, result );
            }, ( ) =>
            {
                var person = new Person
                {
                    FirstName = "FirstName",
                    LastName = "LastName",
                    MiddleName = "MiddleName",
                    NickName = "NickName",
                    Suffix = "Suffix",
                    Title = "Title",
                    Age = 24
                };


                object intExpecting =12;
                _prop.SetValue( person, "Age", intExpecting );
                object intResult = person.Age;

                Assert.AreEqual( intExpecting, intResult );

                object expecting = "Jon";
                _prop.SetValue( person, "FirstName", expecting );
                object result = person.FirstName;

                Assert.AreEqual( expecting, result );



                expecting = "Midding";
                _prop.SetValue( person, "MiddleName", expecting );
                result = person.MiddleName;

                Assert.AreEqual( expecting, result );

                expecting = "DurpDurp";
                _prop.SetValue( person, "LastName", expecting );
                result = person.LastName;

                Assert.AreEqual( expecting, result );

                expecting = "NewNickName";
                _prop.SetValue( person, "NickName", expecting );
                result = person.NickName;

                Assert.AreEqual( expecting, result );

                expecting = "NewSuffix";
                _prop.SetValue( person, "Suffix", expecting );
                result = person.Suffix;

                Assert.AreEqual( expecting, result );


                expecting = "NewTitle";
                _prop.SetValue( person, "Title", expecting );
                result = person.Title;

                Assert.AreEqual( expecting, result );
            } );
        }


        [TestMethod]
        public void PropertyGetValues()
        {
            var testing = new PropertyComponent(new Underscore.Function.CacheComponent());
            var testTarget = new Person
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                Age = 24
            };
            
            Assert.AreEqual(                                            //order of decl
                string.Join("", testing.Values<string>(testTarget)), "FirstNameLastNameNickNameMiddleNameTitleSuffix");
            Assert.AreEqual(24, testing.Values<int>(testTarget).FirstOrDefault());

            
        }

        [TestMethod]
        public async Task ObjectProperties()
        {
            var testing = SetupPropertiesTarget();


            var example1 = new { A = 'A', B = "B", C = 1 };
            var example2 = new Person
            {
                Title = "Mr.",
                FirstName = "Charles",
                MiddleName = "Henry",
                LastName = "Keyser",
                Suffix = "IV",
                NickName = "Chip",
                Age = 24,
            };

            await Util.Tasks.Start(() =>
            {

                var props = testing.All(example1);

                var propA = props.FirstOrDefault(a =>
                    a.Name == "A"
                    && a.PropertyType == typeof(char)
                    && ((char)a.GetGetMethod().Invoke(example1, new object[0])) == 'A');


                var propB = props.FirstOrDefault(a =>
                    a.Name == "B"
                    && a.PropertyType == typeof(string)
                    && ((string)a.GetGetMethod().Invoke(example1, new object[0])) == "B");


                var propC = props.FirstOrDefault(a =>
                    a.Name == "C"
                    && a.PropertyType == typeof(int)
                    && ((int)a.GetGetMethod().Invoke(example1, new object[0])) == 1);

                Assert.IsNotNull(propA);
                Assert.IsNotNull(propB);
                Assert.IsNotNull(propC);
            }, () =>
            {

                var props = testing.OfType(example2, typeof(string));

                Func<string, string, PropertyInfo, bool> strvaluematchfilter =
                    (n, v, a) =>
                        a.PropertyType == typeof(string) &&
                        a.Name == n &&
                        ((string)a.GetGetMethod().Invoke(example2, new object[0])) == v
                    ;

                Func<string, string, Func<PropertyInfo, bool>> createStrTest = (n, v) => (a) => strvaluematchfilter(n, v, a);

                var propertyInfos = props as PropertyInfo[] ?? props.ToArray();
                var title = propertyInfos.FirstOrDefault(createStrTest("Title", "Mr."));
                var firstName = propertyInfos.FirstOrDefault(createStrTest("FirstName", "Charles"));
                var lastName = propertyInfos.FirstOrDefault(createStrTest("LastName", "Keyser"));
                var nickName = propertyInfos.FirstOrDefault(createStrTest("NickName", "Chip"));
                var middleName = propertyInfos.FirstOrDefault(createStrTest("MiddleName", "Henry"));
                var suffix = propertyInfos.FirstOrDefault(createStrTest("Suffix", "IV"));

                var shouldBe0 = propertyInfos.Count(a => a.PropertyType != typeof(string));

                foreach (var item in new[] { title, firstName, lastName, nickName, middleName, suffix })
                    Assert.IsNotNull(item);

                Assert.AreEqual(0, shouldBe0);
            });
        }

        private static PropertyComponent SetupPropertiesTarget()
        {
            var testing = new PropertyComponent(new MockUtilFunctionComponent());
            return testing;
        }

        class OtherPerson2
        {
            private readonly int _age;

            public OtherPerson2(int age)
            {
                _age = age;
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string NickName { get; set; }

            public string MiddleName { get; set; }

            public string Title { get; set; }

            public string Suffix { get; set; }

            public int Age { get { return _age; } }

            public int NumberOfKids { get; set; }
        }

        //TODO: Fix this crap... hurts my face when I read
        [TestMethod]
        public async Task ObjectPropertyForeach()
        {
            var person = new OtherPerson2(25)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 0
            };

            var person2 = new OtherPerson2(25)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 3
            };


            //for single action param
            HashSet<object> propertiesContent = new HashSet<object>();

            person.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(
                    a => !a.GetIndexParameters().Any() && a.CanRead && a.GetGetMethod() != null)
                .ToList().ForEach(a => propertiesContent.Add(a.GetGetMethod().Invoke(person, null)));

            Action<object> oneParamAction = (o) => Assert.IsTrue(propertiesContent.Contains(o), "Did not have property of value {0}", o);


            Dictionary<string, object> propertiesDict =
                person.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(a => !a.GetIndexParameters().Any() && a.GetGetMethod() != null)
                    .ToDictionary(
                        a => a.Name,
                        v => v.GetGetMethod().Invoke(person, null)
                    );

            Action<object, string> twoParamAction = (value, name) =>
                    Assert.IsTrue(
                        propertiesDict.ContainsKey(name) && (

                            (propertiesDict[name] == null && value == null) ||
                            (
                                (propertiesDict[name] != null && value != null)
                                && propertiesDict[name].Equals(value)
                            )
                        ),
                        "Does not have expected property of with name {0} and value {1}",
                        value,
                        name
                    );

            Dictionary<string, Tuple<Func<object>, Action<object>>> propertiesSettableDict =
                person2.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(a => !a.GetIndexParameters().Any() && a.GetGetMethod() != null)
                    .ToDictionary(
                        a => a.Name,
                        v => Tuple.Create(
                                new Func<object>(() => v.GetGetMethod().Invoke(person2, null)),
                                v.GetSetMethod() != null ?
                                    ((o) => v.GetSetMethod().Invoke(person2, new[] { o })) :
                                    null as Action<object>)
                                );



            Action<object, string, Action<object>> threeParamAction = (value, name, assigner) =>
            {
                var orig = value;

                Assert.IsTrue(
                    propertiesSettableDict.ContainsKey(name) &&
                    (
                        (propertiesDict[name] == null && orig == null)
                        ||
                        (
                            (
                                orig != null && propertiesDict[name] != null
                            )
                            && propertiesSettableDict[name].Item1().Equals(orig)
                        )
                    ), "Expected property of name {0} and value {1} not found", name, orig
                );

                if (assigner != null)
                {
                    var assiging =
                        (value != null && value.GetType() == typeof(string)) ?
                            string.Empty as object :
                        //otherwise value is int in this case
                            ((int)value) + 1
                        ;

                    if (assiging is string && ((string)assiging) == ((string)value))
                    {
                        assiging = "AltDefault";
                    }

                    if (assiging is int && ((int)assiging) == ((int)value))
                    {
                        assiging = ((int)assiging) + 1;
                    }

                    //type in this instance is string or int
                    assigner(assiging);

                    Assert.AreNotEqual(orig,
                            propertiesSettableDict[name].Item1(),
                            "expected value change from {0} to {1}", orig, value
                    );

                    //should be equivelant to included method
                    propertiesSettableDict[name].Item2(orig);

                    Assert.AreEqual(orig,
                        propertiesSettableDict[name].Item1(),
                        "expected value change from {0} to {1}", value, orig
                    );

                    //should not break the assigner method
                    assigner(assiging);

                    Assert.AreNotEqual(orig,
                            propertiesSettableDict[name].Item1(),
                            "expected value change from {0} to {1}", orig, value
                    );


                }
            };

            //var mkutil = new _ForeachPropertyUtilMock();
            //var mkprops = new

            //mkutil.Setup(a=>a.Memoize(It.Is<Func<Type,IEnumerable<).

            //var target = 
            var testing = SetupPropertiesTarget();
            await Util.Tasks.Start(
                () => testing.Each(person, oneParamAction),
                () => testing.Each(person, twoParamAction),
                () => testing.Each(person2, threeParamAction)
            );



        }

        [TestMethod]
        public async Task PropertyForeachGeneric()
        {
            var person = new OtherPerson2(25)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 3
            };

            var person2 = new OtherPerson2(30)
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 3
            };

            /*
             * General Notes:
             *  Because there is no implicit conversion between int and string
             *  methods should blow up if one of the int props is passed
             */

            //for single action param
            var propertiesContent = new HashSet<string>();

            person.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(
                    a =>
                            !a.GetIndexParameters().Any()
                            && a.CanRead
                            && a.GetGetMethod() != null
                            && a.PropertyType == typeof(string)
                ).ToList()
                .ForEach(
                    a => propertiesContent.Add(
                            (string)a.GetGetMethod().Invoke(person, null)
                    )
                );

            Action<string> oneParamAction =
                o =>
                    Assert.IsTrue(
                        propertiesContent.Contains(o),
                        "Did not have property of value {0}",
                        o
                    );


            Dictionary<string, string> propertiesDict =
                person.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(
                        a => !a.GetIndexParameters().Any()
                            && a.CanRead
                            && a.GetGetMethod() != null
                            && a.PropertyType == typeof(string)
                    ).ToDictionary(
                        a => a.Name,
                        v => (string)v.GetGetMethod().Invoke(person, null)
                    );

            Action<string, string> twoParamAction = (value, name) =>
                    Assert.IsTrue(
                        propertiesDict.ContainsKey(name) &&
                        (
                            (propertiesDict[name] == null && value == null) ||
                            (
                                (propertiesDict[name] != null && value != null)
                                && propertiesDict[name] == value
                            )
                        ),
                        "Does not have expected property of with name {0} and value {1}",
                        value,
                        name
                    );

            Dictionary<string, Tuple<Func<string>, Action<string>>> propertiesSettableDict =
                person2
                    .GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(a => !a.GetIndexParameters().Any()
                                        && a.CanRead && a.GetGetMethod() != null
                                        && a.PropertyType == typeof(string)
                    ).ToDictionary(
                        a => a.Name,
                        v => Tuple.Create(
                                new Func<string>(
                                    () => (string)v.GetGetMethod().Invoke(person2, null)
                                ),

                                v.GetSetMethod() == null ? null as Action<string> :
                                    ((o) => v.GetSetMethod().Invoke(person2, new object[] { o }))
                            )
                    );



            Action<string, string, Action<string>> threeParamAction = (value, name, assigner) =>
            {
                var orig = value;

                Assert.IsTrue(propertiesSettableDict.ContainsKey(name) && propertiesSettableDict[name].Item1() == orig,
                    "Expected property of name {0} and value {1} not found", name, orig
                );

                //only string so should all be assigneable
                Assert.IsNotNull(assigner);

                //type in this instance is always string, so just set to empty string
                assigner(string.Empty);

                Assert.AreNotEqual(
                        orig,
                        propertiesSettableDict[name].Item1(),
                        "expected value change from {0} to {1}", orig, "[ string.Empty ]"
                    );

                //should be equivelant to included method
                propertiesSettableDict[name].Item2(orig);

                Assert.AreEqual(orig, propertiesSettableDict[name].Item1(),
                    "expected value change from {0} to {1}", "[ string.Empty ]", orig);

                //should not break the assigner method
                assigner(string.Empty);

                Assert.AreNotEqual(
                        orig,
                        propertiesSettableDict[name].Item1(),
                        "expected value change from {0} to {1}", orig, "[ string.Empty ]"
                    );

            };
            var testing = SetupPropertiesTarget();
            await Util.Tasks.Start(
                () => testing.Each(person, oneParamAction),
                () => testing.Each(person, twoParamAction),
                () => testing.Each(person2, threeParamAction)
            );

        }
    }
}
