using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using Moq;
using System.Reflection;
using System.Linq;
using Underscore.Object.Reflection;

namespace Underscore.Test.Object.Reflection
{
    [TestClass]
    public class FieldTest
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
        public async Task ObjectFieldHasField( )
        {

            var target = new FieldMethodsTestClass( );



            var testing = new FieldComponent(new Underscore.Function.CacheComponent());


            await Util.Tasks.Start( ( ) =>
            {
                //test true one public string field
                //test no type
                //test with type
                //test not with wrong type
                //test not private method

                Assert.IsTrue( testing.Has( target, "ShouldShowString" ) );
                Assert.IsTrue( testing.Has( target, "ShouldShowString", typeof( string ) ) );
                Assert.IsFalse( testing.Has( target, "ShouldShowString", typeof( int ) ) );
                Assert.IsFalse( testing.Has( target, "ShouldntShowString" ) );
                Assert.IsFalse( testing.Has( target, "ShouldntShowString", typeof( string ) ) );

            }, ( ) =>
            {

                //test true one public int field
                //test no type
                //test with type
                //test not with wrong type
                //test not private method


                Assert.IsTrue( testing.Has( target, "ShouldShowInt" ) );
                Assert.IsTrue( testing.Has( target, "ShouldShowInt", typeof( int ) ) );
                Assert.IsFalse( testing.Has( target, "ShouldShowInt", typeof( string ) ) );
                Assert.IsFalse( testing.Has( target, "ShouldntShowInt" ) );
                Assert.IsFalse( testing.Has( target, "ShouldntShowInt", typeof( int ) ) );



            }, ( ) =>
            {

                //shouldnt show properties
                Assert.IsFalse( testing.Has( target, "ShouldNotShowProperty" ) );
                Assert.IsFalse( testing.Has( target, "ShouldNotShowProperty", typeof( int ) ) );
                Assert.IsFalse( testing.Has( target, "ShouldNotShowProperty", typeof( string ) ) );

            } );


        }

        [TestMethod]
        public async Task ObjectField( )
        {

            var target = new FieldMethodsTestClass( );



            var testing = new FieldComponent( new Underscore.Function.CacheComponent() );


            await Util.Tasks.Start( ( ) =>
            {
                //test true one public string field
                //test no type
                //test with type
                //test not with wrong type
                //test not private method

                var showFieldNoArgs = testing.Find( target, "ShouldShowString" );
                var showFieldTypeArgs = testing.Find( target, "ShouldShowString", typeof( string ) );
                var shouldNotShowFieldWrongArgs = testing.Find( target, "ShouldShowString", typeof( int ) );
                var shouldntShowFieldPrivate = testing.Find( target, "ShoulntShowString" );
                var shouldntShowFieldPrivateWrongType = testing.Find( target, "ShoulntShowString", typeof( string ) );

                Assert.IsNotNull( showFieldNoArgs );

                foreach ( var item in new[ ] { showFieldTypeArgs } )
                    Assert.AreEqual( showFieldNoArgs, item );

                foreach ( var item in new[ ] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType } )
                    Assert.IsNull( item );

            }, ( ) =>
            {

                //test true one public int field
                //test no type
                //test with type
                //test not with wrong type
                //test not private method

                var showFieldNoArgs = testing.Find( target, "ShouldShowInt" );
                var showFieldTypeArgs = testing.Find( target, "ShouldShowInt", typeof( int ) );
                var shouldNotShowFieldWrongArgs = testing.Find( target, "ShouldntShowInt", typeof( string ) );
                var shouldntShowFieldPrivate = testing.Find( target, "ShouldntShowInt" );
                var shouldntShowFieldPrivateWrongType = testing.Find( target, "ShouldintShowInt", typeof( string ) );

                Assert.IsNotNull( showFieldNoArgs );

                foreach ( var item in new[ ] { showFieldTypeArgs } )
                    Assert.AreEqual( showFieldNoArgs, item );

                foreach ( var item in new[ ] { shouldNotShowFieldWrongArgs, shouldntShowFieldPrivate, shouldntShowFieldPrivateWrongType } )
                    Assert.IsNull( item );



            }, ( ) =>
            {

                //test true no properties picked up


                //shouldnt show properties
                Assert.IsNull( testing.Find( target, "ShouldNotShowProperty" ) );
                Assert.IsNull( testing.Find( target, "ShouldNotShowProperty", typeof( int ) ) );
                Assert.IsNull( testing.Find( target, "ShouldNotShowProperty", typeof( string ) ) );

            } );

        }



    }
}
