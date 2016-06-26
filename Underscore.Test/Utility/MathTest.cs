using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
    [TestClass]
    public class MathTest
    {
        [TestMethod]
        public void MathCtor( )
        {
            var component = new MathComponent( );
        }


        [TestMethod]
        public void MathRandom( )
        {
            var component = new MathComponent( );
            //just check if works, randomness will have to be tested later
            var rand = component.Random( );

            var rand2 = component.Random( 10 );

            Assert.IsTrue( rand2 <= 10 );

            var rand3 = component.Random( 10, 20 );

            Assert.IsTrue( rand3 >= 10 && rand3 <= 20 );

        }


        [TestMethod]
        public void UtilityUnique( )
        {
            var component = new MathComponent( );

            var output = component.UniqueId( "prefix" );
            Assert.IsTrue( output.StartsWith( "prefix" ) );

            var hashset = new HashSet<string>();

            for ( int i=0 ; i < 30 ; i++ )
                Assert.IsTrue( hashset.Add( component.UniqueId( ) ) );

        }

    }
}
