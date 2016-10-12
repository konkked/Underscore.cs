using NUnit.Framework;
using System.Linq;
using Underscore.Extensions;
using Underscore.Utility;

namespace Underscore.Test.Utility.String
{
	[TestFixture]
	public class OtherStringTests
	{
		[Test]
		public void Utility_String_Words_OnlyLetters()
		{
			const string input = "colorless green ideas sleep furiously";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = _.Utility.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}

		[Test]
		public void Utility_String_Words_OtherCharactersInWords()
		{
			const string input = "co;lorless. gre'en- ide-as= sle&ep+ furi$ously,";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = _.Utility.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}

		[Test]
		public void Utility_String_Words_ContainsNonLetterWords()
		{
			const string input = "colorless ^ green & ideas ! sleep _ furiously .";

			string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

			var result = _.Utility.Words(input);

			Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
		}

        [Test]
        public void UtilityExtensions_String_Words_OnlyLetters()
        {
            const string input = "colorless green ideas sleep furiously";

            string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

            var result = input.Words();

            Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
        }

        [Test]
        public void UtilityExtensions_String_Words_OtherCharactersInWords()
        {
            const string input = "co;lorless. gre'en- ide-as= sle&ep+ furi$ously,";

            string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

            var result = input.Words();

            Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
        }

        [Test]
        public void UtilityExtensions_String_Words_ContainsNonLetterWords()
        {
            const string input = "colorless ^ green & ideas ! sleep _ furiously .";

            string[] expected = { "colorless", "green", "ideas", "sleep", "furiously" };

            var result = input.Words();

            Assert.IsTrue(expected.SequenceEqual(result), "expected and result sequences are equal");
        }
    }
}
