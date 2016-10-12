using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.List
{
	[TestFixture]
	public class Manipulate
	{
		[Test]
		public void List_Manipulate_Swap()
		{
			var arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			//reverse list in place
			for (int i = 0; i < 5; i++)
				_.List.Swap(arr, i, 9 - i);

			for (int i = 0; i <= 9; i++)
				Assert.AreEqual(9 - i, arr[i]);
		}

		[Test]
		public void List_Manipulate_Shuffle()
		{
			List<int> arr = Enumerable.Range(0, 100).ToList();
			
			//test shuffle 5 times, see how random is
			int comparisionCount = 0;

			for (int j = 0; j < 5; j++)
			{
				var container = new List<IList<int>>();

				for (int i = 0; i < 5; i++)
					container.Add(_.List.Shuffle(arr));

				comparisionCount = 0;
				// no more than 20 matching instances
				// this should suffice for randomness test
				for (int i = 0; i < arr.Count; i++)
				{
					var st = new HashSet<int>();
					for (int k = 0; k < container.Count; k++)
					{
						if (!st.Add(container[k][i]))
							comparisionCount++;
					}
				}
				if (comparisionCount < 25)
					break;

			}

			Assert.IsTrue(comparisionCount < 25);

			for (int i = 0; i < 5; i++)
			{
				List<int> cmp = Enumerable.Range(0, 100).ToList();

				_.List.Shuffle(arr, true);

				comparisionCount = 0;

				for (int j = 0; j < arr.Count; j++)
					if (arr[j] == cmp[j])
						comparisionCount++;

				if (comparisionCount < 15)
					break;
			}

			Assert.IsTrue(comparisionCount < 15);
		}

		[Test]
		public void List_Manipulate_Rotate()
		{
			var arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

			int shiftl = -3;

			//left shift
			_.List.Rotate(arr, shiftl);

			Assert.IsTrue(arr.SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 }));


			//right shift back to normal
			_.List.Rotate(arr, -shiftl);

			Assert.IsTrue(arr.SequenceEqual(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));


			var shiftr = 5;
			//right shift again
			_.List.Rotate(arr, shiftr);

			Assert.IsTrue(arr.SequenceEqual(new[] { 5, 6, 7, 8, 9, 0, 1, 2, 3, 4 }));



			shiftl = -12;
			//testing overflow shift
			//should be equiv to shift two left
			_.List.Rotate(arr, shiftl);
			Assert.IsTrue(arr.SequenceEqual(new[] { 7, 8, 9, 0, 1, 2, 3, 4, 5, 6 }));

			shiftr = 15;
			//should be equiv to shift two right
			_.List.Rotate(arr, shiftr);
			Assert.IsTrue(arr.SequenceEqual(new[] { 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 }));
		}

		[Test]
		public void List_Manipulate_Sample()
		{
			var target = Enumerable.Range(0, 100).ToList();

			IList<int> result = _.List.Sample(target);

			foreach (var i in result)
				Assert.IsTrue(i >= 0 && i < 100);

			result = _.List.Sample(target, 25);

			Assert.AreEqual(25, result.Count);

			foreach (var i in result)
				Assert.IsTrue(i >= 0 && i < 100);

			result = _.List.Sample(target, 25, true);

			var set = new HashSet<int>();

			Assert.AreEqual(25, result.Count);

			foreach (var i in result)
				Assert.IsTrue(set.Add(i));

			result = _.List.Sample(target, 200, false);
			Assert.AreEqual(200, result.Count);

			foreach (var i in result)
				Assert.IsTrue(i >= 0 && i < 100);

		}

		[Test]
		public void List_Manipulate_Extend()
		{
			var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			
			var result = _.List.Extend(target, 20).ToList();

			Assert.AreEqual(20, result.Count);

			for (int i = 0; i < result.Count; i++)
			{
				Assert.AreEqual(target[i % 10], result[i]);
			}
		}

		[Test]
		public void List_Manipulate_Cycle()
		{
			var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			
			var result = _.List.Cycle(target);

			for (int i = 0; i < 1000; i++)
			{
				Assert.AreEqual(target[i % 10], result.ElementAt(i));
			}
		}

        [Test]
        public void ListExtensions_Manipulate_Swap()
        {
            var arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //reverse list in place
            for (int i = 0; i < 5; i++)
                arr.Swap(i, 9 - i);

            for (int i = 0; i <= 9; i++)
                Assert.AreEqual(9 - i, arr[i]);
        }

        [Test]
        public void ListExtensions_Manipulate_Shuffle()
        {
            List<int> arr = Enumerable.Range(0, 100).ToList();

            //test shuffle 5 times, see how random is
            int comparisionCount = 0;

            for (int j = 0; j < 5; j++)
            {
                var container = new List<IList<int>>();

                for (int i = 0; i < 5; i++)
                    container.Add(arr.Shuffle());

                comparisionCount = 0;
                // no more than 20 matching instances
                // this should suffice for randomness test
                for (int i = 0; i < arr.Count; i++)
                {
                    var st = new HashSet<int>();
                    for (int k = 0; k < container.Count; k++)
                    {
                        if (!st.Add(container[k][i]))
                            comparisionCount++;
                    }
                }
                if (comparisionCount < 25)
                    break;

            }

            Assert.IsTrue(comparisionCount < 25);

            for (int i = 0; i < 5; i++)
            {
                List<int> cmp = Enumerable.Range(0, 100).ToList();

                arr.Shuffle(true);

                comparisionCount = 0;

                for (int j = 0; j < arr.Count; j++)
                    if (arr[j] == cmp[j])
                        comparisionCount++;

                if (comparisionCount < 15)
                    break;
            }

            Assert.IsTrue(comparisionCount < 15);
        }

        [Test]
        public void ListExtensions_Manipulate_Rotate()
        {
            var arr = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int shiftl = -3;

            //left shift
            arr.Rotate(shiftl);

            Assert.IsTrue(arr.SequenceEqual(new[] { 3, 4, 5, 6, 7, 8, 9, 0, 1, 2 }));
            
            //right shift back to normal
            arr.Rotate(-shiftl);

            Assert.IsTrue(arr.SequenceEqual(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }));

            var shiftr = 5;
            //right shift again
            arr.Rotate(shiftr);

            Assert.IsTrue(arr.SequenceEqual(new[] { 5, 6, 7, 8, 9, 0, 1, 2, 3, 4 }));

            shiftl = -12;
            //testing overflow shift
            //should be equiv to shift two left
            arr.Rotate(shiftl);
            Assert.IsTrue(arr.SequenceEqual(new[] { 7, 8, 9, 0, 1, 2, 3, 4, 5, 6 }));

            shiftr = 15;
            //should be equiv to shift two right
            arr.Rotate(shiftr);
            Assert.IsTrue(arr.SequenceEqual(new[] { 2, 3, 4, 5, 6, 7, 8, 9, 0, 1 }));
        }

        [Test]
        public void ListExtensions_Manipulate_Sample()
        {
            var target = Enumerable.Range(0, 100).ToList();

            IList<int> result = target.Sample();

            foreach (var i in result)
                Assert.IsTrue(i >= 0 && i < 100);

            result = target.Sample(25);

            Assert.AreEqual(25, result.Count);

            foreach (var i in result)
                Assert.IsTrue(i >= 0 && i < 100);

            result = target.Sample(25, true);

            var set = new HashSet<int>();

            Assert.AreEqual(25, result.Count);

            foreach (var i in result)
                Assert.IsTrue(set.Add(i));

            result = target.Sample(200, false);
            Assert.AreEqual(200, result.Count);

            foreach (var i in result)
                Assert.IsTrue(i >= 0 && i < 100);
        }

        [Test]
        public void ListExtensions_Manipulate_Extend()
        {
            var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = target.Extend(20).ToList();

            Assert.AreEqual(20, result.Count);

            for (int i = 0; i < result.Count; i++)
                Assert.AreEqual(target[i % 10], result[i]);
        }

        [Test]
        public void ListExtensions_Manipulate_Cycle()
        {
            var target = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var result = target.Cycle();

            for (int i = 0; i < 1000; i++)
            {
                Assert.AreEqual(target[i % 10], result.ElementAt(i));
            }
        }
    }
}