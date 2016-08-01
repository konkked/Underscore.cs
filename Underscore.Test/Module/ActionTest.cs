using NUnit.Framework;
using BindComponent = Underscore.Action.BindComponent;
using ComposeComponent = Underscore.Action.ComposeComponent;
using ConvertComponent = Underscore.Action.ConvertComponent;
using SplitComponent = Underscore.Action.SplitComponent;
using SynchComponent = Underscore.Action.SynchComponent;

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
				new SplitComponent(),
				new ComposeComponent(),
				new SynchComponent(
					new Underscore.Function.SynchComponent(
						new Underscore.Function.CompactComponent(), 
						new Underscore.Utility.CompactComponent(), 
						new Underscore.Utility.MathComponent()
					),
					new ConvertComponent(),
					new Underscore.Function.ConvertComponent()
				),
				new ConvertComponent()
			);
		}
	}
}
