using System;
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
    }
}
