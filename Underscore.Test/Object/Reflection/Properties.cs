using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object.Reflection;


namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class PropertiesTest
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
        public async Task ObjectProperties( )
        {
            var testing = SetupPropertiesTarget( );


            var example1 = new { A = 'A', B = "B", C = 1 };
            var example1Type = example1.GetType( );
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
            var example2Type = typeof( Person );

            await Util.Tasks.Start( ( ) =>
            {

                var props = testing.All( example1 );

                var propA = props.FirstOrDefault( a =>
                    a.Name == "A"
                    && a.PropertyType == typeof( char )
                    && ( ( char ) a.GetGetMethod( ).Invoke( example1, new object[ 0 ] ) ) == 'A' );


                var propB = props.FirstOrDefault( a =>
                    a.Name == "B"
                    && a.PropertyType == typeof( string )
                    && ( ( string ) a.GetGetMethod( ).Invoke( example1, new object[ 0 ] ) ) == "B" );


                var propC = props.FirstOrDefault( a =>
                    a.Name == "C"
                    && a.PropertyType == typeof( int )
                    && ( ( int ) a.GetGetMethod( ).Invoke( example1, new object[ 0 ] ) ) == 1 );

                Assert.IsNotNull( propA );
                Assert.IsNotNull( propB );
                Assert.IsNotNull( propC );
            },()=>{

                var props = testing.OfType( example2, typeof( string ) );

                Func<string,string,PropertyInfo,bool> strvaluematchfilter = 
                    ( n, v, a ) =>
                        a.PropertyType == typeof( string ) &&
                        a.Name == n &&
                        ( ( string ) a.GetGetMethod( ).Invoke( example2, new object[ 0 ] ) ) == v
                    ;

                Func<string, string, Func<PropertyInfo, bool>> create_str_test = ( n, v ) => ( a ) => strvaluematchfilter( n, v, a );

                var title = props.FirstOrDefault( create_str_test( "Title", "Mr." ) );
                var firstName = props.FirstOrDefault( create_str_test( "FirstName", "Charles" ) );
                var lastName = props.FirstOrDefault( create_str_test( "LastName", "Keyser" ) );
                var nickName = props.FirstOrDefault( create_str_test( "NickName", "Chip" ) );
                var middleName = props.FirstOrDefault( create_str_test( "MiddleName", "Henry" ) );
                var suffix = props.FirstOrDefault( create_str_test( "Suffix", "IV" ) );

                var shouldBe0 = props.Count( a => a.PropertyType != typeof( string ) );

                foreach ( var item in new[ ] { title, firstName, lastName, nickName, middleName, suffix } )
                    Assert.IsNotNull( item );

                Assert.AreEqual( 0, shouldBe0 );
            });
        }

        private static PropertyComponent SetupPropertiesTarget( )
        {
            var testing = new PropertyComponent(new MockUtilFunctionComponent());
            return testing;
        }

        class OtherPerson
        {
            private readonly int _age;

            public OtherPerson( int age )
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
        }

        class OtherPerson2
        {
            private readonly int _age;

            public OtherPerson2( int age )
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
        public async Task ObjectPropertyForeach( )
        {
            var person = new OtherPerson2( 25 )
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 0
            };

            var person2=new OtherPerson2( 25 )
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
            HashSet<object> propertiesContent = new HashSet<object>( );

            person.GetType( ).GetProperties( BindingFlags.Public | BindingFlags.Instance )
                .Where(
                    a => a.GetIndexParameters( ).Count( ) == 0 && a.CanRead && a.GetGetMethod( ) != null )
                .ToList( ).ForEach( a => propertiesContent.Add( a.GetGetMethod( ).Invoke( person, null ) ) );

            Action<object> oneParamAction = ( o ) => Assert.IsTrue( propertiesContent.Contains( o ), "Did not have property of value {0}", o );


            Dictionary<string, object> propertiesDict =
                person.GetType( )
                    .GetProperties( BindingFlags.Instance | BindingFlags.Public )
                    .Where( a => a.GetIndexParameters( ).Count( ) == 0 && a.GetGetMethod( ) != null )
                    .ToDictionary(
                        a => a.Name,
                        v => v.GetGetMethod( ).Invoke( person, null )
                    );

            Action<object,string> twoParamAction = ( value, name ) =>
                    Assert.IsTrue(
                        propertiesDict.ContainsKey( name ) && (

                            ( propertiesDict[ name ] == null && value == null ) ||
                            (
                                ( propertiesDict[ name ] != null && value != null )
                                && propertiesDict[ name ].Equals( value )
                            )
                        ),
                        "Does not have expected property of with name {0} and value {1}",
                        value,
                        name
                    );

            Dictionary<string, Tuple<Func<object>, Action<object>>> propertiesSettableDict =
                person2.GetType( )
                    .GetProperties( BindingFlags.Instance | BindingFlags.Public )
                    .Where( a => a.GetIndexParameters( ).Count( ) == 0 && a.GetGetMethod( ) != null )
                    .ToDictionary(
                        a => a.Name,
                        v => Tuple.Create(
                                new Func<object>( ( ) => v.GetGetMethod( ).Invoke( person2, null ) ),
                                v.GetSetMethod( ) != null ?
                                    new Action<object>( ( o ) => v.GetSetMethod( ).Invoke( person2, new object[ ] { o } ) ) :
                                    null as Action<object> )
                                );



            Action<object, string, Action<object>> threeParamAction = ( value, name, assigner ) =>
            {
                var orig = value;

                Assert.IsTrue(
                    propertiesSettableDict.ContainsKey( name ) &&
                    (
                        ( propertiesDict[ name ] == null && orig == null )
                        ||
                        (
                            (
                                orig != null && propertiesDict[ name ] != null
                            )
                            && propertiesSettableDict[ name ].Item1( ).Equals( orig )
                        )
                    ), "Expected property of name {0} and value {1} not found", name, orig
                );

                if ( assigner != null )
                {
                    var assiging = 
                        ( value != null && value.GetType( ) == typeof( string ) ) ?
                            string.Empty as object :
                        //otherwise value is int in this case
                            ( ( int ) value ) + 1
                        ;

                    if ( assiging.GetType( ) == typeof( string ) && ( ( string ) assiging ) == ( ( string ) value ) )
                    {
                        assiging = "AltDefault";
                    }

                    if ( assiging.GetType( ) == typeof( int ) && ( ( int ) assiging ) == ( ( int ) value ) )
                    {
                        assiging = ( ( int ) assiging ) + 1;
                    }

                    //type in this instance is string or int
                    assigner( assiging );

                    Assert.AreNotEqual( orig,
                            propertiesSettableDict[ name ].Item1( ),
                            "expected value change from {0} to {1}", orig, value
                    );

                    //should be equivelant to included method
                    propertiesSettableDict[ name ].Item2( orig );

                    Assert.AreEqual( orig,
                        propertiesSettableDict[ name ].Item1( ),
                        "expected value change from {0} to {1}", value, orig
                    );

                    //should not break the assigner method
                    assigner( assiging );

                    Assert.AreNotEqual( orig,
                            propertiesSettableDict[ name ].Item1( ),
                            "expected value change from {0} to {1}", orig, value
                    );


                }
            };

            //var mkutil = new _ForeachPropertyUtilMock();
            //var mkprops = new

            //mkutil.Setup(a=>a.Memoize(It.Is<Func<Type,IEnumerable<).

            //var target = 
            var testing = SetupPropertiesTarget( );
            await Util.Tasks.Start(
                ( ) => testing.Each( person, oneParamAction ),
                ( ) => testing.Each( person, twoParamAction ),
                ( ) => testing.Each( person2, threeParamAction )
            );



        }

        [TestMethod]
        public async Task PropertyForeachGeneric( )
        {
            var person = new OtherPerson2( 25 )
            {
                FirstName = "FirstName",
                LastName = "LastName",
                MiddleName = "MiddleName",
                NickName = "NickName",
                Suffix = "Suffix",
                Title = "Title",
                NumberOfKids = 3
            };

            var person2 = new OtherPerson2( 30 )
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
            HashSet<string> propertiesContent = new HashSet<string>( );

            person.GetType( )
                .GetProperties( BindingFlags.Public | BindingFlags.Instance )
                .Where(
                    a =>
                            a.GetIndexParameters( ).Count( ) == 0
                            && a.CanRead
                            && a.GetGetMethod( ) != null
                            && a.PropertyType == typeof( string )
                ).ToList( )
                .ForEach(
                    a => propertiesContent.Add(
                            ( string ) a.GetGetMethod( ).Invoke( person, null )
                    )
                );

            Action<string> oneParamAction = 
                ( o ) =>
                    Assert.IsTrue(
                        propertiesContent.Contains( o ),
                        "Did not have property of value {0}",
                        o
                    );


            Dictionary<string, string> propertiesDict =
                person.GetType( )
                    .GetProperties( BindingFlags.Instance | BindingFlags.Public )
                    .Where(
                        a => a.GetIndexParameters( ).Count( ) == 0
                            && a.CanRead
                            && a.GetGetMethod( ) != null
                            && a.PropertyType == typeof( string )
                    ).ToDictionary(
                        a => a.Name,
                        v => ( string ) v.GetGetMethod( ).Invoke( person, null )
                    );

            Action<string, string> twoParamAction = ( value, name ) =>
                    Assert.IsTrue(
                        propertiesDict.ContainsKey( name ) &&
                        (
                            ( propertiesDict[ name ] == null && value == null ) ||
                            (
                                ( propertiesDict[ name ] != null && value != null )
                                && propertiesDict[ name ] == value
                            )
                        ),
                        "Does not have expected property of with name {0} and value {1}",
                        value,
                        name
                    );

            Dictionary<string, Tuple<Func<string>, Action<string>>> propertiesSettableDict =
                person2
                    .GetType( )
                    .GetProperties( BindingFlags.Instance | BindingFlags.Public )
                    .Where( a => a.GetIndexParameters( ).Count( ) == 0
                                        && a.CanRead && a.GetGetMethod( ) != null
                                        && a.PropertyType == typeof( string )
                    ).ToDictionary(
                        a => a.Name,
                        v => Tuple.Create(
                                new Func<string>(
                                    ( ) => ( string ) v.GetGetMethod( ).Invoke( person2, null )
                                ),

                                v.GetSetMethod( ) == null ? null as Action<string> :
                                    new Action<string>(
                                        ( o ) => v.GetSetMethod( ).Invoke( person2, new object[ ] { o } )
                                    )
                            )
                    );



            Action<string, string, Action<string>> threeParamAction = ( value, name, assigner ) =>
            {
                var orig = value;

                Assert.IsTrue( propertiesSettableDict.ContainsKey( name ) && propertiesSettableDict[ name ].Item1( ) == orig,
                    "Expected property of name {0} and value {1} not found", name, orig
                );

                //only string so should all be assigneable
                Assert.IsNotNull( assigner );

                //type in this instance is always string, so just set to empty string
                assigner( string.Empty );

                Assert.AreNotEqual(
                        orig,
                        propertiesSettableDict[ name ].Item1( ),
                        "expected value change from {0} to {1}", orig, "[ string.Empty ]"
                    );

                //should be equivelant to included method
                propertiesSettableDict[ name ].Item2( orig );

                Assert.AreEqual( orig, propertiesSettableDict[ name ].Item1( ),
                    "expected value change from {0} to {1}", "[ string.Empty ]", orig );

                //should not break the assigner method
                assigner( string.Empty );

                Assert.AreNotEqual(
                        orig,
                        propertiesSettableDict[ name ].Item1( ),
                        "expected value change from {0} to {1}", orig, "[ string.Empty ]"
                    );

            };
            var testing = SetupPropertiesTarget( );
            await Util.Tasks.Start(
                ( ) => testing.Each<string>( person, oneParamAction ),
                ( ) => testing.Each<string>( person, twoParamAction ),
                ( ) => testing.Each<string>( person2, threeParamAction )
            );

        }

    }
}
