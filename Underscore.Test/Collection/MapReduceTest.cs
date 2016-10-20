using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Collection
{
    [TestFixture]
    public class MapReduceTest
    {
        private IEnumerable<int> _target;

        [SetUp]
        public void SetUp()
        {
            _target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        }

        [Test]
        public void Collection_MapReduce_Map_EnumerableWithItems()
        {
            var expected = new [] { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            var result = _.Collection.Map(_target, i => i*2);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void Collection_MapReduce_Map_EmptyEnumerable()
        {
            var expected = new int[0];
            var result = _.Collection.Map(new int [0], i => i * 2);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void Collection_Reduce_NoSeed_ValueType()
        {
            const int expected = 45;
            var result = _.Collection.Reduce(_target, (int total, int next) => total + next);
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Collection_Reduce_NoSeed_ReferenceType()
        {
            const int expected = 45;
            var result = _.Collection.Reduce(_target, (ReduceTester total, int next) => total.Add(next));

            Assert.AreEqual(expected, result.Value);
        }

        [Test]
        public void Collection_Reduce_WithSeed()
        {
            const string expected = "123456789";
            var result = _.Collection.Reduce(_target, "", (total, next) => total + next);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CollectionExtensions_MapReduce_Map_EnumerableWithItems()
        {
            var expected = new[] { 2, 4, 6, 8, 10, 12, 14, 16, 18 };
            var result = _target.Map(i => i * 2);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_MapReduce_Map_EmptyEnumerable()
        {
            var expected = new int[0];
            IEnumerable<int> target = new int[0];
            var result = target.Map(i => i * 2);

            Assert.IsTrue(expected.SequenceEqual(result));
        }

        [Test]
        public void CollectionExtensions_Reduce_NoSeed_ValueType()
        {
            const int expected = 45;
            var result = _target.Reduce((int total, int next) => total + next);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CollectionExtensions_Reduce_NoSeed_ReferenceType()
        {
            const int expected = 45;
            var result = _target.Reduce((ReduceTester total, int next) => total.Add(next));

            Assert.AreEqual(expected, result.Value);
        }

        [Test]
        public void CollectionExtensions_Reduce_WithSeed()
        {
            const string expected = "123456789";
            var result = _target.Reduce("", (total, next) => total + next);

            Assert.AreEqual(expected, result);
        }

        private class ReduceTester
        {
            public int Value { get; private set; }

            public ReduceTester()
            {
                Value = 0;
            }

            public ReduceTester Add(int n)
            {
                Value += n;

                return this;
            }
        }
    }
}
