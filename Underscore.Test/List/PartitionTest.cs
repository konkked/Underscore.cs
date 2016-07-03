using System;
using System.Linq;
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

            foreach (var coll in result.Zip(new[] { new[] { 0, 1 }, new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 }, new[] { 8, 9 } }, Tuple.Create))
                Assert.IsTrue(coll.Item1.SequenceEqual(coll.Item2));

            //test overlapped
            result = _testing.Chunk(_target, 11);

            Assert.IsTrue(result.First().SequenceEqual(_target));

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
            var slice = partitioner.Slice(ls, 0, 4);

            // result should be 0 , 1 , 2 , 3
            Assert.IsTrue(slice.SequenceEqual(new[] { 0, 1, 2, 3 }));

        }

        [TestMethod]
        public void List_Partition_SlicePostiveForwardWithPositiveStep()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length < list length 
            // positive 
            // forward 
            var slice = partitioner.Slice(ls, 0, 8, 2);

            // result should be 0 , 2 , 4 , 6
            Assert.IsTrue(slice.SequenceEqual(new[] { 0, 2, 4, 6 }));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_SlicePostiveForwardWithNegativeStepException()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length < list length 
            // positive 
            // forward 
            // this should throw an exception
            var slice = partitioner.Slice(ls, 0, 8, -2);
            Assert.Fail("Should have thrown an exception");

        }

        [TestMethod]
        public void List_Parition_Slice_SingleItem()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //slice of one
            Assert.IsTrue(partitioner.Slice(ls, 0, 1).SequenceEqual(new[] { 0 }));

        }

        [TestMethod]
        public void List_Partition_Slice_NegativeBackwardsStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative reverse slice
            Assert.IsTrue(partitioner.Slice(ls, -1, -3).SequenceEqual(new[] { 10, 9 }));

        }


        [TestMethod]
        public void List_Partition_Slice_NegativeBackwardsIndexWithNegativeStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative reverse slice
            Assert.IsTrue(partitioner.Slice(ls, -1, -9, -2).SequenceEqual(new[] { 10, 8, 6, 4 }));

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_Slice_NegativeBackwardsIndexWithPositiveStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //should throw an exception
            partitioner.Slice(ls, -1, -9, 2);

        }

        [TestMethod]
        public void List_Partition_Slice_NegativeForwards()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative slice
            Assert.IsTrue(partitioner.Slice(ls, -3, -1).SequenceEqual(new[] { 8, 9 }));

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
            Assert.IsTrue(partitioner.Slice(ls, 4, 0).SequenceEqual(new[] { 4, 3, 2, 1 }));

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
                partitioner.Slice(ls, 3, 16, true).SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4 }));

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_Slice_PostiveForwardsOverflowWithNegativeStep()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // positive
            // forward
            // with negative step

            partitioner.Slice(ls, 3, 16, -2, true);


            Assert.Fail("Should have thrown an exception");

        }

        [TestMethod]
        public void List_Partition_Slice_PostiveForwardsOverflowWithPostiveStep()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // positive
            // forward
            // result should be 3, 5, 7, 9, 0, 2, 4
            Assert.IsTrue(
                partitioner.Slice(ls, 3, 16, 2, true).SequenceEqual(new[] { 3, 5, 7, 9, 0, 2, 4 }));

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
                partitioner.Slice(ls, 16, 3, true).SequenceEqual(new[] { 5, 4, 3, 2, 1, 0, 10, 9, 8, 7, 6, 5, 4 }));
        }

        [TestMethod]
        public void List_Partition_Slice_PostiveBackwardsOverflowWithNegativeStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // positive
            // backwards
            Assert.IsTrue(
                partitioner.Slice(ls, 16, 3, -2, true).SequenceEqual(new[] { 5, 3, 1, 10, 8, 6, 4 }));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_Slice_PostiveBackwardsOverflowWithPostiveStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            partitioner.Slice(ls, 16, 3, 2, true);

            Assert.Fail("Should have thrown an exception");
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
                partitioner.Slice(ls, -12, 3, true).SequenceEqual(new[] { 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2 }));

        }



        [TestMethod]
        public void List_Partition_NegativeForwardOverflowWithPositiveStep()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length > list length
            // negative 
            // forward
            Assert.IsTrue(
                partitioner.Slice(ls, -12, 3, 2, true).SequenceEqual(new[] { 10, 1, 3, 5, 7, 9, 0, 2 }));

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_NegativeForwardOverflowWithNegativeStep()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


            // slice length > list length
            // negative 
            // forward
            // backwards step
            partitioner.Slice(ls, -12, 3, -2, true);

            Assert.Fail("Should have thrown exception");

        }

        [TestMethod]
        public void List_Partition_NegativeBackwardsOverflow()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            // should be
            Assert.IsTrue(
                partitioner.Slice(ls, 2, -13, true).SequenceEqual(new[] { 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10 }));

        }



        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void List_Partition_NegativeBackwardsOverflowWithPositiveStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            partitioner.Slice(ls, 2, -13, 2, true);

            Assert.Fail("Should have thrown an exception");

        }



        [TestMethod]
        public void List_Partition_NegativeBackwardsOverflowWithNegativeStep()
        {

            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            // should be
            Assert.IsTrue(
                partitioner.Slice(ls, 2, -13, -2, true).SequenceEqual(new[] { 2, 0, 9, 7, 5, 3, 1, 10 }));

        }


        [TestMethod]
        public void List_Partition_LargeLists()
        {
            var partitioner = new PartitionComponent(new MathComponent());

            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = partitioner.Slice(ls, 0, 1000, true);

            Assert.AreEqual(slice.Count, 1000);

            slice = partitioner.Slice(ls, 0, 10000, true);
            Assert.AreEqual(slice.Count, 10000);

            slice = partitioner.Slice(ls, 0, 100000, true);
            Assert.AreEqual(slice.Count, 100000);

            slice = partitioner.Slice(ls, 0, -1000000, true);
            Assert.AreEqual(slice.Count, 1000000);

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