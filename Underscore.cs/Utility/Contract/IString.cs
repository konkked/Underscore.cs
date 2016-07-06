using System.Collections.Generic;

namespace Underscore.Utility
{
	public interface IStringComponent
	{
		string ToCamelCase(string s);

		bool IsCamelCase(string s);

		string ToPascalCase(string s);

		bool IsPascalCase(string s);

		string Capitalize(string s);

		bool IsCapitalized(string s);

		string ToSnakeCase(string s);

		bool IsSnakeCase(string s);

		string ToKebabCase(string s);

		bool IsKebabCase(string s);

		IEnumerable<string> Words(string s);
	}
}
