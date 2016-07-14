using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Underscore.Utility
{
	public class StringComponent : IStringComponent
	{
		public string ToCamelCase(string s)
		{
			// convert it to snake_case as a baseline
			var toConvert = Normalize(s);
			var chars = toConvert.ToCharArray();
			var output = "";

			for (var i = 0; i < chars.Length; i++)
			{
				if (chars[i] == '_')
				{
					output += chars[i + 1].ToString().ToUpper();

					// skip the next character since we added it already
					i++;
				}
				else
				{
					output += chars[i];
				}
			}

			return output;
		}

		public bool IsCamelCase(string s)
		{
			// starts with a lowercase letter and contains no non-letters
			const string pattern = @"^[a-z][a-zA-Z]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string ToPascalCase(string s)
		{
			// convert it to snake_case as a baseline
			var toConvert = Normalize(s);

			return toConvert.Substring(0, 1).ToUpper() + ToCamelCase(toConvert.Substring(1));
		}

		public bool IsPascalCase(string s)
		{
			// starts with an uppercase letter and contains no non-letters
			const string pattern = @"^[A-Z][a-zA-Z]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string Capitalize(string s)
		{
			if (string.IsNullOrWhiteSpace(s))
				return s;

			if (s.Length == 1)
				return s.ToUpper();

			return s.Substring(0, 1).ToUpper() + s.Substring(1);
		}

		public bool IsCapitalized(string s)
		{
			return !string.IsNullOrWhiteSpace(s) && s.Substring(0, 1).ToUpper() == s.Substring(0, 1);
		}

		public string ToSnakeCase(string s)
		{
			if (IsSnakeCase(s))
				return s;
			if (IsCamelCase(s))
				return CamelToSnake(s);
			if (IsPascalCase(s))
				return PascalToSnake(s);
			if (IsKebabCase(s))
				return KebabToSnake(s);
			
			return OtherToSnake(s);
		}

		private string CamelToSnake(string s)
		{
			var output = "";
			var chars = s.ToCharArray();

			foreach (var c in chars)
			{
				if (IsUpper(c))
				{
					output += "_" + c.ToString().ToLower();
				}
				else
					output += c;
			}

			return output;
		}

		private string PascalToSnake(string s)
		{
			// take off first char since it's supposed to be capitalized
			var output = s.Substring(0, 1).ToLower();

			// treat the rest like it's camelCase since the only difference is the first letter
			return output + CamelToSnake(s.Substring(1));
		}

		private string KebabToSnake(string s)
		{
			// only difference is that kebab uses - instead of _
			return s.Replace('-', '_');
		}

		private string OtherToSnake(string s)
		{
			// since this isn't a normally defined type, we're going to do the following:
			// make it all lowercase
			// treat ' ', '.', '-', ',', '/', and '\' as delimiters
			const string pattern = @"[.\-,/\\\s]";
			var regex = new Regex(pattern);
			return regex.Replace(s.ToLower(), "_");
		}

		public bool IsSnakeCase(string s)
		{
			// must start with a lowercase letter and only contain lowercase letters and underscores
			const string pattern = @"^[a-z]+[a-z_]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string ToKebabCase(string s)
		{
			// normalize to snake case and replace underscores with hyphens
			return Normalize(s).Replace('_', '-');
		}

		public bool IsKebabCase(string s)
		{
			// must start with a lowercase letter and only contain lowercase letters and hypens
			const string pattern = @"^[a-z]+[a-z\-]*$";

			return Regex.IsMatch(s, pattern);
		}

		public IEnumerable<string> Words(string s)
		{
			// filter for words that contain letters,
			// then filter non-letters out of those words
			return s.Split(' ').Where(ContainsLetters).Select(FilterForLetters);
		}

		private string FilterForLetters(string s)
		{
			var chars = s.ToCharArray();

			return chars.Where(IsLetter).Aggregate("", (curr, next) => curr + next);
		}

		private bool ContainsLetters(string s)
		{
			const string pattern = @"[a-zA-Z]+";

			return Regex.IsMatch(s, pattern);
		}

		private bool IsLetter(char c)
		{
			const string pattern = @"^[a-zA-Z]$";

			return Regex.IsMatch(c.ToString(), pattern);
		}

		private bool IsLower(char c)
		{
			const string pattern = @"^[a-z]$";

			return Regex.IsMatch(c.ToString(), pattern);
		}

		private bool IsUpper(char c)
		{
			const string pattern = @"^[A-Z]$";

			return Regex.IsMatch(c.ToString(), pattern);
		}

		/// <summary>
		/// normalize a string to snake_case, 
		/// that way we only need to write
		/// one conversion for every other casing
		/// 
		/// snake case was chosen because snake and kebab case
		/// are the easiest to convert out of
		/// </summary>
		private string Normalize(string s)
		{
			return ToSnakeCase(s);
		}
	}
}
