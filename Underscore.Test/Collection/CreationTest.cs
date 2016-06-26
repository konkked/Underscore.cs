using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection;

namespace Underscore.Test.Collection
{
    [TestClass]
    public class CreationTest
    {
	    private CreationComponent component;
	    private int[] target;

	    [TestInitialize]
	    public void Initialize()
	    {
		    component = new CreationComponent();
		    target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	    }

        [TestMethod]
        public void Collection_Creation_Snapshot()
        {
	        var expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			var result = component.Snapshot(target);
            var resultValue = result();

            Assert.IsTrue(target.SequenceEqual(resultValue));

            for (int i = 0; i < target.Length; i++)
                target[i] *= 2;

			resultValue = result();

			Assert.IsTrue(expected.SequenceEqual(resultValue));
        }

        [TestMethod]
        public void Collection_Creation_Extend()
        {
			var result = component.Extend(target, 20).ToList();

            Assert.AreEqual(20, result.Count);
            
            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(target[i % 10], result[i]);
            }

        }

        [TestMethod]
        public void Collection_Creation_Cycle()
        {
			var result = component.Cycle(target);

            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(target[i % 10], result.ElementAt(i));
            }
        }
    }
}
