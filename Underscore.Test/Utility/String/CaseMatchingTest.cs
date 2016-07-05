using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Underscore.Utility;

namespace Underscore.Test.Utility
{
	[TestClass]
	public class CaseMatchingTest
	{
		private StringComponent component;

		[TestInitialize]
		public void Initialize()
		{
			component = new StringComponent();
		}

		[TestMethod]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_SingleWord()
		{
			const string input = "foo";

			Assert.IsTrue(component.IsCamelCase(input));
		}

		[TestMethod]
		public void Utility_String_IsCamelCase_MatchesCamelCaseString_MultiWord()
		{
			const string input = "fooBar";

			Assert.IsTrue(component.IsCamelCase(input));
		}

		[TestMethod]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasSpace()
		{
			const string input = "foo Bar";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[TestMethod]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_CapitalStartLetter()
		{
			const string input = "FooBar";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[TestMethod]
		public void Utility_String_IsCamelCase_DoesNotMatchNonCamelCaseString_HasNumber()
		{
			const string input = "fooBar1";

			Assert.IsFalse(component.IsCamelCase(input));
		}

		[TestMethod]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_SingleWord()
		{
			const string input = "Foo";

			Assert.IsTrue(component.IsPascalCase(input));
		}

		[TestMethod]
		public void Utility_String_IsPascalCase_MatchesPascalCaseString_MultiWord()
		{
			const string input = "FooBar";

			Assert.IsTrue(component.IsPascalCase(input));
		}

		[TestMethod]
		public void Utility_String_IsPascalCase_DoesNotMatchNonPascalCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsCapitalized_MatchesCapitalizedString()
		{

		}

		[TestMethod]
		public void Utility_String_IsCapitalized_DoesNotMatchUncapitalizedString()
		{

		}

		[TestMethod]
		public void Utility_String_IsSnakeCase_MatchesSnakeCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsSnakeCase_DoesNotMatchNonSnakeCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsKebabCase_MatchesKebabCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsKebabCase_DoesNotMatchNonKebabCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsCStartCase_MatchesStartCaseString()
		{

		}

		[TestMethod]
		public void Utility_String_IsStartCase_DoesNotMatchNonStartCaseString()
		{

		}
	}
}
