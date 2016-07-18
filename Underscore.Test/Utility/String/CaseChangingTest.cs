using NUnit.Framework;
using Underscore.Utility;

namespace Underscore.Test.Utility.String
{
	[TestFixture]
	public class CaseChangingTest
	{
		private StringComponent component;

		[SetUp]
		public void Initialize()
		{
			component = new StringComponent();
		}

        [Test]
        public void Capitalize_UncapitalizedString()
        {
            const string input = "hello, world!";
            const string expected = "Hello, world!";

            var result = _.Utility.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Capitalize_CapitalizedString()
        {
            const string input = "Hello, world!";
            const string expected = "Hello, world!";

            var result = _.Utility.Capitalize(input);

            Assert.AreEqual(expected, result);
        }

        [Test]
		public void Utility_String_ToCamelCase_FromSnakeCase()
		{
			const string input = "camel_case";
			const string expected = "camelCase";

			var result = _.Utility.ToCamelCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToCamelCase_FromKebabCase()
		{
			const string input = "camel-case";
			const string expected = "camelCase";

			var result = _.Utility.ToCamelCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToCamelCase_FromCamelCase()
		{
			const string input = "camelCase";
			const string expected = "camelCase";

			var result = _.Utility.ToCamelCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToCamelCase_FromPascalCase()
		{
			const string input = "CamelCase";
			const string expected = "camelCase";

			var result = _.Utility.ToCamelCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToCamelCase_FromOther()
		{
			const string input = "Camel,Case-This.Is Not";
			const string expected = "camelCaseThisIsNot";

			var result = _.Utility.ToCamelCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToPascalCase_FromSnakeCase()
		{
			const string input = "pascal_case";
			const string expected = "PascalCase";

			var result = _.Utility.ToPascalCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToPascalCase_FromKebabCase()
		{
			const string input = "pascal-case";
			const string expected = "PascalCase";

			var result = _.Utility.ToPascalCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToPascalCase_FromCamelCase()
		{
			const string input = "camelCase";
			const string expected = "CamelCase";

			var result = _.Utility.ToPascalCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToPascalCase_FromPascalCase()
		{
			const string input = "PascalCase";
			const string expected = "PascalCase";

			var result = _.Utility.ToPascalCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToPascalCase_FromOther()
		{
			const string input = "Pascal,Case-This.Is Not";
			const string expected = "PascalCaseThisIsNot";

			var result = _.Utility.ToPascalCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToSnakeCase_FromSnakeCase()
		{
			const string input = "snake_case";
			const string expected = "snake_case";

			var result = _.Utility.ToSnakeCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToSnakeCase_FromKebabCase()
		{
			const string input = "snake-case";
			const string expected = "snake_case";

			var result = _.Utility.ToSnakeCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToSnakeCase_FromCamelCase()
		{
			const string input = "snakeCase";
			const string expected = "snake_case";

			var result = _.Utility.ToSnakeCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToSnakeCase_FromPascalCase()
		{
			const string input = "SnakeCase";
			const string expected = "snake_case";

			var result = _.Utility.ToSnakeCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToSnakeCase_FromOther()
		{
			const string input = "Snake,Case-This.Is Not";
			const string expected = "snake_case_this_is_not";

			var result = _.Utility.ToSnakeCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToKebabCase_FromSnakeCase()
		{
			const string input = "kebab_case";
			const string expected = "kebab-case";

			var result = _.Utility.ToKebabCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToKebabCase_FromKebabCase()
		{
			const string input = "kebab-case";
			const string expected = "kebab-case";

			var result = _.Utility.ToKebabCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToKebabCase_FromCamelCase()
		{
			const string input = "kebabCase";
			const string expected = "kebab-case";

			var result = _.Utility.ToKebabCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToKebabCase_FromPascalCase()
		{
			const string input = "KebabCase";
			const string expected = "kebab-case";

			var result = _.Utility.ToKebabCase(input);

			Assert.AreEqual(expected, result);
		}

		[Test]
		public void Utility_String_ToKebabCase_FromOther()
		{
			const string input = "Kebab,Case-This.Is Not";
			const string expected = "kebab-case-this-is-not";

			var result = _.Utility.ToKebabCase(input);

			Assert.AreEqual(expected, result);
		}
	}
}
