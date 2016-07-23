using NUnit.Framework;
using Underscore.Utility;

namespace Underscore.Test.Module
{
	[TestFixture]
	public class UtilityTest
	{
		[Test]
		public void CreateUtilityModuleTest()
		{
			var result = new Underscore.Module.Utility(
                new CompactComponent(),
				new FunctionComponent(),
				new MathComponent(),
				new ObjectComponent(),
                new StringComponent()
			);
		}
	}
}
