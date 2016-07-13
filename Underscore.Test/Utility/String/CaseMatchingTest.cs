using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
	[TestFixture]
	public class CaseMatchingTest
	{
		private StringComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new StringComponent();
		}

		[Test]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_SingleWord()
		{
			const string input = "foo";

			Assert.IsTrue(component.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_MultiWord()
		{
			const string input = "fooBar";

			Assert.IsTrue(component.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasSpace()
		{
			const string input = "foo Bar";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_CapitalStartLetter()
		{
			const string input = "FooBar";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasNumber()
		{
			const string input = "fooBar1";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_SingleWord()
		{
			const string input = "Foo";

			Assert.IsTrue(component.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_MultiWord()
		{
			const string input = "FooBar";

			Assert.IsTrue(component.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_NotCapitalized()
		{
			const string input = "fooBar";

			Assert.IsFalse(component.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasNumber()
		{
			const string input = "FooBar1";

			Assert.IsFalse(component.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString_HasSpace()
		{
			const string input = "Foo Bar";

			Assert.IsFalse(component.IsPascalCase(input));
		}

		[Test]
		public void Utility_String_IsCapitalized_MatchesCapitalizedString()
		{
			const string input = "FooBar";

			Assert.IsTrue(component.IsCapitalized(input));
		}

		[Test]
		public void Utility_String_IsCapitalized_DoesNotMatchUncapitalizedString()
		{
			const string input = "fooBar";

			Assert.IsFalse(component.IsCapitalized(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_MatchesSnakeCaseString_OneWord()
		{
			const string input = "foo";

			Assert.IsTrue(component.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_MatchesSnakeCaseString_MultiWord()
		{
			const string input = "foo_bar";

			Assert.IsTrue(component.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_Capitalized()
		{
			const string input = "Foo";
		
			Assert.IsFalse(component.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasSpace()
		{
			const string input = "foo bar";

			Assert.IsFalse(component.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString_HasNonUnderscoreNonLetter()
		{
			const string input = "foo-bar";

			Assert.IsFalse(component.IsSnakeCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_MatchesKebabCaseString_OneWord()
		{
			const string input = "foo";

			Assert.IsTrue(component.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_MatchesKebabCaseString_MultiWord()
		{
			const string input = "foo-bar";

			Assert.IsTrue(component.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_Capitalized()
		{
			const string input = "Foo";

			Assert.IsFalse(component.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasSpace()
		{
			const string input = "foo bar";

			Assert.IsFalse(component.IsKebabCase(input));
		}

		[Test]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString_HasNonUnderscoreNonLetter()
		{
			const string input = "foo_bar";

			Assert.IsFalse(component.IsKebabCase(input));
		}
	}
}
