

using NUnit.Framework;
using Underscore.Extensions;

namespace Underscore.Test.Utility
{
	[TestFixture]
	public class CaseMatchingTest
	{
		[Test]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_SingleWord()
		{
			const string input = "foo";

			Assert.IsTrue(_.Utility.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_MultiWord()
		{
			const string input = "fooBar";

			Assert.IsTrue(_.Utility.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasSpace()
		{
			const string input = "foo Bar";

			Assert.IsFalse(_.Utility.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_CapitalStartLetter()
		{
			const string input = "FooBar";

			Assert.IsFalse(_.Utility.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasNumber()
		{
			const string input = "fooBar1";

			Assert.IsFalse(_.Utility.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_SingleWord()
		{
			const string input = "Foo";

			Assert.IsTrue(_.Utility.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_MultiWord()
		{
			const string input = "FooBar";

			Assert.IsTrue(_.Utility.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_NotCapitalized()
		{
			const string input = "fooBar";

			Assert.IsFalse(_.Utility.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasNumber()
		{
			const string input = "FooBar1";

			Assert.IsFalse(_.Utility.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasSpace()
		{
			const string input = "Foo Bar";

			Assert.IsFalse(_.Utility.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsCapitalized_MatchesCapitalizedString()
		{
			const string input = "FooBar";

			Assert.IsTrue(_.Utility.IsCapitalized(input));
		}

		[Test]
		public void Utility_String_IsCapitalized_DoesNotMatchUncapitalizedString()
		{
			const string input = "fooBar";

			Assert.IsFalse(_.Utility.IsCapitalized(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_MatchesSnakeCaseString_OneWord()
		{
			const string input = "foo";

			Assert.IsTrue(_.Utility.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_MatchesSnakeCaseString_MultiWord()
		{
			const string input = "foo_bar";

			Assert.IsTrue(_.Utility.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_Capitalized()
		{
			const string input = "Foo";
		
			Assert.IsFalse(_.Utility.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasSpace()
		{
			const string input = "foo bar";

			Assert.IsFalse(_.Utility.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasNonUnderscoreNonLetter()
		{
			const string input = "foo-bar";

			Assert.IsFalse(_.Utility.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_MatchesKebabCaseString_OneWord()
		{
			const string input = "foo";

			Assert.IsTrue(_.Utility.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_MatchesKebabCaseString_MultiWord()
		{
			const string input = "foo-bar";

			Assert.IsTrue(_.Utility.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_Capitalized()
		{
			const string input = "Foo";

			Assert.IsFalse(_.Utility.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasSpace()
		{
			const string input = "foo bar";

			Assert.IsFalse(_.Utility.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasNonUnderscoreNonLetter()
		{
			const string input = "foo_bar";

			Assert.IsFalse(_.Utility.IsKebabCase(input));
		}

        [Test]
        public void UtilityExtensions_String_IsCamelCase_MatchesCamelCaseString_SingleWord()
        {
            const string input = "foo";

            Assert.IsTrue(input.IsCamelCase());
        }

        [Test]
        public void UtilityExtensions_String_IsCamelCase_MatchesCamelCaseString_MultiWord()
        {
            const string input = "fooBar";

            Assert.IsTrue(input.IsCamelCase());
        }

        [Test]
        public void UtilityExtensions_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasSpace()
        {
            const string input = "foo Bar";

            Assert.IsFalse(input.IsCamelCase());
        }

        [Test]
        public void UtilityExtensions_String_IsCamelCase_DoesNotMatchNonCamelCaseString_CapitalStartLetter()
        {
            const string input = "FooBar";

            Assert.IsFalse(input.IsCamelCase());
        }

        [Test]
        public void UtilityExtensions_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasNumber()
        {
            const string input = "fooBar1";

            Assert.IsFalse(input.IsCamelCase());
        }

        [Test]
        public void UtilityExtensions_String_IsPascalCase_MatchesPascalCaseString_SingleWord()
        {
            const string input = "Foo";

            Assert.IsTrue(input.IsPascalCase());
        }

        [Test]
        public void UtilityExtensions_String_IsPascalCase_MatchesPascalCaseString_MultiWord()
        {
            const string input = "FooBar";

            Assert.IsTrue(input.IsPascalCase());
        }

        [Test]
        public void UtilityExtensions_String_IsPascalCase_DoesNotMatchNonPascalCaseString_NotCapitalized()
        {
            const string input = "fooBar";

            Assert.IsFalse(input.IsPascalCase());
        }

        [Test]
        public void UtilityExtensions_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasNumber()
        {
            const string input = "FooBar1";

            Assert.IsFalse(input.IsPascalCase());
        }

        [Test]
        public void UtilityExtensions_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasSpace()
        {
            const string input = "Foo Bar";

            Assert.IsFalse(input.IsPascalCase());
        }

        [Test]
        public void UtilityExtensions_String_IsCapitalized_MatchesCapitalizedString()
        {
            const string input = "FooBar";

            Assert.IsTrue(input.IsCapitalized());
        }

        [Test]
        public void UtilityExtensions_String_IsCapitalized_DoesNotMatchUncapitalizedString()
        {
            const string input = "fooBar";

            Assert.IsFalse(input.IsCapitalized());
        }

        [Test]
        public void UtilityExtensions_String_IsSnakeCase_MatchesSnakeCaseString_OneWord()
        {
            const string input = "foo";

            Assert.IsTrue(input.IsSnakeCase());
        }

        [Test]
        public void UtilityExtensions_String_IsSnakeCase_MatchesSnakeCaseString_MultiWord()
        {
            const string input = "foo_bar";

            Assert.IsTrue(input.IsSnakeCase());
        }

        [Test]
        public void UtilityExtensions_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_Capitalized()
        {
            const string input = "Foo";

            Assert.IsFalse(input.IsSnakeCase());
        }

        [Test]
        public void UtilityExtensions_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasSpace()
        {
            const string input = "foo bar";

            Assert.IsFalse(input.IsSnakeCase());
        }

        [Test]
        public void UtilityExtensions_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasNonUnderscoreNonLetter()
        {
            const string input = "foo-bar";

            Assert.IsFalse(input.IsSnakeCase());
        }

        [Test]
        public void UtilityExtensions_String_IsKebabCase_MatchesKebabCaseString_OneWord()
        {
            const string input = "foo";

            Assert.IsTrue(input.IsKebabCase());
        }

        [Test]
        public void UtilityExtensions_String_IsKebabCase_MatchesKebabCaseString_MultiWord()
        {
            const string input = "foo-bar";

            Assert.IsTrue(input.IsKebabCase());
        }

        [Test]
        public void UtilityExtensions_String_IsKebabCase_DoesNotMatchNonKebabCaseString_Capitalized()
        {
            const string input = "Foo";

            Assert.IsFalse(input.IsKebabCase());
        }

        [Test]
        public void UtilityExtensions_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasSpace()
        {
            const string input = "foo bar";

            Assert.IsFalse(input.IsKebabCase());
        }

        [Test]
        public void UtilityExtensions_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasNonUnderscoreNonLetter()
        {
            const string input = "foo_bar";

            Assert.IsFalse(input.IsKebabCase());
        }
    }
}
