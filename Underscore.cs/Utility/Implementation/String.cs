﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Underscore.Utility
{
	public class StringComponent : IStringComponent
	{
		public string ToCamelCase(string s)
		{
			throw new NotImplementedException();
		}

		public bool IsCamelCase(string s)
		{
			// starts with a lowercase letter and contains no non-letters
			const string pattern = @"^[a-z][a-zA-Z]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string ToPascalCase(string s)
		{
			throw new NotImplementedException();
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
			throw new NotImplementedException();
		}

		public bool IsSnakeCase(string s)
		{
			// must start with a lowercase letter and only contain lowercase letters and underscores
			const string pattern = @"^[a-z]+[a-z_]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string ToKebabCase(string s)
		{
			throw new NotImplementedException();
		}

		public bool IsKebabCase(string s)
		{
			// must start with a lowercase letter and only contain lowercase letters and hypens
			const string pattern = @"^[a-z]+[a-z\-]*$";

			return Regex.IsMatch(s, pattern);
		}

		public string ToStartCase(string s)
		{
			throw new NotImplementedException();
		}

		public bool IsStartCase(string s)
		{
			// each word must be a capitalized letter-only string
			const string wordPattern = @"^[A-Z]([a-z]|[A)*$";

			return s.Split(' ').All(word => Regex.IsMatch(word, wordPattern));
		}

		public IEnumerable<string> Words(string s)
		{
			const string containsLettersPattern = @"[\l\L]+";
			const string isLetterPattern = @"^[\l\L]+$";
			return s.Split(' ')
				.Where(word => Regex.IsMatch(word, containsLettersPattern)) // only bother with strings that have letters in them
				.Select(word => 
					word.Where(c => Regex.IsMatch(word, isLetterPattern)) // filter each word to only have letters
					.Aggregate("", (curr, next) => curr + next)); // rejoin back into full strings
		}
	}
}
