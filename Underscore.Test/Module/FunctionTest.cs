using NUnit.Framework;
using Underscore.Function;

namespace Underscore.Test.Module
{
	[TestFixture]
	public class FunctionTest
	{
		[Test]
		public void FunctionModuleCreateTest()
		{
			var testing = new Underscore.Module.Function(
				 new BindComponent(),
				 new SplitComponent(),
				 new ComposeComponent(),
				 new ConvertComponent(),
				 new SynchComponent(
					 new CompactComponent(),
					 new Underscore.Utility.CompactComponent(),
					 new Underscore.Utility.MathComponent()
				 ),
				 new CacheComponent(
					new CompactComponent(),
					new Underscore.Utility.CompactComponent()	 
				 ),
				 new BooleanComponent()
			);
		}
	}
}
