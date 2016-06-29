using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Collection.Implementation;

namespace Underscore.Test.Collection
{
	[TestClass]
	public class CompareTest
	{
		public class TestObject
		{
			public TestObject() { }

			public TestObject(TestObject toClone)
			{
				Value = toClone.Value;
				Nested = new TestNestedObject(toClone.Nested);
			}

			public int Value { get; set; }
			public TestNestedObject Nested { get; set; }
		}

		public class TestNestedObject
		{
			public TestNestedObject() { }

			public TestNestedObject(TestNestedObject toClone)
			{
				Value = toClone.Value;
				DeepNested = new TestDeepNestedObject(toClone.DeepNested);
			}

			public int Value { get; set; }
			public TestDeepNestedObject DeepNested { get; set; }
		}

		public class TestDeepNestedObject
		{
			public TestDeepNestedObject() { }

			public TestDeepNestedObject(TestDeepNestedObject toClone)
			{
				Value = toClone.Value;
			}

			public int Value { get; set; }
		}

		private CompareComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new CompareComponent();
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_StringArguments_SortedInput()
		{
			string[] input = { "a", "b", "c", "d", "e", "f" };
			Assert.IsTrue(component.IsSorted(input));
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_StringArguments_UnsortedInput()
		{
			string[] input = { "a", "b", "c", "z", "y", "x" };
			Assert.IsFalse(component.IsSorted(input));
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_IntArguments_SortedInput()
		{
			int[] input = { 1, 2, 3, 4, 5, 6 };
			Assert.IsTrue(component.IsSorted(input));
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_IntArguments_UnsortedInput()
		{
			int[] input = { 1, 2, 3, 6, 5, 4 };
			Assert.IsFalse(component.IsSorted(input));
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_Descending_SortedInput()
		{
			int[] input = { 6, 5, 4, 3, 2, 1 };
			Assert.IsTrue(component.IsSorted(input, true));
		}

		[TestMethod]
		public void Collection_Compare_IsSorted_Descending_UnsortedInput()
		{
			int[] input = { 1, 2, 3, 6, 5, 4 };
			Assert.IsFalse(component.IsSorted(input, true));
		}
	}
}
