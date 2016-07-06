using System.Collections.Generic;

namespace Underscore.Utility
{
	public interface IStringComponent
	{
		/// <summary>
		/// Converts the given string to camelCase
		/// </summary>
		string ToCamelCase(string s);

		/// <summary>
		/// Checks if the given string is camelCase
		/// </summary>
		bool IsCamelCase(string s);

		/// <summary>
		/// Converts the given string to PascalCase
		/// </summary>
		string ToPascalCase(string s);

		/// <summary>
		/// Checks if a string is PascalCase
		/// </summary>
		bool IsPascalCase(string s);

		/// <summary>
		/// Capitalizes the first character of a string
		/// </summary>
		string Capitalize(string s);

		/// <summary>
		/// Checks if the first character of a string is capitalized
		/// </summary>
		bool IsCapitalized(string s);

		/// <summary>
		/// Converts a string to snake_case
		/// </summary>
		string ToSnakeCase(string s);

		/// <summary>
		/// Checks if a string is snake_case
		/// </summary>
		bool IsSnakeCase(string s);

		/// <summary>
		/// Converts a string to kebab-case
		/// </summary>
		string ToKebabCase(string s);

		/// <summary>
		/// Checks if a string is kebab-case
		/// </summary>
		bool IsKebabCase(string s);

		/// <summary>
		/// Converts a string into an enumerable of words,
		/// delimited via spaces. "words" that don't contain letters
		/// are removed, and non-letter characters are removed from
		/// each word
		/// </summary>
		IEnumerable<string> Words(string s);
	}
}
