using System;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.List
{

	[TestFixture]
	public class PartitionTest
	{
		private readonly int[] _target = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

		[Test]
		public void List_Partition_Split()
		{
			var result = _.List.Split(_target);

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

			result = _.List.Split(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 });

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

		[Test]
		public void List_Partition_Chunk_IntArg()
		{
			var result = _.List.Chunk(_target, 2);

			//testing even distribution

			foreach (var coll in result.Zip(new[] { new[] { 0, 1 }, new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 }, new[] { 8, 9 } }, Tuple.Create))
				Assert.IsTrue(coll.Item1.SequenceEqual(coll.Item2));

			//test overlapped
			result = _.List.Chunk(_target, 11);

			Assert.IsTrue(result.First().SequenceEqual(_target));
		}

		[Test]
		public void List_Partition_Chunk_FuncArg()
		{
			var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			
			var result = _.List.Chunk(target, a => a > 0 && a % 3 == 0);

			foreach (var chunk in result)
			{
				for (int i = 0; i < chunk.Count(); i++)
				{
					Assert.AreEqual(i, chunk.ElementAt(i) % 3);
				}
			}
		}

		[Test]
		public void List_Partition_Parition_IntArg()
		{
			for (int i = 0; i < _target.Count(); i++)
			{
				var result = _.List.Partition(_target, i);
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

		[Test]
		public void List_Partition_Partition_FuncArg()
		{
			var result = _.List.Partition(_target, a => a > 0 && a % 3 == 0);

			Assert.AreEqual(3, result.Item1.Count());

			for (int i = 0; i < 3; i++)
				Assert.AreEqual(i, result.Item1.ElementAt(i));

			for (int i = 0; i < result.Item2.Count(); i++)
				Assert.AreEqual(i + 3, result.Item2.ElementAt(i));
		}

		[Test]
		public void List_Partition_PartitionMatches()
		{
			var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			
			var result = _.List.PartitionMatches(target, n => n % 2 == 0);

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

		[Test]
		public void List_Partition_SlicePostiveForward()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// slice length < list length 
			// positive 
			// forward 
			var slice = _.List.Slice(ls, 0, 4);

			// result should be 0 , 1 , 2 , 3
			Assert.IsTrue(slice.SequenceEqual(new[] { 0, 1, 2, 3 }));
		}

		[Test]
		public void List_Partition_SlicePostiveForwardWithPositiveStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// slice length < list length 
			// positive 
			// forward 
			var slice = _.List.Slice(ls, 0, 8, 2);

			// result should be 0 , 2 , 4 , 6
			Assert.IsTrue(slice.SequenceEqual(new[] { 0, 2, 4, 6 }));
		}

		[Test]
		public void List_Partition_SlicePostiveForwardWithNegativeStepException()
		{
		    var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
				
		    // slice length < list length 
		    // positive 
		    // forward 
		    // this should throw an exception
			Assert.Throws<InvalidOperationException>(()=> _.List.Slice(ls, 0, 8, -2));
		}

		[Test]
		public void List_Parition_Slice_SingleItem()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			//slice of one
			Assert.IsTrue(_.List.Slice(ls, 0, 1).SequenceEqual(new[] { 0 }));
		}

		[Test]
		public void List_Partition_Slice_NegativeBackwardsStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//negative reverse slice
			Assert.IsTrue(_.List.Slice(ls, -1, -3).SequenceEqual(new[] { 10, 9 }));
		}

		[Test]
		public void List_Partition_Slice_NegativeBackwardsIndexWithNegativeStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//negative reverse slice
			Assert.IsTrue(_.List.Slice(ls, -1, -9, -2).SequenceEqual(new[] { 10, 8, 6, 4 }));
		}

		[Test]
		public void List_Partition_Slice_NegativeBackwardsIndexWithPositiveStep()
		{
			var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            
			Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, -1, -9, 2));
		}

		[Test]
		public void List_Partition_Slice_NegativeForwards()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			//negative slice
			Assert.IsTrue(_.List.Slice(ls, -3, -1).SequenceEqual(new[] { 8, 9 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveBackwards()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// slice length < list length
			// positive 
			// backwards
			// result should be 3 , 2 , 1 , 0
			Assert.IsTrue(_.List.Slice(ls, 4, 0).SequenceEqual(new[] { 4, 3, 2, 1 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveForwardsOverflow()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// slice length > list length
			// positive
			// forward
			// result should be 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4
			Assert.IsTrue(
                _.List.Slice(ls, 3, 16, true).SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveForwardsOverflowWithNegativeStep()
		{
			var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
		    
		    Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, 3, 16, -2, true));
		}

		[Test]
		public void List_Partition_Slice_PostiveForwardsOverflowWithPostiveStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// slice length > list length
			// positive
			// forward
			// result should be 3, 5, 7, 9, 0, 2, 4
			Assert.IsTrue(
                _.List.Slice(ls, 3, 16, 2, true).SequenceEqual(new[] { 3, 5, 7, 9, 0, 2, 4 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveBackwardsOverflow()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// slice length > list length
			// positive
			// backwards
			Assert.IsTrue(
                _.List.Slice(ls, 16, 3, true).SequenceEqual(new[] { 5, 4, 3, 2, 1, 0, 10, 9, 8, 7, 6, 5, 4 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveBackwardsOverflowWithNegativeStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// slice length > list length
			// positive
			// backwards
			Assert.IsTrue(
                _.List.Slice(ls, 16, 3, -2, true).SequenceEqual(new[] { 5, 3, 1, 10, 8, 6, 4 }));
		}

		[Test]
		public void List_Partition_Slice_PostiveBackwardsOverflowWithPostiveStep()
		{
			var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

			Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, 16, 3, 2, true));
		}

		[Test]
		public void List_Partition_NegativeForwardOverflow()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
			// slice length > list length
			// negative 
			// forward
			// should be
			// 10,0,1,2,3,4,5,6,7,8,9,10,0,1,2
			Assert.IsTrue(
                _.List.Slice(ls, -12, 3, true).SequenceEqual(new[] { 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2 }));
		}
        
		[Test]
		public void List_Partition_NegativeForwardOverflowWithPositiveStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
			// slice length > list length
			// negative 
			// forward
			Assert.IsTrue(
                _.List.Slice(ls, -12, 3, 2, true).SequenceEqual(new[] { 10, 1, 3, 5, 7, 9, 0, 2 }));
		}


		[Test]
		public void List_Partition_NegativeForwardOverflowWithNegativeStep()
		{
		    var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
			
		    // slice length > list length
		    // negative 
		    // forward
		    // backwards step
		    Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, -12, 3, -2, true));
		}

		[Test]
		public void List_Partition_NegativeBackwardsOverflow()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// slice length > list length
			// negative backwards
			// should be
			Assert.IsTrue(
                _.List.Slice(ls, 2, -13, true).SequenceEqual(new[] { 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10 }));
		}

	    [Test]
	    public void List_Partition_NegativeBackwardsOverflowWithPositiveStep()
	    {
	        var ls = new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
	        
			// slice length > list length
	        // negative backwards
	        Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, 2, -13, 2, true));
		}

		[Test]
		public void List_Partition_NegativeBackwardsOverflowWithNegativeStep()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			// slice length > list length
			// negative backwards
			// should be
			Assert.IsTrue(
                _.List.Slice(ls, 2, -13, -2, true).SequenceEqual(new[] { 2, 0, 9, 7, 5, 3, 1, 10 }));
		}

		[Test]
		public void List_Partition_LargeLists()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			var slice = _.List.Slice(ls, 0, 1000, true);

			Assert.AreEqual(slice.Count, 1000);

			slice = _.List.Slice(ls, 0, 10000, true);
			Assert.AreEqual(slice.Count, 10000);

			slice = _.List.Slice(ls, 0, 100000, true);
			Assert.AreEqual(slice.Count, 100000);

			slice = _.List.Slice(ls, 0, -1000000, true);
			Assert.AreEqual(slice.Count, 1000000);
		}

		[Test]
		public void List_Partition_Slice_StartIndexTooLarge()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			// no overflow means that this should throw an exception
		    Assert.Throws<IndexOutOfRangeException>(() => _.List.Slice(ls, 10000, 0));
		}

		[Test]
		public void List_Partition_Slice_StartIndexTooSmall()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			
		    Assert.Throws<IndexOutOfRangeException>(() => _.List.Slice(ls, -10000, 0));
		}

		[Test]
		public void List_Partition_Slice_EndIndexTooLarge()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			
			Assert.Throws<IndexOutOfRangeException>(() => _.List.Slice(ls, 0, 100000));
		}

		[Test]
		public void List_Partition_Slice_EndIndexTooSmall()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            
			Assert.Throws<IndexOutOfRangeException>(() => _.List.Slice(ls, 0, -100000));
		}

		[Test]
		public void List_Partition_Slice_NonMatchingIndexes()
		{
			var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

			Assert.Throws<InvalidOperationException>(() => _.List.Slice(ls, 0, -1));
		}

		[Test]
		public void List_Partition_Combinations_Unit()
		{
			int[] stuff = { 1, 2, 3, 4 };

			int[][] expecting =
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

			var permutation = _.List.Combinations(stuff).Select(a => a.ToList()).ToList();

			Assert.IsTrue(
				expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
		}

        [Test]
        public void ListExtensions_Partition_Split()
        {
            var result = _target.Split();

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

            result = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }.Split();

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

        [Test]
        public void ListExtensions_Partition_Chunk_IntArg()
        {
            var result = _target.Chunk(2);

            //testing even distribution

            foreach (var coll in result.Zip(new[] { new[] { 0, 1 }, new[] { 2, 3 }, new[] { 4, 5 }, new[] { 6, 7 }, new[] { 8, 9 } }, Tuple.Create))
                Assert.IsTrue(coll.Item1.SequenceEqual(coll.Item2));

            //test overlapped
            result = _.List.Chunk(_target, 11);

            Assert.IsTrue(result.First().SequenceEqual(_target));
        }

        [Test]
        public void ListExtensions_Partition_Chunk_FuncArg()
        {
            var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = target.Chunk(a => a > 0 && a % 3 == 0);

            foreach (var chunk in result)
            {
                for (int i = 0; i < chunk.Count(); i++)
                {
                    Assert.AreEqual(i, chunk.ElementAt(i) % 3);
                }
            }
        }

        [Test]
        public void ListExtensions_Partition_Parition_IntArg()
        {
            for (int i = 0; i < _target.Count(); i++)
            {
                var result = _target.Partition(i);
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

        [Test]
        public void ListExtensions_Partition_Partition_FuncArg()
        {
            var result = _target.Partition(a => a > 0 && a % 3 == 0);

            Assert.AreEqual(3, result.Item1.Count());

            for (int i = 0; i < 3; i++)
                Assert.AreEqual(i, result.Item1.ElementAt(i));

            for (int i = 0; i < result.Item2.Count(); i++)
                Assert.AreEqual(i + 3, result.Item2.ElementAt(i));
        }

        [Test]
        public void ListExtensions_Partition_PartitionMatches()
        {
            var target = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = target.PartitionMatches(n => n % 2 == 0);

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

        [Test]
        public void ListExtensions_Partition_SlicePostiveForward()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length 
            // positive 
            // forward 
            var slice = ls.Slice(0, 4);

            // result should be 0 , 1 , 2 , 3
            Assert.IsTrue(slice.SequenceEqual(new[] { 0, 1, 2, 3 }));
        }

        [Test]
        public void ListExtensions_Partition_SlicePostiveForwardWithPositiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length 
            // positive 
            // forward 
            var slice = ls.Slice(0, 8, 2);

            // result should be 0 , 2 , 4 , 6
            Assert.IsTrue(slice.SequenceEqual(new[] { 0, 2, 4, 6 }));
        }

        [Test]
        public void ListExtensions_Partition_SlicePostiveForwardWithNegativeStepException()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length 
            // positive 
            // forward 
            // this should throw an exception
            Assert.Throws<InvalidOperationException>(() => ls.Slice(0, 8, -2));
        }

        [Test]
        public void ListExtensions_Parition_Slice_SingleItem()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //slice of one
            Assert.IsTrue(ls.Slice(0, 1).SequenceEqual(new[] { 0 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_NegativeBackwardsStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative reverse slice
            Assert.IsTrue(ls.Slice(-1, -3).SequenceEqual(new[] { 10, 9 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_NegativeBackwardsIndexWithNegativeStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative reverse slice
            Assert.IsTrue(ls.Slice(-1, -9, -2).SequenceEqual(new[] { 10, 8, 6, 4 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_NegativeBackwardsIndexWithPositiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<InvalidOperationException>(() => ls.Slice(-1, -9, 2));
        }

        [Test]
        public void ListExtensions_Partition_Slice_NegativeForwards()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //negative slice
            Assert.IsTrue(ls.Slice(-3, -1).SequenceEqual(new[] { 8, 9 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveBackwards()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length < list length
            // positive 
            // backwards
            // result should be 3 , 2 , 1 , 0
            Assert.IsTrue(ls.Slice(4, 0).SequenceEqual(new[] { 4, 3, 2, 1 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveForwardsOverflow()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // positive
            // forward
            // result should be 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4
            Assert.IsTrue(
                ls.Slice(3, 16, true).SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2, 3, 4 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveForwardsOverflowWithNegativeStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<InvalidOperationException>(() => ls.Slice(3, 16, -2, true));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveForwardsOverflowWithPostiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // positive
            // forward
            // result should be 3, 5, 7, 9, 0, 2, 4
            Assert.IsTrue(
                ls.Slice(3, 16, 2, true).SequenceEqual(new[] { 3, 5, 7, 9, 0, 2, 4 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveBackwardsOverflow()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // positive
            // backwards
            Assert.IsTrue(
                ls.Slice(16, 3, true).SequenceEqual(new[] { 5, 4, 3, 2, 1, 0, 10, 9, 8, 7, 6, 5, 4 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveBackwardsOverflowWithNegativeStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // positive
            // backwards
            Assert.IsTrue(
                ls.Slice(16, 3, -2, true).SequenceEqual(new[] { 5, 3, 1, 10, 8, 6, 4 }));
        }

        [Test]
        public void ListExtensions_Partition_Slice_PostiveBackwardsOverflowWithPostiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<InvalidOperationException>(() => ls.Slice(16, 3, 2, true));
        }

        [Test]
        public void ListExtensions_Partition_NegativeForwardOverflow()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // negative 
            // forward
            // should be
            // 10,0,1,2,3,4,5,6,7,8,9,10,0,1,2
            Assert.IsTrue(
                ls.Slice(-12, 3, true).SequenceEqual(new[] { 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 0, 1, 2 }));
        }

        [Test]
        public void ListExtensions_Partition_NegativeForwardOverflowWithPositiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // negative 
            // forward
            Assert.IsTrue(
                ls.Slice(-12, 3, 2, true).SequenceEqual(new[] { 10, 1, 3, 5, 7, 9, 0, 2 }));
        }


        [Test]
        public void ListExtensions_Partition_NegativeForwardOverflowWithNegativeStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // negative 
            // forward
            // backwards step
            Assert.Throws<InvalidOperationException>(() => ls.Slice(-12, 3, -2, true));
        }

        [Test]
        public void ListExtensions_Partition_NegativeBackwardsOverflow()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            // should be
            Assert.IsTrue(
                ls.Slice(2, -13, true).SequenceEqual(new[] { 2, 1, 0, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1, 0, 10 }));
        }

        [Test]
        public void ListExtensions_Partition_NegativeBackwardsOverflowWithPositiveStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // slice length > list length
            // negative backwards
            Assert.Throws<InvalidOperationException>(() => ls.Slice(2, -13, 2, true));
        }

        [Test]
        public void ListExtensions_Partition_NegativeBackwardsOverflowWithNegativeStep()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // slice length > list length
            // negative backwards
            // should be
            Assert.IsTrue(
                ls.Slice(2, -13, -2, true).SequenceEqual(new[] { 2, 0, 9, 7, 5, 3, 1, 10 }));
        }

        [Test]
        public void ListExtensions_Partition_LargeLists()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var slice = ls.Slice(0, 1000, true);

            Assert.AreEqual(slice.Count, 1000);

            slice = ls.Slice(0, 10000, true);
            Assert.AreEqual(slice.Count, 10000);

            slice = ls.Slice(0, 100000, true);
            Assert.AreEqual(slice.Count, 100000);

            slice = ls.Slice(0, -1000000, true);
            Assert.AreEqual(slice.Count, 1000000);
        }

        [Test]
        public void ListExtensions_Partition_Slice_StartIndexTooLarge()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // no overflow means that this should throw an exception
            Assert.Throws<IndexOutOfRangeException>(() => ls.Slice(10000, 0));
        }

        [Test]
        public void ListExtensions_Partition_Slice_StartIndexTooSmall()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<IndexOutOfRangeException>(() => ls.Slice(-10000, 0));
        }

        [Test]
        public void ListExtensions_Partition_Slice_EndIndexTooLarge()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<IndexOutOfRangeException>(() => ls.Slice(0, 100000));
        }

        [Test]
        public void ListExtensions_Partition_Slice_EndIndexTooSmall()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<IndexOutOfRangeException>(() => ls.Slice(0, -100000));
        }

        [Test]
        public void ListExtensions_Partition_Slice_NonMatchingIndexes()
        {
            var ls = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Assert.Throws<InvalidOperationException>(() => ls.Slice(0, -1));
        }

        [Test]
        public void ListExtensions_Paritition_Combinations_Unit()
        {
            int[] stuff = { 1, 2, 3, 4 };

            int[][] expecting =
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

            var permutation = stuff.Combinations().Select(a => a.ToList()).ToList();

            Assert.IsTrue(
                expecting.Select(i => permutation.Any(a => a.Count == i.Length && a.All(i.Contains))).All(b => b));
        }
    }
}
