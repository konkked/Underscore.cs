using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Function;

namespace Underscore.Test.Module
{
	[TestClass]
	public class FunctionTest
	{
		[TestMethod]
		public void FunctionModuleCreateTest()
		{
			var testing = new Underscore.Module.Function(
				 new BindComponent(),
				 new SplitComponent(),
				 new ComposeComponent(),
				 new ConvertComponent(),
				 new SynchComponent(),
				 new CacheComponent(),
				 new BooleanComponent()
			);
		}
	}
}
