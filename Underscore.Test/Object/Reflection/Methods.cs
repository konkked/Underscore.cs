using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using Underscore.Object.Reflection;


namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class Methods
    {
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

        [TestMethod]
        public async Task MethodsAll( )
        {

            var target = new MethodMethodsTestClass( );

            IMethodComponent testing = SetupMethodsComponent();// = new Underscore.Object.Reflection.Methods()


            await Util.Tasks.Start(( ) =>
                {
                    var methods = testing.All( target );

                    var targetMethod = methods.FirstOrDefault( a => a.Name == "ShouldShowNoReturnValue" );
                    Assert.IsNotNull( targetMethod );

                    var results = methods.Where( a => a.Name == "ShouldShowNoReturnValue" );
                    Assert.AreEqual( 3, results.Count( a => a.Name == "ShouldShowNoReturnValue" ) );
                    //no param
                    var noRetMethods = results.Where(a=>a.ReturnType == typeof(void) ); 
                    Assert.IsNotNull( noRetMethods.FirstOrDefault(), "Missing no parametered method" );
                    //one param
                    Assert.AreEqual( 1, (
                        from m in noRetMethods
                        let parameters = m.GetParameters( )
                        where parameters.Count( ) == 1
                            && parameters.Count( a => a.ParameterType == typeof( string ) && a.Name == "arg" ) == 1
                            && m.ReturnType == typeof( void )
                        select m
                        ).Count( ),
                        "Missing single parametered method"
                    );
                    //two params
                    Assert.AreEqual( 1, (
                        from m in noRetMethods
                        let parameters = m.GetParameters( )
                        where parameters.Count( ) == 2
                            && parameters.Count( a => a.ParameterType == typeof( string ) && a.Name == "arg1" ) == 1
                            && parameters.Count( a => a.ParameterType == typeof( string ) && a.Name == "arg2" ) == 1
                            && m.ReturnType == typeof( void )
                        select m
                        ).Count( ),
                        "Missing double parametered method"
                    );

                    //no param string return type
                    targetMethod = methods.FirstOrDefault( a => a.Name == "ShouldShowStringReturnValue" );

                    Assert.IsNotNull( targetMethod );
                    Assert.AreEqual( 1, methods.Count( a => a.Name == "ShouldShowStringReturnValue" ) );
                    Assert.IsTrue(
                        targetMethod.ReturnType == typeof( string )
                        && targetMethod.GetParameters( ).Count( ) == 0
                    );

                    Assert.AreEqual( 4, methods.Count( ) );

                    //all methods with no params
                    methods = testing.Query( target, new { } );
                    targetMethod = methods.FirstOrDefault( a => a.Name == "ShouldShowNoReturnValue" );

                    Assert.AreEqual( 2, methods.Count( ) );

                    Assert.IsNotNull( methods.FirstOrDefault( a => a.Name == "ShouldShowNoReturnValue" ) );
                    Assert.AreEqual( 1, methods.Count( a => a.Name == "ShouldShowNoReturnValue" ) );

                    Assert.IsNotNull( methods.FirstOrDefault( a => a.Name == "ShouldShowStringReturnValue" ) );
                    Assert.AreEqual( 1, methods.Count( a => a.Name == "ShouldShowStringReturnValue" ) );


                    var singleParamTypeString1 = testing.Query( target, typeof( string ) );
                    var singleParamTypeString2 = testing.Query( target, new[ ] { typeof( string ) } );

                    Assert.IsTrue( singleParamTypeString1.Count( ) == 1 );
                    Assert.IsNotNull( singleParamTypeString1.FirstOrDefault( ) );

                    var targetingSingleParam = singleParamTypeString1.FirstOrDefault( );
                    Assert.IsTrue( targetingSingleParam.GetParameters( ).Count( ) == 1 && targetingSingleParam.GetParameters( ).Count( a => a.Name == "arg" && a.ParameterType == typeof( string ) ) == 1 );

                    Assert.AreEqual( singleParamTypeString1.FirstOrDefault( ), singleParamTypeString2.FirstOrDefault( ) );

                    var singleParamName1 = testing.Query( target, "arg" );
                    var singleParamName2 = testing.Query( target, new[ ] { "arg" } );

                    Assert.IsTrue( singleParamName1.Count( ) == 1 );
                    Assert.IsTrue( singleParamName2.Count( ) == 1 );

                    Assert.IsTrue(
                        singleParamName1.Count( a => a.GetParameters( ).Count( ) == 1
                        && a.GetParameters( ).Count( b => b.ParameterType == typeof( string ) && b.Name == "arg" ) == 1
                    ) == 1 );

                    Assert.AreEqual( singleParamName1.FirstOrDefault( ), singleParamName2.FirstOrDefault( ) );


                    var dblParamType = testing.Query( target, new[ ] { typeof( string ), typeof( string ) } );

                    Assert.AreEqual( 1, dblParamType.Count( ) );
                    targetMethod = dblParamType.FirstOrDefault( );

                    Assert.IsNotNull( targetMethod );
                    Assert.AreEqual( 1, dblParamType.Count( ) );
                    Assert.AreEqual( 2, targetMethod.GetParameters( ).Count( ) );

                    Assert.AreEqual( 1, targetMethod.GetParameters( ).Count( a => a.ParameterType == typeof( string ) && a.Name == "arg1" ) );
                    Assert.AreEqual( 1, targetMethod.GetParameters( ).Count( a => a.ParameterType == typeof( string ) && a.Name == "arg2" ) );

                    var dblParamName = testing.Query( target, new[ ] { "arg1", "arg2" } );
                    targetMethod = dblParamName.FirstOrDefault( );

                    Assert.IsNotNull( targetMethod );
                    Assert.AreEqual( 1, dblParamName.Count( ) );
                    Assert.AreEqual( 2, targetMethod.GetParameters( ).Count( ) );

                    Assert.AreEqual( 1, targetMethod.GetParameters( ).Count( a => a.ParameterType == typeof( string ) && a.Name == "arg1" ) );
                    Assert.AreEqual( 1, targetMethod.GetParameters( ).Count( a => a.ParameterType == typeof( string ) && a.Name == "arg2" ) );



                } );
        }

        private static Type Type<T>( T example ) 
        {
            return typeof( T );
        }

        private static IEnumerable<PropertyInfo> PropertiesOf<T>(T example ) 
        {
            return typeof( T ).GetProperties( BindingFlags.Instance | BindingFlags.Public );
        }

        private static void SetupAll<T>( Mock<IPropertyComponent> mock, T targeting  , IEnumerable<PropertyInfo> results) 
        {
            var hresults = results;
            mock.Setup(
                a => a.All( It.Is<object>(
                    b => ( b != null && b.GetType( ) == typeof( T ) )
                        || ( b != null && b.GetType( ) == typeof( Type ) && ( ( Type ) b ) == typeof( T ) )
                ) )
            ).Returns(hresults);
        }

        private IMethodComponent SetupMethodsComponent( )
        {
            // need to create an old school mock for this...might be an easier way 
            // but feel like this is the most clear way to do this

            var mock= new Mock<IPropertyComponent>();
            
            var empty= new{};
            SetupAll(mock, empty, PropertiesOf(empty) );

            var one = new{ arg = typeof(string) };
            SetupAll ( mock ,one , PropertiesOf ( one) );

            var two = new{ arg1 = typeof(string) , arg2 = typeof(string)};
            SetupAll ( mock ,two , PropertiesOf ( two ) );

            var mk = mock.Object;

            return new MethodComponent( new MockUtilFunctionComponent( ), mk);



        }
    }
}
