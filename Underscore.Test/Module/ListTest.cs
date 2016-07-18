using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Underscore.List;

namespace Underscore.Test.Module
{
	[TestClass]
	public class ListTest
	{
		[TestMethod]
		public void List_CreateModule()
		{
			var result = new global::Underscore.Module.List(
				new ManipulateComponent(),
				new Underscore.List.PartitionComponent()
			);
		}

		[TestMethod]
		[ExpectedException(typeof (ArgumentNullException))]
		public void List_CreateModule_MissingManipulateComponent()
		{
			try
			{
				var result = new Underscore.Module.List(null, new Underscore.List.PartitionComponent());
			}
			catch (ArgumentNullException e)
			{
				if (e.ParamName != "manipulator")
					Assert.Fail("ParmName should have been manipulator");
				else
					throw;
			}

			Assert.Fail("List create should have thrown an exception about the missing manipulate component");
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void List_CreateModule_MissingPartitionComponent()
		{
			try
			{
				var result = new Underscore.Module.List(new ManipulateComponent(), null);
			}
			catch (ArgumentNullException e)
			{
				if (e.ParamName != "partitioner")
					Assert.Fail("ParmName should have been partitioner");
				else
					throw;
			}

			Assert.Fail("List create should have thrown an exception about the missing partitioner component");
		}
	}
}
