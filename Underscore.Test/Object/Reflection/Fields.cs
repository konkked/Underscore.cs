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
    public class FieldsTest
    {
        private class FieldMethodsTestClass
        {
            public string ShouldShowString;
            private string ShouldntShowString;

            public int ShouldShowInt;
            private int ShouldntShowInt;

            public string ShouldNotShowProperty { get; set; }
            private string ShouldNotShowPrivateProperty { get; set; }

            public void ShouldNotShow( ) { }
        }

        [TestMethod]
        public async Task ObjectFields( )
        {

            var target = new FieldMethodsTestClass( );

            var mkUtil = new Mock<global::Underscore.Function.ICacheComponent>( );

            var fields = typeof( FieldMethodsTestClass ).GetFields( BindingFlags.Public | BindingFlags.Instance );

            mkUtil.Setup( a => a.Memoize( It.IsAny<Func<Type, BindingFlags, IEnumerable<FieldInfo>>>( ) ) )
                .Returns( new Func<Type, BindingFlags, IEnumerable<FieldInfo>>( ( a, b ) => fields.AsEnumerable( ) ) );


            var testing = new FieldComponent( mkUtil.Object );

            var allPublicFields = testing.All( typeof( FieldMethodsTestClass ) );
            var allFieldsThatAreInts = testing.OfType( typeof( FieldMethodsTestClass ), typeof( int ) );
            var allFieldsThatAreStrings = testing.OfType( typeof( FieldMethodsTestClass ), typeof( string ) );

            await Util.Tasks.Start( ( ) =>
            {

                Assert.AreEqual( 2, allPublicFields.Count( ) );
                Assert.AreEqual( 1, allFieldsThatAreInts.Count( ) );
                Assert.AreEqual( 1, allFieldsThatAreStrings.Count( ) );

                Assert.AreEqual( 0, allPublicFields.Count( a => a.Name.StartsWith( "Shouldnt" ) ) );
                Assert.AreEqual( 0, allPublicFields.Count( a => a.FieldType == typeof( decimal ) ) );
                Assert.AreEqual( 0, allPublicFields.Count( a => a.FieldType == typeof( float ) ) );


            } );

        }

    }
}
