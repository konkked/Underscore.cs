using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Module
{
	[TestClass]
	public class UtilityTest
	{
		[TestMethod]
		public void CreateUtilityModuleTest( )
		{
			var result = new global::Underscore.Module.Utility(
				new FunctionComponent(),
				new MathComponent(),
				new ObjectComponent()
			);
		}
	}
}
