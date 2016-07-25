using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Utility.String
{
	[TestClass]
	public class OtherStringTests
	{
		private StringComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new StringComponent();
		}

		[TestMethod]
		public void Utility_String_Words_OnlyLetters()
		{
			const string input = "colorless green ideas sleep furiously";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = component.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}

		[TestMethod]
		public void Utility_String_Words_OtherCharactersInWords()
		{
			const string input = "co;lorless. gre'en- ide-as= sle&ep+ furi$ously,";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = component.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}

		[TestMethod]
		public void Utility_String_Words_ContainsNonLetterWords()
		{
			const string input = "colorless ^ green & ideas ! sleep _ furiously .";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = component.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}
	}
}
