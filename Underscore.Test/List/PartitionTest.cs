using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.List;
using Underscore.Utility;

namespace Underscore.Test.List
{

    [TestClass]
    public class PartitionTest
    {
        private PartitionComponent _testing = new PartitionComponent(new MathComponent());
        private int[] _target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


        [TestMethod]
        public void List_Partition_Split()
        {
            var result = _testing.Split(_target);

            Assert.AreEqual(5, result.Item1.Count);
            Assert.AreEqual(5, result.Item2.Count);
            int ct = 0;

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(ct, result.Item1[i]);
                ct++;
            }

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(ct, result.Item2[i]);
                ct++;
            }

            result = _testing.Split(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

            Assert.AreEqual(6, result.Item1.Count);
            Assert.AreEqual(5, result.Item2.Count);

            ct = 0;

            for (int i = 0; i < 6; i++)
            {
                Assert.AreEqual(ct, result.Item1[i]);
                ct++;
            }

            for (int i = 0; i < 5; i++)
            {
                Assert.AreEqual(ct, result.Item2[i]);
                ct++;
            }

        }

        [TestMethod]
        public void List_Partition_Chunk_IntArg()
        {

            var result = _testing.Chunk(_target, 2);

            //testing even distribution
            Assert.AreEqual(5, result.Count());

            foreach (var coll in result)
                Assert.AreEqual(2, coll.Count());

            var chunk = result.First();

            Assert.AreEqual(0, chunk.First());
            Assert.AreEqual(1, chunk.Skip(1).First());

            chunk = result.Skip(1).First();

            Assert.AreEqual(2, chunk.First());
            Assert.AreEqual(3, chunk.Skip(1).First());

            chunk = result.Skip(2).First();

            Assert.AreEqual(4, chunk.First());
            Assert.AreEqual(5, chunk.Skip(1).First());

            chunk = result.Skip(3).First();

            Assert.AreEqual(6, chunk.First());
            Assert.AreEqual(7, chunk.Skip(1).First());

            chunk = result.Skip(4).First();

            Assert.AreEqual(8, chunk.First());
            Assert.AreEqual(9, chunk.Skip(1).First());

            result = _testing.Chunk(_target, 3);

            Assert.AreEqual(4, result.Count());

            chunk = result.First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(0, chunk.First());
            Assert.AreEqual(1, chunk.Skip(1).First());
            Assert.AreEqual(2, chunk.Skip(2).First());

            chunk = result.Skip(1).First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(3, chunk.First());
            Assert.AreEqual(4, chunk.Skip(1).First());
            Assert.AreEqual(5, chunk.Skip(2).First());

            chunk = result.Skip(2).First();

            Assert.AreEqual(3, chunk.Count());

            Assert.AreEqual(6, chunk.First());
            Assert.AreEqual(7, chunk.Skip(1).First());
            Assert.AreEqual(8, chunk.Skip(2).First());

            chunk = result.Skip(3).First();
            Assert.AreEqual(1, chunk.Count());
            Assert.AreEqual(9, chunk.First());

            result = _testing.Chunk(_target, 11);
            Assert.AreEqual(1, result.Count());

            chunk = result.First();
            Assert.AreEqual(10, chunk.Count());

            for (var i = 0; i < _target.Count(); i++)
            {
                Assert.AreEqual(_target.ElementAt(i), chunk.ElementAt(i));
            }
        }

        [TestMethod]
        public void List_Partition_Chunk_FuncArg()
        {
            var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testing = new PartitionComponent(new MathComponent());
            var result = testing.Chunk(target, a => a > 0 && a % 3 == 0);

            foreach (var chunk in result)
            {
                for (int i = 0; i < chunk.Count(); i++)
                {
                    Assert.AreEqual(i, chunk.ElementAt(i) % 3);
                }
            }

        }

        [TestMethod]
        public void List_Partition_Parition_IntArg()
        {

            for (int i = 0; i < _target.Count(); i++)
            {
                var result = _testing.Partition(_target, i);
                int j = 0;
                for (; j < i; j++)
                {
                    Assert.AreEqual(j, result.Item1.ElementAt(j));
                }

                for (; j < _target.Length; j++)
                {
                    Assert.AreEqual(j, result.Item2.ElementAt(j - i));
                }
            }
        }

        [TestMethod]
        public void List_Partition_Partition_FuncArg()
        {
            var result = _testing.Partition(_target, a => a > 0 && a % 3 == 0);

            Assert.AreEqual(3, result.Item1.Count());

            for (int i = 0; i < 3; i++)
                Assert.AreEqual(i, result.Item1.ElementAt(i));

            for (int i = 0; i < result.Item2.Count(); i++)
                Assert.AreEqual(i + 3, result.Item2.ElementAt(i));

        }

        [TestMethod]
        public void List_Partition_PartitionMatches()
        {
            var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var testing = new PartitionComponent(new MathComponent());
            var result = testing.PartitionMatches(target, n => n % 2 == 0);

            var leftExpected = new[] { 0, 2, 4, 6, 8 };
            var rightExpected = new[] { 1, 3, 5, 7, 9 };

            var leftResult = result.Item1.ToList();
            var rightResult = result.Item2.ToList();

            for (var i = 0; i < leftExpected.Length; i++)
            {
                Assert.AreEqual(leftExpected[i], leftResult[i]);
            }

            for (var i = 0; i < rightExpected.Length; i++)
            {
                Assert.AreEqual(rightExpected[i], rightResult[i]);
            }
        }


        [TestMethod]
        public void List_Partition_SlicePostiveForward()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length < list length 
            // positive 
            // forward 
            var slice = partitioner.Slice(ls, 0, 3);

            // result should be 0 , 1 , 2 , 3
            Assert.IsTrue(slice.SequenceEqual(new[] { 0, 1, 2, 3 }));

        }

        [TestMethod]
        public void List_Parition_Slice_SingleItem()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //slice of one
            Assert.IsTrue(partitioner.Slice(ls, 0, 0).SequenceEqual(new[] { 0 }));

        }

        [TestMethod]
        public void List_Partition_Slice_NegativeForwardIndex()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative reverse slice
            Assert.IsTrue(partitioner.Slice(ls, -1, -2).SequenceEqual(new[] { 10, 9 }));

        }

        [TestMethod]
        public void List_Partition_Slice_NegativeBackwards()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative slice
            Assert.IsTrue(partitioner.Slice(ls, -2, -1).SequenceEqual(new[] { 9, 10 }));

        }

        [TestMethod]
        public void List_Partition_Slice_PostiveBackwards()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length
            // positive 
            // backwards
            // result should be 3 , 2 , 1 , 0
            Assert.IsTrue(partitioner.Slice(ls, 3, 0).SequenceEqual(new[] { 3, 2, 1, 0 }));

        }

        [TestMethod]
        public void List_Partition_Slice_PostiveForwardsOverflow()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // positive
            // forward
            // result should be 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4
            Assert.IsTrue(
                partitioner.Slice(ls, 3, 15, true).SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4 }));

        }

        [TestMethod]
        public void List_Partition_Slice_PostiveBackwardsOverflow()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // positive
            // backwards
            Assert.IsTrue(
                partitioner.Slice(ls, 15, 3, true).SequenceEqual(new[] { 4, 3, 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3 }));



        }

        [TestMethod]
        public void List_Partition_NegativeForwardOverflow()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length > list length
            // negative 
            // forward
            // should be
            // 10,0,1,2,3,4,5,6,7,8,9,10,0,1,2
            Assert.IsTrue(
                partitioner.Slice(ls, -12, 2, true).SequenceEqual(new[] { 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2 }));

        }

        [TestMethod]
        public void List_Partition_NegativeBackwardsOverflow()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            // should be
            // 2 ,1,0,10,9,8,7,6,5,4,3,2,1,0,10
            Assert.IsTrue(
                partitioner.Slice(ls, 2, -12, true).SequenceEqual(new[] { 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10 }));

        }

        public void List_Partition_LargeLists()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 0, 1000, true);

            Assert.AreEqual(slice.Count, 1001);

            slice = partitioner.Slice(ls, 0, 10000, true);
            Assert.AreEqual(slice.Count, 10001);

            slice = partitioner.Slice(ls, 0, 100000, true);
            Assert.AreEqual(slice.Count, 100001);

            slice = partitioner.Slice(ls, 0, -1000000, true);
            Assert.AreEqual(slice.Count, 1000001);


        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void List_Partition_Slice_StartIndexTooLarge()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 10000, 0);

            Assert.Fail("Should have thrown exception");
        }



        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void List_Partition_Slice_StartIndexTooSmall()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, -10000, 0);

            Assert.Fail("Should have thrown exception");
        }




        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void List_Partition_Slice_EndIndexTooLarge()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 0, 100000);

            Assert.Fail("Should have thrown exception");
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void List_Partition_Slice_EndIndexTooSmall()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 0, -100000);

            Assert.Fail("Should have thrown exception");
        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_Slice_NonMatchingIndexes()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 0, -1);

            Assert.Fail("Should have thrown exception");
        }


        [TestMethod]
        public void List_Paritition_Combinations_Unit()
        {
            var testing = new PartitionComponent(new MathComponent());

            int[] stuff = { 1, 2, 3, 4 };

            int[][] expecting = new[]
            {
                new int[] {},
                new[] {1},
                new[] {1, 2},
                new[] {2},
                new[] {1, 2, 3},
                new[] {2, 3},
                new[] {1, 3},
                new[] {3},
                new[] {1, 2, 3, 4},
                new[] {1, 2, 4},
                new[] {1, 3, 4},
                new[] {2, 3, 4},
                new[] {3, 4},
                new[] {2, 4},
                new[] {1, 4},
                new[] {4}
            };

            var permutation = testing.Combinations(stuff).Select(a => a.ToList()).ToList();

            Assert.IsTrue(
                expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
        }

    }
}















