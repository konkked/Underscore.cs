using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;

namespace Underscore.Test
{
    [TestClass]
    public class UnderscoreTest
    {
        [TestMethod]
        public void CreateUnderscore( )
        {
            // initial call will trigger static constructor
            var objects = _.Object;
            var action = _.Action;
            var function = _.Function;
            var lists = _.List;
            var collections = _.Collection;
            var utility = _.Utility;
        }

        private class TestingProperties 
        {
            public string Property { get; set; }
        }

        private class TestingMethods
        {
            public string Method( string arg1, string arg2, string arg3 ) 
            {
                return string.Empty;
            }

            public void OtherMethod( string arg1, string arg2, string arg3 ) 
            {

            }
        }

        [TestMethod]
        public void BasicFunctionalObjectTest( )
        {
            // initial call will trigger static constructor
            var objects = _.Object;

            var resultProperties = _.Object.Property.All( new { FakeProperty = "value", FakeInt = 10 } );

            Assert.AreEqual( 2, resultProperties.Count( ) );
            Assert.IsNotNull( resultProperties.Select( a => a.Name == "FakeProperty" ) );
            Assert.IsNotNull( resultProperties.Select( a => a.Name == "FakeInt" ) );

            var resultMethods = _.Object.Method.All( new TestingProperties() );
            Assert.AreEqual( 0, resultMethods.Count( ) );

            var resultFields = _.Object.Field.All( new { ShouldShowNone = "Value" } );
            Assert.AreEqual( 0, resultFields.Count( ) );
            var target = new TestingMethods( );

            var query = _.Object.Method.Query( target, new { 
                @return = typeof(string),
                arg1 = typeof( string ), 
                arg2 = typeof( string ), 
                arg3 = typeof( string ) 
            } );

            Assert.AreEqual( 1, query.Count( ) );

            query = _.Object.Method.Query( target, new
            {
                arg1 = typeof( string ),
                arg2 = typeof( string ),
                arg3 = typeof( string )
            } );

            Assert.AreEqual( 2, query.Count( ) );
        }

        [TestMethod]
        public void BasicFunctionalUtilityTest( ) 
        {
            var utility = _.Utility;

            var testingConstant = "hi";
            var constantResult = utility.Constant( testingConstant );

            Assert.AreEqual( testingConstant, constantResult( ) );

            testingConstant = "hello";
            Assert.AreNotSame( testingConstant, constantResult( ) );


            var hashst = new HashSet<string>( );

            for ( int i=0 ; i < 1000 ; i++ )
                Assert.IsTrue( hashst.Add( utility.UniqueId( ) ) );

            for ( int i=0 ; i < 1000 ; i++ )
                Assert.IsTrue( hashst.Add( utility.UniqueId("TLA" ) ) );

            utility.Noop( );
            Assert.IsTrue( utility.IsTruthy( "astring" ) );
            Assert.IsTrue( utility.IsTruthy( 1 ) );
            Assert.IsTrue( utility.IsTruthy( -1 ) );
            Assert.IsTrue( utility.IsTruthy( 1.0 ) );
            Assert.IsTrue( utility.IsTruthy( -1.0 ) );
            Assert.IsTrue( utility.IsTruthy( 1.0m ) );
            Assert.IsTrue( utility.IsTruthy( -1.0m ) );
            Assert.IsTrue( utility.IsTruthy( new object()) );

            Assert.IsFalse( utility.IsTruthy( "" ) );
            Assert.IsFalse( utility.IsTruthy( " " ) );
            Assert.IsFalse( utility.IsTruthy( 0 ) );
            Assert.IsFalse( utility.IsTruthy( 0.0 ) );
            Assert.IsFalse( utility.IsTruthy( 0.0m ) );
            Assert.IsFalse( utility.IsTruthy( null ) );



        }


    }
}
