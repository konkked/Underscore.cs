using NUnit.Framework;
using Underscore.Action;
namespace Underscore.Test.Module
{
	[TestFixture]
	public class ActionTest
	{
		[Test]
		public void ActionCreate()
		{
            var action = new Underscore.Module.Action(
                new BindComponent(),
                new PartialComponent(),
                new SplitComponent(),
                new CurryComponent(),
                new UncurryComponent(),
                new ComposeComponent(),
                new ApplyComponent(),
                new ConvertComponent(),
                new AfterComponent(
                    new Underscore.Function.AfterComponent(
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                        ),
                    new ConvertComponent()
                ),
                new BeforeComponent(
                    new Underscore.Function.ConvertComponent(),
                    new ConvertComponent(),
                    new Underscore.Function.BeforeComponent(
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                    )
                ),
                new DebounceComponent(
                    new Underscore.Function.DebounceComponent(
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                    ),
                    new ConvertComponent()
                ),
                new DelayComponent(
                    new Underscore.Function.DelayComponent(
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                    ),
                    new ConvertComponent()
                ),
                new OnceComponent(
                    new Underscore.Function.OnceComponent(
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                    ),
                    new Underscore.Function.ConvertComponent(),
                    new ConvertComponent()
                ),
                new ThrottleComponent(
                    new Underscore.Function.ThrottleComponent(
                        new Underscore.Utility.MathComponent(),
                        new Underscore.Function.CompactComponent(),
                        new Underscore.Utility.CompactComponent()
                    ),
                    new ConvertComponent()
                )
			);
		}
	}
}
