using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class Object
    {
        [TestMethod]
        public void ObjectCtor( )
        {
            var component = new ObjectComponent( );
        }


        [TestMethod]
        public void UtilityTruthy( )
        {
            var component = new ObjectComponent( );
            Assert.IsFalse( component.IsTruthy( "" ) );
            Assert.IsFalse( component.IsTruthy( false ) );
            Assert.IsFalse( component.IsTruthy( 0 ) );
            Assert.IsTrue( component.IsTruthy( 1 ) );
            Assert.IsTrue( component.IsTruthy( "any" ) );
            Assert.IsTrue( component.IsTruthy( true ) );
            Assert.IsTrue( component.IsTruthy( new object() ) );

        }


    }
}
