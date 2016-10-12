using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
	[TestFixture]
	public class CreationTest
	{
	    private int[] _target;

	    [SetUp]
	    public void Initialize()
	    {
		    _target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
	    }

		[Test]
		public void Collection_Creation_Snapshot()
		{
	        var expected = new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			var result = _.Collection.Snapshot(_target);
			var resultValue = result();

			Assert.IsTrue(_target.SequenceEqual(resultValue));

			for (int i = 0; i < _target.Length; i++)
				_target[i] *= 2;

			resultValue = result();

			Assert.IsTrue(expected.SequenceEqual(resultValue));
		}

		[Test]
		public void Collection_Creation_Extend()
		{
			var result = _.Collection.Extend(_target, 20).ToList();

			Assert.AreEqual(20, result.Count);
			
			for (int i = 0; i < result.Count; i++)
			{
				Assert.AreEqual(_target[i % 10], result[i]);
			}

		}

		[Test]
		public void Collection_Creation_Cycle()
		{
			var result = _.Collection.Cycle(_target);

			for (int i = 0; i < 1000; i++)
			{
				Assert.AreEqual(_target[i % 10], result.ElementAt(i));
			}
		}

        [Test]
        public void CollectionExtensions_Creation_Snapshot()
        {
            var expected = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var result = _target.Select(x => x).Snapshot();
            var resultValue = result();

            Assert.IsTrue(_target.SequenceEqual(resultValue));

            for (int i = 0; i < _target.Length; i++)
                _target[i] *= 2;

            resultValue = result();

            Assert.IsTrue(expected.SequenceEqual(resultValue));
        }

        [Test]
        public void CollectionExtensions_Creation_Extend()
        {
            var result = _target.Select(x => x).Extend(20).ToList();

            Assert.AreEqual(20, result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(_target[i % 10], result[i]);
            }

        }

        [Test]
        public void CollectionExtensions_Creation_Cycle()
        {
            var result = _target.Select(x => x).Cycle();

            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(_target[i % 10], result.ElementAt(i));
            }
        }
    }
}
