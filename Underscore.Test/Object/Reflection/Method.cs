using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object.Reflection;
using System.Linq.Expressions;

namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class Method
    {
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

            public string ShouldShowStringReturnValue( ) { return string.Empty; }
            private string ShouldntShowStringReturnValue( ) { return string.Empty; }

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


            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is( EqualTo( new { arg1 = typeof( string ), arg2 = typeof( string ) } ) )
                )
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is<Type[]>( b => b.Length == 2 && b[0] == typeof(string) && b[1] == typeof(string ) )
                )
            )
            .Returns( expectingForQueryEmpty );


            mock.Setup(
                a => a.Query(
                    It.Is<object>( b => ( b is MethodMethodsTestClass || ( b is Type && typeof( MethodMethodsTestClass ) == ( Type ) b ) ) ),
                    It.Is<string[]>( b => b.Count( ) == 2 && b[0] == "arg1" && b[1] == "arg2" )
                )
            )
            .Returns( expectingForQueryEmpty );



        
        
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

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is( EqualTo( new { arg = typeof(string) } ) ) 
                ) 
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    typeof(string) 
                )
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    typeof( string )
                )
            )
            .Returns( expectingForQueryEmpty);


            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    "arg"
                )
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup(
                a => a.Query(
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ),
                    It.Is( EqualTo( new { arg = typeof( string ) } ) )
                )
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is<object[ ]>( 
                        b => b.Length == 1 
                            && ( 
                                ( b[0] is Type && typeof(string) == ( (Type) b[0] ) )
                                || ( b[0] is string && "arg" == ((string)b[0]) )
                            )
                    )
                )
            )
            .Returns( expectingForQueryEmpty );

            mock.Setup( 
                a => a.Query( 
                    It.Is<object>( b=> ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), 
                    It.Is<object>( b => b == null ) 
                ) 
            )
            .Returns( expectingForQueryEmpty );
        
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

            mock.Setup( a => a.Query( It.Is<object>( b => ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), It.Is( EqualTo( new { } ) ) ) )
                .Returns( expectingForQueryEmpty );

            mock.Setup( a => a.Query( It.Is<object>( b => ( b is MethodMethodsTestClass || (b is Type && typeof(MethodMethodsTestClass) == (Type)b ) ) ), It.Is<object[ ]>( b => b.Length == 0 ) ) )
                .Returns( expectingForQueryEmpty );

            mock.Setup( a => a.Query(It.IsAny<object>(), It.Is<object>(b=> b == null || !(b.GetType()==typeof(string) && ((string)b).Contains("Shouldnt") ) ) ) )
                .Returns( expectingForQueryEmpty );
        }


        [TestMethod]
        public async Task ObjectMethodFind( ) 
        {
            var target = new MethodMethodsTestClass( );


            await Util.Tasks.Start(
                ( ) =>
                {
                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher) );

                    var expecting = typeof( MethodMethodsTestClass )
                        .GetMethods( BindingFlags.Public | BindingFlags.Instance )
                        .Where( a => a.GetParameters( ).FirstOrDefault( ) == null )
                        .First();

                    var results =  new[ ]{
                        testing.Find( target, "ShouldShowNoReturnValue" ),
                        testing.Find( target, "ShouldShowNoReturnValue", new { } ),
                        testing.Find( target, "ShouldShowNoReturnValue", new object[ ] { } ),
                        testing.Find( target, "ShouldShowNoReturnValue", null ) 
                    };


                    var allNotNull = !results.Aggregate( false, ( prev, curr ) => prev || curr == null );

                    Assert.IsTrue( allNotNull, "One of the targeting Find results returned null when expecting corresponding method info" );


                    var allEqual = results.Aggregate( expecting , ( prev, curr ) => prev == curr ? curr : null ) != null;

                    Assert.IsTrue( allEqual, "One of the targeting Find results were not equal, all calls to empty find should be eqiv" );

                    results = new[]{
                        testing.Find( target, "ShouldntShowNoReturnValue" ) ,
                        testing.Find( target, "ShouldntShowNoReturnValue", new { } ) ,
                        testing.Find( target, "ShouldntShowNoReturnValue", new object[ ] { } ) , 
                        testing.Find( target, "ShouldntShowNoReturnValue", null ) 
                    };

                    var allNull = results.Aggregate( true, ( prev, curr ) => prev && curr == null );

                    Assert.IsTrue( allNull, "One of the invalid calls to Find found a method when expecting all to return null" );


                },
                ( ) =>
                {

                    var expecting = typeof( MethodMethodsTestClass )
                        .GetMethods( BindingFlags.Public | BindingFlags.Instance )
                        .Where ( 
                            a => a.GetParameters().Count() == 1
                                && a.GetParameters( ).First().ParameterType == typeof(string) 
                                && a.GetParameters().First().Name == "arg"
                        )
                        .First( );

                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

                    var results = new[]{
                        testing.Find( target, "ShouldShowNoReturnValue", new { arg = typeof( string ) } ),
                        testing.Find( target, "ShouldShowNoReturnValue", new[ ] { typeof( string ) } ) ,
                        testing.Find( target, "ShouldShowNoReturnValue", typeof( string ) ) ,
                        testing.Find( target, "ShouldShowNoReturnValue", new[ ] { "arg" } ) ,
                        testing.Find( target, "ShouldShowNoReturnValue", "arg" ) 
                    };

                    var allNotNull = !results.Aggregate( false, ( prev, curr ) => prev || curr == null );

                    Assert.IsTrue( allNotNull, "One of the targeting Find results returned null when expecting corresponding method info" );


                    var allEqual = results.Aggregate( expecting, ( prev, curr ) => prev == curr ? curr : null ) != null;

                    Assert.IsTrue( allEqual, "One of the targeting Find results were not equal, all calls to empty find should be eqiv" );


                    results = new[ ]{
                       testing.Find( target, "ShouldntShowNoReturnValue", new { arg = typeof( string ) } ),
                       testing.Find( target, "ShouldntShowNoReturnValue", new[ ] { typeof( string ) } ) ,
                       testing.Find( target, "ShouldntShowNoReturnValue", typeof( string ) ) ,
                       testing.Find( target, "ShouldntShowNoReturnValue", new[ ] { "arg" } ),
                       testing.Find( target, "ShouldntShowNoReturnValue", "arg" )
                   };

                    var allNull = results.Aggregate( true, ( prev, curr ) => prev && curr == null );

                    Assert.IsTrue( allNull, "One of the invalid calls to Find found a method when expecting all to return null" );

                },
                ( ) =>
                {
                    var expecting = typeof( MethodMethodsTestClass )
                        .GetMethods( BindingFlags.Public | BindingFlags.Instance )
                        .Where(
                            a =>a.GetParameters().Count() == 2 
                                && a.GetParameters( ).First( ).ParameterType == typeof( string )
                                && a.GetParameters( ).First( ).Name == "arg1"
                                &&a.GetParameters().Skip(1).First( ).ParameterType == typeof(string)
                                && a.GetParameters().Skip(1).First().Name == "arg2"
                                && a.Name == "ShouldShowNoReturnValue"
                        )
                        .First( );

                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

                    var results = new[]{
                        testing.Find( target, "ShouldShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ) ,
                        testing.Find( target, "ShouldShowNoReturnValue", new[ ] { typeof( string ), typeof( string ) } ),
                        testing.Find( target, "ShouldShowNoReturnValue", new[ ] { "arg1", "arg2" } ) 
                    };

                    var allNotNull = !results.Aggregate( false, ( prev, curr ) => prev || curr == null );

                    Assert.IsTrue( allNotNull, "One of the targeting Find results returned null when expecting corresponding method info" );


                    var allEqual = results.Aggregate( expecting, ( prev, curr ) => prev == curr ? curr : null ) != null;

                    Assert.IsTrue( allEqual, "One of the targeting Find results were not equal, all calls to empty find should be eqiv" );


                    results = new[]{
                        testing.Find( target, "ShouldntShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ) ,
                        testing.Find( target, "ShouldntShowNoReturnValue", new[ ] { typeof( string ), typeof( string ) } ) ,
                        testing.Find( target, "ShouldntShowNoReturnValue", new[ ] { "arg1", "arg2" } )
                    };

                    var allNull = results.Aggregate( true, ( prev, curr ) => prev && curr == null );

                    Assert.IsTrue( allNull, "One of the invalid calls to Find found a method when expecting all to return null" );


                    results = new[]{ 
                        testing.Find(target, "ShouldShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof( string ) } ),
                        testing.Find(target,"ShouldShowNoReturnValue",new []{ typeof(string), typeof(string)}),
                        testing.Find(target,"ShouldShowNoReturnValue",new[]{"arg1","arg2"})
                    };


                    allNotNull = !results.Aggregate( false, ( prev, curr ) => prev || curr == null );

                    Assert.IsTrue( allNotNull, "One of the targeting Find results returned null when expecting corresponding method info" );


                    allEqual = results.Aggregate( expecting, ( prev, curr ) => prev == curr ? curr : null ) != null;

                    Assert.IsTrue( allEqual, "One of the targeting Find results were not equal, all calls to empty find should be eqiv" );

                    results =  new[ ]{ 
                        testing.Find( target, "ShouldntShowNoReturnValue", new { arg1 = typeof( string ), arg2 = typeof(string) } ),
                        testing.Find(target,"ShouldntShowNoReturnValue",new []{ typeof(string),typeof(string)}),
                        testing.Find(target,"ShouldntShowNoReturnValue",new[]{"arg1", "arg2"})
                    };

                },
                ( ) =>
                {
                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

                    Assert.IsNull( testing.Find( target, "get_PublicPropertyShouldNotShow" ) );
                    Assert.IsNull( testing.Find( target, "get_PrivatePropertyShouldNotShow" ) );

                    Assert.IsNull( testing.Find( target, "set_PublicPropertyShouldNotShow", new { value = typeof( string ) } ) );
                    Assert.IsNull( testing.Find( target, "set_PublicPropertyShouldNotShow", new[ ] { typeof( string ) } ) );
                    Assert.IsNull( testing.Find( target, "set_PublicPropertyShouldNotShow", typeof( string ) ) );
                    Assert.IsNull( testing.Find( target, "set_PublicPropertyShouldNotShow", new[ ] { "value" } ) );
                    Assert.IsNull( testing.Find( target, "set_PublicPropertyShouldNotShow", "value" ) );

                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow" ) );
                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow", new { value = typeof( string ) } ) );
                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow", new[ ] { typeof( string ) } ) );
                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow", typeof( string ) ) );
                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow", new[ ] { "value" } ) );
                    Assert.IsNull( testing.Find( target, "set_PrivatePropertyShouldNotShow", "value" ) );

                }

            );
        }

        [TestMethod]
        public async Task ObjectMethodHas( )
        {
            var target = new MethodMethodsTestClass( );


            await Util.Tasks.Start(
                ( ) =>
                {
                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

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


                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

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

                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

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
                    var cacher = new Underscore.Function.CacheComponent();
                    var testing = new MethodComponent(cacher, new PropertyComponent(cacher));

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
    }
}
