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
                 new PartialComponent(),
                 new SplitComponent(),
                 new CurryComponent(),
                 new UncurryComponent(),
                 new ApplyComponent(),
                 new ComposeComponent(),
                 new ConvertComponent(),
                 new AfterComponent(
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
                 new BeforeComponent(
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
                 new DebounceComponent(
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
                 new DelayComponent(
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
                 new OnceComponent(
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
                 new ThrottleComponent(
                     new Underscore.Utility.MathComponent(),
                     new CompactComponent(),
                     new Underscore.Utility.CompactComponent()
                 ),
				 new CacheComponent(
					new CompactComponent(),
					new Underscore.Utility.CompactComponent()	 
				 ),
				 new AndComponent(),
                 new OrComponent(),
                 new NegateComponent()
			);
		}
	}
}
